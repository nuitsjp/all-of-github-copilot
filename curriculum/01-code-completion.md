# GitHub Copilot コード補完機能 学習教材

## 概要

GitHub Copilotのコード補完機能は、開発者の生産性を大幅に向上させる強力なAI支援ツールです。この教材では、C#を使用した実践的なシナリオを通じて、コード補完機能の効果的な使い方を学習します。

## 学習目標

- GitHub Copilotのコード補完機能の基本を理解する
- コメントを使った自然言語でのコード生成方法を習得する
- 複数の候補から最適な提案を選択する方法を学ぶ
- 部分的な提案の受け入れ方法を理解する
- 次の編集候補機能の活用方法を習得する

## 前提条件

- Visual Studio Codeがインストールされていること
- GitHub Copilot拡張機能がインストールされていること
- C#の基本的な知識があること

## シナリオ: 図書管理システムの構築

図書館の蔵書を管理する簡単なシステムを構築しながら、GitHub Copilotのコード補完機能を学習します。

### ステップ1: 基本的なコード補完

新しいC#ファイル `Book.cs` を作成し、以下のコードを入力してみましょう：

```csharp
public class Book
{
    // プロパティを定義
    public string Title { get; set; }
```

`Title`プロパティの後で改行し、「public」と入力すると、GitHub Copilotが次のプロパティを提案します。Tabキーを押して提案を受け入れましょう。

期待される提案例：
```csharp
public string Author { get; set; }
public string ISBN { get; set; }
public DateTime PublishedDate { get; set; }
```

### ステップ2: コメントを使ったコード生成

次に、コメントを使って複雑な機能を実装してみましょう。`LibraryManager.cs` ファイルを作成し、以下のコメントを入力します：

```csharp
public class LibraryManager
{
    private List<Book> books = new List<Book>();

    // 書籍を追加するメソッド
    // 同じISBNの書籍が既に存在する場合は例外をスロー
```

コメントの後でEnterキーを押すと、GitHub Copilotが完全なメソッドを提案します：

```csharp
/// <summary>
/// 書籍を図書館に追加します
/// </summary>
/// <param name="book">追加する書籍</param>
/// <exception cref="ArgumentException">同じISBNの書籍が既に存在する場合</exception>
public void AddBook(Book book)
{
    if (book == null)
    {
        throw new ArgumentNullException(nameof(book));
    }

    if (books.Any(b => b.ISBN == book.ISBN))
    {
        throw new ArgumentException($"ISBN {book.ISBN} の書籍は既に存在します。");
    }

    books.Add(book);
}
```

### ステップ3: 代替候補の確認

検索機能を実装する際に、複数の提案を確認してみましょう：

```csharp
// タイトルで書籍を検索するメソッド
public List<Book> SearchByTitle(string title)
{
```

メソッドヘッダーを入力後、以下の操作を試してください：

1. **Alt + ]** （Windows/Linux）または **Option + ]** （macOS）で次の候補を表示
2. **Alt + [** で前の候補に戻る
3. **Ctrl + Enter** で新しいタブに複数の候補を表示

異なる実装方法（部分一致、大文字小文字を区別しないなど）が提案されるはずです。

### ステップ4: 部分的な提案の受け入れ

複雑なメソッドを実装する際、提案の一部だけを受け入れる方法を学びます：

```csharp
// 著者名で書籍を検索し、出版日でソートして返すメソッド
public List<Book> SearchByAuthorSorted(string author)
{
    return books
```

提案が表示されたら：
1. **Ctrl + →** （Windows/Linux）または **Command + →** （macOS）で次の単語だけを受け入れ
2. 必要に応じて自分でコードを修正
3. 残りの提案を確認して受け入れ

### ステップ5: 次の編集候補の活用

既存のコードを編集する際の次の編集候補機能を体験します。

まず、以下のような基本的なメソッドを作成します：

```csharp
public void PrintBookInfo(Book book)
{
    Console.WriteLine($"Title: {book.Title}");
}
```

次に、`Title`の行を以下のように編集します：

```csharp
Console.WriteLine($"タイトル: {book.Title}");
```

編集後、Tabキーを押すと、次の編集候補として新しい行が提案されます：

```csharp
Console.WriteLine($"著者: {book.Author}");
Console.WriteLine($"ISBN: {book.ISBN}");
Console.WriteLine($"出版日: {book.PublishedDate:yyyy/MM/dd}");
```

### 演習課題

以下の機能を GitHub Copilotを使って実装してみましょう：

1. **貸出管理機能**
   - コメント: `// 書籍を貸し出すメソッド。貸出中の場合はfalseを返す`
   
2. **統計情報取得**
   - コメント: `// 著者別の書籍数を集計して辞書で返すメソッド`

3. **データ検証**
   - コメント: `// ISBNの形式が正しいかチェックするメソッド（13桁の数字）`

## まとめ

この教材では、GitHub Copilotのコード補完機能について以下を学習しました：

- 基本的なコード補完によるプロパティやメソッドの自動生成
- コメントを使った自然言語でのコード生成
- 複数の候補から最適な提案を選択する方法
- 部分的な提案の受け入れによる柔軟なコード編集
- 次の編集候補を使った効率的なコード修正

これらの機能を活用することで、開発効率を大幅に向上させることができます。実際のプロジェクトでも積極的に活用してみてください。

## 参考リンク

- [GitHub Copilot 公式ドキュメント](https://docs.github.com/ja/copilot)
- [Visual Studio Code での GitHub Copilot の設定](https://code.visualstudio.com/docs/copilot/setup)
