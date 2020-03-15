using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class ViewBViewModel : ViewModelBase
    {
        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand
            = new DelegateCommand(ExecuteNavigateCommand));
        public ViewBViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "ViewB";
            _navigationService = navigationService;
        }
        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("/NavigationPage/MainPage");
        }
    }
}
