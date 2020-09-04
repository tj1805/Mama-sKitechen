using Plugin.Media;
using Plugin.Media.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using static System.Net.Mime.MediaTypeNames;
using Prism.Navigation.Xaml;
using ProjectOne.Utils;
using Plugin.SharedTransitions;
using ProjectOne.Views;

namespace ProjectOne.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        public string imageASource;


        //private Xamarin.Forms.Image image = new Xamarin.Forms.Image();


        //public Xamarin.Forms.Image Imagee
        //{
        //    get { return image; }
        //    set { SetProperty(ref image, value); }
        //}
        //private DelegateCommand _openMapCommand;
        //public DelegateCommand OpenMapCommand => _openMapCommand ?? (_openMapCommand = new DelegateCommand(NavigateToBuilding25));

        private DelegateCommand _openMapPlaceMarkCommand;
        public DelegateCommand OpenMapPlaceMarkCommand => _openMapPlaceMarkCommand ?? (_openMapPlaceMarkCommand = new DelegateCommand(MapwithPlacemark));


        private DelegateCommand _callCommand;
        public DelegateCommand CallCommand => _callCommand ?? (_callCommand = new DelegateCommand(CallUsclicked));

        private DelegateCommand _favoriteCommand;
        public DelegateCommand FavoriteCommand => _favoriteCommand ?? (_favoriteCommand = new DelegateCommand(FavoriteClicked));
        
        private DelegateCommand _homeCommand;
        public DelegateCommand HomeCommand => _homeCommand ?? (_homeCommand = new DelegateCommand(HomeClicked));
        
        private DelegateCommand _contactUsClick;
        public DelegateCommand ContactUsClick => _contactUsClick ?? (_contactUsClick = new DelegateCommand(ContactUs));
      
        private DelegateCommand _signOutCommand;
        public DelegateCommand SignOutCommand => _signOutCommand ?? (_signOutCommand = new DelegateCommand(SignOut));
       
        //private DelegateCommand _profileChanged;
        //public DelegateCommand ProfileChanged => _profileChanged ?? (_profileChanged = new DelegateCommand(profileClicked));

        

        public ProfilePageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            
        }

        async void FavoriteClicked()
        {
            await NavigationService.NavigateAsync("FavoritePage");
        }
         async void HomeClicked()
        {
            await NavigationService.NavigateAsync("HomePage");
        }
         async void ContactUs()
        {
           await NavigationService.NavigateAsync("ContactUsPage");
          
        }

        void CallUsclicked()
        {
            PhoneDialer.Open("08120759252");

        }

        //public async void NavigateToBuilding25()
        //{
        //    var location = new Location(47.645160, -122.1306032);
        //    var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        //    await Map.OpenAsync(location, options);
        //}


        async void MapwithPlacemark()
        {
            var placemark = new Placemark
            {
                CountryName = "United States",
                AdminArea = "WA",
                Thoroughfare = "Microsoft Building 25",
                Locality = "Redmond"
            };
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            await Map.OpenAsync(placemark, options);
        }

        async void SignOut()
        {
            Settings.ClearEverything();
         //  await NavigationService.NavigateAsync("LandingPage");
          
            await NavigationService.NavigateAsync($"/{nameof(SharedTransitionNavigationPage)}/{nameof(LandingPage)}");
           // await NavigationService.NavigateAsync("/LandingPage");
            //await NavigationService.NavigateAsync(new System.Uri("LoginPage",System.UriKind.Absolute));

        }



        //async void profileClicked()
        //{
        //    await CrossMedia.Current.Initialize();

        //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        // await DisplayAlert("OOOps", "pick photo is not support! ", "ok");
        //        await App.Current.MainPage.DisplayAlert("OOOps", "Pick photo is not supported!", "Ok");
        //        return;
        //    }
        //    var file = await CrossMedia.Current.PickPhotoAsync();

        //    if (file == null)
        //        return;

        //    //PathLabel.Text = "photo path" + file.Path;

        //    Imagee.Source = ImageSource.FromStream(() =>

        //    {
        //        var stream = file.GetStream();
        //        file.Dispose();
        //        return stream;
        //    });
        //}

        //async void profileClicked()
        //{
        //    await CrossMedia.Current.Initialize();
        //    bool response = await App.Current.MainPage.DisplayAlert("Confirm", "Select Where to pick Image from", "Gallery", "Camera");
        //    if (response)
        //    {

        //        if (!CrossMedia.Current.IsTakePhotoSupported)
        //        {
        //            // await DisplayAlert("OOOps", "pick photo is not support! ", "ok");
        //            await App.Current.MainPage.DisplayAlert("OOOps", "Pick photo is not supported!", "Ok");
        //            return;
        //        }
        //        //var file = await CrossMedia.Current.PickPhotoAsync();
        //        var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
        //        {
        //            // this helps to control the picture quality
        //            PhotoSize = PhotoSize.Large
        //        });


        //        if (file == null)
        //            return;

        //        //PathLabel.Text = "photo path" + file.Path;

        //        Imagee.Source = ImageSource.FromStream(() =>
        //        //imageASource = ImageSource.FromStream(() =>

        //        {
        //            var stream = file.GetStream();
        //            file.Dispose();
        //            return stream;
        //        });
        //    }

        //    else
        //    {
        //        if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        //        {
        //            // await DisplayAlert("No Pick photo", " :( No camera available.", "OK");
        //            await App.Current.MainPage.DisplayAlert("OOOps", "Pick photo is not supported!", "Ok");
        //            return;
        //        }
        //        //var file = await CrossMedia.Current.PickPhotoAsync();
        //        // var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
        //        var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
        //        {
        //            // this helps to control the picture quality
        //            PhotoSize = PhotoSize.Large
        //        });
        //        if (file == null)
        //            return;
        //        Imagee.Source = ImageSource.FromStream(() =>

        //        {
        //            var stream = file.GetStream();
        //            file.Dispose();
        //            return stream;
        //        });
        //    }

        //}






    }
}
