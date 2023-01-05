using ChatApp.Services;
using ChatApp.ViewModels;
using ChatApp.Views;
using Microsoft.Extensions.Logging;

namespace ChatApp;

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

		// TODO: Registra las fuentes Metropolis

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MessageService>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HomeView>();

        builder.Services.AddTransient<DetailViewModel>();
        builder.Services.AddTransient<DetailView>();

        return builder.Build();
	}
}
