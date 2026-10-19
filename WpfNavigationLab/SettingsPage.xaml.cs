using System.Windows;
using System.Windows.Controls;

namespace WpfNavigationLab
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                $"Értesítések: {(chkNotifications.IsChecked == true ? "be" : "ki")}\n" +
                $"Sötét mód: {(chkDarkMode.IsChecked == true ? "be" : "ki")}");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
