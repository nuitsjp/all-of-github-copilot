# Copilot コーディング エージェントのトラブルシューティング

## 概要

このセッションでは、Copilot コーディング エージェントを使用する際に発生する可能性のある問題と、その解決方法を学びます。実際のトラブルシューティングシナリオを通じて、問題解決スキルを身につけます。

## 学習目標

- よくある問題とその原因を理解する
- 問題の診断と解決手順を習得する
- ファイアウォール設定とMCPの活用方法を学ぶ
- エラーを予防するベストプラクティスを実装する

## よくある問題と解決方法

### 問題1: Assigneesリストに"Copilot"が表示されない

#### 診断手順

```csharp
// C# スクリプトで確認
using Octokit;

public async Task CheckCopilotAvailability()
{
    var client = new GitHubClient(new ProductHeaderValue("CopilotChecker"));
    client.Credentials = new Credentials("YOUR_TOKEN");
    
    try
    {
        // リポジトリの提案されたアクターを確認
        var query = @"
        query {
            repository(owner: ""YOUR_ORG"", name: ""YOUR_REPO"") {
                suggestedActors(capabilities: [CAN_BE_ASSIGNED], first: 100) {
                    nodes {
                        login
                        __typename
                    }
                }
            }
        }";
        
        // GraphQL実行（実装は省略）
        // copilot-swe-agentが含まれているか確認
    }
    catch (Exception ex)
    {
        Console.WriteLine($"エラー: {ex.Message}");
    }
}
```

#### 解決策

1. **サブスクリプションの確認**
   - GitHub Copilot Pro+ またはEnterpriseプランが有効か確認
   - 支払い状況を確認

2. **権限の確認**
   ```bash
   # GitHub CLIで権限を確認
   gh api user -q .login
   gh api repos/OWNER/REPO/collaborators/USERNAME/permission
   ```

3. **設定の有効化**
   - 個人設定または組織設定でコーディング エージェントを有効化
   - リポジトリレベルの設定を確認

### 問題2: Copilotがタスクを開始しない

#### シナリオ

issueを割り当てたが、👀の反応もPull Requestも作成されない。

#### デバッグ手順

```csharp
// デバッグ用のissueテンプレート
public class IssueDebugger
{
    public string CreateDebugIssue()
    {
        return @"
## デバッグ用シンプルタスク

### 説明
READMEファイルに現在の日付を追加してください。

### 要件
1. README.mdファイルを開く
2. ファイルの最後に`最終更新: YYYY-MM-DD`を追加
3. 日付は今日の日付を使用

### ファイル
- README.md のみを変更
";
    }
}
```

#### 解決策

1. **ページをリフレッシュ**
   - ブラウザのキャッシュをクリア
   - 別のブラウザで試す

2. **基本的なタスクで検証**
   - 上記のシンプルなタスクで動作確認
   - 徐々に複雑度を上げる

3. **APIで直接割り当て**
   ```csharp
   // GraphQL APIで割り当て
   var mutation = @"
   mutation {
       replaceActorsForAssignable(input: {
           assignableId: ""ISSUE_NODE_ID"",
           assigneeIds: [""BOT_NODE_ID""]
       }) {
           assignable {
               ... on Issue {
                   assignees(first: 10) {
                       nodes { login }
                   }
               }
           }
       }
   }";
   ```

### 問題3: セッションがタイムアウトする

#### 症状

Copilotが1時間経っても作業を完了しない。

#### 予防策

```markdown
## 効果的なタスク分割

### 悪い例：大きすぎるタスク
「アプリケーション全体をマイクロサービスアーキテクチャに変更する」

### 良い例：適切なサイズのタスク
1. 「Calculatorクラスを独立したサービスに分離する」
2. 「計算履歴を別のサービスに移動する」
3. 「サービス間の通信をREST APIで実装する」
```

#### 対処法

```csharp
public class TaskManager
{
    public void HandleTimeout(string issueNumber)
    {
        // 1. セッションを停止
        Console.WriteLine("セッションログで'Stop session'をクリック");
        
        // 2. issueの割り当てを解除
        RunCommand($"gh issue edit {issueNumber} --remove-assignee copilot-swe-agent");
        
        // 3. より明確な指示で再割り当て
        var updatedDescription = @"
        ## 修正版：明確な指示

        ### 具体的な手順
        1. src/Calculator.cs を開く
        2. Addメソッドにログを追加
        3. tests/CalculatorTests.cs にテストを追加
        
        ### 期待される変更
        - 2つのファイルのみを変更
        - 既存のコードスタイルに従う
        ";
        
        // 4. 再割り当て
        RunCommand($"gh issue edit {issueNumber} --add-assignee copilot-swe-agent");
    }
    
    private void RunCommand(string command)
    {
        // コマンド実行の実装
    }
}
```

