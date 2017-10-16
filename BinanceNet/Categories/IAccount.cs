﻿using System;
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
        
        #region OrdersControl

        /// <summary>
        /// Create new order
        /// </summary>
        /// <param name="requestData">Order params</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        Task<NewOrderResponse> CreateOrderAsync(NewOrderRequest requestData, long recvWindow = 5000);

        /// <summary>
        /// Create new order
        /// </summary>
        /// <param name="requestData">Order params</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        Task<NewOrderResponse> CreateTestOrderAsync(NewOrderRequest requestData, long recvWindow = 5000);

        /// <summary>
        /// Check an order's status
        /// Either orderId or origClientOrderId must be sent.
        /// </summary>
        /// <param name="symbol">Trade pair</param>
        /// <param name="timeStamp">Timestamp</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        Task<OrderQuery> QueryOrderAsync(string symbol, TimeStamp timeStamp, long? orderId = null,
            string origClientOrderId = null, long recvWindow = 5000);

        /// <summary>
        /// Cancel an active order.
        /// </summary>
        /// <param name="symbol">Trade pair</param>
        /// <param name="timeStamp">Timestamp</param>
        /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default.</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        Task<CancelOrderResponse> CancelOrderAsync(string symbol, TimeStamp timeStamp, long? orderId = null,
            string origClientOrderId = null, string newClientOrderId = null, long recvWindow = 5000);

        /// <summary>
        /// Get all open orders on a symbol.
        /// </summary>
        /// <param name="symbol">Trade pair</param>
        /// <param name="timeStamp">Timestamp</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        Task<OrdersQueryList> GetOpenOrdersAsync(string symbol, TimeStamp timeStamp, long recvWindow = 5000);

        /// <summary>
        /// Get all account orders; active, canceled, or filled.
        /// </summary>
        /// <param name="symbol">Trade pair</param>
        /// <param name="timeStamp">Timestamp</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        /// <param name="orderId">If orderId is set, it will get orders >= that orderId. Otherwise most recent orders are returned.</param>
        Task<OrdersQueryList> GetOpenOrdersAsync(string symbol, TimeStamp timeStamp, long recvWindow = 5000,
            int limit = 500, long? orderId = null);

        /// <summary>
        /// Get trades for a specific account and symbol.
        /// </summary>
        /// <param name="symbol">Trade pair</param>
        /// <param name="timeStamp">Timestamp</param>
        /// <param name="recvWindow">How many milliseconds after timestamp order is valid</param>
        /// <param name="fromId">TradeId to fetch from. Default gets most recent trades.</param>
        Task<AccountTradeEntry[]> GetTradesListAsync(string symbol, TimeStamp timeStamp, long recvWindow = 5000,
            int limit = 500, long? fromId = null);

        #endregion

        #region WebSocket

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
        
        #endregion
    }
}
