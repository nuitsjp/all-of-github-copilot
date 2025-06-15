# MCP サーバーによる VS Code の拡張

## 学習目標
Model Context Protocol (MCP) サーバーを使って、データベース接続、API 呼び出し、特殊なタスクの実行などの外部ツールを VS Code のチャット体験に統合する方法を学習します。

## 前提条件
- Visual Studio Code の最新版
- GitHub Copilot へのアクセス
- VS Code 1.99 以降

## 学習内容

### 1. MCP の基本概念

#### MCP とは何か

Model Context Protocol (MCP) は、AI モデルが外部ツールやサービスと統一されたインターフェースを通じて対話するためのオープンスタンダードです。

#### MCP の仕組み

```mermaid
graph LR
    A[VS Code<br/>MCPクライアント] -->|リクエスト| B[MCPサーバー]
    B -->|ツール提供| A
    B --> C[ファイルシステム]
    B --> D[データベース]
    B --> E[API]
```

### 2. MCP サポートの有効化

#### 演習1: MCP の設定

1. **設定の有効化**
   ```json
   // settings.json
   {
     "chat.mcp.enabled": true,
     "chat.mcp.discovery.enabled": true
   }
   ```

2. **利用可能な機能の確認**
   - ツール
   - プロンプト
   - リソース
   - サンプリング

### 3. MCP サーバーの追加

#### 演習2: ワークスペースへのサーバー追加

1. **`.vscode/mcp.json` の作成**
   ```json
   {
     // 入力プロンプト - APIキーなどの機密情報用
     "inputs": [
       {
         "type": "promptString",
         "id": "github-token",
         "description": "GitHub Personal Access Token",
         "password": true
       }
     ],
     "servers": {
       // GitHubサーバーの例
       "github": {
         "type": "stdio",
         "command": "npx",
         "args": ["-y", "@modelcontextprotocol/server-github"],
         "env": {
           "GITHUB_PERSONAL_ACCESS_TOKEN": "${input:github-token}"
         }
       }
     }
   }
   ```

2. **サーバーの起動確認**
   - コマンドパレット: `MCP: List Servers`
   - サーバーの状態を確認

### 4. データベース接続の実装

#### 演習3: PostgreSQL サーバーの設定

1. **PostgreSQL MCP サーバーの追加**
   ```json
   {
     "servers": {
       "postgres": {
         "type": "stdio",
         "command": "npx",
         "args": ["@modelcontextprotocol/server-postgres"],
         "env": {
           "POSTGRES_CONNECTION_STRING": "postgresql://user:password@localhost/mydb"
         }
       }
     }
   }
   ```

2. **データベースツールの使用**
   ```
   エージェントモードで:
   "#postgres データベースから顧客テーブルの構造を取得して、
   C#のエンティティクラスを生成してください"
   ```

### 5. ファイルシステム操作

#### 演習4: ファイルシステムサーバー

1. **設定の追加**
   ```json
   {
     "servers": {
       "filesystem": {
         "type": "stdio",
         "command": "npx",
         "args": ["-y", "@modelcontextprotocol/server-filesystem"],
         "env": {
           "ALLOWED_DIRECTORIES": "${workspaceFolder}"
         }
       }
     }
   }
   ```

2. **ファイル操作タスク**
   ```
   プロンプト:
   "プロジェクト内のすべての.csファイルを検索して、
   TODOコメントを含むファイルのリストを作成してください"
   ```

### 6. Web 検索とAPI 統合

#### 演習5: 外部API の活用

1. **Perplexity API サーバーの設定**
   ```json
   {
     "inputs": [
       {
         "type": "promptString",
         "id": "perplexity-key",
         "description": "Perplexity API Key",
         "password": true
       }
     ],
     "servers": {
       "perplexity": {
         "type": "stdio",
         "command": "docker",
         "args": ["run", "-i", "--rm", "-e", "PERPLEXITY_API_KEY", "mcp/perplexity-ask"],
         "env": {
           "PERPLEXITY_API_KEY": "${input:perplexity-key}"
         }
       }
     }
   }
   ```

2. **Web 検索の活用**
   ```
   プロンプト:
   "#perplexity 最新の.NET 8のパフォーマンス改善について調べて、
   プロジェクトに適用できる最適化技術をまとめてください"
   ```

### 7. カスタム MCP サーバーの作成

#### 演習6: 独自サーバーの開発

