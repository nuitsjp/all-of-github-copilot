# GitHub Copilot コードレビュー 学習マニュアル

## 学習目標
このマニュアルを完了すると、以下ができるようになります：
- GitHub Copilot のコードレビュー機能を効果的に活用する
- 選択範囲レビューと変更レビューを適切に使い分ける
- コードレビューの結果を理解し、適切にフィードバックを処理する
- カスタムコーディングガイドラインを設定・活用する

## 前提知識
- Visual Studio Code の基本操作
- GitHub Copilot の基本的な使用経験
- Git の基本的なワークフロー

## 1. GitHub Copilot コードレビューの基本概念

### 1.1 コードレビュー機能の種類

| 機能 | 対象範囲 | プラン要件 | 用途 |
|------|----------|------------|------|
| 選択範囲レビュー | 選択したコード部分 | Standard | 部分的なコード改善 |
| 変更レビュー | すべての変更 | Premium | 包括的なレビュー |

### 1.2 利用可能環境
- **Visual Studio Code**: 両方の機能が利用可能
- **GitHub Web**: 変更レビューのみ利用可能

## 2. 実践演習：選択範囲レビュー

### 演習 2.1: 基本的な選択範囲レビュー

**ステップ 1: サンプルコードの準備**

次のC#コードをVisual Studio Codeで作成してください：

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public int Divide(int a, int b)
    {
        return a / b;
    }
}
```

**ステップ 2: コードの選択とレビュー実行**

1. `Divide` メソッド全体を選択
2. `Ctrl+Shift+P` (Windows/Linux) または `Shift+Command+P` (Mac) でコマンドパレットを開く
3. "GitHub Copilot: Review and Comment" を検索・選択
4. レビュー結果を確認

**期待される結果:**
- ゼロ除算のエラーハンドリングに関する指摘
- 引数検証の不足に関する指摘

### 演習 2.2: レビュー結果の適用

**ステップ 1: 提案の確認**
- Problems タブでCopilotの指摘を確認
- インラインコメントを読む

**ステップ 2: 提案の適用**
- "Apply and Go To Next" ボタンをクリック
- 変更内容を確認

**ステップ 3: 改善されたコードの確認**

```csharp
/// <summary>
/// 二つの整数を除算します
/// </summary>
/// <param name="a">被除数</param>
/// <param name="b">除数</param>
/// <returns>除算結果</returns>
/// <exception cref="ArgumentException">除数がゼロの場合</exception>
public int Divide(int a, int b)
{
    if (b == 0)
        throw new ArgumentException("除数はゼロにできません", nameof(b));
    
    return a / b;
}
```

## 3. 実践演習：変更レビュー

### 演習 3.1: Git変更のレビュー

**ステップ 1: 変更の作成**

既存のCalculatorクラスに以下のメソッドを追加：

```csharp
public double CalculateAverage(List<int> numbers)
{
    var sum = 0;
    foreach(var num in numbers)
    {
        sum += num;
    }
    return sum / numbers.Count;
}
```

**ステップ 2: 変更レビューの実行**

1. Source Control タブに移動
2. "Changes" セクションにマウスを合わせる
3. "Copilot コードレビュー - Changes" ボタンをクリック
4. レビュー完了まで待機（通常30秒以内）

**期待される結果:**
- null チェックの不足に関する指摘
- 空のリストに対する処理の指摘
- 型安全性の改善提案

### 演習 3.2: 段階的な改善

**改善前のコード分析:**
```csharp
// 問題点：
// 1. nullチェックなし
// 2. 空リスト時のゼロ除算
// 3. 整数オーバーフローの可能性
```

**改善後のコード:**
```csharp
/// <summary>
/// 数値リストの平均値を計算します
/// </summary>
/// <param name="numbers">数値のリスト</param>
/// <returns>平均値</returns>
/// <exception cref="ArgumentNullException">リストがnullの場合</exception>
/// <exception cref="ArgumentException">リストが空の場合</exception>
public double CalculateAverage(List<int> numbers)
{
    if (numbers == null)
        throw new ArgumentNullException(nameof(numbers));
    
    if (numbers.Count == 0)
        throw new ArgumentException("リストは空にできません", nameof(numbers));
    
    long sum = 0; // オーバーフロー対策
    foreach(var num in numbers)
    {
        sum += num;
    }
    
    return (double)sum / numbers.Count;
}
```

## 4. フィードバックとベストプラクティス

### 4.1 フィードバックの提供方法

**良いフィードバックの例:**
- 👍 適切なセキュリティ指摘
- 👍 パフォーマンス改善の提案
- 👍 コード可読性の向上

**フィードバックが必要な場合:**
- 👎 不適切な提案
- 👎 コンテキストを理解していない指摘

### 4.2 効果的な活用方法

**選択範囲レビューの活用場面:**
- 新しく書いたメソッドの確認
- 複雑なロジック部分の検証
- リファクタリング後の確認

**変更レビューの活用場面:**
- プルリクエスト前の最終確認
- 大きな機能追加後のレビュー
- セキュリティに関わる変更

## 5. 高度な機能：カスタムコーディングガイドライン

### 5.1 ガイドライン設定例

**C# プロジェクト用ガイドライン:**

```
1. すべてのpublicメソッドにXMLドキュメントコメントを追加する
2. 引数検証をメソッド冒頭で実施する
3. 適切な例外処理を実装する
4. SOLID原則に従った設計を心がける
5. async/awaitパターンを適切に使用する
```

### 5.2 ガイドライン適用の確認

カスタムガイドラインが設定されている場合、レビューコメントに以下のような表示が追加されます：

```
💡 コーディングガイドラインに基づく提案:
XMLドキュメントコメントが不足しています
```

## 6. トラブルシューティング

### 6.1 よくある問題と解決方法

**問題: レビューが開始されない**
- 解決策: GitHub Copilot Chat拡張機能（v0.22以降）がインストールされているか確認

**問題: Premium機能が使用できない**
- 解決策: プランの確認と月間クォータの残量確認

**問題: 不適切な提案が多い**
- 解決策: フィードバックを積極的に提供し、コンテキストを明確にする

### 6.2 パフォーマンス最適化

**レビュー時間短縮のコツ:**
- 適切なサイズでコードを選択（大きすぎない）
- 明確なコミットメッセージを書く
- 関連するファイルをまとめて変更する

## 7. 総合演習

### 演習 7.1: 実践的なコードレビュー

以下のクラスに対して完全なレビューを実施してください：

```csharp
public class UserService
{
    private List<User> users = new List<User>();
    
