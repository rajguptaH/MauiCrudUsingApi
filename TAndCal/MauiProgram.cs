using TAndCal.Utility.Data.Service;
using TAndCal.Utility.Data.Service.Interface;
using AstroLazer.Library.Connection;
using AstroLazer.Library.Connection.Interface;

namespace TAndCal;

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
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services.AddSingleton<IStudentService, StudentService>();
        builder.Services.AddSingleton<IConnectionBuilder, ConnectionBuilder>();

        return builder.Build();
    }
}
