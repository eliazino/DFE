using DFE.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Response {
    public class SchemaResponse {
        public Schema schema { get; set; }
    }
    public class SchemListResponse {
        public List<Schema> schema { get; set; }
        public List<FilterEntities> unSortedFilterData { get; set; }
    }
}
