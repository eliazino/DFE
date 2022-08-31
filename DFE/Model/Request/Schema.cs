using DFE.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Request {
    public class Schema {
        public string fieldName { get; set; }
        public string fieldID { get; set; }
        public FieldType fieldType { get; set; }
        public List<FieldBehaviour> behavior { get; set; }
        public bool hide { get; set; }
        public string[] data { get; set; }
        public string dataSource { get; set; }
    }
}
