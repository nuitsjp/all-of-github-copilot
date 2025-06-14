using Microsoft.EntityFrameworkCore;
using TodoListApi.Data;
using TodoListApi.DTOs;
using TodoListApi.Models;

namespace TodoListApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoDbContext _context;

        public TodoService(TodoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoItemDto>> GetAllTodosAsync()
        {
            var todos = await _context.TodoItems
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            return todos.Select(MapToDto);
        }

        public async Task<TodoItemDto?> GetTodoByIdAsync(int id)
        {
            var todo = await _context.TodoItems.FindAsync(id);
            return todo == null ? null : MapToDto(todo);
        }

        public async Task<TodoItemDto> CreateTodoAsync(CreateTodoItemDto createTodoDto)
        {
            var todo = new TodoItem
            {
                Title = createTodoDto.Title,
                Description = createTodoDto.Description,
                Priority = createTodoDto.Priority,
                CreatedAt = DateTime.UtcNow
            };

            _context.TodoItems.Add(todo);
            await _context.SaveChangesAsync();

            return MapToDto(todo);
        }

        public async Task<TodoItemDto?> UpdateTodoAsync(int id, UpdateTodoItemDto updateTodoDto)
        {
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null)
                return null;

            if (!string.IsNullOrEmpty(updateTodoDto.Title))
                todo.Title = updateTodoDto.Title;

            if (updateTodoDto.Description != null)
                todo.Description = updateTodoDto.Description;

            if (updateTodoDto.Priority.HasValue)
                todo.Priority = updateTodoDto.Priority.Value;

            if (updateTodoDto.IsCompleted.HasValue)
            {
                var wasCompleted = todo.IsCompleted;
                todo.IsCompleted = updateTodoDto.IsCompleted.Value;

                // 完了状態が変更された場合のタイムスタンプ更新
                if (!wasCompleted && todo.IsCompleted)
                    todo.CompletedAt = DateTime.UtcNow;
                else if (wasCompleted && !todo.IsCompleted)
                    todo.CompletedAt = null;
            }

            await _context.SaveChangesAsync();
            return MapToDto(todo);
        }

        public async Task<bool> DeleteTodoAsync(int id)
        {
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null)
                return false;

            _context.TodoItems.Remove(todo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ToggleCompletionAsync(int id)
        {
            var todo = await _context.TodoItems.FindAsync(id);
            if (todo == null)
                return false;

            todo.IsCompleted = !todo.IsCompleted;
            todo.CompletedAt = todo.IsCompleted ? DateTime.UtcNow : null;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<TodoItemDto>> GetTodosByCompletionStatusAsync(bool isCompleted)
        {
            var todos = await _context.TodoItems
                .Where(t => t.IsCompleted == isCompleted)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            return todos.Select(MapToDto);
        }

        public async Task<IEnumerable<TodoItemDto>> GetTodosByPriorityAsync(Priority priority)
        {
            var todos = await _context.TodoItems
                .Where(t => t.Priority == priority)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            return todos.Select(MapToDto);
        }

        private static TodoItemDto MapToDto(TodoItem todo)
        {
            return new TodoItemDto
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                IsCompleted = todo.IsCompleted,
                CreatedAt = todo.CreatedAt,
                CompletedAt = todo.CompletedAt,
                Priority = todo.Priority
            };
        }
    }
}
