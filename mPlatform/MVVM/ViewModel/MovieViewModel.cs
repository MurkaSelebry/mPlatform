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
        private RelayCommand stopCommand;
        private RelayCommand pauseCommand;
        public MediaElement me;

        public RelayCommand StartCommand
        {
            get
            {
                return startCommand ?? (startCommand = new RelayCommand((obj) =>
                {
                    if (me==null)                  
                        me = obj as MediaElement;
                        
                   
                    me.Play();

                }));
            }
        }
        public RelayCommand StopCommand
        {
            get
            {
                return stopCommand ?? (stopCommand = new RelayCommand((obj) =>
                {
                    


                    me.Stop();

                }));
            }
        }
        public RelayCommand PauseCommand
        {
            get
            {
                return pauseCommand ?? (pauseCommand = new RelayCommand((obj) =>
                {



                    me.Pause();

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
