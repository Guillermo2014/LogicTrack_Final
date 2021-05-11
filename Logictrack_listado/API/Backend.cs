using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Logictrack_listado.API
{
    public class Backend
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://upc-tracking-backend.herokuapp.com/api/");
            return Client;
        }
    }
}