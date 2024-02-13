namespace MauiApp1.Views;

using CommunityToolkit.Maui.Views;
using MauiApp1.ViewModels;

public partial class AlertPopup : Popup
{
	public AlertPopup(AlertViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}