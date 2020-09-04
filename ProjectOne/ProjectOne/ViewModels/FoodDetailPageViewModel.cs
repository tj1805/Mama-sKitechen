using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectOne.ViewModels
{
    public class FoodDetailPageViewModel : ViewModelBase
    {
        public Walkthrough walkthroughs;

        private string image;

        private string heading;

        private string caption;

        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }
        public string Heading
        {
            get { return heading; }
            set { SetProperty(ref heading, value); }
        }
        public string Caption
        {
            get { return caption; }
            set { SetProperty(ref caption, value); }
        }
        private DelegateCommand _goBackCommand;
        public DelegateCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new DelegateCommand(GoBack));

        public FoodDetailPageViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("nav"))
            {
                walkthroughs = parameters.GetValue<Walkthrough>("nav");
                Image = walkthroughs.Image;
                Heading = walkthroughs.Heading;
                Caption = walkthroughs.Caption;

            }
        }   

        private async void GoBack()
        {
            await NavigationService.GoBackAsync();
        }
    }
}
