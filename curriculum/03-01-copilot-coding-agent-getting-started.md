# Copilot コーディング エージェント入門

## 概要

Copilot コーディング エージェントは、GitHub上で自律的に動作し、開発タスクを完了できるAIエージェントです。人間の開発者と同じように、issueを割り当てられ、コードを修正し、Pull Requestを作成してレビューを依頼します。

## 学習目標

このセッションを完了すると、以下のことができるようになります：

- Copilot コーディング エージェントの機能と制限を理解する
- 組織や個人リポジトリでコーディング エージェントを有効化する
- コーディング エージェントに適したタスクを選択する

## 前提条件

- GitHub Copilot Pro+ または GitHub Copilot Enterprise のサブスクリプション
- リポジトリへの書き込みアクセス権限

## シナリオ：電卓アプリケーションのセットアップ

新しい電卓アプリケーションプロジェクトで、Copilot コーディング エージェントを有効化し、最初のタスクを割り当てます。

### ステップ 1: リポジトリの準備

1. GitHubで新しいリポジトリ `calculator-app` を作成
2. 基本的な.NET プロジェクト構造を作成：

```csharp
// Program.cs
namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("電卓アプリケーション");
        }
    }
}
```

### ステップ 2: コーディング エージェントの有効化

#### 個人リポジトリの場合：

1. GitHubの設定画面へ移動
2. 左メニューから「Copilot」を選択
3. 「ポリシー」セクションで「Copilot コーディング エージェント」を有効化

#### 組織リポジトリの場合：

1. 組織の設定画面へ移動
2. 「Copilot」→「ポリシー」を選択
3. 「Copilot コーディング エージェント」を有効化
4. 対象リポジトリを選択

### ステップ 3: カスタム指示の追加

リポジトリに `.github/copilot-instructions.md` ファイルを作成：

```markdown
# Calculator App 開発ガイドライン

このプロジェクトはC#電卓アプリケーションです。以下のガイドラインに従ってください：

## コーディング規約
- C# 命名規則を厳守（PascalCase for public、camelCase for private）
- すべてのpublicメソッドにXMLドキュメントコメントを追加
- 引数検証を必ず実装

## ビルドとテスト
- ビルド: `dotnet build`
- テスト: `dotnet test`
- フォーマット: `dotnet format`

## テスト要件
- xUnitを使用
- Arrange-Act-Assertパターンに従う
- テストメソッド名は日本語で記述
```

### ステップ 4: 最初のissueを作成

以下の内容でissueを作成：

```markdown
タイトル: 基本的な計算機能を実装する

## 説明
電卓アプリケーションに基本的な四則演算機能を実装してください。

## 要件
1. Calculatorクラスを作成
2. 以下のメソッドを実装：
   - Add(double a, double b)
   - Subtract(double a, double b)
   - Multiply(double a, double b)
   - Divide(double a, double b)

## 受け入れ条件
- すべてのメソッドにXMLドキュメントコメントがある
- ゼロ除算のエラーハンドリングが実装されている
- 各メソッドに対する単体テストが存在する
- テストカバレッジが100%である
```

### ステップ 5: Copilotにissueを割り当てる

1. 作成したissueを開く
2. 右サイドバーの「Assignees」をクリック
3. リストから「Copilot」を選択

### ステップ 6: 進行状況の監視

1. Copilotが👀の反応を追加するのを確認
2. 数秒後、下書きPull Requestが作成される
3. 「View session」をクリックしてログを確認

## 理解度チェック

以下の質問に答えてください：

1. Copilot コーディング エージェントを使用するために必要な権限は何ですか？
2. カスタム指示ファイルはどこに配置しますか？
3. Copilotがプッシュできないブランチは何ですか？

## 次のステップ

- [基本的な使い方](./03-02-using-copilot-coding-agent.md)へ進む
- より複雑なタスクの割り当て方法を学ぶ
