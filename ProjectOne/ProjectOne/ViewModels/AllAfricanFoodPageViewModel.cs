using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using ProjectOne.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class AllAfricanFoodPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        
        private DelegateCommand _delegateSelectionCommand;
        public DelegateCommand NavigateSelectionCommand => _delegateSelectionCommand ?? (_delegateSelectionCommand = new DelegateCommand(ExecuteSelectionCommand));

        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));


        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }

        public AllAfricanFoodPageViewModel(INavigationService navigationService) :
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
                     Id = 1,
                    Heading = "Rice",
                    Caption = "Delious",
                    Image = "foodone"
                },
                 new Walkthrough
                {   Id=2,
                    Heading = "Beams",
                    Caption = "sweet",
                    Image = "foodtwo"
                },

                  new Walkthrough
                {    Id=3,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfour"
                },
                  new Walkthrough
                {   Id=4,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfive"
                },
                     new Walkthrough
                {       Id=5,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodsix"
                },
                      new Walkthrough
                {  Id=6,
                    Heading = "Rice",
                    Caption = "Delious",
                    Image = "foodone"
                },
                 new Walkthrough
                { Id=7,
                    Heading = "Beams",
                    Caption = "sweet",
                    Image = "foodtwo"
                },

                  new Walkthrough
                { Id=8,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfour"
                },
                  new Walkthrough
                {  Id=9,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfive"
                },
                     new Walkthrough
                { Id=10,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodsix"
                },
                      new Walkthrough
                { Id=11,
                    Heading = "Rice",
                    Caption = "Delious",
                    Image = "foodone"
                },
                 new Walkthrough
                { Id=12,
                    Heading = "Beams",
                    Caption = "sweet",
                    Image = "foodtwo"
                },

                  new Walkthrough
                { Id=13,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfour"
                },
                  new Walkthrough
                {  Id=14,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodfive"
                },
                     new Walkthrough
                { Id=15,
                    Heading = "Yam",
                    Caption = "sweet",
                    Image = "foodsix"
                },

            };
            App.countNumber = walkThroughList.Count;
            return walkThroughList;
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
        private async void GoBack()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
