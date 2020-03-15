using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {

        private DelegateCommand _navigateCommand;
        private DelegateCommand _navigateCommandTwo;
        private readonly INavigationService _navigationService;
        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand
            = new DelegateCommand(ExecuteNavigateCommand));
        public DelegateCommand NavigateCommandTwo => _navigateCommandTwo ?? (_navigateCommand
            = new DelegateCommand(ExecuteNavigateCommandTwo));
        public ViewAViewModel(INavigationService navigationService ):
            base(navigationService)
        {
            Title = "My view A";
            _navigationService = navigationService;
        }
        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("ViewB");
        }
        async void ExecuteNavigateCommandTwo()
        {
            await _navigationService.NavigateAsync("LoginPage");
        }
    }
}
