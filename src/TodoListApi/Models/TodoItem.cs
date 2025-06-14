using System.ComponentModel.DataAnnotations;

namespace TodoListApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Title { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string? Description { get; set; }
        
        public bool IsCompleted { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? CompletedAt { get; set; }
        
        public Priority Priority { get; set; } = Priority.Medium;
    }
    
    public enum Priority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }
}
