using TodoListApi.DTOs;
using TodoListApi.Models;

namespace TodoListApi.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoItemDto>> GetAllTodosAsync();
        Task<TodoItemDto?> GetTodoByIdAsync(int id);
        Task<TodoItemDto> CreateTodoAsync(CreateTodoItemDto createTodoDto);
        Task<TodoItemDto?> UpdateTodoAsync(int id, UpdateTodoItemDto updateTodoDto);
        Task<bool> DeleteTodoAsync(int id);
        Task<bool> ToggleCompletionAsync(int id);
        Task<IEnumerable<TodoItemDto>> GetTodosByCompletionStatusAsync(bool isCompleted);
        Task<IEnumerable<TodoItemDto>> GetTodosByPriorityAsync(Priority priority);
    }
}
