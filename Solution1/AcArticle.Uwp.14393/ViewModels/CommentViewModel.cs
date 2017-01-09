using AcArticle.Models;
using AcArticle.Services;
using AcArticle.Uwp.Adapters;
using GalaSoft.MvvmLight;
using Microsoft.Toolkit.Uwp;

namespace AcArticle.Uwp.ViewModels
{
    public class CommentViewModel : ViewModelBase, INavigable
    {
        private readonly IAcArticleService _acArticleService;

        private SearchDataItem _articleItem;

        private IncrementalLoadingCollection<ArticleCommentAdapter, ArticleComment> _comments;

        public CommentViewModel(IAcArticleService acArticleService)
        {
            _acArticleService = acArticleService;
        }

        public IncrementalLoadingCollection<ArticleCommentAdapter, ArticleComment> Comments
        {
            get
            {
                _comments = _comments ?? new IncrementalLoadingCollection<ArticleCommentAdapter, ArticleComment>(new ArticleCommentAdapter(_acArticleService, int.Parse(_articleItem.ContentId)));
                return _comments;
            }
        }

        public void Activate(object parameter)
        {
            var articleItem = parameter as SearchDataItem;
            if (articleItem != null)
            {
                _articleItem = articleItem;
            }
        }

        public void Deactivate(object parameter)
        {
        }
    }
}