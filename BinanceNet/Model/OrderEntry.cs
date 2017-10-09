using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceNet.Model {
    public class OrderEntry {
        /// <summary>
        /// Order price
        /// </summary>
        public decimal Price { get; }
        /// <summary>
        /// Quantity
        /// </summary>
        public decimal Quantity { get; }

        public OrderEntry(decimal[] data) {
            if (data.Length < 2)
                throw new InvalidDataException("Wrong number of params");

            Price = data[0];
            Quantity = data[1];
        }
    }
}
