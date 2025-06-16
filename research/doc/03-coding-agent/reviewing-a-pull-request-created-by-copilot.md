Copilot が pull request を作成したら、レビューして変更が必要な内容についてコメントする必要があります。

## この機能を使用できるユーザーについて

Copilot コーディング エージェント は、有効になっているリポジトリの GitHub Copilot Pro+ および GitHub Copilot Enterprise プランで使用できます。  
[Sign up for Copilot](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=reviewing+a+pull+request+created+by+copilot&ref_page=docs)

メモ

Copilot コーディング エージェント is in パブリック プレビュー and subject to change.

## [Copilot の変更をレビューする](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%AE%E5%A4%89%E6%9B%B4%E3%82%92%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%81%99%E3%82%8B)

Copilot がコーディング タスクの作業を完了し、pull request レビューを要求したら、pull request をマージする前に、Copilot の作業を十分にレビューする必要があります。

重要

"必須の承認" ルールまたはブランチ保護が有効になっている場合、関連する issue を Copilot に割り当てることで自分が開始した pull request を承認することはできません。 マージする前に、他のユーザーが pull request を承認する必要があります。

Pull request のコメントを使用して変更を行うように Copilot に依頼するか、Copilot のブランチをチェックアウトして自分で変更を加えることができます。

ヒント

レビュー コメントを個別に送信するのではなく、バッチ処理することをお勧めします。

Copilot の pull request にコメントを残すと、Copilot はコメントを考慮し、新しいエージェント セッションを開始して応答すべきかどうかを決定します。

Copilot only responds to comments from people who have write access to the repository.

Copilot がコメントに応答して新しいエージェント セッションを開始すると、コメントへの応答として目の絵文字 (👀) が追加され、pull request のタイムラインに "Copilot has started work" イベントが追加されます。

![レビュー コメントに加え、目の絵文字の反応と "Copilot started work" タイムライン イベントが表示された、pull request のタイムラインのスクリーンショット。](https://docs.github.com/assets/cb-156524/images/help/copilot/coding-agent/comment-to-agent-on-pr.png)

Copilot は、コメントが無関係と判断すると、そのコメントを無視できます。 Copilot に確実にコメントに応答させたい場合は、コメントに `@copilot` を含めることで、Copilot を @mention することができます。

ヒント

Copilot が pull request のコメントに応答しないようにする場合は、pull request から Copilot の割り当てを解除できます。 後で同じ pull request に Copilot を再割り当てすると、新しいコメントに応答し、さらに変更をプッシュするようになります。 割り当てられていなかった間に追加されたコメントには応答しません。

詳細については、「[Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks#using-comments-to-iterate-on-a-pull-request)」の「コメントを使用して pull request を繰り返す」セクションを参照してください。

## [GitHub Actions のワークフローの実行を管理する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#github-actions-%E3%81%AE%E3%83%AF%E3%83%BC%E3%82%AF%E3%83%95%E3%83%AD%E3%83%BC%E3%81%AE%E5%AE%9F%E8%A1%8C%E3%82%92%E7%AE%A1%E7%90%86%E3%81%99%E3%82%8B)

Copilot が pull request に変更をプッシュしても、GitHub Actions のワークフローは自動的には実行されません。

GitHub Actions ワークフローに特権を付与し、そこから機密性の高いシークレットにアクセスすることができます。 プルリクエストで提案された変更を調べて、プルリクエストブランチでワークフローを快適に実行できることを確認します。 ワークフロー ファイルに影響を与える `.github/workflows/` ディレクトリで提案された変更には特に注意する必要があります。

GitHub Actions のワークフローの実行を許可するには、pull request のマージ ボックスの **\[Approve and run workflows\]** ボタンをクリックします。

![[Approve and run workflows] ボタンが表示された、Copilot による pull request のマージ ボックスのスクリーンショット。](https://docs.github.com/assets/cb-150864/images/help/copilot/coding-agent/approve-and-run-workflows.png)

## [Copilot の作業にフィードバックを提供する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%AE%E4%BD%9C%E6%A5%AD%E3%81%AB%E3%83%95%E3%82%A3%E3%83%BC%E3%83%89%E3%83%90%E3%83%83%E3%82%AF%E3%82%92%E6%8F%90%E4%BE%9B%E3%81%99%E3%82%8B)

Copilot の pull request とコメントのフィードバック ボタンを使用すると、Copilot の作業に関するフィードバックを提供できます。 フィードバックは、製品と Copilot のソリューションの品質の向上に使われます。

1.  Copilot による pull request またはコメントで、サムズアップ (👍) ボタンまたはサムズダウン (👎) ボタンをクリックします。
2.  サムダウン ボタンをクリックした場合は、追加情報の提供を求められます。 必要に応じて、否定的なフィードバックの理由を選び、コメントを残してから、**\[Submit feedback\]** をクリックできます。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#further-reading)

-   [Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks)
-   [Copilot コーディング エージェント ログの使用](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-the-copilot-coding-agent-logs)
-   [Copilot のコーディング エージェントのトラブルシューティング](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/troubleshooting-copilot-coding-agent)