## [前提条件](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#prerequisites)

-   **GitHub Copilot** へのアクセス権。 「[GitHub Copilot とは何ですか?](https://docs.github.com/ja/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
-   **Visual Studio Code の最新バージョン**。 [Visual Studio Code のダウンロード ページ](https://code.visualstudio.com/Download)を参照してください。
-   **Visual Studio Code での GitHub にサイン インします**。 認証に issue が発生した場合は、「[GitHub Copilot Chat での問題のトラブルシューティング](https://docs.github.com/ja/copilot/troubleshooting-github-copilot/troubleshooting-issues-with-github-copilot-chat#troubleshooting-authentication-issues-in-your-editor)」を参照してください。

Organization を介して GitHub Copilot にアクセスできる場合、organization 所有者 が会話を無効にしている場合、GitHub Copilot Chat を使用することはできません。 「[organization 内での Copilot のポリシーの管理](https://docs.github.com/ja/copilot/managing-github-copilot-in-your-organization/managing-policies-and-features-for-copilot-in-your-organization)」をご覧ください。

## [プロンプトの送信](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#submitting-prompts)

Copilot Chat に、コードの提案、コードの説明、単体テストの生成、コード修正の提案を依頼できます。

1.  チャット ビューを開くには、Visual Studio Code のタイトル バーにある アイコンをクリックします。 アイコンが表示されない場合は、タイトル バーを右クリックして、**\[Command Center\]** が選択されていることを確認します。
    
    ![濃いオレンジ色の枠線で強調表示されている [Copilot Chat] ボタンのスクリーンショット。](https://docs.github.com/assets/cb-72745/images/help/copilot/vsc-copilot-chat-icon.png)
    
2.  プロンプト ボックスにプロンプトを入力するか、推奨されるプロンプトのいずれかをクリックします。 使用できるプロンプトの種類の概要については、「[Copilot Chat のプロンプトの概要](https://docs.github.com/ja/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。
    
3.  Copilot の応答を評価し、必要に応じてフォローアップ要求を行います。
    
    応答には、テキスト、コード ブロック、ボタン、画像、URI、およびファイル ツリーが含まれている場合があります。 応答には、多くの場合、対話型要素が含まれます。 たとえば、応答には、コード ブロックを挿入するメニューや、Visual Studio Code コマンドを呼び出すボタンが含まれる場合があります。
    
    Copilot Chat が回答の生成に使ったファイルを確認するには、回答の先頭にある **\[Used _n_ references\]** ドロップダウンを選びます。 リファレンスには、リポジトリのカスタム命令ファイルへのリンクを含めることができます。 このファイルには、応答の品質を向上させるために、すべてのチャットの質問に自動的に追加される追加情報が含まれています。 詳しくは、「[GitHub Copilot のリポジトリ カスタム命令を追加する](https://docs.github.com/ja/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot)」をご覧ください。
    

## [プロンプトでキーワード (keyword)を使用する](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#using-keywords-in-your-prompt)

特別なキーワード (keyword) を使用することで、Copilot がプロンプトを理解するのに役立ちます。 例については、「[Copilot Chat のプロンプトの概要](https://docs.github.com/ja/copilot/using-github-copilot/guides-on-using-github-copilot/getting-started-with-prompts-for-copilot-chat)」を参照してください。

### [チャット参加者](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#chat-participants)

チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。

Copilot Chat は、ユーザーの自然言語プロンプトに基づいて関連するチャット参加者を推測でき、プロンプトで使いたい参加者を明示的に指定しなくても、高度な機能の検出が向上します。

メモ

現在、チャット参加者の自動推論は パブリック プレビュー 段階であり、変更される可能性があります。

また、チャット参加者を手動で指定して、プロンプトのスコープを特定のドメインに絞り込むこともできます。 これを行うには、チャット プロンプト ボックスに「`@`」と入力し、その後にチャット参加者の名前を入力します。

使用できるチャット参加者の一覧を表示するには、チャット プロンプト ボックスに「`@`」と入力します。 Visual Studio Code ドキュメントの「[GitHub Copilot Chat チート シート](https://docs.github.com/ja/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#chat-participants)」または「[チャット参加者](https://code.visualstudio.com/docs/copilot/copilot-chat#_chat-participants)」も参照してください。

### [Copilot Extensions チャット参加者](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#copilot-extensions-%E3%83%81%E3%83%A3%E3%83%83%E3%83%88%E5%8F%82%E5%8A%A0%E8%80%85)

チャット参加者を提供する Copilot Extensions をインストールすることもできます。 [GitHub Marketplace](https://github.com/marketplace?type=apps&copilot_app=true) および [Visual Studio Code Marketplace](https://marketplace.visualstudio.com/search?target=VSCode&category=Chat&sortBy=Installs) からこれらの拡張機能をインストールできます。 チャット参加者を提供する GitHub Marketplace からの拡張機能については、「[拡張情報を使用して外部ツールを Copilot Chat と統合する](https://docs.github.com/ja/copilot/github-copilot-chat/github-copilot-extensions/about-github-copilot-extensions)」を参照してください。

### [スラッシュ コマンド](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#slash-commands)

スラッシュ コマンドを使用して、一般的なシナリオで複雑なプロンプトを記述しないようにします。 スラッシュ コマンドを使用するには、チャット プロンプト ボックスに 「`/`」 と入力し、その後にコマンドを入力します。

使用可能なすべてのスラッシュ コマンドを表示するには、チャットのプロンプト ボックスに `/` を入力します。 Visual Studio Code ドキュメントの「[GitHub Copilot Chat チート シート](https://docs.github.com/ja/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#slash-commands)」または「[スラッシュ コマンド](https://code.visualstudio.com/docs/copilot/copilot-chat#_slash-commands)」も参照してください。

### [チャット変数](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#chat-variables)

チャット変数を使用して、プロンプトに特定のコンテキストを含めます。 チャット変数を使用するには、チャット プロンプト ボックスに 「`#`」 と入力し、その後にチャット変数を入力します。

使用可能なすべてのチャット変数を表示するには、チャット プロンプト ボックスに 「`#`」 と入力します。 Visual Studio Code ドキュメントの「[GitHub Copilot Chat チート シート](https://docs.github.com/ja/copilot/using-github-copilot/github-copilot-chat-cheat-sheet?tool=vscode#chat-variables)」または[チャットの変数](https://code.visualstudio.com/docs/copilot/copilot-chat#_chat-variables)に関する記事も参照してください。

## [Copilot の GitHub スキルの使用](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#copilot-%E3%81%AE-github-%E3%82%B9%E3%82%AD%E3%83%AB%E3%81%AE%E4%BD%BF%E7%94%A8)

Copilot の GitHub 固有のスキルは、Copilot が提供できる情報の種類を拡張します。 Copilot Chat でこれらのスキルにアクセスするには、質問に「`@github`」を含めます。

質問に `@github` を追加すると、Copilot によって、質問の内容に基づいて適切なスキルが動的に選択されます。 また、特定のスキルを使用するように Copilot Chat に明示的に要求することもできます。 次の 2 つの方法で行います。

-   自然言語を使用して、スキルを使用するように Copilot Chat に依頼します。 たとえば、`@github Search the web to find the latest GPT model from OpenAI.` のように指定します。
-   Web 検索を具体的に呼び出すには、質問に `#web` 変数を含めることができます。 たとえば、`@github #web What is the latest LTS of Node.js?` のように指定します。

Copilot に問い合わせ、現在使用可能なスキルの一覧を生成できます: `@github What skills are available?`

## [Copilot Chat の AI モデル](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#copilot-chat-%E3%81%AE-ai-%E3%83%A2%E3%83%87%E3%83%AB)

Copilot がチャット プロンプトに対する回答を生成する際に使う大規模言語モデル (高度な機能を備えた Premium モデルなど) を変更できます。 質問の種類によっては、別のモデルの方がより良いパフォーマンスを発揮したり、より有用な回答が提供されたり場合があります。 詳しくは、「[Copilot Chat の AI モデルを変更する](https://docs.github.com/ja/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-chat)」をご覧ください。

## [Copilot Chat にアクセスするその他の方法](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#copilot-chat-%E3%81%AB%E3%82%A2%E3%82%AF%E3%82%BB%E3%82%B9%E3%81%99%E3%82%8B%E3%81%9D%E3%81%AE%E4%BB%96%E3%81%AE%E6%96%B9%E6%B3%95)

チャット ビューを使用してプロンプトを送信するだけでなく、他の方法でプロンプトを送信することもできます。

-   **クイック チャット:** クイック チャット ドロップダウンを開くには、⇧+⌥+⌘+L キー (Mac) または Ctrl+Shift+Alt+L キー (Windows/Linux) を押します。
-   **インライン**: エディターまたは統合ターミナルで直接インライン チャットを開始するには、Command+i (Mac) / Ctrl+i (Windows/Linux) と入力します。
-   **スマート アクション:** コンテキスト メニューからプロンプトを送信するには、エディター内で右クリックし、表示されるメニューで **\[Copilot\]** を選び、いずれかのアクションを選びます。 スマート アクションには、コード行を選択したときに表示されるきらめきアイコンを使用してアクセスすることもできます。

詳細については、Visual Studio Code ドキュメントの[インライン チャット](https://code.visualstudio.com/docs/copilot/copilot-chat#_inline-chat)、[クイック チャット](https://code.visualstudio.com/docs/copilot/copilot-chat#_quick-chat)、[チャット スマート アクション](https://code.visualstudio.com/docs/copilot/copilot-chat#_chat-smart-actions)を参照してください。

## [Copilot Edits](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#copilot-edits)

1 つの Copilot Chat プロンプトから複数のファイルに直接変更を加えるには、Copilot Edits を使用します。 Copilot Edits には次のモードがあります。

-   [編集モード](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#edit-mode)を使うと、Copilot で複数のファイルに対して制御された編集を行うことができます。
-   [エージェント モード](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#agent-mode)を使うと、設定されたタスクを Copilot で自律的に実行できます。

### [編集モード](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#edit-mode)

編集モードは、Visual Studio Code と JetBrains IDE でのみ使用できます。

Copilot から提案される編集をより詳細に制御する場合は、編集モードを使います。 編集モードでは、Copilot が変更できるファイルを選び、各繰り返しで Copilot にコンテキストを提供し、各ターン後に提案された編集を受け入れるかどうかを決定します。

編集モードは、次のユース ケースに最適です。

-   定義された一連のファイルに対して、迅速かつ具体的な更新を行う必要があります。
-   Copilot が使用する LLM リクエストの数を完全に制御する必要があります。

#### [編集モードの使用](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#using-edit-mode)

1.  編集セッションを開始するには、Copilot Chat メニューから **\[Open Chat\]** を選びます。
    
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Edit\]** を選択します。
    
    ![Copilot Chat モード ドロップダウンのスクリーンショット。 [Edit] オプションが濃いオレンジ色の枠線で囲まれています。](https://docs.github.com/assets/cb-44012/images/help/copilot/chat-mode-vscode.png)
    
3.  必要に応じて、関連ファイルを\_作業セット\_に追加して、作業対象のファイルを GitHub Copilot に示します。
    
4.  プロンプトを送信します。 プロンプトに応じて、Copilot Edits によって "作業セット" 内の変更対象のファイルが判断され、変更の簡単な説明が追加されます。\_\_
    
5.  変更内容を確認し、各ファイルの編集内容を **\[適用\]** または **\[破棄\]** します。
    

詳細な手順については、Visual Studio Code ドキュメントの「[Copilot Edits](https://code.visualstudio.com/docs/copilot/copilot-edits)」を参照してください。

### [エージェント モード](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#agent-mode)

**エージェント モード**: 特定のタスクを念頭に置いて、Copilot を有効にしてコードを自律的に編集できるようにする場合は、エージェント モードを使います。 エージェント モードでは、Copilot がどのファイルに変更を加えるかを決定し、タスクを完了するためのコード変更とターミナル コマンドを提供し、元のタスクが完了するまで issue の修復を繰り返します。

#### [エージェント モードの使用](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#using-agent-mode)

1.  編集セッションを開始するには、Copilot Chat メニューから **\[Open Chat\]** を選びます。
2.  チャット パネルの下部にあるモード ドロップダウンから **\[Agent\]** を選択します。
3.  プロンプトを送信します。 プロンプトに応じて、Copilot によってエディター内の編集内容がストリーミングされ、作業セットが更新され、必要に応じて、実行すべきターミナル コマンドが提案されます。
4.  変更を確認します。 Copilot からターミナル コマンドが提案された場合は、Copilot でそれらを実行できるかどうかを確認します。 これに応じて、Copilot によって追加のアクションが繰り返し実行され、元のプロンプトのタスクが完了されます。

直接 [VS Code でエージェント モードを開く](vscode://GitHub.Copilot-Chat/chat?mode=agent)こともできます。

詳細については、Visual Studio Code ドキュメントの「[Copilot Edits](https://aka.ms/vscode-copilot-agent)」を参照してください。

Copilot エージェント モードを使う場合、送信するプロンプトごとに 1 件の Premium リクエストとしてカウントされ、モデルのレートが乗算されます。 タスクを完了するために、Copilot によって複数のフォローアップ アクションが実行される場合があります。ただし、このようなフォローアップ アクションは Premium リクエストの使用にはカウントされません。 ユーザーが入力したプロンプトのみが課金対象です。エージェントによるツールの呼び出しやバックグラウンド ステップには課金されません。

使った Premium リクエストの合計数は、ユーザーが入力したプロンプト数とユーザーが選んだモデルによって変わります。 「[Premium リクエストについて](https://docs.github.com/ja/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/monitoring-usage-and-entitlements/avoiding-unexpected-copilot-costs)」をご覧ください。

## [Copilot Chat での画像の使用](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#copilot-chat-%E3%81%A7%E3%81%AE%E7%94%BB%E5%83%8F%E3%81%AE%E4%BD%BF%E7%94%A8)

メモ

-   現在、チャット プロンプトへの画像の添付は パブリック プレビュー 段階であり、変更される可能性があります。
-   Copilot Business プランをお使いの場合、そのプランを提供する organization で、**\[Editor preview features\]** の設定を有効にする必要があります。 「[organization 内での Copilot のポリシーの管理](https://docs.github.com/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#enabling-copilot-features-in-your-organization)」を参照してください。

チャット プロンプトに画像を添付してから、画像について Copilot に問い合わせることができます。 たとえば、次のようなものを添付できます。

-   コード スニペットのスクリーンショットを添付して、コードの説明を Copilot に依頼します。
-   アプリケーションのユーザー インターフェイスのモックアップを添付して、コードの生成を Copilot に依頼します。
-   フローチャートを添付して、画像で示されているプロセスについての説明を Copilot に依頼します。
-   Web ページのスクリーンショットを添付して、同様のページの HTML の生成を Copilot に依頼します。

メモ

サポートされている画像ファイルの種類は、JPEG (`.jpg`、`.jpeg`)、PNG (`.png`)、GIF (`.gif`)、WEBP (`.webp`) です。

### [チャット プロンプトへの画像の添付](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#attaching-images-to-your-chat-prompt)

1.  チャット ビューの右下に AI モデル ピッカーが表示される場合は、プロンプトへの画像の追加をサポートするモデルのいずれかを選びます。
    
    -   GPT-4.1 (モデル ピッカーが表示されない場合に使われる既定値)
    -   GPT-4o
    -   Claude Sonnet 3.5
    -   Claude Sonnet 3.7
    -   Gemini 2.0 Flash
    -   Gemini 2.5 Pro
    
    ![モデル ピッカーが濃いオレンジ色の枠線で強調表示されている Copilot Chat のスクリーンショット。](https://docs.github.com/assets/cb-4047/images/help/copilot/vsc-chat-model-picker.png)
    
2.  次のいずれかの操作を行います。
    
    -   画像をコピーしてチャット ビューに貼り付けます。
    -   オペレーティング システムのエクスプローラーまたは VS Code のエクスプローラーから、1 つ以上の画像ファイルをチャット ビューにドラッグ アンド ドロップします。
    -   VS Code エクスプローラーで画像ファイルを右クリックし、**\[Copilot\]** をクリックしてから **\[Add File to Chat\]** をクリックします。
3.  画像に添えるプロンプトをチャット ビューに入力します。 たとえば、 `explain this diagram`、 `describe each of these images in detail`、 `what does this error message mean` などです。
    

## [フィードバックを送る](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#sharing-feedback)

応答が役に立ったかどうかを示すには、応答の横に表示されるサムアップアイコンとサムダウン アイコンを使用します。

GitHub Copilot Chat 拡張機能に関するフィードバックを残すには、[microsoft/vscode-copilot-release](https://github.com/microsoft/vscode-copilot-release/issues) リポジトリで issue を開きます。

## [参考資料](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#further-reading)

-   [Copilot Chat のプロンプト エンジニアリング](https://docs.github.com/ja/copilot/using-github-copilot/prompt-engineering-for-github-copilot)
-   Visual Studio Code ドキュメントの「[Copilot Chat in VS Code の使用](https://code.visualstudio.com/docs/copilot/copilot-chat)」と「[GitHub Copilot Chat in VS Code の概要](https://code.visualstudio.com/docs/copilot/getting-started-chat)」
-   [GitHub で GitHub Copilot に質問をする](https://docs.github.com/ja/copilot/github-copilot-enterprise/copilot-chat-in-github/using-github-copilot-chat-in-githubcom)
-   [IDE での GitHub Copilot Chat の責任ある使用](https://docs.github.com/ja/copilot/github-copilot-chat/about-github-copilot-chat)
-   [追加の製品および機能に適用される GitHub 条件](https://docs.github.com/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page/)
-   [GitHub Copilot FAQ](https://github.com/features/copilot#faq)