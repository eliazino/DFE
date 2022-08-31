using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Request {
    public class RequestBody<T> {
        public T data { get; set; }
    }
}
