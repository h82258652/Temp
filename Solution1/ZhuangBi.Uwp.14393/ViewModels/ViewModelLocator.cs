using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Views;
using ZhuangBi.Uwp.Views;
using SoftwareKobo.Controls;

namespace ZhuangBi.Uwp.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            var serviceLocator = new UnityServiceLocator(ConfigureUnityContainer());
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        public const string MainViewKey = "Main";

        private static INavigationService CreateNavigationService()
        {
            var navigationService = new BingoWallpaperNavigationService();
            navigationService.Configure(MainViewKey, typeof(MainView));
            navigationService.Configure(DetailViewKey, typeof(DetailView));
            navigationService.Configure(SettingViewKey, typeof(SettingView));
            navigationService.Configure(AboutViewKey, typeof(AboutView));
            return navigationService;
        }

        private static IUnityContainer ConfigureUnityContainer()
        {
            var unityContainer = new UnityContainer();

            unityContainer.RegisterInstance(CreateNavigationService());
            unityContainer.RegisterType<IWallpaperService, LeanCloudWallpaperServiceWithCache>();
            unityContainer.RegisterType<ILeanCloudWallpaperService, LeanCloudWallpaperServiceWithCache>();
            unityContainer.RegisterType<ILeanCloudWallpaperServiceWithCache, LeanCloudWallpaperServiceWithCache>();
            unityContainer.RegisterType<IScreenService, ScreenService>();
            unityContainer.RegisterType<ISystemSettingService, SystemSettingService>();
            unityContainer.RegisterType<IBingoFileService, BingoFileService>();
            unityContainer.RegisterType<IAppToastService, AppToastService>();
            unityContainer.RegisterType<IBingoShareService, BingoShareService>();
            unityContainer.RegisterType<IStoreService, StoreService>();

            unityContainer.RegisterType<IBingoWallpaperSettings, BingoWallpaperSettings>();

            unityContainer.RegisterInstance(DefaultImageLoader.Instance);

            unityContainer.RegisterType<MainViewModel>();
            unityContainer.RegisterType<DetailViewModel>();
            unityContainer.RegisterType<SettingViewModel>();
            unityContainer.RegisterType<AboutViewModel>();

            return unityContainer;
        }
    }
}