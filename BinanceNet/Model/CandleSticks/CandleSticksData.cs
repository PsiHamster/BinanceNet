using BinanceNet.Enums;

namespace BinanceNet.Model.CandleSticks {
    public class CandleSticksData {
        /// <summary>
        /// Interval of one CandleStick
        /// </summary>
        KlineInterval Interval { get; }

        /// <summary>
        /// Array of sticks
        /// </summary>
        CandleStick[] CandleSticks { get; }
        
        public CandleSticksData(KlineInterval interval, CandleStick[] data) {
            Interval = interval;
            CandleSticks = data;
        }
    }
}
