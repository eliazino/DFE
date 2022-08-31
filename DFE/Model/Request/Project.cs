using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Model.Request {
    public class Project {
        public string id { get; set; }
        [Required]
        public string projectName { get; set; }
        [Required]
        public string projectDetails { get; set; }
        public long dateCreated { get; set; }
        public int status { get; set; }
    }
}
