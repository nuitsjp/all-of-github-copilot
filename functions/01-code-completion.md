# Code Completion 学習プラン

## 概要
- **機能名**: Code completion
- **学習時間**: 15分
- **対象プラン**: Pro/Pro+/Business/Enterprise
- **対応環境**: VS Code, Visual Studio, JetBrains, Azure Data Studio, Xcode, Vim/Neovim, Eclipse

## 学習目標
- リアルタイム自動補完の動作を理解する
- 提案品質と応答速度を体感する
- 設定オプションを確認する

## 実践内容

### 1. 基本的な補完テスト (5分)
```csharp
// 新しいC#クラスファイルを作成して以下を試す
public class Calculator
{
    // メソッド名を途中まで入力してTab補完を確認
    public int Add
    
    // ループ処理の補完を確認
    public void ProcessNumbers(int[] numbers)
    {
        // for と入力して補完提案を確認
    }
}
```

### 2. コンテキスト依存の補完 (5分)
```csharp
// 既存コードから推測される補完を確認
public class UserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        // コンストラクタの代入文を補完させる
    }
    
    public async Task<User> GetUserAsync(int userId)
    {
        // 戻り値の型からreturn文を推測させる
    }
}
```

### 3. 設定とカスタマイズ (5分)
- VS Codeの設定でCopilot補完の動作を調整
- Inline suggestionとポップアップの違いを確認
- 補完の受け入れ方法（Tab, Enter, Ctrl+Right）を練習

## 確認ポイント
- [ ] 基本的な補完が適切に動作する
- [ ] コンテキストを理解した提案がされる
- [ ] 応答速度は実用的か
- [ ] 不要な提案を無視できるか
- [ ] 設定で動作をカスタマイズできるか

## デモ用メモ
- どのような場面で最も効果的か
- 従来の補完機能との違い
- 実際の開発効率への影響

## 次のステップ
- Copilot Chatとの連携確認
- より複雑なコードでの動作テスト
