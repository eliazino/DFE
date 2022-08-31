using DFE.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Response {
    public class ProjectResponse {
        public Project project { get; set; }
    }
    public class ProjectFetchResponse {
        public List<Project> data { get; set; }
    }
}
