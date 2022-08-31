using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Request {
    public class DataFilter {
        public string schemaID { get; set; }
        public List<FilterElement> filterBodyObj { get; set; }
    }
    public class FilterElement {
        public string fieldID { get; set; }
        public dynamic value { get; set; }
    }
}
