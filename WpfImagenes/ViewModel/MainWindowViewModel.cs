using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfImagenes.Helpers;
using WpfImagenes.Model;
using WpfImagenes.Observable;

namespace WpfImagenes.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {

        private string _tagSearch;
        private GifService service;

        public string TagSearch
        {
            get { return _tagSearch; }
            set
            {
                SetProperty(ref _tagSearch, value);
                OnPropertyChanged(nameof(_tagSearch));
            }
        }

        private List<Gif> _listGifs;

        public List<Gif> ListGifs
        {
            get { return _listGifs; }
            set
            {
                SetProperty(ref _listGifs, value);
                OnPropertyChanged(nameof(_listGifs));
            }
        }

        private GifItem? _item;

        public GifItem? Item
        {
            get { return _item; }
            set
            {
                SetProperty(ref _item, value);
                OnPropertyChanged(nameof(_item));
            }
        }


        private ObservableCollection<GifItem> _tagHistory;

        public ObservableCollection<GifItem> TagHistory
        {
            get { return _tagHistory; }
            set
            {
                SetProperty(ref _tagHistory, value);
                OnPropertyChanged(nameof(_tagHistory));
            }
        }

        private RelayCommand? _searchCommand;

        public RelayCommand? SearchCommand
        {
            get
            {
                if (_searchCommand == null)
                {
                    _searchCommand = new RelayCommand(async param => await SearchGif());
                }

                return _searchCommand;
            }
            set { _searchCommand = value; }
        }

        private RelayCommand? _searchGifCommand;

        public RelayCommand? SearchGifCommand
        {
            get
            {
                if (_searchGifCommand == null)
                {
                    _searchGifCommand = new RelayCommand(async param => await SearchGif());
                }

                return _searchGifCommand;
            }
            set { _searchGifCommand = value; }
        }

        public MainWindowViewModel()
        {
            _tagSearch = "";

            service = new GifService();

            _tagHistory = new ObservableCollection<GifItem>();
            //_listGifs = new List<Gif>();

            
        }

        private async Task SearchGif()
        {
            if(_item != null)
            {
                this._tagSearch = _item.Title;
            }

            await service.GetGifs(_tagSearch, 10);

            this.ListGifs = service.GifListService;

            this.TagHistory = service.TagHistory;

            TagSearch = "";
        }       

    }
}
