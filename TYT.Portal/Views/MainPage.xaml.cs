using TYT.Portal.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TYT.Portal.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
