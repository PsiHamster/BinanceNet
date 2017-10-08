using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Enums {
    /// <summary>
    /// Kline intervals
    /// m -> minutes; h -> hours; d -> days; w -> weeks; M -> months
    /// </summary>
    public enum KlineInterval {
        m1,
        m3,
        m5,
        m15,
        m30,
        h1,
        h2,
        h4,
        h6,
        h8,
        h12,
        d1,
        d3,
        w1,
        M1
    }
}
