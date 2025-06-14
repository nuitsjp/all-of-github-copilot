using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Text.Json;
using TodoListApi.Data;
using TodoListApi.DTOs;
using TodoListApi.Models;

namespace TodoListApi.Tests;

public class TodosControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly HttpClient _client;

    public TodosControllerIntegrationTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _client = _factory.CreateClient();
    }

    [Fact]
    public async Task GetTodos_ReturnsSuccessAndCorrectContentType()
    {
        // Act
        var response = await _client.GetAsync("/api/todos");

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal("application/json; charset=utf-8", 
            response.Content.Headers.ContentType?.ToString());
    }

    [Fact]
    public async Task GetTodos_ReturnsListOfTodos()
    {
        // Act
        var response = await _client.GetAsync("/api/todos");
        var content = await response.Content.ReadAsStringAsync();
        var todos = JsonSerializer.Deserialize<List<TodoItemDto>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        // Assert
        Assert.NotNull(todos);
        Assert.NotEmpty(todos);
        Assert.Equal(3, todos.Count); // サンプルデータの数
    }

    [Fact]
    public async Task CreateTodo_WithValidData_ReturnsCreatedTodo()
    {
        // Arrange
        var newTodo = new CreateTodoItemDto
        {
            Title = "新しいタスク",
            Description = "テスト用のタスクです",
            Priority = Priority.High
        };

        var json = JsonSerializer.Serialize(newTodo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/todos", content);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(System.Net.HttpStatusCode.Created, response.StatusCode);

        var responseContent = await response.Content.ReadAsStringAsync();
        var createdTodo = JsonSerializer.Deserialize<TodoItemDto>(responseContent, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.NotNull(createdTodo);
        Assert.Equal(newTodo.Title, createdTodo.Title);
        Assert.Equal(newTodo.Description, createdTodo.Description);
        Assert.Equal(newTodo.Priority, createdTodo.Priority);
        Assert.False(createdTodo.IsCompleted);
    }

    [Fact]
    public async Task CreateTodo_WithInvalidData_ReturnsBadRequest()
    {
        // Arrange - タイトルなしの無効なデータ
        var invalidTodo = new CreateTodoItemDto
        {
            Title = "", // 空のタイトル
            Description = "説明",
            Priority = Priority.Medium
        };

        var json = JsonSerializer.Serialize(invalidTodo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/todos", content);

        // Assert
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task GetTodo_WithValidId_ReturnsTodo()
    {
        // Act
        var response = await _client.GetAsync("/api/todos/1");

        // Assert
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var todo = JsonSerializer.Deserialize<TodoItemDto>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.NotNull(todo);
        Assert.Equal(1, todo.Id);
    }

    [Fact]
    public async Task GetTodo_WithInvalidId_ReturnsNotFound()
    {
        // Act
        var response = await _client.GetAsync("/api/todos/999");

        // Assert
        Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task UpdateTodo_WithValidData_ReturnsUpdatedTodo()
    {
        // Arrange
        var updateData = new UpdateTodoItemDto
        {
            Title = "更新されたタイトル",
            Priority = Priority.Low
        };

        var json = JsonSerializer.Serialize(updateData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PutAsync("/api/todos/1", content);

        // Assert
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        var updatedTodo = JsonSerializer.Deserialize<TodoItemDto>(responseContent, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.NotNull(updatedTodo);
        Assert.Equal(updateData.Title, updatedTodo.Title);
        Assert.Equal(updateData.Priority, updatedTodo.Priority);
    }

    [Fact]
    public async Task ToggleTodoCompletion_WithValidId_ReturnsNoContent()
    {
        // Act
        var response = await _client.PatchAsync("/api/todos/1/toggle", null);

        // Assert
        Assert.Equal(System.Net.HttpStatusCode.NoContent, response.StatusCode);
    }

    [Fact]
    public async Task DeleteTodo_WithValidId_ReturnsNoContent()
    {
        // Arrange - まず新しいTodoを作成
        var newTodo = new CreateTodoItemDto
        {
            Title = "削除予定のタスク",
            Description = "このタスクは削除されます"
        };

        var json = JsonSerializer.Serialize(newTodo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var createResponse = await _client.PostAsync("/api/todos", content);
        
        var createdContent = await createResponse.Content.ReadAsStringAsync();
        var createdTodo = JsonSerializer.Deserialize<TodoItemDto>(createdContent, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        // Act
        var response = await _client.DeleteAsync($"/api/todos/{createdTodo!.Id}");

        // Assert
        Assert.Equal(System.Net.HttpStatusCode.NoContent, response.StatusCode);
    }

    [Fact]
    public async Task GetTodosByStatus_WithCompletedTrue_ReturnsCompletedTodos()
    {
        // Act
        var response = await _client.GetAsync("/api/todos/filter/status?completed=true");

        // Assert
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var todos = JsonSerializer.Deserialize<List<TodoItemDto>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.NotNull(todos);
        Assert.All(todos, todo => Assert.True(todo.IsCompleted));
    }

    [Fact]
    public async Task GetTodosByPriority_WithHighPriority_ReturnsHighPriorityTodos()
    {
        // Act
        var response = await _client.GetAsync("/api/todos/filter/priority?priority=High");

        // Assert
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var todos = JsonSerializer.Deserialize<List<TodoItemDto>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.NotNull(todos);
        Assert.All(todos, todo => Assert.Equal(Priority.High, todo.Priority));
    }
}
