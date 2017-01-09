using AiXiFan.Services;
using AiXiFan.Uwp.Services;
using AiXiFan.Uwp.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace AiXiFan.Uwp.ViewModels
{
    public class ViewModelLocator
    {
        public const string AboutViewKey = "About";

        public const string ArticleDetailViewKey = "ArticleDetail";

        public const string ArticleViewKey = "Article";

        public const string ChannelViewKey = "Channel";

        public const string CommentViewKey = "Comment";

        public const string HomeViewKey = "Home";

        public const string LoginViewKey = "Login";

        public const string SettingViewKey = "Setting";

        static ViewModelLocator()
        {
            var serviceLocator = new UnityServiceLocator(ConfigureUnityContainer());
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        public AboutViewModel About => ServiceLocator.Current.GetInstance<AboutViewModel>();

        public ArticleViewModel Article => ServiceLocator.Current.GetInstance<ArticleViewModel>();

        public ArticleDetailViewModel ArticleDetail => ServiceLocator.Current.GetInstance<ArticleDetailViewModel>();

        public ChannelViewModel Channel => ServiceLocator.Current.GetInstance<ChannelViewModel>();

        public CommentViewModel Comment => ServiceLocator.Current.GetInstance<CommentViewModel>();

        public HomeViewModel Home => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public LoginViewModel Login => ServiceLocator.Current.GetInstance<LoginViewModel>();

        public SettingViewModel Setting => ServiceLocator.Current.GetInstance<SettingViewModel>();

        private static IUnityContainer ConfigureUnityContainer()
        {
            var unityContainer = new UnityContainer();

            unityContainer.RegisterInstance(CreateNavigationService());
            if (ViewModelBase.IsInDesignModeStatic)
            {
                unityContainer.RegisterType<IAiXiFanService, Design.AiXiFanService>();
            }
            else
            {
                unityContainer.RegisterType<IAiXiFanService, AiXiFanService>();
            }

            unityContainer.RegisterType<HomeViewModel>();
            unityContainer.RegisterType<ArticleViewModel>();
            unityContainer.RegisterType<ChannelViewModel>();
            unityContainer.RegisterType<ArticleDetailViewModel>();
            unityContainer.RegisterType<CommentViewModel>();
            unityContainer.RegisterType<LoginViewModel>();
            unityContainer.RegisterType<SettingViewModel>();
            unityContainer.RegisterType<AboutViewModel>();

            return unityContainer;
        }

        private static INavigationService CreateNavigationService()
        {
            var navigationService = new AiXiFanNavigationService();
            navigationService.Configure(HomeViewKey, typeof(HomeView));
            navigationService.Configure(ChannelViewKey, typeof(ChannelView));
            navigationService.Configure(ArticleViewKey, typeof(ArticleView));
            navigationService.Configure(ArticleDetailViewKey, typeof(ArticleDetailView));
            navigationService.Configure(CommentViewKey, typeof(CommentView));
            navigationService.Configure(SettingViewKey, typeof(SettingView));
            navigationService.Configure(AboutViewKey, typeof(AboutView));
            return navigationService;
        }
    }
}