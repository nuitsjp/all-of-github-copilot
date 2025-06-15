# Copilot Chat のプロンプトの概要 - GitHub Enterprise Cloud Docs

# Copilot Chat のプロンプトの概要

Copilot Chat の使用方法の概要について説明します。

## Tool navigation

## この記事の内容

Copilot Chat にプロジェクトに関する具体的な質問や、ソフトウェア全般に関する質問をすることができます。 また、Copilot Chat に、コードの記述、エラーの修正、テストの記述、ドキュメント コードを依頼することもできます。

上記のタブを使用して、Copilot Chat を使用している環境を選びます。

次のプロンプト例の中には、チャット参加者 (前に `@` が付く)、スラッシュ コマンド (前に `/` が付く)、またはチャット変数 (前に `#` が付く) を使用する場合があります。 プロンプトのキーワードの詳細については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide#using-keywords-in-your-prompt)」を参照してください。

## [ソフトウェアに関する一般的な質問を行う](#ask-general-software-questions)

Copilot Chat の一般的なソフトウェアに関する質問をすることができます。 次に例を示します。

-   `tell me about nodejs web server frameworks`
-   `how can I create an Express app`
-   `@terminal how to update an npm package`

## [プロジェクトに関する質問を行う](#ask-questions-about-your-project)

プロジェクトについて Copilot Chat に質問できます。

-   `what sorting algorithm does this function use`
-   `@workspace how are notifications scheduled`
-   `#file:gameReducer.js #file:gameInit.js how are these files related`

Copilot に正しいコンテキストを提供するには、次の方法をいくつか試してください。

-   関連するコード行をハイライトする。
-   `#selection`、`#file`、`#editor`、`#codebase`、`#git` などのチャット変数を使います。
-   `@workspace` チャット参加者を使います。

## [コードの記述](#write-code)

variables.product.prodname\_copilot\_short %} にコードの記述を依頼できます。 次に例を示します。

-   `write a function to sum all numbers in a list`
-   `add error handling to this function`
-   `@workspace add form validation, similar to the newsletter page`

Copilot がコード ブロックを返すと、応答には、コードをコピーするか、カーソルにコードを挿入するか、新しいファイルに挿入するか、ターミナルに挿入するオプションが含まれます。

## [GitHub Advanced Security 機能のアラートについて質問する](#github-advanced-security-機能のアラートについて質問する)

GitHub Advanced Security 機能 (code scanning、secret scanning、Dependabot alerts) による organization 内リポジトリのセキュリティ アラートについて、Copilot に質問することができます。 次に例を示します。

-   `How would I fix this alert?`
-   `How many alerts do I have on this pull request?`
-   `Which line of code is this code scanning alert referencing?`
-   `What library is affected by this Dependabot alert?`

## [新しいプロジェクトを設定する](#set-up-a-new-project)

`/new` スラッシュ コマンドを使用して、新しいプロジェクトを設定します。 次に例を示します。

-   `/new react app with typescript`
-   `/new python django web application`
-   `/new node.js express server`

Copilot はディレクトリ構造を提案し、提案されたファイルと内容を作成するためのボタンを提供します。 提案されたファイルをプレビューするには、提案されたディレクトリ構造でファイル名を選択します。

`/newNotebook` スラッシュ コマンドを使用して、新しい Jupyter ノートブックを設定します。 次に例を示します。

-   `/newNotebook retrieve the titanic dataset and use Seaborn to plot the data`

## [コードの修正、改善、リファクタリング](#fix-improve-and-refactor-code)

アクティブなファイルにエラーが含まれている場合は、`/fix` スラッシュ コマンドを使用して、Copilot にエラーを修正するよう依頼します。

コードを改善またはリファクタリングするための一般的な要求を行うこともできます。

-   `how would you improve this code?`
-   `translate this code to C#`
-   `add error handling to this function`

## [テストを記述する](#write-tests)

`/tests` スラッシュ コマンドを使用して、Copilot に、アクティブなファイルまたは選択したコードのテストを記述するように依頼します。 次に例を示します。

-   `/tests`
-   `/tests using the Jest framework`
-   `/tests ensure the function rejects an empty list`

