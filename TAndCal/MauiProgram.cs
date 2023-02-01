using TAndCal.Utility.Data.Repository;
using TAndCal.Utility.Data.Repository.Interface;
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
        builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
        builder.Services.AddSingleton<IConnectionBuilder, ConnectionBuilder>();

        return builder.Build();
    }
}
