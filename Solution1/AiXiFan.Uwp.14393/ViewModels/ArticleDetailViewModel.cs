using AiXiFan.Services;
using AiXiFan.Uwp.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using System;
using System.Net;
using System.Net.Http;
using Windows.UI.Popups;

namespace AiXiFan.Uwp.ViewModels
{
    public class ArticleDetailViewModel : ViewModelBase, INavigable
    {
        private readonly IAiXiFanService _aiXiFanService;

        private readonly INavigationService _navigationService;

        private int _id;

        private RelayCommand _viewCommentCommand;

        public ArticleDetailViewModel(INavigationService navigationService, IAiXiFanService aiXiFanService)
        {
            _navigationService = navigationService;
            _aiXiFanService = aiXiFanService;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                Set(ref _id, value);
            }
        }

        public RelayCommand ViewCommentCommand
        {
            get
            {
                _viewCommentCommand = _viewCommentCommand ?? new RelayCommand(() =>
                {
                    _navigationService.NavigateTo(ViewModelLocator.CommentViewKey, Id);
                });
                return _viewCommentCommand;
            }
        }

        public async void Activate(object parameter)
        {
            Id = (int)parameter;
            try
            {
                var result = await _aiXiFanService.GetArticleAsync(Id);
                if (result.Code == HttpStatusCode.OK)
                {
                    var content = result.Data.Article.Content;
                    Messenger.Default.Send(new ArticleLoadedMessage(content));
                }
                else
                {
                    // TODO
                }
            }
            catch (HttpRequestException ex)
            {
                // TODO
                await new MessageDialog(ex.ToString()).ShowAsync();
            }
        }

        public void Deactivate(object parameter)
        {
        }
    }
}