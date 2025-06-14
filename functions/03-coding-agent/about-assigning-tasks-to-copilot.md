# Copilot へのタスク割り当て 学習マニュアル

## 学習時間
**約30分**

## 学習目標
- Copilot coding agentの基本概念を理解する
- タスク割り当ての方法を把握する
- 適切なタスクの選び方を学ぶ
- コストと制限事項を理解する

## 理論学習 (15分)

### Copilot coding agentとは
GitHub Copilotがバックグラウンドで自律的に動作し、人間の開発者と同じようにタスクを完了する機能

### 主な機能
- **バグ修正**: 既存コードの問題を特定・修正
- **新機能実装**: 増分的な機能追加
- **テストカバレッジ向上**: 単体テストの追加
- **ドキュメント更新**: README、コメントの改善
- **技術的負債対応**: リファクタリング作業

### タスク割り当て方法
1. **GitHub Issueへの割り当て**
   - Issue作成 → Copilotをアサイン
   - 自動的にPull request作成

2. **Copilot Chatからの依頼**
   - `@github Create a PR to...`
   - 直接的なPR作成依頼

### VS Code エージェント モードとの違い
- **Copilot coding agent**: GitHub Actions環境で自律動作、PR作成
- **VS Code エージェント**: ローカル環境での直接編集

## 実践学習 (15分)

### 環境確認
```csharp
// 学習用C#プロジェクト例
// CalculatorApp.cs
using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        // TODO: Subtract, Multiply, Divide メソッドを追加
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
        }
    }
}
```

### 実習1: 適切なタスクの識別

**良いタスク例**:
- 電卓アプリに減算機能を追加
- 単体テストの追加
- README.mdの更新

**避けるべきタスク例**:
- 複雑なアーキテクチャ変更
- セキュリティ関連の重要な変更
- 曖昧な要件のタスク

### 実習2: Issue作成練習

GitHub上で以下のようなIssueを作成：

```markdown
# 電卓アプリに減算機能を追加

## 説明
Calculatorクラスに減算(Subtract)メソッドを追加してください。

## 受け入れ基準
- [ ] `public int Subtract(int a, int b)` メソッドを追加
- [ ] a - b の結果を返す
- [ ] 単体テストを追加
- [ ] Main メソッドでの使用例を追加

## 対象ファイル
- CalculatorApp.cs
```

## 理解度チェック

### 質問1
Copilot coding agentが適している作業は？
- A) 新しいマイクロサービスの設計
- B) 既存機能のバグ修正
- C) セキュリティの脆弱性対応
- D) ビジネス要件の策定

### 質問2
タスク割り当ての方法として正しくないものは？
- A) GitHub IssueにCopilotを割り当て
- B) Copilot Chatで`@github Create a PR`
- C) 直接mainブランチにコミット
- D) 既存のPRにコメント追加

## コストと制限事項

### 使用コスト
- **GitHub Actions**: 分単位課金
- **Premium リクエスト**: 月間許容量内は追加費用なし
- 近日中に課金開始予定

### 主要制限
- Pro+/Enterprise限定
- 同一リポジトリ内のみ変更可能
- 一度に1つのPRのみ
- 書き込み権限が必要

## 次のステップ
- [機能有効化の学習](enabling-copilot-coding-agent.md)
- [ベストプラクティスの習得](best-practices-for-using-copilot-to-work-on-tasks.md)

## 参考情報
- 機能はパブリックプレビュー段階
- 定期的な機能更新があります
- セキュリティ制限により外部アクセスは制限
