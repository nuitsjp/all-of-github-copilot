# IDE で GitHub Copilot に質問する - GitHub Enterprise Cloud Docs

# IDE で GitHub Copilot に質問する

エディターで Copilot Chat を使用して、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

## Tool navigation

## この記事の内容

## [前提条件](#prerequisites)

-   **GitHub Copilot** へのアクセス権。 「[GitHub Copilot とは何ですか?](/ja/enterprise-cloud@latest/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
-   **Visual Studio Code の最新バージョン**。 [Visual Studio Code のダウンロード ページ](https://code.visualstudio.com/Download)を参照してください。
-   **Visual Studio Code での GitHub にサイン インします**。 認証に issue が発生した場合は、「[GitHub Copilot Chat での問題のトラブルシューティング](/ja/enterprise-cloud@latest/copilot/troubleshooting-github-copilot/troubleshooting-issues-with-github-copilot-chat#troubleshooting-authentication-issues-in-your-editor)」を参照してください。

Organization または Enterprise を介して GitHub Copilot にアクセスできる場合、organization 所有者 または Enterprise 管理者 が会話を無効にしている場合、GitHub Copilot Chat を使用することはできません。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-github-copilot-in-your-organization/managing-policies-and-features-for-copilot-in-your-organization)」をご覧ください。

## [プロンプトの送信](#submitting-prompts)

Copilot Chat に、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

1.  チャット ビューを開くには、Visual Studio Code のタイトル バーにある アイコンをクリックします。 アイコンが表示されない場合は、タイトル バーを右クリックして、**\[Command Center\]** が選択されていることを確認します。
    
    ![濃いオレンジ色の枠線で強調表示されている [Copilot Chat] ボタンのスクリーンショット。](/assets/cb-72745/images/help/copilot/vsc-copilot-chat-icon.png)
    
2.  プロンプト ボックスにプロンプトを入力するか、推奨されるプロンプトのいずれかをクリックします。 使用できるプロンプトの種類の概要については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。
    
3.  Copilot の応答を評価し、必要に応じてフォローアップ要求を行います。
    
    応答には、テキスト、コード ブロック、ボタン、画像、URI、およびファイル ツリーが含まれている場合があります。 応答には、多くの場合、対話型要素が含まれます。 たとえば、応答には、コード ブロックを挿入するメニューや、Visual Studio Code コマンドを呼び出すボタンが含まれる場合があります。
    
    Copilot Chat が回答の生成に使ったファイルを確認するには、回答の先頭にある **\[Used _n_ references\]** ドロップダウンを選びます。 リファレンスには、リポジトリのカスタム命令ファイルへのリンクを含めることができます。 このファイルには、応答の品質を向上させるために、すべてのチャットの質問に自動的に追加される追加情報が含まれています。 詳しくは、「[GitHub Copilot のリポジトリ カスタム命令を追加する](/ja/enterprise-cloud@latest/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot)」をご覧ください。
    

## [プロンプトでキーワード (keyword)を使用する](#using-keywords-in-your-prompt)

特別なキーワード (keyword) を使用することで、Copilot がプロンプトを理解するのに役立ちます。 例については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。

### [チャット参加者](#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。

Copilot Chat は、ユーザーの自然言語プロンプトに基づいて関連するチャット参加者を推測でき、プロンプトで使いたい参加者を明示的に指定しなくても、高度な機能の検出が向上します。

メモ

現在、チャット参加者の自動推論は パブリック プレビュー 段階であり、変更される可能性があります。

また、チャット参加者を手動で指定して、プロンプトのスコープを特定のドメインに絞り込むこともできます。 これを行うには、チャット プロンプト ボックスに「`@`」と入力し、その後にチャット参加者の名前を入力します。

使用できるチャット参加者の一覧を表示するには、チャット プロンプト ボックスに「`@`」と入力します。 Visual Studio Code ドキュメントの「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#chat-participants)」または「[チャット参加者](https://code.visualstudio.com/docs/copilot/copilot-chat#_chat-participants)」も参照してください。

### [Copilot Extensions チャット参加者](#copilot-extensions-チャット参加者)

チャット参加者を提供する Copilot Extensions をインストールすることもできます。 [GitHub Marketplace](https://github.com/marketplace?type=apps&copilot_app=true) および [Visual Studio Code Marketplace](https://marketplace.visualstudio.com/search?target=VSCode&category=Chat&sortBy=Installs) からこれらの拡張機能をインストールできます。 チャット参加者を提供する GitHub Marketplace からの拡張機能については、「[拡張情報を使用して外部ツールを Copilot Chat と統合する](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/github-copilot-extensions/about-github-copilot-extensions)」を参照してください。

### [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。 Visual Studio Code ドキュメントの「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#slash-commands)」または「[スラッシュ コマンド](https://code.visualstudio.com/docs/copilot/copilot-chat#_slash-commands)」も参照してください。

### [チャット変数](#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

使用可能なすべてのチャット変数を表示するには、チャット プロンプト ボックスに 「`#`」 と入力します。 Visual Studio Code ドキュメントの「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#chat-variables)」または[チャットの変数](https://code.visualstudio.com/docs/copilot/copilot-chat#_chat-variables)に関する記事も参照してください。

## [Copilot の GitHub スキルの使用](#copilot-の-github-スキルの使用)

Copilot の GitHub 固有のスキルは、Copilot が提供できる情報の種類を拡張します。 Copilot Chat でこれらのスキルにアクセスするには、質問に「`@github`」を含めます。

質問に `@github` を追加すると、Copilot によって、質問の内容に基づいて適切なスキルが動的に選択されます。 また、特定のスキルを使用するように Copilot Chat に明示的に要求することもできます。 次の 2 つの方法で行います。

-   自然言語を使用して、スキルを使用するように Copilot Chat に依頼します。 たとえば、`@github Search the web to find the latest GPT model from OpenAI.` のように指定します。
-   Web 検索を具体的に呼び出すには、質問に `#web` 変数を含めることができます。 たとえば、`@github #web What is the latest LTS of Node.js?` のように指定します。

Copilot に問い合わせ、現在使用可能なスキルの一覧を生成できます: `@github What skills are available?`

## [ナレッジ ベースについて質問する](#asking-a-question-about-a-knowledge-base)

メモ

この機能は、Copilot Enterprise サブスクリプションがある場合にのみ使用できます。

組織の所有者は、1 つまたは複数のリポジトリにまたがる Markdown ドキュメントをグループ化したナレッジ ベースを作成できます。 詳しくは、「[Copilot サポート技術情報の管理](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-github-copilot-features-in-your-organization/managing-copilot-knowledge-bases)」をご覧ください。

Copilot に、サポート技術情報のコンテキスト内で質問に回答するように指示できます。

1.  Copilot Chat ウィンドウの下部にある **\[Ask Copilot or type / for commands\]** テキスト ボックスに「`@github #kb`」と入力し、**Enter** キーを押してナレッジ ベース セレクターを開きます。
2.  矢印キーを使用して使用可能なサポート情報のいずれかを選択し、**Enter** キーを押します。
3.  **\[コマンドについて/Copilot に質問するか入力する\]** テキスト ボックスでは、質問付きのメッセージを続け、**Enter** キーを押します。
4.  Copilot Chat により質問が処理され、チャット ウィンドウにナレッジ ベースの引用を含む回答が提供されます。

## [Copilot Chat の AI モデル](#copilot-chat-の-ai-モデル)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [Copilot Chat にアクセスするその他の方法](#copilot-chat-にアクセスするその他の方法)

チャット ビューを使用してプロンプトを送信するだけでなく、他の方法でプロンプトを送信することもできます。

-   **クイック チャット:** クイック チャット ドロップダウンを開くには、⇧+⌥+⌘+L キー (Mac) または Ctrl+Shift+Alt+L キー (Windows/Linux) を押します。
-   **インライン**: エディターまたは統合ターミナルで直接インライン チャットを開始するには、Command+i (Mac) / Ctrl+i (Windows/Linux) と入力します。
-   **スマート アクション:** コンテキスト メニューからプロンプトを送信するには、エディター内で右クリックし、表示されるメニューで **\[Copilot\]** を選び、いずれかのアクションを選びます。 スマート アクションには、コード行を選択したときに表示されるきらめきアイコンを使用してアクセスすることもできます。

詳細については、Visual Studio Code ドキュメントの[インライン チャット](https://code.visualstudio.com/docs/copilot/copilot-chat#_inline-chat)、[クイック チャット](https://code.visualstudio.com/docs/copilot/copilot-chat#_quick-chat)、[チャット スマート アクション](https://code.visualstudio.com/docs/copilot/copilot-chat#_chat-smart-actions)を参照してください。

## [Copilot Edits](#copilot-edits)

1 つの Copilot Chat プロンプトから複数のファイルに直接変更を加えるには、Copilot Edits を使用します。 Copilot Edits には次のモードがあります。

-   [編集モード](#edit-mode)を使うと、Copilot で複数のファイルに対して制御された編集を行うことができます。
-   [エージェント モード](#agent-mode)を使うと、設定されたタスクを Copilot で自律的に実行できます。

### [編集モード](#edit-mode)

編集モードは、Visual Studio Code と JetBrains IDE でのみ使用できます。

Copilot から提案される編集をより詳細に制御する場合は、編集モードを使います。 編集モードでは、Copilot が変更できるファイルを選び、各繰り返しで Copilot にコンテキストを提供し、各ターン後に提案された編集を受け入れるかどうかを決定します。

編集モードは、次のユース ケースに最適です。

-   定義された一連のファイルに対して、迅速かつ具体的な更新を行う必要があります。
-   Copilot が使用する LLM リクエストの数を完全に制御する必要があります。

#### [編集モードの使用](#using-edit-mode)

1.  編集セッションを開始するには、Copilot Chat メニューから **\[Open Chat\]** を選びます。
    
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Edit\]** を選択します。
    
    ![Copilot Chat モード ドロップダウンのスクリーンショット。 [Edit] オプションが濃いオレンジ色の枠線で囲まれています。](/assets/cb-44012/images/help/copilot/chat-mode-vscode.png)
    
3.  必要に応じて、関連ファイルを\_作業セット\_に追加して、作業対象のファイルを GitHub Copilot に示します。
    
4.  プロンプトを送信します。 プロンプトに応じて、Copilot Edits によって "作業セット" 内の変更対象のファイルが判断され、変更の簡単な説明が追加されます。\_\_
    
5.  変更内容を確認し、各ファイルの編集内容を **\[適用\]** または **\[破棄\]** します。
    

詳細な手順については、Visual Studio Code ドキュメントの「[Copilot Edits](https://code.visualstudio.com/docs/copilot/copilot-edits)」を参照してください。

### [エージェント モード](#agent-mode)

**エージェント モード**: 特定のタスクを念頭に置いて、Copilot を有効にしてコードを自律的に編集できるようにする場合は、エージェント モードを使います。 エージェント モードでは、Copilot がどのファイルに変更を加えるかを決定し、タスクを完了するためのコード変更とターミナル コマンドを提供し、元のタスクが完了するまで issue の修復を繰り返します。

#### [エージェント モードの使用](#using-agent-mode)

1.  編集セッションを開始するには、Copilot Chat メニューから **\[Open Chat\]** を選びます。
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Agent\]** を選択します。
3.  プロンプトを送信します。 プロンプトに応じて、Copilot によってエディター内の編集内容がストリーミングされ、作業セットが更新され、必要に応じて、実行すべきターミナル コマンドが提案されます。
4.  変更を確認します。 Copilot からターミナル コマンドが提案された場合は、Copilot でそれらを実行できるかどうかを確認します。 これに応じて、Copilot によって追加のアクションが繰り返し実行され、元のプロンプトのタスクが完了されます。

直接 [VS Code でエージェント モードを開く](vscode://GitHub.Copilot-Chat/chat?mode=agent)こともできます。

詳細については、Visual Studio Code ドキュメントの「[Copilot Edits](https://aka.ms/vscode-copilot-agent)」を参照してください。

Copilot エージェント モードを使う場合、送信するプロンプトごとに 1 件の Premium リクエストとしてカウントされ、モデルのレートが乗算されます。 タスクを完了するために、Copilot によって複数のフォローアップ アクションが実行される場合があります。ただし、このようなフォローアップ アクションは Premium リクエストの使用にはカウントされません。 ユーザーが入力したプロンプトのみが課金対象です。エージェントによるツールの呼び出しやバックグラウンド ステップには課金されません。

使った Premium リクエストの合計数は、ユーザーが入力したプロンプト数とユーザーが選んだモデルによって変わります。 「[Premium リクエストについて](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/monitoring-usage-and-entitlements/avoiding-unexpected-copilot-costs)」をご覧ください。

## [Copilot Chat での画像の使用](#copilot-chat-での画像の使用)

メモ

-   現在、チャット プロンプトへの画像の添付は パブリック プレビュー 段階であり、変更される可能性があります。
-   Copilot Business または Copilot Enterprise プランをお使いの場合、そのプランを提供する organization または Enterprise で、**\[Editor preview features\]** の設定を有効にする必要があります。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#enabling-copilot-features-in-your-organization)」または「[企業内の Copilot のポリシーと機能を管理する](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#configuring-policies-for-github-copilot)」を参照してください。

チャット プロンプトに画像を添付してから、画像について Copilot に問い合わせることができます。 たとえば、次のようなものを添付できます。

-   コード スニペットのスクリーンショットを添付して、コードの説明を Copilot に依頼します。
-   アプリケーションのユーザー インターフェイスのモックアップを添付して、コードの生成を Copilot に依頼します。
-   フローチャートを添付して、画像で示されているプロセスについての説明を Copilot に依頼します。
-   Web ページのスクリーンショットを添付して、同様のページの HTML の生成を Copilot に依頼します。

メモ

サポートされている画像ファイルの種類は、JPEG (`.jpg`、`.jpeg`)、PNG (`.png`)、GIF (`.gif`)、WEBP (`.webp`) です。

### [チャット プロンプトへの画像の添付](#attaching-images-to-your-chat-prompt)

1.  チャット ビューの右下に AI モデル ピッカーが表示される場合は、プロンプトへの画像の追加をサポートするモデルのいずれかを選びます。
    
    -   GPT-4.1 (モデル ピッカーが表示されない場合に使われる既定値)
    -   GPT-4o
    -   Claude Sonnet 3.5
    -   Claude Sonnet 3.7
    -   Gemini 2.0 Flash
    -   Gemini 2.5 Pro
    
    ![モデル ピッカーが濃いオレンジ色の枠線で強調表示されている Copilot Chat のスクリーンショット。](/assets/cb-4047/images/help/copilot/vsc-chat-model-picker.png)
    
2.  次のいずれかの操作を行います。
    
    -   画像をコピーしてチャット ビューに貼り付けます。
    -   オペレーティング システムのエクスプローラーまたは VS Code のエクスプローラーから、1 つ以上の画像ファイルをチャット ビューにドラッグ アンド ドロップします。
    -   VS Code エクスプローラーで画像ファイルを右クリックし、**\[Copilot\]** をクリックしてから **\[Add File to Chat\]** をクリックします。
3.  画像に添えるプロンプトをチャット ビューに入力します。 たとえば、 `explain this diagram`、 `describe each of these images in detail`、 `what does this error message mean` などです。
    

## [フィードバックを送る](#sharing-feedback)

応答が役に立ったかどうかを示すには、応答の横に表示されるサムアップアイコンとサムダウン アイコンを使用します。

GitHub Copilot Chat 拡張機能に関するフィードバックを残すには、[microsoft/vscode-copilot-release](https://github.com/microsoft/vscode-copilot-release/issues) リポジトリで issue を開きます。

## [参考資料](#further-reading)

-   [Copilot Chat のプロンプト エンジニアリング](/ja/enterprise-cloud@latest/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
-   Visual Studio Code ドキュメントの「[Copilot Chat in VS Code の使用](https://code.visualstudio.com/docs/copilot/copilot-chat)」と「[GitHub Copilot Chat in VS Code の概要](https://code.visualstudio.com/docs/copilot/getting-started-chat)」
-   [GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/copilot-chat-in-github/using-github-copilot-chat-in-githubcom)
-   [IDE での GitHub Copilot Chat の責任ある使用](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/about-github-copilot-chat)
-   [追加の製品および機能に適用される GitHub 条件](/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page)
-   [GitHub Copilot FAQ](https://github.com/features/copilot#faq)

## [前提条件](#prerequisites)

-   **GitHub Copilot** へのアクセス権。 「[GitHub Copilot とは何ですか?](/ja/enterprise-cloud@latest/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
    
-   **Visual Studio 2022 バージョン 17.8 以降**。 Visual Studio ドキュメントの「[Visual Studio のインストール](https://learn.microsoft.com/visualstudio/install/install-visual-studio)」を参照してください。
    
-   _Visual Studio 17.8 および 17.9 の場合:_
    
    -   **GitHub Copilot 拡張機能**。 Visual Studio ドキュメントの「[Visual Studio で GitHub Copilot をインストールする](https://learn.microsoft.com/visualstudio/ide/visual-studio-github-copilot-install-and-states)」を参照してください。
    -   **GitHub Copilot Chat 拡張機能**。 Visual Studio ドキュメントの「[Visual Studio で GitHub Copilot をインストールする](https://learn.microsoft.com/visualstudio/ide/visual-studio-github-copilot-install-and-states)」を参照してください。
    
    _Visual Studio 17.10 以降には、GitHub Copilot および GitHub Copilot Chat 拡張機能が組み込まれています。これらを個別にインストールする必要はありません。_
    
-   **Visual Studio で GitHub にサインイン**します。 認証に issue が発生した場合は、「[GitHub Copilot Chat での問題のトラブルシューティング](/ja/enterprise-cloud@latest/copilot/troubleshooting-github-copilot/troubleshooting-issues-with-github-copilot-chat#troubleshooting-authentication-issues-in-your-editor)」を参照してください。
    

Organization または Enterprise を介して GitHub Copilot にアクセスできる場合、organization 所有者 または Enterprise 管理者 が会話を無効にしている場合、GitHub Copilot Chat を使用することはできません。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-github-copilot-in-your-organization/managing-policies-and-features-for-copilot-in-your-organization)」をご覧ください。

## [プロンプトの送信](#submitting-prompts)

Copilot Chat に、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

1.  Visual Studio メニュー バーの **\[View\]** をクリックしてから **\[GitHub Copilot Chat\]** をクリックします。
    
2.  Copilot Chat ウィンドウでプロンプトを入力し、**Enter** キーを押します。 プロンプトの例については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。
    
3.  Copilot の応答を評価し、必要に応じてフォローアップ プロンプトを送信します。
    
    多くの場合、応答には対話型要素が含まれます。 たとえば、応答には、コード ブロックの結果をコピー、挿入、またはプレビューするボタンが含まれる場合があります。
    
    Copilot Chat が回答の生成に使用したファイルを確認するには、回答の下にある **\[References\]** リンクをクリックします。 リファレンスには、リポジトリのカスタム命令ファイルへのリンクを含めることができます。 このファイルには、応答の品質を向上させるために、すべてのチャットの質問に自動的に追加される追加情報が含まれています。 詳しくは、「[GitHub Copilot のリポジトリ カスタム命令を追加する](/ja/enterprise-cloud@latest/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot)」をご覧ください。
    

## [プロンプトでキーワード (keyword)を使用する](#using-keywords-in-your-prompt)

特別なキーワード (keyword) を使用することで、Copilot がプロンプトを理解するのに役立ちます。

### [Copilot Chat の拡張](#copilot-chat-の拡張)

GitHub Copilot Extensions は、外部ツールの機能を Copilot Chat に統合することで、コンテキストの切り替えを減らし、ドメイン固有のコンテキストで応答を受信するのに役立ちます。 GitHub Marketplace から Copilot Extensions をインストールするか、organization 内にあるプライベートの Copilot Extensions をビルドし、チャット ウィンドウに「`@`」と入力すると、使用可能な拡張機能の一覧を表示できます。 拡張機能を使用するには、一覧から拡張機能を選択するか、完全な置換フィールド名を入力し、プロンプトを入力します。

詳しくは、「[拡張情報を使用して外部ツールを Copilot Chat と統合する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/using-extensions-to-integrate-external-tools-with-copilot-chat)」をご覧ください。

### [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。 Visual Studio ドキュメントの「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#slash-commands)」または「[スラッシュ コマンド](https://learn.microsoft.com/visualstudio/ide/copilot-chat-context#slash-commands)」も参照してください。

### [関連情報](#references)

既定では、Copilot Chat は開いているファイルまたは選択したコードを参照します。 `#` を使用してその後に 1 つのファイル名、ファイル名および行番号、または `solution` を続け、特定のファイル、行、またはソリューションを参照することもできます。

Visual Studio ドキュメントの「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=visualstudio#references)」または「[リファレンス](https://learn.microsoft.com/visualstudio/ide/copilot-chat-context#reference)」も参照してください。

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

## [Copilot Chat の AI モデル](#copilot-chat-の-ai-モデル-1)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [Copilot Chat にアクセスするその他の方法](#copilot-chat-にアクセスするその他の方法-1)

チャット ウィンドウからプロンプトを送信するだけでなく、プロンプトをインラインで送信できます。 インライン チャットを開始するには、エディター ウィンドウで右クリックし、**\[Copilot に質問する\]** を選択します。

詳細については、Visual Studio ドキュメントの「[インライン チャット ビューで質問する](https://learn.microsoft.com/visualstudio/ide/visual-studio-github-copilot-chat#ask-questions-in-the-inline-chat-view)」を参照してください。

## [Copilot Edits](#copilot-edits-1)

メモ

-   この機能は現在 パブリック プレビュー にあり、変更される可能性があります。
-   Visual Studio 17.14 以降で使用可能。

Copilot Edits を使うと、1 つの Copilot Chat プロンプトから複数のファイルに変更を加えることができます

特定のタスクについて、Copilot でコードを自律的に編集できるようにしたい場合は、エージェント モードを使います。 エージェント モードでは、Copilot がどのファイルに変更を加えるかを決定し、タスクを完了するためのコード変更とターミナル コマンドを提供し、元のタスクが完了するまで issue の修復を繰り返します。

### [エージェント モードの使用](#using-agent-mode)

1.  Visual Studio メニュー バーの **\[View\]** をクリックしてから **\[GitHub Copilot Chat\]** をクリックします。
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Agent\]** を選択します。
3.  プロンプトを送信します。 プロンプトに応じて、Copilot によってエディター内の編集内容がストリーミングされ、作業セットが更新され、必要に応じて、実行すべきターミナル コマンドが提案されます。
4.  変更を確認します。 Copilot からターミナル コマンドが提案された場合は、Copilot でそれらを実行できるかどうかを確認します。 これに応じて、Copilot によって追加のアクションが繰り返し実行され、元のプロンプトのタスクが完了されます。

エージェント モードを使用すると、Copilot は 1 つのタスクを完了するために複数の Premium リクエストを行う場合があります。 これには、ユーザーが開始したプロンプトと、Copilot がユーザーに代わって実行するフォローアップ アクションの両方が含まれます。 使用される Premium リクエストの合計数は、タスクの複雑さ、関連するステップの数、選択したモデルによって異なります。 「[Premium リクエストについて](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/monitoring-usage-and-entitlements/avoiding-unexpected-copilot-costs)」を参照してください。

## [Copilot Chat での画像の使用](#copilot-chat-での画像の使用-1)

メモ

-   現在、チャット プロンプトへの画像の添付は パブリック プレビュー 段階であり、変更される可能性があります。
-   Copilot Business または Copilot Enterprise プランをお使いの場合、そのプランを提供する organization または Enterprise で、**\[Editor preview features\]** の設定を有効にする必要があります。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#enabling-copilot-features-in-your-organization)」または「[企業内の Copilot のポリシーと機能を管理する](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#configuring-policies-for-github-copilot)」を参照してください。

チャット プロンプトに画像を添付してから、画像について Copilot に問い合わせることができます。 たとえば、次のようなものを添付できます。

-   コード スニペットのスクリーンショットを添付して、コードの説明を Copilot に依頼します。
-   アプリケーションのユーザー インターフェイスのモックアップを添付して、コードの生成を Copilot に依頼します。
-   フローチャートを添付して、画像で示されているプロセスについての説明を Copilot に依頼します。
-   Web ページのスクリーンショットを添付して、同様のページの HTML の生成を Copilot に依頼します。

メモ

サポートされている画像ファイルの種類は、JPEG (`.jpg`、`.jpeg`)、PNG (`.png`)、GIF (`.gif`)、WEBP (`.webp`) です。

### [チャット プロンプトへの画像の添付](#attaching-images-to-your-chat-prompt)

1.  チャット ビューの右下に AI モデル ピッカーが表示される場合は、プロンプトへの画像の追加をサポートするモデルのいずれかを選びます。
    
    -   GPT-4.1 (モデル ピッカーが表示されない場合に使われる既定値)
    -   GPT-4o
    -   Claude Sonnet 3.5
    -   Claude Sonnet 3.7
    -   Gemini 2.0 Flash
    -   Gemini 2.5 Pro
2.  次のいずれかの操作を行います。
    
    -   画像をコピーしてチャット ビューに貼り付けます。
    -   チャット ビューの右下のクリップ アイコンをクリックし、**\[Upload Image\]** をクリックし、添付する画像ファイルを参照し、それを選択して **\[Open\]** をクリックします。
    
    必要に応じて複数の画像を追加できます。
    
3.  画像に添えるプロンプトをチャット ビューに入力します。 たとえば、`explain this image`、または `describe each of these images in detail` です。
    

## [フィードバックを送る](#sharing-feedback)

Copilot Chat に関するフィードバックを共有するには、Visual Studio の **\[Send feedback\]** ボタンを使用できます。 Visual Studio に対するフィードバックの提供の詳細については、[「Visual Studio フィードバック](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-report-a-problem-with-visual-studio?view=vs-2022)」のドキュメントを参照してください。

1.  \[Visual Studio\] ウィンドウの右上隅にある **\[フィードバックの送信\]** ボタンをクリックしてください。
    
    ![Visual Studio の [フィードバックの共有] ボタンのスクリーンショット。](/assets/cb-76215/images/help/copilot/vs-share-feedback-button.png)
    
2.  ご自分のフィードバックを最もよく表している選択肢を選んでください。
    
    -   バグを報告するには、 **\[問題の報告\]** をクリックしてください。
    -   機能を要求するには、 **\[機能の提案\]** をクリックしてください。

## [参考資料](#further-reading)

-   [Copilot Chat のプロンプト エンジニアリング](/ja/enterprise-cloud@latest/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
-   [Microsoft Learn ドキュメントの「GitHub Copilot Chat in Visual Studio を使用する」](https://learn.microsoft.com/visualstudio/ide/visual-studio-github-copilot-chat?view=vs-2022#use-copilot-chat-in-visual-studio)
-   [Microsoft Learn ドキュメントの「GitHub Copilot Chat の結果を改善するためのヒント」](https://learn.microsoft.com/en-us/visualstudio/ide/copilot-chat-context?view=vs-2022)
-   [GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/copilot-chat-in-github/using-github-copilot-chat-in-githubcom)
-   [IDE での GitHub Copilot Chat の責任ある使用](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/about-github-copilot-chat)
-   [追加の製品および機能に適用される GitHub 条件](/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page)
-   [GitHub Copilot FAQ](https://github.com/features/copilot#faq)

## [前提条件](#prerequisites)

-   **GitHub Copilot** へのアクセス権。 「[GitHub Copilot とは何ですか?](/ja/enterprise-cloud@latest/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
    
-   **互換性のある JetBrains IDE**。 GitHub Copilot は、次の IDE と互換性があります。
    
    -   IntelliJ IDEA (Ultimate、Community、Educational)
    -   Android Studio
    -   AppCode
    -   CLion
    -   Code With Me ゲスト
    -   DataGrip
    -   DataSpell
    -   GoLand
    -   JetBrains クライアント
    -   MPS
    -   PhpStorm
    -   PyCharm (Professional、Community、Educational)
    -   Rider
    -   RubyMine
    -   RustRover
    -   WebStorm
    -   Writerside
    
    ダウンロードするには、[JetBrains IDE](https://www.jetbrains.com/products/) のツール ファインダーを参照してください。
    
-   **GitHub Copilot プラグイン**。 JetBrains Marketplace で「[GitHub Copilot プラグイン](https://plugins.jetbrains.com/plugin/17718-github-copilot)」を確認してください。 インストール手順については、「[環境への GitHub Copilot 拡張機能のインストール](/ja/enterprise-cloud@latest/copilot/configuring-github-copilot/installing-the-github-copilot-extension-in-your-environment)」を参照してください。
    
-   **JetBrains IDE で GitHub にログイン**。 認証手順については、「[環境への GitHub Copilot 拡張機能のインストール](/ja/enterprise-cloud@latest/copilot/configuring-github-copilot/installing-the-github-copilot-extension-in-your-environment?tool=jetbrains#installing-the-github-copilot-plugin-in-your-jetbrains-ide)」を参照してください。
    

Organization または Enterprise を介して GitHub Copilot にアクセスできる場合、organization 所有者 または Enterprise 管理者 が会話を無効にしている場合、GitHub Copilot Chat を使用することはできません。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-github-copilot-in-your-organization/managing-policies-and-features-for-copilot-in-your-organization)」をご覧ください。

## [プロンプトの送信](#submitting-prompts)

Copilot Chat に、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

1.  JetBrains IDE ウィンドウの右側にある **GitHub Copilot Chat** アイコンをクリックして、Copilot Chat ウィンドウを開きます。
    
    ![アクティビティ バーにある GitHub Copilot Chat アイコンのスクリーンショット。](/assets/cb-37277/images/help/copilot/jetbrains-copilot-chat-icon.png)
    
2.  プロンプト ボックスにプロンプトを入力します。 プロンプトの例については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。
    
3.  Copilot の応答を評価し、必要に応じてフォローアップ プロンプトを送信します。
    
    多くの場合、応答には対話型要素が含まれます。 たとえば、応答には、コード ブロックをコピーまたは挿入するボタンが含まれている場合があります。
    
    Copilot Chat が回答の生成に使用したファイルを表示するには、回答の下にある **\[References\]** ドロップダウンを選択します。
    

## [プロンプトでキーワード (keyword)を使用する](#using-keywords-in-your-prompt)

特別なキーワード (keyword)を使用すると、Copilot がプロンプトを理解するのに役立ちます。

### [チャット参加者](#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。 チャット参加者を使って、プロンプトのスコープを特定のドメインに限定できます。 これを行うには、チャット プロンプト ボックスに「`@`」と入力し、その後にチャット参加者の名前を入力します。

使用できるチャット参加者の一覧を表示するには、チャット プロンプト ボックスに「`@`」と入力します。 「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=jetbrains#chat-participants-1)」も参照してください。

### [Copilot Chat の拡張](#copilot-chat-の拡張-1)

GitHub Copilot Extensions は、外部ツールの機能を Copilot Chat に統合することで、コンテキストの切り替えを減らし、ドメイン固有のコンテキストで応答を受信するのに役立ちます。 GitHub Marketplace から Copilot Extensions をインストールするか、organization 内にあるプライベートの Copilot Extensions をビルドし、チャット ウィンドウに「`@`」と入力すると、使用可能な拡張機能の一覧を表示できます。 拡張機能を使用するには、一覧から拡張機能を選択するか、完全な置換フィールド名を入力し、プロンプトを入力します。

詳しくは、「[拡張情報を使用して外部ツールを Copilot Chat と統合する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/using-extensions-to-integrate-external-tools-with-copilot-chat)」をご覧ください。

### [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。 「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=jetbrains#slash-commands-2)」も参照してください。

### [ファイル参照](#file-references)

既定では、Copilot Chat は開いているファイルまたは選択したコードを参照します。 ファイルをチャットのプロンプト ボックスにドラッグして、参照するファイルを Copilot Chat に指定することもできます。 または、ファイルを右クリックして **\[GitHub Copilot\]** を選択し、**\[Reference File in Chat\]** (チャットの参照ファイル) を選択することもできます。

## [Copilot の GitHub スキルの使用](#copilot-の-github-スキルの使用-1)

Copilot の GitHub 固有のスキルは、Copilot が提供できる情報の種類を拡張します。 Copilot Chat でこれらのスキルにアクセスするには、質問に「`@github`」を含めます。

質問に `@github` を追加すると、Copilot によって、質問の内容に基づいて適切なスキルが動的に選択されます。 また、特定のスキルを使用するように Copilot Chat に明示的に要求することもできます。 次の 2 つの方法で行います。

-   自然言語を使用して、スキルを使用するように Copilot Chat に依頼します。 たとえば、`@github Search the web to find the latest GPT model from OpenAI.` のように指定します。
-   Web 検索を具体的に呼び出すには、質問に `#web` 変数を含めることができます。 たとえば、`@github #web What is the latest LTS of Node.js?` のように指定します。

Copilot に問い合わせ、現在使用可能なスキルの一覧を生成できます: `@github What skills are available?`

## [Copilot Chat の AI モデル](#copilot-chat-の-ai-モデル-2)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [Copilot Chat にアクセスするその他の方法](#copilot-chat-にアクセスするその他の方法-2)

-   **ビルトイン リクエスト**。 チャット ウィンドウからプロンプトを送信するだけでなく、ファイル上で右クリックして **GitHub Copilot** を選択してから、いずれか 1 つのオプションを選択して、ビルトイン リクエストを送信できます。
-   **インライン**。 チャット プロンプトをインラインで送信し、ハイライトされたコード ブロックまたは現在のファイルに範囲を設定できます。
    -   インライン チャットを開始するには、コード ブロックまたは現在のファイル内の任意の場所を右クリックし、**GitHub Copilot** の上にマウス ポインターを移動し、**\[ Copilot: Inline Chat\]** を選ぶか、Ctrl+Shift+I キーを押します。

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

1.  エージェント モードを使って編集セッションを開始するには、メニュー バーの **\[ Copilot\]** をクリックし、**\[Open GitHub Copilot Chat\]** を選びます。
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

## [前提条件](#prerequisites)

Xcode 用の GitHub Copilot を使用するには、Xcode の拡張機能用に GitHub Copilot をインストールする必要があります。 「[環境への GitHub Copilot 拡張機能のインストール](/ja/enterprise-cloud@latest/copilot/configuring-github-copilot/installing-the-github-copilot-extension-in-your-environment)」を参照してください。

Organization または Enterprise を介して GitHub Copilot にアクセスできる場合、organization 所有者 または Enterprise 管理者 が会話を無効にしている場合、GitHub Copilot Chat を使用することはできません。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-github-copilot-in-your-organization/managing-policies-and-features-for-copilot-in-your-organization)」をご覧ください。

## [プロンプトの送信](#submitting-prompts)

Copilot Chat に、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

1.  チャット ビューを開くには、メニュー バーの **\[Editor\]** をクリックし、**\[ Copilot\]**、**\[Open Chat\]** の順にクリックします。 新しいウィンドウに Copilot Chat が開きます。
    
2.  プロンプト ボックスにプロンプトを入力します。 プロンプトの例については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。
    
3.  Copilot の応答を評価し、必要に応じてフォローアップ プロンプトを送信します。
    
    多くの場合、応答には対話型要素が含まれます。 たとえば、応答には、コード ブロックをコピーまたは挿入するボタンが含まれている場合があります。
    

## [Copilot Chat の AI モデル](#copilot-chat-の-ai-モデル-3)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [プロンプトでキーワード (keyword)を使用する](#using-keywords-in-your-prompt)

特別なキーワード (keyword) を使用することで、Copilot がプロンプトを理解するのに役立ちます。

### [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。 詳しくは、「[GitHub Copilot Chat チート シート](/ja/enterprise-cloud@latest/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=xcode#slash-commands)」をご覧ください。

## [Copilot エージェント モード](#copilot-エージェント-モード)

**エージェント モード**: 特定のタスクを念頭に置いて、Copilot を有効にしてコードを自律的に編集できるようにする場合は、エージェント モードを使います。 エージェント モードでは、Copilot がどのファイルに変更を加えるかを決定し、タスクを完了するためのコード変更とターミナル コマンドを提供し、元のタスクが完了するまで issue の修復を繰り返します。

### [エージェント モードの使用](#using-agent-mode)

1.  チャット ビューを開くには、メニュー バーの **\[ Copilot\]** をクリックし、**\[Open Chat\]** をクリックします。
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Agent\]** を選択します。
3.  必要に応じて、関連するファイルを "作業セット" ビューに追加して、作業するファイルを Copilot に示します。\_\_
4.  プロンプトを送信します。 プロンプトに応じて、Copilot によってエディター内の編集内容がストリーミングされ、作業セットが更新され、必要に応じて、実行すべきターミナル コマンドが提案されます。
5.  変更を確認します。 Copilot からターミナル コマンドが提案された場合は、Copilot でそれらを実行できるかどうかを確認します。 これに応じて、Copilot によって追加のアクションが繰り返し実行され、元のプロンプトのタスクが完了されます。

Copilot エージェント モードを使う場合、送信するプロンプトごとに 1 件の Premium リクエストとしてカウントされ、モデルのレートが乗算されます。 タスクを完了するために、Copilot によって複数のフォローアップ アクションが実行される場合があります。ただし、このようなフォローアップ アクションは Premium リクエストの使用にはカウントされません。 ユーザーが入力したプロンプトのみが課金対象です。エージェントによるツールの呼び出しやバックグラウンド ステップには課金されません。

使った Premium リクエストの合計数は、ユーザーが入力したプロンプト数とユーザーが選んだモデルによって変わります。 「[Premium リクエストについて](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/monitoring-usage-and-entitlements/avoiding-unexpected-copilot-costs)」をご覧ください。

## [ファイル参照](#file-references)

既定では、Copilot Chat は開いているファイルまたは選択したコードを参照します。 特定のファイルをリファレンスとして添付するには、チャット プロンプト ボックスで \[\] をクリックします。

## [チャット管理](#chat-management)

Xcode IDE ごとに会話スレッドを開いて、コンテキストごとにディスカッションを整理しておくことができます。 チャット履歴で以前の会話に戻ることや、過去の提案を参照することができます。

## [フィードバックを送る](#sharing-feedback)

回答が役に立ったかどうかを示すには、回答の横に表示される \[\] または \[\] を使います。

## [参考資料](#further-reading)

-   [Copilot Chat のプロンプト エンジニアリング](/ja/enterprise-cloud@latest/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
-   [GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/copilot-chat-in-github/using-github-copilot-chat-in-githubcom)
-   [IDE での GitHub Copilot Chat の責任ある使用](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/about-github-copilot-chat)
-   [GitHub プレリリース ライセンス条項](/ja/site-policy/github-terms/github-copilot-pre-release-terms)
-   [追加の製品および機能に適用される GitHub 条件](/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page)
-   [GitHub Copilot FAQ](https://github.com/features/copilot#faq)

## [前提条件](#prerequisites)

-   **Copilot へのアクセス権**。 GitHub Copilot in Eclipse を使うには、アクティブな GitHub Copilot サブスクリプションが必要です。 Copilot のアクセス方法の詳細については、「[GitHub Copilot とは何ですか?](/ja/enterprise-cloud@latest/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
-   **Eclipse の互換バージョン**。 GitHub Copilot 拡張機能を使うには、Eclipse バージョン 2024-09 以降が必要です。 [Eclipse のダウンロード ページ](https://www.eclipse.org/downloads/packages/)を参照してください。
-   **GitHub Copilot 拡張機能の最新バージョン**。 これを [Eclipse Marketplace](https://aka.ms/copiloteclipse) からダウンロードします。 詳しくは、「[環境への GitHub Copilot 拡張機能のインストール](/ja/enterprise-cloud@latest/copilot/managing-copilot/configure-personal-settings/installing-the-github-copilot-extension-in-your-environment?tool=eclipse)」をご覧ください。
-   **Eclipse から GitHub にサインインします**。

Organization または Enterprise を介して GitHub Copilot にアクセスできる場合、organization 所有者 または Enterprise 管理者 が会話を無効にしている場合、GitHub Copilot Chat を使用することはできません。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-github-copilot-in-your-organization/managing-policies-and-features-for-copilot-in-your-organization)」をご覧ください。

## [プロンプトの送信](#submitting-prompts)

Copilot Chat に、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

1.  Copilot Chat パネルを開くには、Eclipse の下部にあるステータス バーで Copilot アイコン () をクリックし、**\[Open Chat\]** をクリックします。
    
2.  プロンプト ボックスにプロンプトを入力し、Enter キーを押します。
    
    使用できるプロンプトの種類の概要については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。
    
3.  Copilot の応答を評価し、必要に応じてフォローアップ要求を行います。
    

## [プロンプトでキーワード (keyword)を使用する](#using-keywords-in-your-prompt)

特別なキーワード (keyword) を使用することで、Copilot がプロンプトを理解するのに役立ちます。 例については、「[Copilot Chat のプロンプトの概要](/ja/enterprise-cloud@latest/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。

### [スラッシュ コマンド](#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。 たとえば、`/explain` を使って、現在エディターに表示されているファイル内のコードを Copilot に説明してもらいます。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。

## [Copilot Chat の AI モデル](#copilot-chat-の-ai-モデル-4)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](/ja/enterprise-cloud@latest/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [Copilot エージェント モード](#copilot-エージェント-モード-1)

**エージェント モード**: 特定のタスクを念頭に置いて、Copilot を有効にしてコードを自律的に編集できるようにする場合は、エージェント モードを使います。 エージェント モードでは、Copilot がどのファイルに変更を加えるかを決定し、タスクを完了するためのコード変更とターミナル コマンドを提供し、元のタスクが完了するまで issue の修復を繰り返します。

### [エージェント モードの使用](#using-agent-mode)

1.  Copilot Chat パネルを開くには、Eclipse の下部にあるステータス バーで Copilot アイコン () をクリックし、**\[Open Chat\]** をクリックします。
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Agent\]** を選択します。
3.  プロンプトを送信します。 プロンプトに応じて、Copilot によってエディター内の編集内容がストリーミングされ、作業セットが更新され、必要に応じて、実行すべきターミナル コマンドが提案されます。
4.  変更を確認します。 Copilot からターミナル コマンドが提案された場合は、Copilot でそれらを実行できるかどうかを確認します。 これに応じて、Copilot によって追加のアクションが繰り返し実行され、元のプロンプトのタスクが完了されます。

Copilot エージェント モードを使う場合、送信するプロンプトごとに 1 件の Premium リクエストとしてカウントされ、モデルのレートが乗算されます。 タスクを完了するために、Copilot によって複数のフォローアップ アクションが実行される場合があります。ただし、このようなフォローアップ アクションは Premium リクエストの使用にはカウントされません。 ユーザーが入力したプロンプトのみが課金対象です。エージェントによるツールの呼び出しやバックグラウンド ステップには課金されません。

使った Premium リクエストの合計数は、ユーザーが入力したプロンプト数とユーザーが選んだモデルによって変わります。 「[Premium リクエストについて](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/monitoring-usage-and-entitlements/avoiding-unexpected-copilot-costs)」をご覧ください。

## [参考資料](#further-reading)

-   [Copilot Chat のプロンプト エンジニアリング](/ja/enterprise-cloud@latest/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
-   [GitHub で GitHub Copilot に質問をする](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/copilot-chat-in-github/using-github-copilot-chat-in-githubcom)
-   [IDE での GitHub Copilot Chat の責任ある使用](/ja/enterprise-cloud@latest/copilot/github-copilot-chat/about-github-copilot-chat)
-   [追加の製品および機能に適用される GitHub 条件](/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page)
-   [GitHub Copilot FAQ](https://github.com/features/copilot#faq)