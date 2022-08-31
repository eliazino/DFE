using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Request {
    public class FormDataRequest {
        public string schemaID { get; set; }
        public string projectID { get; set; }
        public JObject dataField { get; set; }
    }
}
