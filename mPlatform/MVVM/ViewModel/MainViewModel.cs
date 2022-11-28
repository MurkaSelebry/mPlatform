using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mPlatform.Core;

namespace mPlatform.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get;set;}
        public RelayCommand DiscoveryViewCommand{ get;set;}
        public RelayCommand MovieViewCommand{ get;set;}
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }
        
   
        public MainViewModel()
        {
            HomeVM = new HomeViewModel(this);
            DiscoveryVM = new DiscoveryViewModel();

            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            }
            );
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            }
            );
            MovieViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM.MovieVM;
            }
            );


        }

    }
}
    

