using Newtonsoft.Json;

namespace BinanceNet.Model.Account
{
    /// <summary>
    /// Contains balance of one asset
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountAssetBalanceUpdated
    {
        /// <summary>
        /// Asset name
        /// </summary>
        [JsonProperty("a")]
        public string Asset { get; set; }

        /// <summary>
        /// Count of asset that not locked (can use to trade)
        /// </summary>
        [JsonProperty("f")]
        public decimal Free { get; set; }

        /// <summary>
        /// Count of asset that locked (now in trade)
        /// </summary>
        [JsonProperty("l")]
        public decimal Locked { get; set; }

        public static implicit operator AccountAssetBalanceUpdated(AccountAssetBalance p)
            => new AccountAssetBalanceUpdated() { Asset = p.Asset, Free = p.Free, Locked = p.Locked };
    }
}