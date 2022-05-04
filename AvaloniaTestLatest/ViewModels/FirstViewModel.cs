using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaTestLatest.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {
        public StreamsViewModel Streams { get; set; }

        public FirstViewModel()
        {
            Streams = new StreamsViewModel();
        }
    }
}
