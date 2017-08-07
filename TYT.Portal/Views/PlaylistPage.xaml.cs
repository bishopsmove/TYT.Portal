using TYT.Portal.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TYT.Portal.Views
{
    public sealed partial class PlaylistPage : Page
    {
        private PlaylistViewModel ViewModel
        {
            get { return DataContext as PlaylistViewModel; }
        }

        public PlaylistPage()
        {
            InitializeComponent();
        }
    }
}
