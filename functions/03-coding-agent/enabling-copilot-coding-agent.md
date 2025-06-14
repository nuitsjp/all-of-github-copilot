# Copilot Coding Agent 有効化 学習マニュアル

## 学習時間
**約15分**

## 学習目標
- 個人アカウントでの有効化方法を理解する
- Organization設定での有効化方法を学ぶ
- 有効化確認方法を習得する

## 前提条件確認 (3分)

### 必要なライセンス
- GitHub Copilot Pro+ プラン
- GitHub Copilot Enterprise プラン

現在のプラン確認：
1. GitHub.com → Settings → Billing and plans
2. Copilot プランを確認

## 個人リポジトリでの有効化 (5分)

### 手順1: 個人設定アクセス
1. GitHub.com右上のプロフィール画像クリック
2. "Settings" を選択
3. 左サイドバーの "Copilot" をクリック

### 手順2: Coding Agent有効化
1. "Copilot coding agent" セクションを探す
2. "Enable Copilot coding agent" にチェック
3. "Save" をクリック

```javascript
// 設定確認用のテストリポジトリ作成
// test-copilot-agent-setup.js
console.log("Copilot coding agent test repository");

// TODO: この行を修正してHello Worldを出力するようにしてください
console.log("TODO: Fix this line");
```

## Organization での有効化 (5分)

### Organization管理者向け手順

#### ステップ1: Organization設定
1. Organization ページへ移動
2. "Settings" タブをクリック
3. 左サイドバーの "Copilot" → "Policies"

#### ステップ2: Coding Agent ポリシー設定
1. "Copilot coding agent" セクションを確認
2. 以下のオプションから選択：
   - **Enabled**: 全メンバーが使用可能
   - **Disabled**: 使用不可
   - **No policy**: 個人設定に委任

#### ステップ3: リポジトリレベル設定
特定のリポジトリでの有効化:
1. リポジトリ設定 → "General"
2. "Features" セクション
3. "Copilot coding agent" を有効化

## Enterprise レベル設定 (2分)

### Enterprise管理者向け
Enterprise設定でも制御可能:
1. Enterprise settings
2. "Policies" → "Copilot"
3. "Copilot coding agent" ポリシー設定

階層的な制御:
- Enterprise → Organization → Individual
- より制限的なポリシーが優先される

## 有効化確認方法

### 確認手順1: Issue の Assignees
1. リポジトリのIssueを開く
2. 右サイドバーの "Assignees" をクリック
3. **Copilot** が選択肢に表示されるか確認

### 確認手順2: GraphQL API確認
```graphql
query {
  repository(owner: "USERNAME", name: "REPOSITORY") {
    suggestedActors(capabilities: [CAN_BE_ASSIGNED], first: 100) {
      nodes {
        login
        __typename
        ... on Bot {
          id
        }
      }
    }
  }
}
```

期待される結果: `login` が `copilot-swe-agent` のノード

### 確認手順3: Copilot Chat テスト
VS Code または GitHub.comで:
```
@github Create a PR to add a simple hello world function
```

エラーが出なければ有効化成功

## トラブルシューティング

### よくある問題

#### 問題1: Copilotが Assignees に表示されない
**原因と解決策**:
- ライセンス確認: Pro+/Enterprise が必要
- Organization設定確認
- リポジトリレベル設定確認

#### 問題2: 権限エラー
**解決策**:
- リポジトリへの書き込み権限確認
- Organization メンバーシップ確認

#### 問題3: 機能が見つからない
**原因**:
- パブリックプレビュー機能
- 段階的ロールアウト中の可能性

## 実践確認

### 確認テスト作成
1. 新しいリポジトリを作成
2. 簡単なIssueを作成
3. Copilotへの割り当てを試行

```markdown
# テスト用Issue例
タイトル: Add console.log statement

説明:
test.js ファイルに "Hello, Copilot!" を出力するconsole.logを追加してください。

受け入れ基準:
- [ ] console.log("Hello, Copilot!"); を追加
- [ ] 動作確認
```

## 次のステップ
- [ベストプラクティスの学習](best-practices-for-using-copilot-to-work-on-tasks.md)
- [実際のIssue処理実践](using-copilot-to-work-on-an-issue.md)

## 注意事項
- 機能は段階的にロールアウト
- 設定変更の反映に時間がかかる場合あり
- エラーが続く場合はGitHub Supportに連絡
