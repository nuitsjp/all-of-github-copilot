# GitHub Copilot Chat レスポンスのカスタマイズ

## 概要

GitHub Copilot Chatは、コーディング規約やプロジェクト要件に合わせたレスポンスを生成できます。毎回のチャットプロンプトに同じ情報を繰り返し入力する代わりに、カスタム指示やプロンプトファイルを使用して、自動的にコンテキストを含めることができます。

## 学習目標

このチュートリアルでは、以下の3つのカスタマイズ方法を実践的に学習します：

1. **カスタム指示（Custom Instructions）** - コード生成の共通ガイドラインを定義
2. **プロンプトファイル（Prompt Files）** - 再利用可能なプロンプトを作成
3. **カスタムチャットモード（Custom Chat Modes）** - チャットの動作方法を定義

## シナリオ：React TypeScriptプロジェクトの開発環境構築

新しいReact TypeScriptプロジェクトで、チーム全体で統一されたコーディング規約とツールを使用したいとします。

### ステップ1：リポジトリカスタム指示の作成

まず、プロジェクト全体に適用される基本的なコーディング規約を定義します。

1. プロジェクトのルートディレクトリに `.github` フォルダーを作成します
2. `.github/copilot-instructions.md` ファイルを作成します
3. 以下の内容を追加します：

```markdown
# プロジェクトコーディング規約

## TypeScript/React開発規約
- TypeScriptを全ての新規コードで使用
- Reactコンポーネントは関数コンポーネント + Hooksを使用
- 型定義にはinterfaceを優先的に使用
- プライベートクラスメンバーにはアンダースコア(_)をプレフィックスとして使用

## 命名規則
- コンポーネント名、インターフェース、型エイリアス: PascalCase
- 変数、関数、メソッド: camelCase  
- 定数: ALL_CAPS

## エラーハンドリング
- 非同期操作にはtry/catchブロックを使用
- Reactコンポーネントには適切なエラーバウンダリを実装
- エラーログには必ずコンテキスト情報を含める

## 使用ツール
- フォームステート管理: react-hook-form
- バリデーション: yup
- スタイリング: CSS Modules
- テストフレームワーク: Jest + React Testing Library
```

### ステップ2：タスク別のインストラクションファイル作成

特定のタスクに対する詳細な指示を別ファイルで管理します。

1. `.github/instructions` フォルダーを作成します
2. `typescript-react.instructions.md` ファイルを作成します：

```markdown
---
applyTo: "**/*.ts,**/*.tsx"
description: "TypeScriptとReact開発のための詳細なガイドライン"
---
# TypeScriptとReact開発ガイドライン

[一般的なコーディング規約](../copilot-instructions.md)を全てのコードに適用してください。

## TypeScript固有のガイドライン
- 関数型プログラミング原則を可能な限り適用
- イミュータブルなデータを優先（const、readonly）
- オプショナルチェイニング（?.）とnullish coalescing（??）演算子を使用
- 型推論が可能な場合は明示的な型定義を省略

## React固有のガイドライン  
- カスタムフックは`use`プレフィックスで始める
- コンポーネントは単一責任の原則に従い、小さく保つ
- propsの型定義は必須
- メモ化（React.memo、useMemo、useCallback）は適切に使用
```

### ステップ3：再利用可能なプロンプトファイルの作成

よく使うタスクのためのプロンプトファイルを作成します。

1. `.github/prompts` フォルダーを作成します
2. `create-react-form.prompt.md` ファイルを作成します：

```markdown
---
mode: 'agent'
tools: ['codebase']
description: 'React Hook Formを使用した新しいフォームコンポーネントを生成'
---
# React フォームコンポーネントの生成

新しいReactフォームコンポーネントを生成します。

## 要件
- フォーム名とフィールドを指定してください（未指定の場合は確認します）
- [typescript-react.instructions.md](../instructions/typescript-react.instructions.md)のガイドラインに従う
- react-hook-formを使用したフォーム管理
- yupを使用したバリデーション
- TypeScript型定義を必ず含める
- CSS Modulesでスタイリング

## 生成するファイル
1. `components/${input:componentName}/${input:componentName}.tsx` - コンポーネント本体
2. `components/${input:componentName}/${input:componentName}.module.css` - スタイル
3. `components/${input:componentName}/${input:componentName}.test.tsx` - テストファイル
4. `components/${input:componentName}/validation.ts` - バリデーションスキーマ
```

