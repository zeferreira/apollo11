using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

using ForgeCore.Shared;

namespace Kristalia.Android
{
    [Activity(Label = "Kristalia.Android"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.Landscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize | ConfigChanges.ScreenLayout)]
    public class Activity : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = GameForgeEngine.Instance;
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }
    }
}

