namespace BinanceNet.Model.General {
    /// <summary>
    /// List of prices.
    /// </summary>
    public class PricesList {
        public PriceEntry[] Prices { get; }

        // TODO: Implement methods

        public PricesList(PriceEntry[] data) {
            Prices = data;
        }
    }
}
