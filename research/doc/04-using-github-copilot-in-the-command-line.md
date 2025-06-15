Copilot と GitHub CLI を使用すれば、コマンド ラインの提案と説明をしてくれます。

## [前提条件](https://docs.github.com/ja/copilot/using-github-copilot/using-github-copilot-in-the-command-line#prerequisites)

-   **GitHub Copilot** へのアクセス権。 「[GitHub Copilot とは何ですか?](https://docs.github.com/ja/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
-   **GitHub CLI がインストールされました。** GitHub CLI のインストール手順については、[GitHub CLI リポジトリ](https://github.com/cli/cli#installation)を参照してください。
-   **Copilot in the CLI 拡張機能がインストールされています**。 「[CLIG での GitHub Copilot のインストール](https://docs.github.com/ja/copilot/github-copilot-in-the-cli/installing-github-copilot-in-the-cli)」を参照してください。

Organization または Enterprise を介して GitHub Copilot にアクセスできる場合、organization 所有者または Enterprise 管理者が Copilot in the CLI を無効にしていると、Copilot in the CLI を使用することはできません。 「[organization 内での Copilot のポリシーの管理](https://docs.github.com/ja/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-github-copilot-features-in-your-organization/managing-policies-for-copilot-in-your-organization)」を参照してください。

## [コマンドの説明の取得について](https://docs.github.com/ja/copilot/using-github-copilot/using-github-copilot-in-the-command-line#getting-command-explanations)

Copilot in the CLI にコマンドの説明を受けるには、説明してほしいコマンドを `gh copilot explain` の後に付けて実行します。 次に例を示します。

Shell

```shell
gh copilot explain "sudo apt-get"
```

## [コマンドの提案の取得について](https://docs.github.com/ja/copilot/using-github-copilot/using-github-copilot-in-the-command-line#getting-command-suggestions)

Copilot in the CLI にコマンドの提案を受けるには、提案してほしいコマンドを `gh copilot suggest` の後に付けて実行します。 次に例を示します。

Shell

```shell
gh copilot suggest "Undo the last commit"
```

Copilot in the CLI が必要な情報の取得に向けて、対話型セッションを開始します。

Copilot in the CLI によるコマンドの提案後、**\[Execute command\]** オプションを選択した場合は、Copilot in the CLI がコマンドをクリップボードにコピーし、対話型セッションを終了します。 その後、コマンドを CLI に手動でペーストすることができます。

ユーザーに代わって Copilot in the CLI にコマンドを実実行してもらうようにするには、`ghcs` エイリアスを設定する必要があります。 「[CLI での GitHub Copilot の構成](https://docs.github.com/ja/copilot/github-copilot-in-the-cli/configuring-github-copilot-in-the-cli#setting-up-aliases)」を参照してください。

## [フィードバックを送る](https://docs.github.com/ja/copilot/using-github-copilot/using-github-copilot-in-the-command-line#sharing-feedback)

提案の品質に関するフィードバックを GitHub に送信するには、Copilot in the CLI の **\[Rate response\]** オプションを選択します。

また、[Copilot in the CLI 拡張機能リポジトリ](https://github.com/github/gh-copilot)で issue を開くこともできます。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/using-github-copilot-in-the-command-line#further-reading)

-   [Copilot in the CLI 拡張機能 README](https://github.com/github/gh-copilot?tab=readme-ov-file)
-   [CLI での GitHub Copilot の構成](https://docs.github.com/ja/copilot/github-copilot-in-the-cli/configuring-github-copilot-in-the-cli)