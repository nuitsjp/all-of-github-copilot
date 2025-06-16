GitHub の issue を Copilot に割り当てたり、pull request の作成を Copilot に依頼したりできます。

## この機能を使用できるユーザーについて

Copilot コーディング エージェント は、有効になっているリポジトリの GitHub Copilot Pro+ および GitHub Copilot Enterprise プランで使用できます。  
[Sign up for Copilot](https://github.com/features/copilot/plans?ref_cta=Copilot+plans+signup&ref_loc=about+assigning+issues+to+copilot&ref_page=docs)

メモ

Copilot コーディング エージェント is in パブリック プレビュー and subject to change.

## [Copilot コーディング エージェント の概要](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%81%AE%E6%A6%82%E8%A6%81)

Copilot コーディング エージェント を使うと、GitHub Copilot はバックグラウンドで独立して動作し、人間の開発者と同じようにタスクを完了できます。

Copilot で次のことができます。

-   バグの修正
-   増分型の新機能を実装する
-   テストのカバレッジを向上させる
-   ドキュメントを更新する
-   技術的負債に対処する

Copilot への開発タスクの委任は、次のようにして行うことができます。

-   Copilot に issue を割り当てる。 「[Copilot を使用して issue を処理する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/using-copilot-to-work-on-an-issue)」を参照してください。
-   GitHub Copilot Chat を使って、Copilot に pull request の作成を依頼する。 「[Copilot に pull request の作成を依頼する](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/asking-copilot-to-create-a-pull-request)」を参照してください。

Copilot は、ユーザーが指定したプロンプトに基づいて、割り当てられたタスクの基になっているのが issue の説明かチャット メッセージかを評価します。 その後、Copilot は必要な変更を行って pull request を開きます。 Copilot は完了するとユーザーにレビューを要求し、ユーザーは pull request のコメントを使って Copilot に反復処理を依頼できます。

コーディング タスクの作業中、Copilot は、GitHub Actions によって実現される独自の一時的な開発環境にアクセスして、コードの探索、変更の実施、自動的なテストとリンターの実行などを行うことができます。

### [Copilot コーディング エージェント と Visual Studio Code のエージェント モードの比較](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%81%A8-visual-studio-code-%E3%81%AE%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%83%A2%E3%83%BC%E3%83%89%E3%81%AE%E6%AF%94%E8%BC%83)

Copilot コーディング エージェント は、Visual Studio Code で使用できる "エージェント モード" 機能とは異なります。 Copilot コーディング エージェント は、GitHub Actions を利用した環境で自律的に機能し、GitHub の issue または GitHub Copilot Chat プロンプトを通じて割り当てられた開発タスクを完了し、結果を含む pull request を作成することができます。 これに対し、Visual Studio Code のエージェント モードは GitHub Copilot Edits 機能の一部です。そのため、Copilot はローカル開発環境で直接自律的な編集を行うことができます。 エージェント モードの詳細については、「[IDE で GitHub Copilot に質問する](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide?tool=visualstudio#copilot-edits-1)」を参照してください。

### [Copilot コーディング エージェント を使用したソフトウェア開発の合理化](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%82%92%E4%BD%BF%E7%94%A8%E3%81%97%E3%81%9F%E3%82%BD%E3%83%95%E3%83%88%E3%82%A6%E3%82%A7%E3%82%A2%E9%96%8B%E7%99%BA%E3%81%AE%E5%90%88%E7%90%86%E5%8C%96)

タスクを Copilot に割り当てて、ソフトウェア開発ワークフローの機能を強化できます。

たとえば、バックログの簡単な issue に Copilot を割り当てることができます。 これにより、それらに費やす時間を減らし、より複雑な作業や興味深い作業、または高度な創造的思考を必要とする作業にかける時間を増やすことができます。 Copilot を使って、コードベースや製品の品質の向上にはなるものの、ユーザーがより緊急な作業に集中している間バックログに残ってしまうことが多い、"必要ではないがあると助かる" issue の作業を行うことができます。

追加のコーディング リソースとして Copilot を使うと、それを使わなければリソース不足のために実施できない可能性があるタスクを、開始することもできます。 たとえば、コードのリファクタリングやログの追加のための Copilot タスクを委任してから、それを Copilot にすぐに割り当てることができます。

Copilot はタスクを開始でき、ユーザーはそれを引き取って自分で作業を続けることができます。 ユーザーは、新しいプロジェクトのスキャフォールディングの設定のような初期作業を Copilot に割り当てることで、そうしなければそれらの反復タスクに費やしたであろう自分の時間を空けることができます。

### [Copilot コーディング エージェント を使用できるようにする](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%82%92%E4%BD%BF%E7%94%A8%E3%81%A7%E3%81%8D%E3%82%8B%E3%82%88%E3%81%86%E3%81%AB%E3%81%99%E3%82%8B)

タスクを Copilot に割り当てる前に、それを有効にする必要があります。 「[Enabling Copilot coding agent](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/enabling-copilot-coding-agent)」を参照してください。

## [Copilot コーディング エージェント の使用コスト](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%81%AE%E4%BD%BF%E7%94%A8%E3%82%B3%E3%82%B9%E3%83%88)

メモ

Premium リクエストの課金は近日中に始まります。 それまでは、Premium リクエストを追加しても課金されずに、Copilot コーディング エージェント を引き続き使用できます。 最新の開始日については、「[Premium リクエストについて](https://docs.github.com/ja/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests)」をご覧ください。

これはプレビュー機能であり、今後変更される可能性があります。

Copilot コーディング エージェント では、GitHub Actions の分単位の時間と Copilot の Premium リクエストが使われます。

GitHub Actions と Premium リクエストの月間使用許容量の範囲内で、追加費用なしにコーディング タスクの処理を Copilot に依頼できます。

詳しくは、「[GitHub Copilot の課金について](https://docs.github.com/ja/billing/managing-billing-for-your-products/managing-billing-for-github-copilot/about-billing-for-github-copilot#allowance-usage-for-copilot-coding-agent)」をご覧ください。

## [リスクと軽減策](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#risks-and-mitigations)

Copilot コーディング エージェント は、ユーザーのコードにアクセスして変更をリポジトリにプッシュできる自律的なエージェントです。 これには特定のリスクが伴います。 可能な場合は、GitHub によって適切な軽減策が適用されます。

### [リスク: Copilot がコードの変更をユーザーのリポジトリにプッシュできる](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#%E3%83%AA%E3%82%B9%E3%82%AF-copilot-%E3%81%8C%E3%82%B3%E3%83%BC%E3%83%89%E3%81%AE%E5%A4%89%E6%9B%B4%E3%82%92%E3%83%A6%E3%83%BC%E3%82%B6%E3%83%BC%E3%81%AE%E3%83%AA%E3%83%9D%E3%82%B8%E3%83%88%E3%83%AA%E3%81%AB%E3%83%97%E3%83%83%E3%82%B7%E3%83%A5%E3%81%A7%E3%81%8D%E3%82%8B)

このリスクを軽減するため、GitHub は次のことを行います。

-   **タスクを Copilot に割り当てることができるユーザーを制限します。** リポジトリへの書き込みアクセス権限を持つユーザーのみが、Copilot をトリガーして動作させることができます。 書き込みアクセス権限を持たないユーザーからのコメントは、エージェントに対して示されません。
-   **Copilot によって使われるアクセス トークンのアクセス許可を制限します。** `copilot/` で始まるブランチに対してのみプッシュできます。 Copilot は、`main` または `master` ブランチにはプッシュできません。
-   **Copilot の資格情報を制限します。** Copilot は、単純なプッシュ操作のみを実行できます。 `git push` や他の Git コマンドを直接実行することはできません。
-   **GitHub Actions ワークフローの実行を制限します。** Copilot のコードがレビューされて、リポジトリへの書き込みアクセス権限を持つユーザーが **\[Approve and run workflows\]** ボタンをクリックするまで、ワークフローはトリガーされません。 「[Copilot によって作成された pull request をレビューする](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/reviewing-a-pull-request-created-by-copilot)」を参照してください。
-   **Pull request の作成を Copilot に依頼したユーザーがそれを承認できないようにします。** これにより、"必須の承認" ルールとブランチ保護での望ましい制御が維持されます。 「[ルールセットで使用できるルール](https://docs.github.com/ja/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/available-rules-for-rulesets)」を参照してください。

### [リスク: Copilot が機密情報にアクセスできる](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#%E3%83%AA%E3%82%B9%E3%82%AF-copilot-%E3%81%8C%E6%A9%9F%E5%AF%86%E6%83%85%E5%A0%B1%E3%81%AB%E3%82%A2%E3%82%AF%E3%82%BB%E3%82%B9%E3%81%A7%E3%81%8D%E3%82%8B)

Copilot はコードや他の機密情報にアクセスでき、誤って、または悪意のあるユーザー入力のために、それを漏洩する可能性があります。 このリスクを軽減するため、GitHub は次のことを行います。

-   **インターネットへの Copilot のアクセスを制限します。** 「[Customizing or disabling the firewall for Copilot coding agent](https://docs.github.com/ja/copilot/customizing-copilot/customizing-or-disabling-the-firewall-for-copilot-coding-agent)」を参照してください。

### [リスク: プロンプト インジェクションの脆弱性](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#risk-prompt-injection-vulnerabilities)

ユーザーは、Copilot に割り当てられた issue や、Copilot に残されたコメントに、[プロンプト インジェクション](https://genai.owasp.org/llmrisk/llm01-prompt-injection/)の形式で非表示のメッセージを含めることができます。 このリスクを軽減するため、GitHub は次のことを行います。

-   **ユーザー入力を Copilot に渡す前に非表示の文字をフィルター処理します。** たとえば、issue の HTML コメントや pull request のコメントとして入力されたテキストは、Copilot に渡されません。

## [Copilot コーディング エージェント の制限](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%A8%E3%83%BC%E3%82%B8%E3%82%A7%E3%83%B3%E3%83%88-%E3%81%AE%E5%88%B6%E9%99%90)

Copilot コーディング エージェント には、ソフトウェア開発ワークフローおよび他の機能との互換性に一定の制限があります。

### [Copilot のソフトウェア開発ワークフローでの制限](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#copilot-%E3%81%AE%E3%82%BD%E3%83%95%E3%83%88%E3%82%A6%E3%82%A7%E3%82%A2%E9%96%8B%E7%99%BA%E3%83%AF%E3%83%BC%E3%82%AF%E3%83%95%E3%83%AD%E3%83%BC%E3%81%A7%E3%81%AE%E5%88%B6%E9%99%90)

-   **Copilot は、それが pull request を作成しているのと同じリポジトリでのみ変更を行うことができます**。 Copilot は、issue を割り当てられたら、その issue が存在するリポジトリでのみ変更を行うことができます。 さらに、Copilot は、1 つの実行で複数のリポジトリの変更を行うことはできません。
-   **Copilot は、割り当てられた issue と同じリポジトリ内のコンテキストにのみアクセスできます**。 既定では、Copilot MCP サーバーとの統合により、一度に 1 つのリポジトリへのアクセスが Copilot に提供されます。 ただし、ユーザーはさらに広範なアクセスを構成できます。 「[Extending Copilot coding agent with the Model Context Protocol (MCP)](https://docs.github.com/ja/enterprise-cloud@latest/copilot/customizing-copilot/extending-copilot-coding-agent-with-mcp)」を参照してください。
-   **Copilot は、一度に 1 つの pull request しか開けません**。 Copilot は、割り当てられた各タスクを処理するために、pull request を厳密に 1 つだけ開きます。
-   **Copilot は、自分で作成していない既存の pull request の作業を行うことはできません**。 Copilot で既存の pull request に関するフィードバックを提供したい場合は、それをレビュー担当者として追加できます。 「[GitHub Copilot コード レビューの使用](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review)」を参照してください。
-   **Copilot は、常に、リポジトリの既定のブランチから変更を開始します**。 Copilot は、機能ブランチやリリース ブランチなど、他のブランチから分岐することはできません。

### [Copilot と他の機能との互換性に関する制限](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#limitations-in-copilots-compatibility-with-other-features)

-   **Copilot は、そのコミットに署名しません**。 "署名済みコミットの必須化" ルールまたはブランチ保護が有効になっている場合、Copilot の pull request をマージするには、コミット履歴を書き換える必要があります。 「[ルールセットで使用できるルール](https://docs.github.com/ja/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/available-rules-for-rulesets#require-signed-commits)」を参照してください。
-   **Copilot は、セルフホステッド GitHub Actions ランナーでは動作しません**。 Copilot は、GitHub Actions で実行されている独自の開発環境にアクセスでき、GitHub ホステッド ランナーを使う必要があります。 「[Copilot コーディング エージェントの開発環境のカスタマイズ](https://docs.github.com/ja/copilot/customizing-copilot/customizing-the-development-environment-for-copilot-coding-agent#upgrading-to-larger-github-hosted-github-actions-runners)」を参照してください。
-   **Copilot では、内容の除外は考慮されません**。 内容の除外を使うと、管理者は特定のファイルを無視するように Copilot を構成できます。 Copilot コーディング エージェント の使用時には、Copilot はこれらのファイルを無視せず、それを表示および更新できます。 「[GitHub Copilot からのコンテンツの除外](https://docs.github.com/ja/copilot/managing-copilot/configuring-and-auditing-content-exclusion/excluding-content-from-github-copilot)」を参照してください。
-   **Copilot コーディング エージェント は データ所在地付き GitHub Enterprise Cloud** では使用できません。 エージェントは GitHub.com でのみ使用できます。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent/about-assigning-tasks-to-copilot#further-reading)

-   [Coding agent](https://docs.github.com/ja/copilot/using-github-copilot/coding-agent)
-   [GitHub.com での Copilot コーディング エージェントの責任ある使用](https://docs.github.com/ja/copilot/responsible-use-of-github-copilot-features/responsible-use-of-copilot-coding-agent-on-githubcom)
-   [Copilot コーディング エージェントの開発環境のカスタマイズ](https://docs.github.com/ja/copilot/customizing-copilot/customizing-the-development-environment-for-copilot-coding-agent)
-   [Customizing or disabling the firewall for Copilot coding agent](https://docs.github.com/ja/copilot/customizing-copilot/customizing-or-disabling-the-firewall-for-copilot-coding-agent)
-   [Extending Copilot coding agent with the Model Context Protocol (MCP)](https://docs.github.com/ja/copilot/customizing-copilot/extending-copilot-coding-agent-with-mcp)