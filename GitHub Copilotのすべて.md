---
marp: true
paginate: true
style: |
  section {
    font-family: 'メイリオ', 'Meiryo', sans-serif;
    font-size: 26px; /* デフォルト29px→26pxに縮小 */
  }
  h1 {
    color: #0366d6;
    font-size: 1.3em; /* デフォルト1.6em→1.3emに縮小 */
  }
  h2 {
    color: #0366d6;
    border-bottom: 2px solid #0366d6;
    font-size: 1.1em; /* デフォルト1.3em→1.1emに縮小 */
  }
  table {
    font-size: 0.9em;
  }
  .highlight {
    background-color: #ffeb3b;
  }
  /* プランアイコンのスタイル定義 */
  .plan-indicators {
    position: absolute;
    top: 20px;
    right: 40px;
    display: flex;
    gap: 8px;
    font-size: 0.92em; /* バッジもやや小さく */
  }
  .plan-badge {
    display: inline-block;
    padding: 6px 12px 3px 12px;
    border-radius: 16px;
    font-size: 0.62em; /* さらに小さく */
    font-weight: bold;
    color: white;
  }
  .plan-active {
    background-color: #7c4dff;
  }
  .plan-inactive {
    background-color: #cccccc;
  }
---
# GitHub Copilotのすべて

<br>
<br>
<br>
<br>

## Azure DevOpsオンライン Vol.13 Agentic DevOpsって何？
### 2025年6月21日

---

# GitHub Copilotの最強なポイントは？

---

# 💰 GitHub Copilotは支払いやすさが最強！


### 🏢 **企業での導入が簡単な理由**

#### ✅ **既存の支払い手段を活用**
- GitHubの既存契約に追加するだけ
- 新規の支払い手続き不要

#### ❌ **他の生成AIサービスの課題**
- クレジットカード必須
- 企業での新規決済は承認が大変
- 経理処理が・・・

---

# 本日のゴール

## （ほぼ）すべての機能の概略を知る

デモ中心に解説します

※ 管理機能およびEnterprise限定などの一部機能を除く

---

# 👨‍💻 自己紹介


- 名前: 中村 充志
- 所属: リコージャパン株式会社
- Microsoft MVP for Development Technologies（2017〜）

---

# 📌 本日の環境

### 🛠️ **使用環境**
- GitHub Copilot Pro+ (Microsoft MVP特典)
- VS Code + C#

<br>

### 🙏 **Special Thanks**
<span class="highlight">**Microsoftさんありがとう！**</span> 🎉

MVP特典でPro+を使わせていただいています！

---

# 発表コンテンツについて

<br>

## 📂 発表コンテンツ
https://github.com/nuitsjp/all-of-github-copilot

## 📑 スライド
https://www.docswell.com/s/nuits_jp/K6VXPX-2025-06-18-all-of-github-copilot

## 📚 学習コンテンツ
https://agreeable-island-0c8e4d900.6.azurestaticapps.net/

---

# たのしい話（機能）の前に楽しくない（お金）の話


---
# GitHub Copilot プラン比較

<br>

| プラン | 月額 | 主な対象 | プレミアムリクエスト |
|--|--|--|--|
| **Free** | 無料 | 個人開発者 | 50/月 |
| **Pro** | $10 | 個人開発者 | 300/月 |
| **Pro+** | $39 | AIパワーユーザー | 1,500/月 |
| **Business** | $19/ユーザー | チーム・組織 | 300/ユーザー/月 |
| **Enterprise** | $39/ユーザー | 大規模組織 | 1,000/ユーザー/月 |

<br>

一部機能の制限とプレミアムリクエストのリミットの相違

---

# プレミアムリクエストとは


## 📊 基本概念

### 🔄 リクエストの定義
- Copilotへのすべての依頼
- チャットでの質問、コード生成、拡張機能の利用など

### 💰 課金モデル
- **基本**: プランに含まれる月間許可量
- **追加**: 許可量超過時は **$0.04/リクエスト**

---

# モデル別プレミアムリクエスト消費量

<br>

| モデル |Premium リクエスト|
|--|--|
|基本モデル（現在はGPT-4.1）|0（有料ユーザー）、1（Free）|
|Claude Sonnet 4|1|
|Claude Opus 4|10|
|o3|1|
|o4-mini|0.33|

---

# 🤔 BusinessとEnterpriseの共存は可能か？

