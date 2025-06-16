# GitHub Copilot 用に個人用カスタム命令を追加する - GitHub Docs

# GitHub Copilot 用に個人用カスタム命令を追加する

個人の好みに合わせて GitHub Copilot Chat の応答をカスタマイズします。

## この記事の内容

メモ

現在、個人用カスタム命令は GitHub Copilot Chat in GitHub でのみサポートされています。

GitHub Copilot Chat の応答のカスタマイズに使用できる方法の概要については、「[About customizing GitHub Copilot Chat responses](/ja/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses?tool=webui)」をご覧ください。

## [GitHub Copilot Chat に対する個人のカスタム指示について](#github-copilot-chat-に対する個人のカスタム指示について)

GitHub Copilot Chat にカスタム指示を追加し、GitHub Web サイトでの会話全体で、個人の好みに合わせてカスタマイズされたチャットの応答を受け取ることができます。 たとえば、Copilot Chat に常に優先言語または特定のスタイルで応答させることができます。 追加できる命令の例を次に示します。

-   `Always respond in Spanish.`
-   `Your style is a helpful colleague, minimize explanations but provide enough context to understand the code.`
-   `Always provide examples in TypeScript.`

メモ

-   It is possible for multiple types of custom instructions to apply to a conversation. Personal instructions take the highest priority, followed by repository instructions, with organization instructions prioritized last. However, all sets of relevant instructions are still combined and provided to Copilot Chat.
-   Whenever possible, you should avoid providing conflicting sets of instructions. If you are concerned about response quality, you can also choose to temporarily disable repository instructions. See [GitHub Copilot のリポジトリ カスタム命令を追加する](/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot?tool=webui#enabling-or-disabling-repository-custom-instructions).

## [個人用カスタム命令を追加する](#adding-personal-custom-instructions)

個人のカスタム命令は、チャット パネルまたはイマーシブ モードで追加できます。 両方のモードに同じ命令が適用されます。

1.  GitHub の任意のページの右上で、次のいずれかを行います。
    
    -   アイコンをクリックして、ページ全体に表示されるイマーシブ モードの Copilot Chat を開きます。
    -   アイコンの横にある をクリックしてから、**\[Assistive\]** をクリックして、Copilot Chat パネルを開きます。
2.  \[Chat\] パネルまたはイマーシブ ページの右上にある ドロップダウン メニューを選び、**\[Personal instructions\]** をクリックします。
    
3.  自然言語の命令をテキスト ボックスに追加します。
    
    命令は任意の形式で記述できます。 たとえば、ひとまとまりのテキスト ブロックとして、1 つずつ改行して、または空行で区切って記述することができます。
    
4.  必要に応じて、 をクリックして、一般的な指示に使用できるテンプレートを表示します。 \[Communication\] などのボックスのいずれかをクリックすると、ユーザー設定に置き換えることができる `{format}` などのプレースホルダーを含む指示がテキスト ボックスに追加されます。
    
5.  **\[保存\]** をクリックします。 命令は現在アクティブであり、変更または削除するまでアクティブなままになります。
    

実際の指示を確認するには、[https://github.com/copilot](https://github.com/copilot) に移動して会話を始めてください。

個人用のカスタム指示をうまく追加できましたか?

[はい](https://docs.github.io/success-test/yes.html) [いいえ](https://docs.github.io/success-test/no.html)