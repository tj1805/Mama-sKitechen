using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class AllItanlianFoodPageViewModel : ViewModelBase
    {
        private DelegateCommand _delegateSelectionCommand;
        public DelegateCommand NavigateSelectionCommand => _delegateSelectionCommand ?? (_delegateSelectionCommand = new DelegateCommand(ExecuteSelectionCommand));

        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));


        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }
        public AllItanlianFoodPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {

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
    }
}
