---
marp: true
theme: default
paginate: true
header: 'GitHub Copilotのすべて'
footer: '2025年6月'
---

<!-- _paginate: false -->
<!-- _header: '' -->
<!-- _footer: '' -->

# GitHub Copilotのすべて

## AIペアプログラミングの現在と未来

---

# アジェンダ

1. **GitHub Copilotとは** - 基本概念とプラン
2. **セットアップ** - 始め方
3. **コード補完・生成** - 基本機能
4. **Copilot Chat** - 対話型AI支援
5. **高度な機能** - Workspace、CLI、Extensions
6. **エンタープライズ機能** - セキュリティと管理
7. **ベストプラクティス** - 効果的な使い方
8. **Q&A**

---

# GitHub Copilotとは

## AIがあなたのペアプログラマーに

- **OpenAI Codexベース**のAIコーディング支援ツール
- **コンテキスト理解**：開いているファイル、コメント、変数名
- **マルチプラットフォーム**：VS Code、Visual Studio、JetBrains、Neovim
- **自然言語→コード**：説明からコードを生成

---

# 対応環境

## IDE・エディタ
- Visual Studio Code ✅
- Visual Studio
- JetBrains IDE (IntelliJ, PyCharm, WebStorm等)
- Neovim

## その他のプラットフォーム
- GitHub.com
- GitHub Mobile
- GitHub CLI
- Windows Terminal

---

# プランと料金体系

| プラン | 月額 | 主な機能 |
|--------|------|----------|
| **Free** | $0 | 月2,000回の補完、50回のチャット |
| **Pro** | $10 | 無制限補完、300プレミアムリクエスト |
| **Pro+** | $39 | 全モデルアクセス、1,500プレミアムリクエスト |
| **Business** | $19/user | 組織管理、IP保護 |
| **Enterprise** | $39/user | ナレッジベース、高度な管理機能 |

※学生・教員は**Pro無料**

---

<!-- _header: 'デモ: セットアップ' -->

# VS Codeでのセットアップ

## 3ステップで開始

1. **拡張機能をインストール**
   - GitHub Copilot
   - GitHub Copilot Chat

2. **GitHubアカウントでサインイン**

3. **最初のコードを書いてみる**

> デモ：実際にインストールから最初の補完まで

---

<!-- _header: 'デモ: コード補完・生成' -->

# コード補完の基本

## C#でPersonクラスを作成

```csharp
// Personクラスを作成（名前、年齢、メールアドレス）
public class Person
{
    // Copilotが提案するコード
}
```

### 機能
- **インライン補完**（Tab/Escで承認/却下）
- **複数の提案**（Alt+]で切り替え）
- **コメントからの生成**

---

# Next Edit Suggestions (NES)

## 次の編集を予測

- 変数追加後の自動リファクタリング
- ロジカルな変更の提案
- コンテキストに基づく最適化

```csharp
// 例：新しいプロパティ追加後、
// 関連メソッドも自動的に更新を提案
```

---

<!-- _header: 'デモ: Copilot Chat' -->

# Copilot Chat

## 対話型のAI支援

### 3つのモード
1. **Ask Mode** - 質問と説明
2. **Edit Mode** - コードの編集と生成
3. **Agent Mode** - 自律的なタスク実行

### ショートカット
- `Ctrl+I` - インラインチャット
- `Ctrl+Alt+I` - チャットビュー

---

# スラッシュコマンド

## よく使うコマンド

- `/explain` - コードの説明
- `/tests` - テスト生成
- `/fix` - エラー修正
- `/doc` - ドキュメント生成
- `/optimize` - 最適化提案

## コンテキスト変数
- `#selection` - 選択中のコード
- `#file` - 特定のファイル
- `#codebase` - プロジェクト全体

---

<!-- _header: 'デモ: テスト生成' -->

# 自動テスト生成

## Personクラスのユニットテスト

```csharp
// Copilot Chatで「/tests」コマンドを使用
// xUnitでのテストを自動生成
```

