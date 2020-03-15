using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic; 
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private DelegateCommand _favoriteCommand;
        public DelegateCommand FavoriteCommand => _favoriteCommand ?? (_favoriteCommand = new DelegateCommand(FavoriteClicked));
        
        private DelegateCommand _homeCommand;
        public DelegateCommand HomeCommand => _homeCommand ?? (_homeCommand = new DelegateCommand(HomeClicked));


        public ProfilePageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            _navigationService = navigationService;
        }

        async void FavoriteClicked()
        {
            await _navigationService.NavigateAsync("FavoritePage");
        }
         async void HomeClicked()
        {
            await _navigationService.NavigateAsync("HomePage");
        }


    }
}
