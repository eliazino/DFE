using Microsoft.AspNetCore.Hosting;
namespace DFE.Model.Config {
    public class SystemVariables {
        public SystemVariables(IWebHostEnvironment env) {

        }
        public string version { get; set; }
        public string appName { get; set; }
        public string environmentName { get; set; }
        public string siteRoot { get; set; }
        public bool debug { get; set; }
        public Endpoints Endpoints { get; set; }
    }
    public class Endpoints {
        public string endpointRootUrl { get; set; } = "";
        public string createProject { get; set; } = "";
        public string getProject { get; set; } = "";
        public string createData { get; set; } = "";
        public string getData { get;set;}
        public string createSchema { get;set;}
        public string getSchemaByID { get;set;}
        public string getSchemaByProject { get;set;}
    }
}