### 生成されるテスト
- 正常系テスト
- 異常系テスト
- エッジケース
- モックの活用

---

# Copilot Workspace

## IssueからPull Requestまで

1. **GitHub Issueから開始**
2. **タスクの計画を生成**
3. **実装コードの提案**
4. **テストと検証**
5. **Pull Request作成**

> プレビュー機能（2025年6月時点）

---

# Copilot CLI

## コマンドラインでのAI支援

```bash
# コマンドの提案
gh copilot suggest "全ての.csファイルを検索"

# コマンドの説明
gh copilot explain "dotnet test --logger"

# エイリアス設定も可能
```

---

# Copilot Extensions

## エコシステムの拡張

- **Docker** - コンテナ操作支援
- **Sentry** - エラー分析
- **Azure** - クラウドリソース管理
- **カスタム拡張** - 独自ツールの統合

### Model Context Protocol (MCP)
外部データソースとの標準化された連携

---

# エンタープライズ機能

## Business/Enterprise限定

### セキュリティ・コンプライアンス
- **IP保護**（パブリックコードフィルター）
- **ゼロデータリテンション**
- **監査ログ**
- **コンテンツ除外設定**

### 管理機能
- **集中ポリシー管理**
- **利用状況分析**
- **ライセンス管理**

---

# ナレッジベース（Enterprise）

## 組織の知識をAIに

- Markdownドキュメントから構築
- 複数リポジトリ対応
- Copilot Chatで参照可能
- 組織固有の回答生成

```markdown
例：社内コーディング規約、
    APIドキュメント、
    アーキテクチャ設計書
```

---

# 効果的な使い方

## プロンプトエンジニアリング

### ❌ 悪い例
```
"関数を書いて"
```

### ✅ 良い例
```
"整数のリストを受け取り、偶数の合計を返すC#メソッドを書いてください。
LINQを使用し、nullチェックも含めてください。"
```

---

# コンテキストの活用

## より良い提案のために

1. **関連ファイルを開く**
2. **明確な変数名・関数名**
3. **コメントで意図を説明**
4. **#codebase変数の活用**

### カスタムインストラクション
```
.github/copilot-instructions.md
```

---

# 注意点と制限事項

## 責任ある利用

### ⚠️ 注意すべき点
- 生成コードは**必ずレビュー**
- セキュリティ脆弱性の可能性
- ライセンスへの配慮
- 過度な依存は避ける

### 制限事項
- コンテキストウィンドウのサイズ
- 最新ライブラリの知識
- 複雑なビジネスロジックの理解

---

# 生産性への影響

## 実証されたメリット

- **最大55%** の開発速度向上
- **94%** がフロー状態を維持しやすい
- **90%** が情報検索時間を短縮
- **88%** の提案が採用される

※GitHub/Accentureの調査による

---

# 今後のロードマップ

## AIネイティブな開発へ

### 2025年の方向性
- より高度な**自律エージェント**
- **マルチモーダルAI**（画像理解）
- 深い**IDE統合**
- **パーソナライゼーション**強化

### 開発者の役割の変化
- コード記述 → **AI監督・検証**
- 単純作業 → **創造的問題解決**

---

# リソース

## 詳しく学ぶには

- **公式ドキュメント**: docs.github.com/copilot
- **GitHub Blog**: github.blog
- **VS Code Docs**: code.visualstudio.com/docs/copilot
- **無料トライアル**: 30日間（Pro）

### コミュニティ
- GitHub Discussions
- Reddit: r/GithubCopilot
- Twitter: #GitHubCopilot

---

<!-- _paginate: false -->
<!-- _class: lead -->

# Q&A

## ご質問をお待ちしています

### 連絡先
- GitHub: @your-username
- Twitter: @your-handle
- Email: your-email@example.com

---

<!-- _paginate: false -->

# ありがとうございました！

## Happy Coding with AI! 🚀

### アンケートのお願い
発表の改善のため、ぜひアンケートにご協力ください。

[アンケートリンク]
