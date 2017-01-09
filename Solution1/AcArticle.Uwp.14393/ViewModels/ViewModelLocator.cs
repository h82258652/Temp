using AcArticle.Services;
using AcArticle.Uwp.Services;
using AcArticle.Uwp.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using SoftwareKobo.Support;

namespace AcArticle.Uwp.ViewModels
{
    public class ViewModelLocator
    {
        public const string AboutViewKey = "About";

        public const string CommentViewKey = "Comment";

        public const string DetailViewKey = "Detail";

        public const string MainViewKey = "Main";

        static ViewModelLocator()
        {
            var serviceLocator = new UnityServiceLocator(ConfigureUnityContainer());
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        public AboutViewModel About => ServiceLocator.Current.GetInstance<AboutViewModel>();

        public CommentViewModel Comment => ServiceLocator.Current.GetInstance<CommentViewModel>();

        public DetailViewModel Detail => ServiceLocator.Current.GetInstance<DetailViewModel>();

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        private static IUnityContainer ConfigureUnityContainer()
        {
            var unityContainer = new UnityContainer();

            unityContainer.RegisterInstance(CreateNavigationService());
            if (ViewModelBase.IsInDesignModeStatic)
            {
                unityContainer.RegisterType<IAcArticleService, Design.AcArticleService>();
            }
            else
            {
                unityContainer.RegisterType<IAcArticleService, AcArticleService>();
            }
            unityContainer.RegisterType<IScreenService, ScreenService>();

            unityContainer.RegisterType<MainViewModel>();
            unityContainer.RegisterType<DetailViewModel>();
            unityContainer.RegisterType<CommentViewModel>();
            unityContainer.RegisterType<AboutViewModel>();

            return unityContainer;
        }

        private static INavigationService CreateNavigationService()
        {
            var navigationService = new AcArticleNavigationService();
            navigationService.Configure(MainViewKey, typeof(MainView));
            navigationService.Configure(DetailViewKey, typeof(DetailView));
            navigationService.Configure(CommentViewKey, typeof(CommentView));
            navigationService.Configure(AboutViewKey, typeof(AboutView));
            return navigationService;
        }
    }
}