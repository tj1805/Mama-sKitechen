using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ProjectOne.ViewModels
{
    public class ContactUsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        
        private DelegateCommand _openMapCommand;
        public DelegateCommand OpenMapCommand => _openMapCommand ?? (_openMapCommand = new DelegateCommand(NavigateToBuilding25));
      
        private DelegateCommand _openMapPlaceMarkCommand;
        public DelegateCommand OpenMapPlaceMarkCommand => _openMapPlaceMarkCommand ?? (_openMapPlaceMarkCommand = new DelegateCommand(MapwithPlacemark));

        private DelegateCommand _callCommand;
        public DelegateCommand CallCommand => _callCommand ?? (_callCommand = new DelegateCommand(CallUsclicked));

        //private DelegateCommand _gotostoreClicked;
        //public DelegateCommand GotoStoreCommand => _gotostoreClicked ?? (_gotostoreClicked = new DelegateCommand(GotoStoreClicked));

        public ContactUsPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            _navigationService = navigationService;
        }
        //async void OpenMapclick()
        //{
        // //   to get current location
        //    //try
        //    //{
        //    //    var location = await Geolocation.GetLastKnownLocationAsync();

        //    //    if (location != null)
        //    //    {
        //    //        Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
        //    //    }
        //    //}
        //    //catch (FeatureNotSupportedException fnsEx)
        //    //{
        //    //    // Handle not supported on device exception
        //    //}
        //    //catch (FeatureNotEnabledException fneEx)
        //    //{
        //    //    // Handle not enabled on device exception
        //    //}
        //    //catch (PermissionException pEx)
        //    //{
        //    //    // Handle permission exception
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    // Unable to get location
        //    //}

        //    //var locations = new Location(47.645160, -122.1306032);
        //    //var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        //    //await Map.OpenAsync(locations, options);

        //}
         async void CallUsclicked()
        {
            //   await _navigationService.NavigateAsync("MapPage");
          //  await PlacePhoneCall("08120759252");

            try
            {
                PhoneDialer.Open("08120759252");
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
        public async void NavigateToBuilding25()
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            await Map.OpenAsync(location, options);
        }


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

        //public async Task PlacePhoneCall(string number)
        //{
        //    try
        //    {
        //        PhoneDialer.Open(number);
        //    }
        //    catch (ArgumentNullException anEx) 
        //    {
        //        // Number was null or white space
        //    }
        //    catch (FeatureNotSupportedException ex)
        //    {
        //        // Phone Dialer is not supported on this device.
        //    }
        //    catch (Exception ex)
        //    {
        //        // Other error has occurred.
        //    }
        //}

        

    }
}
