using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace ImageDisplay.Droid
{
    [Activity(
        Label = "ImageDisplay.Droid"
        , MainLauncher = true
        //, Icon = "@mipmap/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.UserPortrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
