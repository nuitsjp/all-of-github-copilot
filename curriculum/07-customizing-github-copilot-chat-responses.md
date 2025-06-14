# GitHub Copilot Chat レスポンスのカスタマイズ

## 概要

GitHub Copilot Chatは、チームの作業方法やプロジェクトの特性に合わせてカスタマイズできます。このチュートリアルでは、3つの主要なカスタマイズ方法を学習し、実際のシナリオで活用できるようになることを目指します。

## 学習目標

このチュートリアルを完了すると、以下のことができるようになります：

- リポジトリカスタム指示ファイルを作成し、プロジェクト全体のコーディング規約を適用する
- インストラクションファイルを使用して、特定のタスクやファイルタイプに対する指示を定義する
- プロンプトファイルを作成し、再利用可能なプロンプトテンプレートを管理する
- 各カスタマイズ方法の使い分けを理解する

## 前提条件

- Visual Studio Codeがインストールされていること
- GitHub Copilot拡張機能が有効になっていること
- Gitリポジトリの基本的な知識

## 1. リポジトリカスタム指示の設定

### 概要

リポジトリカスタム指示は、プロジェクト全体に適用される一般的なルールや規約を定義するためのシンプルな方法です。

### 実践演習：基本的なリポジトリカスタム指示の作成

1. **リポジトリに`.github`ディレクトリを作成**
   ```bash
   mkdir -p .github
   ```

2. **`copilot-instructions.md`ファイルを作成**
   ```bash
   touch .github/copilot-instructions.md
   ```

3. **基本的な指示を追加**
   ```markdown
   # プロジェクトのコーディング規約

   C#コードを生成する際は、以下の規約に従ってください：
   - インデントにはスペース4つを使用
   - 文字列補間を優先的に使用
   - メソッド名はPascalCaseで記述
   - プライベートフィールドは_camelCaseで記述
   - XMLドキュメントコメントを日本語で記述
   
   テストコードを生成する際は、xUnitフレームワークを使用してください。
   ```

4. **設定を有効化**
   - VS Codeで `Ctrl+,` (設定を開く)
   - `github.copilot.chat.codeGeneration.useInstructionFiles` を検索
   - チェックボックスをオンにする

5. **動作確認**
   - Copilot Chatを開いて「新しいメソッドを作成して」と入力
   - 生成されたコードが指示に従っているか確認

### チャレンジ課題

プロジェクトに合わせて、以下の指示を追加してみましょう：
- エラーハンドリングの方法（try-catch、カスタム例外）
- 命名規則（変数、定数、インターフェース、クラスなど）
- XMLドキュメントコメントの書き方

## 2. インストラクションファイルの活用

### 概要

インストラクションファイルは、より詳細で条件付きの指示を定義できる高度なカスタマイズ方法です。

### 実践演習：タイプ別インストラクションファイルの作成

1. **インストラクションフォルダを作成**
   ```bash
   mkdir -p .github/instructions
   ```

2. **C#用インストラクションファイルを作成**
   
   ファイル名：`.github/instructions/csharp.instructions.md`
   ```markdown
   ---
   applyTo: "**/*.cs"
   description: "C#とASP.NET Coreのコーディング規約"
   ---
   
   # C#コーディング標準
   
   ## 命名規則
   - インターフェースは'I'で始める（例：IRepository）
   - 抽象クラスは'Base'で終わる（例：ControllerBase）
   - 非同期メソッドは'Async'で終わる（例：GetDataAsync）
   
   ## ASP.NET Core
   - DIコンテナを活用する
   - コントローラーアクションは常にIActionResultを返す
   - [ApiController]属性を使用
   
   ## エラーハンドリング
   - グローバル例外ハンドラーを使用
   - カスタム例外クラスを作成
   - すべてのpublicメソッドで引数検証を実施
   ```

