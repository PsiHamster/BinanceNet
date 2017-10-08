using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Model;
using BinanceNet.Model.EventArgs;

namespace BinanceNet.Categories {
    public interface IAccount : IDisposable {
        /// <summary>
        /// Try to authorize application with token.
        /// </summary>
        /// <param name="token">Token that you need get on binance</param>
        /// <returns><c>true</c> if success</returns>
        Task<bool> AuthorizeAsync(string token);

        /// <summary>
        /// Get current account information
        /// </summary>
        /// <returns>Account information</returns>
        Task<AccountInformation> GetAccountInformationAsync();

        /// <summary>
        /// Get OrderBook to check and perform actions with your orders.
        /// </summary>
        /// <returns>Order book with methods to place/delete/get orders</returns>
        IOrderBook OrderBook { get; }

        /// <summary>
        /// Occurs whan a account update is received.
        /// </summary>
        event EventHandler<AccountUpdateArgs> OnAccountUpdate;

        /// <summary>
        /// Occurs whan an order update is received.
        /// </summary>
        event EventHandler<OrderUpdateArgs> OnOrderUpdate;

        /// <summary>
        /// Occurs when a trade update is received.
        /// </summary>
        event EventHandler<TradeUpdateArgs> OnTradeUpdate;
    }
}
