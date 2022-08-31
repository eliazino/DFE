using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Response {
    public class FilterEntities {
        public string id { get; set; }
        public string fieldName { get; set; }
        public string fieldValue { get; set; }
        public string schemaID { get; set; }
        public string fieldID { get; set; }
    }
}
