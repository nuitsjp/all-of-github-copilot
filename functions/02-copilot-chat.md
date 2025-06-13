# Copilot Chat 学習プラン

## 概要
- **機能名**: Copilot Chat
- **学習時間**: 20分
- **対象プラン**: Pro/Pro+/Business/Enterprise
- **対応環境**: GitHub Web, GitHub Mobile, IDE, Windows Terminal

## 学習目標
- チャット形式でのコード相談機能を理解する
- 効果的な質問方法を習得する
- 各環境での使い方を確認する

## 実践内容

### 1. VS Code内でのChat (8分)
```csharp
// テスト用のサンプルコード
public class OrderProcessor
{
    public decimal CalculateTotal(List<OrderItem> items)
    {
        return items.Sum(item => item.Price * item.Quantity);
    }
}
```

**試す質問例:**
- "このコードにエラーハンドリングを追加してください"
- "単体テストを作成してください"
- "このメソッドのパフォーマンスを改善する方法は？"
- "LINQ を使わない書き方で書き直してください"

### 2. GitHub Web でのChat (7分)
- GitHub.comでCopilot Chatを開く
- リポジトリのコードについて質問
- PR作成時の相談機能を確認

**試す内容:**
- "このリポジトリの構造を説明してください"
- "README.mdの改善案を提案してください"
- "セキュリティの観点でチェックすべき点は？"

### 3. Windows Terminal でのChat (5分)
- Windows Terminal CanaryでCopilot機能を確認
- コマンドラインでの質問と回答

**試す内容:**
- Git コマンドの説明要求
- PowerShell スクリプトの作成依頼
- トラブルシューティングの相談

## 確認ポイント
- [ ] 日本語での質問が適切に理解される
- [ ] コードコンテキストを理解した回答が得られる
- [ ] 複数の選択肢を提示してくれる
- [ ] フォローアップ質問ができる
- [ ] 各環境で機能差があるか確認

## 効果的な質問のコツ
1. 具体的で明確な質問をする
2. コンテキスト情報を提供する
3. 期待する回答の形式を指定する
4. 段階的に詳細を掘り下げる

## デモ用メモ
- 実際の開発シナリオでの活用例
- 従来の検索との違い
- ChatGPTなど他のAIツールとの使い分け

## 次のステップ
- Copilot Extensionsとの連携確認
- より高度な技術的質問での精度確認
