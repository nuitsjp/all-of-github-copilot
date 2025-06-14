GitHub Copilot は、コードをレビューしてフィードバックを提供できます。 可能であれば、Copilot のフィードバックには、2 回のクリックで適用できる推奨される変更が含まれています。

Visual Studio Code の Copilot コード レビュー は、次の 2 種類のレビューをサポートしています。

-   **選択内容をレビューする:** コードを範囲選択し、最初のレビューを依頼します
-   **変更のレビュー:** すべての変更について詳細なレビューを依頼します

次の表は、2 種類のレビューの現在の機能と利用可能状況をまとめたものです。

|  | 選択のレビュー | 変更の確認 |
| --- | --- | --- |
| 利用可能 | Visual Studio Code | Visual Studio Code と GitHub Web サイト |
| Premium/Standard 機能 | 標準機能はすべての Copilot サブスクライバーが使用可能 | Premium 機能。 Copilot Pro、Copilot Pro+、Copilot Business、Copilot Enterprise プランで使用できます。 1 人あたりの月間クォータが適用されます。 |
| 説明 | フィードバックと提案を含む、コードの強調表示されたセクションの初期レビュー | すべての変更の詳細なレビュー |
| サポートされている言語 | すべて | すべて |
| カスタム コーディング ガイドラインのサポート | いいえ | はい。「[コーディング ガイドラインを使用した Copilot のレビューのカスタマイズ](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#customizing-copilots-reviews-with-coding-guidelines)」を参照してください |

### [コード レビューの月間クォータ](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#code-review-monthly-quota)

Copilot コード レビュー の種類である**変更レビュー**は、1 人あたりの月間クォータを使用する Premium 機能です。

メモ

Premium リクエストの課金は近日中に始まります。 それまでは、Premium リクエストを追加しても課金されずに、Copilot コード レビュー を引き続き使用できます。 最新の開始日については、「[Premium リクエストについて](https://docs.github.com/ja/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests)」を参照してください。

pull request をレビューするために Copilot を割り当てると、Copilot が pull request にコメントを投稿するたびに、1 つの Premium リクエストが月間クォータから差し引かれます。 「[Premium リクエストについて](https://docs.github.com/ja/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests)」を参照してください。

リポジトリがすべての新しい pull request についてコード レビューを Copilot に自動的に要求するように構成されている場合、Premium リクエストの使用量は pull request 作成者のクォータに適用されます。 pull request が GitHub Actions またはボットによって作成された場合、ワークフローをトリガーしたユーザー (特定できる場合)、または指定された課金所有者に使用量が適用されます。

月間クォータに達すると、Copilot プランをアップグレードするか追加の Premium リクエストを有効にしない限り、クォータがリセットされるまで Copilot のコード レビューを受け取ることができません。

以下の手順では、Visual Studio Code で Copilot コード レビュー を使う方法について説明します。 その他の一般的なコーディング環境の説明を確認するには、ページの上部にあるツール スイッチャーを使います。

メモ

Copilot コード レビュー は、GitHub Copilot Chat 拡張機能のバージョン 0.22 以降をインストールした Visual Studio Code でのみ使用できます。

### [コードの選択のレビュー](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#customizing--data-variablesproductprodname_copilot_short-s-reviews-with-coding-guidelines)

Visual Studio Code で強調表示されているコードの選択の初期レビューを要求できます。

1.  Visual Studio Code で、レビューするコードを選択します。
    
2.  VS Code Command Palette を開きます。
    
    -   Mac の場合:
        -   Shift+Command+P キーを使用します。
    -   Windows または Linux の場合:
        -   Ctrl+Shift+P キーを使用します。
3.  コマンド パレットで、**\[GitHub Copilot: Review and Comment\]** を検索して選びます。
    
    ![[GitHub Copilot: Review and Comment] コマンドが選ばれている Visual Studio Code のコマンド パレットのスクリーンショット。](https://docs.github.com/assets/cb-42682/images/help/copilot/vsc-review-and-comment.png)
    
4.  Copilot によって変更のレビューが行われるまで待ちます。 通常、これにかかる時間は 30 秒未満です。
    
    ![Copilot が Visual Studio Code でレビューを実行しているときの進行状況インジケーターのスクリーンショット。](https://docs.github.com/assets/cb-12269/images/help/copilot/code-review/vscode-review-progress@2x.png)
    
5.  Copilot にコメントがある場合は、ファイル内のインラインと **\[Problems\]** タブで示されます。
    
    ![Visual Studio Code での Copilot からのコメントのスクリーンショット。](https://docs.github.com/assets/cb-73469/images/help/copilot/code-review/vscode-comment@2x.png)
    

### [変更を確認する](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#reviewing-a-selection-of-code)

Visual Studio Code でステージされた変更またはステージされていない変更のレビューを要求できます。

1.  VS Code で、**\[Source Control\]** タブに切り替えます。
    
2.  ステージされていない変更のレビューを依頼するには、サイドバーの **\[Changes\]** にマウス ポインターを合わせて、 **Copilot コード レビュー - \[Changes\]** ボタンをクリックします。
    
    ![Visual Studio Code の [Copilot コード レビュー - Changes] ボタンのスクリーンショット。 コード レビュー ボタンが濃いオレンジ色の枠線で囲まれています。](https://docs.github.com/assets/cb-20176/images/help/copilot/code-review/vscode-review-button@2x.png)
    
3.  ステージされている変更のレビューを依頼するには、サイドバーの **\[Staged Changes\]** にマウス ポインターを合わせて、 **Copilot コード レビュー - \[Staged Changes\]** ボタンをクリックします。
    
4.  Copilot によって変更のレビューが行われるまで待ちます。 通常、これにかかる時間は 30 秒未満です。
    
    ![Copilot が Visual Studio Code でレビューを実行しているときの進行状況インジケーターのスクリーンショット。](https://docs.github.com/assets/cb-12269/images/help/copilot/code-review/vscode-review-progress@2x.png)
    
5.  Copilot にコメントがある場合は、ファイル内のインラインと **\[Problems\]** タブで示されます。
    
    ![Visual Studio Code での Copilot からのコメントのスクリーンショット。](https://docs.github.com/assets/cb-73469/images/help/copilot/code-review/vscode-comment@2x.png)
    

## [Copilot によって提供される提案された変更の処理](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#copilot-%E3%81%AB%E3%82%88%E3%81%A3%E3%81%A6%E6%8F%90%E4%BE%9B%E3%81%95%E3%82%8C%E3%82%8B%E6%8F%90%E6%A1%88%E3%81%95%E3%82%8C%E3%81%9F%E5%A4%89%E6%9B%B4%E3%81%AE%E5%87%A6%E7%90%86-1)

可能であれば、Copilot のフィードバックには、1 回のクリックで適用できる推奨される変更が含まれています。

![推奨される変更を含む Visual Studio Code での Copilot からのコメントのスクリーンショット。](https://docs.github.com/assets/cb-73469/images/help/copilot/code-review/vscode-comment@2x.png)

変更に問題がない場合は、**\[Apply and Go To Next\]** ボタンをクリックして、Copilot からの提案を受け入れることができます。 適用した変更は自動的にはコミットされません。

Copilot が提案する変更を適用しない場合は、**\[Discard and Go to Next\]** ボタンをクリックします。

## [Copilot のレビューに対するフィードバックの提供](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#copilot-%E3%81%AE%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%81%AB%E5%AF%BE%E3%81%99%E3%82%8B%E3%83%95%E3%82%A3%E3%83%BC%E3%83%89%E3%83%90%E3%83%83%E3%82%AF%E3%81%AE%E6%8F%90%E4%BE%9B-1)

Copilot のコメントに対するフィードバックは、各コメント内で直接提供できます。 この情報は、製品と Copilot の提案の品質の向上に使われます。

フィードバックを提供するには、コメントをポイントして、サムアップまたはサムダウン ボタンをクリックします。

![フィードバック ボタンが表示されている Visual Studio Code での Copilot からのコメントのスクリーンショット。 ボタンは濃いオレンジ色の枠線で囲まれています。](https://docs.github.com/assets/cb-55468/images/help/copilot/code-review/vscode-comment-feedback@2x.png)

## [コーディング ガイドラインを使用した Copilot のレビューのカスタマイズ](https://docs.github.com/ja/copilot/using-github-copilot/code-review/using-copilot-code-review#%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0-%E3%82%AC%E3%82%A4%E3%83%89%E3%83%A9%E3%82%A4%E3%83%B3%E3%82%92%E4%BD%BF%E7%94%A8%E3%81%97%E3%81%9F-copilot-%E3%81%AE%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%81%AE%E3%82%AB%E3%82%B9%E3%82%BF%E3%83%9E%E3%82%A4%E3%82%BA-1)

メモ

カスタム コーディング ガイドライン機能は、Copilot Enterprise プランでのみ利用でき、現在は一部のお客様に限定されています。

Visual Studio Code または GitHub Web サイトで Copilot コード レビュー を使って変更をレビューする場合は、自然言語で記述されたカスタム コーディング ガイドラインを使って Copilot のレビューをカスタマイズできます。 Copilot は、コードをレビューするときにそのコーディング ガイドラインに基づいてフィードバックを提供します。 詳しくは、「[GitHub Copilot コード レビューのコーディング ガイドラインの構成](https://docs.github.com/ja/copilot/using-github-copilot/code-review/configuring-coding-guidelines)」をご覧ください。

コーディング ガイドラインに基づいて生成されたコメントには、そのソースを明確に示すメッセージが含まれます。