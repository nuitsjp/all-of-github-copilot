# Copilot を使って pull request に関する作業を支援する - GitHub Docs

# Copilot を使って pull request に関する作業を支援する

Copilot Workspace を使って、反復処理や検証を行い、提案された変更をコードに統合することができます。

## この機能を使用できるユーザーについて

この機能は、GitHub Copilot Free では使用できません。

## この記事の内容

メモ

Copilot Workspace は限定的な パブリック プレビュー 段階です。 現在、このプレビューに参加する順番待ちリストは受け付けていません。

## [Copilot を使って pull request に関する作業を支援する方法について](#copilot-を使って-pull-request-に関する作業を支援する方法について)

pull request を作成した後、GitHub の Web サイト上で PR の作業を続けることができます。 この記事では、Copilot Workspace について説明します。これには、次を実行するための Copilot 対応の環境が用意されています。

-   pull request の**調整**
-   変更の**検証**
-   レビュー担当者からの提案の**統合**

Copilot Workspace を使えば、pull request の作成からマージまで、pull request に関する作業を 1 か所で (GitHub で) 行うことができます。

Copilot を他の方法で pull request に役立てることもできます。 それらについては、別の記事で説明します。 Copilot で次のことができます。

-   Pull request の要約を自動的に作成 - 「[GitHub Copilot で pull request の概要を作成する](/ja/copilot/using-github-copilot/using-github-copilot-for-pull-requests/creating-a-pull-request-summary-with-github-copilot)」を参照してください。
-   Pull request を自動的にレビュー - 「[GitHub Copilot コード レビューの使用](/ja/copilot/using-github-copilot/code-review/using-copilot-code-review)」を参照してください。
-   CodeQL code scanning によって特定されたコーディングの問題の修正を提案 - 「[コード スキャンに対する Copilot Autofix の責任ある使用](/ja/code-security/code-scanning/managing-code-scanning-alerts/responsible-use-autofix-code-scanning)」を参照してください。

### [Copilot Workspace の利点](#copilot-workspace-の利点)

Copilot Workspace:

-   GitHub Web サイトと IDE 間で切り替えを行わずに pull request に関する作業を行うことができます。
-   Copilot コード レビューや Copilot Autofix、または人間のレビュー担当者によるレビューからのコーディングの提案を、簡単に表示、テスト、変更、適用できます。
-   Copilot コード補完候補を GitHub で利用できます。 以前は、IDE でしか利用できませんでした。
-   ブラウザー ベースのエディター内で、pull request によって変更されるファイルの一覧を表示できます。リポジトリ全体から任意のファイルを検索して編集することもできます。
-   GitHub 上の ワークスペース 環境から直接コードをビルド、テスト、実行できます。

## [前提条件](#prerequisites)

Copilot Workspace を使うには、GitHub Web サイト上の既存の pull request と、次のいずれかが必要です。

-   順番待ちリスト (現在は受け付けていません) からこのパブリック プレビューにアクセスする。
-   GitHub Team プランまたは GitHub Enterprise プランの organization が所有するプライベート リポジトリ上の GitHub Advanced Security (GHAS) 機能へのアクセス。 「[GitHub Advanced Security について](/ja/get-started/learning-about-github/about-github-advanced-security)」を参照してください。

Copilot Workspace にアクセスしなくても、pull request 内のファイルを編集できます。それには、**\[Files changed\]** タブに移動し、編集するファイルの横にある省略記号 (**\[...\]**) をクリックして、**\[Edit file\]** をクリックします。

## [pull request 内のファイルを編集する](#editing-files-in-a-pull-request)

Copilot Workspace で pull request に関する作業を行うには:

