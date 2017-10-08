using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinanceNet.Tests.Utils {
    public static class TestsConfig {
        public static string ApiToken {
            get {
                try {
                    return LoadApiToken();
                } catch (FileNotFoundException) {
                    throw new FileNotFoundException(
                        "To test methods with API-KEY and SIGNED access please " +
                        "create TestToken.txt file with your API-KEY in " +
                        Directory.GetCurrentDirectory());
                }
            }
        }

        public static string[] PairsToTest => new string[] {"BTCETH", "LTCBTC" };

        public static string GetRandomPairToTest() {
            return PairsToTest[new Random().Next(0, PairsToTest.Length)];
        }

        private static string LoadApiToken() {
            string s;
            using (var r = new StreamReader("TestToken.txt")) {
                s = r.ReadToEnd();
            }
            return s;
        }
    }
}
