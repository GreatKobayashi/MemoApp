using MemoApp.Domain;
using MemoApp.Domain.Exceptions;
using MemoApp.Infrastructure;
using MemoApp.UI.Pages.ViewModels;
using Microsoft.Extensions.Logging;

namespace MemoApp.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            try
            {
                SetupSetting();

                var builder = MauiApp.CreateBuilder();
                builder
                    .UseMauiApp<App>()
                    .ConfigureFonts(fonts =>
                    {
                        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    });

                builder.Services.AddSingleton<IHomeViewModel>(new HomeViewModel(Factories.CreateMemoRepository()));
                builder.Services.AddMauiBlazorWebView();
#if DEBUG
                builder.Services.AddBlazorWebViewDeveloperTools();
                builder.Logging.AddDebug();
#endif

                return builder.Build();
            }
            catch (Exception)
            {
                // TODO: ログ処理
                throw;
            }
        }

        private static void SetupSetting()
        {
            try
            {
                var settingRepository = Factories.CreateSettingRepository(true);
                var settingEntity = settingRepository.GetEntity();
                Shared.Setup(settingEntity);
            }
            catch (SettingFileException e)
            {
                // TODO: ログ処理
                Shared.UnhandledExceptions.Add(e);
            }
        }
    }
}
