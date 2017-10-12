using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
    public class TradeHistoryData {
        public long FirstTradeId { get; }
        public long LastTradeId { get; }
        public DateTimeOffset StartTime { get; }
        public DateTimeOffset EndTime { get; }

        public AggregatedTrade[] Trades { get; }
    }
}