### 問題4: CIチェックに失敗する

#### 原因と対策

```yaml
# .github/copilot-setup-steps.yml
# CIチェックを成功させるための環境準備

- name: Install dependencies
  run: |
    dotnet restore
    dotnet tool restore

- name: Setup test environment
  run: |
    # テストデータベースの準備
    dotnet ef database update --project src/MyApp
    
- name: Configure test settings
  run: |
    cp appsettings.test.json appsettings.json
```

#### カスタム指示の追加

```markdown
# .github/copilot-instructions.md に追加

## CI/CD要件
1. すべての変更をコミット前にビルドとテストを実行
2. `dotnet format`でコードをフォーマット
3. テストカバレッジ90%以上を維持

## テスト実行手順
```bash
dotnet build
dotnet test --logger "console;verbosity=detailed"
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```
```

### 問題5: ファイアウォール警告

#### 警告の例

```
⚠️ Firewall blocked request to api.external-service.com
Command attempted: curl https://api.external-service.com/data
```

#### 対処法

1. **必要性の評価**
   - 外部APIアクセスが本当に必要か確認
   - 代替手段を検討

2. **ファイアウォール設定**
   ```csharp
   // MCPサーバー設定例
   public class FirewallConfiguration
   {
       public void ConfigureAllowedDomains()
       {
           var allowedDomains = new[]
           {
               "api.github.com",
               "nuget.org",
               "your-internal-api.com"
           };
           
           // 設定の適用（実装は環境依存）
       }
   }
   ```

### 高度なトラブルシューティング

#### MCP（Model Context Protocol）の活用

```json
// mcp-config.json
{
  "mcpServers": {
    "filesystem": {
      "command": "npx",
      "args": ["-y", "@modelcontextprotocol/server-filesystem"],
      "config": {
        "directories": [
          {
            "path": "C:/projects/shared-libs",
            "name": "Shared Libraries"
          }
        ]
      }
    }
  }
}
```

#### デバッグログの有効化

```csharp
public class CopilotDebugger
{
    private readonly ILogger<CopilotDebugger> _logger;
    
    public void EnableDetailedLogging()
    {
        // 環境変数の設定
        Environment.SetEnvironmentVariable("COPILOT_DEBUG", "true");
        Environment.SetEnvironmentVariable("COPILOT_LOG_LEVEL", "verbose");
        
        _logger.LogInformation("詳細ログが有効になりました");
    }
    
    public void AnalyzeSessionLog(string sessionId)
    {
        // セッションログの分析
        _logger.LogInformation($"セッション {sessionId} の分析を開始");
        
        // 共通のエラーパターンを検出
        var errorPatterns = new[]
        {
            "Permission denied",
            "Rate limit exceeded",
            "Timeout",
            "Authentication failed"
        };
        
        // 分析と推奨事項の提供
    }
}
```

### 実践演習

以下の問題を解決してください：

1. **演習1: 権限問題の解決**
   - 新しいリポジトリでCopilotが使えない状況を想定
   - 診断と解決の手順を実行

2. **演習2: 失敗したタスクの再実行**
   - タイムアウトしたタスクを適切に分割
   - 明確な指示で再割り当て

3. **演習3: CI/CD統合の修正**
   - テストが失敗する状況を作成
   - copilot-setup-steps.ymlで解決

## まとめ

### トラブルシューティングのチェックリスト

```markdown
## Copilot コーディング エージェント トラブルシューティングチェックリスト

### 初期確認
- [ ] サブスクリプションが有効
- [ ] リポジトリで機能が有効化されている
- [ ] 書き込み権限がある

### 問題発生時
- [ ] ブラウザをリフレッシュ
- [ ] セッションログを確認
- [ ] エラーメッセージを記録

### 解決策
- [ ] より簡単なタスクで検証
- [ ] 指示をより明確に記述
- [ ] 必要に応じてタスクを分割

### 予防策
- [ ] カスタム指示を最新に保つ
- [ ] 定期的に設定を確認
- [ ] ベストプラクティスに従う
```

## 次のステップ

- 実際のプロジェクトでCopilot コーディング エージェントを活用
- チームメンバーとトラブルシューティング経験を共有
- [Copilotコミュニティ](https://github.com/community)で質問と回答
