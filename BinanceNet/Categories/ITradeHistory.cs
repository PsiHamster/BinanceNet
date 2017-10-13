using BinanceNet.Model;
using BinanceNet.Model.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Categories {
    /// <summary>
    /// Class implements connection to trade history and contains compressed, aggregate trades.
    /// Trades that fill at the time, from the same order, with the same price will have the quantity aggregated.
    /// </summary>
    public interface ITradeHistory {

        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Id of last update
        /// </summary>
        long LastUpdateId { get; }

        /// <summary>
        /// Is new trades listening
        /// </summary>
        bool IsListening { get; }

        /// <summary>
        /// Start Listen thread
        /// </summary>
        void StartListen();

        /// <summary>
        /// Stop Listen thread
        /// </summary>
        void StopListen();

        /// <summary>
        /// Clear and load new data from site.
        /// Use it if you don't need update in realtime
        /// but need newest data instead creating new book.
        /// </summary>
        /// <param name="limit">Default: 500 Max: 500</param>
        /// <returns><c>true</c> if success.</returns>
        Task<bool> RefreshData(int limit = 500);

        /// <summary>
        /// Last Time when any event / data gotten from server
        /// </summary>
        DateTimeOffset LastUpdateTime { get; }

        /// <summary>
        /// Get data from specified ID.
        /// </summary>
        /// <param name="fromId">ID to get aggregate trades from INCLUSIVE</param>
        /// <param name="limit">Default 500; max 500</param>
        Task<TradeHistoryData> GetDataFromIdAsync(long fromId, int limit = 500);

        /// <summary>
        /// Get data limited by time period.
        /// You can send only start and end time without limit.
        /// Or only one of time limits and <see cref="limit"/>
        /// </summary>
        /// <param name="startTime">Timestamp in ms to get aggregate trades from INCLUSIVE.</param>
        /// <param name="endTime">Timestamp in ms to get aggregate trades until INCLUSIVE.</param>
        /// <param name="limit">Default 500; max 500</param>
        Task<TradeHistoryData> GetDataInTimePeriodAsync(DateTimeOffset? startTime = null,
            DateTimeOffset? endTime = null, int limit = 500);

        /// <summary>
        /// Get latest aggregated trade history. Always returns new Data.
        /// </summary>
        TradeHistoryData CurrentData { get; }

        /// <summary>
        /// Occurs when an <see cref="TradeUpdateArgs"/> is received.
        /// </summary>
        event EventHandler<TradeUpdateArgs> OnDepthUpdate;

        /// <summary>
        /// Occurs whan error happens.
        /// </summary>
        event EventHandler<ReceiveErrorEventArgs> OnError;
    }
}
