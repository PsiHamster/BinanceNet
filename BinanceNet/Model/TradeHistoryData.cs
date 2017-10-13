using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
    /// <summary>
    /// Contains data from aggregate trades list
    /// </summary>
    public class TradeHistoryData {
        /// <summary>
        /// First aggregated trade id contains here
        /// </summary>
        public long FirstAggId => Trades.Min(x => x.AggregateTradeId);
        /// <summary>
        /// Last aggregated trade id contains here
        /// </summary>
        public long LastAggId => Trades.Max(x => x.AggregateTradeId);
        
        /// <summary>
        /// First ID contains here
        /// </summary>
        public long FirstTradeId => Trades.Min (x => x.FirstTradeId);
        /// <summary>
        /// Last ID contains here
        /// </summary>
        public long LastTradeId => Trades.Max (x => x.LastTradeId);

        /// <summary>
        /// Min timestamp of aggregate trade contains here
        /// </summary>
        public DateTimeOffset StartTime => Trades.Min(x => x.TimeStamp);
        /// <summary>
        /// Max timestamp of aggregate trade contains here
        /// </summary>
        public DateTimeOffset EndTime => Trades.Max(x => x.TimeStamp);

        /// <summary>
        /// Contains array of aggregated trades
        /// </summary>
        public AggregatedTrade[] Trades { get; }
    }
}
