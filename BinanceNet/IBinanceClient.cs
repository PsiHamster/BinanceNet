using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Categories;
using BinanceNet.Enums;
using BinanceNet.Model;
using BinanceNet.Model.General;
using BinanceNet.Utils;

namespace BinanceNet {
    // TODO: recvWindow

    /// <summary>
    /// A client interface to use the Binance API
    /// </summary>
    public interface IBinanceClient {

        bool IsAuthorized { get; }

        IWebRequester WebRequester { get; set; }

        #region Events
        
        /// <summary>
        /// Occurs whan any Async method throws exception
        /// </summary>
        event EventHandler<ReceiveErrorEventArgs> OnReceiveError;

        #endregion

        
        #region PublicCommands

        /// <summary>
        /// Check connection to server
        /// </summary>
        /// <returns><c>true</c> if all is fine</returns>
        Task<bool> TestConnectionAsync();

        /// <summary>
        /// Get ServerTime
        /// </summary>
        /// <returns>Object contains server time in unix millis</returns>
        Task<ServerTime> GetServerTimeAsync();

        /// <summary>
        /// Get latest price for all symbols
        /// </summary>
        /// <returns>Prices list contains symbol and its price</returns>
        Task<PricesList> GetPricesListAsync();

        /// <summary>
        /// Best price/qty on the order book for all symbols.
        /// </summary>
        /// <returns>List contains all symbols with best prices to buy/sell and its qty</returns>
        Task<AllBookTickers> GetAllBookTickersAsync();

        #endregion

        #region SymbolCommands

        /// <summary>
        /// Get class provides order book for choosed symbol.
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <returns> Interface with access to current orders and possibility to update it. </returns>
        IDepthBook GetDepthBook(string symbol);

        /// <summary>
        /// Get class provides trade history book for choosed symbol.
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <returns>Interface with access to trade history of choosen symbol and possibility to update it. </returns>
        ITradeHistory GetTradeHistory(string symbol);

        /// <summary>
        /// Get kline/candlestick bars for a symbol.
        /// Klines are uniquely identified by their open time.
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <param name="interval">Choose type of <see cref="KlineInterval"/> that you need</param>
        /// <returns>Interface with access to work with CandleSticks</returns>
        ICandleSticks GetCandleSticks(string symbol, KlineInterval interval);

        /// <summary>
        /// Get 24 hour price change statistics for choosen symbol
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <returns>Object that contain stats</returns>
        Task<Symbol24Stats> GetSymbol24StatsAsync(string symbol);

        #endregion

        /// <summary>
        /// Get Account object to token that allows you to control
        /// open / closed orders.
        /// </summary>
        /// <param name="token">API-KEY that you can get on https://www.binance.com/userCenter/createApi.html page</param>
        /// <returns></returns>
        Task<IAccount> GetAccountAsync(string token);
    }
}
