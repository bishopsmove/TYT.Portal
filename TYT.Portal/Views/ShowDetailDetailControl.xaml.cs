using TYT.Portal.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TYT.Portal.Views
{
    public sealed partial class ShowDetailDetailControl : UserControl
    {
        public IEpisode MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as IEpisode; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(IEpisode),typeof(ShowDetailDetailControl),new PropertyMetadata(null));

        public ShowDetailDetailControl()
        {
            InitializeComponent();
        }
    }
}
