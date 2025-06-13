# **GitHub Copilotのすべて（2025年6月10日時点）**

## **1\. GitHub Copilotの概要と歴史 (5分)**

### **GitHub Copilotとは何か**

GitHub Copilotは、GitHubとOpenAIによって共同開発されたAI搭載の開発支援ツールです。開発者のIDE（統合開発環境）、CLI（コマンドラインインターフェース）、GitHub.comといった作業環境に直接統合され、文脈に応じたコード提案、自然言語プロンプトからのコード生成、コード解説、デバッグ支援など、多岐にわたる機能を提供します。2025年6月現在、単なるコード補完ツールを超越し、ソフトウェア開発ライフサイクル全体をサポートする包括的なAIパートナーへと進化を遂げています 1。

初心者開発者にとっては、経験豊富なプログラミングパートナーが傍にいて、必要なコードの次の行を即座に提案してくれたり、説明に基づいて関数全体を記述してくれたり、複雑なコード片を平易な言葉で説明してくれたりするような存在と捉えることができます。このツールは、開発の初期段階から最終段階に至るまで、開発者の生産性向上とコード品質の向上に貢献することを目指しています。

### **開発の経緯と主要なマイルストーン**

GitHub Copilotは2021年にAIペアプログラマーとして初めて発表され、当初はOpenAIのモデルを活用したオートコンプリート形式のコード提案に重点を置いていました 2。その後、GPT-4やGPT-4oといったより強力なAIモデルが段階的に統合され、提案の精度向上、対応言語の拡大、機能強化が図られてきました 2。

Copilotの進化はコード補完に留まらず、対話型インターフェースであるCopilot Chat、コマンドライン操作を支援するCopilot for CLI、タスクの計画から実行までをサポートするCopilot Workspace、そして自律的なタスク処理が可能なCoding Agentといった新機能が次々と導入されました 2。この急速な機能拡張は、AI開発の加速とソフトウェアエンジニアリングへの深い統合を反映しており、Copilotが単一のツールから包括的な開発プラットフォームへと変貌を遂げたことを示しています。GitHubのロードマップにおける「AIネイティブでエージェント的な体験」への注力も、この戦略的方向性を裏付けています 9。

一部では、2025年の進化したCopilotスイートを指して「Copilot X」という呼称も見られますが 2、公式な製品名としては確認されていません。しかし、このような呼称が使われること自体が、Copilotが遂げた飛躍的な進化をユーザーや観察者が認識していることの現れと言えるでしょう。

エンタープライズ利用への対応も重要な進展です。セキュリティ、コンプライアンス、管理機能、そしてIP（知的財産）補償といった側面が大幅に強化され、大企業での利用に適したツールへと成熟しました 10。

2023年から2025年にかけての主要なマイルストーンとしては、Copilot BusinessおよびEnterpriseの一般提供開始、IDEおよびGitHub.comでのCopilot Chatのローンチ、Copilot Workspaceの発表（パブリックプレビューから一般提供へ）、Coding Agentの展開（パブリックプレビューから一般提供へ）、Model Context Protocol (MCP) のサポート開始 5、そしてCopilot Edits/Chatにおける履歴追跡機能の導入（2025年までには解決・統合されている可能性が高い）15などが挙げられます。

### **2025年6月時点での最新バージョンと主要アップデート**

2025年6月時点では、特に2025年第1四半期から第2四半期にかけてリリースされた主要なアップデートが注目されます。これには、新しいAIモデルの導入、Copilot WorkspaceやCoding Agentの機能の大幅な強化、新たなIDE統合、CLI機能の拡張などが含まれる可能性があります 14。

特にAgent Modeは継続的な開発が進められ、より自律的で高度なタスク処理能力を持つようになっていると考えられます 5。Model Context Protocol (MCP) の一般提供開始とそれに伴うアップデートにより、外部ツールやエンタープライズデータとのよりリッチな連携が実現しているでしょう 5。さらに、新しい、より強力な大規模言語モデル（LLM）の導入や、特定のタスクや言語に特化したモデルが広く利用可能になっていることも期待されます 5。これらのアップデートは、Copilotが常に最先端のAI技術を取り込み、進化し続けていることを示しています。

## **2\. 製品ラインナップとライセンス詳細 (10分)**

GitHub Copilotは、個人の開発者から大規模なエンタープライズまで、多様なニーズに対応するための製品ラインナップを2025年6月時点で提供しています。これらのプランは、機能、管理性、サポート、価格においてそれぞれ特徴があります。

### **GitHub Copilot Individual**

個人開発者向けのプランは、Copilot Free、Copilot Pro、そしてCopilot Pro+（または2025年6月時点での最上位個人向けティア）の3段階で構成されています。

* **Copilot Free:**  
  * **機能:** 月間のコード補完回数（例：2,000回）およびチャットリクエスト回数（例：50回/月）に制限があります 10。  
  * **対象ユーザー:** 学生、ホビイスト、AIコーディングを初めて試すユーザーに適しています 10。  
  * **制限事項:** 管理機能、監査ログ、ポリシー管理、IP補償などが欠如しているため、エンタープライズ用途には適していません 19。  
  * **価格:** $0 10。  
