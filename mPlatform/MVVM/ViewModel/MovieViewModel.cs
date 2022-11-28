using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mPlatform.MVVM.Model;
using mPlatform.MVVM.View;
using mPlatform.Core;
using System.Windows.Controls;
using System.Windows;

namespace mPlatform.MVVM.ViewModel
{
    class MovieViewModel: ObservableObject
    {
        

        private Movie movie;
        private RelayCommand startCommand;
        

        public RelayCommand StartCommand
        {
            get
            {
                return startCommand ?? (startCommand = new RelayCommand((obj) =>
                {
                    MediaElement me = obj as MediaElement;
                    me.Play();

                }));
            }
        }

        
        public void SetMovie(HomeViewModel hvm)
        {
            hvm.mainViewModel.CurrentView = this;
        }
        public MovieViewModel(Movie movie)
        {
            this.movie = movie;
        }
        public string ImageSource { get => movie.ImageSource; set => movie.ImageSource = value; }
        public string Url { get => movie.Url; set => movie.Url = value; }
        public MovieInfo Title { get => movie.Title; set => movie.Title = value; }

        public double Rating { get => movie.Rating; set
            {
                movie.Rating = value;
                OnPropertyChanged("Rating");
            }
        }


    }
}
