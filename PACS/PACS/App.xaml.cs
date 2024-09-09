using PACS.Utilities;
using PACS.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PACS
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new();

            navigationStore.CurrentVM = new LoginVM(navigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowVM(navigationStore)
            };
            MainWindow.Show();
            Helpers.SetAppTitle("PACS Login");

            base.OnStartup(e);
        }

    }
}
