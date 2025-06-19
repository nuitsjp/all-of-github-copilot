---
applyTo: "**.cs"
---

# 開発: C#

## コーディング規約
- C# 命名規則 (PascalCase, camelCase) を厳守
- XML ドキュメントコメントを全publicメソッドに追加
- 引数検証をメソッド冒頭で実施

## 開発フロー
### ビルド・テスト
- ビルド: `dotnet build`
- テスト: `dotnet test`
- フォーマット: `dotnet format`

- ソリューションファイル: [CalculatorApp.sln](../src/CalculatorApp/CalculatorApp.sln)

### テスト要件
- 新機能には必ず単体テストを追加
- テストメソッド名は日本語で記述
- Arrange-Act-Assert パターンを使用
- xUnit, Shouldlyを使用
- パラメーター違いのテストはTheory属性を使用

#### 例

テスト対象
```csharp
public class Calculator
{
    public int Add(int a, int b) => a + b;
}
```

テスト対象の関数に対して、内部クラスを使用してテストをグループ化し、メソッド名は日本語で記述します。

Arrange-Act-Assertパターンに従い、xUnitのTheory属性とShouldlyを使用して引数のバリエーションをテストします。

テストコード
```csharp
using Xunit;
using Shouldly;
using CalculatorApp;

public class CalculatorTests
{
    public class Add
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        public void Add_正しい引数を渡した場合_正しい結果を返す(int a, int b, int expected)
        {
            ////////////////////////////////////////////////////////////////////////
            // Arrange
            ////////////////////////////////////////////////////////////////////////
            var calculator = new Calculator();

            ////////////////////////////////////////////////////////////////////////
            // Act
            ////////////////////////////////////////////////////////////////////////
            var result = calculator.Add(a, b);

            ////////////////////////////////////////////////////////////////////////
            // Assert
            ////////////////////////////////////////////////////////////////////////
            result.ShouldBe(expected);
        }
    }
}
```


## プロジェクト構造
- メインアプリケーションコード: [src](../src/CalculatorApp/CalculatorApp.csproj)
- 単体テストコード: [tests](../tests/CalculatorApp.Tests/CalculatorApp.Tests.csproj)

## 品質基準
1. すべてのpublicメソッドにXMLコメント
2. 引数検証の実装
3. 単体テストのカバレッジ90%以上
4. エラーハンドリングの適切な実装