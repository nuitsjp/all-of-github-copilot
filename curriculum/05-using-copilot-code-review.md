# GitHub Copilotコードレビュー機能の活用

## 概要

GitHub Copilotのコードレビュー機能は、コードの品質向上とベストプラクティスの遵守を支援する強力なツールです。AIによる自動レビューにより、潜在的な問題の早期発見、コードの改善提案、チーム全体の生産性向上を実現します。

## 学習目標

この教材を完了すると、以下のことができるようになります：

- Visual Studio Codeで選択したコードのレビューを実施する
- 変更全体に対する詳細なレビューを取得する
- Copilotの提案を適用してコードを改善する
- カスタムコーディングガイドラインを設定してレビューをカスタマイズする

## 前提条件

- Visual Studio Codeがインストールされていること
- GitHub Copilot Chat拡張機能（バージョン0.22以降）がインストールされていること
- GitHub Copilotへのアクセス権
- 基本的なGitの知識

## コードレビューの種類

GitHub Copilotは2種類のコードレビューを提供します：

### 1. 選択内容のレビュー（標準機能）
- すべてのCopilotサブスクライバーが利用可能
- コードの特定部分を選択してレビュー
- 即座にフィードバックと提案を取得

### 2. 変更のレビュー（Premium機能）
- Copilot Pro、Business、Enterpriseプランで利用可能
- すべての変更に対する詳細なレビュー
- カスタムコーディングガイドラインのサポート
- 月間クォータが適用される

## 実習：C# Calculatorプロジェクトでのコードレビュー

### シナリオ：電卓アプリケーションの品質向上

#### ステップ1：プロジェクトのセットアップ

まず、サンプルのC#電卓プロジェクトを作成します：

```csharp
// filepath: src/Calculator.cs
namespace CalculatorApp
{
    public class Calculator
    {
        // 意図的に改善の余地があるコードを含む
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            // エラーハンドリングなし
            return a / b;
        }

        public double Calculate(string operation, double a, double b)
        {
            // 複雑な条件分岐
            if (operation == "add")
                return a + b;
            else if (operation == "subtract")
                return a - b;
            else if (operation == "multiply")
                return a * b;
            else if (operation == "divide")
                return a / b;
            else
                return 0;
        }
    }
}
```

#### ステップ2：選択内容のレビュー実施

1. Visual Studio Codeで`Calculator.cs`を開きます

2. `Divide`メソッドを選択します

3. コマンドパレットを開きます：
   - Mac: `Shift + Command + P`
   - Windows/Linux: `Ctrl + Shift + P`

4. **GitHub Copilot: Review and Comment**を選択します

5. Copilotがエラーハンドリングの欠如を指摘することを確認します

期待される提案例：
```csharp
/// <summary>
/// 2つの数値の除算を行います。
/// </summary>
/// <param name="a">被除数</param>
/// <param name="b">除数</param>
/// <returns>除算結果</returns>
/// <exception cref="DivideByZeroException">除数が0の場合</exception>
public double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("除数は0にできません。");
    }
    return a / b;
}
```

#### ステップ3：Calculate メソッドの改善

`Calculate`メソッドを選択してレビューを実施します。Copilotは以下の改善を提案する可能性があります：

```csharp
/// <summary>
/// 指定された演算を実行します。
/// </summary>
public double Calculate(string operation, double a, double b)
{
    if (string.IsNullOrWhiteSpace(operation))
    {
        throw new ArgumentException("演算を指定してください。", nameof(operation));
    }

    return operation.ToLower() switch
    {
        "add" => Add(a, b),
        "subtract" => Subtract(a, b),
        "multiply" => Multiply(a, b),
        "divide" => Divide(a, b),
        _ => throw new ArgumentException($"サポートされていない演算: {operation}", nameof(operation))
    };
}

private double Subtract(double a, double b) => a - b;
private double Multiply(double a, double b) => a * b;
```

### 実践演習：単体テストのレビュー

以下の単体テストコードを作成し、Copilotでレビューしてみましょう：

