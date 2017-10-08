using System;
using BinanceNet.Exception;

namespace BinanceNet.Model.EventArgs {
    public class ReceiveErrorEventArgs {
        /// <summary>
        /// Gets the API request exception
        /// </summary>
        public System.Exception Exception { get; private set; }

        internal ReceiveErrorEventArgs(System.Exception exception) {
            Exception = exception;
        }

        /// <summary>
        /// Perfom an implict conversion from <see cref="System.Exception"/> to <see cref="ReceiveErrorEventArgs"/>
        /// </summary>
        public  static implicit operator ReceiveErrorEventArgs(System.Exception e) => new ReceiveErrorEventArgs(e);
    }
}
