using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

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
        }

        async void SignIn()
        {
           // await _navigationService.NavigateAsync("/ShellPage");
            await _navigationService.NavigateAsync("HomePage");
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
