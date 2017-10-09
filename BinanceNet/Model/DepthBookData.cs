using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    /// <summary>
    /// Class contains Data of Depth Book
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DepthBookData {
        /// <summary>
        /// Id of last update
        /// </summary>
        [JsonProperty("lastUpdateId")]
        public long LastUpdateId { get; set; }

        /// <summary>
        /// All bids in depth book.
        /// </summary>
        public OrderEntry[] Bids { get; private set; }

        /// <summary>
        /// All asks in depth book.
        /// </summary>
        public OrderEntry[] Asks { get; private set; }

        /// <summary>
        /// SPECIAL FOR NEWTONSOFT.JSON
        /// YOU CAN USE <see cref="Bids"/> for it
        /// </summary>
        [JsonProperty ("bids")]
        public decimal[][] DecimalBids {
            get { return Bids.Select(x => new[] {x.Price, x.Quantity}).ToArray(); }
            set { Bids = value.Select(x => new OrderEntry(x)).ToArray(); }
        }
        
        /// <summary>
        /// SPECIAL FOR NEWTONSOFT.JSON
        /// YOU CAN USE <see cref="Asks"/> for it
        /// </summary>
        [JsonProperty ("asks")]
        public decimal[][] DecimalAsks {
            get { return Asks.Select (x => new[] { x.Price, x.Quantity }).ToArray (); }
            set { Asks = value.Select (x => new OrderEntry (x)).ToArray (); }
        }
    }
}
