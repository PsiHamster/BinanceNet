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
        /// Get data from specified ID.
        /// </summary>
        /// <param name="fromId">ID to get aggregate trades from INCLUSIVE</param>
        Task<> GetDataFromId(long fromId, int limit = 500);

        /// <summary>
        /// Get data limited by time period.
        /// You can send only start and end time without limit.
        /// Or only one of time limits and <see cref="limit"/>
        /// </summary>
        /// <param name="startTime">Timestamp in ms to get aggregate trades from INCLUSIVE.</param>
        /// <param name="endTime">Timestamp in ms to get aggregate trades until INCLUSIVE.</param>
        /// <param name="limit">Default 500; max 500</param>
        Task<> GetDataInTimePeriod(DateTimeOffset? startTime = null,
            DateTimeOffset? endTime = null, int limit = 500);
    }
}
