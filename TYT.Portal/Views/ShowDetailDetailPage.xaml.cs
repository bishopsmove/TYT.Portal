using TYT.Portal.Models;
using TYT.Portal.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TYT.Portal.Views
{
    public sealed partial class ShowDetailDetailPage : Page
    {
        private ShowDetailDetailViewModel ViewModel
        {
            get { return DataContext as ShowDetailDetailViewModel; }
        }

        public ShowDetailDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as Order;
        }
    }
}
