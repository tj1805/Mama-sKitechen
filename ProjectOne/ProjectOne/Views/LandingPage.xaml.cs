using Xamarin.Forms;

namespace ProjectOne.Views
{
    public partial class LandingPage : ContentPage
    {
      
        public LandingPage()
        {
            InitializeComponent();
        }

      
        protected override void OnAppearing()
        {
            base.OnAppearing();
            WelcomeText.Opacity = 0;
            var parentAnimation = new Animation();

            parentAnimation.Add(0, 1, new Animation(v => Logo.Scale = v, 2, 1, Easing.BounceOut));
            parentAnimation.Add(0, 0.8, new Animation(v => WelcomeText.Opacity = v, 0, 1, Easing.SpringIn));
            parentAnimation.Add(0.3, 1, new Animation(v => WelcomeText.TranslationX = v, 50, 0, Easing.SpringIn));
            parentAnimation.Add(0, 1, new Animation(v => SignInButton.TranslationY = v,50,0, Easing.SpringIn));
            parentAnimation.Add(0, 1, new Animation(v => SignOutButton.TranslationY = v,50,0, Easing.SpringIn));
            parentAnimation.Commit(this, "PageAnimations", 16, 3000);
        }
    }
}