3. **新しいインストラクションファイルを作成**
   - VS Codeでコマンドパレット（`Ctrl+Shift+P`）を開く
   - `Chat: New Instructions File`を実行
   - 保存場所とファイル名を指定

4. **動作確認**
   - C#ファイルを開く
   - Copilot Chatで「このファイルに新しいメソッドを追加」と入力
   - 生成されたコードがC#用の指示に従っているか確認

### チャレンジ課題

以下のシナリオに対応するインストラクションファイルを作成してみましょう：
- Web APIコントローラー用（`**/Controllers/**/*.cs`）
- テストファイル用（`**/*.Tests.cs`）
- Entity Frameworkモデル用（`**/Models/**/*.cs`）

## 3. プロンプトファイルの作成と活用

### 概要

プロンプトファイルは、再利用可能なプロンプトテンプレートを作成し、チーム全体で共有できる強力な機能です。

### 実践演習：ASP.NET Core APIコントローラー生成プロンプト

1. **プロンプトフォルダを作成**
   ```bash
   mkdir -p .github/prompts
   ```

2. **APIコントローラー生成プロンプトを作成**
   
   ファイル名：`.github/prompts/aspnet-controller.prompt.md`
   ```markdown
   ---
   mode: 'agent'
   tools: ['codebase']
   description: 'ASP.NET Core APIコントローラーを生成'
   ---
   
   # ASP.NET Core APIコントローラーの生成
   
   以下の要件に従ってASP.NET Core APIコントローラーを作成してください：
   
   ## コントローラー名: ${input:controllerName:コントローラー名を入力してください（例：Product）}
   
   ## 必要なアクション:
   ${input:actions:必要なアクションをカンマ区切りで入力（例: GetAll,GetById,Create,Update,Delete）}
   
   ## 要件:
   - [ApiController]属性を使用
   - 適切なHTTP動詞属性を使用（HttpGet, HttpPost等）
   - DTOパターンを使用
   - 依存性注入でサービスを注入
   - 適切なHTTPステータスコードを返す
   - XMLドキュメントコメントを含める
   - 非同期メソッドとして実装
   
   ## 参照すべきカスタム指示:
   [C#規約](../instructions/csharp.instructions.md)
   ```

3. **プロンプトファイルの実行**
   - コマンドパレット（`Ctrl+Shift+P`）を開く
   - `Chat: Run Prompt`を実行
   - 作成したプロンプトファイルを選択
   - 必要な情報を入力

4. **Chat入力での直接実行**
   - Copilot Chatで `/aspnet-controller` と入力
   - 追加情報を指定：`/aspnet-controller: controllerName=Product`

### 実践演習：C#コードレビュー用プロンプト

ファイル名：`.github/prompts/csharp-review.prompt.md`
```markdown
---
mode: 'edit'
description: 'C#コードの品質とセキュリティレビュー'
---

# C#コードレビュー

選択されたコードに対して、以下の観点でレビューを実施してください：

## コード品質チェック項目:
- SOLID原則の遵守
- null参照の適切な処理
- 非同期処理の正しい実装
- メモリリークの可能性
- パフォーマンスの問題

## セキュリティチェック項目:
- SQLインジェクション対策
- 入力値検証の実装
- 認証・認可の適切な実装
- 機密情報の取り扱い

## レビュー結果の形式:
1. 発見された問題点をリスト化
2. 各問題の深刻度（高・中・低）を記載
3. 修正案を提示
4. .NETのベストプラクティスへの参照を含める

## 参照ファイル:
${file}
```

### チャレンジ課題

以下のプロンプトファイルを作成してみましょう：
- xUnit テスト生成プロンプト
- Entity Frameworkマイグレーション作成プロンプト
- XML ドキュメントコメント生成プロンプト

## 4. VS Code設定によるカスタマイズ

### 概要

VS Codeの設定を使用して、特定のタスクに対するカスタム指示を定義できます。

