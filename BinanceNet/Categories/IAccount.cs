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
        /// Is account authorized
        /// </summary>
        bool IsAuthorized { get; }
        
        /// <summary>
        /// Get latest account information from site.
        /// </summary>
        /// <returns>Account information</returns>
        Task<AccountInformation> GetAccountInformationAsync();
        
        Task<>

        /// <summary>
        /// Is account updates listening
        /// </summary>
        bool IsListening { get; }

        /// <summary>
        /// Last Time when any event / data gotten from server
        /// </summary>
        TimeStamp LastUpdateTime { get; }

        /// <summary>
        /// Start Listen thread
        /// </summary>
        void StartListen();

        /// <summary>
        /// Stop Listen thread
        /// </summary>
        void StopListen();

        /// <summary>
        /// Contains latest information about account
        /// </summary>
        AccountInformation AccountData { get; }

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
