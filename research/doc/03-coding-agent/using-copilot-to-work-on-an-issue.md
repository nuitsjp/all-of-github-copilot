GitHub Copilot に issue を割り当て、Copilot が issue を処理する際の進行状況を監視し、pull request レビュー コメントを使用して Copilot に処理を繰り返し実行するように求める方法について説明します。

## この機能を使用できるユーザーについて

Copilot コーディング エージェント は、有効になっているリポジトリの GitHub Copilot Pro+ および GitHub Copilot Enterprise プランで使用できます。  
[Sign up for Copilot](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=using+copilot+to+work+on+an+issue&ref_page=docs)

メモ

Copilot コーディング エージェント is in パブリック プレビュー and subject to change.

## [はじめに](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#introduction)

人間のソフトウェア開発者に対して行うのと同じように、GitHub の issue を Copilot に割り当てることができます。 Copilot は issue の処理を開始し、pull request を発生させ、処理が完了したら、レビューを要求します。 詳しくは、「[Copilot へのタスクの割り当てについて](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot)」をご覧ください。

以前に Copilot を使用して issue を処理したことがない場合は、良い結果を得るための有用なアドバイスを「[Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks)」でご覧ください。

## [Copilot に issue を割り当てる](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#copilot-%E3%81%AB-issue-%E3%82%92%E5%89%B2%E3%82%8A%E5%BD%93%E3%81%A6%E3%82%8B)

Copilot に issue を割り当てることで、issue の処理を開始するように Copilot に依頼できます。

以下のようにして Copilot に issue を割り当てることができます。

