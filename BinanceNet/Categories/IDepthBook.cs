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
    /// 
    /// You need to use <see cref="StartListen"/> method to start update date in real time.
    /// If you don't need it use <see cref="StopListen"/> to stop listen.
    /// Also you can subscribe to <see cref="OnDepthUpdate"/> to get orders change in real time.
    /// </summary>
    public interface IDepthBook {
        
        /// <summary>
        /// String contains name of trading pair e.g. BNBBTC
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// Id of last update
        /// </summary>
        long LastUpdateId { get; }

        /// <summary>
        /// Is new orders listening
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
        /// Clear and load new data from site.
        /// Use it if you don't need update in realtime
        /// but need newest data instead creating new book.
        /// </summary>
        /// <param name="limit">Default: 100 Max: 100</param>
        /// <returns><c>true</c> if success.</returns>
        Task<bool> RefreshDataAsync(int limit = 100);

        /// <summary>
        /// Last Time when any event / data gotten from server
        /// </summary>
        DateTimeOffset LastUpdateTime { get; }

        /// <summary>
        /// All bids in depth book.
        /// </summary>
        DepthBookOrderEntry[] Bids { get; }

        /// <summary>
        /// All asks in depth book.
        /// </summary>
        DepthBookOrderEntry[] Asks { get; }

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
