namespace Task_Manager.Models
{
    public class TaskModel
    {
        public string Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string Status { get; set; } // Add the Status property
        // Add any other properties as needed
    }
}
