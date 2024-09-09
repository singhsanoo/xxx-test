using PACS.Commands;
using PACS.Utilities;
using System.Windows;
using System.Windows.Input;

namespace PACS.ViewModel
{
    public class LoginVM : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }

        /// /////////////////////////////////////////////////////////////////////////////////////
        /// CONSTRUCTOR
        /// /// /////////////////////////////////////////////////////////////////////////////////
        public LoginVM(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            LoginCommand = new LoginCommand(this);
            Username = string.Empty;
            Password = string.Empty;            
        }

        public void Login()
        {
            if (Username.Trim() == string.Empty || Password.Trim() == string.Empty)
            {
                MessageBox.Show("Username and Password are required fields", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                // navigate to Home
                _navigationStore.CurrentVM = new HomePageVM(_navigationStore);
            }
        }

    }
}
