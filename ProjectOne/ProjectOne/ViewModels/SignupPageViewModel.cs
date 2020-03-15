using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class SignupPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private DelegateCommand _signInCommand;
        public DelegateCommand SignInCommand => _signInCommand ?? (_signInCommand = new DelegateCommand(SignIn));

         private DelegateCommand _termsCommand;
        public DelegateCommand TermsCommand => _termsCommand ?? (_termsCommand = new DelegateCommand(TermsClicked));


        public SignupPageViewModel(INavigationService navigationService) :
             base(navigationService)
        {
            _navigationService = navigationService;
        }

        async void SignIn()
        {
            await _navigationService.NavigateAsync("LoginPage");
        }
         async void TermsClicked()
        {
            await _navigationService.NavigateAsync("TermsAndCondPage");
        }

    }
}
