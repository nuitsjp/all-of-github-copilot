# Copilot Chat 学習マニュアル

## 学習目標
- GitHub Copilot Chatの対話的なコード生成機能を理解する
- チャット参加者、スラッシュコマンド、チャット変数を活用する
- Copilot Editsの編集モードとエージェントモードを習得する
- 画像を使ったプロンプトの送信方法を学習する
- 実際のプロジェクトでの活用方法を体験する

## 学習時間
約30分

## 前提条件
- Visual Studio Code がインストール済み
- GitHub Copilot 拡張機能が有効
- GitHub Copilot にサインイン済み
- C# Dev Kit または C# 拡張機能がインストール済み

## 1. 基本的なチャット機能（10分）

### 1.1 チャットビューの起動
1. VS Codeのタイトルバーの💬アイコンをクリック
2. または `Ctrl+Shift+Alt+L` (Windows/Linux) / `⇧+⌥+⌘+L` (Mac) でクイックチャット

### 1.2 基本的なプロンプトの送信
以下のプロンプトを試してください：

```
C#でファイルの内容を読み込んで、行数をカウントする関数を作成してください
```

**確認ポイント:**
- 応答にコードブロックが含まれているか
- コードブロックの右上に「Apply」「Copy」などのボタンがあるか
- 「Used n references」が表示されるか

### 1.3 フォローアップ質問
```
そのコードにエラーハンドリングを追加してください
```

**操作方法:**
- 会話の文脈が保持されているか確認
- コードの修正提案が適切か評価

## 2. チャット参加者とスラッシュコマンド（8分）

### 2.1 チャット参加者の使用
プロンプトボックスに `@` を入力して利用可能な参加者を確認：

```
@workspace このプロジェクトの構造を教えてください
```

```
@vscode VS Codeの設定でテーマを変更する方法を教えてください
```

### 2.2 スラッシュコマンドの活用
プロンプトボックスに `/` を入力して利用可能なコマンドを確認：

```csharp
// まず、テスト対象のコードを準備
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

**スラッシュコマンドの例:**
```
/tests Calculator クラスの単体テストを生成してください
```

```
/explain このコードの動作を説明してください
```

```
/fix このコードの潜在的な問題を修正してください
```

### 2.3 チャット変数の使用
プロンプトボックスに `#` を入力して利用可能な変数を確認：

```
#file Calculator.cs の問題点を教えてください
```

```
#selection 選択したコードをリファクタリングしてください
```

## 3. 異なるアクセス方法（5分）

### 3.1 インラインチャット
1. エディター内で `Ctrl+i` (Windows/Linux) / `Command+i` (Mac)
2. 直接コード内でCopilotに質問

**演習:**
```csharp
public void ProcessData(List<string> data)
{
    // ここでCtrl+iを押して「この関数にログ出力機能を追加して」と入力
}
```

### 3.2 スマートアクション
1. コードを選択して右クリック
2. **「Copilot」** → 適切なアクションを選択

**演習:**
```csharp
// この部分を選択してスマートアクションを試す
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
```

## 4. GitHub スキルと高度な機能（4分）

### 4.1 GitHub スキルの使用
```
@github Web検索を使って、最新のC# 13の新機能について教えてください
```

```
@github #web .NET 9の最新情報を調べてください
```

### 4.2 AIモデルの変更
1. チャットビューの右下のモデルピッカーを確認
2. 異なるモデル（GPT-4o、Claude Sonnet等）を試す

**比較演習:**
```
複雑なアルゴリズムの実装について、異なるモデルの回答を比較してください
```

## 5. Copilot Edits（10分）

### 5.1 編集モードの使用

**準備:** 以下のファイルを作成

```csharp
// UserService.cs
public class UserService
{
    public string GetUserName(int userId)
    {
        return "User" + userId;
    }
}
```

```csharp
// UserController.cs
public class UserController
{
    public string Index()
    {
        return "Hello";
    }
}
```

**編集モードの演習:**
1. Copilot Chatのモードドロップダウンから「Edit」を選択
2. 作業セットにファイルを追加
3. プロンプトを送信：

```
UserServiceを使用するようにUserControllerを修正し、
依存性注入も追加してください
```

4. 提案された変更を確認し、ファイルごとに「適用」または「破棄」

### 5.2 エージェントモードの使用