```csharp
// filepath: tests/CalculatorTests.cs
using Xunit;
using CalculatorApp;

public class CalculatorTests
{
    private Calculator calculator = new Calculator();

    [Fact]
    public void TestAdd()
    {
        var result = calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void TestDivide()
    {
        var result = calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }
}
```

Copilotは以下の改善点を提案する可能性があります：

1. **日本語のテストメソッド名**
2. **Arrange-Act-Assertパターンの明確化**
3. **エッジケースのテスト追加**
4. **Theoryを使用したパラメータ化テスト**

改善後のコード例：

```csharp
using Xunit;
using Shouldly;
using CalculatorApp;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void 加算が正しく動作すること(double a, double b, double expected)
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Add(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(-10, -2, 5)]
    [InlineData(0, 1, 0)]
    public void 除算が正しく動作すること(double a, double b, double expected)
    {
        // Arrange - コンストラクタで実施済み

        // Act
        var result = _calculator.Divide(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void ゼロ除算で例外が発生すること()
    {
        // Arrange - コンストラクタで実施済み

        // Act & Assert
        Should.Throw<DivideByZeroException>(() => _calculator.Divide(10, 0))
            .Message.ShouldBe("除数は0にできません。");
    }
}
```

## 変更のレビュー（Premium機能）

### 全体的な変更をレビューする手順

1. **ソース管理タブに切り替え**
   - Visual Studio Codeの左側のアクティビティバーから「ソース管理」アイコンをクリック

2. **ステージングされていない変更のレビュー**
   - 「変更」セクションにマウスを合わせる
   - 「Copilot コード レビュー - Changes」ボタンをクリック

3. **ステージングされた変更のレビュー**
   - 「ステージされた変更」セクションにマウスを合わせる
   - 「Copilot コード レビュー - Staged Changes」ボタンをクリック

4. **レビュー結果の確認**
   - インラインコメントを確認
   - 「問題」タブで全体的な問題を確認

## Copilotの提案の処理

### 提案の適用

1. **推奨される変更を確認**
   - Copilotのコメントに含まれる提案を読む

2. **変更の適用**
   - 「Apply and Go To Next」ボタンをクリックして提案を受け入れる
   - 適用された変更は自動的にはコミットされない

3. **提案の破棄**
   - 「Discard and Go to Next」ボタンをクリックして次の提案へ

### フィードバックの提供

各コメントに対してフィードバックを提供することで、Copilotの精度向上に貢献できます：

1. コメントにマウスを合わせる
2. 👍（サムアップ）または 👎（サムダウン）ボタンをクリック

## カスタムコーディングガイドライン（Enterprise限定）

組織固有のコーディング規約をCopilotに理解させることができます：

```markdown
# コーディングガイドライン例

## C#命名規則
- publicメソッドはPascalCase
- privateフィールドは_camelCase
- 定数はUPPER_CASE

## コメント規約
- すべてのpublicメソッドにXMLドキュメントコメント
- 複雑なロジックには日本語でコメント

## エラーハンドリング
- 引数検証を必ず実施
- 適切な例外タイプを使用
- エラーメッセージは日本語で記述
```

## ベストプラクティス

### 1. 定期的なレビューの実施
- コミット前に必ずレビューを実行
- 大きな変更は段階的にレビュー

### 2. 提案の選択的な適用
- すべての提案を盲目的に受け入れない
- チームの規約と照らし合わせて判断

### 3. フィードバックループの活用
- 有益な提案には積極的にフィードバック
- 不適切な提案も報告してCopilotの改善に貢献

## まとめ

GitHub Copilotのコードレビュー機能は、開発プロセスに統合することで、コード品質の向上、バグの早期発見、開発速度の向上を実現します。選択レビューから始めて、徐々に変更レビューやカスタムガイドラインを活用することで、チーム全体の開発効率を最大化できます。

## 次のステップ

1. 実際のプロジェクトでCopilotコードレビューを試す
2. チーム固有のコーディングガイドラインを作成
3. レビュー結果をチームで共有し、共通の改善点を特定
4. CI/CDパイプラインへの統合を検討
