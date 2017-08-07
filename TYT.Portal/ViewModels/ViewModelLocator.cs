using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

using TYT.Portal.Services;
using TYT.Portal.Views;

namespace TYT.Portal.ViewModels
{
    public class ViewModelLocator
    {
        NavigationServiceEx _navigationService = new NavigationServiceEx();

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => _navigationService);
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<MediaPlayerViewModel, MediaPlayerPage>();
            Register<ShowViewViewModel, ShowViewPage>();
            Register<ShowDetailViewModel, ShowDetailPage>();
            Register<ShowDetailDetailViewModel, ShowDetailDetailPage>();
            Register<PlaylistViewModel, PlaylistPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public PlaylistViewModel PlaylistViewModel => ServiceLocator.Current.GetInstance<PlaylistViewModel>();

        public ShowDetailDetailViewModel ShowDetailDetailViewModel => ServiceLocator.Current.GetInstance<ShowDetailDetailViewModel>();

        public ShowDetailViewModel ShowDetailViewModel => ServiceLocator.Current.GetInstance<ShowDetailViewModel>();

        public ShowViewViewModel ShowViewViewModel => ServiceLocator.Current.GetInstance<ShowViewViewModel>();

        public MediaPlayerViewModel MediaPlayerViewModel => ServiceLocator.Current.GetInstance<MediaPlayerViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public void Register<VM, V>() where VM : class
        {
            SimpleIoc.Default.Register<VM>();
            
            _navigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
