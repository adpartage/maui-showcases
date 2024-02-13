namespace MauiApp1.ViewModels
{
    using CommunityToolkit.Maui.Core;
    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class MainPageViewModel : ObservableObject
    {
        private readonly IPopupService _popupService;

        public MainPageViewModel(IPopupService popupService)
        {
            TransferCommand = new RelayCommand(async () => await TransferAsync());
            _popupService = popupService;
        }
        public ICommand TransferCommand { get; set; }

        private async Task TransferAsync()
        {
            var transferType = await _popupService.ShowPopupAsync<TransferTypeViewModel>() as TransferType?;

            if(transferType == null)
            {
                return;
            }

            switch (transferType.Value)
            {
                case TransferType.ScanToPay:
                    await DoScanToPayAsync();
                    break;
                case TransferType.ShowQrCode:
                    await DoShowQrCode();
                    break;
                case TransferType.QuickTransfer:
                    await DoQuickTransfer();
                    break;
            }
        }

        private async Task DoQuickTransfer()
        {
            await ShowPopupAsync("Do quick transfer");
        }

        private async Task DoShowQrCode()
        {
            await ShowPopupAsync("Show QrCode to receive payment");
        }

        private async Task DoScanToPayAsync()
        {
            await ShowPopupAsync("Scan the QrCode to pay");
        }

        private async Task ShowPopupAsync(string message)
        {
            await _popupService.ShowPopupAsync<AlertViewModel>(vm => vm.Message = message);
        }

    }
}
