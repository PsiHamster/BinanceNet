namespace BinanceNet.Model {
    public class ReceiveErrorEventArgs {
        /// <summary>
        /// Gets the API request exception
        /// </summary>
        public System.Exception Exception { get; }

        /// <summary>
        /// Contains request params in object.
        /// </summary>
        public object RequestParams { get; }

        /// <summary>
        /// Params in json.
        /// </summary>
        public string RequestJsonParams { get; }

        internal ReceiveErrorEventArgs(System.Exception exception, object requestParams = null, string requestJsonParams = null) {
            Exception = exception;
            RequestParams = requestParams;
            RequestJsonParams = requestJsonParams;
        }

        /// <summary>
        /// Perfom an implict conversion from <see cref="System.Exception"/> to <see cref="ReceiveErrorEventArgs"/>
        /// </summary>
        public  static implicit operator ReceiveErrorEventArgs(System.Exception e) => new ReceiveErrorEventArgs(e);
    }
}
