# Copilot サポート技術情報の管理 - GitHub Enterprise Cloud Docs

# Copilot サポート技術情報の管理

Organization 所有者は、1 つまたは複数のリポジトリにまたがる Markdown ドキュメントを 1 つにまとめたナレッジ ベースを作成できます。また、organization メンバーはそのナレッジ ベースを Copilot Chat in GitHub のコンテキストとして使用できます。

## この機能を使用できるユーザーについて

Copilot Enterprise プランを所有する organization

## この記事の内容

ヒント

Copilot のコンテキストをより柔軟に整理したい場合は、Copilot Spaces も試すことをお勧めします。

スペース を使うと、コードとフリーテキスト コンテンツ (トランスクリプトや仕様など) を組み合わせることができます。また、organization 所有者だけでなく、すべての Copilot ユーザーが作成できます。 これらは、より焦点を絞った、またはタスク固有のユース ケースに適した選択肢です。 「[Copilot Spaces を使用したコンテキストの整理と共有について](/ja/enterprise-cloud@latest/copilot/using-github-copilot/copilot-spaces/about-organizing-and-sharing-context-with-copilot-spaces)」を参照してください。

## [ナレッジ べースについて](#about-knowledge-bases)

組織の所有者は、1 つまたは複数のリポジトリにまたがる Markdown ドキュメントを 1 つにまとめたサポート技術情報を作成できます。 Copilot Chat in GitHub、Copilot Chat in Visual Studio Code、Copilot Chat in Visual Studio の場合、organization メンバーは、そのナレッジ ベースをコンテキストとして指定できます。

ナレッジ ベースを選択した状態で GitHub Copilot Chat で質問すると、GitHub Copilot はナレッジ ベースで関連情報を検索し、回答を合成します。

Copilot Chat でナレッジ ベースを使用する方法の詳細については、「[GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/copilot-chat-in-github/using-github-copilot-chat-in-githubcom#asking-a-question-about-a-knowledge-base)」と「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/copilot-chat-in-ides/using-github-copilot-chat-in-your-ide#asking-a-question-about-a-knowledge-base-in-github-copilot-chat)」を参照してください。

## ["ナレッジ ベースを作成する"](#ナレッジ-ベースを作成する)

1 つのリポジトリまたは選択したリポジトリからナレッジ ベースを作成できます。 ナレッジ ベースを作成するには、パブリック、プライベート、または内部リポジトリを使用します。

作成したナレッジ ベースには、Copilot Enterprise プランをお使いのすべての organization メンバーがアクセスできます。 Organization メンバーが GitHub Copilot Chat のコンテキストとしてナレッジ ベースを使用する場合、回答では、organization メンバーが読み取りアクセスを持つリポジトリからのデータのみが使用されます。

1.  GitHub の右上隅でプロフィール写真を選んでから、 **\[Your organizations\]** をクリックします。
    
2.  組織の隣の **\[設定\]** をクリックします。
    
3.  左側のサイドバーで、 **\[Copilot\]** をクリックしてから、**\[Knowledge bases\]** をクリックします。
    
4.  \[サポート技術情報\] の右側にある **\[新規サポート技術情報\]** をクリックします。
    
5.  \[名前\] フィールドに、ナレッジ ベースの一意の名前を入力します。 必要に応じて、\[説明\] フィールドにナレッジ ベースの説明を追加できます。
    
    ![[新規サポート技術情報] ページのスクリーンショット。](/assets/cb-42605/images/help/copilot/copilot-create-knowledge-base-page.png)
    
6.  \[コンテンツ\] で、使用可能なリポジトリの完全な一覧を表示するには、**\[リポジトリの選択\]** をクリックします。
    
    ![[リポジトリの選択] ページのスクリーンショット。 [リポジトリの選択] ページが濃いオレンジ色の枠線で強調表示されています。](/assets/cb-25498/images/help/copilot/copilot-select-repositories-button.png)
    
7.  1 つまたは複数のリポジトリを選択するには、リポジトリ名の横にあるチェックボックスをクリックします。 リポジトリの選択が完了したら、**\[適用\]** をクリックします。
    
    ![[リポジトリの選択] ページのスクリーンショット。](/assets/cb-64640/images/help/copilot/copilot-select-repositories-page.png)
    
8.  必要に応じて、選択したリポジトリ内の特定のパスを検索用に指定できます。 サポート技術情報を使用して検索を実行すると、指定されたパスにあるファイルのみが結果に含まれます。 リポジトリ パスの指定の詳細については、「[GitHub Code Search の構文について](/ja/enterprise-cloud@latest/search-github/github-code-search/understanding-github-code-search-syntax#path-qualifier)」を参照してください
    
    -   **\[ファイル パスの編集\]** をクリックします。
    
    ![選択したリポジトリの一覧のスクリーンショット。 [ファイル パスの編集] リンクが濃いオレンジ色の枠線で強調表示されます。](/assets/cb-17083/images/help/copilot/copilot-select-paths-button.png)
    
    -   ナレッジ ベースに含めるパスを 1 行に 1 つずつ入力します。 終了したら、**\[適用\]** をクリックします。
9.  **\[ナレッジ ベースを作成する\]** をクリックします。
    

## [ナレッジ ベースの更新](#updating-a-knowledge-base)

組織の所有者は、組織内で作成したナレッジ ベースを更新できます。

1.  GitHub の右上隅でプロフィール写真を選んでから、 **\[Your organizations\]** をクリックします。
    
2.  組織の隣の **\[設定\]** をクリックします。
    
3.  左側のサイドバーで、 **\[Copilot\]** をクリックしてから、**\[Knowledge bases\]** をクリックします。
    
4.  編集するナレッジ ベースの右側にある をクリックします。
    
5.  ナレッジ ベースに必要な変更を加えます。
    
6.  **\[ナレッジ ベースを更新する\]** をクリックします。
    

## [ナレッジ ベースの削除](#deleting-a-knowledge-base)

組織の所有者は、組織内で作成したナレッジ ベースを削除できます。

1.  GitHub の右上隅でプロフィール写真を選んでから、 **\[Your organizations\]** をクリックします。
    
2.  組織の隣の **\[設定\]** をクリックします。
    
3.  左側のサイドバーで、 **\[Copilot\]** をクリックしてから、**\[Knowledge bases\]** をクリックします。
    
4.  削除するナレッジ ベースの右側にある をクリックします。
    
5.  \[削除の確認\] ダイアログ ボックスで情報を確認し、**\[削除\]** をクリックします。