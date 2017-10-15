using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Model
{
    public class OrdersQueryList
    {
        public OrderQuery[] Orders { get; }

        public OrdersQueryList(OrderQuery[] data) {
            Orders = data;
        }
    }
}
