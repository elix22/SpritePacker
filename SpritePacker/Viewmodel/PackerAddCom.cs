﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Input; // ICommand

namespace SpritePacker.Viewmodel
{
    class PackerAddCom : ICommand
    {
        private PackerViewmodel _packerView;

        public PackerAddCom(PackerViewmodel packerView)
        {
            _packerView = packerView;
        }

        public bool CanExecute(object parameter)
        {
            return _packerView.CanAdd;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _packerView.AddSubsprite();
        }
    }
}
