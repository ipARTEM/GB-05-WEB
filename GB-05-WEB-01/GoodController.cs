using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GB_05_WEB_01
{
    public class GoodController : ApiController
    {
        private static readonly HttpClient HttpClient;

        static GoodController()
        {
            HttpClient = new HttpClient();
        }
    }
}
