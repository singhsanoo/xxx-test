using PACS.ViewModel;
using System.Windows.Input;

namespace PACS.Commands
{
    public class LoginCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public LoginVM VM { get; set; }

        public LoginCommand(LoginVM vM)
        {
            VM = vM;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.Login();
        }
    }
}
