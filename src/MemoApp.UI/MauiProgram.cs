using MemoApp.Infrastructure;
using MemoApp.UI.Pages.ViewModels;
using Microsoft.Extensions.Logging;

namespace MemoApp.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var settingLoader = new SettingLoader(FileSystem.Current);
            settingLoader.Load();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddSingleton(_ => Factories.CreateMemoRepository());
            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
