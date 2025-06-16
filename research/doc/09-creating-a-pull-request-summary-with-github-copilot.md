# GitHub Copilot で pull request の概要を作成する - GitHub Docs

# GitHub Copilot で pull request の概要を作成する

pull request の説明で概要を生成することも、コメントとして生成することもできます。

## この機能を使用できるユーザーについて

この機能は、GitHub Copilot Free では使用できません。

## この記事の内容

## [Copilot pull requestの要約 について](#copilot-pull-requestの要約-について)

GitHub Copilot を使用して、GitHub に対する pull request の概要を生成できます。 概要を使用すると、レビュー担当者に変更を把握してもらったり、レビューしている pull request の変更をすばやく把握したりするのに役立ちます。

GitHub Copilot は pull request をスキャンし、変更の概要を文章で示し、影響を受けるファイルの変更の箇条書きリストを出力します。 次の場所に概要を生成できます。

-   作成する新しい pull request の説明の中
-   既存の pull request の説明の中（開始コメントの編集による）
-   pull request のメイン タイムラインに関するコメント内

Copilot pull requestの要約 の詳細と、この機能を最も効果的に使用する方法については、「[GitHub Copilot pull request の責任ある使用の概要](/ja/copilot/github-copilot-enterprise/copilot-pull-request-summaries/about-copilot-pull-request-summaries)」を参照してください。

## [pull request の概要を作成する](#creating-a-summary-for-a-pull-request)

1.  GitHub で、pull request を作成するか、既存の pull request に移動します。
    
    メモ
    
    GitHub Copilot では、pull request の説明に含まれる既存の内容は考慮されないため、説明を空白にしてから開始するのがベストです。
    
2.  pull request の概要を追加するテキスト フィールドに移動します。
    
    -   新しい pull request を作成する場合は、\[説明の追加\] フィールドを使用します。
    -   既存の pull request に説明を追加する場合は、開始コメントを編集します。
    -   概要をコメントとして追加する場合は、pull request ページの下部にある \[コメントの追加\] セクションに移動します。
3.  テキスト フィールドのヘッダーで、 を選択し、**\[概要\]** をクリックします。
    
    ![pull request 作成のフォームのスクリーンショット。 [Copilot] アイコンが強調表示され、[概要] コマンドが表示されたボックスが表示されています。](/assets/cb-42638/images/help/copilot/copilot-description-suggestion.png)
    
4.  GitHub Copilot が概要を生成するまで待ってから、結果を慎重にチェックします。
    
5.  オプションとして、あなたの企業や組織の設定によっては、テキスト ボックスの下にある \[Copilot のパフォーマンスはいかがでしたか?\] の横に表示されるボタンのどちらかをクリックすると、概要に関するフィードバックを提供できます。
    
    ![pull request コメントの下部のスクリーンショット。 フィードバック アイコン (サムアップとサムダウン) は、濃いオレンジ色の枠線で強調表示されています。](/assets/cb-41181/images/help/copilot/copilot-summary-feedback.png)
    
    概要を適切か不適切か評価した後、表示されるリンクをクリックすると、フィードバックを書き込むことができます。
    
6.  pull request を閲覧するユーザーに役立つコンテキストを追加します。
    
7.  説明に問題がない場合は、新しい pull request で **\[pull request の作成\]** をクリックし、既存の説明を編集する場合は、**\[コメントの更新\]** をクリックします。