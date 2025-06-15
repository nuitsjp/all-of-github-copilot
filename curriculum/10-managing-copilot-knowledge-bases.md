# Copilot ナレッジベースの管理

## 概要

GitHub Copilot ナレッジベースは、組織内の技術文書やドキュメントを一元管理し、Copilot Chat でコンテキストとして活用できる強力な機能です。この学習教材では、C#プロジェクトのドキュメントを例に、ナレッジベースの作成から活用までを実践的に学びます。

## 学習目標

- ナレッジベースの概念と利点を理解する
- 組織でナレッジベースを作成・管理する方法を習得する
- Copilot Chat でナレッジベースを効果的に活用する方法を学ぶ

## 前提条件

- GitHub Enterprise Cloud アカウント
- Copilot Enterprise プラン
- Organization 所有者権限
- C# の基本的な知識

## シナリオ：C# Calculatorアプリケーションのドキュメント管理

あなたは組織で開発している C# Calculator アプリケーションのドキュメントを管理する責任者です。開発チーム全体がドキュメントを参照しながら効率的に開発できるよう、ナレッジベースを構築します。

### ステップ1：ドキュメントリポジトリの準備

まず、ナレッジベースに含めるドキュメントを整理します。

```csharp
// 例：Calculator プロジェクトのドキュメント構造
// docs/
// ├── architecture/
// │   ├── overview.md
// │   └── design-patterns.md
// ├── api/
// │   ├── calculator-api.md
// │   └── error-handling.md
// └── guides/
//     ├── getting-started.md
//     └── contributing.md
```

### ステップ2：ナレッジベースの作成

1. **Organization 設定へのアクセス**
   - GitHub の右上隅でプロフィール写真をクリック
   - 「Your organizations」を選択
   - 対象組織の「設定」をクリック

2. **ナレッジベースの設定**
   - 左側のサイドバーで「Copilot」→「Knowledge bases」を選択
   - 「新規サポート技術情報」をクリック

3. **基本情報の入力**
   - 名前: `calculator-docs`
   - 説明: `C# Calculator アプリケーションの技術文書とAPI仕様`

4. **リポジトリの選択**
   - 「リポジトリの選択」をクリック
   - `calculator-app` リポジトリを選択
   - 「適用」をクリック

5. **パスの指定（オプション）**
   - 「ファイル パスの編集」をクリック
   - 以下のパスを入力：
     ```
     docs/
     README.md
     CONTRIBUTING.md
     ```
   - 「適用」をクリック

6. **作成の完了**
   - 「ナレッジ ベースを作成する」をクリック

### ステップ3：ナレッジベースの活用

#### Visual Studio Code での使用例

```csharp
/// <summary>
/// 電卓の基本演算を提供するクラス
/// </summary>
public class Calculator
{
    // Copilot Chat で質問：
    // @knowledge-base:calculator-docs エラーハンドリングのベストプラクティスは？
    
    /// <summary>
    /// 2つの数値を加算します
    /// </summary>
    /// <param name="a">第1引数</param>
    /// <param name="b">第2引数</param>
    /// <returns>加算結果</returns>
    public double Add(double a, double b)
    {
        // ナレッジベースのガイドラインに従ってエラーハンドリングを実装
        if (double.IsInfinity(a) || double.IsInfinity(b))
        {
            throw new ArgumentException("無限大の値は処理できません");
        }
        
        return a + b;
    }
}
```

#### GitHub.com での使用例

Pull Request レビュー時に、ナレッジベースを参照：

```
@copilot このPRの実装は、@knowledge-base:calculator-docs のアーキテクチャガイドラインに準拠していますか？
```

### ステップ4：ナレッジベースの更新

ナレッジベースは指定されたリポジトリとパス内のドキュメントを**動的に参照**するため、以下の更新は自動的に反映されます：

#### 自動的に反映される更新
- ✅ 既存のMarkdownファイルの内容変更
- ✅ 指定パス内への新しいMarkdownファイルの追加
- ✅ 指定パス内からのファイルの削除

```csharp
// 例：docs/api/calculator-api.md を更新した場合
// 変更は即座にナレッジベースに反映され、Copilot Chat で最新情報を参照可能
```

#### 手動更新が必要なケース

1. **新しいリポジトリの追加**
   ```
   例：calculator-tests リポジトリを追加して、テストドキュメントも含める
   ```

2. **検索対象パスの変更**
   ```
   例：docs/ に加えて、examples/ フォルダも含めたい
   ```

3. **リポジトリの削除**
   ```
   例：古いドキュメントリポジトリを対象から外す
   ```

**更新手順：**
1. Organization 設定の「Knowledge bases」へアクセス
2. 対象のナレッジベース右側の編集アイコンをクリック
3. 必要な変更を実施
4. 「ナレッジ ベースを更新する」をクリック

### 実践演習

#### 演習1：基本的なナレッジベースの作成

以下の要件でナレッジベースを作成してください：

```csharp
// 要件：
// - 名前: test-framework-docs
// - 説明: xUnit と Shouldly を使用したテストフレームワークのドキュメント
// - 含めるパス: tests/docs/, testing-guidelines.md
```

#### 演習2：Copilot Chat での活用

作成したナレッジベースを使用して、以下の質問をしてください：

```csharp
// テストクラスの実装
[TestClass]
public class CalculatorTests
{
    // Copilot Chat での質問例：
    // @knowledge-base:test-framework-docs Theory属性を使用したパラメータテストの書き方は？
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void 加算テスト_正常系(double a, double b, double expected)
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(a, b);
        
        // Assert
        result.ShouldBe(expected);
    }
}
```

## ベストプラクティス

### 1. ドキュメントの構造化

```markdown
# API ドキュメントの例
## Calculator.Add メソッド

### 概要
2つの数値を加算します。

### シグネチャ
```csharp
public double Add(double a, double b)
```

### パラメータ
- `a`: 第1引数
- `b`: 第2引数

### 戻り値
加算結果を返します。

### 例外
- `ArgumentException`: 無限大の値が渡された場合
```

### 2. 定期的な更新

- **ドキュメント内容の更新**：リポジトリ内で直接更新（自動反映）
- **ナレッジベース構成の見直し**：四半期ごとに対象リポジトリとパスを評価
- **不要になったリポジトリ**：ナレッジベース設定から削除

### 3. アクセス権限の管理

- ナレッジベースは組織全体で共有される
- 機密情報は含めない
- 必要に応じて複数のナレッジベースを作成して分離

## トラブルシューティング

### よくある問題と解決方法

1. **ナレッジベースが Copilot Chat に表示されない**
   - Copilot Enterprise プランが有効か確認
   - ブラウザのキャッシュをクリア
   - IDE を再起動

2. **特定のドキュメントが検索されない**
   - ファイルパスの指定を確認
   - Markdown ファイルであることを確認
   - リポジトリへの読み取り権限を確認

## まとめ

ナレッジベースを効果的に活用することで：

- チーム全体でドキュメントを一元管理
- Copilot Chat で即座に情報を参照
- 開発効率と品質の向上

次のステップとして、Copilot Spaces の活用も検討してみましょう。より柔軟なコンテキスト管理が可能になります。

## 参考リンク

- [GitHub Copilot ドキュメント](https://docs.github.com/copilot)
- [Copilot Spaces について](https://docs.github.com/copilot/using-github-copilot/copilot-spaces)
