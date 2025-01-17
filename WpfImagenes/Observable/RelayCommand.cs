﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfImagenes.Observable
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object>? _canExecute;


        public RelayCommand(Action<object> execute)
        : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object>? canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }


        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter == null ? new object() : parameter);
        }

        public void Execute(object? parameter)
        {
            this._execute?.Invoke(parameter==null ? new object() : parameter);
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


    }
}
