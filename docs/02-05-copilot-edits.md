# Copilot Edit モードによる複数ファイル編集

## 学習目標
Edit モードを使って、複数のファイルにまたがる変更を効率的に実行する方法を学習します。

## 学習内容

### 1. Edit モードの基本概念

#### なぜ Edit モードを使うのか

- **制御された編集**: 変更するファイルを明示的に指定
- **段階的なレビュー**: 各ファイルの変更を個別に確認
- **予測可能な動作**: Agent モードより制御しやすい

### 2. Edit モードの開始

#### 演習1: 基本的な操作

1. **モードの切り替え**
   - Chat view を開く（Ctrl+Alt+I）
   - モードドロップダウンから「Edit」を選択
   - または直接開く: [VS Code Stable](vscode://GitHub.Copilot-Chat/chat?mode=edit)

2. **作業セットの準備**
   ```
   プロジェクト構造:
   /BookStore
     /Models
       - Book.cs
       - Author.cs
     /Services
       - BookService.cs
   ```

### 3. 単純な複数ファイル編集

#### 演習2: 関連するファイルの同時更新

1. **初期コードの作成**
   ```csharp
   // Book.cs
   public class Book
   {
       public int Id { get; set; }
       public string Title { get; set; }
       public string ISBN { get; set; }
       public decimal Price { get; set; }
   }
   
   
   // Author.cs
   public class Author
   {
       public int Id { get; set; }
       public string Name { get; set; }
   }
   
   // BookService.cs
   public class BookService
   {
       private readonly List<Book> _books = new();
       
       public void AddBook(Book book)
       {
           _books.Add(book);
       }
   }
   ```

2. **Edit モードでの変更**
   ```
   プロンプト: Book.csとAuthor.csを更新して、
   本と著者の関係を追加してください。
   一つの本は複数の著者を持つことができ、
   一人の著者は複数の本を書くことができます。
   BookService.csも更新して、著者情報を含めた本の追加ができるようにしてください。
   ```

3. **変更の確認とレビュー**
   - 各ファイルの変更内容を確認
   - 必要に応じて個別に承認または却下
   - エディタオーバーレイで変更箇所をナビゲート

### 4. リファクタリング作業

#### 演習3: 既存コードの改善

1. **リファクタリング前のコード**
   ```csharp
   // OrderManager.cs
   public class OrderManager
   {
       public decimal CalculateTotal(List<OrderItem> items)
       {
           decimal total = 0;
           foreach(var item in items)
           {
               total += item.Price * item.Quantity;
               if(item.Quantity > 10)
               {
                   total *= 0.9m; // 10% discount
               }
           }
           return total;
       }
   }
   ```

2. **戦略パターンへのリファクタリング**
   ```
   プロンプト: OrderManager.csをリファクタリングして、
   割引計算を戦略パターンで実装してください。
   以下のファイルを作成/更新してください：
   - IDiscountStrategy.cs (新規)
   - QuantityDiscountStrategy.cs (新規)
   - NoDiscountStrategy.cs (新規)
   - OrderManager.cs (更新)
   ```

### 5. 大規模な機能追加

#### 演習4: 新機能の実装

1. **既存システムへの機能追加**
   ```
   プロンプト: 図書館管理システムに貸出機能を追加してください。
   以下を実装してください：
   
   更新対象ファイル：
   - Book.cs: 貸出状態を追加
   - Member.cs: 新規作成、会員情報
   - Loan.cs: 新規作成、貸出記録
   - BookService.cs: 貸出・返却メソッドを追加
   - INotificationService.cs: 新規作成、通知インターフェース
   
   要件：
   - 一人3冊まで借りられる
   - 貸出期間は2週間
   - 延滞時は通知を送る
   ```

### 6. エラー修正とテスト追加

#### 演習5: 問題の修正と品質向上

1. **バグのあるコード**
   ```csharp
   public class ShoppingCart
   {
       private List<CartItem> items = new List<CartItem>();
       
       public void AddItem(Product product, int quantity)
       {
           var item = items.FirstOrDefault(i => i.Product.Id == product.Id);
           if(item != null)
           {
               item.Quantity += quantity;
           }
           else
           {
               items.Add(new CartItem { Product = product, Quantity = quantity });
           }
       }
       
       public decimal GetTotal()
       {
           return items.Sum(i => i.Product.Price * i.Quantity);
       }
   }
   ```

2. **修正とテストの追加**
   ```
   プロンプト: ShoppingCart.csの以下の問題を修正し、
   単体テストを追加してください：
   
   修正内容：
   - null参照の可能性がある箇所の修正
   - 数量が負の値の場合の検証追加
   - スレッドセーフな実装への変更
   
   テスト追加：
   - ShoppingCartTests.cs を作成
   - 正常系・異常系のテストケースを網羅
   - xUnitを使用、日本語でテスト名を記述
   ```

## 実践プロジェクト

### シナリオ: マイクロサービスへの分割

モノリシックなアプリケーションをマイクロサービスに分割します：

1. **現状分析**
   ```
   既存構造:
   /MonolithApp
     - UserService.cs
     - OrderService.cs  
     - InventoryService.cs
     - PaymentService.cs
     - NotificationService.cs
   ```

2. **第1段階: インターフェースの抽出**
   ```
   プロンプト: 各サービスクラスからインターフェースを抽出してください。
   既存のクラスはそのインターフェースを実装するように更新してください。
   ```

3. **第2段階: 通信レイヤーの追加**
   ```
   プロンプト: 各サービス間の通信をHTTPベースに変更するため、
   以下を実装してください：
   - 各サービスにAPIコントローラーを追加
   - サービス間通信用のHttpClientラッパーを作成
   - 既存の直接呼び出しをHTTP経由に変更
   ```

### Edit モードのベストプラクティス

#### ファイル選択の戦略

1. **関連ファイルのグループ化**
   - モデルとそのリポジトリ
   - インターフェースと実装
   - サービスとそのテスト

2. **段階的な変更**
   - 大きな変更は小さなステップに分割
   - 各ステップでテストを実行
   - 問題があれば早期に発見

#### 効果的なプロンプト

1. **明確なファイル指定**
   ```
   良い例: "User.cs、IUserRepository.cs、UserRepository.csを更新して..."
   悪い例: "ユーザー関連のファイルを更新して..."
   ```

2. **具体的な要件**
   ```
   良い例: "EmailプロパティにValidation属性を追加し、
           RepositoryにFindByEmailメソッドを追加"
   悪い例: "メール機能を追加"
   ```

### 変更の管理

#### レビューとアプリケーション

1. **個別ファイルのレビュー**
   - ファイルごとに変更内容を確認
   - 不要な変更は却下
   - 必要に応じて手動で微調整

2. **一括操作**
   - Accept All: すべての変更を承認
   - Discard All: すべての変更を破棄
   - 慎重に使用すること

## トラブルシューティング

### よくある問題と対処法

1. **期待しない変更が含まれる**
   - より具体的なプロンプトを使用
   - ファイルを明示的に指定
   - 小さな変更単位で実行

2. **変更が適用されない**
   - ファイルが保存されているか確認
   - 構文エラーがないか確認
   - VS Codeを再起動

## まとめ

学習した内容：
- Edit モードの基本的な使い方
- 複数ファイルの同時編集
- リファクタリングへの活用
- 大規模な機能追加の実装
- 効果的なファイル選択とプロンプト作成

## 次のステップ

次は「Agent モード」について学習し、より自律的なコード生成と問題解決の方法を習得しましょう。
