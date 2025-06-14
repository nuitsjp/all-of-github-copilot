using Microsoft.EntityFrameworkCore;
using TodoListApi.Models;

namespace TodoListApi.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000);

                entity.Property(e => e.Priority)
                    .HasConversion<int>();

                entity.Property(e => e.CreatedAt)
                    .HasDefaultValueSql("GETUTCDATE()");

                entity.HasIndex(e => e.IsCompleted);
                entity.HasIndex(e => e.CreatedAt);
                entity.HasIndex(e => e.Priority);
            });

            // サンプルデータの追加
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = 1,
                    Title = "プロジェクトの企画書を作成",
                    Description = "新しいWebアプリケーションプロジェクトの企画書を作成する",
                    IsCompleted = false,
                    Priority = Priority.High,
                    CreatedAt = DateTime.UtcNow.AddDays(-2)
                },
                new TodoItem
                {
                    Id = 2,
                    Title = "API仕様書のレビュー",
                    Description = "REST API仕様書を確認してフィードバックを提供する",
                    IsCompleted = true,
                    Priority = Priority.Medium,
                    CreatedAt = DateTime.UtcNow.AddDays(-1),
                    CompletedAt = DateTime.UtcNow.AddHours(-2)
                },
                new TodoItem
                {
                    Id = 3,
                    Title = "ユニットテストの作成",
                    Description = "コントローラーとサービスクラスのユニットテストを作成する",
                    IsCompleted = false,
                    Priority = Priority.High,
                    CreatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
