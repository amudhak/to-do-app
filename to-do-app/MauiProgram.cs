using to_do_app.ViewModel;
using Microsoft.Extensions.Logging;

namespace to_do_app;

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
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<DetailPage>();
		builder.Services.AddTransient<DetailViewModel>();

		//builder.Services.AddScoped<DetailPage>();
		//builder.Services.AddScoped<DetailViewModel>();

        return builder.Build();
	}
}

