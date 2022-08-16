﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace WpfPopup.ViewModels
{
    public class ViewCViewModel : BindableBase , IDialogAware
    {
        public ViewCViewModel()
        {
            OKButton = new DelegateCommand(OKButtonExecute);
        }

        private string _viewCTextBox = "XXX";

        public event Action<IDialogResult> RequestClose;

        public string ViewCTextBox
        {
            get { return _viewCTextBox; }
            set { SetProperty(ref _viewCTextBox, value); }
        }

        public string Title => "ViewCのタイトル";

        public DelegateCommand OKButton { get; }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
        private void OKButtonExecute()
        {
            RequestClose.Invoke(new DialogResult(ButtonResult.OK));
        }
    }
}
