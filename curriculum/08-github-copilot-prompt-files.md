# GitHub Copilot プロンプトファイルの作成と活用

## 概要

プロンプトファイルは、再利用可能なプロンプトテンプレートを作成し、チーム全体で共有できる強力な機能です。このチュートリアルでは、プロンプトファイルの作成から活用まで、実践的なシナリオを通じて学習します。

## 学習目標

このチュートリアルを完了すると、以下のことができるようになります：

- プロンプトファイルの構造と記法を理解する
- 様々な種類のプロンプトファイルを作成する
- 変数とモードを効果的に活用する
- チーム開発でプロンプトファイルを共有・管理する

## 前提条件

- Visual Studio Codeがインストールされていること
- GitHub Copilot拡張機能が有効になっていること
- C#の基本的な知識

## プロンプトファイルとは

プロンプトファイルは、`.prompt.md`拡張子を持つMarkdownファイルで、再利用可能なプロンプトテンプレートを定義します。ファイルは以下の構造を持ちます：

```markdown
---
mode: 'agent' | 'edit' | 'insert'
tools: ['codebase', 'workspace', ...] # オプション
description: 'プロンプトの説明'
---

# プロンプトの内容
${変数}を使用して動的な要素を含めることができます
```

## 実践演習：ASP.NET Core APIコントローラー生成プロンプト

### ステップ1：プロンプトフォルダの準備

```bash
mkdir -p .github/prompts
```

### ステップ2：APIコントローラー生成プロンプトの作成

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
プロジェクトのC#コーディング規約に従ってください。
```

### ステップ3：プロンプトファイルの実行方法

1. **コマンドパレットから実行**
   - `Ctrl+Shift+P`でコマンドパレットを開く
   - `Chat: Run Prompt`を実行
   - 作成したプロンプトファイルを選択
   - 必要な情報を入力

2. **Chat入力での直接実行**
   - Copilot Chatで `/aspnet-controller` と入力
   - 追加情報を指定：`/aspnet-controller: controllerName=Product`

## 高度なプロンプトファイルの作成

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

### 実践演習：xUnitテスト生成プロンプト

ファイル名：`.github/prompts/xunit-test.prompt.md`

```markdown
---
mode: 'agent'
tools: ['codebase']
description: 'xUnitを使用したC#単体テストの生成'
---

# xUnit単体テストの生成

## 対象クラス: ${input:className:テスト対象のクラス名を入力}
## テストタイプ: ${input:testType:通常テスト|Theory（パラメータテスト）|例外テスト}

以下の要件でxUnitテストを生成してください：

### 基本要件:
- xUnitとShouldlyを使用
- Arrange-Act-Assertパターンに従う
- テストメソッド名は日本語で記述
- 各テストは独立して実行可能

### テストケース:
- 正常系のテスト
- 境界値のテスト
- 異常系のテスト（該当する場合）
- nullや空の値のテスト

### 特別な指示:
${input:specialInstructions:追加の指示がある場合は入力（オプション）}

## 例:
```csharp
[Theory]
[InlineData(1, 2, 3)]
[InlineData(-1, 1, 0)]
public void 加算が正しく動作すること(int a, int b, int expected)
{
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Add(a, b);
    
    // Assert
    result.ShouldBe(expected);
}
```
```

## 変数とプレースホルダー

プロンプトファイルでは、以下の変数を使用できます：

### 入力変数
```markdown
${input:variableName:プロンプト}
${input:variableName:プロンプト:デフォルト値}
```

### システム変数
```markdown
${file}              # 現在開いているファイル
${selection}         # 選択されたテキスト
${workspaceFolder}   # ワークスペースフォルダのパス
${fileDirname}       # 現在のファイルのディレクトリ
${fileBasename}      # 現在のファイル名（拡張子付き）
${fileBasenameNoExtension}  # 現在のファイル名（拡張子なし）
```

これらの変数は、Visual Studio Codeの**Variables Reference**機能の一部です。詳細は[公式ドキュメント](https://code.visualstudio.com/docs/editor/variables-reference)を参照してください。

## モードの詳細

### agent モード
- 新しいコードやドキュメントの生成
- 複雑な質問への回答
- ツールを使用した分析

### edit モード
- 既存のコードの修正
- リファクタリング
- コードレビュー

### insert モード
- 特定の位置へのコード挿入
- コメントの追加
- インポート文の追加

## プロンプトファイルの管理

### ディレクトリ構造の推奨例

```
.github/prompts/
├── code-generation/
│   ├── aspnet-controller.prompt.md
│   ├── entity-model.prompt.md
│   └── repository-pattern.prompt.md
├── testing/
│   ├── xunit-test.prompt.md
│   ├── integration-test.prompt.md
│   └── mock-setup.prompt.md
├── review/
│   ├── csharp-review.prompt.md
│   ├── security-review.prompt.md
│   └── performance-review.prompt.md
└── documentation/
    ├── xml-comments.prompt.md
    └── readme-update.prompt.md
