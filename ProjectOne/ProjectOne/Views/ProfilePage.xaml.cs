using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using Xamarin.Forms;

namespace ProjectOne.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            bool response = await DisplayAlert("Confirm", "Select Where to pick Image from", "Gallery", "Camera");

            if (response)
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("OOOps", "pick photo is not support! ", "ok");
                    return;
                }
                var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                {
                    PhotoSize = PhotoSize.Large,
                }
                );

                if (file == null)
                    return;

                //var streams = file.GetStream();

                //var bytes = new byte[streams.Length];
                //await streams.ReadAsync(bytes, 0, (int)streams.Length);
                //string base64 = Convert.ToBase64String(bytes);

                //ProfileImage = base64;


                ProfileImage.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();

                    file.Dispose();
                    return stream;
                });

            }
            else
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("No Pick photo", " :( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    PhotoSize = PhotoSize.Large,
                }
                );

                if (file == null)
                    return;

                //var streams = file.GetStream();

                //var bytes = new byte[streams.Length];
                //await streams.ReadAsync(bytes, 0, (int)streams.Length);
                //string base64 = Convert.ToBase64String(bytes);

                //ProfileImage = base64;


                ProfileImage.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();

                    file.Dispose();
                    return stream;
                });
            }


        }

       
    }
}
