using System.Windows;
using System.Windows.Controls;

namespace PACS.View
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Shutdown_app(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //if (Username_TextBox.Text == string.Empty || string.IsNullOrWhiteSpace(PasswordBox.Password))
            //{
            //    MessageBox.Show("Username and Password are required fields", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            //} else
            //{

            //}
           
        }
    }
}