```

### VS Code設定での管理

`.vscode/settings.json`でプロンプトファイルの場所を指定：

```json
{
  "github.copilot.chat.promptFilesLocations": [
    ".github/prompts/**/*.prompt.md",
    "prompts/**/*.prompt.md"
  ]
}
```

## チーム開発でのベストプラクティス

### 1. 命名規則の統一
- 用途が明確にわかる名前を使用
- ケバブケース（kebab-case）を推奨
- 例：`create-api-controller.prompt.md`

### 2. ドキュメントの充実
各プロンプトファイルに以下を含める：
- 使用目的の説明
- 必要な前提条件
- 使用例
- 期待される出力

### 3. バージョン管理
- Gitでプロンプトファイルを管理
- 変更履歴を記録
- プルリクエストでレビュー

### 4. テンプレートの標準化

プロンプトファイルのテンプレート例：

```markdown
---
mode: 'agent'
tools: ['codebase']
description: '簡潔な説明'
---

# タイトル

## 概要
このプロンプトの目的と使用場面を説明

## 入力
${input:param1:パラメータ1の説明}
${input:param2:パラメータ2の説明}

## 要件
- 要件1
- 要件2
- 要件3

## 出力形式
期待される出力の形式を説明

## 例
具体的な使用例や出力例
```

## トラブルシューティング

### よくある問題と解決方法

1. **プロンプトファイルが認識されない**
   - ファイルの拡張子が`.prompt.md`であることを確認
   - VS Codeの設定で`promptFilesLocations`を確認
   - VS Codeを再起動

2. **変数が置換されない**
   - 変数の構文が正しいか確認
   - 入力変数の場合、プロンプトが表示されるか確認
   - システム変数の場合、適切なコンテキストで実行しているか確認

3. **期待した出力が得られない**
   - モードが適切か確認
   - 必要なツールが指定されているか確認
   - プロンプトの指示が明確か確認

## 演習課題

### 課題1：Entity Frameworkモデル生成プロンプト
以下の要件でプロンプトファイルを作成してください：
- テーブル名とプロパティを入力として受け取る
- Data Annotationsを含める
- ナビゲーションプロパティの生成をサポート

### 課題2：API統合テスト生成プロンプト
以下の要件でプロンプトファイルを作成してください：
- WebApplicationFactoryを使用
- 認証のテストを含める
- レスポンスの検証を実装

### 課題3：カスタムプロンプトライブラリの構築
チーム用のプロンプトファイルライブラリを作成し、READMEで使用方法を文書化してください。

## まとめ

プロンプトファイルは、繰り返し行うタスクを効率化し、チーム全体の生産性を向上させる強力なツールです。以下のポイントを押さえて活用しましょう：

- 適切なモードとツールを選択する
- 変数を活用して柔軟性を高める
- チームで共有し、継続的に改善する
- ドキュメントを充実させる

## 次のステップ

- より高度な変数の活用方法を学ぶ
- カスタムツールの作成を検討する
- 組織全体でのプロンプトファイル管理戦略を策定する

## 参考リソース

- [GitHub Copilot Chat ドキュメント](https://docs.github.com/ja/copilot/using-github-copilot/using-github-copilot-chat-in-your-ide)
- [VS Code Variables Reference](https://code.visualstudio.com/docs/editor/variables-reference)
- [プロンプトエンジニアリングガイド](https://docs.github.com/ja/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
