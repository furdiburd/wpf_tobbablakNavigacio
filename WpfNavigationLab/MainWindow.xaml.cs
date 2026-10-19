using System.Windows;

namespace WpfNavigationLab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mainFrame.Navigate(new HomePage());
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HomePage());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ProfilePage());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SettingsPage());
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AboutPage());
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();

            infoWindow.Show();
        }

        private void OpenDialog_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();

            infoWindow.Owner = this;

            infoWindow.ShowDialog();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();

            helpWindow.Owner = this;

            helpWindow.ShowDialog();
        }
    }
}
