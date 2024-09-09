using PACS.Utilities;

namespace PACS
{
    public class MainWindowVM : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentVM => _navigationStore.CurrentVM;

        public MainWindowVM(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentVMChanged += OnCurrentVMChanged;
        }

        private void OnCurrentVMChanged()
        {
            OnPropertyChanged(nameof(CurrentVM));
        }
    }
}