1. **TypeScript でのサーバー作成**
   ```typescript
   // custom-mcp-server.ts
   import { Server } from '@modelcontextprotocol/sdk/server/index.js';
   import { StdioServerTransport } from '@modelcontextprotocol/sdk/server/stdio.js';
   
   const server = new Server({
     name: 'custom-calculator',
     version: '1.0.0'
   });
   
   // ツールの定義
   server.setRequestHandler('tools/list', () => ({
     tools: [{
       name: 'calculate',
       description: '数式を計算します',
       inputSchema: {
         type: 'object',
         properties: {
           expression: { type: 'string' }
         }
       }
     }]
   }));
   
   // ツールの実装
   server.setRequestHandler('tools/call', async (request) => {
     if (request.params.name === 'calculate') {
       const expression = request.params.arguments.expression;
       const result = eval(expression); // 実際の実装では安全な評価方法を使用
       return { content: `計算結果: ${result}` };
     }
   });
   
   // サーバーの起動
   const transport = new StdioServerTransport();
   await server.connect(transport);
   ```

2. **カスタムサーバーの登録**
   ```json
   {
     "servers": {
       "customCalculator": {
         "type": "stdio",
         "command": "node",
         "args": ["${workspaceFolder}/custom-mcp-server.js"]
       }
     }
   }
   ```

## 実践プロジェクト

### シナリオ: データ駆動型アプリケーションの構築

MCP サーバーを組み合わせて、完全なアプリケーションを構築します。

1. **要件分析フェーズ**
   ```
   プロンプト:
   "#postgres 既存のデータベーススキーマを分析して、
   #github リポジトリ内の既存コードとの整合性を確認し、
   改善提案をしてください"
   ```

2. **実装フェーズ**
   ```
   プロンプト:
   "データベースのテーブル構造に基づいて、
   以下を実装してください：
   1. Entity Framework Core のモデルクラス
   2. リポジトリパターンの実装
   3. Web API コントローラー
   4. 単体テスト"
   ```

3. **デプロイメント準備**
   ```
   プロンプト:
   "#filesystem プロジェクト内のすべての設定ファイルを確認し、
   本番環境用の設定を生成してください。
   機密情報は環境変数として分離してください"
   ```

### ツールセットの活用

#### ツールセットの定義

1. **開発用ツールセット**
   ```json
   // .vscode/toolsets.jsonc
   {
     "development": {
       "tools": [
         "filesystem",
         "postgres",
         "github",
         "codebase"
       ],
       "description": "開発環境用ツールセット",
       "icon": "tools"
     },
     "research": {
       "tools": [
         "perplexity",
         "fetch",
         "githubRepo"
       ],
       "description": "調査・リサーチ用ツールセット",
       "icon": "search"
     }
   }
   ```

2. **ツールセットの使用**
   ```
   プロンプト:
   "#development プロジェクトの全体的な健全性チェックを実行し、
   問題があれば修正提案をしてください"
   ```

## トラブルシューティング

### よくある問題と解決方法

1. **サーバーが起動しない**
   - コマンドパレット: `MCP: List Servers` → `Show Output`
   - ログを確認してエラーを特定

2. **Docker を使用時の問題**
   - `-d` オプションを使用しない
   - インタラクティブモード (`-i`) を確保

3. **認証エラー**
   - 入力変数が正しく設定されているか確認
   - 環境変数の読み込みを確認

### デバッグモード

```json
{
  "servers": {
    "myServer": {
      "command": "node",
      "args": ["server.js"],
      "dev": {
        "watch": "src/**/*.js",
        "debug": { "type": "node" }
      }
    }
  }
}
```

## ベストプラクティス

### セキュリティ

1. **信頼できるソースのみ使用**
   - 公式リポジトリを優先
   - コードレビューを実施

2. **機密情報の管理**
   - ハードコーディングを避ける
   - 入力変数や環境ファイルを使用

3. **権限の制限**
   - 必要最小限のアクセス権
   - ディレクトリ制限の設定

### パフォーマンス

1. **サーバーの管理**
   - 不要なサーバーは停止
   - リソース使用量を監視

2. **ツールの選択**
   - タスクに適したツールのみ有効化
   - ツールセットで効率化

## まとめ

学習した内容：
- MCP の基本概念と仕組み
- サーバーの追加と設定方法
- 各種ツールの活用方法
- カスタムサーバーの作成
- セキュリティとパフォーマンスの考慮事項

## 次のステップ

次は「GitHub Copilot Chat チートシート」で、すべての機能のクイックリファレンスを確認しましょう。

## 関連リソース

- [Model Context Protocol ドキュメント](https://modelcontextprotocol.io/)
- [MCP サーバーリポジトリ](https://github.com/modelcontextprotocol/servers)
- [VS Code での Agent モード](/docs/copilot/chat/chat-agent-mode)