### 💭 よくある疑問
- ユーザーによって利用頻度が異なり、使い分けたいことがある
- コスト最適化を図りたい

<br>

### 🎯 答え: **共存可能です！**

---

# ✅ BusinessとEnterpriseの共存可能

### 🔄 **混在のメリット**
- <span class="highlight">同一リポジトリで異なるライセンスユーザーの混在は可能</span>
- ユーザーの役割に応じたライセンス割り当て

### ⚠️ **注意点**
- ただ現状のライセンス設計にだいぶ無理がある
- 将来変わる可能性はあり

---

# 📋 重要なポイント

### 🏢 **Organization制限**
- <span class="highlight">OrganizationにはBusinessまたはEnterprise何れかのみ設定可能</span>
   - 例: BusinessレベルのOrganizationでライセンスを割り当てるとBusinessに

### 👥 **Team単位の管理**
- CopilotライセンスはOrganization内のTeamごとに割り当てられる
   - Copilotが有効なユーザーと無効なユーザーが混在可能

### 🏆 **ライセンス優先度**
- ライセンスを重複割当した場合、有効ライセンスは優先度によって決定
   - **Enterprise** > **Business** > **Pro+・Pro**
   - おそらくガバナンスを優先するため

---

# 🎯 Biz/Entの混在おすすめ設定

### 💡 <span class="highlight">リポジトリー管理Organizationとライセンス管理Organizationを分ける</span>

### 📊 **構成例**

| Organization | ユーザー | 用途 |
|---|---|---|
| 🏢 **Business License Org** | User B1, User B2 | ライセンス管理専用 |
| 🚀 **Enterprise License Org** | User E1, User E2 | ライセンス管理専用 |
| 📁 **Repository Org** | 全ユーザー | 実際の開発作業 |

### 🔧 **設定のポイント**
- ライセンス用Organizationにはリポジトリーを持たせない
- リポジトリーは別Organizationに配置

---

# 機能紹介

---

# 機能①

|#| 機能名 |Free| Pro | Pro+ | Business | Enterprise |
|--|--|:-:|:-:|:-:|:-:|:-:|
|1|Code completion | ✅ | ✅ | ✅ | ✅ | ✅ |
|2|Copilot Chat | ✅ | ✅ | ✅ | ✅ | ✅ |
|3|Copilot coding agent | ❌ | ❌ | ✅ | ❌ | ✅ |
|4|Copilot in the CLI | ✅ | ✅ | ✅ | ✅ | ✅ |
|5|GitHub Copilot code review | ✅| ✅ | ✅ | ✅ | ✅ |
|6|GitHub Models | ❌ | ❌ | ✅ | ✅ | ✅ |
|7|Repository and personal custom instructions| ✅ | ✅ | ✅ | ✅ | ✅ |
|8|Organization custom instructions | ❌ | ❌ | ❌ | ✅ | ✅ |

---

# 機能②

|#| 機能名 |Free| Pro | Pro+ | Business | Enterprise |
|--|--|:-:|:-:|:-:|:-:|:-:|
|9|Copilot prompt files| ✅ | ✅ | ✅ | ✅ | ✅ |
|10|Copilot pull request summaries | ❌ | ✅ | ✅ | ✅ | ✅ |
|11|Copilot text completion | ❌ | ❌ | ❌ | ❌ | ✅ |
|12|GitHub Copilot Extensions | ✅ | ✅ | ✅ | ✅ | ✅ |
|13|Copilot Workspace | ❌ | ✅ | ✅ | ✅ | ✅ |
|14|Copilot Spaces | ✅ | ✅ | ✅ | ✅ | ✅ |
|15|Copilot knowledge bases | ❌ | ❌ | ❌ | ❌ | ✅ |

---

# ⚠️ 最初にお断り

### 🚫 **本日デモできない機能**

<span class="highlight">次の機能は本日お見せできません。</span>

<br>

1. **🔒 制限Preview機能** - 現在募集されていないもの
2. **🏢 Enterprise限定機能** - 高度な管理・統合機能

<br>

これらは簡単な解説のみとなります。

---

<!-- 1. Code Completion のヘッダーに計画アイコンを追加 -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 1. Code Completion

## <span style="color:#0366d6; font-weight:bold;">⚡ リアルタイムコード補完</span>

