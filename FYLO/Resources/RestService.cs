using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using static System.Net.WebRequestMethods;

namespace FYLO.Resources
{
    public class RestService
    {
        public const string Url = "http://localhost:61001/api/base/";
        public HttpClient _client = new HttpClient();
    }
}
