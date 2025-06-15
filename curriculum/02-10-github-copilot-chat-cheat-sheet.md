# GitHub Copilot Chat チート シート - GitHub Enterprise Cloud Docs

# GitHub Copilot Chat チート シート

このチート シートを使うと、GitHub Copilot Chat を使う際に最も一般的なコマンドとオプションを簡単に参照できます。

## Tool navigation

## この記事の内容

この記事のこのバージョンは、GitHub の Web サイト上の Copilot に関するものです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

GitHub Web サイトの Copilot Chat の概要については、「[GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-github)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/clear`

会話をクリアします。

`/delete`

会話を削除します。

`/new`

会話を開始する

`/rename`

会話の名前を変更します。

この記事のこのバージョンは、Visual Studio Code の Copilot に関するものです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について-1)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

Copilot Chat in Visual Studio Code の概要については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/clear`

新しいチャット セッションを開始します。

`/explain`

アクティブなエディターのコードがどのように機能するかについて説明します。

`/fix`

選んだコードの問題の修正プログラムを提案します。

`/fixTestFailure`

失敗したテストを見つけて修正します。

`/help`

GitHub Copilot の使用に関するクイック リファレンスと基本。

`/new`

新しいプロジェクトを作成します。

`/tests`

選んだコードの単体テストを生成します。

## [チャット変数](#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

Variable

説明

`#block`

現在のコード ブロックをプロンプトに含めます。

`#class`

現在のクラスをプロンプトに含めます。

`#comment`

現在のコメントをプロンプトに含めます。

`#file`

現在のファイルの内容をプロンプトに含めます。

`#function`

現在の関数またはメソッドをプロンプトに含めます。

`#line`

現在のコード行をプロンプトに含めます。

`#path`

ファイル パスをプロンプトに含めます。

`#project`

プロジェクトのコンテキストをプロンプトに含めます。

`#selection`

現在選択されているテキストをプロンプトに含めます。

`#sym`

現在のシンボルをプロンプトに含めます。

## [チャット参加者](#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。 チャット プロンプト ボックスに「`@`」と入力し、それに続けてチャット参加者名を入力することで、チャット参加者を指定できます。 使用可能なすべてのチャット参加者を表示するには、チャット プロンプト ボックスに 「`@`」 と入力します。

Copilot Chat を使う際に最も一般的なチャット参加者の一覧を次に示します。

Variable

説明

`@azure`

Azure サービスに関するコンテキストと、それらを使用、配置、管理する方法があります。 Azure に関するヘルプが必要な場合は、`@azure` を使います。 `@azure` チャット参加者は現在 パブリック プレビュー 段階であり、変更される可能性があります。

`@github`

GitHub 固有の Copilot スキルを使用できます。 「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide#using-github-skills-for-copilot)」を参照してください。

`@terminal`

Visual Studio Codeターミナル シェルとその内容に関するコンテキストがあります。 ターミナル コマンドの作成またはデバッグに関するヘルプが必要な場合に `@terminal` を使用します。

`@vscode`

Visual Studio Code コマンドと機能に関するコンテキストがあります。 Visual Studio Code に関するヘルプが必要な場合に `@vscode` を使用します。

`@workspace`

ワークスペース内のコードに関するコンテキストがあります。 Copilot でプロジェクトの構造、コードのさまざまな部分の相互作用、またはプロジェクト内の設計パターンを考慮する場合に `@workspace` を使用します。

この記事のこのバージョンは、Copilot in Visual Studio 向けです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について-2)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

Copilot Chat in Visual Studio の概要については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/clear`

新しいチャット セッションを開始します。

`/explain`

アクティブなエディターのコードがどのように機能するかについて説明します。

`/fix`

選んだコードの問題の修正プログラムを提案します。

`/fixTestFailure`

失敗したテストを見つけて修正します。

`/help`

GitHub Copilot の使用に関するクイック リファレンスと基本。

`/new`

新しいプロジェクトを作成します。

`/tests`

選んだコードの単体テストを生成します。

## [チャット変数](#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

Variable

説明

`#block`

現在のコード ブロックをプロンプトに含めます。

`#class`

現在のクラスをプロンプトに含めます。

`#comment`

現在のコメントをプロンプトに含めます。

`#file`

現在のファイルの内容をプロンプトに含めます。

`#function`

現在の関数またはメソッドをプロンプトに含めます。

`#line`

現在のコード行をプロンプトに含めます。

`#path`

ファイル パスをプロンプトに含めます。

`#project`

プロジェクトのコンテキストをプロンプトに含めます。

`#selection`

