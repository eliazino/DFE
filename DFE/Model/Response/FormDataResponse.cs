using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Response {
    public class FormDataResponse {
        public List<FormData> data { get; set; }
    }

    public class FormData {
        public string id { get; set; }
        public string schemaID { get; set; }
        public string projectID { get; set; }
        public Dictionary<string, dynamic> data { get; set; }
    }
}
