using Covid19.Infrastructure.Commands.Base;
using System.Windows;

namespace DialogsWindowExample.Infrastructure.Commands
{
    class CloseDialogCommand : Command
    {
        public bool? _DialogResult { get; set; }

        public override bool CanExecute(object parameter) => parameter is Window;

        public override void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;
            var window = (Window)parameter;
            window.DialogResult = _DialogResult;
            window.Close();
        }
    }
}
