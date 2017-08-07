using TYT.Portal.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TYT.Portal.Views
{
    public sealed partial class ShowDetailPage : Page
    {
        private ShowDetailViewModel ViewModel
        {
            get { return DataContext as ShowDetailViewModel; }
        }

        public ShowDetailPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.LoadDataAsync(WindowStates.CurrentState);
        }
    }
}
