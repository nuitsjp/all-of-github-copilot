# GitHub Desktop での GitHub Copilot の責任ある使用

## 学習目標

このカリキュラムを完了すると、以下のことができるようになります：

- GitHub Desktop での Copilot のコミットメッセージ生成機能を理解し、適切に使用する
- AI が生成したコミットメッセージの品質を評価し、必要に応じて編集する
- この機能の制限事項を理解し、責任を持って活用する

## 前提条件

- GitHub Desktop がインストールされていること
- GitHub Copilot のサブスクリプションがあること
- 基本的な Git の知識があること
- C# の基本的な知識があること

## 概要

GitHub Desktop での Copilot は、コード変更に基づいて適切なコミットメッセージを自動生成する AI 機能です。この機能により、開発者は時間を節約しながら、明確で一貫性のあるコミット履歴を維持できます。

## シナリオ：C# 電卓アプリケーションの機能追加

実際のプロジェクトで GitHub Desktop の Copilot を使用する方法を学びます。

### ステップ 1：プロジェクトの準備

1. 新しい C# コンソールアプリケーションを作成します：

```bash
dotnet new console -n CalculatorApp
cd CalculatorApp
git init
```

2. 基本的な電卓クラスを作成します：

```csharp
// Program.cs
namespace CalculatorApp
{
    /// <summary>
    /// 基本的な計算機能を提供するクラス
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// 2つの数値を加算します
        /// </summary>
        /// <param name="a">第1引数</param>
        /// <param name="b">第2引数</param>
        /// <returns>加算結果</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine($"1 + 2 = {calculator.Add(1, 2)}");
        }
    }
}
```

3. 初期コミットを作成します（手動で）：

```bash
git add .
git commit -m "初期コミット：基本的な電卓アプリケーションの作成"
```

### ステップ 2：新機能の追加とCopilotの使用

1. 減算、乗算、除算の機能を追加します：

```csharp
/// <summary>
/// 2つの数値を減算します
/// </summary>
/// <param name="a">被減数</param>
/// <param name="b">減数</param>
/// <returns>減算結果</returns>
public double Subtract(double a, double b)
{
    return a - b;
}

/// <summary>
/// 2つの数値を乗算します
/// </summary>
/// <param name="a">第1引数</param>
/// <param name="b">第2引数</param>
/// <returns>乗算結果</returns>
public double Multiply(double a, double b)
{
    return a * b;
}

/// <summary>
/// 2つの数値を除算します
/// </summary>
/// <param name="a">被除数</param>
/// <param name="b">除数</param>
/// <returns>除算結果</returns>
/// <exception cref="ArgumentException">除数が0の場合</exception>
public double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new ArgumentException("除数は0にできません。", nameof(b));
    }
    return a / b;
}
```

2. GitHub Desktop を開き、変更を確認します

3. **Copilot でコミットメッセージを生成**：
   - 変更タブで、追加された行を選択します
   - コミットメッセージエリアの Copilot ボタンをクリックします
   - AI が生成したメッセージを確認します

### ステップ 3：生成されたメッセージの評価と編集

1. **生成されたメッセージの確認ポイント**：
   - 変更内容が正確に反映されているか
   - 技術的な用語が適切に使用されているか
   - 日本語として自然な文章になっているか（英語で生成される場合は翻訳）

2. **メッセージの改善例**：
   - 生成例：「Add arithmetic operations to Calculator class」
   - 改善例：「feat: Calculator クラスに減算・乗算・除算機能を追加」

3. **再生成の活用**：
   - より適切なメッセージが欲しい場合は、再生成ボタンをクリック
   - 複数の候補を比較して最適なものを選択

### ステップ 4：テストコードの追加とコミット

1. テストプロジェクトを追加：

```bash
dotnet new xunit -n CalculatorApp.Tests
dotnet add CalculatorApp.Tests reference CalculatorApp
```

2. テストコードを作成：

```csharp
// CalculatorTests.cs
using Xunit;
using Shouldly;
using System;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void 加算が正しく動作すること(double a, double b, double expected)
        {
            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(0, 5, -5)]
        [InlineData(-3, -2, -1)]
        public void 減算が正しく動作すること(double a, double b, double expected)
        {
            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void ゼロ除算時に例外が発生すること()
        {
            // Act & Assert
            Should.Throw<ArgumentException>(() => _calculator.Divide(10, 0))
                .ParamName.ShouldBe("b");
        }
    }
}
```

3. GitHub Desktop で変更を確認し、Copilot を使用してコミットメッセージを生成

### ステップ 5：ベストプラクティスの実践

1. **特定の行やファイルの選択**：
   - より正確なメッセージ生成のため、関連する変更のみを選択
   - 大きな変更は複数のコミットに分割することを検討

2. **生成されたメッセージの検証**：
   - [ ] 変更内容が正確に記述されているか
   - [ ] チームの命名規則に従っているか
   - [ ] 将来の自分や他の開発者が理解できるか

3. **フィードバックの提供**：
   - 不適切なメッセージが生成された場合は、GitHub Desktop のリポジトリで issue を作成

## 演習課題

1. **課題1**：Calculator クラスに平方根を計算する `SquareRoot` メソッドを追加し、Copilot でコミットメッセージを生成してください。負の数の処理も考慮してください。

2. **課題2**：計算履歴を保存する機能を追加し、複数の変更を含むコミットで Copilot がどのようなメッセージを生成するか確認してください。

3. **課題3**：リファクタリング（メソッド名の変更、コードの整理など）を行い、Copilot が技術的な変更をどのように説明するか観察してください。

## まとめ

GitHub Desktop での Copilot は、コミットメッセージ作成を効率化する強力なツールです。しかし、以下の点を常に意識することが重要です：

- **AI はツールであり、置き換えではない**：生成されたメッセージは必ず人間がレビューする
- **コンテキストの重要性**：適切な行やファイルを選択することで、より正確なメッセージが生成される
- **継続的な改善**：フィードバックを提供することで、ツール全体の品質向上に貢献できる

## 次のステップ

- より複雑なプロジェクトで Copilot を使用してみる
- チーム内でコミットメッセージのガイドラインを作成し、Copilot の出力を調整する
- 他の GitHub Copilot 機能（コード補完、チャット機能など）と組み合わせて使用する
