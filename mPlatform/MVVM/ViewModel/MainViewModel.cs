using System;
using System.Collections.Generic;
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
        public MovieViewModel MovieVM { get; set; }

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
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            MovieVM = 
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("123",new DateTime(),"456","Russia",new string[] {"1","2"},"wow",10.0),
                "/Images/2.jpg",
                "url",
                10.0));
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
                CurrentView = MovieVM;
            }
            );


        }

    }
}
    

