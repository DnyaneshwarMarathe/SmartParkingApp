using SmartParkingApp.Services;
using SmartParkingApp.View;
using SmartParkingApp.ViewModel;

namespace SmartParkingApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ParkingService>();
        builder.Services.AddSingleton<ParkingViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<ParkingPage>();

        return builder.Build();
	}
}
