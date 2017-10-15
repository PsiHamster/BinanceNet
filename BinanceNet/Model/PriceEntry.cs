using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
    /// <summary>
    /// Contains price of symbol
    /// </summary>
    [JsonObject (MemberSerialization.OptIn)]
    public class PriceEntry {
        /// <summary>
        /// Symbol of pair. e.g. LTCBTC
        /// </summary>
        [JsonProperty ("symbol")]
        public string Symbol { get; set; }
        
        /// <summary>
        /// Current price of symbol
        /// </summary>
        [JsonProperty ("price")]
        public decimal Price { get; set; }


    }
}
