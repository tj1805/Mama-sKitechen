using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        

        private readonly INavigationService _navigationService;
        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }

        private DelegateCommand _favoriteCommand;
        public DelegateCommand FavoriteCommand => _favoriteCommand ?? (_favoriteCommand = new DelegateCommand(FavoriteClicked));
        
        private DelegateCommand _profileCommand;
        public DelegateCommand ProfileCommand => _profileCommand ?? (_profileCommand = new DelegateCommand(ProfileClicked));
        
         private DelegateCommand _itanlianSeeAllCommand;
        public DelegateCommand ItanlianSeeAllCommand => _itanlianSeeAllCommand ?? (_itanlianSeeAllCommand = new DelegateCommand(ItalianSeeAllClicked));
         
        private DelegateCommand _africanSeeAllCommand;
        public DelegateCommand AfricanSeeAllCommand => _africanSeeAllCommand ?? (_africanSeeAllCommand = new DelegateCommand(AfricanSeeAllClicked));
        
         private DelegateCommand _chinesseSeeAllCommand;
        public DelegateCommand ChinesseSeeAllCommand => _chinesseSeeAllCommand ?? (_chinesseSeeAllCommand = new DelegateCommand(ChinesseSeeAllClicked));
        


        //private DelegateCommand _testingCommand;
        //public DelegateCommand TestingCommand => _testingCommand ?? (_testingCommand = new DelegateCommand(SignIn));


        public HomePageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            _navigationService = navigationService;
        
        }

        private List<Walkthrough> GetWalkthroughs()
        {
            var walkThroughList = new List<Walkthrough>()
            {
                 new Walkthrough
                {
                    Heading = "Rice",
                    Caption = "Delious",
                    Image = "foodone"
                },
                 new Walkthrough
                {
                    Heading = "Beams",
                    Caption = "sweet",
                    Image = "foodtwo"
                },
               
                  new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfour"
                },
                  new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfive"
                },
                     new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodsix"
                }

            };
            App.countNumber = walkThroughList.Count;
            return walkThroughList;
           }
         
       
         async void FavoriteClicked()
        {
             await _navigationService.NavigateAsync("FavoritePage");
         
        }
        async void ProfileClicked()
        {
             await _navigationService.NavigateAsync("ProfilePage");
         
        }
         async void ItalianSeeAllClicked()
        {
             await _navigationService.NavigateAsync("AllItanlianFoodPage");
         
        }
         async void AfricanSeeAllClicked()
        {
             await _navigationService.NavigateAsync("AllAfricanFoodPage");
         
        }
          async void ChinesseSeeAllClicked()
        {
             await _navigationService.NavigateAsync("AllChinesseFoodPage");
         
        }
        



    }
}
