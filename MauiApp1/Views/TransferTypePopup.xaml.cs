namespace MauiApp1.Views;

using CommunityToolkit.Maui.Views;
using MauiApp1.ViewModels;
using System.Threading.Tasks;

public partial class TransferTypePopup : Popup, IDisposable
{
    private TransferTypeViewModel _viewModel;
    public TransferTypePopup(TransferTypeViewModel vm)
    {
        InitializeComponent();
        BindingContext = _viewModel = vm;
        vm.OnClose += Close;
    }

    public void Dispose()
    {
        _viewModel.OnClose -= Close;
    }

    private async Task Close(TransferType result)
    {
        await CloseAsync(result, CancellationToken.None);
    }
}