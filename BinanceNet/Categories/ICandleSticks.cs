﻿using BinanceNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Model.CandleSticks;
using BinanceNet.Model.TradeHistory;
using BinanceNet.Utils;

namespace BinanceNet.Categories
{
    /// <summary>
    /// Class implements connection to CandleSticks.
    /// To get data call <see cref="GetLatestDataAsync"/>
    /// 
    /// If you want connect to wesocket:
    /// You need to use <see cref="StartListen"/> method to start update date in real time.
    /// If you don't need it use <see cref="StopListen"/> to stop listen.
    /// Subscribe on <see cref="OnUpdate"/> to get updates in real time
    /// </summary>
    public interface ICandleSticks {

        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        string Symbol { get; }
        
        #region DataGetters

        /// <summary>
        /// Get latest data from site async.
        /// </summary>
        /// <param name="limit">Default: 500 Max: 500</param>
        Task<CandleSticksData> GetLatestDataAsync(int limit = 500);

        /// <summary>
        /// Get data from specified ID.
        /// </summary>
        /// <param name="fromId">ID to get aggregate trades from INCLUSIVE</param>
        /// <param name="limit">Default 500; max 500</param>
        Task<CandleSticksData> GetDataFromIdAsync(long fromId, int limit = 500);

        /// <summary>
        /// Get data limited by time period.
        /// You can send only start and end time without limit.
        /// Or only one of time limits and <see cref="limit"/>
        /// </summary>
        /// <param name="startTime">Timestamp in ms to get aggregate trades from INCLUSIVE.</param>
        /// <param name="endTime">Timestamp in ms to get aggregate trades until INCLUSIVE.</param>
        /// <param name="limit">Default 500; max 500</param>
        Task<CandleSticksData> GetDataInTimePeriodAsync(TimeStamp startTime = null,
            TimeStamp endTime = null, int limit = 500);

        #endregion

        #region WebSocket

        /// <summary>
        /// Is new trades listening
        /// </summary>
        bool IsListening { get; }

        /// <summary>
        /// Id of last update
        /// </summary>
        long LastUpdateId { get; }

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
        /// Get latest copy of data that updates in real time.
        /// Will be null if <c>StartListen</c> not called.
        /// </summary>
        CandleSticksData CurrentData { get; }

        #endregion
        
        /// <summary>
        /// Occurs when an <see cref="TradeHistoryUpdateArgs"/> is received.
        /// </summary>
        event EventHandler<CandleSticksUpdateArgs> OnUpdate;

        /// <summary>
        /// Occurs when error happens.
        /// </summary>
        event EventHandler<CandleSticksUpdateArgs> OnError;
    }
}
