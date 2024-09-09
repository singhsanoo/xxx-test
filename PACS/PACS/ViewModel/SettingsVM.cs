using PACS.Commands;
using PACS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PACS.ViewModel
{
    public class SettingsVM : ViewModelBase
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

        public ICommand NetworkSettingsOptionsCommand { get; set; }
        public ICommand OperatingModelCommandsCommand { get; set; }
        public ICommand FileSettingsCommand { get; set; }
        public ICommand SystemConfigCommand { get; set; }

        public SettingsVM()
        {
            CurrentView = new NetworkSettingsOptionsVM();

            NetworkSettingsOptionsCommand = new RelayCommand(obj =>
            {
                CurrentView = new NetworkSettingsOptionsVM();
            });
            OperatingModelCommandsCommand = new RelayCommand(obj =>
            {
                CurrentView = new OperatingModeCommandsVM();
            });
            FileSettingsCommand = new RelayCommand(obj =>
            {
                CurrentView = new FileSettingsVM();
            });
            SystemConfigCommand = new RelayCommand(obj =>
            {
                CurrentView = new SystemConfigVM();
            });
        }
    }
}
