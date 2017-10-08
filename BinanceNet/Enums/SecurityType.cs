using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Enums {
    /// <summary>
    /// Each endpoint has a security type that determines the how you will interact with it.
    /// </summary>
    public enum SecurityType {
        /// <summary>
        /// Endpoint can be accessed freely.
        /// </summary>
        None,
        /// <summary>
        /// Endpoint requires sending a valid API-KEY.
        /// </summary>
        ApiKey,
        /// <summary>
        /// Endpoint requires sending a valid API-Key and signing the payload
        /// </summary>
        Signed
    }
}
