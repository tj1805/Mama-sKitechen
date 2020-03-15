using System;
using System.Collections.ObjectModel;
using System.Timers;
using Xamarin.Forms;

namespace ProjectOne.Views
{
    public partial class PrismContentPage1 : ContentPage
    {
        public PrismContentPage1()
        {
            InitializeComponent();
            //this.BindingContext = this;
       
           
        }
      //  private Timer timer;
     

        //protected override void OnAppearing()
        //{
        //    timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
        //    timer.Elapsed += Timer_Elapsed;
        //    base.OnAppearing();
        //}

        //protected override void OnDisappearing()
        //{
        //    timer?.Dispose();
        //    base.OnDisappearing();
        //}
        //private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    Device.BeginInvokeOnMainThread(async () =>
        //    {
        //        if (cvWalkthrough.Position == 2)
        //        {
        //            cvWalkthrough.Position = 0;
                  
                   
        //            return;
        //        }

        //        cvWalkthrough.Position += 1;

        //    });
        //}

       
    }

    
}
