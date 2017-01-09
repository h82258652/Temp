namespace AcArticle.Uwp.ViewModels
{
    public interface INavigable
    {
        void Activate(object parameter);

        void Deactivate(object parameter);
    }
}