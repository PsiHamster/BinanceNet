﻿using Newtonsoft.Json;

namespace BinanceNet.Model.Account
{
    // TODO: Find better solution to convert same JSON's with different property names

    /// <summary>
    /// Contains balance of one asset
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountAssetBalance
    {
        /// <summary>
        /// Asset name
        /// </summary>
        [JsonProperty("asset")]
        public string Asset { get; set; }

        /// <summary>
        /// Count of asset that not locked (can use to trade)
        /// </summary>
        [JsonProperty("free")]
        public decimal Free { get; set; }

        /// <summary>
        /// Count of asset that locked (now in trade)
        /// </summary>
        [JsonProperty("locked")]
        public decimal Locked { get; set; }
        
        public static implicit operator AccountAssetBalance(AccountAssetBalanceUpdated p)
            => new AccountAssetBalance() {Asset = p.Asset, Free = p.Free, Locked = p.Locked};
    }
}