using TYT.Portal.Services;
using TYT.Portal.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TYT.Portal.Views
{
    public sealed partial class ShellPage : Page
    {
        private ShellViewModel ViewModel { get { return DataContext as ShellViewModel; } }

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);
        }
    }
}
