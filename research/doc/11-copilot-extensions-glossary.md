# Copilot 拡張機能の用語集 - GitHub Docs

# Copilot 拡張機能の用語集

Copilot Extensions で使われる用語について説明します。

ここでは、Copilot Extensions のコンテキストで使われる以下の用語を明確に定義します。

#### [エージェント](#agent)

Copilot Extension の実装の一種。開発者はこれを使ってユーザー クエリと応答生成の処理を完全に制御できます。 このアプローチは、AI 操作の完全なカスタマイズと管理を必要とするビルダーに最適です。

#### [コンテキストの受け渡し](#context-passing)

Copilot Extensions の機能。エディターからユーザー コンテキストをエージェントに送信し、応答をさらにカスタマイズできるようにします。

#### [Copilot Chat](#copilot-chat)

GitHub Copilot 内の会話インターフェイス。ユーザーは AI アシスタントと拡張機能を操作できます。

#### [Copilot Extension](#copilot-extension)

Copilot Chat ウィンドウと Copilot API への追加アクセス権を持つ GitHub App。GitHub の Copilot Chat で機能を拡張できます。 これは、拡張機能ユーザーの観点から拡張機能を参照する方法です。

#### [Copilot 拡張性プラットフォーム](#copilot-拡張性プラットフォーム)

認証を処理し、クライアントとエージェント プラグイン間の要求をプロキシするシステム。

#### [Copilot 対応 Visual Studio Code 拡張機能](#copilot-対応-visual-studio-code-拡張機能)

Visual Studio Code チャット拡張機能とも呼ばれる Copilot 対応 Visual Studio Code 拡張機能 は、GitHub App ではなく Visual Studio Code 拡張機能として構築されます。 これらの拡張機能は VS Code に限定されており、VS Code マーケットプレースからダウンロードできます。

#### [GitHub App](#github-app)

Copilot Extension のための基盤。必要なインフラストラクチャ、アクセス許可、GitHub からのコンテキスト (ユーザー、リポジトリ、organization のメタデータなど) を提供します。

#### [GitHub Marketplace](#github-marketplace)

GitHub によって承認された GitHub Copilot Extensions を公開でき、ユーザーがそれを見つけることのできるプラットフォーム。

#### [表示/公開済み拡張機能](#listedpublished-extension)

GitHub Marketplace に表示される拡張機能。 これらの拡張機能は、GitHub によってレビューおよび承認される必要があります。

#### [プライベート拡張機能](#private-extension)

拡張機能を作成した Enterprise、organization、または個人ユーザーのみが表示および使用できる拡張機能。 Enterprise が作成した拡張機能は、その Enterprise 内の organization がインストールできます。

#### [パブリック拡張機能](#public-extension)

GitHub ユーザーまたは組織が表示およびインストールできる拡張機能。

#### [スキル](#skill)

コンテキストを取得するか、ユーザーのプロンプト (例: "findIssueByID(ID: 番号)") に応答してアクションを実行するコードの一部。 スキルの一覧については、「[現在利用可能なスキル](/ja/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide#currently-available-skills)」を参照してください。

#### [スキルセット](#skillset)

Copilot Extension の実装の一種。開発者は、最小限の複雑さで外部サービスとカスタム API エンドポイントを Copilot に接続できます。 Copilot 拡張性プラットフォーム は、プロンプトの作成、関数の評価、応答の生成を処理します。 ビルダーは API スキル定義を処理するだけで済みます。 このアプローチは、複雑さを最小限に抑えたいビルダーに最適です。

#### [ツール/関数呼び出し](#toolfunction-calling)

特定のツールまたは関数を呼び出すことができる Copilot の LLM (および Open AI) の機能。 拡張機能ビルダーは、パラメーターを使用して使用可能なツールを定義できます。これにより、LLM はユーザーの要求を満たすために適切なツールを選択して呼び出すことができます。 "Functions" は "tools" のサブセットであり、"関数呼び出し" という用語は 終了 になります。

#### [一覧に表示されない拡張機能](#unlisted-extension)

GitHub Marketplace で公開されていない拡張機能。 ビルダーは、GitHub からのレビューや承認を必要とせずに、公開されていない拡張機能を開発および配布できます。 GitHub は、一覧にない拡張機能のセキュリティや品質を保証するものではありません。

#### [検証済み作成者](#verified-creator)

組織が GitHub Marketplace に拡張機能を公開するために必要な状態。