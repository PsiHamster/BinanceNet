using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Enums {
    public enum TimeInForce {
        /// <summary>
        /// ImmediateOrCancel order will closed immediate if it can't then will be cancel.
        /// </summary>
        IOC,
        /// <summary>
        /// GoodTilCanceled Order will continue to work within the system and in the marketplace until it executes or is canceled
        /// </summary>
        GTC
    }
}
