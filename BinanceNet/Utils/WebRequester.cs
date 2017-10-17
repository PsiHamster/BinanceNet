using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Enums;
using System.Security.Cryptography;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BinanceNet.Utils {
    class WebRequester : IWebRequester {
        public IWebProxy WebProxy { get; set; }
        
        public async Task<T> SendWebRequestAsync<T>(string address, object queryObject = null, SecurityType securityType = SecurityType.None,
            RequestType requestType = RequestType.GET, string apiKey = null, string secretKey = null) {

            string query = queryObject ??;
            if (securityType != SecurityType.None) {
                client.DefaultRequestHeaders.Clear();
                var e = new HttpClient();
            }
            

            if (requestType == RequestType.GET) {
                var responseString = await client.GetStringAsync(address+"?"+query);
            }
        }

        private static string GenerateQueryString(object request)
        {
            if (request == null)
            {
                throw new System.Exception("No request data provided - query string can't be created");
            }
            //TODO: Refactor to not require double JSON loop
            var obj = (JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(request, _settings));

            return String.Join("&", obj.Children()
                .Cast<JProperty>()
                .Select(j => j.Name + "=" + HttpUtility.UrlEncode(j.Value.ToString())));
        }

        public WebRequester(IWebProxy proxy = null)
        {
            WebProxy = proxy;
        }

        private static readonly HttpClient client = new HttpClient();
    }
}
