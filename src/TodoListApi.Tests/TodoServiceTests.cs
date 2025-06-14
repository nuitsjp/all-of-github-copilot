using Microsoft.EntityFrameworkCore;
using TodoListApi.Data;
using TodoListApi.DTOs;
using TodoListApi.Models;
using TodoListApi.Services;

namespace TodoListApi.Tests;

public class TodoServiceTests
{
    private TodoDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<TodoDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        return new TodoDbContext(options);
    }

    [Fact]
    public async Task GetAllTodosAsync_ReturnsAllTodos()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var todo1 = new TodoItem { Title = "Task 1", Description = "Description 1" };
        var todo2 = new TodoItem { Title = "Task 2", Description = "Description 2" };

        context.TodoItems.AddRange(todo1, todo2);
        await context.SaveChangesAsync();

        // Act
        var result = await service.GetAllTodosAsync();

        // Assert
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public async Task GetTodoByIdAsync_WithValidId_ReturnsTodo()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var todo = new TodoItem { Title = "Test Task", Description = "Test Description" };
        context.TodoItems.Add(todo);
        await context.SaveChangesAsync();

        // Act
        var result = await service.GetTodoByIdAsync(todo.Id);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(todo.Title, result.Title);
        Assert.Equal(todo.Description, result.Description);
    }

    [Fact]
    public async Task GetTodoByIdAsync_WithInvalidId_ReturnsNull()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        // Act
        var result = await service.GetTodoByIdAsync(999);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task CreateTodoAsync_WithValidData_CreatesAndReturnsTodo()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var createDto = new CreateTodoItemDto
        {
            Title = "New Task",
            Description = "New Description",
            Priority = Priority.High
        };

        // Act
        var result = await service.CreateTodoAsync(createDto);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(createDto.Title, result.Title);
        Assert.Equal(createDto.Description, result.Description);
        Assert.Equal(createDto.Priority, result.Priority);
        Assert.False(result.IsCompleted);

        // データベースに保存されているか確認
        var savedTodo = await context.TodoItems.FindAsync(result.Id);
        Assert.NotNull(savedTodo);
        Assert.Equal(createDto.Title, savedTodo.Title);
    }

    [Fact]
    public async Task UpdateTodoAsync_WithValidData_UpdatesAndReturnsTodo()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var todo = new TodoItem 
        { 
            Title = "Original Title", 
            Description = "Original Description",
            Priority = Priority.Low
        };
        context.TodoItems.Add(todo);
        await context.SaveChangesAsync();

        var updateDto = new UpdateTodoItemDto
        {
            Title = "Updated Title",
            Priority = Priority.High,
            IsCompleted = true
        };

        // Act
        var result = await service.UpdateTodoAsync(todo.Id, updateDto);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(updateDto.Title, result.Title);
        Assert.Equal(todo.Description, result.Description); // 変更されていない
        Assert.Equal(updateDto.Priority, result.Priority);
        Assert.True(result.IsCompleted);
        Assert.NotNull(result.CompletedAt);
    }

    [Fact]
    public async Task UpdateTodoAsync_WithInvalidId_ReturnsNull()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var updateDto = new UpdateTodoItemDto
        {
            Title = "Updated Title"
        };

        // Act
        var result = await service.UpdateTodoAsync(999, updateDto);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task DeleteTodoAsync_WithValidId_DeletesAndReturnsTrue()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var todo = new TodoItem { Title = "To Delete", Description = "Will be deleted" };
        context.TodoItems.Add(todo);
        await context.SaveChangesAsync();

        // Act
        var result = await service.DeleteTodoAsync(todo.Id);

        // Assert
        Assert.True(result);

        // データベースから削除されているか確認
        var deletedTodo = await context.TodoItems.FindAsync(todo.Id);
        Assert.Null(deletedTodo);
    }

    [Fact]
    public async Task DeleteTodoAsync_WithInvalidId_ReturnsFalse()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        // Act
        var result = await service.DeleteTodoAsync(999);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public async Task ToggleCompletionAsync_WithValidId_TogglesStatusAndReturnsTrue()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var todo = new TodoItem 
        { 
            Title = "Toggle Test", 
            IsCompleted = false,
            CompletedAt = null
        };
        context.TodoItems.Add(todo);
        await context.SaveChangesAsync();

        // Act
        var result = await service.ToggleCompletionAsync(todo.Id);

        // Assert
        Assert.True(result);

        // データベースの状態を確認
        var updatedTodo = await context.TodoItems.FindAsync(todo.Id);
        Assert.NotNull(updatedTodo);
        Assert.True(updatedTodo.IsCompleted);
        Assert.NotNull(updatedTodo.CompletedAt);
    }

    [Fact]
    public async Task GetTodosByCompletionStatusAsync_WithCompletedTrue_ReturnsOnlyCompletedTodos()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var completedTodo = new TodoItem 
        { 
            Title = "Completed", 
            IsCompleted = true,
            CompletedAt = DateTime.UtcNow
        };
        var incompleteTodo = new TodoItem 
        { 
            Title = "Incomplete", 
            IsCompleted = false
        };

        context.TodoItems.AddRange(completedTodo, incompleteTodo);
        await context.SaveChangesAsync();

        // Act
        var result = await service.GetTodosByCompletionStatusAsync(true);

        // Assert
        Assert.Single(result);
        Assert.True(result.First().IsCompleted);
        Assert.Equal("Completed", result.First().Title);
    }

    [Fact]
    public async Task GetTodosByPriorityAsync_WithHighPriority_ReturnsOnlyHighPriorityTodos()
    {
        // Arrange
        using var context = GetInMemoryDbContext();
        var service = new TodoService(context);

        var highPriorityTodo = new TodoItem 
        { 
            Title = "High Priority", 
            Priority = Priority.High
        };
        var lowPriorityTodo = new TodoItem 
        { 
            Title = "Low Priority", 
            Priority = Priority.Low
        };

        context.TodoItems.AddRange(highPriorityTodo, lowPriorityTodo);
        await context.SaveChangesAsync();

        // Act
        var result = await service.GetTodosByPriorityAsync(Priority.High);

        // Assert
        Assert.Single(result);
        Assert.Equal(Priority.High, result.First().Priority);
        Assert.Equal("High Priority", result.First().Title);
    }
}
