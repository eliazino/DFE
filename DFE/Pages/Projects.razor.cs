using DFE.Model.Request;

namespace DFE.Pages {
    public partial class Projects {
        private Project projectData = new Project();
        private async Task createProject() {
            if(string.IsNullOrEmpty(projectData.projectName) || string.IsNullOrEmpty(projectData.projectName)) {
                return;
            }
        }
    }
}
