using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GB_05_WEB_01
{
    public class Program
    {
        static 

        public static async Task Main()
        {
            var result = Parsing("http://www.contoso.com/");

        }

        private static async Task Parsing(string url)
        {

            try
            {
                using (HttpClientHandler handler = new HttpClientHandler {AllowAutoRedirect=false,AutomaticDecompression=System.Net.DecompressionMethods.Deflate|System.Net.DecompressionMethods.GZip|System.Net.DecompressionMethods.None })
                {
                    using( HttpClient client = new HttpClient(handler))
                    {
                        using (HttpResponseMessage response = await client.GetAsync(url))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var html = response.Content.ReadAsStringAsync().Result;

                                if (!string.IsNullOrEmpty(html))
                                {

                                }
                            }
                        }
                    }
                }



                ////HttpResponseMessage response = await client.GetAsync(url);
                //response.EnsureSuccessStatusCode();
                //string responseBody = await response.Content.ReadAsStringAsync();
            

                //Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
