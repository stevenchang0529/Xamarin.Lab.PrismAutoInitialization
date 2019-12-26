using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Lab.PrismAutoInitialization.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand OnGoNext { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            this.OnGoNext = new DelegateCommand(() =>
              {

                  var p = new NavigationParameters() { { "model", new MyModel() } }; 
                  this.NavigationService.NavigateAsync("PrismContentPageA?data=指定名稱",p);
              });
        }


    }
    public class MyModel
    {
        public string Data => "56789";
    }
}
