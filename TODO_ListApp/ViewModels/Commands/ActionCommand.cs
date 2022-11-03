﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TODO_ListApp.ViewModels.Commands
{
    public class ActionCommand : ICommand
    {
        public ActionCommand(Action action, bool canRun)
        {
            Action = action;
            CanRun = canRun;
        }

        public Action Action { get; }
        public bool CanRun { get; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
