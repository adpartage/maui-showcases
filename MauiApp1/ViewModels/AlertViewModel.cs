namespace MauiApp1.ViewModels
{
    using CommunityToolkit.Mvvm.ComponentModel;

    public class AlertViewModel : ObservableObject
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}