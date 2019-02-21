using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PrismForWPFSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand NextCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            NextCommand = new DelegateCommand(() => NavigationService.NavigateAsync("SecondPage"));
        }
    }
}
