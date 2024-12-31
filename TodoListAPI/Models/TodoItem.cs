namespace TodoListAPI.Models
{
    public class TodoItem
    {
        public int Id { get; set; } // Unique identifier
        public string? Title { get; set; } // The task description
        public bool IsCompleted { get; set; } // Status of the task
    }
}
