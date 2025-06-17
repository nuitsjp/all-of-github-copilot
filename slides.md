---
marp: true
paginate: true
style: |
  section {
    font-family: 'メイリオ', 'Meiryo', sans-serif;
  }
  h1 {
    color: #0366d6;
  }
  h2 {
    color: #0366d6;
    border-bottom: 2px solid #0366d6;
  }
  table {
    font-size: 0.7em;
  }
  .highlight {
    background-color: #ffeb3b;
  }
---
# GitHub Copilotのすべて

<br>
<br>
<br>
<br>

### 2025年6月
#### Azure DevOpsオンライン Vol.13 ～ Agentic DevOpsって何?～

---

# 本日のゴール1️⃣

<br>

## （ほぼ）すべての機能の概略を知る

※ 管理機能およびEnterprise限定などの一部機能を除く

---

# 本日のゴール2️⃣

<br>

## 本発表内容の学習の仕方を理解する

---

# 本日のゴール

<br>

## 本発表内容の学習コンテンツが自作できるようになる3️⃣

---

# 👨‍💻 自己紹介


- 名前: 中村 充志
- 所属: リコージャパン株式会社
- Microsoft MVP for Development Technologies（2017〜）

---

### 📌 本日の環境
- GitHub Copilot Pro+ (Microsoft MVP特典)
- VS Code + C#

---

# 発表コンテンツについて

<br>

## 📚 学習コンテンツ
https://agreeable-island-0c8e4d900.6.azurestaticapps.net/

## 📂 発表資料
https://github.com/nuitsjp/all-of-github-copilot

---
# GitHub Copilot プラン比較

| プラン | 月額 | 主な対象 | プレミアムリクエスト |
|--|--|--|--|
| **Free** | 無料 | 個人開発者 | 50/月 |
| **Pro** | $10 | 個人開発者 | 300/月 |
| **Pro+** | $39 | AIパワーユーザー | 1,500/月 |
| **Business** | $19/ユーザー | チーム・組織 | 300/ユーザー/月 |
| **Enterprise** | $39/ユーザー | 大規模組織 | 1,000/ユーザー/月 |

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

<br>

### 💭 よくある疑問
- ユーザーによって利用頻度が異なり、使い分けたいことがある
- コスト最適化を図りたい

<br>

### 🎯 答え: **共存可能です！**

---

# ✅ BusinessとEnterpriseの共存可能

<br>

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
   - **Enterprise** > **Business** > **Pro+** > **Pro**
   - おそらくガバナンスを優先するため

---

# 🎯 Biz/Entの混在おすすめ設定

<br>

### 💡 **ベストプラクティス**
<span class="highlight">リポジトリー管理Organizationとライセンス管理Organizationを分ける</span>

<br>

### 📊 **構成例**

| Organization | ユーザー | 用途 |
|---|---|---|
| 🏢 **Business License Org** | User B1, User B2 | ライセンス管理専用 |
| 🚀 **Enterprise License Org** | User E1, User E2 | ライセンス管理専用 |
| 📁 **Repository Org** | 全ユーザー | 実際の開発作業 |

<br>

### 🔧 **設定のポイント**
- ライセンス用Organizationにはリポジトリーを持たせない
- リポジトリーは別Organizationに配置
- 上記の割り当てに従ったレベルで利用可能

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
|5|GitHub Copilot code review | ✅³| ✅ | ✅ | ✅ | ✅ |
|6|GitHub Models | ❌ | ❌ | ✅ | ✅ | ✅ |
|7|Repository and personal custom instructions| ✅ | ✅ | ✅ | ✅ | ✅ |
|8|Organization custom instructions (public preview)| ❌ | ❌ | ❌ | ✅ | ✅ |

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

# 1. Code Completion

## リアルタイムコード補完

<br>

### 📝 概要
- AIによる自動的なコード提案
- 文脈を理解した賢い補完
- 複数行の提案も可能

### ✅ 利用可能プラン
Free, Pro, Pro+, Business, Enterprise

---

# デモ: Code Completion

<br>

## 🎯 実演内容

1. **基本的なコード補完**
   - メソッドの自動生成
   - パターンの認識

2. **コメントからのコード生成**
   ```csharp
   // 2つの数値を足し算するメソッド
   ```

3. **複雑なロジックの提案**
   - エラーハンドリング
   - LINQ式の生成

---

# 2. Copilot Chat

## 対話型コーディングアシスタント

<br>

### 🗣️ 3つのモード

| モード | 用途 | 特徴 |
|--------|------|------|
| **Ask** | 質問・説明 | コードの理解、技術的な質問 |
| **Edit** | ファイル編集 | 複数ファイルの制御された編集 |
| **Agent** | 自律的実行 | タスクの自動完了、ツール実行 |

### 💡 コンテキスト指定
`#file`, `#codebase`, `#selection`, `@workspace`

