using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using WpfPopup.Views;

namespace WpfPopup.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IDialogService _dialogService;

        public MainWindowViewModel(
            IDialogService dialogService
            )
        {
            _dialogService = dialogService;
            ShowViewCButton = new DelegateCommand(ShowViewCButtonExecute);
        }

        public DelegateCommand ShowViewCButton { get; }

        private void ShowViewCButtonExecute()
        {
            _dialogService.ShowDialog(nameof(ViewC), null, null);
        }

    }
}
