using TYT.Portal.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TYT.Portal.Views
{
    public sealed partial class ShowDetailDetailControl : UserControl
    {
        public Order MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Order; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(Order),typeof(ShowDetailDetailControl),new PropertyMetadata(null));

        public ShowDetailDetailControl()
        {
            InitializeComponent();
        }
    }
}
