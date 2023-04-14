
using ZXing.Net.Maui.Controls;

namespace QRManager;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
		builder.UseBarcodeReader();
        return builder.Build();
	}
}
