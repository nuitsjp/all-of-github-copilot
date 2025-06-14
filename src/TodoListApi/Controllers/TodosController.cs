using Microsoft.AspNetCore.Mvc;
using TodoListApi.DTOs;
using TodoListApi.Models;
using TodoListApi.Services;

namespace TodoListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;
        private readonly ILogger<TodosController> _logger;

        public TodosController(ITodoService todoService, ILogger<TodosController> logger)
        {
            _todoService = todoService;
            _logger = logger;
        }

        /// <summary>
        /// すべてのTodoアイテムを取得します
        /// </summary>
        /// <returns>Todoアイテムのリスト</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItemDto>>> GetTodos()
        {
            try
            {
                var todos = await _todoService.GetAllTodosAsync();
                return Ok(todos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Todoリストの取得中にエラーが発生しました");
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 指定されたIDのTodoアイテムを取得します
        /// </summary>
        /// <param name="id">TodoアイテムのID</param>
        /// <returns>Todoアイテム</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItemDto>> GetTodo(int id)
        {
            try
            {
                var todo = await _todoService.GetTodoByIdAsync(id);
                if (todo == null)
                {
                    return NotFound($"ID {id} のTodoアイテムが見つかりません");
                }
                return Ok(todo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ID {Id} のTodo取得中にエラーが発生しました", id);
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 新しいTodoアイテムを作成します
        /// </summary>
        /// <param name="createTodoDto">作成するTodoアイテムの情報</param>
        /// <returns>作成されたTodoアイテム</returns>
        [HttpPost]
        public async Task<ActionResult<TodoItemDto>> CreateTodo(CreateTodoItemDto createTodoDto)
        {
            try
            {
                var todo = await _todoService.CreateTodoAsync(createTodoDto);
                return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Todo作成中にエラーが発生しました");
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 指定されたIDのTodoアイテムを更新します
        /// </summary>
        /// <param name="id">TodoアイテムのID</param>
        /// <param name="updateTodoDto">更新する情報</param>
        /// <returns>更新されたTodoアイテム</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<TodoItemDto>> UpdateTodo(int id, UpdateTodoItemDto updateTodoDto)
        {
            try
            {
                var todo = await _todoService.UpdateTodoAsync(id, updateTodoDto);
                if (todo == null)
                {
                    return NotFound($"ID {id} のTodoアイテムが見つかりません");
                }
                return Ok(todo);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ID {Id} のTodo更新中にエラーが発生しました", id);
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 指定されたIDのTodoアイテムを削除します
        /// </summary>
        /// <param name="id">TodoアイテムのID</param>
        /// <returns>削除結果</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodo(int id)
        {
            try
            {
                var success = await _todoService.DeleteTodoAsync(id);
                if (!success)
                {
                    return NotFound($"ID {id} のTodoアイテムが見つかりません");
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ID {Id} のTodo削除中にエラーが発生しました", id);
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 指定されたIDのTodoアイテムの完了状態を切り替えます
        /// </summary>
        /// <param name="id">TodoアイテムのID</param>
        /// <returns>切り替え結果</returns>
        [HttpPatch("{id}/toggle")]
        public async Task<ActionResult> ToggleTodoCompletion(int id)
        {
            try
            {
                var success = await _todoService.ToggleCompletionAsync(id);
                if (!success)
                {
                    return NotFound($"ID {id} のTodoアイテムが見つかりません");
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ID {Id} のTodo完了状態切り替え中にエラーが発生しました", id);
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 完了状態でフィルタリングしたTodoアイテムを取得します
        /// </summary>
        /// <param name="completed">完了状態 (true: 完了済み, false: 未完了)</param>
        /// <returns>フィルタリングされたTodoアイテムのリスト</returns>
        [HttpGet("filter/status")]
        public async Task<ActionResult<IEnumerable<TodoItemDto>>> GetTodosByStatus([FromQuery] bool completed)
        {
            try
            {
                var todos = await _todoService.GetTodosByCompletionStatusAsync(completed);
                return Ok(todos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "完了状態 {Completed} でのTodoフィルタリング中にエラーが発生しました", completed);
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }

        /// <summary>
        /// 優先度でフィルタリングしたTodoアイテムを取得します
        /// </summary>
        /// <param name="priority">優先度 (1: Low, 2: Medium, 3: High)</param>
        /// <returns>フィルタリングされたTodoアイテムのリスト</returns>
        [HttpGet("filter/priority")]
        public async Task<ActionResult<IEnumerable<TodoItemDto>>> GetTodosByPriority([FromQuery] Priority priority)
        {
            try
            {
                var todos = await _todoService.GetTodosByPriorityAsync(priority);
                return Ok(todos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "優先度 {Priority} でのTodoフィルタリング中にエラーが発生しました", priority);
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }
    }
}
