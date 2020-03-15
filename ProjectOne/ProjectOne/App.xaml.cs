using Prism;
using Prism.Ioc;
using ProjectOne.ViewModels;
using ProjectOne.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);
           // await NavigationService.NavigateAsync("NavigationPage/PrismContentPage1");
          // await NavigationService.NavigateAsync("NavigationPage/ViewA");
          // await NavigationService.NavigateAsync("NavigationPage/MainPage");
          await NavigationService.NavigateAsync("NavigationPage/LandingPage");
          // await NavigationService.NavigateAsync("NavigationPage/ShellPage");
        //   await NavigationService.NavigateAsync("/ShellPage");
          // await NavigationService.NavigateAsync("/HomePage");

       
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();


            containerRegistry.RegisterForNavigation<PrismContentPage1, PrismContentPage1ViewModel>();
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
        } 
    }
}