現在選択されているテキストをプロンプトに含めます。

`#sym`

現在のシンボルをプロンプトに含めます。

## [チャット参加者](#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。 チャット プロンプト ボックスに「`@`」と入力し、それに続けてチャット参加者名を入力することで、チャット参加者を指定できます。 使用可能なすべてのチャット参加者を表示するには、チャット プロンプト ボックスに 「`@`」 と入力します。

よく使われるチャット参加者は次のとおりです。

Variable

説明

`@github`

GitHub 固有の Copilot スキルを使用できます。 「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide#using-github-skills-for-copilot-1)」を参照してください。

`@project`

プロジェクト内のコードに関するコンテキストがあります。 質問の回答を得るときに、Copilot にプロジェクト内のすべてのファイルを考慮してもらう場合は、`@project` を使います。

この記事のこのバージョンは、Copilot in Xcode 向けです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について-4)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

Copilot Chat in Xcode の概要については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/doc`

このシンボルのドキュメント コメントを追加します。

`/explain`

アクティブなエディターのコードがどのように機能するかについて説明します。

`/fix`

選んだコードの問題の修正プログラムを提案します。

`/help`

GitHub Copilot の使用に関するクイック リファレンスと基本。

`/optimize`

選んだコードの実行時間を分析して改善します。

`/tests`

選んだコードの単体テストを生成します。

## [チャット変数](#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

Variable

説明

`#block`

現在のコード ブロックをプロンプトに含めます。

`#class`

現在のクラスをプロンプトに含めます。

`#comment`

現在のコメントをプロンプトに含めます。

`#file`

現在のファイルの内容をプロンプトに含めます。

`#function`

現在の関数またはメソッドをプロンプトに含めます。

`#line`

現在のコード行をプロンプトに含めます。

`#path`

ファイル パスをプロンプトに含めます。

`#project`

プロジェクトのコンテキストをプロンプトに含めます。

`#selection`

現在選択されているテキストをプロンプトに含めます。

`#sym`

現在のシンボルをプロンプトに含めます。

## [チャット参加者](#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。 チャット プロンプト ボックスに「`@`」と入力し、それに続けてチャット参加者名を入力することで、チャット参加者を指定できます。 使用可能なすべてのチャット参加者を表示するには、チャット プロンプト ボックスに 「`@`」 と入力します。

よく使われるチャット参加者は次のとおりです。

Variable

説明

`@github`

GitHub 固有の Copilot スキルを使用できます。 「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide#using-github-skills-for-copilot-1)」を参照してください。

`@project`

プロジェクト内のコードに関するコンテキストがあります。 質問の回答を得るときに、Copilot にプロジェクト内のすべてのファイルを考慮してもらう場合は、`@project` を使います。

この記事のこのバージョンは、Copilot in Xcode 向けです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について-4)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

Copilot Chat in Xcode の概要については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/doc`

このシンボルのドキュメント コメントを追加します。

`/explain`

アクティブなエディターのコードがどのように機能するかについて説明します。

`/fix`

選んだコードの問題の修正プログラムを提案します。

`/help`

GitHub Copilot の使用に関するクイック リファレンスと基本。

`/optimize`

選んだコードの実行時間を分析して改善します。

`/tests`

選んだコードの単体テストを生成します。

## [チャット変数](#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

Variable

説明

`#block`

現在のコード ブロックをプロンプトに含めます。

`#class`

現在のクラスをプロンプトに含めます。

`#comment`

現在のコメントをプロンプトに含めます。

`#file`

現在のファイルの内容をプロンプトに含めます。

`#function`

現在の関数またはメソッドをプロンプトに含めます。

`#line`

現在のコード行をプロンプトに含めます。

`#path`

ファイル パスをプロンプトに含めます。

`#project`

プロジェクトのコンテキストをプロンプトに含めます。

`#selection`

現在選択されているテキストをプロンプトに含めます。

`#sym`

現在のシンボルをプロンプトに含めます。

## [チャット参加者](#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。 チャット プロンプト ボックスに「`@`」と入力し、それに続けてチャット参加者名を入力することで、チャット参加者を指定できます。 使用可能なすべてのチャット参加者を表示するには、チャット プロンプト ボックスに 「`@`」 と入力します。

よく使われるチャット参加者は次のとおりです。

Variable

説明

`@github`

GitHub 固有の Copilot スキルを使用できます。 「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide#using-github-skills-for-copilot-1)」を参照してください。

`@project`

プロジェクト内のコードに関するコンテキストがあります。 質問の回答を得るときに、Copilot にプロジェクト内のすべてのファイルを考慮してもらう場合は、`@project` を使います。

