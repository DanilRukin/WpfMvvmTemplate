using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WpfMvvmTemplate.Infrastructure.Commands.Base;

namespace WpfMvvmTemplate.Infrastructure.Commands
{
    public class CloseWindowCommand : Command
    {
        protected override bool CanExecute(object parameter) => (parameter as Window ?? App.FocusedWindow ?? App.ActivedWindow) != null;

        protected override void Execute(object parameter) => (parameter as Window ?? App.FocusedWindow ?? App.ActivedWindow)?.Close();
    }
}
