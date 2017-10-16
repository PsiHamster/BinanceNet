namespace BinanceNet.Model.General {
    public class AllBookTickers {
        public BookTicker[] BookTickers { get; }

        public AllBookTickers(BookTicker[] data) {
            BookTickers = data;
        }
    }
}
