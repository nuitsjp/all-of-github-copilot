# リポジトリー

URL: https://github.com/nuitsjp/all-of-github-copilot

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

### テスト要件
- 新機能には必ず単体テストを追加
- テスト対象のメソッド一つに対して、1つのテストクラスを作成
- テストメソッド名は日本語で記述
- Arrange-Act-Assert パターンを使用
- xUnit, Shouldlyを使用
- パラメーター違いのテストはTheory属性を使用

## プロジェクト構造
- メインアプリケーションコード: [src](../src/CalculatorApp/CalculatorApp.csproj)
- 単体テストコード: [tests](../tests/CalculatorApp.Tests/CalculatorApp.Tests.csproj)

## 品質基準
1. すべてのpublicメソッドにXMLコメント
2. 引数検証の実装
3. 単体テストのカバレッジ90%以上
4. エラーハンドリングの適切な実装