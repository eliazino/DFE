using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Enum {
    public enum FieldBehaviour {
        UNIQUE = 1,
        AUTO_GENERATED_ID = 3,
        AUTO_GENERATED_DATE = 4,
        REQUIRED = 5,
        FILTERABLE_INPUT = 6,
        FILTERABLE_DROPDOWN = 7,
        FILTERABLE_DATE_RANGE = 8
    }
}
