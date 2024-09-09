using System;

namespace PACS.Utilities
{
    public class NavigationStore
    {
        public event Action CurrentVMChanged;

        private ViewModelBase _currentVM;

        public ViewModelBase CurrentVM
        {
            get { return _currentVM; }
            set { _currentVM = value; OnCurrentVMChanged(); }
        }

        private void OnCurrentVMChanged()
        {
            CurrentVMChanged?.Invoke();
        }
    }
}
