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

        /// <summary>
        /// Method returns current timestamp in server time. You need call <see cref="SetTimeStampCorrection"/> before it.
        /// </summary>
        public static TimeStamp CurrentTimeStamp()
            => DateTimeOffset.Now.ToUnixTimeMilliseconds() - TimeStampCorrection;

        public static long TimeStampCorrection { get; set; }

        /// <summary>
        /// Set correction between program and server time.
        /// </summary>
        /// <param name="serverTime"></param>
        public static void SetTimeStampCorrection(TimeStamp serverTime)
        {
            TimeStampCorrection = DateTimeOffset.Now.ToUnixTimeMilliseconds() - serverTime.UnixTime;
        }

        public static implicit operator TimeStamp(string s)
            => new TimeStamp(long.Parse(s));

        public static implicit operator TimeStamp(long s)
            => new TimeStamp(s);

        public static implicit operator TimeStamp(DateTimeOffset s)
            => new TimeStamp(s.ToUnixTimeMilliseconds());
        
        public static implicit operator DateTimeOffset(TimeStamp s)
            => s.Time;

        public static implicit operator string(TimeStamp s)
            => s.UnixTime.ToString();

        public static implicit operator long(TimeStamp s)
            => s.UnixTime;
    }
}
