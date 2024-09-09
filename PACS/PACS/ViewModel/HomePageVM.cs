using PACS.Commands;
using PACS.Utilities;
using System.Windows.Input;

namespace PACS.ViewModel
{
    public class HomePageVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        //private readonly NavigationStore _navigationStore;

        public ICommand HomeCommand { get; set; }
        public ICommand SettingsCommand { get; set; }
        public ICommand InfoCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand CalculatorCommand { get; set; }

        /// ///////////////////////////////////////////////////////////
        //CONSTRUCTOR
        /// ///////////////////////////////////////////////////////////
        public HomePageVM(NavigationStore navigationStore)
        {
            //_navigationStore = navigationStore;
            Helpers.SetAppTitle("Desktop Software Visualizer");

            CurrentView = new SettingsVM();

            HomeCommand = new RelayCommand(obj =>
            {
                CurrentView = new HomeVM();
            });
            SettingsCommand = new RelayCommand(obj =>
            {
                CurrentView = new SettingsVM();
            });
            InfoCommand = new RelayCommand(obj =>
            {
                CurrentView = new InfoVM();
            });
        }
    }
}