-   GitHub.com で ([次のセクション](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#assigning-an-issue-to-copilot-on-githubcom)をご覧ください)
-   [GitHub Mobile](https://docs.github.com/ja/get-started/using-github/github-mobile) 上
-   GitHub API を使用して ([この記事の後半](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#assigning-an-issue-to-copilot-via-the-github-api)をご覧ください)
-   GitHub CLI を使用する (「[`gh issue edit`](https://cli.github.com/manual/gh_issue_edit)」をご覧ください)

### [GitHub.com で Copilot に issue を割り当てる](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#githubcom-%E3%81%A7-copilot-%E3%81%AB-issue-%E3%82%92%E5%89%B2%E3%82%8A%E5%BD%93%E3%81%A6%E3%82%8B)

別のユーザーを割り当てるのとまったく同じ方法で、GitHub.com の Copilot に issue を割り当てることができます。

1.  GitHub で、リポジトリのメイン ページに移動します。
    
2.  リポジトリ名の下にある **\[イシュー\]** をクリックします。
    
    ![リポジトリのメイン ページのスクリーンショット。 水平ナビゲーション バーでは、[イシュー] というラベルが付いたタブが濃いオレンジ色の枠線で囲まれています。](https://docs.github.com/assets/cb-51267/images/help/repository/repo-tabs-issues-global-nav-update.png)
    
3.  Copilot に割り当てる issue を開きます。
    
4.  右側のメニューで **\[担当者\]** をクリックします。
    
    ![issue の右サイドバーのスクリーンショット。 "担当者" というラベルの付いたヘッダーが、濃いオレンジ色の枠線で囲まれています。](https://docs.github.com/assets/cb-19901/images/help/issues/assignee-menu.png)
    
5.  担当者の一覧から **\[Copilot\]** をクリックします。
    
    ![Issue の [Assignees] ウィンドウのスクリーンショット。 一覧にある Copilot を利用できます。](https://docs.github.com/assets/cb-52480/images/help/copilot/coding-agent/assign-to-copilot.png)
    

ヒント

Copilot に issue を割り当てると、issue のタイトル、説明、および現在存在するすべてのコメントが送信されます。 Issue を割り当てた後、Copilot はその issue に追加された以降のコメントを認識せず、したがってそれに応答しません。 さらに詳しい情報がある場合、または元の要件に変更がある場合は、Copilot が発生させる pull request にコメントとして追加してください。

GitHub.com のその他の場所から Copilot に issue を割り当てることもできます。

-   リポジトリの **\[Issues\]** ページにある issue の一覧から。
-   GitHub プロジェクト で issue を表示しているとき。

### [GitHub API を使用して issue を Copilot に割り当てる](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#github-api-%E3%82%92%E4%BD%BF%E7%94%A8%E3%81%97%E3%81%A6-issue-%E3%82%92-copilot-%E3%81%AB%E5%89%B2%E3%82%8A%E5%BD%93%E3%81%A6%E3%82%8B)

GraphQL API に要求を行うことで、Copilot に issue を割り当てることができます。

1.  personal access tokenや GitHub App ユーザーからサーバーへのトークンなどのユーザー トークンを使用して API で認証していることを確認してください。
    
2.  GraphQL API のリポジトリの `suggestedActors` に Copilot が含まれているかどうかを確認して、Copilot コーディング エージェント がリポジトリで有効になっていることを確認します。 `monalisa` をリポジトリ所有者に置き換え、`octocat` を名前に置き換えます。
    
    GraphQL
    
    ```graphql
    query { repository(owner: "monalisa", name: "octocat") { suggestedActors(capabilities: [CAN_BE_ASSIGNED], first: 100) { nodes { login __typename ... on Bot { id } ... on User { id } } } } }
    ```
    
    ユーザーとリポジトリで Copilot コーディング エージェント が有効になっている場合、クエリから返される最初のノードの `login` 値は `copilot-swe-agent` です。
    
3.  Copilot に割り当てる issue の GraphQL グローバル ID をフェッチし、`monalisa` をリポジトリの所有者、`octocat` を名前、`9000` を issue 番号に置き換えます。
    
    GraphQL
    
    ```graphql
    query { repository(owner: "monalisa", name: "octocat") { issue(number: 9000) { id title } } }
    ```
    
4.  `replaceActorsForAssignable` GraphQL のミューテーションを使用して、issue を Copilot に割り当てます。 `ISSUE_ID` を前のステップで返された ID に置き換え、`BOT_ID` をその前のステップで返された ID に置き換えます。
    
    GraphQL
    
    ```graphql
    mutation { replaceActorsForAssignable(input: {assignableId: "ISSUE_ID", assigneeIds: ["BOT_ID"]}) { assignable { ... on Issue { id title assignees(first: 10) { nodes { login } } } } } }
    ```
    

## [Issue に関する Copilot の進行状況を追跡する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#issue-%E3%81%AB%E9%96%A2%E3%81%99%E3%82%8B-copilot-%E3%81%AE%E9%80%B2%E8%A1%8C%E7%8A%B6%E6%B3%81%E3%82%92%E8%BF%BD%E8%B7%A1%E3%81%99%E3%82%8B)

Copilot に issue を割り当てた直後に、Copilot は issue に対して 👀 の応答を残します。

![Copilot に割り当てられている issue のスクリーンショット。 Copilot が目のアイコンで応答を残しています。](https://docs.github.com/assets/cb-129528/images/help/copilot/coding-agent/issue-assigned-to-copilot.png)

数秒後、Copilot は、元の issue にリンクされた下書きの pull request を開きます。 イベントが issue のタイムラインに表示され、pull request にリンクされます。

![リンクされた pull request が開かれていることを示す、タイムライン イベントを含む issue のスクリーンショット。](https://docs.github.com/assets/cb-73703/images/help/copilot/coding-agent/issue-link-to-pr.png)

Copilot が issue を処理するための**エージェント セッション**を開始します。 "Copilot started work" イベントが pull request タイムラインに表示され、Copilot が機能すると、通常の状態の更新で pull request 本文が更新され、コミットがブランチにプッシュされます。

!["Copilot started work" など、一連のタイムライン イベントを含む pull request のスクリーンショット。](https://docs.github.com/assets/cb-139955/images/help/copilot/coding-agent/copilot-started-work.png)

Copilot の処理状況を確認する場合は、**\[View session\]** をクリックします。 セッション ログ ビューアーが表示され、Copilot による issue の処理のライブ ログが表示されます。 Issue に対する Copilot の処理を停止する場合は、**\[Stop session\]** をクリックします。 「[Copilot コーディング エージェント ログの使用](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-the-copilot-coding-agent-logs)」を参照してください。

Copilot が終了すると、エージェント セッションが終了し、Copilot がレビューを要求し、通知をトリガーします。 さらに、pull request タイムラインに "Copilot finished work" イベントが表示されます。

!["Copilot requested review" イベントと "Copilot finished work" イベントを含む pull request タイムラインのスクリーンショット。](https://docs.github.com/assets/cb-43158/images/help/copilot/coding-agent/copilot-finished-work.png)

## [Pull request で Copilot を操作する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#pull-request-%E3%81%A7-copilot-%E3%82%92%E6%93%8D%E4%BD%9C%E3%81%99%E3%82%8B)

Copilot が issue の処理を完了したら、pull request を十分に確認し、変更が必要な内容についてコメントする必要があります。 「[Copilot によって作成された pull request をレビューする](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot)」を参照してください。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue#further-reading)

-   [Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks)
-   [Copilot のコーディング エージェントのトラブルシューティング](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/troubleshooting-copilot-coding-agent)