using System.Windows;

namespace WpfNavigationLab
{
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            MessageBox.Show($"Szia {txtName.Text.Trim()}!");
        }

        private void SetTitle_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Add meg a neved!");
                return;
            }

            Title = txtName.Text.Trim();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
