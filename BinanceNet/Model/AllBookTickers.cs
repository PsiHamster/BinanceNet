using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model {
    public class AllBookTickers {
        public BookTicker[] BookTickers { get; }

        public AllBookTickers(BookTicker[] data) {
            BookTickers = data;
        }
    }
}
