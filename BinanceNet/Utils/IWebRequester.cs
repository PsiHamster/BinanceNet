using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Enums;
using BinanceNet.Model;

namespace BinanceNet.Utils {
    public interface IWebRequester {
        /// <summary>
        /// Used if you need to use proxy
        /// </summary>
        IWebProxy WebProxy { get; set; }

        /// <summary>
        /// Sending web request
        /// </summary>
        /// <typeparam name="T">Return type</typeparam>
        /// <param name="address">Adress of used method eg http https://www.binance.com/api/v3/order</param>
        /// <param name="queryObject">Object that will be converted to JSON and then to query string</param>
        /// <param name="securityType">Security type of method. Read binance API.</param>
        /// <param name="requestType">GET/POST/DELETE/PUT</param>
        /// <param name="apiKey">Send if security type not <see cref="SecurityType.None"/></param>
        /// <param name="secretKey">Send if security type <see cref="SecurityType.Signed"/></param>
        /// <returns></returns>
        Task<T> SendWebRequestAsync<T>(string address, object queryObject,
            SecurityType securityType = SecurityType.None,
            HttpMethod requestType = null,
            string apiKey = null,
            string secretKey = null);

        /// <summary>
        /// Occurs whan any Async method throws exception
        /// </summary>
        event EventHandler<ReceiveErrorEventArgs> OnReceiveError;
    }
}
