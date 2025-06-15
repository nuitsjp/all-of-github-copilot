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

## [関連情報](#references)

既定では、Copilot Chat は開いているファイルまたは選択したコードを参照します。 # に続けてファイル名、ファイル名と行番号、またはソリューションを指定し、特定のファイル、行、またはソリューションを参照することもできます。

例

説明

`Where are the tests in #MyFile.cs?`

特定のファイルを参照する

`How are these files related #MyFile.cs #MyFile2.cs`

複数のファイルを参照する

`Explain this function #MyFile.cs: 66-72?`

ファイル内の特定の行を参照する

`Is there a delete method in this #solution?`

現在のファイルを参照する

この記事のこのバージョンは、Copilot in JetBrains 向けです。 この記事の他のバージョンについては、上のタブをクリックします。

## [GitHub Copilot の機能強化について](#github-copilot-の機能強化について-3)

さまざまなコマンドとオプションを使って、Copilot Chat のエクスペリエンスを向上させることができます。 取り組んでいるタスクに適したコマンドまたはオプションを見つけると、より効率的に目標を達成することができます。 このチート シートは、Copilot Chat を使う際に最も一般的なコマンドとオプションのクイック リファレンスとして利用できます。

Copilot Chat in JetBrains の概要については、「[IDE で GitHub Copilot に質問する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide)」を参照してください。

## [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使うには、チャット プロンプト ボックスに「`/`」と入力し、それに続けてコマンド名を入力します。

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際に最も一般的なスラッシュ コマンドの一覧を次に示します。

command

説明

`/explain`

アクティブなエディターのコードがどのように機能するかについて説明します。

`/fix`

選んだコードの問題の修正プログラムを提案します。

`/help`

GitHub Copilot の使用に関するクイック リファレンスと基本。

`/tests`

選んだコードの単体テストを生成します。

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

使用できるスラッシュ コマンドは、環境やチャットのコンテキストによって異なります。 現在使用できるスラッシュ コマンドの一覧を表示するには、現在の環境のチャット プロンプト ボックスに「`/`」と入力します。 Copilot Chat を使う際のスラッシュ コマンドの一覧を次に示します。

command

説明

`/doc`

このシンボルのドキュメントを生成します。

`/explain`

選んだコードの説明を表示します。

`/fix`

コード エラーや入力ミスの修正を提案します。

`/simplify`

現在のコードの選択を簡略化します。

`/tests`

現在のコード選択に対する単体テストを作成します。