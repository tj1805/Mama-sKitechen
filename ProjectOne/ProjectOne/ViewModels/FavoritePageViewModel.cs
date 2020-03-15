using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class FavoritePageViewModel : ViewModelBase
    {

        //public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }

        private readonly INavigationService _navigationService;

        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }

        private DelegateCommand _profileCommand;
        public DelegateCommand ProfileCommand => _profileCommand ?? (_profileCommand = new DelegateCommand(ProfileClicked));

        private DelegateCommand _homeCommand;
        public DelegateCommand HomeCommand => _homeCommand ?? (_homeCommand = new DelegateCommand(HomeClicked));


        public FavoritePageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            _navigationService = navigationService;
        }

        async void ProfileClicked()
        {
            await _navigationService.NavigateAsync("ProfilePage");

        }

        async void HomeClicked()
        {
            await _navigationService.NavigateAsync("HomePage");
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
                },

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

        //private List<Walkthrough> GetWalkthroughs()
        //{
        //    var walkThroughList = new List<Walkthrough>()
        //    {
        //         new Walkthrough
        //        {
        //            Heading = "Mountain",
        //            Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
        //            Image = "mountains.png"
        //        },
        //         new Walkthrough
        //        {
        //            Heading = "Cities",
        //            Caption = "Explore the blue and sights of high rise buildings round the world",
        //            Image = "Cities.png"
        //        },
        //         new Walkthrough
        //        {
        //            Heading = "Ancient",
        //            Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
        //            Image = "Ancient.png"
        //        }

        //    };
        //    return walkThroughList;


        //}

        //private List<Walkthrough> GetWalkthroughs()
        //{
        //    var list = new List<Walkthrough>();
        //    list.Add(new Walkthrough
        //    {
        //        Heading = "Ancient",
        //        Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
        //        Image = "mountains.png"
        //    });
        //     list.Add(new Walkthrough
        //    {
        //        Heading = "Ancient",
        //        Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
        //        Image = "mountains.png"
        //    });
        //     list.Add(new Walkthrough
        //    {
        //        Heading = "Ancient",
        //        Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
        //        Image = "mountains.png"
        //    });




        //    return list;
        //}

    }
}
