using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace mPlatform.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для MovieView.xaml
    /// </summary>
    public partial class MovieView : System.Windows.Controls.UserControl
    {
        public MovieView()
        {
            InitializeComponent();
            //mediaPlayer.Play();
            //mediaElement.Source = new Uri(@"Videos\1.mp4", UriKind.Relative);
            DispatcherTimer dt = new DispatcherTimer();
            dt.Tick += new EventHandler(timer_tick);
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Start();

        }







      
        private void timer_tick(object sender, EventArgs e)
        {
            slider_video.Value = mediaElement.Position.TotalSeconds;
        }

        

        

        private void slider_video_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaElement.Position = ts;
        }

        private void slider_audio_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = slider_audio.Value;
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(mediaElement.NaturalDuration.TimeSpan.TotalMilliseconds);
                slider_video.Maximum = ts.TotalSeconds;
            }
        }

    }
}
