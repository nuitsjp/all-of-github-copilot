タスクを Copilot に割り当てるときに発生する可能性がある問題の解決方法について説明します。

## この機能を使用できるユーザーについて

Copilot コーディング エージェント は、有効になっているリポジトリの GitHub Copilot Pro+ および GitHub Copilot Enterprise プランで使用できます。  
[Sign up for Copilot](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=troubleshooting+copilot+coding+agent&ref_page=docs)

メモ

Copilot コーディング エージェント is in パブリック プレビュー and subject to change.

## [Issue の "Assignees" 一覧に Copilot が存在しない](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#issue-%E3%81%AE-assignees-%E4%B8%80%E8%A6%A7%E3%81%AB-copilot-%E3%81%8C%E5%AD%98%E5%9C%A8%E3%81%97%E3%81%AA%E3%81%84)

Copilot に issue を割り当てることができるのは、**GitHub Copilot Pro+** プランまたは **GitHub Copilot Enterprise** プランを通じて Copilot にアクセスできる場合のみです。

これらのプランのサブスクリプションをまだお持ちでない場合は、次のボタンをクリックして詳細を確認してください。  
[Copilot にサインアップする](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=troubleshooting+copilot+coding+agent&ref_page=docs)

GitHub Copilot Pro+ または GitHub Copilot Enterprise のいずれかを "持っている" 場合は、Copilot コーディング エージェント がリポジトリで使用可能になっていることをチェックします。\_\_

