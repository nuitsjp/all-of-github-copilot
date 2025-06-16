# インラインチャットによる効率的なコード編集

## 学習目標
エディタやターミナル内で直接Copilot Chatを使用し、コンテキストを切り替えることなく効率的にコードを編集する方法を学習します。

## 学習内容

### 1. インラインチャットの基本

#### インラインチャットとは
- エディタ内で直接起動するチャット
- 選択したコードや現在のファイルに焦点を当てた編集
- コンテキストの切り替えが不要

### 2. エディタインラインチャット

#### 演習1: 基本的な起動と操作

1. **インラインチャットの起動**
   ```
   キーボードショートカット: Ctrl+I
   ```

2. **簡単なコード変更**
   ```csharp
   // 以下のコードを選択
   public class User
   {
       public string Name { get; set; }
       public string Email { get; set; }
   }
   ```
   
   インラインチャットで実行:
   - "コンストラクタを追加"
   - "バリデーションを追加"
   - "ToStringメソッドを実装"

### 3. コードリファクタリング

#### 演習2: 既存コードの改善

1. **メソッドの抽出**
   ```csharp
   public class OrderProcessor
   {
       public void ProcessOrder(Order order)
       {
           // 在庫確認
           foreach(var item in order.Items)
           {
               var stock = GetStock(item.ProductId);
               if(stock < item.Quantity)
               {
                   throw new InsufficientStockException($"商品{item.ProductId}の在庫が不足しています");
               }
           }
           
           // 価格計算
           decimal total = 0;
           foreach(var item in order.Items)
           {
               var price = GetPrice(item.ProductId);
               total += price * item.Quantity;
           }
           
           // 割引適用
           if(total > 10000)
           {
               total *= 0.9m;
           }
           
           order.TotalAmount = total;
       }
   }
   ```
   
   選択してインラインチャット:
   "各処理を個別のメソッドに抽出してください"

2. **パフォーマンス最適化**
   ```csharp
   // 非効率なコード
   public List<string> GetActiveUserNames()
   {
       var names = new List<string>();
       var users = GetAllUsers();
       foreach(var user in users)
       {
           if(user.IsActive)
           {
               names.Add(user.Name);
           }
       }
       return names;
   }
   ```
   
   インラインチャット:
   "LINQを使って最適化"

### 4. エラー修正

#### 演習3: 問題の迅速な解決

1. **コンパイルエラーの修正**
   ```csharp
   public class Calculator
   {
       public int Divide(int a, int b)
       {
           return a / b; // エラー: ゼロ除算の可能性
       }
       
       public async Task<string> GetDataAsync()
       {
           var result = await HttpClient.GetStringAsync("https://api.example.com");
           // エラー: HttpClientが定義されていない
           return result;
       }
   }
   ```
   
   エラー箇所でインラインチャット:
   "/fix"

### 5. コード生成

#### 演習4: 新しいコードの追加

1. **インターフェースの実装**
   ```csharp
   public interface IEmailService
   {
       Task SendEmailAsync(string to, string subject, string body);
       Task SendBulkEmailAsync(List<string> recipients, string subject, string body);
       bool ValidateEmailAddress(string email);
   }
   
   public class EmailService : IEmailService
   {
       // カーソルをここに置いてCtrl+I
       // "インターフェースを実装"
   }
   ```

2. **ユニットテストの生成**
   ```csharp
   public class StringHelper
   {
       public static string Reverse(string input)
       {
           if (string.IsNullOrEmpty(input))
               return input;
           
           char[] chars = input.ToCharArray();
           Array.Reverse(chars);
           return new string(chars);
       }
   }
   ```
   
   メソッドを選択してインラインチャット:
   "このメソッドの単体テストを生成。xUnitを使用し、エッジケースも含める"

### 6. ターミナルインラインチャット

#### 演習5: コマンドラインでの活用

1. **ターミナルでインラインチャットを起動**
   - 統合ターミナルで Ctrl+I
   
2. **コマンドの生成**
   ```
   プロンプト例:
   - "現在のディレクトリのC#ファイル数を数える"
   - "最近変更されたファイルトップ10を表示"
   - "すべての.csファイルでTODOコメントを検索"
   ```

3. **複雑なコマンドの構築**
   ```
   プロンプト:
   - "gitで過去1週間のコミットを著者別に集計"
   - "dockerコンテナのログをフィルタして特定のエラーを抽出"
   - "プロジェクト内のNuGetパッケージをすべて最新版に更新"
   ```

## 実践プロジェクト

### シナリオ: レガシーコードのモダナイゼーション

インラインチャットを使って、古いコードを段階的に改善します：

1. **Step 1: 古いパターンの識別**
   ```csharp
   // レガシーコード
   public class DataAccess
   {
       public DataSet GetUserData(int userId)
       {
           SqlConnection conn = new SqlConnection("...");
           SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Id = " + userId, conn);
           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           DataSet ds = new DataSet();
           adapter.Fill(ds);
           return ds;
       }
   }
   ```
   
   選択してインラインチャット:
   "このコードの問題点を指摘してください"

2. **Step 2: 段階的な改善**
   - SQLインジェクション対策: "パラメータ化クエリに変更"
   - using文の追加: "リソースの適切な解放を実装"
   - 非同期化: "async/awaitパターンに変更"

3. **Step 3: モダンなパターンへの移行**
   ```
   インラインチャット:
   "Entity Framework Coreを使用した実装に変更"
   ```

### ベストプラクティス

#### 効果的なインラインチャットの使い方

1. **具体的な指示**
   - ❌ "改善して"
   - ✅ "nullチェックとログ出力を追加"

2. **段階的な変更**
   - 大きな変更は小さなステップに分割
   - 各ステップでテストを実行

3. **コンテキストの活用**
   - 必要な部分だけを選択
   - 関連するコードも含める

### トラブルシューティング

#### よくある問題と対処法

1. **インラインチャットが起動しない**
   - VS Codeの最新版を確認
   - Copilot拡張機能の有効化を確認
   - キーボードショートカットの競合を確認

2. **提案が期待と異なる**
   - より具体的なプロンプトを使用
   - 必要なコンテキストを選択
   - スラッシュコマンドを活用

## 高度な使い方

### マルチカーソル編集との組み合わせ

1. **複数箇所の同時編集**
   - Alt+クリックで複数カーソル設置
   - 各位置でインラインチャット起動
   - 一括で類似の変更を適用

2. **正規表現との組み合わせ**
   ```
   プロンプト: "選択した変数名をすべてキャメルケースに変換"
   ```

### カスタムスニペットの生成

```
インラインチャット: "このパターンのVS Codeスニペットを生成"
```

## まとめ

学習した内容：
- エディタとターミナルでのインラインチャット起動方法
- コードのリファクタリングと最適化
- エラー修正とコード生成
- ターミナルコマンドの効率的な作成
- 実践的なシナリオでの活用方法

## 次のステップ

次は「プロンプトエンジニアリング」について学習し、より効果的なプロンプトの作成方法を習得しましょう。
