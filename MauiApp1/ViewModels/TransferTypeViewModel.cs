namespace MauiApp1.ViewModels
{
    using System.Windows.Input;
    using CommunityToolkit.Mvvm.ComponentModel;
    using CommunityToolkit.Mvvm.Input;

    public delegate Task CloseHandler<T> (T result);

    public class TransferTypeViewModel : ObservableObject
    {
        public event CloseHandler<TransferType> OnClose;
        public TransferTypeViewModel()
        {
            CloseCommand = new RelayCommand<TransferType>(async tt => await OnClose?.Invoke(tt));
        }

        public ICommand CloseCommand { get; set; }        
    }
}