スラッシュ コマンドは `/tests` 、既存のコードのテストを記述します。 コードを書き込む前にテストを記述する (テスト駆動開発) 場合は、`/tests` コマンドを省略します。 次に例を示します。

-   `Add tests for a JavaScript function that should sum a list of integers`

## [Visual Studio Code について質問する](#visual-studio-code-について質問する)

`@vscode` チャット参加者を使用して、Visual Studio Code に関する具体的な質問をします。 次に例を示します。

-   `@vscode tell me how to debug a node.js app`
-   `@vscode how do I change my Visual Studio Code colors`
-   `@vscode how can I change key bindings`

## [コマンド ラインについて質問する](#ask-questions-about-the-command-line)

`@terminal` チャット参加者を使用して、コマンド ラインに関する具体的な質問をします。 次に例を示します。

-   `@terminal find the largest file in the src directory`
-   最後のコマンドとエラーを説明する `@terminal #terminalLastCommand`

## [ソフトウェアに関する一般的な質問を行う](#ask-general-software-questions)

Copilot Chat の一般的なソフトウェアに関する質問をすることができます。 次に例を示します。

-   `tell me about nodejs web server frameworks`
-   `how can I create an Express app`
-   `what's the process for updating an npm package`

## [プロジェクトに関する質問を行う](#ask-questions-about-your-project)

プロジェクトについて Copilot Chat に質問できます。 Copilot に正しいコンテキストを提供するには、次の方法をいくつか試してください。

-   関連するコード行をハイライトする。
-   関連するファイルを開く。
-   `#file` を使って、Copilot に特定のファイルを参照するよう指示します。
-   `#solution` を使って、Copilot にアクティブなファイルを参照するよう指示します。

次に例を示します。

-   `what sorting algorithm does this function use`
-   `#file:gameReducer.js what happens when a new game is requested`

## [コードの記述](#write-code)

variables.product.prodname\_copilot\_short %} にコードの記述を依頼できます。 次に例を示します。

-   `write a function to sum all numbers in a list`
-   `add error handling to this function`

Copilot がコード ブロックを返す際、応答には、コードをコピーするか、新しいファイルに挿入するか、またはコードの出力をプレビューするかのオプションが含まれます。

## [GitHub Advanced Security 機能のアラートについて質問する](#github-advanced-security-機能のアラートについて質問する-1)

GitHub Advanced Security 機能 (code scanning、secret scanning、Dependabot alerts) による organization 内リポジトリのセキュリティ アラートについて、Copilot に質問することができます。 次に例を示します。

-   `How would I fix this alert?`
-   `How many alerts do I have on this pull request?`
-   `Which line of code is this code scanning alert referencing?`
-   `What library is affected by this Dependabot alert?`

## [コードの修正、改善、リファクタリング](#fix-improve-and-refactor-code)

アクティブなファイルにエラーが含まれている場合は、`/fix` スラッシュ コマンドを使用して、Copilot にエラーを修正するよう依頼します。

コードを改善またはリファクタリングするための一般的な要求を行うこともできます。

-   `how would you improve this code?`
-   `translate this code to C#`
-   `add error handling to this function`

## [テストを記述する](#write-tests)

`/tests` スラッシュ コマンドを使用して、Copilot に、アクティブなファイルまたは選択したコードのテストを記述するように依頼します。 次に例を示します。

-   `/tests`
-   `/tests using the Jest framework`
-   `/tests ensure the function rejects an empty list`

スラッシュ コマンドは `/tests` 、既存のコードのテストを記述します。 コードを書き込む前にテストを記述する (テスト駆動開発) 場合は、`/tests` コマンドを省略します。 次に例を示します。

-   `Add tests for a JavaScript function that should sum a list of integers`

## [ソフトウェアに関する一般的な質問を行う](#ask-general-software-questions)

Copilot Chat の一般的なソフトウェアに関する質問をすることができます。 次に例を示します。

-   `tell me about nodejs web server frameworks`
-   `how can I create an Express app`
-   `what's the process for updating an npm package`

