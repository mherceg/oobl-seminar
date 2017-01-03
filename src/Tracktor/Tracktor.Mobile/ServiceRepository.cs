using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Tracktor.Domain;
using System.IO;
using Newtonsoft.Json;

namespace Tracktor.Mobile
{
    class ServiceRepository
    {
        public async Task<Object> fetchObject<T>(string uri, string method)
        {
            var request = WebRequest.Create(string.Format(@"http://tracktor.azurewebsites.net/api" + uri));
            //request.ContentType = "application/json";
            request.Method = method;
            //request.Headers["Accept-Encoding"] = "application/json";
            //request.Headers["Accept-Encoding"] = "gzip";
            Object returnObject = null;

            using (var response = (HttpWebResponse)(await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null)))
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    //something went wrong
                    //Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                }

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var content = reader.ReadToEnd();
                    if (!string.IsNullOrWhiteSpace(content))
                    {
                        returnObject = JsonConvert.DeserializeObject<T>(content);
                    }
                }
            }

            return returnObject;
        }
        public async Task<List<PlaceEntity>> getPlaces()
        {
            Object o = await fetchObject<List<Domain.PlaceEntity>>(@"/place/list", "GET");            

            return null;
        } 
    }
}