### 実践演習：設定ファイルでのカスタム指示

1. **ワークスペース設定を開く**
   - `.vscode/settings.json`を作成または開く

2. **各種タスク用の指示を追加**
   ```json
   {
     "github.copilot.chat.codeGeneration.instructions": [
       {
         "text": "生成されたコードには必ず「// AI生成」というコメントを追加し、すべてのpublicメソッドにXMLドキュメントコメントを含める"
       },
       {
         "file": "csharp-standards.instructions.md"
       }
     ],
     "github.copilot.chat.testGeneration.instructions": [
       {
         "text": "xUnitを使用し、テストメソッド名は「MethodName_Scenario_ExpectedResult」形式で記述"
       }
     ],
     "github.copilot.chat.commitMessageGeneration.instructions": [
       {
         "text": "コミットメッセージは日本語で記述し、[feat/fix/docs/style/refactor/test/chore]: 内容 の形式を使用"
       }
     ]
   }
   ```

3. **動作確認**
   - コード生成、テスト生成、コミットメッセージ生成を試す
   - それぞれの指示が適用されているか確認

## 5. 統合演習：C#プロジェクト全体のカスタマイズ

### シナリオ

新しいASP.NET Core Web APIプロジェクトのために、包括的なカスタマイズ設定を作成します。

### 手順

1. **プロジェクト構造の作成**
   ```
   my-csharp-api/
   ├── .github/
   │   ├── copilot-instructions.md
   │   ├── instructions/
   │   │   ├── controllers.instructions.md
   │   │   ├── services.instructions.md
   │   │   └── testing.instructions.md
   │   └── prompts/
   │       ├── create-controller.prompt.md
   │       ├── create-service.prompt.md
   │       └── create-test.prompt.md
   └── .vscode/
       └── settings.json
   ```

2. **各ファイルに適切な内容を追加**

3. **チーム開発のワークフロー**
   - 新しいAPIエンドポイント追加時：`/create-controller`プロンプトを使用
   - ビジネスロジック追加時：`/create-service`プロンプトを使用
   - テスト作成時：`/create-test`プロンプトを使用

## ベストプラクティス

1. **指示の書き方**
   - 短く明確な文章を使用
   - 矛盾する指示を避ける
   - 具体的な例を含める

2. **ファイルの整理**
   - 目的別にファイルを分割
   - 命名規則を統一
   - ドキュメントを充実させる

3. **チーム共有**
   - リポジトリにコミット
   - READMEに使用方法を記載
   - 定期的に見直しと更新

## トラブルシューティング

### よくある問題と解決方法

1. **カスタム指示が適用されない**
   - 設定が有効になっているか確認
   - ファイルパスが正しいか確認
   - VS Codeを再起動

2. **プロンプトファイルが見つからない**
   - `chat.promptFilesLocations`設定を確認
   - ファイルの拡張子が`.prompt.md`か確認

3. **インストラクションファイルが特定のファイルに適用されない**
   - `applyTo`のglob パターンを確認
   - ファイルパスがパターンにマッチするか確認

## まとめ

このチュートリアルでは、GitHub Copilot Chatの3つの主要なカスタマイズ方法を学習しました：

1. **リポジトリカスタム指示** - プロジェクト全体の基本ルール
2. **インストラクションファイル** - 条件付きの詳細な指示
3. **プロンプトファイル** - 再利用可能なタスクテンプレート

これらを組み合わせることで、チームの生産性を大幅に向上させることができます。

## 次のステップ

- カスタムチャットモードの作成方法を学ぶ
- より高度なプロンプトファイルのテクニックを探求
- チーム固有のベストプラクティスを確立

## 参考リソース

- [GitHub Copilot Chat カスタマイズドキュメント](https://docs.github.com/ja/copilot/customizing-copilot)
- [VS Code Copilot カスタマイズガイド](https://code.visualstudio.com/docs/copilot/copilot-customization)