-   Organization が所有するリポジトリの場合、リポジトリ内で Copilot コーディング エージェント が使用できるかどうかは organization の設定で構成されます。 「[Organization への Copilot コーディング エージェント の追加](https://docs.github.com/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/adding-copilot-coding-agent-to-organization)」を参照してください。
    
-   個人用のリポジトリの場合、リポジトリ内で Copilot コーディング エージェント が使用できるかどうかはユーザーのアカウントの設定で構成されます。 「[個人のサブスクライバーとしての Copilot ポリシーの管理](https://docs.github.com/ja/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/managing-your-copilot-plan/managing-copilot-policies-as-an-individual-subscriber#enabling-or-disabling-copilot-coding-agent)」を参照してください。
    

## [Copilot で Copilot Chat](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%A7-copilot-chat)

から pull request を作成できない

Copilot に pull request を作成するように依頼し、pull request を直接作成できないという応答が返された場合は、Copilot コーディング エージェント が使用可能であることを確認します。

重要

VS Code、Visual Studio、JetBrains IDE では、プロンプトで `@github` チャット参加者をメンションする必要があります。 GitHub.com の Copilot Chat ではこれを省略できます。

## [Copilot に issue を割り当てたものの、何も起こらない](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%AB-issue-%E3%82%92%E5%89%B2%E3%82%8A%E5%BD%93%E3%81%A6%E3%81%9F%E3%82%82%E3%81%AE%E3%81%AE%E4%BD%95%E3%82%82%E8%B5%B7%E3%81%93%E3%82%89%E3%81%AA%E3%81%84)

しばらく待って、ページを更新します。 Copilot が issue に対して 👀 の反応を残していることに気付くはずです。 この後すぐに、Copilot が issue に関連する下書きの pull request を開き、issue のタイムラインに表示されます。

## [Copilot が pull request を開いたものの、何も起こらない](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%8C-pull-request-%E3%82%92%E9%96%8B%E3%81%84%E3%81%9F%E3%82%82%E3%81%AE%E3%81%AE%E4%BD%95%E3%82%82%E8%B5%B7%E3%81%93%E3%82%89%E3%81%AA%E3%81%84)

Pull request のタイムラインに "Copilot が作業を開始した" イベントがある場合は、**\[View session\]** をクリックしてセッション ログを確認します。 これらはライブストリーミングされるため、Copilot が何を行っているかを確認できます。

## [Copilot が pull request のコメントに応答しない](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%8C-pull-request-%E3%81%AE%E3%82%B3%E3%83%A1%E3%83%B3%E3%83%88%E3%81%AB%E5%BF%9C%E7%AD%94%E3%81%97%E3%81%AA%E3%81%84)

Copilot only responds to comments from people who have write access to the repository.

書き込みアクセス権限を持っているユーザーが、Copilot に割り当てられている pull request にコメントを追加した場合、コメントは Copilot コーディング エージェント に渡されます。 Copilot コーディング エージェント によってコメントが考慮されていることを示す目の絵文字 (👀) がコメントに追加されます。 エージェントがコメントに応答して変更を行う作業に進んだ場合、pull request のタイムラインに "Copilot が作業を開始した" イベントが追加されます。

このようにならない場合は、Copilot が pull request から割り当てを解除されたか、Copilot がコメントに対応できないと判断した可能性があります。

Copilot が pull request に割り当てられていることを確認します。 割り当てられている場合、`@copilot` 付きのコメントで Copilot を @mentioning することで、Copilot にコメントへの応答を強制できます。

## [エージェントのセッション ログによると、Copilot の作業が停止しているように見える](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88%E3%81%AE%E3%82%BB%E3%83%83%E3%82%B7%E3%83%A7%E3%83%B3-%E3%83%AD%E3%82%B0%E3%81%AB%E3%82%88%E3%82%8B%E3%81%A8copilot-%E3%81%AE%E4%BD%9C%E6%A5%AD%E3%81%8C%E5%81%9C%E6%AD%A2%E3%81%97%E3%81%A6%E3%81%84%E3%82%8B%E3%82%88%E3%81%86%E3%81%AB%E8%A6%8B%E3%81%88%E3%82%8B)

Copilot はしばらくの間作業が停止しているように見えた後、再度作業を開始することがあります。

セッションが停止したままの場合、1 時間後にタイムアウトになります。 再試行するには、issue の割り当てを解除した後、Copilot に再割り当てすることができます。

コメントへの応答中に Copilot の作業が停止した場合は、pull request に同じコメントをもう一度追加してみてください。

## [Copilot がプッシュしても、GitHub Actions のワークフローが実行されない](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%8C%E3%83%97%E3%83%83%E3%82%B7%E3%83%A5%E3%81%97%E3%81%A6%E3%82%82github-actions-%E3%81%AE%E3%83%AF%E3%83%BC%E3%82%AF%E3%83%95%E3%83%AD%E3%83%BC%E3%81%8C%E5%AE%9F%E8%A1%8C%E3%81%95%E3%82%8C%E3%81%AA%E3%81%84)

Copilot が pull request に変更をプッシュしても、GitHub Actions のワークフローは自動的には実行されません。

GitHub Actions のワークフローの実行を許可するには、pull request のマージ ボックスの **\[Approve and run workflows\]** ボタンをクリックします。 「[Copilot によって作成された pull request をレビューする](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot)」を参照してください。

## [Copilot が CI チェックに合格しない変更をプッシュしている](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#copilot-%E3%81%8C-ci-%E3%83%81%E3%82%A7%E3%83%83%E3%82%AF%E3%81%AB%E5%90%88%E6%A0%BC%E3%81%97%E3%81%AA%E3%81%84%E5%A4%89%E6%9B%B4%E3%82%92%E3%83%97%E3%83%83%E3%82%B7%E3%83%A5%E3%81%97%E3%81%A6%E3%81%84%E3%82%8B)

Issue の作業中、Copilot は、GitHub Actions を利用して独自の一過性の開発環境にアクセスできます。この開発環境では、自動的なテストとリンターを実施することで、プッシュする前に作業の検証を行えます。

何をすべきかについて明確な指示が与えられた場合は、これを実施する可能性が最も高くなります。 これを最も効果的に実施する方法は、`.github/copilot-instructions.md` ファイルを使用することです。 「[Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks#adding-custom-instructions-to-your-repository)」を参照してください。

## [ファイアウォールに関する GitHub Copilot からの警告がある](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#%E3%83%95%E3%82%A1%E3%82%A4%E3%82%A2%E3%82%A6%E3%82%A9%E3%83%BC%E3%83%AB%E3%81%AB%E9%96%A2%E3%81%99%E3%82%8B-github-copilot-%E3%81%8B%E3%82%89%E3%81%AE%E8%AD%A6%E5%91%8A%E3%81%8C%E3%81%82%E3%82%8B)

既定では、Copilot のインターネットへのアクセスはファイアウォールで制限されます。

インターネットへのアクセスを制限すると、Copilot の驚くべき動作や提供された悪意のある指示によってコードやその他の機密情報がリモートの場所に漏洩する可能性がある、データ流出のリスクを管理できます。

Copilot がファイアウォールによってブロックされた要求を行おうとすると、pull request の本文 (Copilot が issue の割り当てに応答している場合) またはコメント (Copilot がコメントに応答している場合) に警告が追加されます。 警告には、ブロックされたアドレスと要求を行おうとしたコマンドが表示されます。

![ファイアウォールによってブロックされたことに関する Copilot からの警告のスクリーンショット。](https://docs.github.com/assets/cb-121588/images/help/copilot/coding-agent/firewall-warning.png)

詳しくは、「[Customizing or disabling the firewall for Copilot coding agent](https://docs.github.com/ja/copilot/customizing-copilot/customizing-or-disabling-the-firewall-for-copilot-coding-agent)」をご覧ください。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot#there-is-a-warning-from--data-variablesproductprodname_copilot--about-the-firewall)

-   [Best practices for using Copilot to work on tasks](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/best-practices-for-using-copilot-to-work-on-tasks)
-   [Copilot コーディング エージェントの開発環境のカスタマイズ](https://docs.github.com/ja/copilot/customizing-copilot/customizing-the-development-environment-for-copilot-coding-agent)