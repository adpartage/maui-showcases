namespace MauiApp1
{
    using CommunityToolkit.Maui;
    using MauiApp1.ViewModels;
    using MauiApp1.Views;
    using Microsoft.Extensions.Logging;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "Material");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransientPopup<AlertPopup, AlertViewModel>();
            builder.Services.AddTransientPopup<TransferTypePopup, TransferTypeViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            return builder.Build();
        }
    }
}
