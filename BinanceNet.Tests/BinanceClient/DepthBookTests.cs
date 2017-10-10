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

        [ClassInitialize]
        public static async void ClassInit(TestContext context) {
            Client = new BinanceNet.BinanceClient ();
            Book = await Client.GetDepthBookAsync(TestsConfig.GetPairToTest());
        }

        [TestMethod]
        public void IsBookGetted() {
            Assert.IsNotNull(Book);
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
