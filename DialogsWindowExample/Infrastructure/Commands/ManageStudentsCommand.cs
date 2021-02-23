using Covid19.Infrastructure.Commands.Base;
using DialogsWindowExample.Views;
using System;
using System.Windows;

namespace DialogsWindowExample.Infrastructure.Commands
{
    // Команда, которая открывает окно с управлением студентами в режиме ShowDialog
    class ManageStudentsCommand : Command
    {
        private StudentsManagementWindow window;

        public override bool CanExecute(object parameter) => window == null;

        public override void Execute(object parameter)
        {
            var _window = new StudentsManagementWindow
            {
                Owner = Application.Current.MainWindow
            };
            window = _window;
            _window.Closed += OnWindowClosed;
            _window.ShowDialog();
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            ((Window)sender).Closed -= OnWindowClosed; // в случае перехвата, отписываемся
            window = null;
        }
    }
}
