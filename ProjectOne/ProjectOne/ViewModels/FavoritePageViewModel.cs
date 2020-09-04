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

        private DelegateCommand _delegateSelectionCommand;
        public DelegateCommand NavigateSelectionCommand => _delegateSelectionCommand ?? (_delegateSelectionCommand = new DelegateCommand(ExecuteSelectionCommand));


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

        private Walkthrough selectedItem;
        public Walkthrough SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                SetProperty(ref selectedItem, value);
            }
        }
        private async void ExecuteSelectionCommand()
        {
            if (SelectedItem != null)
            {
                var parameters = new NavigationParameters();
                parameters.Add("nav", SelectedItem);
                await NavigationService.NavigateAsync("FoodDetailPage", parameters);
                SelectedItem = null;
            }
        }


        private List<Walkthrough> GetWalkthroughs()
        {
            var walkThroughList = new List<Walkthrough>()
            {
                 new Walkthrough
                {
                    Heading = "Rice",
                    Caption = "Delious",
                    Image = "foodone",
                    ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Beams",
                    Caption = "sweet",
                    Image = "foodtwo",
                     ItemPrice =2000
                },

                  new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfour",
                     ItemPrice =2000
                },
                  new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfive",
                     ItemPrice =2000
                },
                     new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodsix",
                     ItemPrice =2000
                },

                     new Walkthrough
                {
                    Heading = "Rice",
                    Caption = "Delious",
                    Image = "foodone",
                     ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Beams",
                    Caption = "sweet",
                    Image = "foodtwo",
                     ItemPrice =2000
                },

                  new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfour",
                     ItemPrice =2000
                },
                  new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfive",
                     ItemPrice =2000
                },
                     new Walkthrough
                {
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodsix",
                     ItemPrice =2000
                }

            };
            App.countNumber = walkThroughList.Count;
            return walkThroughList;
        }

    }
}
