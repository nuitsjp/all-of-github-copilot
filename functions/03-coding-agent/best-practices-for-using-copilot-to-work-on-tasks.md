# Copilot Coding Agent ベストプラクティス 学習マニュアル

## 学習時間
**約45分**

## 学習目標
- 効果的なIssue作成方法を習得する
- 適切なタスクの選び方を理解する
- カスタム指示の活用方法を学ぶ
- Pull requestでの反復改善プロセスを理解する

## 理論学習: Issue作成のベストプラクティス (15分)

### 良いIssueの特徴

#### 1. 明確なタスク説明
```markdown
# ❌ 悪い例
タイトル: バグ修正

説明:
何かがうまく動かない

# ✅ 良い例  
タイトル: Calculator.Divide メソッドでゼロ除算時の例外処理を追加

説明:
現在のCalculator.Divideメソッドは除数が0の場合にDivideByZeroExceptionを
適切に処理していません。適切な例外ハンドリングを追加してください。
```

#### 2. 完全な受け入れ基準
```markdown
## 受け入れ基準
- [ ] Divideメソッドで除数が0の場合にArgumentExceptionを投げる
- [ ] 適切なエラーメッセージを含める
- [ ] 単体テストを追加する
- [ ] XMLドキュメントコメントを更新する
```

#### 3. 対象ファイルの明示
```markdown
## 変更対象ファイル
- Calculator.cs (主な変更)
- CalculatorTests.cs (テスト追加)
- README.md (使用例更新)
```

## 実践学習: 適切なタスクの選択 (15分)

### 推奨タスクカテゴリ

#### ✅ Copilotに適したタスク

**1. バグ修正**
```csharp
// 例: null参照エラーの修正
public string GetUserDisplayName(User user)
{
    return user.FirstName + " " + user.LastName; // NullReferenceException の可能性
}
```

**2. 機能追加**
```csharp
// 例: 新しいメソッド追加
public class Calculator
{
    public int Add(int a, int b) => a + b;
    // TODO: Subtract, Multiply, Divide メソッドを追加
}
```

**3. テストカバレッジ向上**
```csharp
// 例: 単体テスト不足
public class MathUtilities
{
    public bool IsPrime(int number) 
    {
        // テストが不足している複雑なロジック
    }
}
```

#### ❌ Copilotに適さないタスク

**1. 複雑なアーキテクチャ変更**
- マイクロサービス分割
- 大規模リファクタリング
- 設計パターンの根本的変更

**2. セキュリティ・クリティカルなタスク**
- 認証システムの変更
- 暗号化実装
- 本番環境の緊急対応

**3. 曖昧なタスク**
- 「パフォーマンスを改善して」
- 「ユーザビリティを向上させて」
- 「コードをきれいにして」

## 実践学習: カスタム指示の活用 (10分)

### .github/copilot-instructions.md 作成

```markdown
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

## プロジェクト構造
- `src/`: メインアプリケーションコード
- `tests/`: 単体テストコード
- `docs/`: ドキュメント

## 品質基準
1. すべてのpublicメソッドにXMLコメント
2. 引数検証の実装
3. 単体テストのカバレッジ90%以上
4. エラーハンドリングの適切な実装
```

### 効果的なカスタム指示のポイント
- **具体的**: 曖昧な指示は避ける
- **実行可能**: Copilotが実際に実行できるコマンド
- **構造化**: セクション分けで読みやすく
- **例示**: 具体例を含める

## 実践学習: Pull Requestでの反復改善 (5分)

### レビューコメントのベストプラクティス

#### ✅ 効果的なコメント例
```markdown
このメソッドで引数検証を追加してください：
- numberパラメータが負の値の場合はArgumentOutOfRangeExceptionを投げる
- エラーメッセージ: "Number must be non-negative"
```

#### ❌ 非効果的なコメント例
```markdown
このコードをもっと良くして
```

### バッチレビューの活用
1. "Start a review" をクリック
2. 複数のコメントを追加
3. 一度に "Submit review" で送信
4. Copilotが全コメントを同時に処理

## 実践演習

### 演習1: Issue作成
以下の要件でIssueを作成：

```markdown
タイトル: Add input validation to Calculator methods

説明:
Calculator クラスの全メソッドに適切な入力検証を追加してください。

受け入れ基準:
- [ ] すべてのメソッドで引数のnullチェック実装
- [ ] 数値オーバーフローのチェック追加  
- [ ] 適切な例外タイプと説明メッセージ
- [ ] 各検証ケースの単体テスト追加
- [ ] XMLドキュメントでの例外記述

対象ファイル:
- src/Calculator.cs
- tests/CalculatorTests.cs
```

### 演習2: カスタム指示作成
自分のプロジェクトに適した `.github/copilot-instructions.md` を作成

### 演習3: レビューコメント練習
以下のコードに対する改善コメントを作成：

```csharp
public int Divide(int a, int b)
{
    return a / b;
}
```

期待されるコメント例：
- ゼロ除算チェックの追加
- XMLドキュメントコメントの追加
- 例外処理の実装

## 理解度チェック

### 質問1: 良いIssueの特徴として適切でないものは？
A) 明確なタスク説明
B) 曖昧で柔軟な要件
C) 具体的な受け入れ基準
D) 対象ファイルの明示

### 質問2: カスタム指示ファイルの推奨場所は？
A) `.copilot/instructions.md`
B) `.github/copilot-instructions.md`
C) `docs/copilot-setup.md`
D) `README.md`

## 次のステップ
- [Issue処理の実践](using-copilot-to-work-on-an-issue.md)
- [Pull request作成の実践](asking-copilot-to-create-a-pull-request.md)

## 参考資料
- GitHub Copilot 公式ドキュメント
- コミュニティのベストプラクティス事例
- プロジェクト固有のガイドライン
