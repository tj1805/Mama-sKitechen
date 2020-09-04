using Xamarin.Forms;

namespace ProjectOne.Views
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           
            SignUpText.Opacity = 0;
            EmailEntry.Opacity = 0;
            AddressEntry.Opacity = 0;
            MobileNumberEntry.Opacity = 0;
            PasswordEntry.Opacity = 0;
            ConfrimPasswordEntry.Opacity = 0;

            EmailEntry.TranslationX = -50;
            AddressEntry.TranslationX = -50;
            MobileNumberEntry.TranslationX = -50;
            PasswordEntry.TranslationX = -50;
            ConfrimPasswordEntry.TranslationX = -50;

               var parentAnimation = new Animation();
            parentAnimation.Add(0, 1, new Animation(v => SignUpText.Opacity = v, 0, 1, Easing.SinInOut));

            parentAnimation.Add(0, 1, new Animation(v => SurnameEntry.TranslationX = v, -50, 0, Easing.SinInOut));
            parentAnimation.Add(0, 1, new Animation(v => FirstNameEntry.TranslationX = v, 50, 0, Easing.SinInOut));

            parentAnimation.Add(0, 0.3, new Animation(v => EmailEntry.Opacity = v, 0, 1, Easing.SinInOut));
            parentAnimation.Add(0.1, 0.5, new Animation(v => EmailEntry.TranslationX = v, -50, 0, Easing.SinInOut));

            parentAnimation.Add(0, 0.4, new Animation(v => AddressEntry.Opacity = v, 0, 1, Easing.SinInOut));
            parentAnimation.Add(0.2, 0.7, new Animation(v => AddressEntry.TranslationX = v, -50, 0, Easing.SinInOut));
       

            parentAnimation.Add(0, 0.4, new Animation(v => MobileNumberEntry.Opacity = v, 0, 1, Easing.SinInOut));
            parentAnimation.Add(0.3, 0.8, new Animation(v => MobileNumberEntry.TranslationX = v, -50, 0, Easing.SinInOut));

            parentAnimation.Add(0, 0.5, new Animation(v => PasswordEntry.Opacity = v, 0, 1, Easing.SinInOut));
            parentAnimation.Add(0.4, 0.9, new Animation(v => PasswordEntry.TranslationX = v, -50, 0, Easing.SinInOut));

            parentAnimation.Add(0, 0.7, new Animation(v => ConfrimPasswordEntry.Opacity = v, 0, 1, Easing.SinInOut));
            parentAnimation.Add(0.5, 1, new Animation(v => ConfrimPasswordEntry.TranslationX = v, -50, 0, Easing.SinInOut));

            parentAnimation.Commit(this, "PageAnimations", 16, 3000);
        }
    }
}
