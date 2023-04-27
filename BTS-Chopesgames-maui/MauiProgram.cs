﻿using BTS_Chopesgames_maui.Views;
using Microsoft.Extensions.Logging;

namespace BTS_Chopesgames_maui;

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

        //builder.Services.AddSingleton<Accueil>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