* **Copilot Pro:**  
  * **機能:** 無制限のコード補完、ベースモデルでの無制限チャット、より高度なAIモデルへのアクセス（「プレミアムリクエスト」の上限あり）、IDE/[GitHub.com/モバイルでのCopilot](https://GitHub.com/%E3%83%A2%E3%83%90%E3%82%A4%E3%83%AB%E3%81%A7%E3%81%AECopilot) Chat、CLIアクセスなどが含まれます 6。  
  * **プレミアムリクエスト:** 月間一定数（例：Proでは300件）のプレミアムリクエストが含まれ、追加購入も可能です。これらのリクエストは、より高度なモデルや機能を利用する際に消費されます 19。この「プレミアムリクエスト」という概念は、より高度でコストのかかるAIモデルへのアクセスを収益化しつつ、基本機能を広く提供するための重要なメカニズムとなっています。  
  * **対象ユーザー:** 本格的なAI支援を必要とするプロフェッショナル開発者や個人ユーザー向けです 10。  
  * **価格:** 月額$10 USD、または年額$100 USD 19。  
* **Copilot Pro+ (または同等の最上位個人ティア):**  
  * **機能:** Copilot Proの全機能に加え、Copilot Chatで利用可能な全てのモデルへのフルアクセス、大幅に増加したプレミアムリクエスト上限（例：1,500件/月）、高度なAI機能への優先アクセスなどが提供されます 19。  
  * **対象ユーザー:** AIパワーユーザーや、最先端のツールと最大限のモデルアクセスを求める開発者向けです 19。  
  * **価格:** 月額$39 USD、または年額$390 USD 19。

この個人向けプランの細分化されたティア構造は、市場のセグメンテーションと機能の差別化を示しており、ユーザーが自身の利用パターンや高度な機能へのニーズに応じて最もコスト効率の高いプランを選択できるようになっています。

### **GitHub Copilot Business**

* **機能:** Copilot Proの全機能に加え、組織全体のポリシー管理、ライセンス管理、IP補償（重複検出フィルターの有効化などの条件付き）、ユーザー管理、コンテンツ除外機能、監査ログなどが提供されます 10。  
* **対象ユーザー:** ガバナンスとIP保護を必要とするチームや中規模組織向けです 10。  
* **価格:** ユーザーあたり月額$19 USD 10。  
* **要件:** GitHub Enterprise Cloudの利用が前提となります 23。

### **GitHub Copilot Enterprise**

* **機能:** Copilot Businessの全機能に加え、高度に文脈化された提案を可能にするコードベースのインデックス作成（「内部関係者のようにコーディングする」7）、プライベートAIモデル（またはプライベートコードベースでのファインチューニング機能）、より深いGitHub Chat統合、組織リポジトリからのナレッジベース作成、潜在的により高度なCoding Agent機能などが含まれます 6。  
* **ナレッジベース:** 組織のオーナーは、複数のリポジトリにまたがるMarkdownドキュメントからナレッジベースを作成・管理できます。これにより、組織メンバーはCopilot Chat利用時にそのドキュメントをコンテキストとして活用できます 6。  
* **対象ユーザー:** 厳格なコンプライアンス、セキュリティ、およびカスタマイズのニーズを持つ大企業向けです 10。  
* **価格:** ユーザーあたり月額$39 USD 10。  
* **要件:** GitHub Enterprise Cloudの利用が前提となります 23。

Copilot BusinessおよびEnterpriseプランにおけるIP補償の明示的な提供は、法務リスクを主要な懸念事項とする大企業にとって、採用を決定づける重要な要素です 10。これは、GitHubが企業の法務要件に対応する製品の成熟度を示しています。

### **各プランの機能比較表**

| 機能 | Copilot Free | Copilot Pro | Copilot Pro+ | Copilot Business | Copilot Enterprise |
| :---- | :---- | :---- | :---- | :---- | :---- |
| **価格 (月額)** | $0 | $10 USD | $39 USD | $19 USD/ユーザー | $39 USD/ユーザー |
| **価格 (年額)** | \- | $100 USD | $390 USD | \- | \- |
| **コード補完 (制限)** | 月間2,000回まで 10 | 無制限 10 | 無制限 19 | 無制限 | 無制限 |
| **チャット対話 (制限、モデルアクセス)** | 月間50回まで 10 | ベースモデルで無制限 19 | 全モデルで無制限 19 | ベースモデルで無制限、高度モデルはプレミアムリクエスト | 全モデルで無制限、高度モデルはプレミアムリクエスト |
| **プレミアムリクエスト (許容量)** | 50回/月 19 | 300回/月 19 | 1,500回/月 19 | プランによる (Pro機能ベース) | プランによる (Business機能ベース、より高度な機能で消費) |
| **追加プレミアムリクエスト費用** | \- | $0.04 USD/リクエスト 19 | $0.04 USD/リクエスト 19 | $0.04 USD/リクエスト | $0.04 USD/リクエスト |
| **高度/複数モデルへのアクセス** | 基本モデルのみ | 一部アクセス可 19 | 全モデルフルアクセス 19 | 一部アクセス可 | 全モデルフルアクセス、プライベートモデル/ファインチューニング可能性 |
| **Copilot Chat (IDE, GitHub.com, Mobile)** | 限定的 | 利用可 6 | 利用可 6 | 利用可 | 利用可、GitHub.comでより深い統合 |
| **Copilot CLI** | 利用不可 | 利用可 6 | 利用可 6 | 利用可 | 利用可 |
| **Copilot Workspace** | 利用不可 | プレビュー/限定機能 6 | プレビュー/限定機能 6 | プレビュー/限定機能 | 高度な機能、組織利用最適化 |
| **Coding Agent** | 利用不可 | プレビュー/限定機能 6 | プレビュー/限定機能 6 | プレビュー/限定機能 | 高度な機能、組織リポジトリでの課題割り当て |
| **IP補償** | なし 19 | なし | なし | あり（条件付き）10 | あり（条件付き）10 |
| **ポリシー管理** | なし 19 | なし | なし | 組織単位 10 | エンタープライズ/組織単位 11 |
| **ユーザー管理 & 監査ログ** | なし 19 | なし | なし | あり 11 | あり 11 |
| **コンテンツ除外** | なし 19 | なし | なし | あり 11 | あり 11 |
| **コードベースインデックス/ナレッジベース** | なし | なし | なし | なし | あり 6 |
| **MCP/拡張機能サポート** | 限定的/なし | あり | あり | あり | あり、より高度な連携 |

*注: 機能や価格は2025年6月10日時点のものであり、変更される可能性があります。プレミアムリクエストの具体的な消費量は機能によって異なります。*

### **ライセンス条件、制限事項、価格体系**

GitHub Copilotのライセンスは、ユーザー単位のサブスクリプションモデルに基づいています 10。契約条件は、購入チャネル（GitHubから直接購入か、Microsoft経由か）によって、GitHub顧客契約またはMicrosoftの関連契約に準拠します 13。

主な制限事項として、IP補償は通常、BusinessまたはEnterpriseプランのユーザーが「パブリックコードと一致する提案」フィルターを「ブロック」に設定して有効にしている場合に適用されます 12。データ利用に関しては、Copilot BusinessおよびEnterpriseのプロンプトと提案は、公開モデルのトレーニングには使用されません。Individualプラン（Pro/Pro+）のユーザーは、モデル改善のためのデータ共有をオプトアウトできます 24。プレミアムリクエストは、高度なモデルや機能の利用時に消費され、許容量を超過すると追加料金が発生するか、機能がベースモデルに制限される場合があります 19。

価格体系は、Individualプランでは月額および年額のサブスクリプションが選択可能で、BusinessおよびEnterpriseプランは月額となっています 19。

### **学生・教育機関向けプログラム**

GitHubは、教育コミュニティへの貢献として、学生および教員向けにCopilot Proへの無料アクセスを提供しています。

* **GitHub Student Developer Pack:** 在学証明が可能な認証済み学生は、Copilot Proを無料で利用できます 1。認証には、在籍証明書や学生用メールアドレスの提出が必要です 1。この特典により、学生はCopilot Proの全機能を、資格を有する限り継続して利用できます 1。  
* **教員:** GitHub Educationで認証された教員も同様に、Copilot Proへの無料アクセスを得られます 18。

Microsoft Learn for Organizationsは、Copilotトレーニングを含む構造化された学習プランやトレーニングビデオを提供している可能性がありますが 25、教育機関全体への無料Copilotアクセス（個々の学生・教員を除く）については、2025年6月時点での具体的な情報を確認する必要があります。

学生、教員、そして有力なオープンソースプロジェクトのメンテナーにCopilot Proを無料で提供する戦略は、早期導入を促進し、将来のユーザーベースを構築し、オープンソースエコシステムを支援するという、GitHubの長期的なエコシステム成長への投資と言えます 1。

### **オープンソースプロジェクトでの利用条件**

* **人気のあるオープンソースリポジトリのメンテナー:** Copilot Proへの無料アクセスを得られる場合があります 18。GitHubは毎月、この資格を再評価します 18。  
* **「パブリックコードと一致する提案」フィルター:** この機能は、既存の公開コードの大きな塊を提案することを避けるのに役立つため、オープンソースプロジェクトにとって特に関連性があります 11。

## **3\. 主要機能と使い方 (15分)**

GitHub Copilotは、開発者の生産性を向上させるための多様な主要機能を提供しています。これらの機能は、コードの記述からデバッグ、ドキュメンテーション作成に至るまで、開発プロセスの様々な側面をサポートします。

### **コード補完・生成機能**

IDE（VS Code、Visual Studio、JetBrains製IDE、Neovimなど）内でオートコンプリート形式の提案を行います。現在のファイル内容、コメント、自然言語によるプロンプトに基づいて、単一行のコード、コードブロック、あるいは関数全体を生成します 3。特にVS Codeでは、「Next Edit Suggestions (NES)」と呼ばれる機能があり、次に行われる可能性のある編集箇所を予測し、そのための補完を提案します。これには、新しい変数に応じてコードをリファクタリングしたり、論理的な変更を加えたりすることも含まれます 6。

**使い方:** コードの入力を開始するか、目的の関数やロジックを説明するコメントを記述すると、Copilotがインラインで提案を表示します。

**具体例 (Python):**

Python

\# APIからデータを取得し、JSONを解析する関数  
def fetch\_and\_parse\_api\_data(url):  
    \# Copilotによる提案:  
    \# import requests  
    \# response \= requests.get(url)  
    \# response.raise\_for\_status() \# HTTPエラーの場合は例外を発生させる  
    \# return response.json()

**デモに適した内容:** PythonやJavaScriptで、単純なコード補完からコメントに基づく複雑な関数生成までを実演します。VS CodeであればNESの動作も示すと効果的です。

**初心者向け解説:** コードを書いている途中で、Copilotが次に書くであろう内容を予測して補完候補を出してくれます。これによりタイピングの手間が省けます。また、「2つの数値を足す関数を作成」のようなコメントを書くと、Copilotがその通りのコードを書いてくれます。

### **GitHub Copilot Chat（IDE内、GitHub.com、モバイル）**

コーディング関連の質問、コードの説明、リファクタリング、テスト生成、デバッグなどを対話形式で行えるインターフェースです。IDE、GitHub.com、モバイルアプリなど、複数のプラットフォームで利用可能です 3。

* **IDE統合:** VS Code、Visual Studio、JetBrains製IDEなどに深く統合されており、インラインチャット（Ctrl+I）、チャットビュー（Ctrl+Alt+I）、そして異なるモード（Ask、Edit、Agent）を提供します 5。  
  * **Ask Mode:** 質問や説明を求める際に使用します 5。  
  * **Edit Mode (Multi Edit):** コードやタスクを提供すると、Copilotがコードを生成・修正します。複数のファイルにまたがる編集も可能です 3。  
  * **Agent Mode:** より自律的に動作し、コード分析、改善提案、デバッグ、ターミナルコマンドの実行（許可が必要）などを行います 5。このAgent Modeや後述のCopilot Workspaceのような機能は、Copilotが単にコードを「提案する」段階から、タスクを「実行する」段階へと進化していることを示しています。これは開発者の信頼と新しい対話パターンを必要とします。  
* **GitHub.com:** GitHubウェブサイト上で直接チャットが利用でき、リポジトリ、Issue、ファイルといった特定のコンテキストに基づいた対話が可能です 3。  
* **モバイルアプリ:** GitHubモバイルアプリ内でもチャット機能が利用できます 6。  
* **スラッシュコマンドとチャット変数:** /explain、/test、/fixのようなコマンドや、\#codebase、\#selection、\#file、\#fetchのような変数を使用して、コンテキストを提供し、意図を明確に伝えることができます 5。これらのメカニズムは、Copilotの文脈理解能力を向上させるためのGitHubによる積極的な取り組みの一環です。

具体例 (IDEチャット):  
複雑な関数を選択し、インラインチャット（Ctrl+I）で/explainと入力すると、Copilotがその関数を説明します。チャットビューで「これをより効率的にリファクタリングし、エラー処理を追加してください」と依頼することも可能です。Agent Modeでは、「Issue \#123で説明されている機能を実装してください。全ての新しい関数にはユニットテストを付けてください」といった指示も可能です 5。  
**デモに適した内容:** IDEチャットで、選択したコードの説明、そのユニットテストの生成、そしてリファクタリング依頼という一連の対話を実演します。/testsや\#selectionのようなスラッシュコマンドやチャット変数の使用も効果的です。

**初心者向け解説:** Copilotに「このコードは何をしているの？」や「Pythonでループを書くにはどうすればいい？」のように話しかけることができます。Copilotはそれに答え、コード例も示してくれます。

### **GitHub Copilot Voice**

VS Codeなどの対応IDEにおいて、音声コマンドでCopilot Chatと対話できる機能です。プロンプトを音声で入力し、応答が音声で読み上げられることもあります 27。この音声入力の搭載は、テキスト、音声、さらには視覚情報（コーディングエージェントによるUIモックアップの画像理解など 17）を含むマルチモーダルな対話が一般的になる未来を示唆しており、多様な好みやアクセシビリティのニーズに対応する可能性があります。

**セットアップ:** 通常、VS CodeのCopilot Chat拡張機能の一部として提供され、マイクへのアクセス許可が必要になる場合があります 27。

**使い方:** チャットインターフェースで音声入力を有効にし、プロンプトを話します。

**具体例:** (音声入力が有効なVS Codeチャットで) 「Copilot、選択した関数を説明して」

**デモに適した内容:** VS Codeチャットで音声を使って簡単な質問をする様子を短く実演します。

**初心者向け解説:** 質問をタイピングする代わりに、マイクを使ってCopilotに話しかけることができます。

*注: 27および27では「音声（ボイスチャット）を使用してチャットプロンプトを入力する」と言及されていますが、2025年6月時点で「Copilot Voice」が独立した主要機能としてどの程度確立されているかは確認が必要です。Copilot Chatの入力モダリティの一つである可能性が高いです。*

### **GitHub Copilot CLI**

Copilotの支援機能をコマンドラインにもたらします。コマンドの説明、タスクに応じたコマンドの提案を行い、ZshやPowerShellなどのシェルと統合できます 6。

* **コマンド:**  
  * gh copilot explain "\<コマンド\>": 指定されたシェルコマンドを説明します 8。  
  * gh copilot suggest "\<タスクの説明\>": タスクを達成するためのコマンドを提案します 8。  
  * gh copilot alias: より短いエイリアス（例: ghcsで提案、ghceで説明）を設定します 31。  
* **対話セッション:** suggestコマンドは、詳細を明確にするための対話セッションを開始できます 8。  
* **実行（エイリアス/許可が必要）:** 提案されたコマンドを実行するように設定できます 8。

**具体例:**

Bash

gh copilot suggest "カレントディレクトリとサブディレクトリ内の全ての.mdファイルを検索し、その数をカウントする"  
\# Copilotの提案例: find. \-name "\*.md" \-type f | wc \-l  
gh copilot explain "tar \-czvf archive.tar.gz /path/to/dir"

**デモに適した内容:** 一般的だが少し複雑なコマンドラインタスクに対してgh copilot suggestを使用し、次に馴染みのないコマンドに対してgh copilot explainを使用する実演。

**初心者向け解説:** ターミナルコマンドが分からない場合や、コマンドラインで何かをする方法が分からない場合に、Copilot CLIに助けを求めることができます。

### **GitHub Copilot Workspace**

Issueや自然言語による説明から始まり、コーディングタスクの計画、実装、検証を支援するAI搭載環境です（6、6ではパブリックプレビュー、2025年6月までには一般提供の可能性が高い）。計画を提案し、複数のファイルにまたがるコードを生成し、反復とテストを可能にします 4。

* **仕組み:**  
  1. **タスク入力:** Issue、プルリクエスト、または自然言語による説明から開始します 4。  
  2. **仕様と計画:** Copilotがコードベースを分析し、仕様（現状、望ましい状態）と計画（作成/変更するファイル、アクション）を生成します。これらは開発者が編集可能です 4。  
  3. **実装:** 計画に基づいてコードを生成します。  
  4. **検証と反復:** 統合ターミナル、テスト用のセキュアなポートフォワーディング。テスト失敗時には「修復エージェント」が修正を試みます。編集可能な差分表示 4。  
  5. **コラボレーション:** 共有可能なワークスペース、ワンクリックでのプルリクエスト作成 4。  
* **搭載モデル:** GPT-4o（または2025年6月時点での新しいモデル）4。

**ユースケース例:** 「Passport.jsを使用してユーザー認証を実装する。ログイン、登録、ログアウトのルートを作成する。ユーザーモデルを更新してハッシュ化されたパスワードを含める。」Copilot Workspaceは既存のプロジェクトを分析し、計画（例：ルート用の新しいファイル、モデルの変更、新しいコントローラー関数）を提案し、初期コードを生成し、開発者がテストと改良を行えるようにします。

**デモに適した内容:** GitHub Issueから開始し、Copilot Workspaceで開きます。Workspaceに計画と初期コードを生成させ、計画や生成されたコードを編集する方法を示します。

**初心者向け解説:** プロジェクトマネージャーとコーダーチームが一体となったようなものです。大きなタスク（新機能の追加など）を説明すると、Workspaceがその計画を手伝い、初期コードの多くを書いてくれます。

### **Pull Request サポート機能**

* **PRサマリー:** プルリクエスト内の変更点、影響を受けるファイル、レビュアーが注目すべき点をAIが生成したサマリーで表示します 6。  
* **PR説明文生成 (Copilot Text Completion):** プルリクエストの説明文を迅速かつ正確に記述するのを支援するAIによるテキスト補完機能です 6。  
* **Coding AgentによるPR作成:** Issueを割り当てると、Coding Agentが変更案を含むプルリクエストを作成し、レビュー可能な状態にします 6。  
* **CopilotによるPRレビュー支援:** Copilotは、変更点を説明したり改善案を提案したりすることで、プルリクエストのレビューを支援できます 6。

**具体例:** プルリクエストが作成されると、Copilotが自動的にサマリーを生成します。「このPRは、パフォーマンス向上のためにユーザープロファイルの新しいキャッシュレイヤーを導入します。主な変更点はUserService.javaとCacheConfig.javaです。レビュアーはキャッシュの破棄ロジックに注目してください。」

**デモに適した内容:** 小さなプルリクエストを作成し、自動生成されたサマリーを表示します。時間があれば、Coding AgentがIssueからプルリクエストを作成する様子も示します。

**初心者向け解説:** あなたやチームメイトがコードに変更を加えた際（プルリクエスト）、Copilotが変更内容の要約を自動的に書いてくれるので、誰もが理解しやすくなります。

### **ドキュメント生成機能**

* **インラインコードドキュメント:** Copilot Chatを使用して（例：/docコマンドや自然言語プロンプト）、関数やクラスなどのインラインコメントやdocstringを生成します 2。  
* **プロジェクトドキュメント:** Copilot Chatは、コードの文脈に基づいて、より広範なプロジェクトドキュメント（例：READMEのセクション、モジュールの説明）の生成を支援します 3。  
* **コードの説明:** ドキュメンテーションの前段階となる、Chatの主要機能です 3。  
* **Copilot for Docs (旧機能):** 40では「Copilot for Docs」は*終了した実験的機能*（テクニカルプレビューは2023年12月終了）とされています。その知見は、2025年6月までにはスタンドアロン製品としてではなく、Copilot Chatや他の機能に統合されている可能性があります。現在のChatや他のツール内のドキュメンテーション機能に焦点を当てるべきです。

具体例 (Python、Chat使用):  
関数を選択:

Python

def complex\_algorithm(data, threshold):  
    \#... 複雑なロジック...  
    return result

Copilot Chatへのプロンプト: 「選択したPython関数のdocstringを生成し、パラメータ、処理内容、戻り値を説明してください。」

**デモに適した内容:** ドキュメントがない関数を選択し、Copilot Chatを使ってそのdocstringといくつかのインラインコメントを生成させます。

**初心者向け解説:** Copilotは、コードが何をしているかを説明するコメントを書く手助けをしてくれるので、後であなたや他の人が理解しやすくなります。

## **4\. 対応環境とセットアップ (5分)**

GitHub Copilotは、開発者が日常的に使用する多様な環境で利用できるように設計されています。これにより、開発者は好みのツールからシームレスにAIの支援を受けることができます。この広範なサポートは、Copilotを特定のベンダーエコシステムに縛られない、開発者のワークフローに深く組み込まれた支援ツールとして位置づける戦略の現れです。

### **対応IDE/エディタ一覧**

* **主要サポート:** Visual Studio Code、Visual Studio、JetBrains製IDE（IntelliJ IDEA、PyCharm、WebStormなど）、Neovimが主要な対応環境として挙げられます 6。  
* **その他言及されている環境:** Azure Data Studio、Xcode、Eclipse、Vimなどもサポート対象として言及されています 6。  
* *注: サポート対象は拡大する可能性があるため、2025年6月時点での公式リストを確認することが推奨されます。*

### **対応プログラミング言語**

* **特に得意とする言語:** Python、JavaScript、TypeScript、Ruby、Go、C\#、C++で特に優れた提案能力を発揮します 19。  
* **広範なサポート:** 「多数の言語と多種多様なフレームワーク」に対して提案を行うことができます 26。  
* **コメント提案:** 古い情報源ではC\#とC++で特に言及されていますが 19、2025年までにははるかに広範になっていると考えられます。

### **インストール手順**

* **IDE拡張機能:**  
  * **VS Code:** Marketplaceから「GitHub Copilot」および「GitHub Copilot Chat」拡張機能をインストールします 1。  
  * **JetBrains:** JetBrains Marketplaceからプラグインをインストールします 26。  
  * **Visual Studio:** 統合されているか、拡張機能マネージャー経由でインストールします 28。  
* **GitHub CLI拡張機能:**  
  1. GitHub CLI (gh)をインストールします 8。  
  2. Copilot拡張機能をインストールします: gh extension install github/gh-copilot 8。  
  3. 認証を行います: gh auth loginの後、gh copilot authを実行します 31。

### **初期設定とカスタマイズ**

* **認証:** アクティブなCopilotサブスクリプション（Free、Pro、Business、Enterpriseのいずれか）を持つGitHubアカウントでサインインします 25。  
* **基本設定 (IDE):** Copilotの有効/無効化、提案トリガーの設定、テレメトリ設定の管理（個人ユーザー向け）などを行います。  
* **コンテンツ除外 (Business/Enterprise):** 管理者は、Copilotのコンテキストから除外するコンテンツを設定できます 11。  
* **ポリシー設定 (Business/Enterprise):** 管理者は、Bing検索へのアクセス、パブリックコードと一致する提案、代替AIモデルの使用、Copilot Coding Agentなどの機能に関するポリシーを管理します 11。  
* **パーソナルカスタムインストラクション:** ユーザーは、Copilot Chatの応答に関する個人的な設定（例：言語、スタイル）を行うことができます 11。

これらの多層的なカスタマイズオプション（個人設定から組織全体のポリシー制御まで）は、個々の開発者のスタイル、チームの慣習、そして企業のガバナンス要件といった多様なニーズに対応する必要性を反映しています。Copilotは適応性の高いツールとして設計されており、これらのカスタマイズレイヤーを活用することが、上級ユーザーや企業にとって価値を最大化し、コンプライアンスを確保する鍵となります。

## **5\. 実践的な活用テクニック (5分)**

GitHub Copilotの能力を最大限に引き出すためには、効果的なプロンプトの記述方法、コンテキストの活用、カスタムインストラクションの設定、そして効率的な操作方法を習得することが重要です。これらのテクニックは、AIとの対話をより生産的で質の高いものにします。

### **効果的なプロンプトの書き方**

Copilot Chatやその他の生成機能から高品質で関連性の高い応答を得るためには、プロンプトの質が重要です。これは、生成AIツールの出力品質が入力（プロンプトとコンテキスト）の品質に直接比例するという原則に基づいています。効果的なプロンプトエンジニアリングは、AIを活用する開発者にとって新たな必須スキルとなりつつあります 30。

* **具体性:** 何を求めているのかを正確に記述します。「関数を書いて」ではなく、「整数のリストを受け取り、偶数の合計を返すPython関数を書いてください」のように具体的に指示します 30。  
* **コンテキストの提供:** プロンプト内、またはIDEの機能（開いているファイル、選択範囲など）を通じて、可能な限り多くの関連コンテキストを提供します 30。  
* **タスクの分解:** 複雑なリクエストの場合は、より小さく連続したプロンプトに分割します 30。  
* **反復的な改良:** 最初の回答が完璧であるとは限りません。フォローアップの質問をして出力を改良します 30。  
* **ペルソナの活用（暗黙的/明示的）:** 「シニアPython開発者として説明して…」のように指示することで、Copilotのスタイルを誘導できる場合があります。  
* **具体例** 30**:**  
  * 悪い例: 「このコードを修正して。」  
  * 良い例: 「このJavaScriptコードはメールアドレスを検証するものですが、ハイフン付きのメールで失敗します。正規表現を使って修正するにはどうすればよいですか？現在の正規表現は/.../です。」  
  * 「このC\#のメール検証用コードスニペットをPythonに翻訳してください。」34。

### **コンテキストの活用方法**

Copilotは、提供されるコンテキストの質と量に応じて、より適切で正確な支援を提供できます。Copilotは、広範なコンテキスト（開いているファイル、\#codebase）から特定のコンテキスト（\#selection、リポジトリのカスタムインストラクション）まで、複数の方法でコンテキストを理解するよう設計されており、開発者はこれらのメカニズムを組み合わせることで、さまざまなタスクに対してCopilotの焦点を微調整できます。

* **開いているファイル:** IDEで現在開いているファイルの内容をCopilotが参照し、プロジェクトのコンテキストを理解します。関連ファイルを開いておくことが重要です 24。  
* **プロジェクト構造:** 明確な命名規則を持つ整理されたプロジェクトは、Copilotが関連性を推測するのに役立ちます。  
* **\#codebase / @workspace:** これらのチャット変数や参加者を使用して、ワークスペース/プロジェクト全体を考慮するようCopilotに指示します 5。  
* **\#selection / コードのハイライト:** Copilot Chatにプロンプトを出す前に特定のコードスニペットを選択し、注意を集中させます 27。  
* **\#file:\<パス\>:** チャットプロンプトで特定のファイルを参照します 27。  
* **\#fetch \<URL\>:** Copilotがドキュメントやコンテキストを取得するためのURLを提供します 5。

### **カスタムインストラクション**

カスタムインストラクションは、AIの振る舞いを事前にプログラムし、特定のニーズに応じて標準化するための「AI設定ファイル」のように機能します。これにより、チームはCopilotの出力を確立されたエンジニアリングプラクティスに整合させることができます。

* **パーソナルインストラクション:** GitHub.comのCopilot Chatに対するグローバルな設定（応答言語、コーディングスタイル、優先フレームワークなど）を行います 11。  
  * 例: 「常にTypeScriptで関数コンポーネントの例を提示してください。Promisesよりもasync/awaitを優先してください。」33。  
* **リポジトリカスタムインストラクション (.github/copilot-instructions.md):** プロジェクト固有のガイドライン、ツール、コーディング標準を定義し、Copilotがそのリポジトリと対話する際に遵守するようにします 11。  
  * 例: 「Javaの依存関係管理にはMavenではなくBazelを使用しています。Javaパッケージについて話すときは、常にBazelを使用する指示とコードサンプルを提示してください。」35。  
* **オーガニゼーションカスタムインストラクション (Enterprise):** 組織全体のデフォルトとガイドラインを設定します 11。  
* **優先順位:** パーソナル \> リポジトリ \> オーガニゼーションの順で適用されますが、関連する全てのインストラクションが組み合わされます 33。

**デモに適した内容:** GitHub.comのCopilot Chatで、パーソナルカスタムインストラクション（例：「Reactでは常に関数コンポーネントを使用し、説明はドイツ語で提供する」）が提案にどのように影響するかを実演します。

### **ショートカットキーと効率的な操作**

* **VS Code** 5**:**  
  * Ctrl+Alt+I: チャットビューを開く。  
  * Ctrl+I: インラインチャットを開始。  
  * Ctrl+.: チャットビューでチャットモード（Ask、Edit、Agent）を切り替え。  
  * Tab: インラインコード提案を承認。  
  * Esc: インラインコード提案を却下。  
  * Alt+\] / Alt+\[ (Macでは Option+\] / \`Option+。  
* **チャットのスラッシュコマンド:** /explain、/test、/fix、/newNotebookなどでタスク指定を高速化 27。

## **6\. エンタープライズ向け機能 (5分)**

GitHub Copilotは、大規模組織特有のニーズに応えるため、BusinessおよびEnterpriseプランを通じて、管理、セキュリティ、コンプライアンス、カスタマイズに関する高度な機能を提供しています。これらの機能は、企業がAIを統制下で安全に導入し、その価値を最大限に引き出すことを支援します 6。

### **組織での導入・管理**

* **ライセンス割り当て:** 管理者は、組織内のユーザーまたはチームにCopilot Business/Enterpriseライセンスを割り当てます 10。セルフサービスライセンスもオプションとして提供される場合があります 11。  
* **ユーザー管理:** ユーザーアクセスと権限を管理するためのツールが提供されます 23。  
* **導入戦略:** 導入計画、採用促進に関するガイダンスが利用可能です 11。

### **ポリシー設定**

* **集中管理:** エンタープライズオーナーは、エンタープライズ内の全ての組織に対してポリシーを設定できます。エンタープライズレベルで設定されていない場合、組織オーナーがポリシーを管理できます 11。  
* **機能トグル:** 特定のCopilot機能（IDE/GitHub.comでのCopilot Chat、CLI、Bing検索へのアクセス、パブリックコードと一致する提案、代替AIモデルの使用、Copilot Coding Agentなど）の有効/無効を切り替えることができます 11。  
* **コンテンツ除外:** Copilotがコンテキストとして使用したり学習したりすべきでないファイルやリポジトリを指定できます（機密コードの保護）11。

### **使用状況の監視とレポート**

* **監査ログ:** Copilotの設定、ポリシー、シート割り当て、その他の管理アクションへの変更を追跡します 11。Business/Enterpriseで利用可能で、ログは通常180日間保持されます。  
* **ユーザーアクティビティデータ/利用状況分析:** 時間経過に伴う利用状況の分析、アクティブ/非アクティブユーザーの特定を行うためのツールやAPIが提供されます 11。  
* **Copilot Metrics API:** 利用状況メトリクスへのプログラムによるアクセスが可能です 11。  
* **プレミアムリクエストの監視:** 許容量に対するプレミアムリクエストの消費量を追跡します 20。

### **セキュリティとコンプライアンス**

* **データ処理:**  
  * Business/Enterprise向けのプロンプトと提案は、公開モデルのトレーニングには使用されません 24。  
  * データ送信は安全（例：AzureへのHTTPS通信）です 24。  
  * エディタ内のプロンプトは応答後に破棄され、Chatでは会話履歴のために保持されますが、基盤モデルのトレーニングには使用されません 24。  
* **パブリックコードのフィルタリング:** GitHub上のパブリックコードと一致する提案をブロックするオプションがあります（フィルターは約150文字のスニペットを比較）11。  
* **脆弱性防止:** コンテンツフィルターが、有害、攻撃的、または安全でないコード提案を検出し、防止しようとします 24。ただし、これは完全ではありません 13。

### **IP保護とコードのプライバシー**

* **IP補償:** GitHubは、Copilot Business/Enterpriseからの未修正の提案に対して、「パブリックコードと一致する提案」フィルターが「ブロック」に設定されている場合にIP補償を提供します 10。このIP補償が責任ある利用（フィルターの有効化）に結びついている点は、GitHubが企業にリスク軽減機能の利用を奨励する巧妙な方法であり、AIは強力であるもののガードレールが必要であることを強調しています。  
* **コードのプライバシー:**  
  * Business/Enterprise顧客のプライベートリポジトリのコードスニペットは、公開モデルのトレーニングには使用されません 24。  
  * コンテンツ除外ポリシーは、指定されたコードがCopilotによって処理されるのを防ぐことで、プライバシーをさらに強化します 11。  
* **提案の所有権:** GitHubは、Copilotによって生成された提案の所有権を主張しません。ユーザー/組織が所有権を保持します 13。

### **ナレッジベース (Enterprise Only)**

* **説明:** 組織のオーナーは、1つ以上のリポジトリにまたがるMarkdownドキュメントからナレッジベースを作成できます。これにより、メンバーはCopilot Chat（GitHub.com、VS Codeなど）で質問する際に、そのキュレーションされたドキュメントをコンテキストとして使用できます 6。  
* **影響:** Copilotが組織固有の、関連性の高い回答やコードを提供できるようになり、内部ナレッジを効果的に「オンボーディング」します。このナレッジベース機能は、AIを真にカスタマイズするための重要な一歩であり、Copilotが組織の独自のソフトウェアランドスケープについて深く理解することを可能にし、企業内での価値と実用性を劇的に向上させます。これはEnterpriseティアの主要な差別化要因です。

## **7\. 最新機能とロードマップ (3分)**

GitHub Copilotは継続的なイノベーションを特徴としており、2025年もその例外ではありません。最新機能の導入と将来のロードマップは、AI開発の最前線に立ち続けるというGitHubのコミットメントを反映しています。

### **2025年に追加された新機能**

2025年前半には、いくつかの重要な機能が一般提供されたか、大幅なアップデートが行われたと考えられます。

* **Agent Modeの強化:** Copilot Chat内のAgent ModeおよびスタンドアロンのCoding Agentの自律性と機能がさらに向上している可能性があります 5。  
* **MCPエコシステムの成長:** Model Context Protocol (MCP) サーバーの採用が拡大し、より多くのサードパーティツールやエンタープライズデータソースとの連携が可能になっているでしょう 5。このMCPや後述のCopilot Extensionsへの注力は、Copilotを閉じたシステムではなく、広範な外部ツールやデータソースと統合できる拡張可能なプラットフォームにするという戦略を示唆しています。  
* **Visual Studioにおける「Next Edit Suggestions」:** 予測編集機能が強化され、VS Code以外にも展開されている可能性があります 6。  
* **Copilot Studioとの連携（該当する場合）:** 2025年5月のCopilot Studioのアップデート（A2Aプロトコル、エージェントによるコンピュータ操作、BYOモデル、MCPのGAなど 14）が、GitHub Copilotの機能に直接的な強化や統合をもたらしているか確認が必要です。本発表ではGitHub Copilotに焦点を当てます。  
* **新しいLLMオプション:** 新しい基盤LLM（例：新しいGPTバージョン、ClaudeやGeminiなどの他のモデル）が一般提供されたり、特定のタスクでより深く統合されたり、デフォルトになったりしている可能性があります 5。これにより、ユーザーはコスト、能力、専門性といったニーズに応じてモデルを選択できるようになります。

### **ベータ版・プレビュー機能 (2025年6月時点)**

2025年6月頃にパブリックベータまたはテクニカルプレビュー段階にあると予想される機能は以下の通りです。

* **Copilot Workspace:** 完全な一般提供に至っていない場合、そのステータスと最新のプレビュー機能 4。  
* **Coding Agent:** 完全な一般提供に至っていない場合、そのステータスと最新のプレビュー機能 6。  
* **Copilot in GitHub Desktop:** 引き続きプレビュー版である可能性 6。  
* **Copilot Spaces:** 引き続きプレビュー版である可能性 6。  
* **GitHub Models (パブリックプレビュー):** GitHub上で様々なLLMに直接アクセスできる機能の状況 6。  
* **Copilot Extensions:** サードパーティ製拡張機能のエコシステムは、多くがプレビュー段階で進化を続けている可能性があります 6。  
* **コードレビューにおける実験的な言語/機能:** 11。

### **今後の開発予定**

GitHubの将来ビジョンは、「AIネイティブでエージェント的な体験」、「開発者の選択肢」、「エンタープライズグレードのセキュリティ」といったテーマに集約されます 9。この「エージェント的」な未来への注力は、GitHubのロードマップや最近の機能発表で顕著であり 4、単なる支援を超えて、AIエージェントが開発タスクを自律的に計画、実行、反復処理する方向性を示しています。

* **より高度なエージェント機能:** 人間の介入を減らし、複雑なタスクを処理できる、より自律的なエージェントへの継続的な取り組み 7。  
* **IDEおよびワークフローとのより深い統合:** 開発ツールやプロセス内で、AI支援をさらにシームレスかつ文脈認識的にする。  
* **強化されたコラボレーション機能:** Copilot Workspaceなどで見られるような、AIによるチームワークの促進 4。  
* **パーソナライゼーションとカスタマイズ:** Copilotを個人、チーム、組織のニーズに合わせて調整するための、より洗練された方法（カスタムインストラクション、ナレッジベース、MCPの活用）。  
* **マルチモーダルAI:** Copilotがテキスト/コードだけでなく、図やUIモックアップ（17の画像理解が示唆）なども理解・生成する可能性。

これらの開発予定は、GitHubがCopilotとAIをソフトウェア開発の未来においてどのように位置づけているかを示すものです。

## **8\. 注意点と制限事項 (2分)**

GitHub Copilotは強力な開発支援ツールですが、その利用にあたってはいくつかの注意点と制限事項を理解しておくことが不可欠です。これらを認識することで、AIをより安全かつ効果的に活用できます。

### **生成されるコードの品質と責任**

* **完全ではない:** 生成されるコードには、バグ、非効率な部分、安全でないパターンが含まれる可能性があります 13。  
* **人間の監督が不可欠:** 提案されたコードを使用する前に、開発者自身がレビュー、テスト、理解する最終的な責任を負います。盲目的にコピー＆ペーストしてはいけません 1。この「共同責任」モデルは、AIが支援し、開発者が検証するという新しい開発様式を意味します。  
* **セキュリティ脆弱性:** Copilotは、トレーニングデータに含まれる公開コードに既知の脆弱性が存在する場合、それを不注意に提案したり、新たな脆弱性を生み出したりする可能性があります 23。GitGuardianの調査では、Copilotがアクティブなリポジトリでシークレット漏洩の発生率が高いことが示唆されていますが、因果関係は複雑です 38。

Copilotは開発速度を向上させる一方で 10、これらのリスク（バグ、脆弱性、開発者の深い理解の低下 23）との間に潜在的な緊張関係が存在します。このため、Copilotの速度を活用しつつ、コードレビューやセキュリティスキャン、継続的な学習の厳格さを維持するためのベストプラクティスを確立することが求められます。

### **ライセンス上の注意点**

* **パブリックコードとの一致:** フィルター機能は存在しますが 13、特にフィルターが無効な場合や非常に短いスニペットの場合、提案がパブリックコードに類似する可能性は依然としてわずかに残ります。プロジェクトのライセンスへの影響を理解することが重要です。  
* **IP補償の条件:** Business/Enterpriseプランの場合、IP補償は重複検出フィルターの適切な利用が条件となります 12。

### **プライバシーとデータの取り扱い**

* **プロンプト/スニペットの取り扱い:**  
  * **Individual (Pro/Pro+):** モデル改善に使用される可能性のあるテレメトリのオプトアウトが可能です。オプトアウトした場合、またはエディタ補完のデフォルトでは、プロンプト/提案は基盤LLMのトレーニングには保持されません 24。  
  * **Business/Enterprise:** プロンプトと提案は、公開されている基盤LLMのトレーニングには使用されません 24。  
* **コンテンツ除外:** 特定のプライベートコードが処理されないようにするためのエンタープライズ機能です 11。  
* **透明性:** GitHubはTrust Centerを通じて透明性を確保することを目指しています 24。

### **既知の制限事項**

* **複雑な意図の理解:** 非常に抽象的、曖昧、または不十分に定義されたプロンプトの理解に苦労する場合があります 23。  
* **コンテキストウィンドウ:** LLMには有限のコンテキストウィンドウがあり、非常に長い会話やファイルの場合、コンテキストキューで適切に管理しないと、Copilotが以前の部分を「忘れる」ことがあります（LLMの暗黙的な制限であり、23では一部のケースで以前の対話を忘れることが言及されています）。  
* **知識の陳腐化:** モデルは特定のカットオフ日までのデータでトレーニングされています。Bing検索 11 や \#fetch 5 のような機能で補完されない限り、非常に新しいライブラリ、API、またはCVEについては知らない可能性があります。  
* **時折の無関係性/不正確性:** 時として、トピックから外れた、微妙に間違った、またはベストプラクティスではないコードや説明を生成することがあります 23。  
* **過度な依存のリスク:** 注意しないと、開発者が過度に依存し、批判的思考が低下する可能性があります 23。

これらの「既知の制限事項」の多くは、LLMにおける活発な研究開発分野であり、Bing統合 11、\#fetch 5、より高度なモデルの開発といった機能は、これらの緩和を目的としています。現在の制限事項を認識しつつも、AIの状況は急速に進化しており、今日の制限が将来のイテレーションで軽減または克服される可能性があることを理解しておくべきです。

## **補足としてリストアップすべき機能**

本報告で主要機能として詳細に触れられなかったものの、注目すべき補足的な機能として以下が挙げられます。

* **GitHub DesktopにおけるCopilot (コミットメッセージ生成):** プロジェクトへの変更に基づいて、GitHub Desktop内でコミットメッセージや説明文を自動生成する機能です 6。これにより、一般的で時に退屈な作業を自動化し、コミットメッセージの品質と一貫性を向上させます。  
* **GitHub Modelsと選択肢 (Claude, Gemini, OpenAI派生, o3, o4-miniなど):** 開発者が複数のAIモデルから選択できる機能です 5。モデルの選択は、パフォーマンス、コスト（プレミアムリクエスト経由）、特定の強みといった要素を考慮して、AIを特定のタスク要件やコスト制約に適合させることを可能にします。  
* **Copilot Spaces (パブリックプレビュー):** 特定のタスクのためにCopilotのコンテキストを整理し、一元化する機能です 6。これにより、ユーザーが関連情報（コード、ドキュメント、仕様など）をキュレーションし、Copilotに提供することで、より焦点の合った正確な支援を得られるようになります。  
* **Copilot Extensionsエコシステム:** サードパーティ（および企業内部）が、他のツールやサービスをCopilot Chatに直接統合する拡張機能を構築・共有できる仕組みです 3。これにより、Copilot ChatがGitHub中心のツールから、より広範な開発者サービスと自然言語で対話するためのハブへと進化します。  
* **Chatのためのセマンティックインデックス作成:** コードベースのセマンティックな意味を理解することで、チャット応答の関連性を向上させる機能です 11。これにより、Copilot Chatはキーワードマッチングを超え、ユーザーのコード内のより深い関係性や概念を理解し、よりインテリジェントで正確な回答や提案を行うことができます。

## **まとめと今後の展望**

2025年6月時点でのGitHub Copilotは、単なるコード補完ツールから、開発ライフサイクル全体を支援する包括的なAI開発プラットフォームへと著しい進化を遂げています。多様な製品ラインナップは、個人のホビイストから大規模エンタープライズまで、幅広いユーザー層のニーズに対応し、特にエンタープライズ向けには、管理、セキュリティ、IP保護といった高度な機能が提供されています。

Copilot Chat、Copilot Workspace、Coding Agentといった主要機能は、開発者とAIとの対話方法を変革し、より自律的で高度なタスク実行を可能にしつつあります。この「エージェント的」な方向性は、GitHubの将来戦略の中核を成しており、開発者の役割を、目標設定やAIエージェントの監督、より創造的な側面にシフトさせていく可能性があります。

効果的なプロンプトエンジニアリング、コンテキストの戦略的活用、そしてカスタムインストラクションによるパーソナライゼーションは、Copilotの能力を最大限に引き出すための鍵となります。また、Model Context Protocol (MCP) やCopilot Extensionsといった技術は、ツールの拡張性と相互運用性を高め、より広範なエコシステムとの連携を促進します。

しかし、生成されるコードの品質に対する責任は依然として開発者にあり、セキュリティ脆弱性やライセンス上の注意点、プライバシーへの配慮も不可欠です。これらの課題に対応するため、GitHubはフィルター機能や透明性の高いデータ取り扱い方針を提供していますが、人間の監督と批判的思考の重要性は変わりません。

今後の展望として、GitHub Copilotはさらに高度なエージェント機能、IDEやワークフローとのより深い統合、マルチモーダルAIへの対応などを通じて、開発者の生産性と創造性を新たなレベルへと引き上げることが期待されます。この急速な進化の過程で、開発者自身も新しいスキルを習得し、AIとの協調関係を再定義していく必要があるでしょう。GitHub Copilotは、ソフトウェア開発の未来を形作る上で、中心的な役割を果たし続けると考えられます。

#### **引用文献**

1. How to Use GitHub Copilot for Free (Student Discount Guide) \- DEV Community, 6月 10, 2025にアクセス、 [https://dev.to/therealmrmumba/how-to-use-github-copilot-for-free-student-discount-guide-2f56](https://dev.to/therealmrmumba/how-to-use-github-copilot-for-free-student-discount-guide-2f56)  
2. Evolution of GitHub Copilot to Copilot X \- Expert Top Guide, 6月 10, 2025にアクセス、 [https://www.n-school.com/evolution-of-github-copilot-to-copilot-x/](https://www.n-school.com/evolution-of-github-copilot-to-copilot-x/)  
3. How to use GitHub Copilot: What it can do and real-world examples, 6月 10, 2025にアクセス、 [https://github.blog/ai-and-ml/github-copilot/what-can-github-copilot-do-examples/](https://github.blog/ai-and-ml/github-copilot/what-can-github-copilot-do-examples/)  
4. Copilot Workspace \- GitHub Next, 6月 10, 2025にアクセス、 [https://githubnext.com/projects/copilot-workspace](https://githubnext.com/projects/copilot-workspace)  
5. Celebrating Microsoft's 50th Anniversary with exciting new GitHub Copilot Features, 6月 10, 2025にアクセス、 [https://blog.nimbus-musings.com/posts/gh-copilot-new-features/](https://blog.nimbus-musings.com/posts/gh-copilot-new-features/)  
6. GitHub Copilot features \- GitHub Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features)  
7. See what's new with GitHub Copilot, 6月 10, 2025にアクセス、 [https://github.com/features/copilot/whats-new](https://github.com/features/copilot/whats-new)  
8. Using GitHub Copilot in the command line, 6月 10, 2025にアクセス、 [https://docs.github.com/copilot/using-github-copilot/using-github-copilot-in-the-command-line](https://docs.github.com/copilot/using-github-copilot/using-github-copilot-in-the-command-line)  
9. GitHub Galaxy 2025, 6月 10, 2025にアクセス、 [https://galaxy.github.com/](https://galaxy.github.com/)  
10. Exploring GitHub Copilot Plans \- KodeKloud Notes, 6月 10, 2025にアクセス、 [https://notes.kodekloud.com/docs/GitHub-Copilot-Certification/Management-of-GitHub-Copilot/Exploring-GitHub-Copilot-Plans](https://notes.kodekloud.com/docs/GitHub-Copilot-Certification/Management-of-GitHub-Copilot/Exploring-GitHub-Copilot-Plans)  
11. Managing policies and features for Copilot in your enterprise ..., 6月 10, 2025にアクセス、 [https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise)  
12. resources.github.com, 6月 10, 2025にアクセス、 [https://resources.github.com/learn/pathways/copilot/essentials/establishing-trust-in-using-github-copilot/\#:\~:text=GitHub%20Copilot%20Business%20and%20GitHub,the%20copyright%20claim%20in%20court.](https://resources.github.com/learn/pathways/copilot/essentials/establishing-trust-in-using-github-copilot/#:~:text=GitHub%20Copilot%20Business%20and%20GitHub,the%20copyright%20claim%20in%20court.)  
13. Establishing trust in using GitHub Copilot, 6月 10, 2025にアクセス、 [https://resources.github.com/learn/pathways/copilot/essentials/establishing-trust-in-using-github-copilot/](https://resources.github.com/learn/pathways/copilot/essentials/establishing-trust-in-using-github-copilot/)  
14. What's new in Copilot Studio: May 2025 \- Microsoft, 6月 10, 2025にアクセス、 [https://www.microsoft.com/en-us/microsoft-copilot/blog/copilot-studio/whats-new-in-copilot-studio-may-2025/](https://www.microsoft.com/en-us/microsoft-copilot/blog/copilot-studio/whats-new-in-copilot-studio-may-2025/)  
15. Feature Request: Add History Tracking for Copilot Edits · Issue \#2460 \- GitHub, 6月 10, 2025にアクセス、 [https://github.com/microsoft/vscode-copilot-release/issues/2460](https://github.com/microsoft/vscode-copilot-release/issues/2460)  
16. Next edit suggestions available in Visual Studio GitHub Copilot \- Microsoft Developer Blogs, 6月 10, 2025にアクセス、 [https://devblogs.microsoft.com/visualstudio/next-edit-suggestions-available-in-visual-studio-github-copilot/](https://devblogs.microsoft.com/visualstudio/next-edit-suggestions-available-in-visual-studio-github-copilot/)  
17. Assigning and completing issues with coding agent in GitHub Copilot, 6月 10, 2025にアクセス、 [https://github.blog/ai-and-ml/github-copilot/assigning-and-completing-issues-with-coding-agent-in-github-copilot/](https://github.blog/ai-and-ml/github-copilot/assigning-and-completing-issues-with-coding-agent-in-github-copilot/)  
18. Getting free access to Copilot Pro as a student, teacher, or ..., 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/getting-started-with-copilot-on-your-personal-account/getting-free-access-to-copilot-pro-as-a-student-teacher-or-maintainer](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/getting-started-with-copilot-on-your-personal-account/getting-free-access-to-copilot-pro-as-a-student-teacher-or-maintainer)  
19. About individual Copilot plans and benefits \- GitHub Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/getting-started-with-copilot-on-your-personal-account/about-individual-copilot-plans-and-benefits](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/getting-started-with-copilot-on-your-personal-account/about-individual-copilot-plans-and-benefits)  
20. About billing for individual Copilot plans \- GitHub Enterprise Cloud Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-as-an-individual-subscriber/billing-and-payments/about-billing-for-individual-copilot-plans)  
21. About billing for GitHub Copilot, 6月 10, 2025にアクセス、 [https://docs.github.com/en/billing/managing-billing-for-your-products/managing-billing-for-github-copilot/about-billing-for-github-copilot](https://docs.github.com/en/billing/managing-billing-for-your-products/managing-billing-for-github-copilot/about-billing-for-github-copilot)  
22. Reviewing audit logs for Copilot Business \- GitHub Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/reviewing-activity-related-to-github-copilot-in-your-organization/reviewing-audit-logs-for-copilot-business](https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/reviewing-activity-related-to-github-copilot-in-your-organization/reviewing-audit-logs-for-copilot-business)  
23. GitHub Copilot: Complete Guide to Features, Limitations & Alternatives \- Swimm, 6月 10, 2025にアクセス、 [https://swimm.io/learn/github-copilot/github-copilot-complete-guide-to-features-limitations-alternatives](https://swimm.io/learn/github-copilot/github-copilot-complete-guide-to-features-limitations-alternatives)  
24. GitHub Copilot Data Pipeline Security \- GitHub Resources, 6月 10, 2025にアクセス、 [https://resources.github.com/learn/pathways/copilot/essentials/how-github-copilot-handles-data/](https://resources.github.com/learn/pathways/copilot/essentials/how-github-copilot-handles-data/)  
25. Generate Documentation Using GitHub Copilot Tools \- Training ..., 6月 10, 2025にアクセス、 [https://learn.microsoft.com/en-us/training/modules/generate-documentation-using-github-copilot-tools/](https://learn.microsoft.com/en-us/training/modules/generate-documentation-using-github-copilot-tools/)  
26. Getting code suggestions in your IDE with GitHub Copilot, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot](https://docs.github.com/en/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot)  
27. GitHub Copilot in VS Code cheat sheet, 6月 10, 2025にアクセス、 [https://code.visualstudio.com/docs/copilot/reference/copilot-vscode-features](https://code.visualstudio.com/docs/copilot/reference/copilot-vscode-features)  
28. Quickstart for GitHub Copilot \- GitHub Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/copilot/quickstart](https://docs.github.com/copilot/quickstart)  
29. Asking GitHub Copilot questions in your IDE \- GitHub Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide](https://docs.github.com/en/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide)  
30. Prompt engineering for Copilot Chat \- Visual Studio Code, 6月 10, 2025にアクセス、 [https://code.visualstudio.com/docs/copilot/chat/prompt-crafting](https://code.visualstudio.com/docs/copilot/chat/prompt-crafting)  
31. Getting Started with GitHub Copilot in the CLI \- The Lazy Administrator, 6月 10, 2025にアクセス、 [https://www.thelazyadministrator.com/2024/03/22/getting-started-with-github-copilot-in-the-cli/](https://www.thelazyadministrator.com/2024/03/22/getting-started-with-github-copilot-in-the-cli/)  
32. GitHub Galaxy '25, 6月 10, 2025にアクセス、 [https://resources.github.com/events/galaxy2025](https://resources.github.com/events/galaxy2025)  
33. Adding personal custom instructions for GitHub Copilot, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/customizing-copilot/adding-personal-custom-instructions-for-github-copilot](https://docs.github.com/en/copilot/customizing-copilot/adding-personal-custom-instructions-for-github-copilot)  
34. 5 Fun Copilot Prompts You Can Use Today \- DEV Community, 6月 10, 2025にアクセス、 [https://dev.to/nikl/5-fun-copilot-prompts-you-can-use-today-5dmb](https://dev.to/nikl/5-fun-copilot-prompts-you-can-use-today-5dmb)  
35. Adding repository custom instructions for GitHub Copilot, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot](https://docs.github.com/en/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot)  
36. Measuring Impact of GitHub Copilot, 6月 10, 2025にアクセス、 [https://resources.github.com/learn/pathways/copilot/essentials/measuring-the-impact-of-github-copilot/](https://resources.github.com/learn/pathways/copilot/essentials/measuring-the-impact-of-github-copilot/)  
37. Reviewing the audit log for your organization \- GitHub Enterprise Cloud Docs, 6月 10, 2025にアクセス、 [https://docs.github.com/enterprise-cloud@latest/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization](https://docs.github.com/enterprise-cloud@latest/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization)  
38. GitHub Copilot Security and Privacy Concerns: Understanding the Risks and Best Practices, 6月 10, 2025にアクセス、 [https://blog.gitguardian.com/github-copilot-security-and-privacy/](https://blog.gitguardian.com/github-copilot-security-and-privacy/)  
39. Responsible use of GitHub Copilot Chat in GitHub, 6月 10, 2025にアクセス、 [https://docs.github.com/en/copilot/responsible-use-of-github-copilot-features/responsible-use-of-github-copilot-chat-in-github](https://docs.github.com/en/copilot/responsible-use-of-github-copilot-features/responsible-use-of-github-copilot-chat-in-github)  
40. Copilot for Docs \- GitHub Next, 6月 10, 2025にアクセス、 [https://githubnext.com/projects/copilot-for-docs/](https://githubnext.com/projects/copilot-for-docs/)