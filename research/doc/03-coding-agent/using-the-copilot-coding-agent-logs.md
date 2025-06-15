セッション ログを使うと、Copilot のアプローチを理解できます

## この機能を使用できるユーザーについて

Copilot コーディング エージェント は、有効になっているリポジトリの GitHub Copilot Pro+ および GitHub Copilot Enterprise プランで使用できます。  
[Sign up for Copilot](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=using+the+copilot+coding+agent+logs&ref_page=docs)

メモ

Copilot コーディング エージェント is in パブリック プレビュー and subject to change.

## [はじめに](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#introduction)

Copilot に issue を割り当てると、または Copilot Chat を使って Copilot に pull request の作成を依頼すると、Copilot は自律的に動作してタスクを完了します。 「[Copilot へのタスクの割り当てについて](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot)」を参照してください。

エージェント セッションの間または後に、セッション ログを調べて、問題に対する Copilot のアプローチを理解できます。

## [Copilot のアプローチを理解するためのセッション ログの使用](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%AE%E3%82%A2%E3%83%97%E3%83%AD%E3%83%BC%E3%83%81%E3%82%92%E7%90%86%E8%A7%A3%E3%81%99%E3%82%8B%E3%81%9F%E3%82%81%E3%81%AE%E3%82%BB%E3%83%83%E3%82%B7%E3%83%A7%E3%83%B3-%E3%83%AD%E3%82%B0%E3%81%AE%E4%BD%BF%E7%94%A8)

セッション ログを表示するには、pull request のタイムラインで **\[View session\]** をクリックします。

![[View session] ボタンが強調されている pull request のセクションのスクリーンショット。](https://docs.github.com/assets/cb-73933/images/help/copilot/coding-agent/log-view-session.png)

セッション ログでは、Copilot の内部モノローグと、リポジトリの理解、変更の実施、その作業の検証に使われたツールを確認できます。

メモ

Copilot には、プッシュする前に変更を検証するための自動テストとリンターを実行する機能が含まれる、独自の開発環境があります。

## [Copilot セッションの停止](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%82%BB%E3%83%83%E3%82%B7%E3%83%A7%E3%83%B3%E3%81%AE%E5%81%9C%E6%AD%A2)

セッション ログ ビューアーの **\[Stop session\]** をクリックして、Copilot がタスクで動作し続けるのを停止できます。

![[Stop session] ボタンが強調されているログ ビューアーのスクリーンショット。](https://docs.github.com/assets/cb-72575/images/help/copilot/coding-agent/log-stop-session.png)

次のような理由でセッションを停止することがあります。

-   Copilot が間違った方向に進んでいるように見え、停止して、さらに明確に指示する必要があります。
-   必要な作業の説明を間違えたため、やり直します。
-   要求した変更を行う必要がないことがわかったので、それ以上作業しないよう Copilot を停止する必要があります。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#further-reading)

-   [Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks)
-   [Copilot のコーディング エージェントのトラブルシューティング](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/troubleshooting-copilot-coding-agent)