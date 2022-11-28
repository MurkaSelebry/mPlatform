using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace mPlatform.MVVM.ViewModel
{
    class DiscoveryViewModel
    {
        public string urlMedia { get; set; }
        public MovieViewModel mv;
        public DiscoveryViewModel(MovieViewModel mv)
        {
            this.mv = mv;
        }
    }
}
