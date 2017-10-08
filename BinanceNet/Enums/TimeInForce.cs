using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Enums {
    public enum TimeInForce {
        /// <summary>
        /// Order will b
        /// </summary>
        ImmediateOrCancel,
        /// <summary>
        /// Order will continue to work within the system and in the marketplace until it executes or is canceled
        /// </summary>
        GoodTilCanceled
    }
}
