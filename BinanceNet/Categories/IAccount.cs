using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Model;
using BinanceNet.Model.Account;
using BinanceNet.Utils;

namespace BinanceNet.Categories {
    public interface IAccount {
        /// <summary>
        /// Try to authorize application with token.
        /// </summary>
        /// <param name="token">Token that you need get on binance</param>
        /// <returns><c>true</c> if success</returns>
        Task<bool> AuthorizeAsync(string token);

        /// <summary>
        /// Is account authorized
        /// </summary>
        bool IsAuthorized { get; }

        /// <summary>
        /// Is account updates listening
        /// </summary>
        bool IsListening { get; }

        /// <summary>
        /// Start Listen thread
        /// </summary>
        void StartListen();

        /// <summary>
        /// Stop Listen thread
        /// </summary>
        void StopListen();

        /// <summary>
        /// Last Time when any event / data gotten from server
        /// </summary>
        TimeStamp LastUpdateTime { get; }

        /// <summary>
        /// Contains latest information about account
        /// </summary>
        AccountInformation AccountData { get; }

        /// <summary>
        /// Get current account information
        /// </summary>
        /// <returns>Account information</returns>
        Task<bool> UpdateAccountInformationAsync();

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
        event EventHandler<ExecutionReportUpdateArgs> OnOrderUpdate;

        /// <summary>
        /// Occurs when a trade update is received.
        /// </summary>
        event EventHandler<ExecutionReportUpdateArgs> OnTradeUpdate;
    }
}
