using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismForWPFSample.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public string Text { get; }

        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Second Page";
            Text = "Second Pageです。";
        }
    }
}
