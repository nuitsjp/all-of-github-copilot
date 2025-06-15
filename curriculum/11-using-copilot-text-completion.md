# Copilot テキスト入力候補の学習教材

## 概要

Copilot テキスト入力候補は、Pull Request の説明を AI が自動補完してくれる機能です。この機能により、開発者はより効率的かつ正確な Pull Request の説明を作成できるようになります。

## 学習目標

この教材を完了すると、以下のことができるようになります：

- Copilot テキスト入力候補の基本概念を理解する
- Pull Request作成時に効果的な説明文を自動生成できる
- 機能の有効化・無効化を適切に管理できる

## 前提条件

- GitHub Enterprise Cloud のアカウント
- GitHub Copilot Enterprise のサブスクリプション
- 企業管理者による Copilot 機能プレビューの有効化

## 実践シナリオ: C#プロジェクトでの機能追加

### シナリオ設定

あなたは C# プロジェクトで新しいユーザー管理機能を開発しています。以下のコードを追加した後、Pull Request を作成する場面を想定します。

```csharp
/// <summary>
/// ユーザー情報を管理するサービスクラス
/// </summary>
public class UserService
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// UserService のコンストラクタ
    /// </summary>
    /// <param name="userRepository">ユーザーリポジトリ</param>
    /// <exception cref="ArgumentNullException">userRepository が null の場合</exception>
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
    }

    /// <summary>
    /// 新しいユーザーを作成します
    /// </summary>
    /// <param name="userName">ユーザー名</param>
    /// <param name="email">メールアドレス</param>
    /// <returns>作成されたユーザーのID</returns>
    /// <exception cref="ArgumentException">ユーザー名またはメールアドレスが無効な場合</exception>
    public async Task<int> CreateUserAsync(string userName, string email)
    {
        if (string.IsNullOrWhiteSpace(userName))
            throw new ArgumentException("ユーザー名は必須です", nameof(userName));
        
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("メールアドレスは必須です", nameof(email));

        var user = new User
        {
            UserName = userName,
            Email = email,
            CreatedAt = DateTime.UtcNow
        };

        return await _userRepository.CreateAsync(user);
    }
}
```

### 手順 1: Pull Request の作成開始

1. GitHub のリポジトリページで **「Pull request」** をクリック
2. **「New pull request」** を選択
3. 適切なブランチを選択（例: `feature/user-management` → `main`）

### 手順 2: Copilot テキスト入力候補の活用

1. **タイトル** フィールドに「Add UserService class」と入力
2. **説明** フィールドにカーソルを置く
3. 「この Pull Request では」と入力を開始する

**期待される Copilot の提案例:**
```
この Pull Request では、新しいユーザー管理機能を追加しました。

## 変更内容
- UserService クラスの実装
- ユーザー作成機能の追加
- 適切な引数検証の実装
- XMLドキュメントコメントの追加

## テスト
- ユーザー作成の正常系テスト
- 引数検証のテスト
- 例外処理のテスト
```

### 手順 3: 提案の活用

1. **Tab キー** を押して提案を受け入れる
2. 必要に応じて追加の詳細を手動で入力
3. **Esc キー** で不要な提案を無視
4. Copilot が新しいコンテキストに基づいて追加提案を表示

### 手順 4: 設定の管理

機能の有効化・無効化：

1. 説明フィールド上部の設定アイコンをクリック
2. **「Autocomplete (パブリック プレビュー)」** にマウスオーバー
3. **「Enabled」** または **「Disabled」** を選択

## 実践演習

### 演習 1: バグ修正の Pull Request

以下のバグ修正コードで Pull Request を作成し、Copilot の提案を活用してください：

```csharp
// 修正前のコード（コメントで説明）
// public void ValidateEmail(string email)
// {
//     if (!email.Contains("@")) // 不十分な検証
//         throw new ArgumentException("Invalid email");
// }

/// <summary>
/// メールアドレスの妥当性を検証します
/// </summary>
/// <param name="email">検証するメールアドレス</param>
/// <exception cref="ArgumentException">メールアドレスが無効な場合</exception>
public void ValidateEmail(string email)
{
    if (string.IsNullOrWhiteSpace(email))
        throw new ArgumentException("メールアドレスは必須です", nameof(email));

    var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    if (!emailRegex.IsMatch(email))
        throw new ArgumentException("無効なメールアドレス形式です", nameof(email));
}
```

### 演習 2: パフォーマンス改善の Pull Request

キャッシュ機能を追加したコードで Pull Request を作成してください：

```csharp
/// <summary>
/// キャッシュ機能付きユーザーサービス
/// </summary>
public class CachedUserService : IUserService
{
    private readonly IUserService _userService;
    private readonly IMemoryCache _cache;
    private readonly TimeSpan _cacheExpiry = TimeSpan.FromMinutes(30);

    public CachedUserService(IUserService userService, IMemoryCache cache)
    {
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        _cache = cache ?? throw new ArgumentNullException(nameof(cache));
    }

    /// <summary>
    /// キャッシュ機能付きでユーザーを取得します
    /// </summary>
    public async Task<User> GetUserAsync(int userId)
    {
        string cacheKey = $"user_{userId}";
        
        if (_cache.TryGetValue(cacheKey, out User cachedUser))
            return cachedUser;

        var user = await _userService.GetUserAsync(userId);
        _cache.Set(cacheKey, user, _cacheExpiry);
        
        return user;
    }
}
```

## ベストプラクティス

### 効果的な説明文の構成

1. **概要**: 変更の目的を明確に
2. **変更内容**: 具体的な実装内容
3. **テスト**: 実施したテストの概要
4. **注意事項**: レビュー時の確認ポイント

### Copilot 活用のコツ

1. **コンテキストの提供**: ファイル名や変更内容を明確に
2. **段階的入力**: 少しずつ入力して適切な提案を得る
3. **手動調整**: 自動提案をベースに必要に応じて修正

## まとめ

Copilot テキスト入力候補を活用することで：

- Pull Request の説明作成時間を大幅短縮
- 一貫性のある高品質な説明文を作成
- レビュー効率の向上
- チーム全体のドキュメント品質向上

この機能を日常的に使用することで、開発チーム全体の生産性向上に貢献できます。
