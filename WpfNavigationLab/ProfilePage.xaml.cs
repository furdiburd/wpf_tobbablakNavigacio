using System.Windows;
using System.Windows.Controls;

namespace WpfNavigationLab
{
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Hibás e-mail cím!");
                return;
            }

            MessageBox.Show("Az adatok megfelelőek!");
        }

        private void GoToSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SettingsPage());
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
