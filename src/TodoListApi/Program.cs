using Microsoft.EntityFrameworkCore;
using FluentValidation;
using FluentValidation.AspNetCore;
using TodoListApi.Data;
using TodoListApi.Services;
using TodoListApi.Validators;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

// Entity Framework設定
builder.Services.AddDbContext<TodoDbContext>(options =>
{
    // 開発環境ではInMemoryデータベースを使用
    if (builder.Environment.IsDevelopment())
    {
        options.UseInMemoryDatabase("TodoListDb");
    }
    else
    {
        // 本番環境ではSQL Serverを使用（接続文字列は設定ファイルから取得）
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
});

// FluentValidation設定
builder.Services.AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<CreateTodoItemDtoValidator>();

// サービス登録
builder.Services.AddScoped<ITodoService, TodoService>();

// API Explorer & Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { 
        Title = "TodoList API", 
        Version = "v1",
        Description = "TodoListアプリケーションのWeb API"
    });
    
    // XMLコメントファイルのパスを取得
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }
});

// CORS設定（開発環境用）
builder.Services.AddCors(options =>
{
    options.AddPolicy("DevelopmentPolicy", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// データベース初期化（開発環境でInMemoryDBを使用する場合）
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<TodoDbContext>();
        context.Database.EnsureCreated();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoList API v1");
        c.RoutePrefix = string.Empty; // Swaggerをルートに設定
    });
    app.UseCors("DevelopmentPolicy");
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
