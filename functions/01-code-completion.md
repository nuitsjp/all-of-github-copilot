# Code Completion 学習マニュアル

## 学習目標
- GitHub Copilotのコード補完機能を理解する
- VS Code + C#環境で実際に動作確認を行う
- 基本的な使用方法から応用テクニックまでを習得する
- デモ用のサンプルコードを作成する

## 学習時間
約30分

## 前提条件
- Visual Studio Code がインストール済み
- GitHub Copilot 拡張機能が有効
- C# Dev Kit または C# 拡張機能がインストール済み
- GitHub Copilot にサインイン済み

## 1. 基本的なコード補完（10分）

### 1.1 関数の自動補完
新しいC#ファイル（`Calculator.cs`）を作成し、以下を試してください：

```csharp
public class Calculator
{
    // 関数ヘッダーを入力してCopilotの提案を確認
    public int CalculateDaysBetweenDates(DateTime begin, DateTime end)
    {
        // Tab キーで提案を受け入れる
    }
}
```

**確認ポイント:**
- 入力中に灰色のテキストで提案が表示されるか
- Tab キーで提案が受け入れられるか
- 提案内容が妥当か

### 1.2 コメントからのコード生成
```csharp
// 2つの数値の最大公約数を求める関数を作成
public int CalculateGcd(int a, int b)
{
    // Copilotの提案を確認
}
```

## 2. 代替候補の表示と選択（10分）

### 2.1 複数候補の表示
```csharp
// 配列内の偶数のみを抽出する関数
public List<int> FilterEvenNumbers(int[] numbers)
{
    // 複数の実装方法が提案されることを確認
}
```

**操作方法:**
- Windows/Linux: `Alt + ]` (次の候補), `Alt + [` (前の候補)
- macOS: `Option + ]` (次の候補), `Option + [` (前の候補)
- `Ctrl + Enter`: 新しいタブで複数候補を表示

### 2.2 候補の比較と選択
- 各候補の違いを確認
- 最適な実装を選択
- 不適切な候補は `Esc` で拒否

## 3. 部分的な提案の受け入れ（5分）

### 3.1 単語単位の受け入れ
```csharp
public string FormatPersonalInformation(string firstName, string lastName, int age)
{
    // 長い提案の一部だけを受け入れる練習
    return $"Name: {firstName} {lastName}, Age: {age}";
}
```

**操作方法:**
- Windows/Linux: `Ctrl + →` (次の単語を受け入れ)
- macOS: `Command + →` (次の単語を受け入れ)

## 4. 応用演習（5分）

### 4.1 複雑なロジックの実装
以下のクラスを完成させてください：

```csharp
public class TaskManager
{
    private List<Task> tasks;
    
    public TaskManager()
    {
        // Copilotに初期化処理を提案させる
    }
    
    // タスクを優先度順にソートするメソッド
    public void SortTasksByPriority()
    {
        // Copilotの提案を活用
    }
    
    // 期限切れのタスクを取得するメソッド
    public List<Task> GetOverdueTasks()
    {
        // 複数の実装候補を比較
    }
}

public class Task
{
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    public int Priority { get; set; }
    public bool IsCompleted { get; set; }
}
```

## デモ用サンプルコード

### デモ1: 基本的なコード補完
```csharp
// このコメントを入力してコード生成をデモ
// 文字列を逆順にする関数を作成
public string ReverseString(string input)
{
    // Tabキーでの受け入れをデモ
}
```

### デモ2: 複数候補の選択
```csharp
// 配列の平均値を計算する関数
public double CalculateAverage(int[] numbers)
{
    // Alt + ] / Alt + [ での候補切り替えをデモ
}
```

### デモ3: 部分受け入れ
```csharp
// 複雑な条件分岐を含む関数
public string DetermineGrade(int score)
{
    // Ctrl + → での部分受け入れをデモ
    if (score >= 90)
        return "A";
    // 続きをCopilotに提案させる
}
```

## トラブルシューティング

### よくある問題と解決方法

1. **提案が表示されない**
   - GitHub Copilot拡張機能が有効か確認
   - インターネット接続を確認
   - VS Codeを再起動

2. **提案の品質が低い**
   - より具体的なコメントを記述
   - 関数名やパラメータ名を明確にする
   - コンテキストを提供する

3. **キーボードショートカットが効かない**
   - VS Codeのキーバインド設定を確認
   - 他の拡張機能との競合を確認

## 学習チェックリスト

- [ ] 基本的なコード補完が動作することを確認
- [ ] 複数候補の表示と選択ができる
- [ ] 部分的な提案の受け入れができる
- [ ] コメントからのコード生成ができる
- [ ] デモ用のサンプルコードを作成
- [ ] トラブルシューティング方法を理解

## 次のステップ

Code completion の基本をマスターしたら、次は以下の機能に進みましょう：
- Copilot Chat: 対話的なコード生成と質問
- Copilot Edits: より大規模なコード編集
- GitHub Copilot Extensions: 専門的な機能拡張

## 参考リンク

- [GitHub Copilot公式ドキュメント](https://docs.github.com/ja/copilot/)
- [Visual Studio Code での GitHub Copilot の設定](https://code.visualstudio.com/docs/copilot/setup)
