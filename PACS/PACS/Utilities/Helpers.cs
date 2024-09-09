using System.Windows;

namespace PACS.Utilities
{
    public class Helpers
    {
        public static void SetAppTitle(string title)
        {
            var mainWindow = Application.Current.MainWindow;
            if (mainWindow != null)
            {
                mainWindow.Title = title;
            }
        }

    }
}
