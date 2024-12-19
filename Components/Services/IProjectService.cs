using ForInterview.Models;

namespace ForInterview.Services
{

    public interface IProjectService{
        List<Project>? GetProjects();
        
        // Project? GetProjectByNAme();
        // Project? SetProject();
    }
    
}