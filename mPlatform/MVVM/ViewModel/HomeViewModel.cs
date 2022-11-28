using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mPlatform.Core;

namespace mPlatform.MVVM.ViewModel
{
    class HomeViewModel: ObservableObject
    {
        public RelayCommand MovieViewCommand { get; set; }
        public MovieViewModel MovieVM { get; set; }
        public MainViewModel mainViewModel { get; set; }

        public ObservableCollection<MovieViewModel> Movies { get; set; }
        public MovieViewModel SelectedMovie
        {
            get { return MovieVM; }
            set
            {
                MovieVM = value;
                MovieVM.SetMovie(this);
                OnPropertyChanged("SelectedMovie");
            }
        }
        public HomeViewModel(MainViewModel mv)
        {
            Movies = new ObservableCollection<MovieViewModel> {
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("Мой домашний крокодил",new DateTime(2022,6,28),"Джош Гордон, Уилл Спек","США","мюзикл, фэнтези, комедия, приключения, семейный".Split(new char[] { ',' }),"Лайл – именно так зовут уникального в своем роде крокодила, который сильно отличается от многочисленных других представителей данного рода пресмыкающихся. " +
                "Ведь он – вовсе не кровожадное существо, а полная противоположность последнего. " +
                "Доброжелательно настроенный в отношении людей, он уже немалое время, как поддерживает свое существование на чердаке одного из пустующих старых домов в Нью-Йорке. Одним из его самых любимых хобби является пение, которым он увлекается еще с малых лет. Таким образом, он – поющий крокодил, который, к тому же, любит модно одеваться." + 
"В один из обычных дней в этот дом переезжает жить семейка Приммов, которые лишь недавно приобрели это жилье. Каковым огромным оказывается их удивление, когда в некий момент ни осознают, что на чердаке обитает самый настоящий крокодил. Изначально эти люди впадают в шок. Н уже спустя короткий период времени ни осознают, что имеют дело с самым добрым во всем мире крокодилом!",
8.4),
                "/Images/crocodile.png",
                "Videos/crocodile.mp4",
                10.0)),
                new MovieViewModel(new Model.Movie(
                new Model.MovieInfo("123",new DateTime(),"456","Russia",new string[] {"1","2"},"wow",10.0),
                "/Images/vakanda.png",
                "url",
                10.0)),
                };
            mainViewModel = mv;
           




        }
    }
}
