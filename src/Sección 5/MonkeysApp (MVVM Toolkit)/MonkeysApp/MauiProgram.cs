using Microsoft.Extensions.Logging;
using MonkeysApp.Services;
using MonkeysApp.ViewModels;
using MonkeysApp.Views;

namespace MonkeysApp;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MonkeyService>();
        builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Services.AddSingleton<MonkeysView>();

        builder.Services.AddTransient<MonkeyDetailsViewModel>();
        builder.Services.AddTransient<MonkeyDetailsView>();

        return builder.Build();
	}
}