using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Tracktor.Domain;
using System.IO;
using Newtonsoft.Json;
using Tracktor.WebService.Models;

namespace Tracktor.Mobile
{
    class ServiceRepository
    {
        //public const string ServiceBaseURI = @"http://tracktor.azurewebsites.net/api";
        private const string ServiceBaseURI = @"http://localhost:5071/api";

        private async Task<T> fetchObject<T>(string uri, string method, Object argument)
        {
            var request = WebRequest.Create(string.Format(ServiceBaseURI + uri));
            request.Method = method;
            Object returnObject = null;

            if (argument != null)
            {
                request.ContentType = "application/json";
                using (var streamWriter = new StreamWriter(await request.GetRequestStreamAsync()))
                {
                    string json = JsonConvert.SerializeObject(argument);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
            }

            try
            {
                using (var response = (HttpWebResponse)(await Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null)))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            var content = reader.ReadToEnd();
                            if (!string.IsNullOrWhiteSpace(content))
                            {
                                returnObject = JsonConvert.DeserializeObject<T>(content);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return default(T);
            }

            return (T)returnObject;
        }

        public async Task<List<CategoryEntity>> getCategories()
        {
            List<Domain.CategoryEntity> list = await fetchObject<List<Domain.CategoryEntity>>(@"/category/list", "GET", null);

            return list;
        }

        private async Task<Dictionary<string, bool>> getCategoriesDict()
        {
            Dictionary<string, bool> categories = new Dictionary<string, bool>();
            List<Domain.CategoryEntity> list = await getCategories();
            foreach (var category in list)
            {
                categories[category.Name] = true;
            }
            return categories;
        }

        public async Task<List<PlaceEntity>> getPlaces(CategoriesContainer categoriesContainer)
        {
            string requestString = "active=true&future=true";
            if (categoriesContainer != null)
            {
                requestString = "active=" + categoriesContainer.time["current"].ToString()
                    + "&future=" + categoriesContainer.time["future"].ToString();
            }
            else
            {
                categoriesContainer = new CategoriesContainer()
                {
                    categories = await getCategoriesDict()
                };
            }
            List<Domain.PlaceEntity> list = await fetchObject<List<Domain.PlaceEntity>>(@"/place/filter?"+requestString, "POST", categoriesContainer.categories);

            if (list == null)
                list = new List<Domain.PlaceEntity>();

            return list;
        }

        public async Task<IEnumerable<InfoDTO>> getInfoDTO(PlaceEntity place)
        {
            IEnumerable<InfoDTO> collection = await fetchObject<IEnumerable<InfoDTO>>(@"/info/ListByPlace?PlaceId="+place.Id, "GET", null);
            
            return collection;
        }

        public async Task<bool> setVoteInfo(RateInfoPostDTO postDTO)
        {
            bool? result = await fetchObject<bool?>(@"/info/rate/", "POST", postDTO);

            if (result == null)
                return false;

            return (bool)result;
        }

        public async Task<int?> setComment(CommentPostDTO postDTO)
        {
            return await fetchObject<int?>(@"/comment/add", "POST", postDTO);
        }

        public async Task<int> getSessionId(LoginEntity loginEntity)
        {
            int? sessionId = await fetchObject<int?>(@"/user/login/", "POST", loginEntity);

            if (sessionId == null)
                return -1;

            return (int)sessionId;
        }
    }
}
