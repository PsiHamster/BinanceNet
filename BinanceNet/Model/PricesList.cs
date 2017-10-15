using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
    /// <summary>
    /// List of prices.
    /// </summary>
    public class PricesList {
        public PriceEntry[] Prices { get; }

        // TODO: Implement methods

        public PricesList(PriceEntry[] data) {
            Prices = data;
        }
    }
}