    public void AddUser(string name, string email)
    {
        var user = new User { Name = name, Email = email };
        users.Add(user);
    }
    
    public User GetUser(string email)
    {
        foreach(var user in users)
        {
            if(user.Email == email)
                return user;
        }
        return null;
    }
    
    public void DeleteUser(string email)
    {
        for(int i = 0; i < users.Count; i++)
        {
            if(users[i].Email == email)
            {
                users.RemoveAt(i);
                break;
            }
        }
    }
}
```

**チェックポイント:**
1. 選択範囲レビューで各メソッドを個別に確認
2. 変更レビューで全体の設計を確認
3. 提案された改善を適用
4. 適切なフィードバックを提供

**期待される改善点:**
- 引数検証の追加
- XMLドキュメントコメントの追加
- LINQ使用による可読性向上
- 並行処理対応（ConcurrentCollection使用）
- 非同期メソッドへの変更

## 8. 学習の振り返り

### 8.1 習得すべきスキル
- [ ] 選択範囲レビューの実行
- [ ] 変更レビューの実行
- [ ] レビュー結果の適切な処理
- [ ] フィードバックの提供
- [ ] カスタムガイドラインの活用

### 8.2 次のステップ
1. **実際のプロジェクトでの活用**: 日常の開発ワークフローに組み込む
2. **チームでの共有**: ベストプラクティスをチームメンバーと共有
3. **継続的改善**: フィードバックを通じてレビュー品質の向上に貢献

## 9. 参考資料

- [GitHub Copilot公式ドキュメント](https://docs.github.com/ja/copilot)
- [Visual Studio Code拡張機能](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot-chat)
- [プレミアムリクエストについて](https://docs.github.com/ja/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests)

---

**学習完了の確認:**
このマニュアルのすべての演習を完了し、実際のプロジェクトでGitHub Copilotコードレビュー機能を活用できるようになりましたか？
