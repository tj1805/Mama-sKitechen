using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using ProjectOne.Services;
using ProjectOne.Utils;
using System;
using System.Collections.Generic;

using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace ProjectOne.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        RemoteServices remoteServices;

        
        private readonly INavigationService _navigationService;

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }


        private DelegateCommand _signInCommand;
        public DelegateCommand SignInCommand => _signInCommand ?? (_signInCommand = new DelegateCommand(SignIn));

        
        private DelegateCommand _registerCommand;
        public DelegateCommand RegisterCommand => _registerCommand ?? (_registerCommand = new DelegateCommand(RegisterClicked));
      
        private DelegateCommand _forgetPasswordCommand;
        public DelegateCommand ForgetPasswordCommand => _forgetPasswordCommand ?? (_forgetPasswordCommand = new DelegateCommand(ForgotPasswordClicked));
      
        public LoginPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            _navigationService = navigationService;
            remoteServices = new RemoteServices();
            IsBusy = true;
        }

       
       
       
        async void SignIn()
        {
            // removed the signing up procees 
            await _navigationService.NavigateAsync("HomePage");

            //signing inn process
            //var loadingDialogConfiguration = new MaterialLoadingDialogConfiguration()
            //{
            //    BackgroundColor = Color.FromHex("010088"),
            //    MessageTextColor = Color.FromHex("FFFFFF"),
            //  TintColor = Color.FromHex("FFFFFF"),
            //    CornerRadius = 20,
            //};

            //var snackBarconfiguration = new MaterialSnackbarConfiguration()
            //{
            //    TintColor = Color.FromHex("#00FF01"),
            //    CornerRadius = 20,
            //    MessageTextColor = Color.White,
            //    BackgroundColor = Color.FromHex("#010088")
            //};

            //var network = Connectivity.NetworkAccess;
            //if(network != NetworkAccess.Internet)
            //{
            //    await MaterialDialog.Instance.SnackbarAsync(message: "Please connnect to internet",
            //                               actionButtonText: "OK",
            //                               msDuration: 3000,
            //                               configuration: snackBarconfiguration);
            //    return;
            //}

            //if(Email == null || Password == null)
            //{
            //    await MaterialDialog.Instance.SnackbarAsync(message: "Please Input fields",
            //                              actionButtonText: "OK",
            //                              msDuration: 3000,
            //                              configuration: snackBarconfiguration);
            //    return;
            //}
            //IsBusy = false;
            //var loadingDialog = await MaterialDialog.Instance.LoadingDialogAsync(message: "Something is running...", configuration: loadingDialogConfiguration);

            //var login = new Login()
            //{
            //    Email = this.Email,
            //    Password = this.Password
            //};
            //var loginservice = await remoteServices.LoginAsync(login);
            //await loadingDialog.DismissAsync();
            //IsBusy = true;
            //if(loginservice != null)
            //{
            //    Settings.Email = loginservice.Email;
            //    Settings.Address = loginservice.Address;
            //    Settings.MobileNumber = loginservice.MobileNumber;
            //    Settings.FirstName = loginservice.FirstName;
            //    Settings.Surname = loginservice.Surname;

            //    await _navigationService.NavigateAsync("HomePage");
            //}

            //else
            //{
            //    await MaterialDialog.Instance.SnackbarAsync(message: "login failed",
            //                             actionButtonText: "OK",
            //                             msDuration: 3000,
            //                             configuration: snackBarconfiguration);
            //}

        }

        async void RegisterClicked()
        {
        await _navigationService.NavigateAsync("SignupPage");
        }
         async void ForgotPasswordClicked()
        {
         await _navigationService.NavigateAsync("ForgetPasswordPage");
        }

    }
}
