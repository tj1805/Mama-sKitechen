using ProjectOne.ViewModels;
using System;
using System.Timers;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace ProjectOne.Views
{
    public partial class HomePage : ContentPage
    {
        private Timer timer;
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
                       
            var parentAnim = new Animation();
            parentAnim.Add(0.00, 0.15, new Animation(t => Itanlianfood.TranslationY = t, 50, 0, Easing.SinInOut));
          parentAnim.Commit(this, "PageAnimations", 16, 5000);
        }

        protected  override bool OnBackButtonPressed()
        {
            
            // return base.OnBackButtonPressed();
            var snackBarconfiguration = new MaterialSnackbarConfiguration()
            {
                TintColor = Color.FromHex("#00FF01"),
                CornerRadius = 20,
                //  MessageTextColor = Color.White.MultiplyAlpha(0.6),
                MessageTextColor = Color.White,
                BackgroundColor = Color.FromHex("#010088")
            };

             MaterialDialog.Instance.SnackbarAsync(message: "Click on the top Back arrow to exit ",
                                          actionButtonText: "OK",
                                          msDuration: 3000,
                                          configuration: snackBarconfiguration);

            return true;
        }


       
        protected override void OnDisappearing()
        {
            timer?.Dispose(); 
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == App.countNumber)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }
    }

}

