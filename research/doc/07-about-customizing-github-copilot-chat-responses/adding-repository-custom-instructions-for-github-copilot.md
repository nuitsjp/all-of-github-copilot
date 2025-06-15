Copilot にそれがリポジトリで行う作業に関する追加コンテキストを提供するファイルを、そのリポジトリに作成します。

## [リポジトリ カスタム指示の前提条件](https://docs.github.com/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot#prerequisites-for-repository-custom-instructions)

-   カスタム指示ファイル (以下の手順を参照)。

## [リポジトリのカスタム命令ファイルを作成する](https://docs.github.com/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot#creating-a-repository-custom-instructions-file)

1.  リポジトリのルートに `.github/copilot-instructions.md` という名前のファイルを作成します。
    
    `.github` ディレクトリがまだ存在しない場合は作成します。
    
2.  Markdown 形式で自然言語の指示をファイルに追加します。
    
    指示と指示の間の空白は無視されるため、複数の指示を 1 つの段落に記述することも、1 行に 1 つずつ記述することもでき、読みやすくするために空白行で区切ることもできます。
    

指示の動作を確認するには、[https://github.com/copilot](https://github.com/copilot) に移動し、指示ファイルを含むリポジトリをアタッチして、会話を始めます。

カスタム指示ファイルをリポジトリにうまく追加できましたか?

[はい](https://docs.github.io/success-test/yes.html) [いいえ](https://docs.github.io/success-test/no.html)

## [効果的なリポジトリのカスタム命令を作成する](https://docs.github.com/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot#writing-effective-repository-custom-instructions)

`.github/copilot-instructions.md` ファイルに追加する指示は、ユーザーのチャット質問を補完するコンテキストすなわち関連情報を追加する、短い自己完結型の文章であることが必要です。

リポジトリのサイズと複雑さも考慮する必要があります。 次の種類の指示は、コントリビューターが数人だけの小規模なリポジトリでは機能しますが、大規模で多様なリポジトリの場合、Copilot の他の部分で問題が発生する可能性があります。

-   応答を作成するときに外部リソースを参照するという要求
-   特定のスタイルで回答するという指示
-   常に特定の詳細レベルで応答するという要求

たとえば、次の指示では意図した結果が得られない場合があります。

```markdown
Always conform to the coding styles defined in styleguide.md in repo my-org/my-repo when generating code. Use @terminal when answering questions about Git. Answer all questions in the style of a friendly colleague, using informal language. Answer all questions in less than 1000 characters, and words of no more than 12 characters.
```

## [使われているリポジトリのカスタム命令](https://docs.github.com/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot#repository-custom-instructions-in-use)

## [リポジトリのカスタム命令の有効化または無効化](https://docs.github.com/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot#enabling-or-disabling-repository-custom-instructions)

チャット質問にカスタム指示を追加するかどうかを選択できます。