# Copilot コーディング エージェントの使い方

## 概要

このセッションでは、Copilot コーディング エージェントを使用して実際の開発タスクを完了する方法を学びます。issueの割り当てとCopilot Chatを使用したPull Request作成の両方を体験します。

## 学習目標

- issueをCopilotに割り当てる複数の方法を習得する
- Copilot Chatを使用してPull Requestを作成する
- セッションログを使用して進行状況を監視する
- Copilotの作業を必要に応じて停止する

## シナリオ：電卓アプリケーションの機能拡張

前回作成した電卓アプリケーションに、高度な計算機能を追加します。

### パート1: issueの割り当て

#### ステップ 1: 新しいissueを作成

```markdown
タイトル: 科学計算機能を追加する

## 説明
電卓アプリケーションに科学計算機能を追加してください。

## 要件
1. ScientificCalculatorクラスを作成（Calculatorクラスを継承）
2. 以下のメソッドを実装：
   - Power(double baseNum, double exponent) - べき乗
   - SquareRoot(double value) - 平方根
   - Logarithm(double value, double baseNum) - 対数

## 技術要件
- すべてのメソッドにXMLドキュメントコメント
- 負の数の平方根などの無効な入力に対するエラーハンドリング
- 各メソッドに対する包括的な単体テスト
- Theoryを使用したパラメトリックテスト

## ファイル構造
- src/ScientificCalculator.cs に実装
- tests/ScientificCalculatorTests.cs にテストを作成
```

#### ステップ 2: 複数の方法でissueを割り当てる

**方法1: GitHub.comで直接割り当て**
1. issueページで「Assignees」をクリック
2. 「Copilot」を選択

**方法2: GitHub CLIを使用**
```bash
gh issue edit <issue-number> --add-assignee copilot-swe-agent
```

**方法3: GitHub APIを使用**
```csharp
// C# サンプルコード
using Octokit;

var client = new GitHubClient(new ProductHeaderValue("MyApp"));
client.Credentials = new Credentials("YOUR_TOKEN");

var issueUpdate = new IssueUpdate();
issueUpdate.AddAssignee("copilot-swe-agent");
await client.Issue.Update("owner", "repo", issueNumber, issueUpdate);
```

### パート2: Copilot Chatを使用したPull Request作成

#### ステップ 1: VS CodeでCopilot Chatを開く

1. VS Codeでプロジェクトを開く
2. Copilot Chatパネルを開く（Ctrl+Shift+I）

#### ステップ 2: Pull Request作成を依頼

以下のプロンプトを入力：

```
@github Create a PR to add a configuration system for the calculator app. 
The system should:
1. Read settings from appsettings.json
2. Allow configuring decimal precision
3. Allow enabling/disabling scientific mode
4. Include appropriate error handling
```

#### ステップ 3: 応答の確認

Copilotが以下を返すことを確認：
- Pull RequestのURL
- 作業開始の確認メッセージ

### パート3: 進行状況の監視とコントロール

#### ステップ 1: セッションログの確認

1. 作成されたPull Requestを開く
2. タイムラインで「Copilot started work」を確認
3. 「View session」をクリック

#### ステップ 2: ログの読み方

ログには以下の情報が含まれます：
- Copilotの内部思考プロセス
- 実行されたコマンド
- ファイルの変更内容
- テストの実行結果

#### ステップ 3: セッションの停止（必要な場合）

以下の状況でセッションを停止します：
- Copilotが間違った方向に進んでいる
- 要件を変更する必要がある
- 十分な変更が行われた

停止方法：
1. セッションログビューアーを開く
2. 「Stop session」ボタンをクリック

### 実践演習

以下のタスクを実行してください：

1. **演習1**: エラーハンドリングの改善
   ```markdown
   タイトル: エラーメッセージを日本語化する
   
   すべてのエラーメッセージを日本語に変更し、
   ユーザーフレンドリーな内容にしてください。
   ```

2. **演習2**: Copilot Chatでドキュメント生成
   ```
   @github Create a PR to add comprehensive API documentation 
   for all calculator classes in Markdown format
   ```

### トラブルシューティングのヒント

1. **Copilotが応答しない場合**
   - リポジトリでコーディング エージェントが有効か確認
   - 書き込み権限があるか確認

2. **セッションがタイムアウトした場合**
   - issueの割り当てを解除して再割り当て
   - より明確な指示で新しいissueを作成

## 理解度チェック

1. Copilot Chatでプロンプトに含める必要がある参加者は？
2. セッションログで確認できる情報を3つ挙げてください
3. Copilotのセッションを停止すべき状況を説明してください

## 次のステップ

- [実践的な活用](./03-03-advanced-copilot-coding-agent.md)へ進む
- より複雑なシナリオでの活用方法を学ぶ