この記事のこのバージョンは、Copilot in Xcode 向けです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について-4)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

Copilot Chat in Xcode の概要については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/doc`

このシンボルのドキュメント コメントを追加します。

`/explain`

アクティブなエディターのコードがどのように機能するかについて説明します。

`/fix`

選んだコードの問題の修正プログラムを提案します。

`/help`

GitHub Copilot の使用に関するクイック リファレンスと基本。

`/optimize`

選んだコードの実行時間を分析して改善します。

`/tests`

選んだコードの単体テストを生成します。

## [チャット変数](#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

Variable

説明

`#block`

現在のコード ブロックをプロンプトに含めます。

`#class`

現在のクラスをプロンプトに含めます。

`#comment`

現在のコメントをプロンプトに含めます。

`#file`

現在のファイルの内容をプロンプトに含めます。

`#function`

現在の関数またはメソッドをプロンプトに含めます。

`#line`

現在のコード行をプロンプトに含めます。

`#path`

ファイル パスをプロンプトに含めます。

`#project`

プロジェクトのコンテキストをプロンプトに含めます。

`#selection`

現在選択されているテキストをプロンプトに含めます。

`#sym`

現在のシンボルをプロンプトに含めます。

## [Copilot の GitHub スキルの使用 (プレビュー版)](#copilot-の-github-スキルの使用-プレビュー版)

メモ

