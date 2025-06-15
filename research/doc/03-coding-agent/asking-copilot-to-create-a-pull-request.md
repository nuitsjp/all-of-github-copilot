Copilot Chat プロンプトを使用すると、Copilot に pull request を作成するよう依頼できます。

## この機能を使用できるユーザーについて

Copilot コーディング エージェント は、有効になっているリポジトリの GitHub Copilot Pro+ および GitHub Copilot Enterprise プランで使用できます。  
[Sign up for Copilot](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=asking+copilot+to+create+a+pull+request&ref_page=docs)

メモ

-   Copilot コーディング エージェント にアクセスできる場合、Copilot Chat in Visual Studio Code、Visual Studio、JetBrains IDE から、また GitHub.com 上で pull request を作成できます。
-   Copilot コーディング エージェント is in パブリック プレビュー and subject to change.

## [はじめに](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#introduction)

多くの場合、プロジェクトに取り組む際に、実施すべき変更に気付くかもしれませんが、その変更は現在のタスクに直接関係しません。 変更を実施する必要があることを記録するために GitHub issue を作成する場合もあれば、変更を忘れて先に進む場合もあります。

その代わりに、Copilot コーディング エージェント が使用可能な場合は、Copilot に変更の実施を依頼できます。 Copilot はバックグラウンドで変更作業を開始し、完了すると、作成した pull request をレビューするように要求します。

Copilot コーディング エージェント を使用可能にする方法については、「[Enabling Copilot coding agent](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/enabling-copilot-coding-agent)」を参照してください。

## [Copilot Chat で pull request を作成する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#copilot-chat-%E3%81%A7-pull-request-%E3%82%92%E4%BD%9C%E6%88%90%E3%81%99%E3%82%8B)

1.  IDE 上、または GitHub.com でファイルを表示中に、GitHub Copilot Chat を開きます。
    
2.  プロンプトを入力して、Copilot に pull request を作成するように依頼し、Copilot に変更してもらいたい内容の詳細を提供します。
    
    たとえば、`@github Create a PR to put backticks around file names and variables in output.` のように指定します。
    
    重要
    
    VS Code、Visual Studio、JetBrains IDE では、プロンプトで `@github` チャット参加者をメンションする必要があります。 GitHub.com の Copilot Chat ではこれを省略できます。
    
    ヒント
    
    Copilot を支援するために、プロンプトを送信する前に関連するコード行を選択できます。
    
3.  プロンプトを送信します。
    
    Copilot が、作成した pull request のリンクを返します。 タスクの作業を行い、pull request に変更をプッシュし、完了すると、あなたをレビュー担当者として追加し、通知をトリガーします。
    

## [進行状況の監視](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#monitoring-progress)

セッション ログを表示することで、タスクの作業中に Copilot が実行している内容を確認できます。 「[Copilot コーディング エージェント ログの使用](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-the-copilot-coding-agent-logs)」を参照してください。

また、セッション ログの **\[Stop session\]** をクリックして、Copilot のタスクの作業を停止することもできます。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#further-reading)

-   [Copilot へのタスクの割り当てについて](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot)
-   [Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks)
-   [Copilot のコーディング エージェントのトラブルシューティング](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/troubleshooting-copilot-coding-agent#copilot-cant-create-a-pull-request-from-copilot-chat)