# Copilot コーディング エージェントの実践的活用

## 概要

このセッションでは、Copilot コーディング エージェントを使用した高度な開発ワークフローを学びます。Pull Requestのレビュー、フィードバックによる反復開発、ベストプラクティスの実装を体験します。

## 学習目標

- Copilotが作成したPull Requestを効果的にレビューする
- コメントを使用した反復的な改善プロセスを実践する
- ベストプラクティスを適用してCopilotの生産性を最大化する
- GitHub Actionsワークフローとの統合を管理する

## シナリオ：電卓アプリケーションの品質向上

Copilotが作成したコードをレビューし、品質を向上させます。

### パート1: Pull Requestのレビュー

#### ステップ 1: Copilotの作業完了を確認

1. Pull Requestページで以下を確認：
   - 「Copilot finished work」イベント
   - レビューリクエストの通知

#### ステップ 2: 変更内容の詳細レビュー

レビュー時のチェックポイント：

```markdown
## コードレビューチェックリスト

### 機能要件
- [ ] すべての要求された機能が実装されている
- [ ] エッジケースが適切に処理されている
- [ ] エラーハンドリングが実装されている

### コード品質
- [ ] 命名規則が一貫している
- [ ] XMLドキュメントコメントが完備している
- [ ] 重複コードがない

### テスト
- [ ] すべての機能に対するテストが存在する
- [ ] エッジケースのテストがある
- [ ] テストが実際に機能を検証している
```

#### ステップ 3: レビューコメントの作成

**バッチレビューの開始：**
1. 「Start a review」をクリック
2. 複数のコメントを追加
3. すべてのコメントを一度に送信

**効果的なコメントの例：**

```markdown
このメソッドの引数検証が不足しています。以下を追加してください：

1. `value` が負の数の場合の検証
2. `ArgumentOutOfRangeException` をスローする
3. エラーメッセージは日本語で記述

例：
```csharp
if (value < 0)
{
    throw new ArgumentOutOfRangeException(nameof(value), 
        "値は0以上である必要があります。");
}
```
```

### パート2: フィードバックによる反復開発

#### ステップ 1: Copilotへの修正依頼

**基本的なコメント：**
```markdown
以下の修正をお願いします：
- Divideメソッドでゼロ除算の例外メッセージを改善
- より詳細な情報を含める（現在の値など）
```

**@mentionを使用した強制的な応答：**
```markdown
@copilot 
このクラスにロギング機能を追加してください。
Microsoft.Extensions.Loggingを使用し、
すべての計算操作をログに記録するようにしてください。
```

#### ステップ 2: Copilotの応答を確認

1. コメントに👀の反応が追加される
2. 「Copilot started work」イベントの確認
3. 新しいコミットの確認

#### ステップ 3: 複数回の反復

実際のプロジェクトでの反復例：

```csharp
// 初回のCopilotの実装
public class Calculator
{
    public double Add(double a, double b) => a + b;
}

// 1回目のフィードバック後
public class Calculator
{
    /// <summary>
    /// 2つの数値を加算します。
    /// </summary>
    public double Add(double a, double b) => a + b;
}

// 2回目のフィードバック後
public class Calculator
{
    private readonly ILogger<Calculator> _logger;
    
    public Calculator(ILogger<Calculator> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }
    
    /// <summary>
    /// 2つの数値を加算します。
    /// </summary>
    /// <param name="a">最初の数値</param>
    /// <param name="b">2番目の数値</param>
    /// <returns>加算結果</returns>
    public double Add(double a, double b)
    {
        _logger.LogInformation("加算を実行: {A} + {B}", a, b);
        var result = a + b;
        _logger.LogInformation("結果: {Result}", result);
        return result;
    }
}
```

### パート3: GitHub Actionsとの統合

#### ステップ 1: ワークフローの承認

1. Pull Requestの「Files changed」タブを確認
2. 特に`.github/workflows/`の変更に注意
3. 安全性を確認後、「Approve and run workflows」をクリック

#### ステップ 2: CI/CD環境の準備

`.github/copilot-setup-steps.yml`を作成：

```yaml
- name: Setup .NET
  uses: actions/setup-dotnet@v3
  with:
    dotnet-version: '8.0.x'

- name: Restore dependencies
  run: dotnet restore

- name: Install test tools
  run: |
    dotnet tool install --global dotnet-reportgenerator-globaltool
    dotnet tool install --global coverlet.console
```

### パート4: ベストプラクティスの実装

#### 効果的なissueの書き方

```markdown
## 良い例：明確で具体的

タイトル: 計算履歴機能を実装する

### 背景
ユーザーが過去の計算を確認できるようにする

### 要件
1. CalculationHistoryクラスを作成
2. 最新10件の計算を保持
3. 以下のメソッドを実装：
   - AddEntry(string operation, double result)
   - GetHistory() - List<HistoryEntry>を返す
   - ClearHistory()

### 技術仕様
- HistoryEntryクラス: Operation, Result, Timestamp
- メモリ内でのみ保持（永続化は不要）
- スレッドセーフである必要がある

### テスト要件
- 履歴の追加と取得
- 10件を超えた場合の古いエントリの削除
- 並行アクセスのテスト
```

#### カスタム指示の活用

`.github/copilot-instructions.md`の拡張：

```markdown
## パフォーマンス基準
- すべての計算メソッドは10ms以内に完了すること
- メモリ使用量は最小限に抑える

## セキュリティ
- 入力値の検証を必ず実施
- SQLインジェクションなどの脆弱性を防ぐ

## アクセシビリティ
- すべてのエラーメッセージは明確で理解しやすい
- 国際化を考慮した実装
```

### 実践演習

以下の高度なタスクを実行：

1. **複雑なリファクタリング**
   ```markdown
   既存のCalculatorクラスをStrategy patternを使用して
   リファクタリングし、操作の追加が容易になるようにしてください。
   ```

2. **パフォーマンス最適化**
   ```markdown
   @copilot 
   計算履歴機能のパフォーマンスを改善してください。
   ベンチマークテストも追加してください。
   ```

## フィードバックの提供

Copilotの作業に対するフィードバック：

1. Pull RequestまたはコメントでThumbsUp/ThumbsDownをクリック
2. 否定的な場合は理由を選択
3. 具体的なコメントを追加

## 理解度チェック

1. バッチレビューを使用すべき理由を説明してください
2. GitHub Actionsワークフローを承認する前に確認すべき点は？
3. Copilotの生産性を最大化するための3つのベストプラクティスを挙げてください

## 次のステップ

- [トラブルシューティング](./03-04-troubleshooting-copilot-coding-agent.md)へ進む
- 実際のプロジェクトでCopilot コーディング エージェントを活用する
