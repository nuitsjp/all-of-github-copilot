毎日使用するツールで AI モデルを呼び出します。

GitHub Models 拡張機能を使用すると、Copilot Chat と GitHub CLI の両方から特定の AI モデルを呼び出すことができます。 これらの拡張機能は開発ワークフローに直接統合されるため、コンテキストを切り替えずにモデルにプロンプトを送信できます。

## [Copilot Chat での AI モデルの使用](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#copilot-chat-%E3%81%A7%E3%81%AE-ai-%E3%83%A2%E3%83%87%E3%83%AB%E3%81%AE%E4%BD%BF%E7%94%A8)

Copilot サブスクリプションをお持ちの場合は、次の 2 通りの方法で Copilot Chat の AI モデルを操作できます。

-   GitHub Models Copilot Extension の使用。 この拡張機能を使用すると、特定の条件に基づいてモデルのレコメンデーションを要求し、特定のモデルとチャットすることができます。 「[GitHub Models Copilot Extension の使用](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#using-the-github-models-copilot-extension)」を参照してください。
-   Copilot Chat での複数モデル サポートの使用。 マルチモデル Copilot Chat では、会話に使用する特定のモデルを選択し、通常どおり Copilot Chat にプロンプトを送信できます。 「[Copilot Chat の AI モデルを変更する](https://docs.github.com/ja/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」を参照してください。

### [GitHub Models Copilot Extension の使用](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#github-models-copilot-extension-%E3%81%AE%E4%BD%BF%E7%94%A8)

メモ

GitHub Models Copilot Extension はパブリック プレビュー段階にあり、変更される可能性があります。

1.  [GitHub Models Copilot Extension](https://github.com/marketplace/models-github) をインストールします。
    
    -   Copilot Pro サブスクリプションをお持ちの場合は、個人用アカウントに拡張機能をインストールできます。
    -   Copilot Business または Copilot Enterprise サブスクリプションを介して Copilot にアクセスできる場合:
        -   Organization または Enterprise の所有者は、organization または Enterprise の Copilot Extensions ポリシーを有効にする必要があります。
        -   Organization の所有者は、organization の拡張機能をインストールする必要があります。
2.  GitHub Copilot Extensions をサポートする Copilot Chat の実装を開きます。 サポートされている Copilot Chat 実装の一覧については、「[拡張情報を使用して外部ツールを Copilot Chat と統合する](https://docs.github.com/ja/copilot/using-github-copilot/using-extensions-to-integrate-external-tools-with-copilot-chat#supported-clients-and-ides)」を参照してください。
    
3.  チャット ウィンドウで、「」と入力し、プロンプトを送信します。 GitHub Models Copilot Extension には、次のようないくつかのユース ケースがあります。`@models YOUR-PROMPT`
    
    -   指定したコンテキストと条件に基づいて特定のモデルを推奨する。 たとえば、関数呼び出しをサポートする低コストの OpenAI モデルを要求できます。
    -   特定のモデルを使用してプロンプトを実行する。 これは、マルチモデル Copilot Chat で現在使用できないモデルを使用する場合に特に便利です。
    -   GitHub Models で現在利用可能なモデルを一覧表示する

## [GitHub Actions での AI モデルの使用](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#github-actions-%E3%81%A7%E3%81%AE-ai-%E3%83%A2%E3%83%87%E3%83%AB%E3%81%AE%E4%BD%BF%E7%94%A8)

GitHub Actions トークン () を使って、ワークフロー内で直接 AI モデルを呼び出すことができます。`GITHUB_TOKEN`

### [アクセス許可の設定](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#setting-permissions)

ワークフローで AI モデルを使うには、ワークフローの構成で アクセス許可が有効になっていることを確認します。 このアクセス許可により、ワークフローは GitHub Models の推論 API にアクセスできます。 このアクセス許可自体を設定するか、一般的な または のアクセス許可を使用することができます。 「[GitHub Appに必要な権限](https://docs.github.com/ja/rest/overview/permissions-required-for-github-apps?apiVersion=2022-11-28#repository-permissions-for-actions)」を参照してください。`models``read-all``write-all`

### [ワークフロー ファイルの書き込み](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#writing-your-workflow-file)

ワークフローから推論 API を直接呼び出すことができます。 次に例を示します。

```yaml
name: Use GitHub Models on: workflow_dispatch: permissions: models: read jobs: call-model: runs-on: ubuntu-latest steps: - name: Call AI model env: GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }} run: | curl "https://models.github.ai/inference/chat/completions" \ -H "Content-Type: application/json" \ -H "Authorization: Bearer $GITHUB_TOKEN" \ -d '{ "messages": [ { "role": "user", "content": "Explain the concept of recursion." } ], "model": "openai/gpt-4o" }'
```

## [コマンド ラインから AI モデルを使用する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#using-ai-models-from-the-command-line)

メモ

GitHub CLI の GitHub Models 拡張機能はパブリック プレビュー段階にあり、変更される可能性があります。

GitHub CLI の GitHub Models 拡張機能を使用して、コマンド ラインから AI モデルを要求したり、コマンドの出力をコンテキストとしてパイプしたりできます。

### [前提条件](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#prerequisites)

GitHub Models の CLI 拡張機能を使うには、GitHub CLI をインストールする必要があります。 GitHub CLI のインストール手順については、[GitHub CLI リポジトリ](https://github.com/cli/cli#installation)を参照してください。

### [拡張機能をインストールする](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#installing-the-extension)

1.  GitHub CLI アカウントでまだ認証していない場合は、ターミナルで次のコマンドを実行します。
    
2.  GitHub Models 拡張機能をインストールするには、次のコマンドを実行します。
    
    Shell
    
    ```shell
    gh extension install https://github.com/github/gh-models
    ```
    

### [拡張機能を使用する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#using-the-extension)

使用可能なすべてのコマンドの一覧を表示するには、 を実行します。`gh models`

拡張機能を使用する主な方法はいくつかあります。

-   **チャット エクスペリエンスを使用してモデルに複数の質問をするには**、 を実行します。 一覧表示されているモデルからモデルを選択し、プロンプトを送信します。`gh models run`
-   **モデルに 1 つの質問をするには**、ターミナルで を実行します。 たとえば、空が青い理由を GPT-4.1 モデルに聞くには、 を実行できます。`gh models run MODEL-NAME "QUESTION"``gh models run openai/gpt-4.1 "why is the sky blue?"`
-   **モデルを呼び出すときにコマンドの出力をコンテキストとして提供するには**、パイプ文字 () を使用して、別のコマンドとモデルへの呼び出しを結合できます。 たとえば、GPT-4.1 モデルを使って現在のディレクトリにある README ファイルを要約するには、 を実行できます。`|``cat README.md | gh models run openai/gpt-4.1 "summarize this text"`