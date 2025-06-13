# Copilot Edits 学習プラン

## 概要
- **機能名**: Copilot Edits (Edit mode & Agent mode)
- **学習時間**: 25分
- **対象プラン**: Pro/Pro+/Business/Enterprise
- **対応環境**: VS Code, Visual Studio, JetBrains

## 学習目標
- 複数ファイルの一括編集機能を理解する
- Edit modeとAgent modeの違いを体験する
- 実際のリファクタリングシナリオで活用する

## 実践内容

### 1. 準備：サンプルプロジェクト作成 (5分)
```csharp
// Program.cs
using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 3));
        }
    }
}

// Calculator.cs
namespace SampleApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
```

### 2. Edit Mode での編集 (10分)

**シナリオ1: ログ機能の追加**
```
プロンプト: 
「全てのクラスにILoggerを追加して、各メソッドの開始と終了でログ出力するように変更してください。
dependency injectionも適切に設定してください。」
```

**シナリオ2: 非同期対応**
```
プロンプト:
「CalculatorクラスのすべてのメソッドをTask<T>に変更し、
呼び出し側もasync/awaitに対応してください。」
```

**Edit Modeの確認ポイント:**
- 提案される変更の適切性
- 複数ファイルの整合性
- 変更範囲の明確性

### 3. Agent Mode での自律編集 (10分)

**シナリオ3: 新機能追加**
```
プロンプト:
「電卓に四則演算と履歴機能を追加してください。
- Calculator クラスに減算、乗算、除算メソッド追加
- 計算履歴を保存・表示するHistoryManagerクラス作成
- Program.cs でインタラクティブな計算機として動作
- 適切な例外処理とバリデーション追加」
```

**Agent Modeの確認ポイント:**
- 自律的な設計判断
- 新規ファイルの作成
- エラーハンドリングの考慮
- コードの品質

## 確認ポイント
- [ ] 複数ファイルが適切に変更される
- [ ] ファイル間の依存関係が保たれる
- [ ] 変更の差分が明確に表示される
- [ ] ロールバックが可能
- [ ] Edit modeとAgent modeの使い分けができる

## Edit vs Agent Mode比較

| 項目 | Edit Mode | Agent Mode |
|------|-----------|------------|
| 制御レベル | 高い | 低い（自律的） |
| 適用シーン | 明確な変更指示 | 包括的なタスク |
| 新規ファイル | 制限的 | 自由に作成 |
| 設計判断 | 人間主導 | AI主導 |

## デモ用メモ
- 従来の検索・置換との違い
- 大規模リファクタリングでの威力
- コードレビューの重要性

## 次のステップ
- より大きなプロジェクトでの検証
- レガシーコードの現代化タスク
