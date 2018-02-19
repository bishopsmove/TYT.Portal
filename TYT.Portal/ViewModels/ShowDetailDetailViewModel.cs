using System;
using System.Windows.Input;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using TYT.Portal.Models;
using TYT.Portal.Services;

using Windows.UI.Xaml;

namespace TYT.Portal.ViewModels
{
    public class ShowDetailDetailViewModel : ViewModelBase
    {

        public NavigationServiceEx NavigationService
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NavigationServiceEx>();
            }
        }
        const string NarrowStateName = "NarrowState";
        const string WideStateName = "WideState";

        public ICommand StateChangedCommand { get; private set; }

        private Episode _item;
        public Episode Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public ShowDetailDetailViewModel()
        {
            StateChangedCommand = new RelayCommand<VisualStateChangedEventArgs>(OnStateChanged);
        }
        
        private void OnStateChanged(VisualStateChangedEventArgs args)
        {
            if (args.OldState.Name == NarrowStateName && args.NewState.Name == WideStateName)
            {
                NavigationService.GoBack();
            }
        }
    }
}
