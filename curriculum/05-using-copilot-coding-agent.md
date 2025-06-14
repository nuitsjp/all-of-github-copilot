# GitHub Copilot コーディングエージェントを使いこなす

## 学習の目的

このハンズオンでは、GitHub Copilot コーディングエージェントを使用して、自律的にIssueを処理し、Pull Requestを作成する方法を学びます。実際のワークフローを体験しながら、効果的な使い方を習得しましょう。

## 前提条件

- GitHub Copilot Pro+ または GitHub Copilot Enterprise のサブスクリプション
- リポジトリへの書き込み権限
- Copilot コーディングエージェントが有効化されていること

## シナリオ: ドキュメントの改善タスクをCopilotに委任する

### ステップ1: Copilot コーディングエージェントを有効化する

まず、リポジトリでCopilot コーディングエージェントを使用できるようにします。

**個人リポジトリの場合:**
1. GitHubの設定画面を開く
2. 「Copilot」セクションに移動
3. 「Copilot コーディングエージェント」を有効化

**組織リポジトリの場合:**
1. 組織の設定画面を開く
2. 「Copilot」ポリシーに移動
3. 対象リポジトリでエージェントを有効化

### ステップ2: 適切なIssueを作成する

効果的なIssueの書き方を学びましょう。

```markdown
Title: READMEファイルのコード例にシンタックスハイライトを追加

Description:
現在、READMEファイルのコード例にシンタックスハイライトが設定されていません。
以下の改善を実施してください：

1. すべてのコードブロックに適切な言語識別子を追加
2. インラインコードには`バッククォート`を使用
3. ファイル名や変数名も適切にマークアップ

受け入れ基準:
- すべてのコードブロックに言語識別子が設定されている
- インラインのコード、ファイル名、変数名がバッククォートで囲まれている
- Markdownのプレビューで正しくハイライトされることを確認
```

### ステップ3: CopilotにIssueを割り当てる

1. 作成したIssueを開く
2. 右側のサイドバーで「Assignees」をクリック
3. リストから「Copilot」を選択

![Copilotへの割り当て](https://docs.github.com/assets/cb-52480/images/help/copilot/coding-agent/assign-to-copilot.png)

割り当て後、Copilotが👀の絵文字で反応します。

### ステップ4: 進行状況を監視する

Copilotの作業状況を確認しましょう：

1. IssueのタイムラインでPull Requestへのリンクを確認
2. Pull Requestを開き、「View session」をクリック
3. セッションログでCopilotの思考プロセスを観察

```
セッションログの例：
- リポジトリの構造を分析中...
- READMEファイルを検査中...
- コードブロックを識別中...
- 変更を実装中...
- テストを実行中...
```

### ステップ5: Pull Requestをレビューする

Copilotが作業を完了したら、Pull Requestをレビューします：

1. **変更内容の確認**
   - 提案された変更が要件を満たしているか
   - 不要な変更が含まれていないか

2. **フィードバックの提供**
   ```markdown
   @copilot 以下の点を修正してください：
   - `config.yml`のコードブロックにYAML言語識別子を追加
   - セクション3.2のインラインコードが漏れています
   ```

3. **GitHub Actionsワークフローの承認**
   - 「Approve and run workflows」ボタンをクリック

### ステップ6: Copilot Chatから直接Pull Requestを作成する

別の方法として、Copilot Chatを使用することもできます：

**VS Code/Visual Studio/JetBrainsの場合:**
```
@github Create a PR to add syntax highlighting to all code blocks in documentation
```

**GitHub.comの場合:**
```
Create a PR to add syntax highlighting to all code blocks in documentation
```

## ベストプラクティス

### 1. カスタム指示の追加

`.github/copilot-instructions.md`ファイルを作成：

```markdown
<!-- filepath: .github/copilot-instructions.md -->
# Copilot Instructions

このリポジトリで作業する際は、以下のガイドラインに従ってください：

## コーディング規約
- すべてのコードにはコメントを追加
- 変更前に必ず`npm test`を実行
- コミット前に`npm run lint`を実行

## ドキュメント
- 新機能にはREADMEを更新
- コード例には必ず言語識別子を追加
- 日本語ドキュメントは敬語を使用
```

### 2. 依存関係の事前設定

`.github/copilot-setup-steps.yml`ファイルを作成：

```yaml
<!-- filepath: .github/copilot-setup-steps.yml -->
steps:
  - name: Setup Node.js
    run: |
      curl -fsSL https://deb.nodesource.com/setup_20.x | sudo -E bash -
      sudo apt-get install -y nodejs

  - name: Install dependencies
    run: |
      npm install
      npm run build
```

## トラブルシューティング

### よくある問題と解決方法

1. **CopilotがAssigneesリストに表示されない**
   - Copilot Pro+/Enterpriseのサブスクリプションを確認
   - リポジトリでエージェントが有効化されているか確認

2. **Copilotが反応しない**
   - ページをリフレッシュ
   - Pull RequestのタイムラインでCopilotの状態を確認

3. **Pull Requestのコメントに反応しない**
   - 書き込み権限があることを確認
   - `@copilot`でメンションして強制的に反応させる

## 演習問題

### 演習1: バグ修正タスク
以下の内容でIssueを作成し、Copilotに割り当ててみましょう：

```markdown
Title: TypeError in utils.js の修正

Description:
utils.js の formatDate 関数で、null値が渡された時にTypeErrorが発生します。

再現手順:
1. formatDate(null) を実行
2. TypeError: Cannot read property 'toISOString' of null

期待される動作:
- null/undefinedの場合は空文字列を返す
- 適切なエラーハンドリングを追加
- ユニットテストを追加
```

### 演習2: 機能追加タスク
新機能の実装をCopilotに依頼：

```markdown
Title: ダークモード切り替え機能の追加

Description:
ユーザーがダークモードとライトモードを切り替えられる機能を追加してください。

要件:
1. ヘッダーに切り替えボタンを追加
2. ユーザーの選択をlocalStorageに保存
3. ページ読み込み時に保存された設定を適用
4. CSSカスタムプロパティを使用して実装

受け入れ基準:
- 切り替えボタンが機能する
- リロード後も設定が保持される
- すべての画面で正しく表示される
```

## まとめ

このハンズオンを通じて、以下のことを学びました：

1. Copilot コーディングエージェントの有効化方法
2. 効果的なIssueの書き方
3. Copilotへのタスクの割り当て方
4. 進行状況の監視方法
5. Pull Requestのレビューとフィードバック
6. ベストプラクティスの適用

Copilot コーディングエージェントを活用することで、定型的なタスクを自動化し、より創造的な作業に集中できるようになります。継続的に使用しながら、チームに最適な活用方法を見つけていきましょう。

## 次のステップ

- [MCPを使用したCopilotの拡張](https://docs.github.com/ja/copilot/customizing-copilot/extending-copilot-coding-agent-with-mcp)
- [ファイアウォールのカスタマイズ](https://docs.github.com/ja/copilot/customizing-copilot/customizing-or-disabling-the-firewall-for-copilot-coding-agent)
- [組織での効果的な活用方法](https://docs.github.com/ja/copilot/rolling-out-github-copilot-at-scale/enabling-developers/using-copilot-coding-agent-in-org)