---

# デモ: Copilot Chat - Ask Mode

<br>

## 🎯 実演内容

1. **コードの説明を求める**
   ```
   このCalculatorクラスの機能を説明してください
   ```

2. **ベストプラクティスの質問**
   ```
   C#でのエラーハンドリングのベストプラクティスは？
   ```

3. **コンテキストを使った質問**
   ```
   #file:Calculator.cs このファイルの改善点は？
   ```

---

# デモ: Copilot Chat - Edit Mode

<br>

## 🎯 実演内容

1. **複数ファイルの編集**
   - Calculator.cs と CalculatorTests.cs の同時更新

2. **リファクタリング**
   ```
   Calculatorクラスをインターフェースに分離して
   ```

3. **段階的な変更の実行**
   - 提案の確認
   - 選択的な適用

---

# デモ: Copilot Chat - Agent Mode

<br>

## 🎯 実演内容

1. **自律的なタスク実行**
   ```
   新しい機能「平方根計算」を実装して、テストも書いて
   ```

2. **エラーの自動修正**
   - ビルドエラーの検出と修正

3. **テストの実行と修正**
   - 失敗したテストの自動修正

---

# 3. Inline Chat

## エディタ内チャット機能

<br>

### 💬 特徴
- コードを離れずに質問
- Ctrl+I (Cmd+I) で起動
- 選択範囲での操作

### 🎯 使用例
- 選択コードの説明
- インライン修正
- リファクタリング提案

### ✅ 対応IDE
VS Code, Visual Studio, JetBrains

---

# 4. Copilot in the CLI

## コマンドライン支援

<br>

### 🖥️ 機能
- コマンドの提案
- コマンドの説明
- エラーの解決支援

### 💡 使用例
```bash
gh copilot suggest "ファイルを再帰的に検索"
gh copilot explain "git rebase -i HEAD~3"
```

### ✅ 利用可能
全プラン（Pro, Pro+, Business, Enterprise）

---

# 5. Code Review (AI生成)

## AIによるコードレビュー

<br>

### 🔍 機能
- PRの自動レビュー
- 改善提案の生成
- セキュリティ問題の検出

### 📊 レビュー内容
- コード品質
- ベストプラクティス
- 潜在的なバグ

### ⚠️ 利用制限
Pro+ 以上のプランで利用可能

---

# 6. GitHub Models

## AI言語モデルへのアクセス

<br>

### 🤖 機能
- 業界をリードする大規模・小規模言語モデルへの直接アクセス
- 様々なAIモデルの試用と比較
- プロトタイピングと実験

### 🎯 用途
- モデルの選定
- APIの事前検証
- 性能比較

### ✅ 利用可能
全プラン（Pro, Pro+, Business, Enterprise）

---

# 7. Copilot Custom Instructions

## 応答のカスタマイズ

<br>

### ⚙️ 機能
- 個人の好みに基づく応答調整
- 使用ツール・フレームワークの指定
- プロジェクト固有の要件設定

### 📝 設定例
- コーディング規約の指定
- 優先言語/フレームワーク
- セキュリティ要件

### ✅ 利用可能
全プラン（Pro, Pro+, Business, Enterprise）

---

# 8. GitHub Copilot Extensions

## 外部ツールの統合

<br>

### 🔌 機能
- 外部ツールのCopilot Chatへの統合
- サードパーティサービスとの連携
- カスタム拡張の利用

### 🛠️ 対応ツール例
- Docker
- Azure
- データベース管理ツール

### ✅ 利用可能
全プラン（Pro, Pro+, Business, Enterprise）

---

# 9. Copilot in GitHub Desktop

## デスクトップアプリ統合

<br>

### 💻 機能
- コミットメッセージの自動生成
- 変更内容の要約
- Git操作の支援

### 🎯 メリット
- 一貫性のあるコミットメッセージ
- 時間の節約
- ベストプラクティスの適用

### ✅ 利用可能
全プラン（Pro, Pro+, Business, Enterprise）

---

# 10. Copilot Coding Agent

## 自動実装エージェント

<br>

### 🤖 機能
- GitHub IssueからPRまでの自動実装
- コードの自動生成と検証
- テストの作成と実行

### 🔄 ワークフロー
1. Issueの理解と分析
2. 実装計画の作成
3. コードの自動生成
4. PRの作成

### ⚠️ 利用制限
Pro+ 以上のプランで利用可能

---

# 11. Copilot Pull Request Summaries

## PR要約の自動生成

<br>

### 📝 機能
- PR変更内容の自動要約
- 影響範囲の分析
- レビュアー向けの説明生成

### 🎯 メリット
- レビュー時間の短縮
- 変更内容の明確化
- コミュニケーションの改善

### ⚠️ 利用制限
Pro+ 以上のプランで利用可能

---

