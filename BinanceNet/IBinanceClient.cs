using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Categories;
using BinanceNet.Enums;
using BinanceNet.Model;
using BinanceNet.Model.EventArgs;
using BinanceNet.Model.RequestResponse;
using BinanceNet.Utils;

namespace BinanceNet {
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
        /// Get Server DateTime object
        /// </summary>
        /// <returns>Current time on server</returns>
        Task<DateTime> GetServerTimeAsync();

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
        /// Get order book for choosed symbol
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <param name="limit">Default 100; Max 100;</param>
        /// <returns> Interface with access to current orders and possibility to update it. </returns>
        Task<IDepthBook> GetDepthBookAsync(string symbol, int limit = 100);

        /// <summary>
        /// Get compressed, aggregate trades for a symbol.
        /// Trades that fill at the time, from the same order,
        /// with the same price will have the quantity aggregated.
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <param name="fromId">ID to get aggregate trades from INCLUSIVE</param>
        /// <param name="startTime">Timestamp in ms to get aggregate trades from INCLUSIVE.</param>
        /// <param name="endTime">Timestamp in ms to get aggregate trades until INCLUSIVE.</param>
        /// <param name="limit">Default 500; Max 500;</param>
        /// <returns>Interface with access to trade history of choosen symbol</returns>
        Task<ITradeHistory> GetTradeHistoryAsync(string symbol, long fromId,
            DateTime? startTime = null,
            DateTime? endTime = null,
            int limit = 500);

        /// <summary>
        /// Get kline/candlestick bars for a symbol.
        /// Klines are uniquely identified by their open time.
        /// </summary>
        /// <param name="symbol">String contains name of trading pair e.g. BNBBTC </param>
        /// <param name="interval">Choose type of <see cref="KlineInterval"/> that you need</param>
        /// <param name="startTime">Timestamp in ms to get aggregate trades from INCLUSIVE.</param>
        /// <param name="endTime">Timestamp in ms to get aggregate trades until INCLUSIVE.</param>
        /// <param name="limit">Default 500; Max 500;</param>
        /// <returns>Interface with access to work with CandleSticks</returns>
        Task<ICandleSticks> GetCandleSticksAsync(string symbol, KlineInterval interval,
            DateTime? startTime = null,
            DateTime? endTime = null,
            int limit = 500);

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