`@github` チャット参加者は現在プレビュー段階であり、[Visual Studio 2022 Preview 2](https://visualstudio.microsoft.com/vs/preview/) 以降でのみ使用できます。

Copilot の GitHub 固有のスキルは、Copilot が提供できる情報の種類を拡張します。 Copilot Chat in Visual Studio でこれらのスキルにアクセスするには、質問に `@github` を含めます。

質問に `@github` を追加すると、Copilot によって、質問の内容に基づいて適切なスキルが動的に選択されます。 また、特定のスキルを使用するように Copilot Chat に明示的に要求することもできます。 たとえば、`@github Search the web to find the latest GPT4 model from OpenAI.` のように指定します。

Copilot に問い合わせ、現在使用可能なスキルの一覧を生成できます: `@github What skills are available?`

## [サポート技術情報について質問する (プレビュー)](#asking-a-question-about-a-knowledge-base-preview)

メモ

-   この機能は、Copilot Enterprise サブスクリプションがある場合にのみ使用できます。
-   サポート技術情報のサポートは現在プレビュー段階であり、[Visual Studio 2022 Preview 3](https://visualstudio.microsoft.com/vs/preview/) 以降でのみ使用できます。

組織の所有者は、1 つまたは複数のリポジトリにまたがる Markdown ドキュメントをグループ化したナレッジ ベースを作成できます。 詳しくは、「[Copilot サポート技術情報の管理](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/managing-copilot-knowledge-bases)」をご覧ください。

Copilot に、サポート技術情報のコンテキスト内で質問に回答するように指示できます。

1.  Copilot Chat ウィンドウの下部にある **\[Ask Copilot: Type / for commands and # to reference\]** テキスト ボックスに「`@github`」と入力し、# キーを押して、一覧からナレッジ ベースを選びます。
2.  **\[コマンドの場合は / を入力し、参照する場合は # を入力する\]** テキスト ボックスで、質問があるメッセージを続行し、**Enter** キーを押します。
3.  Copilot Chat により質問が処理され、チャット ウィンドウにナレッジ ベースの引用を含む回答が提供されます。

## [Copilot Chat の AI モデル](#copilot-chat-の-ai-モデル-3)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [プロンプトでキーワード (keyword)を使用する](#using-keywords-in-your-prompt)

特別なキーワード (keyword) を使用することで、Copilot がプロンプトを理解するのに役立ちます。

### [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。 たとえば、`/explain` を使って、現在エディターに表示されているファイル内のコードを Copilot に説明してもらいます。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。

## [Copilot Edits](#copilot-edits-2)

1 つの Copilot Chat プロンプトから複数のファイルに直接変更を加えるには、Copilot Edits を使用します。 Copilot Edits には次のモードがあります。

-   [編集モード](#edit-mode-1)を使うと、Copilot で複数のファイルに対して制御された編集を行うことができます。
-   [エージェント モード](#agent-mode-1)を使うと、設定されたタスクを Copilot で自律的に実行できます。

### [編集モード](#edit-mode)

編集モードは、Visual Studio Code と JetBrains IDE でのみ使用できます。

Copilot から提案される編集をより詳細に制御する場合は、編集モードを使います。 編集モードでは、Copilot が変更できるファイルを選び、各繰り返しで Copilot にコンテキストを提供し、各ターン後に提案された編集を受け入れるかどうかを決定します。

編集モードは、次のユース ケースに最適です。

-   定義された一連のファイルに対して、迅速かつ具体的な更新を行う必要があります。
-   Copilot が使用する LLM リクエストの数を完全に制御する必要があります。

#### [編集モードの使用](#using-edit-mode)

1.  編集セッションを開始するには、メニュー バーの **\[ Copilot\]** をクリックし、**\[Open GitHub Copilot Chat\]** を選びます。
2.  チャット パネルの上部で、**\[Copilot Edits\]** をクリックします。
3.  関連ファイルを "作業セット" に追加して、作業対象のファイルを GitHub Copilot に示します。\_\_ **\[Add all open files\]** をクリックして開いているすべてのファイルを追加するか、個々のファイルを個別に検索できます。
4.  プロンプトを送信します。 プロンプトに応じて、Copilot Edits によって "作業セット" 内の変更対象のファイルが判断され、変更の簡単な説明が追加されます。\_\_
5.  変更内容を確認し、各ファイルの編集内容を **\[Accept\]** または **\[Discard\]** します。

### [エージェント モード](#agent-mode)

**エージェント モード**: 特定のタスクを念頭に置いて、Copilot を有効にしてコードを自律的に編集できるようにする場合は、エージェント モードを使います。 エージェント モードでは、Copilot がどのファイルに変更を加えるかを決定し、タスクを完了するためのコード変更とターミナル コマンドを提供し、元のタスクが完了するまで issue の修復を繰り返します。

#### [エージェント モードの使用](#using-agent-mode)

1.  Copilot Chat パネルを開くには、Eclipse の下部にあるステータス バーで Copilot アイコン () をクリックし、**\[Open Chat\]** をクリックします。
2.  チャット パネルの上部にある **\[Agent\]** タブをクリックします。
3.  プロンプトを送信します。 プロンプトに応じて、Copilot によってエディター内の編集内容がストリーミングされ、作業セットが更新され、必要に応じて、実行すべきターミナル コマンドが提案されます。
4.  変更を確認します。 Copilot からターミナル コマンドが提案された場合は、Copilot でそれらを実行できるかどうかを確認します。 これに応じて、Copilot によって追加のアクションが繰り返し実行され、元のプロンプトのタスクが完了されます。

Copilot エージェント モードを使う場合、送信するプロンプトごとに 1 件の Premium リクエストとしてカウントされ、モデルのレートが乗算されます。 タスクを完了するために、Copilot によって複数のフォローアップ アクションが実行される場合があります。ただし、このようなフォローアップ アクションは Premium リクエストの使用にはカウントされません。 ユーザーが入力したプロンプトのみが課金対象です。エージェントによるツールの呼び出しやバックグラウンド ステップには課金されません。

使った Premium リクエストの合計数は、ユーザーが入力したプロンプト数とユーザーが選んだモデルによって変わります。 「[Premium リクエストについて](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/monitoring-usage-and-entitlements/avoiding-unexpected-copilot-costs)」をご覧ください。

## [フィードバックを送る](#sharing-feedback)

Copilot Chat に関するフィードバックを共有するには、JetBrains の **\[share feedback\]** リンクを使用できます。

1.  JetBrains IDE ウィンドウの右側にある **Copilot Chat** アイコンをクリックして、Copilot Chat ウィンドウを開きます。
    
    ![アクティビティ バーにある Copilot Chat アイコンのスクリーンショット。](/assets/cb-37277/images/help/copilot/jetbrains-copilot-chat-icon.png)
    
2.  Copilot Chat ウィンドウの上部にある **\[share feedback\]** リンクをクリックします。
    
    ![Copilot Chat ウィンドウの [share feedback] リンクのスクリーンショット。](/assets/cb-130879/images/help/copilot/jetbrains-share-feedback.png)
    

## [参考資料](#further-reading)

-   [Copilot Chat のプロンプト エンジニアリング](/ja/enterprise-cloud@latest/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
-   [GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/copilot-chat-in-github/using-github-copilot-chat-in-githubcom)
-   [IDE での GitHub Copilot Chat の責任ある使用](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/about-github-copilot-chat)
-   [GitHub プレリリース ライセンス条項](/ja/site-policy/github-terms/github-copilot-pre-release-terms)
-   [追加の製品および機能に適用される GitHub 条件](/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page)
-   [GitHub Copilot FAQ](https://github.com/features/copilot#faq)