### 📝 概要
- AIによる自動的なコード提案
- 文脈を理解した賢い補完
- 複数行の提案も可能

---

<!-- 2. Copilot Chat -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 2. Copilot Chat

## 対話型コーディングアシスタント

### 🗣️ 3つのモード

| モード | 用途 | 特徴 |
|--------|------|------|
| **Ask** | 質問・説明 | コードの理解、技術的な質問 |
| **Edit** | ファイル編集 | 複数ファイルの制御された編集 |
| **Agent** | 自律的実行 | タスクの自動完了、ツール実行 |

- [GitHub Copilot Chat チート シート](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet?tool=vscode#chat-variables)

---

# Copilot Chat モードの機能比較

### 📊 **各モードの機能範囲**

| 機能 | Ask | Edit | Agent |
|------|:---:|:----:|:-----:|
| 質問への回答 | ✅ | ✅ | ✅ |
| 単一ファイル編集 | ❌ | ✅ | ✅ |
| 複数ファイル編集 | ❌ | ✅ | ✅ |
| ターミナル実行 | ❌ | ❌ | ✅ |
| エラー自動修正 | ❌ | ❌ | ✅ |
| 実装計画作成 | ❌ | ❌ | ✅ |
| **MCP利用** | ❌ | ❌ | ✅ |
| **利用可能モデル** | ◎ | ◎ | ○ |

---
# なぜ機能の少ないモードを選ぶのか？

### 🎯 **Ask モードを選ぶ理由**
- **最速の応答**: 編集機能がない分、処理が軽い
- **純粋な情報取得**: コードを誤って変更するリスクがゼロ
- **リクエスト消費最小**: 対話のみで追加処理なし

### ✏️ **Edit モードを選ぶ理由**
- **予測可能性**: 指定したファイルのみ変更（Agent は探索的）
- **高速処理**: 計画フェーズがないため Agent より速い
- **制御性**: ツール実行なし、コード変更のみに集中
- **中程度のリクエスト消費**: Agent の1/3〜1/5程度

---

# 🎨 カスタムチャットモード

## プロジェクト固有のAI設定

### 📝 **概要**
- `.chatmode.md`ファイルでカスタムモードを定義
- プロジェクト固有の指示とツールセットを設定

### 🏗️ **ファイル構造**
```markdown
---
description: モードの説明
tools: ['tool1', 'tool2', 'tool3']
---
# カスタムモード指示
ここにAIへの具体的な指示を記述
```

---

<!-- 3. Copilot Coding Agent -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-inactive">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-inactive">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 3. Copilot Coding Agent

## 自動実装エージェント

### 🤖 機能
- GitHub IssueからPRまでの自動実装
- コードの自動生成と検証
- テストの作成と実行

### 🔄 ワークフロー
1. Issueの理解と分析
2. 実装計画の作成
3. コードの自動生成
4. PRの作成

---

<!-- 4. Copilot in the CLI -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 4. Copilot in the CLI

## コマンドライン支援

### 🖥️ 機能
- コマンドの提案
- コマンドの説明
- エラーの解決支援

### 💡 使用例
```bash
gh copilot suggest "ファイルを再帰的に検索"
gh copilot explain "git rebase -i HEAD~3"
```

---

<!-- 5. GitHub Copilot Code Review -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 5. GitHub Copilot Code Review

## AIによるコードレビュー

### 🔍 機能
- PRの自動レビュー
- 改善提案の生成
- セキュリティ問題の検出

### 📊 レビュー内容
- コード品質
- ベストプラクティス
- 潜在的なバグ

---

<!-- 6. GitHub Models -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-inactive">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 6. GitHub Models

## AI言語モデルへのアクセス

### 🤖 機能
- 業界をリードする大規模・小規模言語モデルへの直接アクセス
- 様々なAIモデルの試用と比較
- プロトタイピングと実験

### 🎯 用途
- モデルの選定
- APIの事前検証
- 性能比較

---

<!-- 7. Repository and Personal Custom Instructions -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 7. Repository and Personal Custom Instructions

## 応答のカスタマイズ

### ⚙️ 機能
- 個人の好みに基づく応答調整
- 使用ツール・フレームワークの指定
- プロジェクト固有の要件設定

### 📝 設定例
- コーディング規約の指定
- 優先言語/フレームワーク
- セキュリティ要件

---

<!-- 8. Organization Custom Instructions -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-inactive">Pro</span>
  <span class="plan-badge plan-inactive">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 8. Organization Custom Instructions

## 組織レベルのカスタマイズ

### 🏢 機能
- 組織全体での統一された応答設定
- 企業のコーディング規約の適用
- セキュリティポリシーの強制

### 🎯 メリット
- 一貫性のあるコード生成
- 組織標準の自動適用
- 品質の統一化

---

<!-- 9. Copilot Prompt Files -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 9. Copilot Prompt Files

## プロンプトファイルの活用

### 📁 機能
- 再利用可能なプロンプトの定義
- プロジェクト固有の設定
- チーム間での共有

### 💡 使用例
- `.github/prompts/foo-prompts.md`
- テンプレートの定義
- ベストプラクティスの共有

---

<!-- 10. Copilot Pull Request Summaries -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 10. Copilot Pull Request Summaries

## PR要約の自動生成

### 📝 機能
- PR変更内容の自動要約
- 影響範囲の分析
- レビュアー向けの説明生成

### 🎯 メリット
- レビュー時間の短縮
- 変更内容の明確化
- コミュニケーションの改善

---

<!-- 11. Copilot Text Completion -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-inactive">Pro</span>
  <span class="plan-badge plan-inactive">Pro+</span>
  <span class="plan-badge plan-inactive">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 11. Copilot Text Completion

## テキスト補完支援

### ✍️ 機能
- PR説明文の迅速・正確な作成支援

### 🎯 メリット
- 一貫性のある文書作成
- 時間の節約
- 品質の向上

---

<!-- 12. GitHub Copilot Extensions -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 12. GitHub Copilot Extensions

## Copilot Extensions 概要

- Copilot Chatに外部ツールやサービスを統合できる拡張機能
- GitHub Appとして提供、Marketplaceからインストール

### 主な用途
- クラウド管理（Azure等）、CI/CD連携、社内システム操作
- チャットからAPI呼び出しや自動化が可能

### ポイント
- 個人・組織どちらでも利用可（組織リソース利用時は管理者承認）
- 公開/非公開や権限管理が柔軟
- セキュリティ・プライバシーに配慮

---

<!-- 13. Copilot Workspace -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 13. Copilot Workspace

## AIによる統合開発フロー自動化

### 📝 概要
- Issueやタスクを自然言語で書くと、仕様検討・計画・実装・テスト・PR作成
- チャットや直接編集やCodespaces連携で即ビルド・テストもOK

### 🔄 ワークフロー
1. Issue作成→Workspace起動
2. AIが計画・実装案を自動生成
3. 差分を確認しつつ修正・テスト
4. PR作成も自動化、追加修正もAIで反映

---

<!-- 14. Copilot Spaces -->
<div class="plan-indicators">
  <span class="plan-badge plan-active">Free</span>
  <span class="plan-badge plan-active">Pro</span>
  <span class="plan-badge plan-active">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 14. Copilot Spaces

## コードと知識の一元化・共有

### 📝 概要
- プロジェクトやチームの「文脈」をスペースに集約
- コード・ドキュメント・カスタム命令などを追加
- Copilotがそのスペースの専門家として応答

### 📦 主な機能
- **リポジトリやファイルをスペースに直接アタッチ**（常に最新）
- **カスタム命令・メモの追加**（応答を最適化）
- **スペースの共有**（チーム全体で活用）

---

<!-- 15. Copilot Knowledge Bases -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-inactive">Pro</span>
  <span class="plan-badge plan-inactive">Pro+</span>
  <span class="plan-badge plan-inactive">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 15. Copilot Knowledge Bases

### 📝 概要
- 複数リポジトリのMarkdownドキュメントをまとめて「ナレッジベース」として管理
- Copilot Chatでナレッジベースを指定し、組織の技術情報をAI応答に活用

### 📦 主な機能
- **リポジトリやパス単位でナレッジベースを作成・編集・削除**
- **Enterpriseユーザー全員が利用可能**

### 💡 利用イメージ
- 組織標準の技術情報・FAQ・設計書を一元化
- 社内ガイドラインや運用手順をナレッジベース化し、Copilot Chatで即参照

---

# Copilot SpacesとKnowledge Basesの違い

| 項目 | Copilot Spaces | Copilot Knowledge Bases |
|------|:--------------|:-----------------------|
| 作成権限 | 全ユーザー | 組織管理者のみ |
| 対象 | コード・ドキュメント・カスタム命令 | Markdownドキュメントのみ |
| 共有範囲 | チーム/個人/組織 | 組織全体 |
| 用途 | プロジェクト/タスク単位の文脈共有 | 組織標準ナレッジの集約 |
| プラン | Free以上 | Enterprise限定 |

---

<!-- 管理者向け機能 -->
<div class="plan-indicators">
  <span class="plan-badge plan-inactive">Free</span>
  <span class="plan-badge plan-inactive">Pro</span>
  <span class="plan-badge plan-inactive">Pro+</span>
  <span class="plan-badge plan-active">Biz</span>
  <span class="plan-badge plan-active">Ent</span>
</div>

# 管理者向け機能

## Business/Enterprise プラン

### 🔐 アクセス管理
- メンバーのライセンス管理
- 組織レベルのポリシー設定

### 📊 使用状況分析
- 利用統計の確認
- 効果測定

### 🛡️ セキュリティ
- ファイルの除外設定
- 監査ログ

---

# 学習コンテンツの活用方法

## 📚 オンライン教材
https://agreeable-island-0c8e4d900.6.azurestaticapps.net/

### 🎯 学習のポイント
- 正直学習コンテンツとしての精度は微妙
- 発表資料のリポジトリーをクローンしてCopilot Chatで適宜質問・修正しながら実行するのがお勧め
- 別に完璧な教材なんて必要がない

### 📂 **発表資料**

🔗 https://github.com/nuitsjp/all-of-github-copilot

---

# 💡 学習コンテンツの作成方法

### 🚀 **効率的な作成フロー**

#### 1️⃣ **公式ドキュメントの活用**
- プロンプトで学習教材を自動生成

#### 2️⃣ **`#fetch`で直接参照**
- URLを直接指定して効率化

#### 3️⃣ **Markdownでローカル保存**
- コンテキスト長の節約
- Chrome拡張（Webpage to Markdown）の活用

---

# 📝 学習コンテンツ作成のコツ

### 💭 **重要な考え方**

#### ✅ **完璧を求めない**
- 「こんなんで十分」の精神
- 作り込みより実践を優先

#### ✅ **プロンプトに時間をかけない**
- モデルが変われば最適解も変わる
- 学習時間を最優先に

### 📂 **参考資料**
🔗 https://github.com/nuitsjp/all-of-github-copilot

---

# まとめ

## 🎯 本日お伝えしたこと

### ✅ GitHub Copilotの全機能概要
- 15の主要機能
- プラン別の利用可能機能

### ✅ 効果的な学習方法
- 段階的アプローチ
- 実践的な練習

### ✅ 継続的な活用
- 学習コンテンツの活用
- チームでの展開

---

# ありがとうございました！

## 🎉 GitHub Copilotで開発を加速しましょう！

### 📚 リソース
- 学習コンテンツ: https://agreeable-island-0c8e4d900.6.azurestaticapps.net/
- 公式ドキュメント: https://docs.github.com/copilot
- VS Code ドキュメント: https://code.visualstudio.com/docs/copilot/

### 🚀 Happy Coding with GitHub Copilot!
---

# ありがとうございました！

## 🎉 GitHub Copilotで開発を加速しましょう！

### 📚 リソース
- 学習コンテンツ: https://agreeable-island-0c8e4d900.6.azurestaticapps.net/
- 公式ドキュメント: https://docs.github.com/copilot
- VS Code ドキュメント: https://code.visualstudio.com/docs/copilot/

### 🚀 Happy Coding with GitHub Copilot!
- 学習コンテンツ: https://agreeable-island-0c8e4d900.6.azurestaticapps.net/
- 公式ドキュメント: https://docs.github.com/copilot
- VS Code ドキュメント: https://code.visualstudio.com/docs/copilot/

### 🚀 Happy Coding with GitHub Copilot!
- VS Code ドキュメント: https://code.visualstudio.com/docs/copilot/

### 🚀 Happy Coding with GitHub Copilot!
- 学習コンテンツ: https://agreeable-island-0c8e4d900.6.azurestaticapps.net/
- 公式ドキュメント: https://docs.github.com/copilot
- VS Code ドキュメント: https://code.visualstudio.com/docs/copilot/

### 🚀 Happy Coding with GitHub Copilot!
### 🚀 Happy Coding with GitHub Copilot!
