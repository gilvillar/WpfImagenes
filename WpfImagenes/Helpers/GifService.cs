using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WpfImagenes.Model;

namespace WpfImagenes.Helpers
{
    public class GifService
    {
        private const string APY_KEY = "PjmhpWQ4VAW2pTibSHQeoQ9hCTCk1tVF";
        private string baseAddress = "https://api.giphy.com/v1/gifs/";



        HttpClient client;

        private string _prueba;

        public string Prueba
        {
            get { return _prueba; }
            set { _prueba = value; }
        }


        private List<Gif> _gifListService;

        public List<Gif> GifListService
        {
            get { return _gifListService; }
            set { _gifListService = value; }
        }

        private ObservableCollection<GifItem> _tagHistory;
        public ObservableCollection<GifItem> TagHistory
        {
            get
            {
                return _tagHistory;
            }
        }

        public GifService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _tagHistory = new ObservableCollection<GifItem>();
            _gifListService = new List<Gif>();

            _prueba = "esta es una prueba";


        }

        public async Task GetGifs(string tagSearch, int limite)
        {
            OrganizeHistory(tagSearch);

            SearchResponse? respuesta = null;

            string URL = $"https://api.giphy.com/v1/gifs/search?api_key={APY_KEY}&q={tagSearch}&limit={limite}";

            HttpResponseMessage? response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                respuesta = await response.Content.ReadFromJsonAsync<SearchResponse>();
            }

            if (respuesta != null)
            {
                this._gifListService = respuesta.Data;
                Prueba = tagSearch;
            }
        }

        private void OrganizeHistory(string tagSearch)
        {
            if (tagSearch != null)
            {
                GifItem item = new GifItem();
                item.Title = tagSearch;

                var toDelete = _tagHistory.Where(x => !x.Title.Equals(tagSearch));
                _tagHistory = new ObservableCollection<GifItem>(_tagHistory.Intersect(toDelete));


                TagHistory.Insert(0, new GifItem { Title = tagSearch });

                if (TagHistory.Count > 10)
                {
                    TagHistory.RemoveAt(10);
                }

                SetFullName();
            }
        }

        private void SetFullName()
        {
            for (int i = 0; i < _tagHistory.Count; i++)
            {
                TagHistory[i].FullName = $"{i + 1} - {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TagHistory[i].Title.ToLower())}";
                TagHistory[i].Title = $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TagHistory[i].Title.ToLower())}";
            }
        }
    }
}
