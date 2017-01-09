using AiXiFan.Models;
using AiXiFan.Services;
using AiXiFan.Uwp.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Windows.UI.Popups;

namespace AiXiFan.Uwp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly IAiXiFanService _aiXiFanService;

        private readonly INavigationService _navigationService;

        private IReadOnlyList<RegionData> _article;

        private RelayCommand<RegionContent> _articleChannelClickCommand;

        private RelayCommand<RegionContent> _articleClickCommand;

        private RelayCommand _articleRefreshCommand;

        private RegionData _carouselsData;

        private RelayCommand<ChannelData> _channelClickCommand;

        private IReadOnlyList<ChannelData> _channels;

        private bool _isArticleLoading;

        private bool _isChannelLoading;

        private RelayCommand _refreshChannelCommand;

        private IReadOnlyDictionary<int, int> _updateCounts;

        public HomeViewModel(INavigationService navigationService, IAiXiFanService aiXiFanService)
        {
            _navigationService = navigationService;
            _aiXiFanService = aiXiFanService;
        }

        public IReadOnlyList<RegionData> Article
        {
            get
            {
                if (_article == null)
                {
                    LoadArticleRegion();
                }
                return _article;
            }
            private set
            {
                Set(ref _article, value);
            }
        }

        public RelayCommand<RegionContent> ArticleChannelClickCommand
        {
            get
            {
                _articleChannelClickCommand = _articleChannelClickCommand ?? new RelayCommand<RegionContent>(channel =>
                {
                    var channelId = int.Parse(channel.Url);
                    _navigationService.NavigateTo(ViewModelLocator.ArticleViewKey, channelId);
                });
                return _articleChannelClickCommand;
            }
        }

        public RelayCommand<RegionContent> ArticleClickCommand
        {
            get
            {
                _articleClickCommand = _articleClickCommand ?? new RelayCommand<RegionContent>(article =>
                {
                    var id = int.Parse(article.Url);
                    _navigationService.NavigateTo(ViewModelLocator.ArticleDetailViewKey, id);
                });
                return _articleClickCommand;
            }
        }

        public RelayCommand ArticleRefreshCommand
        {
            get
            {
                _articleRefreshCommand = _articleRefreshCommand ?? new RelayCommand(() =>
                {
                    // TODO
                });
                return _articleRefreshCommand;
            }
        }

        public RegionData CarouselsData
        {
            get
            {
                return _carouselsData;
            }
            private set
            {
                Set(ref _carouselsData, value);
            }
        }

        public RelayCommand<ChannelData> ChannelClickCommand
        {
            get
            {
                _channelClickCommand = _channelClickCommand ?? new RelayCommand<ChannelData>(channel =>
                {
                    // TODO 不导航某些 channel。
                    _navigationService.NavigateTo(ViewModelLocator.ChannelViewKey, channel);
                });
                return _channelClickCommand;
            }
        }

        public IReadOnlyList<ChannelData> Channels
        {
            get
            {
                if (_channels == null)
                {
                    LoadChannelsRegion();
                }
                return _channels;
            }
            private set
            {
                Set(ref _channels, value);
            }
        }

        public bool IsArticleLoading
        {
            get
            {
                return _isArticleLoading;
            }
            private set
            {
                Set(ref _isArticleLoading, value);
            }
        }

        public bool IsChannelLoading
        {
            get
            {
                return _isChannelLoading;
            }
            private set
            {
                Set(ref _isChannelLoading, value);
            }
        }

        public RelayCommand RefreshChannelCommand
        {
            get
            {
                _refreshChannelCommand = _refreshChannelCommand ?? new RelayCommand(LoadChannelsRegion);
                return _refreshChannelCommand;
            }
        }

        public IReadOnlyDictionary<int, int> UpdateCounts
        {
            get
            {
                return _updateCounts;
            }
            private set
            {
                Set(ref _updateCounts, value);
            }
        }

        private async void Initialize()
        {
            // TODO try catch exception.

            //var homeResult = await _aiXiFanService.GetRegionAsync(0, null);
            //if (homeResult.Code == HttpStatusCode.OK)
            //{
            //    var homeData = homeResult.Data;
            //    CarouselsData = homeData.FirstOrDefault(temp => temp.Type.Id == 5);
            //}

            return;
            //var updateCountsResult = await _aiXiFanService.GetUpdateCountsAsync(channels.Select(temp => temp.Id).ToArray());
            //UpdateCounts = updateCountsResult.Data.List;
        }

        private async void LoadArticleRegion()
        {
            if (IsArticleLoading)
            {
                return;
            }

            IsArticleLoading = true;
            try
            {
                var articleRegionResult = await _aiXiFanService.GetRegionAsync(11, 63);
                if (articleRegionResult.Code == HttpStatusCode.OK)
                {
                    Article = articleRegionResult.Data;
                }
                else
                {
                    // TODO
                }
            }
            catch (HttpRequestException)
            {
                // TODO
                await new MessageDialog("加载文章失败").ShowAsync();
            }
            finally
            {
                IsArticleLoading = false;
            }
        }

        private async void LoadChannelsRegion()
        {
            if (IsChannelLoading)
            {
                return;
            }

            IsChannelLoading = true;
            ChannelData[] channels = null;
            try
            {
                var channelResult = await _aiXiFanService.GetChannelsAsync();
                if (channelResult.Code == HttpStatusCode.OK)
                {
                    channels = channelResult.Data;
                    Channels = channels;
                }
                else
                {
                    // TODO
                }
            }
            catch (HttpRequestException)
            {
                // TODO
                await new MessageDialog("加载频道失败").ShowAsync();
            }
            finally
            {
                IsChannelLoading = false;
            }

            if (channels != null)
            {
                try
                {
                    var updateCountsResult = await _aiXiFanService.GetUpdateCountsAsync(channels.Select(temp => temp.Id).ToArray());
                    if (updateCountsResult.Code == HttpStatusCode.OK)
                    {
                        var updateCounts = updateCountsResult.Data.List;
                        if (updateCounts != null)
                        {
                            UpdateCounts = updateCounts;
                            MessengerInstance.Send(new UpdateCountsLoadedMessage(updateCounts));
                        }
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
            }
        }
    }
}