using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xamarin.Lab.PrismAutoInitialization.ViewModels
{
    public class PrismContentPageAViewModel : ViewModelBase, IAutoInitialize
    {
        private string _myValue;

        [AutoInitialize("data")]
        public string MyValue
        {
            get { return _myValue; }
            set { SetProperty(ref _myValue, value); }
        }

        [AutoInitialize(true)]
        public MyModel Model { get; set; }

        public PrismContentPageAViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
        }
    }
}
