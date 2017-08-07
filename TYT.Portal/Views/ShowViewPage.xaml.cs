using TYT.Portal.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TYT.Portal.Views
{
    public sealed partial class ShowViewPage : Page
    {
        private ShowViewViewModel ViewModel
        {
            get { return DataContext as ShowViewViewModel; }
        }

        public ShowViewPage()
        {
            InitializeComponent();
        }
    }
}