## [プロジェクトに関する質問を行う](#ask-questions-about-your-project)

プロジェクトについて Copilot Chat に質問できます。 Copilot に正しいコンテキストを提供するには、次の方法をいくつか試してください。

-   関連するコード行をハイライトする。
-   関連するファイルを開く。
-   参照としてファイルを追加する。 ファイル参照の使い方の詳細については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide?tool=jetbrains#file-references)」を参照してください。
-   `@project` チャット参加者を使います。

次に例を示します。

-   `what sorting algorithm does this function use`
-   `how are these files related` (質問内のファイルへの参照を含む)
-   `@project how are notifications scheduled`

## [コードの記述](#write-code)

variables.product.prodname\_copilot\_short %} にコードの記述を依頼できます。 次に例を示します。

-   `write a function to sum all numbers in a list`
-   `add error handling to this function`

Copilot がコード ブロックを返す際、応答には、コードをコピーするか、そのコードをカーソルで挿入するかのオプションが含まれます。

## [コードを修正、改善、リファクタリングする](#fix-improve-and-refactor-code)

アクティブなファイルにエラーが含まれている場合は、`/fix` スラッシュ コマンドを使用して、Copilot にエラーを修正するよう依頼します。

コードを改善またはリファクタリングするための一般的な要求を行うこともできます。

-   `how would you improve this code?`
-   `translate this code to C#`
-   `add error handling to this function`

## [テストを記述する](#write-tests)

`/tests` スラッシュ コマンドを使用して、Copilot に、アクティブなファイルまたは選択したコードのテストを記述するように依頼します。 次に例を示します。

-   `/tests`
-   `/tests using the Jest framework`
-   `/tests ensure the function rejects an empty list`

スラッシュ コマンドは `/tests` 、既存のコードのテストを記述します。 コードを書き込む前にテストを記述する (テスト駆動開発) 場合は、`/tests` コマンドを省略します。 次に例を示します。

-   `Add tests for a JavaScript function that should sum a list of integers`

