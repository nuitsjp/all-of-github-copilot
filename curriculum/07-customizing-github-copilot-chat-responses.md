# GitHub Copilot Chat レスポンスのカスタマイズ

## 概要

GitHub Copilot Chatは、チームの作業方法やプロジェクトの特性に合わせてカスタマイズできます。このチュートリアルでは、2つの主要なカスタマイズ方法を学習し、実際のシナリオで活用できるようになることを目指します。

## 学習目標

このチュートリアルを完了すると、以下のことができるようになります：

- リポジトリカスタム指示ファイルを作成し、プロジェクト全体のコーディング規約を適用する
- インストラクションファイルを使用して、特定のタスクやファイルタイプに対する指示を定義する
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

## 3. VS Code設定によるカスタマイズ

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

## 4. 統合演習：C#プロジェクト全体のカスタマイズ

### シナリオ

新しいASP.NET Core Web APIプロジェクトのために、包括的なカスタマイズ設定を作成します。

### 手順

1. **プロジェクト構造の作成**
   ```
   my-csharp-api/
   ├── .github/
   │   ├── copilot-instructions.md
   │   └── instructions/
   │       ├── controllers.instructions.md
   │       ├── services.instructions.md
   │       └── testing.instructions.md
   └── .vscode/
       └── settings.json
   ```

2. **各ファイルに適切な内容を追加**

3. **チーム開発のワークフロー**
   - 新しいAPIエンドポイント追加時：適切なインストラクションファイルが自動適用
   - ビジネスロジック追加時：サービス層の規約に従った実装
   - テスト作成時：テスト用の指示に基づいた単体テスト生成

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

2. **インストラクションファイルが特定のファイルに適用されない**
   - `applyTo`のglob パターンを確認
   - ファイルパスがパターンにマッチするか確認

## まとめ

このチュートリアルでは、GitHub Copilot Chatの2つの主要なカスタマイズ方法を学習しました：

1. **リポジトリカスタム指示** - プロジェクト全体の基本ルール
2. **インストラクションファイル** - 条件付きの詳細な指示

これらを組み合わせることで、チームの生産性を大幅に向上させることができます。プロンプトファイルの詳細については、次のチュートリアルで学習します。

## 次のステップ

- プロンプトファイルの作成方法を学ぶ
- カスタムチャットモードの作成方法を探求
- チーム固有のベストプラクティスを確立

## 参考リソース

- [GitHub Copilot Chat カスタマイズドキュメント](https://docs.github.com/ja/copilot/customizing-copilot)
- [VS Code Copilot カスタマイズガイド](https://code.visualstudio.com/docs/copilot/copilot-customization)
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
