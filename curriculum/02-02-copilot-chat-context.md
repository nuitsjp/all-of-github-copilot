# Copilot Chat のコンテキスト管理

## 学習目標
適切なコンテキストを提供することで、より正確で関連性の高い応答を得る方法を学習します。

## 学習内容

### 1. 暗黙的コンテキストの理解

#### 演習1: 自動的に含まれるコンテキストを確認

1. 新しいC#ファイルを作成：
   ```csharp
   // UserService.cs
   public class UserService
   {
       private readonly IUserRepository _repository;
       
       public UserService(IUserRepository repository)
       {
           _repository = repository;
       }
   }
   ```

2. コードの一部を選択して、チャットで質問：
   - 選択したテキストが自動的にコンテキストに含まれることを確認
   - ファイル名が表示されることを確認

### 2. #-mentionsの活用

#### 演習2: 各種コンテキストアイテムを試す

1. **ファイル参照**
   ```
   プロンプト: #UserService.cs このクラスにGetUserByIdメソッドを追加
   ```

2. **コードベース検索**
   ```
   プロンプト: #codebase IUserRepositoryの実装はどこにありますか？
   ```

3. **変更内容の参照**
   ```
   プロンプト: #changes 変更内容を要約してください
   ```

4. **問題の参照**
   ```
   プロンプト: #problems これらの問題を修正してください
   ```

### 3. 複数ファイルのコンテキスト

#### 演習3: 関連ファイルを含めた開発

1. 以下のファイル構造を作成：
   ```
   /src
     /Models
       - User.cs
     /Repositories
       - IUserRepository.cs
       - UserRepository.cs
     /Services
       - UserService.cs
   ```

2. 複数ファイルを参照するプロンプト：
   ```
   プロンプト: #User.cs #IUserRepository.cs #UserService.cs 
   これらのファイルを使用して、ユーザー検索機能を実装してください
   ```

### 4. Web コンテンツの参照

#### 演習4: 外部リソースの活用

1. **ドキュメントの参照**
   ```
   プロンプト: #fetch https://learn.microsoft.com/ja-jp/aspnet/core/fundamentals/dependency-injection
   このドキュメントに基づいて、DIコンテナの設定を実装してください
   ```

2. **GitHubリポジトリの参照**
   ```
   プロンプト: #githubRepo microsoft/AspNetCore.Docs
   このリポジトリのベストプラクティスに従ってコントローラーを実装してください
   ```

### 5. カスタム指示の作成

#### 演習5: プロジェクト固有の指示ファイル

1. `.github/copilot-instructions.md` を作成：
   ```markdown
   # プロジェクトのコーディング規約
   
   ## 命名規則
   - クラス名: PascalCase
   - メソッド名: PascalCase
   - 変数名: camelCase
   - プライベートフィールド: _camelCase
   
   ## アーキテクチャ
   - リポジトリパターンを使用
   - 依存性注入を活用
   - 単体テストは必須
   ```

2. 指示に従った実装を依頼：
   ```
   プロンプト: ProductServiceクラスを作成してください
   ```

## 実践プロジェクト

### シナリオ: ユーザー管理システムの構築

以下の手順で、コンテキストを活用しながらシステムを構築します：

1. **モデルの作成**
   ```
   プロンプト: ユーザー管理システムのUserモデルを作成してください。
   ID、名前、メールアドレス、作成日時を含めてください
   ```

2. **リポジトリインターフェースの定義**
   ```
   プロンプト: #User.cs このモデルに対するCRUD操作を定義するIUserRepositoryインターフェースを作成
   ```

3. **実装の作成**
   ```
   プロンプト: #User.cs #IUserRepository.cs 
   Entity Framework Coreを使用してUserRepositoryを実装してください
   ```

4. **サービス層の構築**
   ```
   プロンプト: #User.cs #IUserRepository.cs #UserRepository.cs
   ビジネスロジックを含むUserServiceを作成してください。
   メールアドレスの重複チェックを含めてください
   ```

5. **単体テストの追加**
   ```
   プロンプト: #UserService.cs #testFailure
   このサービスの単体テストを作成し、失敗しているテストを修正してください
   ```

## 高度なコンテキスト管理

### ワークスペースインデックスの活用

1. **設定を有効化**
   - `github.copilot.chat.codesearch.enabled` を有効にする

2. **大規模コードベースでの検索**
   ```
   プロンプト: #codebase 認証処理の実装を説明してください
   ```

### チャット履歴の管理

1. **新しいセッションの開始**
   - Ctrl+L で新しいチャットセッションを開始
   - コンテキストをリセットして新しいトピックに移行

2. **フォローアップ質問**
   ```
   初回: "UserServiceにキャッシュ機能を追加してください"
   フォローアップ: "キャッシュの有効期限を設定可能にしてください"
   ```

## まとめ

学習した内容：
- 暗黙的・明示的なコンテキストの違い
- #-mentionsを使った効果的なコンテキスト指定
- 複数ファイルやWebコンテンツの参照方法
- カスタム指示によるプロジェクト固有の要件の伝達
- ワークスペースインデックスの活用方法

## 次のステップ

次は「チャットモード」について学習し、タスクに応じた最適なモードの選択方法を習得しましょう。
