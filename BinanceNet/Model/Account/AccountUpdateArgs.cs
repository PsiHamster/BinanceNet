using System;
using Newtonsoft.Json;

namespace BinanceNet.Model.Account
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountUpdateArgs
    {
        /// <summary>
        /// Event type (Normally need to be equal "outboundAccountInfo")
        /// </summary>
        [JsonProperty("e")]
        public string EventType { get; set; }
        
        /// <summary>
        /// Time of event
        /// </summary>
        [JsonProperty("E")]
        public DateTimeOffset EventTime { get; set; }

        [JsonProperty("m")]
        public long MakerCommission { get; set; }

        [JsonProperty("t")]
        public long TakerCommission { get; set; }

        [JsonProperty("b")]
        public long BuyerCommission { get; set; }

        [JsonProperty("s")]
        public long SellerCommission { get; set; }

        /// <summary>
        /// Can account place orders.
        /// </summary>
        [JsonProperty("T")]
        public bool CanTrade { get; set; }

        /// <summary>
        /// Can account withdraw assets.
        /// </summary>
        [JsonProperty("W")]
        public bool CanWithdraw { get; set; }

        /// <summary>
        /// Can account deposit assets.
        /// </summary>
        [JsonProperty("D")]
        public bool CanDeposit { get; set; }

        /// <summary>
        /// Array of balances.
        /// </summary>
        [JsonProperty("B")]
        public AccountAssetBalanceUpdated[] Balances { get; set; }
    }
}
