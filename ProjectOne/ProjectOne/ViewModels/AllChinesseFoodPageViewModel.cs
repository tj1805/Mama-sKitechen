using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;

namespace ProjectOne.ViewModels
{
    public class AllChinesseFoodPageViewModel : ViewModelBase
    {
        private DelegateCommand _delegateSelectionCommand;
        public DelegateCommand NavigateSelectionCommand => _delegateSelectionCommand ?? (_delegateSelectionCommand = new DelegateCommand(ExecuteSelectionCommand));

        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));

        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }
        public AllChinesseFoodPageViewModel(INavigationService navigationService) :
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
            if(SelectedItem != null)
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
                    Image = "mealone",
                    ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealtwo",
                     ItemPrice =2000
                },

                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealthree",
                     ItemPrice =2000
                },
                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealfour",
                     ItemPrice =2000
                },
                     new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealfive",
                     ItemPrice =2000
                },

                     new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "Delious",
                    Image = "mealsix",
                     ItemPrice =2000
                },
                 new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealseven",
                     ItemPrice =2000
                },

                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealeight",
                     ItemPrice =2000
                },
                  new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealnine",
                     ItemPrice =2000
                },
                     new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealten",
                     ItemPrice =2000
                },
                new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealeleven",
                     ItemPrice =2000
                },
                new Walkthrough
                {
                    Heading = "Lorem",
                    Caption = "sweet",
                    Image = "mealforteen",
                     ItemPrice =2000
                }

            };
            return walkThroughList;
        }
    }
}
