using BinanceNet.Categories;
using BinanceNet.Enums;
using BinanceNet.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinanceNet.Tests.BinanceClient {
    [TestClass]
    public class BinanceClientTests {
        private readonly IBinanceClient client = new BinanceNet.BinanceClient ();

        [TestMethod]
        public void ConnectionTest() {
            var task = client.TestConnectionAsync();

            task.RunSynchronously();

            Assert.IsTrue(task.Result);
        }

        [TestMethod]
        public void GetServerTimeTest() {
            var task = client.GetServerTimeAsync();

            task.RunSynchronously();

            Assert.IsNotNull(task.Result);
        }

        [TestMethod]
        public void GetPriceListTest() {
            var task = client.GetPricesListAsync();

            task.RunSynchronously();

            Assert.IsInstanceOfType(task.Result, typeof(PricesList));
        }

        [TestMethod]
        public void GetAllBockTickersTest() {
            var task = client.GetAllBookTickersAsync();

            task.RunSynchronously();

            Assert.IsInstanceOfType(task.Result, typeof(AllBookTickers));
        }

        [TestMethod]
        public void GetDepthBookTest() {
            var task = client.GetDepthBookAsync(Utils.TestsConfig.GetPairToTest ());

            task.RunSynchronously ();

            Assert.IsInstanceOfType (task.Result, typeof (IDepthBook));
        }

        [TestMethod]
        public void GetTradeHistoryTest() {
            var task = client.GetTradeHistoryAsync(Utils.TestsConfig.GetPairToTest ());

            task.RunSynchronously ();

            Assert.IsInstanceOfType (task.Result, typeof (ITradeHistory));
        }

        [TestMethod]
        public void GetCandleSticksTest() {
            var task = client.GetCandleSticksAsync(Utils.TestsConfig.GetPairToTest (), KlineInterval.m5);

            task.RunSynchronously ();

            Assert.IsInstanceOfType (task.Result, typeof (ICandleSticks));
        }

        public void GetSymbol24HrStatsTest() {
            var task = client.GetSymbol24StatsAsync (Utils.TestsConfig.GetPairToTest());

            task.RunSynchronously ();

            Assert.IsInstanceOfType (task.Result, typeof (ICandleSticks));
        }

        [TestMethod]
        public void GetAccountTest() {
            var task = client.GetAccountAsync (Utils.TestsConfig.ApiToken);

            task.RunSynchronously ();

            Assert.IsInstanceOfType (task.Result, typeof (IAccount));
        }
    }
}
