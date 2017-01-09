using AiXiFan.Models;
using AiXiFan.Services;
using AiXiFan.Uwp.Collections;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Tools;

namespace AiXiFan.Uwp.ViewModels
{
    public class ArticleViewModel : ViewModelBase, INavigable
    {
        private const int PageSize = 20;

        private readonly IAiXiFanService _aiXiFanService;

        private readonly INavigationService _navigationService;

        private RelayCommand<ItemClickEventArgs> _articleClickCommand;

        private IncrementalCollection<SearchDataItem> _articles;

        private int _channelId;

        private int _pageNo;

        private Sort _selectedArticleSort;

        public ArticleViewModel(INavigationService navigationService, IAiXiFanService aiXiFanService)
        {
            _navigationService = navigationService;
            _aiXiFanService = aiXiFanService;
        }

        public RelayCommand<ItemClickEventArgs> ArticleClickCommand
        {
            get
            {
                _articleClickCommand = _articleClickCommand ?? new RelayCommand<ItemClickEventArgs>(args =>
                {
                    var article = (SearchDataItem)args.ClickedItem;
                    var contentId = int.Parse(article.ContentId);
                    _navigationService.NavigateTo(ViewModelLocator.ArticleDetailViewKey, contentId);
                });
                return _articleClickCommand;
            }
        }

        public IncrementalCollection<SearchDataItem> Articles
        {
            get
            {
                return _articles;
            }
            private set
            {
                Set(ref _articles, value);
            }
        }

        public IReadOnlyList<Sort> ArticleSorts
        {
            get;
        } = EnumExtensions.GetValues<Sort>();

        public IReadOnlyList<string> ArticleSubChannels
        {
            get;
        } = new[]
        {
            "工作‧情感",
            "动漫文化",
            "漫画‧小说",
            "综合",
            "游戏"
        };

        public Sort SelectedArticleSort
        {
            get
            {
                return _selectedArticleSort;
            }
            set
            {
                Set(ref _selectedArticleSort, value);
            }
        }

        public void Activate(object parameter)
        {
            _channelId = (int)parameter;
            _pageNo = 1;
            Articles = new IncrementalCollection<SearchDataItem>(LoadArticles);
        }

        public void Deactivate(object parameter)
        {
        }

        private async Task<IEnumerable<SearchDataItem>> LoadArticles()
        {
            try
            {
                var result = await _aiXiFanService.SearchAsync(_channelId, _pageNo, PageSize, SelectedArticleSort);
                if (result.Code == HttpStatusCode.OK)
                {
                    var items = result.Data.List;
                    _pageNo++;
                    return items;
                }
                else
                {
                    // TODO
                }
            }
            catch (HttpRequestException)
            {
                // TODO
            }
            return null;
        }
    }
}