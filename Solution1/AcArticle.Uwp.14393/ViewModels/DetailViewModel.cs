using AcArticle.Models;
using AcArticle.Services;
using AcArticle.Uwp.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Net;

namespace AcArticle.Uwp.ViewModels
{
    public class DetailViewModel : ViewModelBase, INavigable
    {
        private readonly IAcArticleService _acArticleService;

        private readonly INavigationService _navigationService;

        private SearchDataItem _articleItem;

        private RelayCommand _todoCommand;

        public DetailViewModel(INavigationService navigationService, IAcArticleService acArticleService)
        { 
            _navigationService = navigationService;
            _acArticleService = acArticleService;
        }

        public SearchDataItem ArticleItem
        {
            get
            {
                return _articleItem;
            }
            private set
            {
                if (_articleItem != value)
                {
                    Set(ref _articleItem, value);
                    LoadArticle();
                }
            }
        }

        public RelayCommand TODOCommand
        {
            get
            {
                _todoCommand = _todoCommand ?? new RelayCommand(() =>
                {
                    _navigationService.NavigateTo(ViewModelLocator.CommentViewKey);
                    // TODO
                });
                return _todoCommand;
            }
        }

        public void Activate(object parameter)
        {
            var articleItem = parameter as SearchDataItem;
            if (articleItem != null)
            {
                ArticleItem = articleItem;
            }
        }

        public void Deactivate(object parameter)
        {
        }

        private async void LoadArticle()
        {
            var articleResult = await _acArticleService.GetArticleDetailAsync(int.Parse(ArticleItem.ContentId));
            if (articleResult.Code == HttpStatusCode.OK)
            {
                MessengerInstance.Send(new ArticleContentLoadedMessage(articleResult.Data.Article.Content));
            }
            else
            {
                // TODO
            }
        }
    }
}