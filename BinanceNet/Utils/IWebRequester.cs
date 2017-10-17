using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Enums;

namespace BinanceNet.Utils {
    public interface IWebRequester {
        IWebProxy WebProxy { get; set; }
        
        Task<T> SendWebRequestAsync<T>(string address, T query,
            SecurityType securityType = SecurityType.None,
            RequestType requestType = RequestType.GET,
            string secretKey = null);
    }
}