**エージェントモードの演習:**
1. Copilot Chatのモードドロップダウンから「Agent」を選択
2. 以下のプロンプトを送信：

```
Web APIプロジェクトを作成し、ユーザー管理機能を実装してください。
CRUD操作とバリデーション機能を含めてください。
```

3. Copilotが自律的にファイルを作成・編集する様子を観察
4. 提案されたターミナルコマンドがあれば実行

**確認ポイント:**
- 複数ファイルが自動的に作成・編集されるか
- 作業セットが動的に更新されるか
- Premium リクエストの消費を理解する

## 6. 画像を使用したプロンプト（3分）

### 6.1 画像の添付方法
1. サポートされるモデル（GPT-4o、Claude Sonnet等）を選択
2. 以下の方法で画像を添付：
   - 画像をコピー＆ペースト
   - ファイルをドラッグ＆ドロップ
   - エクスプローラーから右クリック → Copilot → Add File to Chat

### 6.2 画像プロンプトの例

**デモ用プロンプト:**
```
このUIモックアップ画像を見て、対応するHTMLとCSSコードを生成してください
```

```
このエラーメッセージのスクリーンショットから、問題の原因と解決方法を教えてください
```

## デモ用サンプルコード

### デモ1: 基本的なチャット
```csharp
// プロンプト例：「この配列処理コードを最適化してください」
public void ProcessArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.WriteLine("Even: " + numbers[i]);
        }
    }
}
```

### デモ2: チャット参加者とスラッシュコマンド
```csharp
// 以下のコードで /tests コマンドをデモ
public class StringHelper
{
    public bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}
```

### デモ3: Copilot Edits（編集モード）
```
複数ファイルにまたがるリファクタリングの例：
1. Model クラスの作成
2. Service クラスの依存関係修正
3. Controller の更新
```

### デモ4: エージェントモード
```
「TodoList アプリケーションを作成してください。
Entity Framework、Web API、バリデーション機能を含めてください」
のような包括的なタスクでエージェントの自律性をデモ
```

## トラブルシューティング

### よくある問題と解決方法

1. **チャットが応答しない**
   - インターネット接続を確認
   - GitHub Copilotにサインインしているか確認
   - VS Codeとエクステンションを再起動

2. **編集モードで変更が適用されない**
   - 作業セットにファイルが追加されているか確認
   - ファイルが編集可能な状態か確認
   - プロンプトが具体的で明確か確認

3. **エージェントモードが期待通りに動作しない**
   - タスクが明確で実行可能か確認
   - Premium リクエストの残量を確認
   - 複雑すぎるタスクは分割して実行

4. **画像が認識されない**
   - サポートされているファイル形式か確認（JPEG、PNG、GIF、WEBP）
   - 適切なAIモデルが選択されているか確認
   - 画像が明確で読みやすいか確認

## 学習チェックリスト

- [ ] 基本的なチャット機能が使用できる
- [ ] チャット参加者（@workspace、@vscode等）が使える
- [ ] スラッシュコマンド（/tests、/explain等）が使える
- [ ] チャット変数（#file、#selection等）が使える
- [ ] インラインチャットとスマートアクションが使える
- [ ] GitHub スキル（@github）が使える
- [ ] Copilot Editsの編集モードが使える
- [ ] Copilot Editsのエージェントモードが使える
- [ ] 画像を使ったプロンプトが送信できる
- [ ] AIモデルの変更ができる

## 重要なポイント

### Premium リクエストについて
- エージェントモードは1プロンプトで1 Premium リクエストを消費
- フォローアップアクションは追加料金なし
- 高度なAIモデル使用時は追加消費

### セキュリティ
- 機密情報を含むプロンプトは避ける
- Organizationのポリシーに従う
- 画像に含まれる情報にも注意

## 次のステップ

Copilot Chat をマスターしたら、次は以下の機能に進みましょう：
- Copilot in the CLI: コマンドライン操作の支援
- GitHub Copilot Extensions: 専門的な機能拡張
- GitHub Models: 異なるAIモデルとの比較

## 参考リンク

- [Copilot Chat公式ドキュメント](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/)
- [Copilot Chatのプロンプトエンジニアリング](https://docs.github.com/ja/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
- [VS Code Copilot Chat ドキュメント](https://code.visualstudio.com/docs/copilot/copilot-chat)
