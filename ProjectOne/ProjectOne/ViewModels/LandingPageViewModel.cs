using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class LandingPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private DelegateCommand _signInCommand;
        public DelegateCommand SignInCommand => _signInCommand ?? (_signInCommand = new DelegateCommand(SignIn));

        private DelegateCommand _signUpCommand;
        public DelegateCommand SignUpCommand => _signUpCommand ?? (_signUpCommand = new DelegateCommand(SignUp));

        public LandingPageViewModel(INavigationService navigationService) :
             base(navigationService)
        {
            _navigationService = navigationService;
        }

          async void SignIn()
        {

            await _navigationService.NavigateAsync("LoginPage");
        }
           async void SignUp()
        {

            await _navigationService.NavigateAsync("SignupPage");
        }

    }
}
