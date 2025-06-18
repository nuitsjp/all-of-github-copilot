# Copilot Extensions に関する FAQ - GitHub Docs

# Copilot Extensions に関する FAQ

GitHub Copilot Extensions についてのよくあるご質問に回答します。

## この記事の内容

## [全般](#general)

このセクションでは、GitHub Copilot Extensions についてのよくあるご質問に回答します。

-   [GitHub Copilot Extension と Visual Studio Code のチャット参加者の違いは何ですか?](#what-is-the-difference-between-a-github-copilot-extension-and-a-visual-studio-code-chat-participant)
-   [Copilot Extensions に対する補償は提供されますか?](#is-indemnity-provided-for-copilot-extensions)

### [GitHub Copilot Extension と Visual Studio Code のチャット参加者の違いは何ですか?](#github-copilot-extension-と-visual-studio-code-のチャット参加者の違いは何ですか)

GitHub Copilot Extensions と Visual Studio Code のチャット参加者は、同じバックエンド プラットフォームを使ってリクエストを拡張機能にルーティングします。 どちらも同様のエンドユーザー エクスペリエンスを提供し、Copilot Chat と統合され、Copilot API または他の LLM を利用できます。

類似点もありますが、主な相違点の一部を次に示します。

-   GitHub Copilot Extensions と Visual Studio Code のチャット参加者は、さまざまなマーケットプレースを介してアクセスされます。
-   GitHub Copilot Extensions はサーバー側の拡張機能であり、サーバー インフラストラクチャを構築する必要があります。 これらの拡張機能は、organization 管理者による設定に従い、GitHub ワークスペースへの組み込みの接続を提供します。
-   Visual Studio Code チャット参加者は、ローカル ファイルへの読み取りおよび書き込みアクセス権限を持つクライアント側の拡張機能です。 サーバー インフラストラクチャは必要ありません。
-   GitHub Copilot Extensions は、拡張機能がサポートされているエディターで使用できますが、Visual Studio Code チャット参加者は Visual Studio Code でのみ使用できます。

詳しくは、「[Copilot 拡張機能の構築について](/ja/copilot/building-copilot-extensions/about-building-copilot-extensions)」をご覧ください。

### [Copilot Extensions に対する補償は提供されますか?](#copilot-extensions-に対する補償は提供されますか)

いいえ、Copilot Extensions は、GitHub Copilot の補償ポリシーの対象ではありません。 ただし、この除外は拡張機能のチャット スレッド内で発生した issue にのみ適用されます。

拡張機能をインストールして使っても、コード補完やチャットなどの他の Copilot 機能を使用中に発生する issue に対する補償範囲には影響しません。

## [データとアクセス許可](#data-and-permissions)

このセクションでは、Copilot Extensions の使用時に収集および共有されるデータについて説明します。

-   [Copilot Extensions ではどのようなデータが収集されて共有されますか?](#what-data-is-being-collected-and-shared-with-copilot-extensions)
-   [Copilot Extensions にはどのようなアクセス許可が必要ですか?](#what-permissions-are-required-for-copilot-extensions)
-   [Organization リソースにアクセスするためのアクセス許可を Copilot Extensions に付与できるのは誰ですか?](#who-can-provide-permissions-for-copilot-extensions-to-access-organization-resources)
-   [ユーザーは、organization がアクセス許可を付与していない Copilot Extensions を使用できますか?](#can-a-user-use-copilot-extensions-that-the-organization-has-not-provided-permissions-for)

### [Copilot Extensions ではどのようなデータが収集されて共有されますか?](#copilot-extensions-ではどのようなデータが収集されて共有されますか)

Copilot Extensions とやり取りするときは、次のデータが共有されます。

-   アカウントにアタッチされているデータと、Copilot Chat の使用状況 (GitHub ユーザー ID、メッセージのタイムスタンプなど)。
-   拡張機能を呼び出しているチャット スレッド内の過去のメッセージ。 1 つのスレッドで使用できる拡張機能は 1 つだけなので、拡張機能間でデータは共有されません。 スレッド コンテキストのデータ保持期間は 30 日間です。
-   Organization 管理者によって拡張機能が許可されているその他の organization およびリポジトリ データ。拡張機能をインストールする管理者は、インストールを完了する前に、必要なアクセス許可へのアクセスを承認する必要があります。
-   Copilot Chat in GitHub では、管理者がリポジトリまたは organization のメタデータにアクセスするための拡張機能を承認している場合、そのデータも共有されます。

### [Copilot Extensions にはどのようなアクセス許可が必要ですか?](#copilot-extensions-にはどのようなアクセス許可が必要ですか)

アクセス許可は、拡張機能がクエリに応答するために必要な認可のレベルに応じて、拡張機能ごとに異なります。 必要なアクセス許可は、拡張機能のインストール ページで、課金情報の手順の後、インストールと認可の手順の前に確認できます。

**開発者向け**: 少なくとも、**Copilot Chat** のアクセス許可を \[Read-only\] に設定する必要があります。 その他のアクセス許可として、他の画面での書き込みアクションの実行や、GitHub 内のリポジトリおよび organization レベルのデータへの読み取りアクセス権の認可が含まれる場合があります。

**ビルダー向け**: 上記に加えて、ユーザーの編集者にローカル コンテキストを要求して、応答をさらに調整することもできます。 これを行うには、**Copilot Editor Context** アクセス許可を \[Read-only\] に設定する必要があります。 ユーザーには、必要な認可を与えるよう通知されます。

GitHub App のアクセス許可の詳細については、「[GitHub アプリのアクセス許可を選択する](/ja/apps/creating-github-apps/registering-a-github-app/choosing-permissions-for-a-github-app)」を参照してください

### [Organization リソースにアクセスするためのアクセス許可を Copilot Extensions に付与できるのは誰ですか?](#organization-リソースにアクセスするためのアクセス許可を-copilot-extensions-に付与できるのは誰ですか)

Organization のリソースにアクセスするためのアクセス許可を Copilot Extensions に付与できるのは、organization 管理者だけです。 Organization メンバーは、拡張機能がリポジトリまたはクエリ コンテキストにアクセスできない状況にぶつかる可能性があります。 これは、通常、organization 管理者がまだアクセス許可を付与していない、または拡張機能を認可していないために発生します。 「[Organization リソースにアクセスするためのアクセス許可を付与する](/ja/copilot/building-copilot-extensions/about-building-copilot-extensions#granting-permissions-to-access-organization-resources)」を参照してください。

### [ユーザーは、organization がアクセス許可を付与していない Copilot Extensions を使用できますか?](#ユーザーはorganization-がアクセス許可を付与していない-copilot-extensions-を使用できますか)

はい、すべてのユーザーは Copilot Extensions をインストールして使用できます。 ただし、organization のリソースとリポジトリのクエリを実行するには、organization 管理者によって拡張機能がインストールされ、認可されている必要があります。「[Organization リソースにアクセスするためのアクセス許可を付与する](/ja/copilot/building-copilot-extensions/about-building-copilot-extensions#granting-permissions-to-access-organization-resources)」を参照してください。

ユーザーは、organization 管理者に問い合わせて、インストールと認可を依頼する必要があります。 管理者のアクセス許可がなければ会社のコンテキストにアクセスできません。

## [ポリシー](#policies)

このセクションでは、Copilot Extensions の管理ポリシーについて説明します

-   [Enterprise 内で使用できる Copilot Extensions を制御するにはどうすればよいですか?](#how-do-i-control-which-copilot-extensions-can-be-used-in-my-enterprise)
-   [Enterprise レベルの許可リストと禁止リストはありますか?](#is-there-an-allowlistblocklist-at-the-enterprise-level)
-   [Organization のメンバーは、どのようにして Copilot Extensions にアクセスできますか?](#as-a-member-of-an-organization-how-can-i-get-access-to-copilot-extensions)

### [Enterprise 内で使用できる Copilot Extensions を制御するにはどうすればよいですか?](#enterprise-内で使用できる-copilot-extensions-を制御するにはどうすればよいですか)

Enterprise 管理者は、**Copilot Extensions** ポリシーを \[Disabled\] または \[No Policy\] に設定して、Enterprise 全体で Copilot Extensions を無効にできます。

### [Enterprise レベルの許可リストと禁止リストはありますか?](#is-there-an-allowlistblocklist-at-the-enterprise-level)

いいえ、Enterprise レベルの許可リストや禁止リストはありません。

### [Organization のメンバーは、どのようにして Copilot Extensions にアクセスできますか?](#organization-のメンバーはどのようにして-copilot-extensions-にアクセスできますか)

Organization メンバーとして Copilot Extensions にアクセスするには、自分に GitHub シートを割り当た organization で、Copilot Extensions ポリシーを有効にする必要があります。 さらに、同じ organization が拡張機能をインストールし、organization が所有するリポジトリにアクセスすることを認可する必要があります。

たとえば、あなたが複数の organization のメンバーであり、organization A から GitHub シートが割り当てられている場合、organization A がポリシーを有効にしている場合にのみ拡張機能にアクセスできます。 Organization B が拡張機能を有効にしているのにアクセスできない場合は、organization A が Copilot Extensions ポリシーを無効にしているためです。