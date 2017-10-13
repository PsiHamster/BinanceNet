using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceNet.Exception {
    public  class ApiException : System.Exception {
        public int Code { get; }
        public string Msg { get; }

        public override string Message
            => $"Code:{Code}, Message:{Msg}";

        public ApiException(int code, string message) {
            Code = code;
            Msg = message;
        }
    }

    /// <summary>
    /// Throws when sended symbol is wrong 
    /// </summary>
    public class WrongSymbolException : ApiException {
        public WrongSymbolException(int code, string message) : base(code, message) { }
    }
}
