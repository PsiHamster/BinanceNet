using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Categories;
using BinanceNet.Model;
using BinanceNet.Model.EventArgs;
using BinanceNet.Model.RequestParams;
using BinanceNet.Model.RequestResponse;

namespace BinanceNet {
    /// <summary>
    /// A client interface to use the Binance API
    /// </summary>
    public interface IBinanceClient {

        bool IsAuthorized { get; }

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
        Task<PricesListResponse> GetPricesListAsync();

        /// <summary>
        /// Best price/qty on the order book for all symbols.
        /// </summary>
        /// <returns>List contains all symbols with best prices to buy/sell and its qty</returns>
        Task<AllBookTickersResponse> GetAllBookTickersAsync();


        #endregion

        #region SymbolCommands

        /// <summary>
        /// Get order book for choosed symbol
        /// </summary>
        /// <param name="params">Params to perfom this request</param>
        /// <returns> Interface with access to current orders and possibility to update it. </returns>
        Task<IDepthBook> GetDepthBookAsync(DepthBookParams @params);

        /// <summary>
        /// Get compressed, aggregate trades.
        /// Trades that fill at the time, from the same order,
        /// with the same price will have the quantity aggregated.
        /// </summary>
        /// <param name="params">Params to perfom this request</param>
        /// <returns>Interface with access to trade history of choosen symbol</returns>
        Task<ITradeHistory> GetTradeHistoryAsync(TradeHistoryParams @params);

        /// <summary>
        /// Get kline/candlestick bars for a symbol.
        /// Klines are uniquely identified by their open time.
        /// </summary>
        /// <param name="params">Params to perfom this request</param>
        /// <returns>Interface with access to work with CandleSticks</returns>
        Task<ICandleSticks> GetCandleSticksAsync(CandleSticksParams @params);

        /// <summary>
        /// Get 24 hour price change statistics for choosen symbol
        /// </summary>
        /// <param name="symbol">Pair symbols</param>
        /// <returns>Object that contain stats</returns>
        Task<Symbol24StatsResponse> GetSymbol24HrStatsAsync(string symbol);

        #endregion

        #region Authorized commands

        Task<IAccount> GetAccountAsync(string token);
        
        #endregion
    }
}
