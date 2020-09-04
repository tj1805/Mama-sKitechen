using Plugin.SharedTransitions;
using Prism;
using Prism.Ioc;
using ProjectOne.Utils;
using ProjectOne.ViewModels;
using ProjectOne.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjectOne
{
    public partial class App
    {
        public static int countNumber;

        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) 
        {
            //  XF.Material.Forms.Material.Init(this, "Material.Style");

        }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            Device.SetFlags(new[] {"Expander_Experimental" });
            XF.Material.Forms.Material.Init(this);
            SetMainPage();
            // using normal navigation and sharedTransitionNavigation
            //   await NavigationService.NavigateAsync($"{nameof(SharedTransitionNavigationPage)}/{nameof(LandingPage)}");


            // await NavigationService.NavigateAsync("NavigationPage/ShellPage");


        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
          //  containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<SharedTransitionNavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<LandingPage, LandingPageViewModel>();
            containerRegistry.RegisterForNavigation<ForgetPasswordPage, ForgetPasswordPageViewModel>();
            containerRegistry.RegisterForNavigation<SignupPage, SignupPageViewModel>();
            containerRegistry.RegisterForNavigation<TermsAndCondPage, TermsAndCondPageViewModel>();
            containerRegistry.RegisterForNavigation<ShellPage, ShellPageViewModel>();
            containerRegistry.RegisterForNavigation<FavoritePage, FavoritePageViewModel>();
            containerRegistry.RegisterForNavigation<ContactUsPage, ContactUsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<AllItanlianFoodPage, AllItanlianFoodPageViewModel>();
            containerRegistry.RegisterForNavigation<AllAfricanFoodPage, AllAfricanFoodPageViewModel>();
            containerRegistry.RegisterForNavigation<AllChinesseFoodPage, AllChinesseFoodPageViewModel>();
            containerRegistry.RegisterForNavigation<FoodDetailPage, FoodDetailPageViewModel>();
           containerRegistry.RegisterForNavigation<CallPage, CallPageViewModel>();
        }



        public async void SetMainPage()
        {
            var network = Connectivity.NetworkAccess;
            if (network != NetworkAccess.Internet)
            {


              await  MaterialDialog.Instance.SnackbarAsync(message: "Please connnect to internet",
                                           actionButtonText: "OK",
                                           msDuration: 3000
                                           );
                return;
            }
            if (string.IsNullOrEmpty(Settings.Email))
            {
                await  NavigationService.NavigateAsync($"{nameof(SharedTransitionNavigationPage)}/{nameof(LandingPage)}");

            }
            else
            {
                await NavigationService.NavigateAsync($"{nameof(SharedTransitionNavigationPage)}/{nameof(HomePage)}");

            }
        }

        //MaterialSnackbarConfiguration snackBarconfiguration = new MaterialSnackbarConfiguration()
        //{
        //    TintColor = Color.FromHex("#00FF01"),
        //    CornerRadius = 20,
        //    MessageTextColor = Color.White,
        //    BackgroundColor = Color.FromHex("#010088")
        //};
    }
}
