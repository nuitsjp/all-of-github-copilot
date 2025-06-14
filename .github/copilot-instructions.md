# プロジェクト: C# Calculator アプリケーション

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
- テストメソッド名: `MethodName_Scenario_ExpectedResult`
- Arrange-Act-Assert パターンを使用
- xUnit, Shouldlyを使用

## プロジェクト構造
- `src/`: メインアプリケーションコード
- `tests/`: 単体テストコード
- `docs/`: ドキュメント

## 品質基準
1. すべてのpublicメソッドにXMLコメント
2. 引数検証の実装
3. 単体テストのカバレッジ90%以上
4. エラーハンドリングの適切な実装