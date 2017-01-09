using AiXiFan.Services;
using AiXiFan.Uwp.Collections;
using GalaSoft.MvvmLight;

namespace AiXiFan.Uwp.ViewModels
{
    public class CommentViewModel : ViewModelBase, INavigable
    {
        private readonly IAiXiFanService _aiXiFanService;

        private IncrementalCollection<object> _comments;

        public CommentViewModel(IAiXiFanService aiXiFanService)
        {
            _aiXiFanService = aiXiFanService;
        }

        public IncrementalCollection<object> Comments
        {
            get
            {
                return _comments;
            }
            private set
            {
                Set(ref _comments, value);
            }
        }

        public void Activate(object parameter)
        {
            var id = (int)parameter;
        }

        public void Deactivate(object parameter)
        {
        }
    }
}