1.  Pull request のメイン ページの右側にある **\[ Open in ワークスペース\]** ボタンをクリックします。
    
    Copilot Workspace が開き、pull request の概要が表示されます。
    
    Copilot Workspace ウィンドウの左側には、pull request によって変更されるファイルの一覧が表示されます。
    
    ![Copilot Workspace の左側に表示される、PR 内のファイル一覧のスクリーンショット。](/assets/cb-97851/images/help/copilot/workspace-files-in-pr.png)
    
2.  現在この pull request によって変更されていないファイルを操作するには、**\[Files in this pull request\]** をクリックし、ドロップダウンから **\[All files in this repository\]** を選択します。
    
3.  一覧内のファイルをクリックして、ワークスペース エディターでファイルを開きます。
    
    ファイルは diff ビューで表示されます。 このビューは必要に応じて変更できます。 この記事で後述する「[ワークスペース オプションの変更](#changing-the-workspace-options)」を参照してください。
    
    複数のファイルを開いて変更してから、変更をコミットできます。
    
4.  変更が完了したら、**\[Review and commit\]** をクリックします。
    
    **\[Commit changes\]** パネルが表示されます。 行った変更に基づいて、Copilot がコミット メッセージを自動生成します。 必要に応じて、このメッセージを編集したり、詳しい説明を追加したりできます。
    
    ![[Commit changes] パネルのスクリーンショット。自動生成されたコミット メッセージと変更された 3 つのファイルが表示されています。](/assets/cb-72020/images/help/copilot/workspace-commit-changes.png)
    
    パネルには、変更したファイルが一覧表示されます。 各ファイルを展開して、行った変更を確認できます。
    
5.  必要に応じて、複数のファイルを編集した後に 1 回のコミットですべての変更をコミットしたくないと思った場合は、変更をコミットしないファイルの横にあるチェック ボックスをオフにします。 **\[Commit changes\]** をクリックすると、それらのファイルに適用した変更は適用されたままですが、コミットはされず、別のコミットで pull request に追加できます。
    
    メモ
    
    ファイルの横にあるチェック ボックスをオフにした場合は、そのファイルの変更には言及しないようにコミット メッセージを書き直す必要があるかもしれません。
    
6.  **\[変更をコミットする\]** をクリックします。
    
    または、**\[Reset all changes\]** をクリックして、ファイルを pull request 内の現在の状態に戻します。ワークスペース エディター パネル内で行った変更内容は失われます。 変更内容のリセットを取り消すことはできません。
    

## [Copilot を使って pull request のコメントに関する作業を行う](#copilot-を使って-pull-request-のコメントに関する作業を行う)

Copilot Workspace を使って pull request のすべてのコメントを 1 つずつ処理してから、1 回のコミットで、行うことにしたすべての変更をコミットできます。

1.  コード変更の提案を含むコメントで、**\[Open in ワークスペース\]** をクリックします。
    
    ![Copilot コード レビュー によるコーディング提案のスクリーンショット。](/assets/cb-119264/images/help/copilot/workspace-copilot-review-suggestion.png)
    
    Copilot Workspace が開き、ワークスペース ウィンドウの右側にある \[Suggestions\] パネルに提案された変更が表示されます。
    
2.  提案された変更を確認し、\[Suggestions\] パネルの下部にある 2 つのボタンのいずれかをクリックします。
    
    -   **\[Apply\]** - 提案された変更に同意する場合。
    -   **\[Dismiss\]** - 提案された変更を行いたくない場合。
3.  pull request に複数のコメントがある場合は、\[Suggestions\] パネルの下部にある矢印 **\[>\]** をクリックすれば、次のコメントを処理できます。
    
    ![[Suggestions] パネルのスクリーンショット。矢印 [>] と [Dismiss] ボタン、[Apply] ボタンが表示されています。](/assets/cb-23421/images/help/copilot/workspace-next-comment.png)
    
4.  必要に応じて、pull request のすべてのコメントを一覧表示するには、\[Suggestions\] パネルの左上の戻る矢印をクリックします。
    
    ![左上の戻る矢印が表示されている [Suggestions] パネルのスクリーンショット。](/assets/cb-76575/images/help/copilot/workspace-all-comments.png)
    
    同意した提案と却下した提案は、\[applied\] と \[dismissed\] のドロップダウンに表示されます。これにより、まだ処理していない提案はどれか簡単にわかります。
    
    ![[Suggestions] パネルのコメントの一覧を示すスクリーンショット。 アクションを待っているものが 2 つあります。 その下には、[1 applied] と [1 dismissed] というドロップダウン リンクがあります。](/assets/cb-43119/images/help/copilot/workspace-applied-dismissed.png)
    
5.  提案された変更のレビューが完了したら、**\[Review and commit\]** をクリックします。
    
6.  必要に応じて、適用した変更のすべてを 1 回のコミットでコミットしたくないと思った場合は、変更をコミットしないファイルの横にあるチェック ボックスをオフにします。 **\[Commit changes\]** をクリックすると、それらのファイルに適用した変更は適用されたままですが、コミットはされず、別のコミットで pull request に追加できます。
    
7.  **\[変更をコミットする\]** をクリックします。
    
    または、**\[Reset all changes\]** をクリックして提案を最初の状態に戻します。行った同意または却下の選択は失われ、ワークスペース エディター パネルで直接ファイルを編集して行った変更内容も失われます。 変更内容のリセットを取り消すことはできません。
    

## [pull request について Copilot とチャットする](#pull-request-について-copilot-とチャットする)

1.  ワークスペース ウィンドウの上部にある ボタンをクリックします。
    
2.  Copilot パネルの下部にある \[Ask Copilot\] ボックスに質問を入力して、Enter を押します。
    
    次に関する質問をすることができます。
    
    -   **現在表示されているファイル** - 例:「このファイルを改善するにはどうすればよいですか?」
    -   **pull request 全体** - 例:「この pull request で参照されるフレームワークは何ですか?」
    -   **プログラミングに関する一般的なトピック** - 例:「Ruby の最新バージョンは何ですか?」
    
    詳しくは、「[GitHub で GitHub Copilot に質問をする](/ja/copilot/using-github-copilot/asking-github-copilot-questions-in-githubcom)」をご覧ください。
    

メモ

現在、Copilot Workspace の パブリック プレビュー 段階では使用できない Copilot Chat 機能があります。

## [変更を検証する](#verifying-your-changes)

ワークスペース には、組み込みのターミナルと、コードをビルド、実行、テストするための簡単な方法が用意されています。

### [ターミナルを開く](#opening-the-terminal)

ターミナルを開くには、ワークスペース エディター パネルの右上にある をクリックします。

メモ

ターミナルを使うには、codespace が実行中である必要があります。 アイコンが表示されないときは、codespace が起動するまで数秒待つ必要がある場合があります。

### [ターミナル コマンドの実行](#running-terminal-commands)

ターミナルに直接コマンドを入力することも、クイック コマンドを使ってよく使われるコマンドを数クリックで実行することもできます。

#### [個人用のクイック コマンドを構成する](#configuring-personal-quick-commands)

Copilot Workspace で特定のプロジェクトに取り組むときに使用できる、**Build**、**Run**、**Test** コマンドを構成できます。 リポジトリに対して既にコマンドが構成されている場合は、個人で使うための代わりのコマンドでそれらを置き換えることができます。

1.  ワークスペース ウィンドウの上部にある **\[ Configure\]** をクリックします。
    
    **Build**、**Run**、**Test** のクイック コマンドが既に定義されている場合は、**\[ Configure\]** の代わりに **\[ Build\]** ボタンが表示されます。 **\[ Build\]** ボタンの横にあるドロップダウン矢印をクリックしてから、ドロップダウン メニューの **\[ Configure\]** をクリックします。
    
    ![[Commands] ドロップダウン メニューのスクリーンショット。[Configure] オプションが濃いオレンジ色の枠線で強調表示されています。](/assets/cb-30499/images/help/copilot/workspace-configure-commands.png)
    
2.  \[Configure commands\] ダイアログで、**Build**、**Run**、**Test** のオプションに使いたいコマンドを入力します。
    
3.  **\[保存\]** をクリックします。
    

#### [リポジトリのクイック コマンドを構成する](#configuring-quick-commands-for-your-repository)

Copilot Workspace を使って自分のリポジトリの pull request に関する作業を行う全員に対して、既定の **Build**、**Run**、**Test** コマンドを定義できます。

1.  リポジトリのルートに `.devcontainer/devcontainer.json` という名前のファイルを作成するか、それを編集します。
    
    メモ
    
    `.devcontainer/devcontainer.json` ファイルは、リポジトリ用に作成される codespace の構成ファイルです。 詳しくは、「[開発コンテナーの概要](/ja/enterprise-cloud@latest/codespaces/setting-up-your-project-for-codespaces/adding-a-dev-container-configuration/introduction-to-dev-containers#devcontainerjson)」をご覧ください。
    
2.  次のように `commands` セクションを追加します。以下のコマンドの例は、そのリポジトリで作業するユーザーが使うべきコマンドに置き換えてください。
    
    ```json
    {
      "commands": {
        "Build": "make",
        "Run": "./bin/start",
        "Test": "make test"
      }
    }
    ```
    
3.  **\[保存\]** をクリックします。
    

#### [ワークスペース クイック コマンドの使用](#ワークスペース-クイック-コマンドの使用)

1.  定義済みクイック コマンドの最初のコマンド (通常は **Build**) を実行するには、ワークスペース ウィンドウの上部にあるボタンをクリックします。
    
2.  別のクイック コマンドを実行するには、ボタンの横にあるドロップダウン矢印をクリックし、ドロップダウン メニューから実行したいコマンドをクリックします。
    
    ![[Commands] ドロップダウン メニューのスクリーンショット。[Run] オプションが濃いオレンジ色の枠線で強調表示されています。](/assets/cb-30670/images/help/copilot/workspace-run-command.png)
    
3.  **\[Run\]** をクリックした後、プロセスの実行中に、ドロップダウン矢印をもう一度クリックして、プロセスを停止または再起動するオプション、または実行コマンドの出力を表示するオプションを選択できます。
    
    ![実行中のアプリケーションのドロップダウン メニューのスクリーンショット。[Stop] オプションが濃いオレンジ色の枠線で強調表示されています。](/assets/cb-26856/images/help/copilot/workspace-stop-command.png)
    

#### [Web アプリケーションのプレビュー](#previewing-a-web-application)

実行コマンドで Web サーバーが起動された場合は、ワークスペース ウィンドウの上部に \[\] ボタンが表示されます。

このボタンをクリックすると、ブラウザーの新しいタブでサーバーの出力をプレビューできます。

## [ワークスペース オプションの変更](#ワークスペース-オプションの変更)

Copilot Workspace でファイルの表示方法を変更できます。

### [diff ビューを変更する](#changing-the-diff-view)

1.  ワークスペース エディター パネルの右上にある比較ピッカー アイコン () をクリックします。
    
2.  ビュー オプションを選択します。
    
    -   **Unified** - 1 つのビューに変更を表示します。追加された線は緑色で強調表示され、削除された行は赤で強調表示されます。
    -   **Split** - 分割ビューに変更を表示します。元のファイルは左側に、新しいファイルは右側に表示されます。
    -   **Hidden** - この pull request 内のファイルの現在の状態を表示し、PR が行う変更は表示しません。

### [長い行の折り返し](#wrapping-long-lines)

1.  ワークスペース エディター パネルの右上にある省略記号 (**\[...\]**) をクリックします。
2.  **\[Wrap lines\]** をクリックして、行の折り返しのオンとオフを切り替えます。