# TodoList API

Entity Framework、Web API、FluentValidationを使用したTodoListアプリケーションのAPIです。

## 機能

- **Todoアイテムの基本操作**
  - 作成、読み取り、更新、削除 (CRUD)
  - 完了状態の切り替え

- **フィルタリング機能**
  - 完了状態によるフィルタリング
  - 優先度によるフィルタリング

- **バリデーション**
  - FluentValidationによる入力値検証
  - 詳細なエラーメッセージ

- **ドキュメント**
  - Swagger UI による API ドキュメント

## プロジェクト構成

```
TodoListApi/
├── Controllers/
│   └── TodosController.cs          # Todoアイテム用Web APIコントローラー
├── Data/
│   └── TodoDbContext.cs            # Entity Framework DbContext
├── DTOs/
│   └── TodoItemDto.cs              # データ転送オブジェクト
├── Models/
│   └── TodoItem.cs                 # Todoアイテムエンティティモデル
├── Services/
│   ├── ITodoService.cs             # Todoサービスインターフェース
│   └── TodoService.cs              # Todoサービス実装
├── Validators/
│   └── TodoItemValidators.cs       # FluentValidationバリデーター
└── Program.cs                      # アプリケーション設定
```

## 使用技術

- **ASP.NET Core 10.0** - Web API フレームワーク
- **Entity Framework Core 9.0** - ORM
- **FluentValidation 11.11** - バリデーション
- **Swagger/OpenAPI** - API ドキュメント
- **InMemory Database** - 開発環境用データベース
- **SQL Server** - 本番環境用データベース

## 開始方法

### 前提条件
- .NET 10.0 SDK
- Visual Studio 2022 or Visual Studio Code

### 実行手順

1. プロジェクトディレクトリに移動:
   ```bash
   cd src/TodoListApi
   ```

2. パッケージの復元:
   ```bash
   dotnet restore
   ```

3. アプリケーションの実行:
   ```bash
   dotnet run
   ```

4. ブラウザで以下のURLにアクセス:
   - Swagger UI: `https://localhost:5001/` (または `http://localhost:5000/`)
   - API エンドポイント: `https://localhost:5001/api/todos`

## API エンドポイント

### 基本操作

| メソッド | エンドポイント | 説明 |
|---------|---------------|------|
| GET | `/api/todos` | すべてのTodoアイテムを取得 |
| GET | `/api/todos/{id}` | 指定IDのTodoアイテムを取得 |
| POST | `/api/todos` | 新しいTodoアイテムを作成 |
| PUT | `/api/todos/{id}` | 指定IDのTodoアイテムを更新 |
| DELETE | `/api/todos/{id}` | 指定IDのTodoアイテムを削除 |
| PATCH | `/api/todos/{id}/toggle` | 指定IDのTodoアイテムの完了状態を切り替え |

### フィルタリング

| メソッド | エンドポイント | 説明 |
|---------|---------------|------|
| GET | `/api/todos/filter/status?completed=true` | 完了済みのTodoアイテムを取得 |
| GET | `/api/todos/filter/status?completed=false` | 未完了のTodoアイテムを取得 |
| GET | `/api/todos/filter/priority?priority=High` | 高優先度のTodoアイテムを取得 |

### 優先度

- `Low` (1) - 低優先度
- `Medium` (2) - 中優先度  
- `High` (3) - 高優先度

## サンプルデータ

アプリケーション起動時に以下のサンプルデータが自動的に作成されます：

1. **プロジェクトの企画書を作成** (高優先度、未完了)
2. **API仕様書のレビュー** (中優先度、完了済み)
3. **ユニットテストの作成** (高優先度、未完了)

## 開発環境

開発環境では以下の設定が適用されます：

- **InMemoryDatabase**: データはメモリ上に保存され、アプリケーション停止時に削除されます
- **CORS**: すべてのオリジンからのアクセスを許可
- **Swagger UI**: ルートURL (`/`) でSwagger UIが表示されます
- **詳細ログ**: Entity Framework のクエリログが出力されます

## 本番環境への展開

本番環境では以下の設定を行ってください：

1. **データベース接続文字列の更新**:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=your-server;Database=TodoListDb;User Id=your-user;Password=your-password;"
     }
   }
   ```

2. **Environment Variables の設定**:
   ```
   ASPNETCORE_ENVIRONMENT=Production
   ```

3. **マイグレーションの実行**:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## トラブルシューティング

### よくある問題

1. **パッケージが見つからない**:
   ```bash
   dotnet restore
   ```

2. **ポートが使用中**:
   - `launchSettings.json` でポート番号を変更

3. **データベース接続エラー**:
   - 開発環境ではInMemoryDBを使用するため、通常問題ありません
   - 本番環境では接続文字列を確認してください

## ライセンス

このプロジェクトはMITライセンスの下で公開されています。
