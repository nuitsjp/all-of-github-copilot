# Copilot Workspaceを使ったプルリクエスト作業の学習

## 概要

GitHub Copilot Workspaceは、プルリクエストの作業を効率化するための統合環境です。この機能により、GitHubのWebサイト上でコードの編集、レビューコメントの処理、変更の検証を一箇所で行うことができます。

## 学習目標

この学習を完了すると、以下ができるようになります：

- Copilot Workspaceでプルリクエストのファイルを編集する
- レビューコメントや提案を効率的に処理する
- 統合ターミナルを使用してコードをビルド・テストする
- Copilotとチャットしてプルリクエストについて質問する

## 前提条件

- GitHub Copilot Pro以上のサブスクリプション
- Copilot Workspaceへのアクセス権限
- 既存のプルリクエスト

## シナリオ: C# Calculatorアプリのプルリクエスト改善

新しい計算機能を追加するプルリクエストがレビューされ、改善提案を受けたとします。Copilot Workspaceを使ってこれらの提案を効率的に処理していきます。

### 手順1: Copilot Workspaceを開く

1. プルリクエストのメインページで **「Open in Workspace」** ボタンをクリック
2. Copilot Workspaceが開き、プルリクエストの概要が表示される
3. 左側にプルリクエストで変更されるファイル一覧が表示される

### 手順2: ファイルの編集

#### Calculator.cs の改善

```csharp
/// <summary>
/// 基本的な計算機能を提供するクラス
/// </summary>
public class Calculator
{
    /// <summary>
    /// 2つの数値を加算します
    /// </summary>
    /// <param name="a">第1オペランド</param>
    /// <param name="b">第2オペランド</param>
    /// <returns>加算結果</returns>
    /// <exception cref="OverflowException">計算結果がオーバーフローした場合</exception>
    public decimal Add(decimal a, decimal b)
    {
        if (a == decimal.MaxValue || b == decimal.MaxValue)
            throw new OverflowException("計算結果がオーバーフローします");
            
        return a + b;
    }

    /// <summary>
    /// 2つの数値を除算します
    /// </summary>
    /// <param name="dividend">被除数</param>
    /// <param name="divisor">除数</param>
    /// <returns>除算結果</returns>
    /// <exception cref="ArgumentException">除数が0の場合</exception>
    public decimal Divide(decimal dividend, decimal divisor)
    {
        if (divisor == 0)
            throw new ArgumentException("0で除算することはできません", nameof(divisor));
            
        return dividend / divisor;
    }
}
```

#### テストファイルの追加

```csharp
/// <summary>
/// Calculator クラスのテスト
/// </summary>
public class CalculatorTests
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Add_正常な値_正しい結果を返す(decimal a, decimal b, decimal expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        result.ShouldBe(expected);
    }

    [Fact]
    public void Divide_ゼロ除算_例外をスローする()
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Should.Throw<ArgumentException>(() => calculator.Divide(10, 0));
    }
}
```

### 手順3: レビューコメントの処理

1. **「Suggestions」** パネルでレビューコメントを確認
2. 各提案について：
   - **「Apply」** - 提案を適用する場合
   - **「Dismiss」** - 提案を却下する場合
3. 矢印ボタンで次のコメントに移動
4. すべてのコメントを処理後、**「Review and commit」** をクリック

### 手順4: 変更の検証

#### ターミナルの使用

1. エディターパネル右上の ターミナルアイコンをクリック
2. クイックコマンドを設定：

```json
{
  "commands": {
    "Build": "dotnet build",
    "Run": "dotnet run",
    "Test": "dotnet test"
  }
}
```

3. **「Build」** ボタンでビルド実行
4. **「Test」** でテスト実行
5. 問題があれば修正し、再テスト

### 手順5: Copilotとのチャット

1. ワークスペース上部の Copilotアイコンをクリック
2. 質問例：
   - "このプルリクエストのコード品質を向上させる方法は？"
   - "テストカバレッジは十分ですか？"
   - "パフォーマンスの問題はありませんか？"

### 手順6: 変更のコミット

1. **「Review and commit」** をクリック
2. 自動生成されたコミットメッセージを確認・編集
3. 変更するファイルを選択
4. **「Commit changes」** でコミット実行

## 実践演習

### 演習1: XMLドキュメントコメントの追加

既存のメソッドにXMLドキュメントコメントが不足している場合、Copilot Workspaceを使って追加してください。

### 演習2: エラーハンドリングの改善

レビューで指摘されたエラーハンドリングの問題を、Copilot Workspaceで修正してください。

### 演習3: テストケースの追加

テストカバレッジが不十分な部分について、新しいテストケースを追加してください。

## まとめ

Copilot Workspaceを使用することで：

- GitHubとIDEを行き来せずに作業完了
- レビューコメントを効率的に処理
- 統合環境でコードのビルド・テストが可能
- Copilotとの対話でコード品質向上

これらの機能により、プルリクエストの作業効率が大幅に向上します。

## 次のステップ

- より複雑なプルリクエストで練習
- チーム開発でのワークフロー最適化
- Copilot Autofix機能との連携活用
