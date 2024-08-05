using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfImagenes.Helpers;
using WpfImagenes.Observable;

namespace WpfImagenes.Model
{
    public class GifItem : ObservableObject
    {
        private GifService service;

        private string _title = "";

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                SetProperty(ref _title, value);
                OnPropertyChanged(nameof(_title));
            }
        }

        private string _fullName = "";

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                SetProperty(ref _fullName, value);
                OnPropertyChanged(nameof(_fullName));
            }
        }

    }
}
