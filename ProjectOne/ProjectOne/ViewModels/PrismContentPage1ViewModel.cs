using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class PrismContentPage1ViewModel : ViewModelBase
    {

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;
        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand
           = new DelegateCommand(ExecuteNavigateCommand));
        public List<Walkthrough> Walkthroughs { get => GetWalkthroughs(); }
        public PrismContentPage1ViewModel(INavigationService navigationService):
             base(navigationService)
        {
            Title = "My view A";
            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {

            await _navigationService.NavigateAsync("LoginPage");
        }

        private List<Walkthrough> GetWalkthroughs()
        {
            var walkThroughList = new List<Walkthrough>()
            {
                 new Walkthrough
                {
                    Heading = "Mountain",
                    Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
                    Image = "mountains.png"
                },
                 new Walkthrough
                {
                    Heading = "Cities",
                    Caption = "Explore the blue and sights of high rise buildings round the world",
                    Image = "Cities.png"
                },
                 new Walkthrough
                {
                    Heading = "Ancient",
                    Caption = "Explore the world from your point of view. Visit mountain and enjoy the freshness of life",
                    Image = "Ancient.png"
                }

            };
            return walkThroughList;


        }


    }
}
