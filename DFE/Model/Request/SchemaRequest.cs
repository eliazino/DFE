using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Request {
    public class SchemaRequest {
        public string id { get; set; }
        public string projectID { get; set; }
        public string schemaName { get; set; }
        public string schemaID { get; set; }
        public bool locked { get; set; } = false;
        public List<Schema> SchemaField { get; set; }
    }
}
