using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Response {
    public class ResponseBody<T> {
        public StatusIdentifier error { get; set; }
        public StatusIdentifier success { get; set; }
        public T content { get; set; }
    }

    public class StatusIdentifier {
        public int status { get; set; }
        public string message { get; set; } = string.Empty;
    }
}
