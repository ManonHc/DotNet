using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace Carpartage.ViewModels
{
    class SearchViewModel : ViewModelBase
    {
        
        public void GotoSearchDriverPage() =>
            NavigationService.Navigate(typeof(Views.SearchDriverPage));

        public void GotoSearchPassengerPage() =>
            NavigationService.Navigate(typeof(Views.SearchPassengerPage));
    }
}
