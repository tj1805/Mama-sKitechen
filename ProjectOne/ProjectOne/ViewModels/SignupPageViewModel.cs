using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using ProjectOne.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using XF.Material.Forms.UI.Dialogs;
using XF.Material.Forms.UI.Dialogs.Configurations;

namespace ProjectOne.ViewModels
{
    public class SignupPageViewModel : ViewModelBase
    {
        RemoteServices remoteServices;

        private string _surname;
        public string Surname 
        {
            get { return _surname; }
            set { SetProperty(ref _surname, value); }
        }

        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set { SetProperty(ref _firstname, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        
        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }
       
        private string _mobileNumber;
        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { SetProperty(ref _mobileNumber, value); }
        }
        
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
       
        private string _confirmPassword;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }
     
        private string _avatar;
        public string Avatar
        {
            get { return _avatar; }
            set { SetProperty(ref _avatar, value); }
        }
       
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }


        private DelegateCommand _signInCommand;
        public DelegateCommand SignInCommand => _signInCommand ?? (_signInCommand = new DelegateCommand(SignIn));
         private DelegateCommand _signUpCommand;
        public DelegateCommand SignUpCommand => _signUpCommand ?? (_signUpCommand = new DelegateCommand(SignUp));

         private DelegateCommand _termsCommand;
        public DelegateCommand TermsCommand => _termsCommand ?? (_termsCommand = new DelegateCommand(TermsClicked));

        public RemoteServices RemoteServices => RemoteServices1;

        public RemoteServices RemoteServices1 => remoteServices;

        public SignupPageViewModel(INavigationService navigationService) :
             base(navigationService)
        {
            remoteServices = new RemoteServices();
            IsBusy = true;
        }

        async void SignIn()
        {
            await NavigationService.NavigateAsync("LoginPage");
        }
        async void SignUp()
        {
            var network = Connectivity.NetworkAccess;
            if (network != NetworkAccess.Internet)
            {
                // using display alert with MVVM
                await Application.Current.MainPage.DisplayAlert("Alert", "Please check your internet connection ", "Ok");

                return;
            }
            if (Surname == null || Firstname == null || Email == null || Address == null || MobileNumber == null || Password == null || ConfirmPassword == null)
            {
                await Application.Current.MainPage.DisplayAlert("Alert", "Please input all fields", "Ok");
                return;
            }
            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Alert", "Please make sure Password and confirm passwoed are the same  ", "Ok");
                return;
            }
            IsBusy = false;

            //  add loading dialog here 
            var loadingDialogConfiguration = new MaterialLoadingDialogConfiguration()
            {
                BackgroundColor = Color.FromHex("010088"),
                MessageTextColor = Color.FromHex("FFFFFF"),
                //  MessageFontFamily = 
                TintColor = Color.FromHex("FFFFFF"),
                CornerRadius = 20,
                // ScrimColor = 
            };

            var snackBarconfiguration = new MaterialSnackbarConfiguration()
            {
                TintColor = Color.FromHex("#00FF01"),
                CornerRadius = 20,
                //  MessageTextColor = Color.White.MultiplyAlpha(0.6),
                MessageTextColor = Color.White,
                BackgroundColor = Color.FromHex("#010088")

            };

           var loadingDialog =  await MaterialDialog.Instance.LoadingDialogAsync(message: "Something is running...", configuration: loadingDialogConfiguration);

            // also add validation of user here oo or add in the remote class

            var signUp = new SignUp
            {
                Surname = this.Surname,
                FirstName = this.Firstname,
                Email = this.Email,
                Address = this.Address,
                MobileNumber = this.MobileNumber,
                Password = this.Password,
               ConfrimPassword = this.ConfirmPassword
             };

            var user = await remoteServices.SignUpAsync(signUp);

            await loadingDialog.DismissAsync();
            IsBusy = true;
            if (user)
            {
                Surname = null;
                Firstname = null;
                Email = null;
                Address = null;
                MobileNumber = null;
                Password = null;
                ConfirmPassword = null;

                await MaterialDialog.Instance.SnackbarAsync(message: "Account created successfully .",
                                            actionButtonText: "OK", 
                                            msDuration: 3000,
                                            configuration: snackBarconfiguration);
                await NavigationService.NavigateAsync("LoginPage");
            }
            else
            {
                await MaterialDialog.Instance.SnackbarAsync(message: "Sign up failed! Retry",
                                            actionButtonText: "OK",
                                            msDuration: 3000,
                                            configuration: snackBarconfiguration);
               // await Application.Current.MainPage.DisplayAlert("Alert", "Sign up failed ", "Ok");
            }

          
        }


         async void TermsClicked()
        {
            await NavigationService.NavigateAsync("TermsAndCondPage");
        }

    }
}
