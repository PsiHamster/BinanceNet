using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Enums
{
    public enum OrderRejectReason
    {
        NONE,
        UNKNOWN_INSTRUMENT,
        MARKET_CLOSED,
        PRICE_QTY_EXCEED_HARD_LIMITS,
        UNKNOWN_ORDER,
        DUPLICATE_ORDER,
        UNKNOWN_ACCOUNT,
        INSUFFICIENT_BALANCE,
        ACCOUNT_INACTIVE,
        ACCOUNT_CANNOT_SETTLE
    }
}
