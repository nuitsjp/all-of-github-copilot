# Agent モードによる自律的なタスク実行

## 学習目標
Agent モードを使って、複雑なタスクを自律的に実行し、問題を反復的に解決する方法を学習します。

## 前提条件
- VS Code 1.99以降
- `chat.agent.enabled` 設定を有効化

## 学習内容

### 1. Agent モードの特徴

#### Edit モードとの違い

| 特徴 | Edit モード | Agent モード |
|------|------------|-------------|
| ファイル選択 | 手動で指定 | 自動で判断 |
| 実行範囲 | 指定ファイルのみ | 必要に応じて拡張 |
| ツール実行 | なし | ターミナル、ビルド、テスト |
| エラー対応 | 手動 | 自動的に修正を試行 |

### 2. Agent モードの開始

#### 演習1: 基本設定と起動

1. **設定の確認**
   ```json
   // settings.json
   {
     "chat.agent.enabled": true,
     "chat.agent.maxRequests": 15,
     "github.copilot.chat.agent.runTasks": true,
     "github.copilot.chat.agent.autoFix": true
   }
   ```

2. **Agent モードの起動**
   - Chat view を開く（Ctrl+Alt+I）
   - モードドロップダウンから「Agent」を選択
   - または直接開く: [VS Code Stable](vscode://GitHub.Copilot-Chat/chat?mode=agent)

### 3. シンプルなタスクの実行

#### 演習2: 新しいアプリケーションの作成

1. **Webアプリケーションの構築**
   ```
   プロンプト: タスク管理Webアプリケーションを作成してください。
   以下の機能を含めてください：
   - タスクのCRUD操作
   - 優先度の設定（高・中・低）
   - 期限の管理
   - 完了/未完了の切り替え
   - ASP.NET Core Web APIとして実装
   ```

2. **Agent モードの動作を観察**
   - ファイルの自動作成
   - 必要なパッケージのインストール
   - ビルドエラーの自動修正
   - 基本的なテストの追加

### 4. ツールの活用

#### 演習3: ツールの選択と実行

1. **利用可能なツール**
   - ファイル操作
   - ターミナルコマンド実行
   - ビルドとテストの実行
   - 問題の検出と修正

2. **ツールの制御**
   ```
   プロンプト: #fetch https://docs.microsoft.com/en-us/aspnet/core/security/authentication/jwt
   このドキュメントを参考に、JWT認証を実装してください。
   必要なNuGetパッケージをインストールし、
   認証ミドルウェアを設定してください。
   ```

3. **ツールの承認**
   - 初回実行時は承認が必要
   - "Continue"ボタンのドロップダウンで自動承認を設定可能

### 5. 複雑なタスクの実行

#### 演習4: マイクロサービスアーキテクチャの構築

1. **包括的なシステムの作成**
   ```
   プロンプト: マイクロサービスベースのEコマースシステムを構築してください。
   
   以下のサービスを作成：
   1. 商品サービス (Product Service)
      - 商品のCRUD
      - カテゴリ管理
      - 在庫管理
   
   2. 注文サービス (Order Service)
      - 注文の作成と管理
      - 注文履歴
      - ステータス管理
   
   3. ユーザーサービス (User Service)
      - ユーザー登録・認証
      - プロファイル管理
   
   4. APIゲートウェイ
      - ルーティング
      - 認証の一元化
   
   各サービスは独立したプロジェクトとして作成し、
   Docker Composeで起動できるようにしてください。
   ```

2. **Agent モードの反復的な動作**
   - プロジェクト構造の作成
   - 各サービスの実装
   - Dockerfileの生成
   - docker-compose.ymlの作成
   - エラーの検出と修正

### 6. 既存プロジェクトの改善

#### 演習5: レガシーコードのモダナイゼーション

1. **レガシープロジェクトの準備**
   ```csharp
   // LegacyApp/DataAccess.cs
   public class DataAccess
   {
       public DataTable GetUsers()
       {
           using (var conn = new SqlConnection("Server=.;Database=MyApp;Trusted_Connection=true;"))
           {
               conn.Open();
               var cmd = new SqlCommand("SELECT * FROM Users", conn);
               var adapter = new SqlDataAdapter(cmd);
               var dt = new DataTable();
               adapter.Fill(dt);
               return dt;
           }
       }
   }
   ```

2. **モダナイゼーションの実行**
   ```
   プロンプト: このレガシーアプリケーションをモダナイズしてください：
   
   1. Entity Framework Coreへの移行
   2. リポジトリパターンの実装
   3. 依存性注入の導入
   4. 非同期処理への変更
   5. 構成ファイルからの接続文字列読み込み
   6. 単体テストの追加
   
   既存の機能は維持しつつ、段階的に移行してください。
   ```

### 7. 問題の自動解決

#### 演習6: エラーの検出と修正

1. **意図的なエラーの導入**
   ```csharp
   public class BrokenCalculator
   {
       public int Divide(int a, int b)
       {
           return a / b; // ゼロ除算の可能性
       }
       
       public async Task<string> GetDataAsync()
       {
           var client = new HttpClient();
           return client.GetStringAsync("https://api.example.com/data").Result; // デッドロックの可能性
       }
   }
   ```

2. **Agent モードによる修正**
   ```
   プロンプト: BrokenCalculator.csのコードを分析し、
   潜在的な問題をすべて修正してください。
   修正後は単体テストを追加して、
   問題が解決されていることを確認してください。
   ```

### 8. カスタムツールとMCPサーバー

#### 演習7: 外部ツールの統合

1. **MCPサーバーの設定**
   ```json
   // mcp.json
   {
     "mcpServers": {
       "postgres": {
         "command": "npx",
         "args": ["@modelcontextprotocol/server-postgres"],
         "env": {
           "POSTGRES_CONNECTION_STRING": "postgresql://localhost/mydb"
         }
       }
     }
   }
   ```

2. **データベース連携タスク**
   ```
   プロンプト: #postgres データベースから商品情報を取得し、
   それをベースにWeb APIを作成してください。
   既存のテーブル構造を分析し、
   適切なエンティティクラスとリポジトリを生成してください。
   ```

## 実践プロジェクト

### シナリオ: フルスタックアプリケーションの構築

Agent モードを使って、完全なアプリケーションを構築します：

1. **要件定義**
   ```
   プロンプト: ブログプラットフォームを作成してください。
   
   バックエンド要件：
   - ASP.NET Core Web API
   - PostgreSQLデータベース
   - JWT認証
   - 記事のCRUD操作
   - コメント機能
   - タグとカテゴリ
   
   フロントエンド要件：
   - React + TypeScript
   - Material-UI
   - 記事一覧・詳細表示
   - Markdownエディタ
   - ユーザー認証UI
   
   インフラ要件：
   - Docker化
   - GitHub Actions CI/CD
   - 環境変数による設定
   
   すべてを実装し、READMEも作成してください。
   ```

2. **実行の観察**
   - プロジェクト構造の自動生成
   - 必要な依存関係のインストール
   - データベーススキーマの作成
   - APIエンドポイントの実装
   - フロントエンドコンポーネントの作成
   - ビルドエラーの自動修正
   - Dockerfileとdocker-compose.ymlの生成

### Agent モードのベストプラクティス

#### 効果的なプロンプト作成

1. **高レベルな要件を記述**
   ```
   良い例: "ユーザー管理システムを作成し、
           認証、権限管理、監査ログを含めてください"
   悪い例: "User.csファイルを作成してください"
   ```

2. **期待する結果を明確に**
   ```
   良い例: "RESTful APIとして実装し、
           Swaggerドキュメントを自動生成してください"
   悪い例: "APIを作ってください"
   ```

#### ツールの管理

1. **自動承認の設定**
   - 信頼できる環境では `chat.tools.autoApprove` を有効化
   - リモート環境での使用を推奨

2. **ツールセットの定義**
   ```json
   // ツールセットの例
   {
     "webdev": {
       "tools": ["codebase", "terminal", "fetch", "problems"],
       "description": "Web開発用ツールセット"
     }
   }
   ```

### トラブルシューティング

#### よくある問題

1. **無限ループの回避**
   - `chat.agent.maxRequests` で上限を設定
   - 必要に応じて手動で中断

2. **パフォーマンスの最適化**
   - 大規模なタスクは段階的に実行
   - 不要なファイルは .gitignore に追加

## まとめ

学習した内容：
- Agent モードの自律的な動作
- ツールの選択と承認
- 複雑なタスクの実行
- エラーの自動検出と修正
- 外部ツールとの統合

## 次のステップ

次は「インラインチャット」について学習し、エディタ内で直接AIサポートを受ける方法を習得しましょう。
