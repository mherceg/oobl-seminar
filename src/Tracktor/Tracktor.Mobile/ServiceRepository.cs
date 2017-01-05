﻿using System;
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
        //public const string ServiceBaseURI = @"http://tracktor.azurewebsites.net/api";
        public const string ServiceBaseURI = @"http://localhost:5071/api";

        public async Task<T> fetchObject<T>(string uri, string method, Object argument)
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
                    //streamWriter.
                }
            }            

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

            return (T)returnObject;
        }

        public async Task<List<PlaceEntity>> getPlaces()
        {
            List<Domain.PlaceEntity> list = await fetchObject<List<Domain.PlaceEntity>>(@"/place/list", "GET", null);            

            return list;
        }

        public async Task<int> getSessionId(LoginEntity loginEntity)
        {
            int sessionId = await fetchObject<int>(@"/user/login/", "POST", loginEntity);

            return sessionId;
        }
    }
}
