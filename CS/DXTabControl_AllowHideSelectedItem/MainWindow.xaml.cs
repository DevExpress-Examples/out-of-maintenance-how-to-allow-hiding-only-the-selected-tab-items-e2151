using System.Windows;
using DevExpress.Utils;
using DevExpress.Xpf.Core;
using DXExample.DemoData;

namespace DXTabControl_AllowHideSelectedItem {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {
            tabControl.ItemsSource = Invoice.GetData();
        }
        private void tabControl_SelectionChanged(object sender, TabControlSelectionChangedEventArgs e) {
            DXTabItem oldItem = tabControl.GetTabItem(e.OldSelectedIndex);
            DXTabItem newItem = tabControl.GetTabItem(tabControl.SelectedIndex);
            if (oldItem != null)
                oldItem.AllowHide = DefaultBoolean.Default;
            if (newItem != null)
                newItem.AllowHide = DefaultBoolean.True;
        }
    }
}
