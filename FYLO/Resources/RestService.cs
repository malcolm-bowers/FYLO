using FYLO.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FYLO.Resources
{
    public class RestService
    {
        public const string Url = "http://192.168.1.158:8000/api/";
        public HttpClient _client = new HttpClient();

        public ObservableCollection<Base> _bases;

        public async Task<ObservableCollection<Base>> GetAPIBases()
        {
            var baseUrl = Url + "base/?format=json";
            var content = await _client.GetStringAsync(baseUrl);
            var bases = JsonConvert.DeserializeObject<List<Base>>(content);

            _bases = new ObservableCollection<Base>(bases);

            return _bases;
        }


    }
}
