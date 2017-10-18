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
using System.Web;
using BinanceNet.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BinanceNet.Utils {
    class WebRequester : IWebRequester {
        public IWebProxy WebProxy { get; set; }
        
        public async Task<T> SendWebRequestAsync<T>(string address, object queryObject = null, SecurityType securityType = SecurityType.None,
            HttpMethod requestType = null, string apiKey = null, string secretKey = null) {
            requestType = requestType ?? HttpMethod.Get;

            // Adding "?" to query to do not check on empty query
            string query = queryObject != null ? "?" + GenerateQueryString(queryObject) : "";
            address += query;

            if (securityType != SecurityType.None)
            {
                client.DefaultRequestHeaders.Clear();

            }
            
            var request = new HttpRequestMessage() {
                RequestUri = new Uri(address),
                Method = requestType
            };


            if (requestType == HttpMethod.Get) {
                var responseString = await client.GetStringAsync(address+query);
            }
        }

        /// <inheritdoc/>
        public event EventHandler<ReceiveErrorEventArgs> OnReceiveError;

        private static string GenerateQueryString(object data)
        {
            if (data == null)
            {
                throw new ArgumentException("Data cannot be null");
            }

            var obj = (JObject)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(data));

            return string.Join("&", obj.Children()
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
