# GitHub Copilotのすべて

## 発表概要
- タイトル: GitHub Copilotのすべて
- 時間: 50分
- 対象: ITエンジニア（レベル感は雑多）
- 形式: オンラインカンファレンス

## 発表の目的
- GitHub Copilotの全機能を網羅的に紹介
- 各機能の概要をデモで分かりやすく示す
- 導入を検討している人に判断材料を提供

## 発表で重視するポイント

### 1. 正確性と最新性
- 2025年6月時点の最新情報に基づく
- 研究資料を基にした正確な機能説明
- プラン・価格の正確な比較

### 2. 分かりやすいデモ
- VS Code + C#での簡潔なデモ
- 各機能がどういうものかが伝わる内容
- 深い実装より機能の理解を優先

### 3. レベル感の異なる聴衆への配慮
- 初心者にも分かりやすい説明
- 上級者にも価値のある詳細情報
- 段階的な説明（基本→応用）

### 4. 網羅性重視の構成
- 全機能をカバーすることを最優先
- 各機能は概要レベルで説明
- 時間配分を厳密に管理

### 5. 導入判断に役立つ情報
- 各プランの特徴と適用シーン
- コスト（プレミアムリクエストの仕組み）
- セキュリティ・コンプライアンス面
- **企業内でのBusinessとEnterpriseの使い分け**
  - 同一リポジトリで人によって異なるライセンスの適用が可能
  - ライセンスの優先順位（Enterprise > Business > Pro+）
  - 推奨される組織構成（Copilot割当用Organization分離）
  - [参考](/research/2025-06-05-github-copilot-license.md)
- **主要競合製品との簡単な比較**
  - Cursor、Windsurf、Claude Code等との機能・価格比較
  - 各ツールの特徴と適用シーン
  - GitHub Copilotの位置づけと強み
  - [参考](/research/Copilot最新情報と競合ツール比較_.md)

## デモ環境
- VS Code + C#
- GitHub Copilot Pro/Business（Pro+、Enterprise固有機能も説明）
- 各機能の動作が分かる簡潔なデモ

## 準備するもの
- Marpスライド
- デモ用のサンプルコード（シンプルなもの）
- 機能一覧

## 学習プラン

発表前の準備として、GitHub Copilotの全機能を体系的に学習・検証します。

### 学習方針
- 1機能につき10-30分で完了する実践的な内容
- VS Code + C#環境での実際の動作確認
- 各機能の特徴・使用感・制限事項を記録
- デモで使用するサンプルコードの準備

### 学習スケジュール
機能一覧に基づき、以下の順序で学習を進めます：

1. **基本機能（Pro対応）** - 約3時間
   - Code completion
   - Copilot Chat
   - Copilot in the CLI
   - GitHub Copilot Extensions
   - GitHub Models
   - Copilot Edits
   - Copilot custom instructions
   - Copilot in GitHub Desktop

2. **Pro+/Business/Enterprise機能** - 約4時間
   - Copilot coding agent
   - GitHub Copilot code review
   - Copilot pull request summaries
   - Copilot Workspace
   - Copilot text completion
   - Copilot Spaces
   - Copilot knowledge bases（Enterprise限定）

### 学習テキストの作成

[doc](doc/) フォルダー下の機能別の概略説明文書をもとに[functions](functions/)ディレクトリに学習マニュアルを作成してください。

docの下のファイルと同じ名前でfunctionsに学習マニュアルを作成してください。
