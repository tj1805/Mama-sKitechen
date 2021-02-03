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
        public List<Walkthrough> ItalianList { get => GetItalianList(); }
        public List<Walkthrough> AfricanList { get => GetAfricanList(); }

       
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
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealone",
                    ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealtwo",
                      ItemPrice =2000
                },
               
                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealthree",
                    ItemPrice = 2000
                },
                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealfour",
                    ItemPrice = 2000
                },
                     new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealfive",
                    ItemPrice = 2000
                }

            };
            App.countNumber = walkThroughList.Count;
            return walkThroughList;
           }

        private List<Walkthrough> GetItalianList()
        {
            var walkThroughList = new List<Walkthrough>()
            {
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealsix",
                    ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealseven",
                      ItemPrice =2000
                },

                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealeight",
                    ItemPrice = 2000
                },
                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum",
                    Image = "mealnine",
                    ItemPrice = 2000
                },
                     new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum ",
                    Image = "mealfive",
                    ItemPrice = 2000
                }

            };
            return walkThroughList;
        }

         private List<Walkthrough> GetAfricanList()
        {
            var walkThroughList = new List<Walkthrough>()
            {
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum ",
                    Image = "mealforteen",
                    ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum ",
                    Image = "mealeleven",
                      ItemPrice =2000
                },

                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum ",
                    Image = "mealten",
                    ItemPrice = 2000
                },
                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum ",
                    Image = "mealnine",
                    ItemPrice = 2000
                },
                     new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "ipsum ",
                    Image = "mealfive",
                    ItemPrice = 2000
                }

            };
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
