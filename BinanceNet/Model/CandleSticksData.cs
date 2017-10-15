using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BinanceNet.Enums;
using Newtonsoft.Json.Converters;

namespace BinanceNet.Model {
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
