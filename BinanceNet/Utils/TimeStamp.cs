using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Utils {
    // TODO: Replace all DateTimeOffset with this class
    // TODO: Add long->TimeStamp
    public class TimeStamp {
        public DateTimeOffset Time { get; set; }

        public long UnixTime => Time.ToUnixTimeMilliseconds();

        public TimeStamp(long unixTimeMs) {
            Time = DateTimeOffset.FromUnixTimeMilliseconds(unixTimeMs);
        }
    }
}
