using DFE.Model.Request;
using DFE.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFE.Infrastructure.Abstraction.API {
    public interface IDynamicRemote {
        Task<ResponseBody<ProjectResponse>> createProject(Project project);
        Task<ResponseBody<ProjectFetchResponse>> fetchProjects();
        Task<ResponseBody<SchemaResponse>> createSchema(SchemaRequest request);
        Task<ResponseBody<SchemaResponse>> getSchemaByID(string schemaID);
        Task<ResponseBody<SchemaResponse>> getSchemaByProject(string projectID);
        Task<ResponseBody<SchemaResponse>> updateSchema(SchemaRequest request);
        Task<ResponseBody<FormDataResponse>> getData(DataFilter filter);
    }
}