# 12. Copilot Workspace

## 統合開発環境

<br>

### 🏗️ 機能
- IssueからPRまでの統合フロー
- コードの自動生成と検証
- レビューと改良の統合

### 🔄 ワークフロー
1. Issueの理解
2. 実装計画の生成
3. コードの自動実装
4. テストとレビュー

### ⚠️ 利用制限
Pro+ 以上のプランで利用可能

---

# 13. Copilot Spaces

## コンテンツ管理・共有

<br>

### 📁 機能
- 関連コンテンツの整理・集中化
- コンテキストの共有
- チーム間のナレッジ共有

### 🎯 用途
- プロジェクトドキュメントの管理
- コードスニペットの共有
- ベストプラクティスの蓄積

### ⚠️ 利用制限
Pro+ 以上のプランで利用可能

---

# 14. Copilot Text Completion

## テキスト補完支援

<br>

### ✍️ 機能
- PR説明文の迅速・正確な作成支援
- Issue説明の自動補完
- ドキュメントの作成支援

### 🎯 メリット
- 一貫性のある文書作成
- 時間の節約
- 品質の向上

### ⚠️ 利用制限
Enterprise プラン限定

---

# 15. Copilot Knowledge Bases

## 組織知識の統合

<br>

### 📚 機能
- 組織ドキュメントのコレクション作成・管理
- 内部ナレッジベースとの統合
- カスタムコンテキストの提供

### 🏢 用途
- 社内コーディング規約の適用
- ドメイン知識の活用
- プロジェクト固有情報の参照

### ⚠️ 利用制限
Enterprise プラン限定

---

# 管理者向け機能

## Business/Enterprise プラン

<br>

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

# 学習パスの提案

<br>

## 🎯 初級者向け
1. Code Completion の基本
2. Copilot Chat (Ask mode)
3. コミットメッセージ生成

## 🚀 中級者向け
1. Edit/Agent mode の活用
2. CLI 統合
3. カスタム指示の設定

## 💎 上級者向け
1. Workspace/Spaces の活用
2. Knowledge bases の構築
3. 組織全体での最適化

---

# 学習コンテンツの活用方法

<br>

## 📚 オンライン教材
https://agreeable-island-0c8e4d900.6.azurestaticapps.net/

### 🎯 学習のポイント
- 正直学習コンテンツとしての精度は微妙
- 発表資料のリポジトリーをクローンしてCopilot Chatで適宜質問・修正しながら実行するのがお勧め

### 📂 **発表資料**
発表資料を保管しているリポジトリーにプロンプトの例があるので参考にどうぞ。

🔗 https://github.com/nuitsjp/all-of-github-copilot

---

# 💡 学習コンテンツの作成のポイント

<br>

### 🚀 **効率的な教材作成フロー**

1. **📖 ソース活用**: 公式ドキュメントなどからプロンプトで学習教材を作成する
2. **🔗 直接参照**: `#fetch`で直接参照させる方法が楽
3. **💾 ローカル保管**: ただローカルにMarkdownで保管してからプロンプトかけたほうがコンテキスト長の圧迫が少なくてすみそう
   - <span class="highlight">Chrome拡張（Webpage to Markdownなど）の併用がお勧め</span>

<br>

### 📂 **発表資料**
発表資料を保管しているリポジトリーにプロンプトの例があるので参考にどうぞ。

🔗 https://github.com/nuitsjp/all-of-github-copilot

---

# まとめ

<br>

## 🎯 本日お伝えしたこと

### ✅ GitHub Copilotの全機能概要
- 14の主要機能
- プラン別の利用可能機能

### ✅ 効果的な学習方法
- 段階的アプローチ
- 実践的な練習

### ✅ 継続的な活用
- 学習コンテンツの活用
- チームでの展開

---

# 次のステップ

<br>

## 🚀 今すぐできること

1. **無料トライアルの開始**
   - 30日間の無料体験

2. **学習コンテンツへのアクセス**
   - デモコードのダウンロード
   - ハンズオンの実施

3. **コミュニティへの参加**
   - 質問・情報交換
   - ベストプラクティスの共有

---

# Q&A

<br>

## 🙋 ご質問をどうぞ！

<br>

### 📝 アンケートのお願い
- ハンズオン開催の希望調査
- 興味のある機能の確認
- フィードバック

<br>

### 📧 お問い合わせ
[連絡先情報]

---

# ありがとうございました！

<br>

## 🎉 GitHub Copilotで開発を加速しましょう！

<br>

### 📚 リソース
- 学習コンテンツ: https://agreeable-island-0c8e4d900.6.azurestaticapps.net/
- 公式ドキュメント: https://docs.github.com/copilot
- VS Code ドキュメント: https://code.visualstudio.com/docs/copilot/

<br>

### 🚀 Happy Coding with GitHub Copilot!
