using AcArticle.Models;
using AcArticle.Services;
using AcArticle.Uwp.Adapters;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using Microsoft.Toolkit.Uwp;
using System.Collections.Generic;
using System.Diagnostics;

namespace AcArticle.Uwp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IAcArticleService _acArticleService;

        private readonly INavigationService _navigationService;

        private RelayCommand<SearchDataItem> _articleItemClickCommand;

        private IReadOnlyDictionary<Channel, IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>> _articles;

        private RelayCommand<object> _refreshCommand;

        public MainViewModel(INavigationService navigationService, IAcArticleService acArticleService)
        {
            _navigationService = navigationService;
            _acArticleService = acArticleService;
        }

        public RelayCommand<SearchDataItem> ArticleItemClickCommand
        {
            get
            {
                _articleItemClickCommand = _articleItemClickCommand ?? new RelayCommand<SearchDataItem>(articleItem =>
                {
                    _navigationService.NavigateTo(ViewModelLocator.DetailViewKey, articleItem);
                });
                return _articleItemClickCommand;
            }
        }

        public IReadOnlyDictionary<Channel, IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>> Articles
        {
            get
            {
                _articles = _articles ?? new Dictionary<Channel, IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>>()
                {
                    {
                        Channel.Synthetical,
                        new IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>(new ArticleAdapter(_acArticleService, Channel.Synthetical))
                    },
                    {
                        Channel.WorkAndEmotion,
                        new IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>(new ArticleAdapter(_acArticleService, Channel.WorkAndEmotion))
                    },
                    {
                        Channel.ACGCulture,
                        new IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>(new ArticleAdapter(_acArticleService, Channel.ACGCulture))
                    },
                    {
                        Channel.ComicAndNovel,
                        new IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>(new ArticleAdapter(_acArticleService, Channel.ComicAndNovel))
                    },
                    {
                        Channel.Game,
                        new IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>(new ArticleAdapter(_acArticleService, Channel.Game))
                    }
                };
                return _articles;
            }
        }

        public RelayCommand<object> RefreshCommand
        {
            get
            {
                _refreshCommand = _refreshCommand ?? new RelayCommand<object>(articles =>
                {
                    var b = articles as IncrementalLoadingCollection<ArticleAdapter, SearchDataItem>;
                    Debug.Assert(b != null);
                    b.Clear();
                    // TODO
                });
                return _refreshCommand;
            }
        }
    }
}