# Copilot Issue処理 実践学習マニュアル

## 学習時間
**約60分**

## 学習目標
- GitHubでCopilotにIssueを割り当てる方法を習得する
- エージェントセッションの監視方法を理解する
- Pull requestでの反復改善プロセスを実践する
- API経由での割り当て方法を学ぶ

## 事前準備 (10分)

### 学習用リポジトリ作成

```bash
# リポジトリ作成
mkdir copilot-issue-practice
cd copilot-issue-practice
git init
```

### サンプルコード準備

```csharp
// filepath: src/Calculator.cs
using System;

namespace CalculatorApp
{
    /// <summary>
    /// 基本的な計算機能を提供するクラス
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// 二つの整数を加算します
        /// </summary>
        /// <param name="a">第一オペランド</param>
        /// <param name="b">第二オペランド</param>
        /// <returns>加算結果</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        // TODO: 他の基本演算メソッドを実装する必要があります
        // - Subtract (減算)
        // - Multiply (乗算)  
        // - Divide (除算) - ゼロ除算のエラーハンドリング付き
    }
}
```

```csharp
// filepath: tests/CalculatorTests.cs
using System;
using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();
            
            // Act
            var result = calculator.Add(2, 3);
            
            // Assert
            Assert.Equal(5, result);
        }
        
        // TODO: 他の演算メソッドのテストが必要です
    }
}
```

## 実践1: GitHub.comでのIssue割り当て (20分)

### ステップ1: Issue作成
GitHub リポジトリで新しいIssueを作成：

```markdown
タイトル: Calculatorに減算機能を追加

## 説明
Calculatorクラスに減算(Subtract)メソッドを追加してください。

## 要件
- 二つの整数を受け取り、第一引数から第二引数を減算する
- XMLドキュメントコメントを追加
- 単体テストを作成
- オーバーフローチェックは不要

## 受け入れ基準
- [ ] `public int Subtract(int a, int b)` メソッドを追加
- [ ] 適切なXMLドキュメントコメント
- [ ] `CalculatorTests.cs` に単体テストを追加
- [ ] テストは複数シナリオをカバー（正数、負数、ゼロ）

## 対象ファイル
- `src/Calculator.cs`
- `tests/CalculatorTests.cs`
```

### ステップ2: Copilotへの割り当て
1. 作成したIssueを開く
2. 右サイドバーの **Assignees** をクリック
3. リストから **Copilot** を選択
4. 👀 リアクションが追加されることを確認

### ステップ3: 進捗確認
- 数秒後にdraft Pull Requestが作成される
- IssueタイムラインにPRリンクが表示される
- "Copilot started work" イベントを確認

## 実践2: エージェントセッション監視 (15分)

### セッションログの確認
1. Copilotが作成したPull Requestを開く
2. **View session** ボタンをクリック
3. セッションログビューアーでライブログを確認

### 確認ポイント
- Copilotの思考プロセス
- 使用されたツール
- コード変更の進捗
- テスト実行結果

### セッション停止の練習
1. セッションログで **Stop session** をクリック
2. 停止理由を理解：
   - 間違った方向に進んでいる
   - 要件説明に誤りがあった
   - 作業が不要になった

## 実践3: Pull Requestでの反復改善 (10分)

### レビューコメント追加
Copilotが作成したPRに以下のコメントを追加：

```markdown
Subtractメソッドに以下の改善をお願いします：

1. メソッドの戻り値の型をlongに変更して、オーバーフローを避けてください
2. 引数にint.MinValueが渡された場合の考慮を追加
3. テストケースに境界値テストを追加（int.MaxValue, int.MinValue）
```

### バッチレビューの実践
1. **Start a review** をクリック
2. 複数のコメントを追加
3. **Submit review** で一括送信
4. Copilotの 👀 リアクションを確認
5. "Copilot started work" イベントを待機

## 実践4: GraphQL APIを使用した割り当て (10分)

### 前提条件確認
GitHub GraphQL Explorer (https://docs.github.com/en/graphql/overview/explorer) を使用

### ステップ1: Copilotが利用可能か確認
```graphql
query {
  repository(owner: "YOUR_USERNAME", name: "copilot-issue-practice") {
    suggestedActors(capabilities: [CAN_BE_ASSIGNED], first: 100) {
      nodes {
        login
        __typename
        ... on Bot {
          id
        }
        ... on User {
          id
        }
      }
    }
  }
}
```

期待結果: `copilot-swe-agent` が最初のノードに表示

### ステップ2: Issue ID取得
```graphql
query {
  repository(owner: "YOUR_USERNAME", name: "copilot-issue-practice") {
    issue(number: ISSUE_NUMBER) {
      id
      title
    }
  }
}
```

### ステップ3: Copilotに割り当て
```graphql
mutation {
  replaceActorsForAssignable(input: {
    assignableId: "ISSUE_ID"
    assigneeIds: ["BOT_ID"]
  }) {
    assignable {
      ... on Issue {
        id
        title
        assignees(first: 10) {
          nodes {
            login
          }
        }
      }
    }
  }
}
```

## 実践5: GitHub CLIを使用した割り当て (5分)

### GitHub CLI セットアップ確認
```bash
gh --version
gh auth status
```

### Issue割り当てコマンド
```bash
# Issue一覧表示
gh issue list

# Copilotに割り当て
gh issue edit ISSUE_NUMBER --assignee @copilot
```

## トラブルシューティング実践

### よくある問題の対処

#### 問題1: Copilotが選択肢に表示されない
**診断手順**:
1. ライセンス確認: `gh copilot status`
2. リポジトリ設定確認
3. Organization設定確認

#### 問題2: Issueに割り当てても反応がない
**対処法**:
1. ページリフレッシュ
2. 数分待機
3. 👀 リアクション確認

#### 問題3: PRコメントに応答しない
**確認項目**:
- 書き込み権限の有無
- Copilotの割り当て状況
- `@copilot` メンションの追加

## 学習の振り返り

### 理解度チェック

#### 質問1: Issue割り当て後の最初の兆候は？
A) Pull Request作成
B) 👀 リアクション追加  
C) コミットのプッシュ
D) セッション開始通知

#### 質問2: セッションを停止すべき状況は？
A) Copilotが期待通りに動作している
B) 間違った方向に進んでいる
C) 作業が完了した
D) レビューコメントを追加した

### 実践結果の確認
- [ ] Issue作成からPR作成まで一連の流れを実行
- [ ] セッションログを確認してCopilotの動作を理解
- [ ] レビューコメントでの反復改善を実践
- [ ] API/CLI経由での割り当てを実行

## 次のステップ
- [Pull request作成依頼の学習](asking-copilot-to-create-a-pull-request.md)
- [エージェントログの詳細理解](using-the-copilot-coding-agent-logs.md)

## 学習メモ
今回の実践で学んだポイントや気づきをメモ：
- 
- 
- 
