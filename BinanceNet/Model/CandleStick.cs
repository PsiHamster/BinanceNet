using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Utils;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    /// <summary>
    /// Contains one kline bar uniquely identified by open time.
    /// </summary>
    [JsonConverter (typeof (ObjectToArrayConverter<CandleStick>))]
    public class CandleStick {
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty (Order = 1)]
        public DateTimeOffset OpenTime { get; set; }

        public CandleStick() {
            DateTimeOffset.FromUnixTimeMilliseconds();
        }
    }
}
