using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
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



        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }

        private Walkthrough _foodSelection;
        public Walkthrough FoodSelection
        {
            get
            {
                return _foodSelection;
            }
            set
            {
                SetProperty(ref _foodSelection, value);
            }
        }

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
                },

            };
            App.countNumber = walkThroughList.Count;
            return walkThroughList;
        }

        private async void ExecuteSelectionCommand()
        {
            if (FoodSelection != null)
            {
                var a = new NavigationParameters();
                a.Add("nav", FoodSelection);
               await _navigationService.NavigateAsync("FoodDetailPage", a);
               // await NavigationService.NavigateAsync("FoodDetailPage", a);
                FoodSelection = null;
            }
        }
    }
}
