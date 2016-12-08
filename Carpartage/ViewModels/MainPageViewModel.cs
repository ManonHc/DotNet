using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Template10.Services.NavigationService;

namespace Carpartage.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public void GotoSearchPage() =>
            NavigationService.Navigate(typeof(Views.SearchPage));
        
        public void GotoPostPage() =>
            NavigationService.Navigate(typeof(Views.PostPage));

        
    }
}

