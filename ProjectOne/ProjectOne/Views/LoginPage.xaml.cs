using Xamarin.Forms;

namespace ProjectOne.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

           
            var parentAnimation = new Animation();
            parentAnimation.Add(0, 1, new Animation(v => Logintext.TranslationY = v, 50, 0, Easing.SinInOut));
            parentAnimation.Add(0, 0.6, new Animation(v => EmailText.TranslationX = v, 80, 0, Easing.SinInOut));
            parentAnimation.Add(0, 0.6, new Animation(v => PasswordText.TranslationX = v, 80, 0, Easing.SinInOut));
            parentAnimation.Add(0, 1, new Animation(v => EmailEntrty.TranslationX = v, -80, 0, Easing.SinInOut));
            parentAnimation.Add(0, 1, new Animation(v => PasswordEntry.TranslationX = v, -80, 0, Easing.SinInOut));
            parentAnimation.Commit(this, "PageAnimations", 16, 3000);
        }
    }
}
