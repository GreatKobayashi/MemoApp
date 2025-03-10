using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using System.Diagnostics;

namespace MemoApp.UI
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Shared.BgColor.ToRgb(out var r, out var g, out var b);
            Window!.SetStatusBarColor(Android.Graphics.Color.Rgb(r, g, b));

            // ↓なぜか定数を引数にすると警告が出るので、直接値を指定
            //   本来ならば定数化必須
            // Android 11 (API 30) 以降
            if (OperatingSystem.IsAndroidVersionAtLeast(30))
            {
                Window.InsetsController!.SetSystemBarsAppearance(
                    (int)WindowInsetsControllerAppearance.LightStatusBars,
                    (int)WindowInsetsControllerAppearance.LightStatusBars
                );
            }
            // Android 10 (API 24) 以降 Android 11 未満
            else if (OperatingSystem.IsAndroidVersionAtLeast(24))
            {
                Window.DecorView.SystemUiFlags = SystemUiFlags.LightStatusBar;
            }
        }
    }
}
