# Ask モードの効果的な活用

## 学習目標
Ask モードを使って、コードの理解、技術的な質問、アイデアのブレインストーミングを効果的に行う方法を学習します。

## 学習内容

### 1. Ask モードの基本

#### 演習1: モードの切り替えと基本的な質問

1. **Ask モードへの切り替え**
   - Chat view を開く（Ctrl+Alt+I）
   - モードドロップダウンから「Ask」を選択
   - または直接開く: [VS Code Stable](vscode://GitHub.Copilot-Chat/chat?mode=ask)

2. **基本的な質問の練習**
   ```
   質問例:
   - "C#のrecord型とclass型の違いは何ですか？"
   - "非同期プログラミングのベストプラクティスを教えてください"
   - "SOLID原則について説明してください"
   ```

### 2. コードの理解

#### 演習2: 複雑なコードの解析

1. **サンプルコードの準備**
   ```csharp
   public class OrderProcessor
   {
       private readonly IOrderRepository _orderRepo;
       private readonly IInventoryService _inventory;
       private readonly IPaymentGateway _payment;
       private readonly INotificationService _notification;
       
       public async Task<OrderResult> ProcessOrderAsync(Order order)
       {
           using var transaction = await _orderRepo.BeginTransactionAsync();
           try
           {
               // 在庫確認
               var availableItems = await _inventory.CheckAvailabilityAsync(
                   order.Items.Select(i => (i.ProductId, i.Quantity))
               );
               
               if (!availableItems.All(a => a.IsAvailable))
               {
                   return OrderResult.InsufficientInventory(
                       availableItems.Where(a => !a.IsAvailable).ToList()
                   );
               }
               
               // 支払い処理
               var paymentResult = await _payment.ProcessPaymentAsync(
                   order.PaymentInfo, order.TotalAmount
               );
               
               if (!paymentResult.IsSuccessful)
               {
                   return OrderResult.PaymentFailed(paymentResult.ErrorMessage);
               }
               
               // 注文保存
               order.PaymentTransactionId = paymentResult.TransactionId;
               order.Status = OrderStatus.Confirmed;
               await _orderRepo.SaveOrderAsync(order);
               
               // 在庫更新
               await _inventory.ReserveItemsAsync(order.Id, order.Items);
               
               await transaction.CommitAsync();
               
               // 通知送信
               await _notification.SendOrderConfirmationAsync(order);
               
               return OrderResult.Success(order.Id);
           }
           catch (Exception ex)
           {
               await transaction.RollbackAsync();
               throw;
           }
       }
   }
   ```

2. **理解を深める質問**
   ```
   プロンプト例:
   - "ProcessOrderAsyncメソッドの処理フローを図解してください"
   - "このコードの潜在的な問題点を指摘してください"
   - "エラーハンドリングの改善案を提案してください"
   ```

### 3. ブレインストーミング

#### 演習3: 機能拡張のアイデア出し

1. **既存システムの拡張**
   ```
   プロンプト: 
   "OrderProcessorクラスに以下の機能を追加したいです：
   - 注文のキャンセル機能
   - 部分的な返品処理
   - 優先配送オプション
   各機能の実装アプローチを提案してください"
   ```

2. **アーキテクチャの検討**
   ```
   プロンプト:
   "現在のOrderProcessorをマイクロサービス化する場合、
   どのように分割すべきか提案してください"
   ```

### 4. コンテキストを活用した質問

#### 演習4: #-mentionによる具体的な質問

1. **ファイル全体の分析**
   ```
   プロンプト: "#OrderProcessor.cs このクラスのテスタビリティを
   向上させるためのリファクタリング案を提案してください"
   ```

2. **複数ファイルの関連性**
   ```
   プロンプト: "#OrderProcessor.cs #IInventoryService.cs 
   これらのインターフェース間の依存関係を最適化する方法を教えてください"
   ```

3. **コードベース全体の理解**
   ```
   プロンプト: "#codebase 注文処理に関連するすべてのコンポーネントと
   その相互作用を説明してください"
   ```

### 5. 特殊なキーワードの活用

#### 演習5: @-mentionとスラッシュコマンド

1. **@-mentionの使用**
   ```
   プロンプト: "@terminal 現在のプロジェクトで使用されている
   NuGetパッケージをバージョンと共に一覧表示するコマンドを教えてください"
   ```

2. **スラッシュコマンドの活用**
   ```
   /explain - 選択したコードの説明
   /fix - 問題の修正提案
   /optimize - パフォーマンス最適化の提案
   ```

## 実践プロジェクト

### シナリオ: レガシーコードの理解と改善

既存のレガシーシステムを理解し、改善提案を行います：

1. **コードの理解フェーズ**
   ```csharp
   // LegacyOrderManager.cs
   public class LegacyOrderManager
   {
       private SqlConnection _connection;
       
       public void ProcessOrder(int orderId)
       {
           _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
           _connection.Open();
           
           var cmd = new SqlCommand("SELECT * FROM Orders WHERE Id = " + orderId, _connection);
           var reader = cmd.ExecuteReader();
           
           // 複雑な処理ロジック...
       }
   }
   ```
   
   質問:
   - "このコードの問題点を列挙してください"
   - "モダンなC#での書き換え案を提示してください"

2. **改善提案フェーズ**
   ```
   プロンプト: "#LegacyOrderManager.cs このレガシーコードを
   以下の要件でリファクタリングする計画を立ててください：
   - 依存性注入の導入
   - 非同期処理への移行
   - SQLインジェクション対策
   - 単体テストの追加
   ```

3. **段階的移行の計画**
   ```
   プロンプト: "レガシーシステムを稼働させながら、
   段階的に新しいアーキテクチャに移行する戦略を提案してください"
   ```

### 応答の活用

#### コードブロックの適用方法

1. **Apply in Editor**
   - 提案されたコードをエディタに直接適用
   - スマートな挿入位置の自動判定

2. **Copy to Clipboard**
   - 必要な部分だけをコピー
   - 他のファイルやドキュメントへの転用

3. **Insert at Cursor**
   - カーソル位置への正確な挿入
   - 部分的な変更に便利

## Ask モードのベストプラクティス

### 効果的な質問の仕方

1. **具体的で明確な質問**
   - ❌ "このコードを改善して"
   - ✅ "このコードのエラーハンドリングを改善し、ログ出力を追加してください"

2. **コンテキストの提供**
   - ❌ "認証を実装して"
   - ✅ "#User.cs #IAuthService.cs JWT認証を実装してください"

3. **段階的な質問**
   - まず概要を理解
   - 次に詳細を掘り下げる
   - 最後に具体的な実装方法

### Quick Chat の活用

素早い質問には Quick Chat (Ctrl+Shift+Alt+L) を使用：
- 簡単な構文の確認
- エラーメッセージの意味
- ライブラリの使用方法

## まとめ

学習した内容：
- Ask モードの基本的な使い方
- コード理解のための効果的な質問方法
- ブレインストーミングへの活用
- コンテキストを使った具体的な質問
- 応答の様々な活用方法

## 次のステップ

次は「Edit モード」について学習し、複数ファイルの効率的な編集方法を習得しましょう。