### ステップ4：コードレビュー用プロンプトファイルの作成

コードレビューを効率化するプロンプトファイルを作成します。

```markdown
---
mode: 'edit'
description: 'TypeScript/Reactコードの包括的なレビュー'
---
# コードレビューチェックリスト

選択されたコードについて以下の観点でレビューを実行してください：

## セキュリティ
- [ ] ユーザー入力の適切なサニタイゼーション
- [ ] XSS脆弱性のチェック
- [ ] 機密情報のハードコーディングなし

## パフォーマンス  
- [ ] 不要な再レンダリングの回避
- [ ] 適切なメモ化の使用
- [ ] 大きなリストでの仮想化検討

## コード品質
- [ ] プロジェクトのコーディング規約への準拠
- [ ] 適切なエラーハンドリング
- [ ] テストの存在と品質
- [ ] TypeScript型の適切な使用

改善提案と共に、具体的なコード例を提供してください。
```

### ステップ5：VS Code設定でのカスタム指示

VS Codeの設定ファイルで、特定のタスク用の指示を定義します。

1. プロジェクトの `.vscode/settings.json` を作成または編集します：

```json
{
  "github.copilot.chat.codeGeneration.useInstructionFiles": true,
  "github.copilot.chat.codeGeneration.instructions": [
    {
      "text": "常にTypeScriptの厳格モードを使用してください"
    },
    {
      "file": ".github/instructions/typescript-react.instructions.md"
    }
  ],
  "github.copilot.chat.testGeneration.instructions": [
    {
      "text": "JestとReact Testing Libraryを使用してテストを作成"
    },
    {
      "text": "データ属性（data-testid）を使用して要素を選択"
    }
  ],
  "github.copilot.chat.commitMessageGeneration.instructions": [
    {
      "text": "コミットメッセージは日本語で記述"
    },
    {
      "text": "形式: <type>: <description>"
    },
    {
      "text": "type: feat, fix, docs, style, refactor, test, chore"
    }
  ]
}
```

## 実践演習

### 演習1：フォームコンポーネントの生成

1. VS Codeでチャットビューを開きます
2. `/create-react-form` と入力します
3. フォーム名として「UserRegistration」を指定します
4. 必要なフィールド（name, email, password）を指定します
5. 生成されたコードがプロジェクトの規約に従っているか確認します

### 演習2：コードレビューの実行

1. 既存のReactコンポーネントを開きます
2. コードを選択します
3. チャットで `/code-review` プロンプトを実行します
4. 提案された改善点を確認し、適用します

### 演習3：カスタム指示の効果測定

1. カスタム指示なしでコードを生成してみます
2. カスタム指示を有効にして同じタスクを実行します
3. 生成されたコードの違いを比較します

## トラブルシューティング

### カスタム指示が適用されない場合

1. `github.copilot.chat.codeGeneration.useInstructionFiles` 設定が `true` になっているか確認
2. ファイルパスが正しいか確認（相対パスの基準点に注意）
3. Front Matterの構文が正しいか確認

### プロンプトファイルが見つからない場合

1. ファイル拡張子が `.prompt.md` になっているか確認
2. `chat.promptFilesLocations` 設定を確認
3. VS Codeを再起動してみる

## ベストプラクティス

1. **指示は短く具体的に** - 各指示は単一の明確なステートメントにする
2. **ファイルを分割** - トピックやタスクごとに指示を整理
3. **バージョン管理** - 指示ファイルもGitで管理し、変更履歴を追跡
4. **チームで共有** - プロジェクト全体で一貫性を保つ
5. **定期的な見直し** - プロジェクトの進化に合わせて指示を更新

## まとめ

GitHub Copilot Chatのカスタマイズ機能を使用することで：

- プロジェクト固有のコーディング規約を自動的に適用
- 繰り返しのタスクを効率化
- チーム全体で一貫したコード品質を維持
- 新しいメンバーのオンボーディングを簡素化

これらの機能を組み合わせることで、より生産的で一貫性のある開発環境を構築できます。
```
