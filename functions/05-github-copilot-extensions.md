# GitHub Copilot Extensions 学習プラン

## 概要
- **機能名**: GitHub Copilot Extensions
- **学習時間**: 20分
- **対象プラン**: Pro/Pro+/Business/Enterprise
- **対応環境**: GitHub

## 学習目標
- 外部ツールとの統合機能を理解する
- 主要なExtensionsを実際に試す
- 開発ワークフローでの活用方法を把握する

## 実践内容

### 1. 利用可能なExtensions確認 (5分)
- GitHub.comでCopilot Chat画面を開く
- @マークで利用可能なExtensionsを確認
- 各Extensionの概要を把握

**主要なExtensions:**
- @docker - Docker関連のサポート
- @github - GitHubリポジトリ操作
- @terminal - ターミナルコマンド支援
- @workspace - ワークスペース分析

### 2. Docker Extension (@docker) (5分)
```bash
# Copilot Chatで以下を試す
@docker C#のWebAPIアプリケーション用のDockerfileを作成してください

@docker このアプリケーションをdocker-composeで起動する設定を教えてください

@docker コンテナのログを確認するコマンドは？
```

### 3. GitHub Extension (@github) (5分)
```bash
# GitHub上でCopilot Chatを開いて試す
@github このリポジトリの最近のコミット履歴を教えてください

@github セキュリティの脆弱性がないかチェックしてください

@github このプロジェクトのCI/CD設定を改善する提案をしてください
```

### 4. Workspace Extension (@workspace) (5分)
```bash
# VS Code内でCopilot Chatを開いて試す
@workspace このプロジェクトの構造を分析してください

@workspace 未使用のファイルや関数を見つけてください

@workspace コードの品質を改善する提案をしてください
```

## 確認ポイント
- [ ] Extensionsが正しく認識される
- [ ] 各Extensionの専門分野での回答品質
- [ ] 通常のChatとの機能差
- [ ] 複数Extensionの組み合わせ使用
- [ ] レスポンス速度と精度

## 活用シーン例
1. **Docker開発**
   - Dockerfile最適化
   - コンテナトラブルシューティング

2. **GitHub操作**
   - リポジトリ分析
   - PR・Issue管理

3. **プロジェクト分析**
   - コードベース理解
   - リファクタリング提案

## デモ用メモ
- 各Extensionの特化した機能
- 外部ツール連携の価値
- 開発効率への具体的影響

## 次のステップ
- より複雑なタスクでの検証
- カスタムExtensionの可能性調査