一部のプロンプト例では、GitHub Web サイトの特定のコンテキストにいる必要があります。 こうしたコンテキストにアクセスする方法の詳細については、「[さまざまなコンテキストで Copilot Chat に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-github#asking-copilot-chat-questions-in-different-contexts)」を参照してください。

## [ソフトウェアに関する一般的な質問を行う](#ask-general-software-questions)

Copilot Chat の一般的なソフトウェアに関する質問をすることができます。 次に例を示します。

-   `tell me about nodejs web server frameworks`
-   `how can I create an Express app`
-   `what is the best way to update an npm package`

## [リポジトリについて質問する](#ask-questions-about-a-repository)

リポジトリについて Copilot Chat に質問できます。 次に例を示します。

-   `what is the purpose of this repository?`
-   `When was the most recent release?`
-   `Where is rate limiting implemented in our API?`
-   `What was the last merged PR by USERNAME`

## [特定のファイルまたはシンボルについて質問する](#ask-questions-about-a-specific-file-or-symbol)

特定のファイルまたはシンボルについて、Copilot Chat に質問することができます。 次に例を示します。

-   `what sorting algorithm does this function use`
-   `how are these files related`
-   `what is the purpose of this function`

## [ナレッジ ベースについて質問する](#ask-questions-about-a-knowledge-base)

ナレッジ ベースについて Copilot Chat に質問することができます。 次に例を示します。

-   `How do I deploy a new application?`
-   `What's the process for creating a new REST API?`
-   `What are our best practices for logging?`

## [特定のコード部分について質問する](#ask-questions-about-a-specific-piece-of-code)

特定のコード部分について Copilot Chat に質問することができます。 ファイル全体または特定の行について質問することができます。 次に例を示します。

ファイル全体について質問する場合は、次のように入力できます。

-   `Explain this file.`
-   `How could I improve this code?`
-   `How can I test this script?`

特定の行について質問する場合は、次のように入力できます。

-   `Explain the function at the selected lines.`
-   `How could I improve this class?`
-   `Add error handling to this code.`
-   `Write a unit test for this method.`

## [GitHub Advanced Security 製品からのアラートについて質問する](#github-advanced-security-製品からのアラートについて質問する)

GitHub Advanced Security 機能 (code scanning、secret scanning、Dependabot alerts) による organization 内のリポジトリのセキュリティ アラートについて、Copilot Chat に質問することができます。 次に例を示します。

-   `How would I fix this alert?`
-   `How many alerts do I have on this pull request?`
-   `Which line of code is this code scanning alert referencing?`
-   `What library is affected by this Dependabot alert?`

## [Pull request で Copilot Chat に質問する](#pull-request-で-copilot-chat-に質問する)

Pull request で Copilot Chat に質問することができます。 質問は、pull request のさまざまな要素に関連している可能性があります。次に例を示します。

Pull request の変更の概要について質問することができます。

-   `Summarize this PR for me.`
-   `Summarize the comments in this PR.`
-   `Summarize the changes in this PR.`

Pull request 内の特定のファイルに加えられた変更について質問することができます。

-   `What's the purpose of this file?`
-   `Why has this module been included?`

Pull request の特定の行に加えられた変更について質問することができます。

-   `What is "actorData" in this line?`
-   `Explain this "do..end" block.`

ワークフローが失敗した理由を質問することができます。

-   `Tell me why this job failed`
-   `Suggest a fix for this error`

## [特定の issue やディスカッションについて Copilot Chat に質問する](#特定の-issue-やディスカッションについて-copilot-chat-に質問する)

特定の issue やディスカッションについて Copilot Chat に質問することができます。 次に例を示します。

-   `what is the purpose of this issue?`

## [特定のコミットについて Copilot Chat に質問する](#特定のコミットについて-copilot-chat-に質問する)

特定のコミットについて Copilot Chat に質問することができます。 次に例を示します。

-   `what is the purpose of this commit?`
-   `what is the expected output of this commit?`
-   `what is the best way to test this commit?`

## [ソフトウェアに関する一般的な質問を行う](#ask-general-software-questions)

Copilot Chat の一般的なソフトウェアに関する質問をすることができます。 次に例を示します。

-   `tell me about nodejs web server frameworks`
-   `how can I create an Express app`
-   `what's the process for updating an npm package`

## [プロジェクトのファイルについて質問する](#ask-questions-about-files-your-project)

エディターに現在表示されているファイルについて、または Copilot Chat パネルで会話に添付したファイルについて、Copilot Chat に質問することができます。 Copilot に正しいコンテキストを与えるには:

-   関連するファイルをエディターで開きます。
-   Copilot Chat パネルのペーパー クリップ アイコンをクリックし、会話に添付するファイルを検索して選びます。

次に例を示します。

-   `how can I make this file run faster`
-   `how are these files related` (複数のファイルが添付されている場合)
-   `explain the getSearchReplaceRules function`

## [コードの記述](#write-code)

variables.product.prodname\_copilot\_short %} にコードの記述を依頼できます。 次に例を示します。

-   `write a TypeScript function to sum all numbers in a list`
-   `using the comments in this file, create appropriate Node JavaScript`

Copilot からコード ブロックが返された場合、回答にはコードをコピーするオプションが含まれます。

## [コードを修正、改善、リファクタリングする](#fix-improve-and-refactor-code)

アクティブなファイルにエラーが含まれている場合は、`/fix` スラッシュ コマンドを使用して、Copilot にエラーを修正するよう依頼します。

コードを改善またはリファクタリングするための一般的な要求を行うこともできます。

-   `how would you improve the code in this file`
-   `translate this code to C#`
-   `add error handling to the main function`

## [テストを記述する](#write-tests)

`/tests` スラッシュ コマンドを使用して、Copilot に、アクティブなファイルまたは選択したコードのテストを記述するように依頼します。 次に例を示します。

-   `/tests`
-   `/tests using the Jest framework`
-   `/tests ensure the function rejects an empty list`

スラッシュ コマンドは `/tests` 、既存のコードのテストを記述します。 コードを書き込む前にテストを記述する (テスト駆動開発) 場合は、`/tests` コマンドを省略します。 次に例を示します。

-   `Add tests for a JavaScript function that should sum a list of integers`