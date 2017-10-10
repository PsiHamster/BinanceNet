using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BinanceNet.Categories;
using BinanceNet.Tests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinanceNet.Tests.BinanceClient {
    [TestClass]
    public class DepthBookTests {
        public static IBinanceClient Client { get; set; }
        public static IDepthBook Book { get; set; }
        public static string symbol { get; set; }

        [ClassInitialize]
        public static async void ClassInit(TestContext context) {
            symbol = TestsConfig.GetPairToTest();
            Client = new BinanceNet.BinanceClient ();
            Book = await Client.GetDepthBookAsync(symbol);
        }

        [TestMethod]
        public void IsBookGetted() {
            Assert.IsNotNull(Book);
            Assert.AreEqual(symbol, Book.Symbol);
        }

        [TestMethod]
        public void IsDataInBook() {
            Assert.IsTrue (Book.Bids.Length > 0);
            Assert.IsTrue (Book.Asks.Length > 0);
        }

        [TestMethod]
        public void IsFirstBidLowerThanFirstAsk() {
            Assert.IsTrue(Book.Bids.First().Price < Book.Asks.First().Price);
        }

        [TestMethod]
        public void IsRefreshWorksCorrectly() {
            var lastUpdateTime = Book.LastUpdateTime;
            Book.RefreshData();
            Assert.AreNotEqual(lastUpdateTime, Book.LastUpdateTime);
        }

        [TestMethod]
        public void IsListeningWorks() {
            // Book should not listen before this test
            Assert.IsFalse(Book.IsListening);
            var startTime = Book.LastUpdateTime;

            int updatesCount = 0;
            // Subscribe on update to increase updatesCount
            Book.OnDepthUpdate += (sender, data) => {
                updatesCount++;
                Assert.IsNotNull(data);
            };
            // If not any events happen in 10 sec than test is failed
            Thread.Sleep(10000);

            Assert.IsTrue(Book.LastUpdateTime != startTime);
            Assert.IsTrue(updatesCount > 0);
        }
    }
}
