namespace BinanceNet.Model.Account
{
    public class OrdersQueryList
    {
        public OrderQuery[] Orders { get; }

        public OrdersQueryList(OrderQuery[] data) {
            Orders = data;
        }
    }
}
