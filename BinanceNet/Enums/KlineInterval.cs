using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BinanceNet.Enums {
    /// <summary>
    /// Kline intervals
    /// m -> minutes; h -> hours; d -> days; w -> weeks; M -> months
    /// </summary>
    public enum KlineInterval {
        [JsonProperty("1m")]
        m1,
        [JsonProperty("3m")]
        m3,
        [JsonProperty("5m")]
        m5,
        [JsonProperty("15m")]
        m15,
        [JsonProperty("30m")]
        m30,
        [JsonProperty("1h")]
        h1,
        [JsonProperty("2h")]
        h2,
        [JsonProperty("4h")]
        h4,
        [JsonProperty("6h")]
        h6,
        [JsonProperty("8h")]
        h8,
        [JsonProperty("12h")]
        h12,
        [JsonProperty("1d")]
        d1,
        [JsonProperty("3d")]
        d3,
        [JsonProperty("1w")]
        w1,
        [JsonProperty("1M")]
        M1
    }
}
