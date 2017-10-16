using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinanceNet.Model;
using BinanceNet.Model.DepthBook;
using BinanceNet.Utils;

namespace BinanceNet.Categories {
    /// <summary>
    /// Class implements connection to depth book and contains bids/asks data.
    /// To get data call <see cref="GetLatestDataAsync"/>
    /// 
    /// If you want connect to wesocket:
    /// You need to use <see cref="StartListen"/> method to start update date in real time.
    /// If you don't need it use <see cref="StopListen"/> to stop listen.
    /// Subscribe on <see cref="OnUpdate"/> to get updates in real time
    /// </summary>
    public interface IDepthBook {
        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Get latest data async.
        /// </summary>
        /// <param name="limit">Default: 100 Max: 100</param>
        Task<DepthBookData> GetLatestDataAsync(int limit = 100);

        /// <summary>
        /// Is new orders listening
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
        DepthBookData CurrentData { get; }
        
        /// <summary>
        /// Occurs when an <see cref="DepthBookUpdateArgs"/> is received.
        /// </summary>
        event EventHandler<DepthBookUpdateArgs> OnUpdate;

        /// <summary>
        /// Occurs whan error happens.
        /// </summary>
        event EventHandler<ReceiveErrorEventArgs> OnError;
    }
}
