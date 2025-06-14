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

   JavaScriptコードを生成する際は、以下の規約に従ってください：
   - インデントにはタブを使用
   - 文字列にはダブルクォートを使用
   - 関数名はcamelCaseで記述
   - コメントは日本語で記述
   
   テストコードを生成する際は、Jestフレームワークを使用してください。
   ```

4. **設定を有効化**
   - VS Codeで `Ctrl+,` (設定を開く)
   - `github.copilot.chat.codeGeneration.useInstructionFiles` を検索
   - チェックボックスをオンにする

5. **動作確認**
   - Copilot Chatを開いて「新しい関数を作成して」と入力
   - 生成されたコードが指示に従っているか確認

### チャレンジ課題

プロジェクトに合わせて、以下の指示を追加してみましょう：
- エラーハンドリングの方法
- 命名規則（変数、定数、クラスなど）
- コメントの書き方

## 2. インストラクションファイルの活用

### 概要

インストラクションファイルは、より詳細で条件付きの指示を定義できる高度なカスタマイズ方法です。

### 実践演習：タイプ別インストラクションファイルの作成

1. **インストラクションフォルダを作成**
   ```bash
   mkdir -p .github/instructions
   ```

2. **TypeScript用インストラクションファイルを作成**
   
   ファイル名：`.github/instructions/typescript.instructions.md`
   ```markdown
   ---
   applyTo: "**/*.ts,**/*.tsx"
   description: "TypeScriptとReactのコーディング規約"
   ---
   
   # TypeScriptコーディング標準
   
   ## 型定義
   - インターフェースを優先的に使用
   - 型エイリアスは共用体型や交差型に限定
   - any型の使用は禁止
   
   ## React コンポーネント
   - 関数コンポーネントとHooksを使用
   - PropsはインターフェースとしてExportする
   - コンポーネント名はPascalCase
   
   ## エラーハンドリング
   - try-catchブロックで適切にエラーを処理
   - カスタムエラークラスを使用
   ```

3. **新しいインストラクションファイルを作成**
   - VS Codeでコマンドパレット（`Ctrl+Shift+P`）を開く
   - `Chat: New Instructions File`を実行
   - 保存場所とファイル名を指定

4. **動作確認**
   - TypeScriptファイルを開く
   - Copilot Chatで「このファイルに新しい関数を追加」と入力
   - 生成されたコードがTypeScript用の指示に従っているか確認

### チャレンジ課題

以下のシナリオに対応するインストラクションファイルを作成してみましょう：
- APIエンドポイント用（`**/api/**/*.js`）
- テストファイル用（`**/*.test.js`）
- 設定ファイル用（`**/*.config.js`）

## 3. プロンプトファイルの作成と活用

### 概要

プロンプトファイルは、再利用可能なプロンプトテンプレートを作成し、チーム全体で共有できる強力な機能です。

### 実践演習：Reactフォームコンポーネント生成プロンプト

1. **プロンプトフォルダを作成**
   ```bash
   mkdir -p .github/prompts
   ```

2. **Reactフォーム生成プロンプトを作成**
   
   ファイル名：`.github/prompts/react-form.prompt.md`
   ```markdown
   ---
   mode: 'agent'
   tools: ['codebase']
   description: 'Reactフォームコンポーネントを生成'
   ---
   
   # Reactフォームコンポーネントの生成
   
   以下の要件に従ってReactフォームコンポーネントを作成してください：
   
   ## フォーム名: ${input:formName:フォーム名を入力してください}
   
   ## 必要なフィールド:
   ${input:fields:必要なフィールドをカンマ区切りで入力（例: name,email,age）}
   
   ## 要件:
   - React Hook Formを使用
   - TypeScriptで型定義を作成
   - バリデーション付き
   - Material-UIのコンポーネントを使用
   - エラーメッセージの表示
   - 送信ボタンとリセットボタンを含む
   
   ## 参照すべきカスタム指示:
   [TypeScript規約](../instructions/typescript.instructions.md)
   ```

3. **プロンプトファイルの実行**
   - コマンドパレット（`Ctrl+Shift+P`）を開く
   - `Chat: Run Prompt`を実行
   - 作成したプロンプトファイルを選択
   - 必要な情報を入力

4. **Chat入力での直接実行**
   - Copilot Chatで `/react-form` と入力
   - 追加情報を指定：`/react-form: formName=UserRegistration`

### 実践演習：コードレビュー用プロンプト

ファイル名：`.github/prompts/code-review.prompt.md`
```markdown
---
mode: 'edit'
description: 'セキュリティ重視のコードレビュー'
---

# セキュリティ重視のコードレビュー

選択されたコードに対して、以下の観点でレビューを実施してください：

## セキュリティチェック項目:
- SQLインジェクション対策
- XSS（クロスサイトスクリプティング）対策
- 認証・認可の実装
- 機密情報の取り扱い
- 入力値検証

## レビュー結果の形式:
1. 発見された問題点をリスト化
2. 各問題の深刻度（高・中・低）を記載
3. 修正案を提示
4. ベストプラクティスへの参照を含める

## 参照ファイル:
${file}
```

### チャレンジ課題

以下のプロンプトファイルを作成してみましょう：
- API テスト生成プロンプト
- データベースマイグレーション作成プロンプト
- ドキュメント生成プロンプト

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
         "text": "生成されたコードには必ず「// AI生成」というコメントを追加"
       },
       {
         "file": "coding-standards.instructions.md"
       }
     ],
     "github.copilot.chat.testGeneration.instructions": [
       {
         "text": "テストケース名は日本語で記述し、describe-it形式を使用"
       }
     ],
     "github.copilot.chat.commitMessageGeneration.instructions": [
       {
         "text": "コミットメッセージは日本語で記述し、[種別]: 内容 の形式を使用"
       }
     ]
   }
   ```

3. **動作確認**
   - コード生成、テスト生成、コミットメッセージ生成を試す
   - それぞれの指示が適用されているか確認

## 5. 統合演習：プロジェクト全体のカスタマイズ

### シナリオ

新しいWebアプリケーションプロジェクトのために、包括的なカスタマイズ設定を作成します。

### 手順

1. **プロジェクト構造の作成**
   ```
   my-webapp/
   ├── .github/
   │   ├── copilot-instructions.md
   │   ├── instructions/
   │   │   ├── frontend.instructions.md
   │   │   ├── backend.instructions.md
   │   │   └── testing.instructions.md
   │   └── prompts/
   │       ├── create-component.prompt.md
   │       ├── create-api-endpoint.prompt.md
   │       └── security-review.prompt.md
   └── .vscode/
       └── settings.json
   ```

2. **各ファイルに適切な内容を追加**

3. **チーム開発のワークフロー**
   - 新機能開発時：`/create-component`プロンプトを使用
   - APIエンドポイント追加時：`/create-api-endpoint`プロンプトを使用
   - コードレビュー時：`/security-review`プロンプトを使用

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
