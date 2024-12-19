using ForInterview.Models;
namespace ForInterview.Services{


public class ProjectService : IProjectService {

    private static readonly List<Project> Projects = new List<Project>{
        new Project{
            Title = "The Hague network",
            Description = "This website was made to give students around Europe the opportunity to sign up for exchanges throught the website that I created, I was the sole developer here.",
            Language= "Javascript, Next Js, CMS",
            SiteURL= "https://jonathon-stamper.com/projects/thehaguenetwork"
            },
             
            new Project{
            Title = "Examentool (The Hague University)",
            Description = "I made a scanning application for the hague university, where students can scan their student ID and register for an exam. For the admins, I made a dashboard that sees in realtime how many student, which students specically and when they registered for a test.",
            Language= "Javascript, Next Js, Supabase", 
            SiteURL= "https://jonathon-stamper.com/projects/examentool"
            },

            new Project{
            Title = "Portal Horizon",
            Description = "This was a school project where we used a 3d modeling platform in combination with next js",
            Language= "Spline, Next JS", 
            SiteURL= "https://jonathon-stamper.com/projects/portal-horizon"
            },

            new Project{
            Title = "DNN (Gemeente Amsterdam)",
            Description = "A administrative dashboard for Gemeente Den haag. I made some features for this website such as the PDF generation",
            Language= "Javascript, Next JS", 
            SiteURL= "This was a private application."
            },

            new Project{
            Title = "Theater-Laak",
            Description = "A school project where we built a theater website where the user is able to buy tickets for oncoming shows",
            Language= "C#, React", 
            SiteURL= "School project is no longer hosted"
            },
            new Project{
            Title = "console Chess",
            Description = "A school project where I needed to program a robot to play chess against",
            Language= "C#, React", 
            SiteURL= "School project was not hosted"
            },

           
};
        
    

        // public Project GetProjectByName(string name){
        //                  throw new NotImplementedException();

        // }

        // public Project SetProject(string name, string description){
            
        //                  throw new NotImplementedException();
        // }
        
        public List<Project>? GetProjects(){
            return Projects;
        }
};
}