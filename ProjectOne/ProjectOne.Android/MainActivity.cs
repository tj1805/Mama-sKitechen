using Android.App;
using Android.Content.PM;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using FFImageLoading.Forms.Platform;
using Java.Nio;
using Plugin.CurrentActivity;
using Plugin.Media;
using Prism;
using Prism.Ioc;

namespace ProjectOne.Droid
{
    [Activity(Label = "ProjectOne", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override  void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
           
            CrossCurrentActivity.Current.Init(this, bundle);


            base.OnCreate(bundle);

            // await CrossMedia.Current.Initialize();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            CarouselViewRenderer.Init();
            CachedImageRenderer.Init(true);
            XF.Material.Droid.Material.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}

