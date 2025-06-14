# Copilot Coding Agent 学習マニュアル

## 学習概要
- **学習時間**: 約4時間
- **対象レベル**: GitHub Copilot Pro+/Enterprise利用者
- **前提条件**: GitHub Copilot基本機能の理解
- **環境**: VS Code + C# + GitHub リポジトリ

## 学習目標
GitHub Copilot coding agentの全機能を理解し、実際のプロジェクトで効果的に活用できるようになる

### 具体的な到達目標
- Issueへのタスク割り当てができる
- Pull requestの作成依頼ができる
- エージェントセッションログを理解できる
- 適切なベストプラクティスを適用できる
- トラブルシューティングができる

## 機能一覧
1. **Copilot へのタスクの割り当て** - 基本概念とワークフロー
2. **Issue処理** - GitHubのIssueをCopilotに割り当てる方法
3. **Pull request作成依頼** - Copilot Chatからのプルリク作成
4. **エージェントセッションログ** - Copilotの作業進捗確認
5. **Pull requestレビュー** - Copilotが作成したPRのレビュー方法
6. **ベストプラクティス** - 効果的な活用方法
7. **有効化設定** - 機能の有効化手順
8. **トラブルシューティング** - 問題解決方法

## 学習順序
1. [基本概念とタスク割り当て](03-coding-agent/about-assigning-tasks-to-copilot.md) (30分)
2. [機能有効化](03-coding-agent/enabling-copilot-coding-agent.md) (15分)
3. [ベストプラクティス](03-coding-agent/best-practices-for-using-copilot-to-work-on-tasks.md) (45分)
4. [Issue処理実践](03-coding-agent/using-copilot-to-work-on-an-issue.md) (60分)
5. [Pull request作成実践](03-coding-agent/asking-copilot-to-create-a-pull-request.md) (30分)
6. [エージェントログ活用](03-coding-agent/using-the-copilot-coding-agent-logs.md) (30分)
7. [Pull requestレビュー](03-coding-agent/reviewing-a-pull-request-created-by-copilot.md) (30分)
8. [トラブルシューティング](03-coding-agent/troubleshooting-copilot-coding-agent.md) (30分)

## 事前準備
### 必要なアクセス権限
- GitHub Copilot Pro+またはEnterprise
- リポジトリへの書き込みアクセス権限
- Organization設定でのcoding agent有効化

### 学習用リポジトリ準備
```bash
# テスト用リポジトリ作成
mkdir copilot-coding-agent-practice
cd copilot-coding-agent-practice
git init
# README.md、簡単なC#プロジェクトを作成
```

## 学習のポイント
- **実践重視**: 各機能を実際に使用して体験する
- **段階的学習**: 基本から応用へ順序立てて進める
- **問題解決**: トラブルシューティングも含めて習得する
- **ベストプラクティス**: 効果的な使い方を身につける

## 注意事項
- Copilot coding agentはパブリックプレビュー機能
- Pro+/Enterprise限定機能
- GitHub Actionsの利用量とPremiumリクエストが消費される
- セキュリティとプライバシーに関する制限事項の理解が重要
