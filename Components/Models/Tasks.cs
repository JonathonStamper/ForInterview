namespace ForInterview.Models{

public class Tasks{
    public string Description {get; set;}

}

public enum TaskStatus{
    Nothing, // Default state.
    Busy,    // Task is in progress.
    Done     // Task is completed.

}}