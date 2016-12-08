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
    class PostViewModel : ViewModelBase
    {
        //navigation page
        public void GotoPostDriverPage() =>
            NavigationService.Navigate(typeof(Views.PostDriverPage));

        public void GotoPostPassengerPage() =>
            NavigationService.Navigate(typeof(Views.PostPassengerPage));
    }
}
