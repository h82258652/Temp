using AiXiFan.Models;
using AiXiFan.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace AiXiFan.Uwp.ViewModels
{
    public class ChannelViewModel : ViewModelBase, INavigable
    {
        private readonly IAiXiFanService _aiXiFanService;

        private readonly INavigationService _navigationService;

        private ChannelData _channel;

        public ChannelViewModel(INavigationService navigationService, IAiXiFanService aiXiFanService)
        {
            _navigationService = navigationService;
            _aiXiFanService = aiXiFanService;
        }

        public ChannelData Channel
        {
            get
            {
                return _channel;
            }
            private set
            {
                Set(ref _channel, value);
            }
        }

        public void Activate(object parameter)
        {
            var channel = (ChannelData)parameter;
            Channel = channel;
        }

        public void Deactivate(object parameter)
        {
        }
    }
}