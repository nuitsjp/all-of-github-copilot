# 準備

- VS Codeを開く
- https://github.com/nuitsjp/all-of-github-copilot
- https://github.com/nuitsjp/all-of-github-copilot-private
- https://github.com/copilot


# Code Completion

Program.csに公開鍵暗号化方式のデモ

# Copilot Chat

1. Ask：コメントの表示
2. Edit:コメントの追加
3. Agent
    1. バグ埋め込んでテストして直す
    2. ブランチ作成・コミット・プッシュ
4. カスタムチャットモード
    1. 掛け算の計画を立てる
    2. IssueをMCPを使って建てる

# Copilot Coding Agent

Issueにコパイロットを割り当てて自動的にPRが作成されるところを確認したら先へ

# Copilot in the CLI

```pwsh
gh copilot suggest "PowerShellでファイルを再帰的に検索"
```

# GitHub Copilot Code Review

1. VS Code
    1. Ctrl+Shift+P
    2. コマンド パレットで、[GitHub Copilot: Review and Comment] を検索して選びます。
2. GitHub上でCoding AgentのPRからレビュー割り当て

# GitHub Models

```prompt
あなたはGitバージョン管理システムの専門家です。
ユーザーがコマンドラインからGitを使用する方法について質問した際、200文字以内で例を挙げて説明してください。
```

```prompt
Gitの使い方を学びたいです。ブランチの作成と切り替えについて教えてください。
```

```prompt
Gitの使い方を学びたいです。{{topic}}について教えてください。
```

```variable
ブランチの作成と切り替え
```

```variable
リベースとマージの違いと使い分け
```

```text
git-learning-assistant
```

Issueからのワークフローを見せる
あくまでModelを利用する何らかのサービスの開発に利用する
別の開発のためにModelを利用するのは用途外なので注意

# Repository and Personal Custom Instructions

リポジトリー
パーソナル
個別カスタマイズ

# Organization Custom Instructions

組織全体

# Copilot Prompt Files

学習カリキュラムの作成プロンプト

https://docs.github.com/ja/copilot/using-github-copilot/best-practices-for-using-github-copilot

# Copilot Pull Request Summaries

作成したPRで試す。
custom instructionsが設定できるようになれば実用的になるかも

# Copilot Text Completion

説明のみ