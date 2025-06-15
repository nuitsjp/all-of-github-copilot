生成 AI アプリケーションを開発する場合は、GitHub Models を使用して、AI モデルを無料で検索して実験できます。 アプリケーションを運用環境に移行する準備ができたら、有料の Azure アカウントからトークンに切り替えることができます。 [Azure AI](https://aka.ms/azureai/github-models) のドキュメントを参照してください。

「[GitHub モデルの責任ある使用](https://docs.github.com/ja/github-models/responsible-use-of-github-models)」も参照してください。

## [AI モデルの検索](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#finding-ai-models)

AI モデルを検索するには:

1.  [github.com/marketplace/models](https://github.com/marketplace/models) に移動します。
    
2.  ページの左上にある **\[Model: Select a Model\]** をクリックします。
    
3.  ドロップダウン メニューからモデルを選択します。
    
    または、ドロップダウン メニューで **\[View all models\]** をクリックし、Marketplace でモデルをクリックしてから、**\[プレイグラウンド\]** をクリックします。
    

モデルがモデル プレイグラウンドに表示されます。 モデルの詳細が右側のサイドバーに表示されます。 サイドバーが表示されていない場合は、プレイグラウンドの右側にある アイコンをクリックしてサイドバーを展開します。

メモ

OpenAI の モデルは現在 パブリック プレビュー にあり、変更される可能性があります。

## [プレイグラウンドでの AI モデルの実験](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#experimenting-with-ai-models-in-the-playground)

AI モデル プレイグラウンドは無料のリソースです。 モデル パラメーターを調整し、プロンプトを送信してモデルがどのように応答するかを確認することができます。

メモ

-   モデル プレイグラウンドは パブリック プレビュー 段階であり、変更される可能性があります。
-   プレイグラウンドにはレート制限があります。 以下の「[レート制限](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#rate-limits)」を参照してください。

モデルのパラメーターを調整するには、プレイグラウンドのサイドバーにある **\[Parameters\]** タブを選びます。

選択したパラメーターに対応するコードを表示するには、 **\[チャット\]** タブから **\[コード\]** タブに切り替えます。

![プレイグラウンドの左上にある、濃いオレンジ色の枠線で強調表示されている [Code] タブ ボタンのスクリーンショット。](https://docs.github.com/assets/cb-23240/images/help/models/model-playground-code-tab.png)

### [モデルを比較する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#comparing-models)

プロンプトを 2 つのモデルに同時に送信し、応答を比較できます。

プレイグラウンドで 1 つのモデルを開いた状態で、**\[Compare\]** をクリックし、ドロップダウン メニューで比較対象のモデルを選びます。 選んだモデルが 2 つ目のチャット ウィンドウに表示されます。 いずれかのチャット ウィンドウにプロンプトを入力すると、そのプロンプトはもう一方のウィンドウにもミラーリングされます。 プロンプトは同時に送信されるので、各モデルからの応答を比較できます。

設定したパラメーターは両方のモデルに使われます。

## [AI モデルの評価](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#evaluating-ai-models)

プレイグラウンドでプロンプトのテストを始めたら、構造化されたメトリックを使ってモデルのパフォーマンスを評価できます。 評価は、異なるモデルについて複数のプロンプト構成を比較し、最適なセットアップを決定するのに役立ちます。

\[Comparisons\] ビューでは、類似性、関連性、グラウンデッドネスなどのエバリュエータを適用して、各出力が期待されることをどの程度満たしているかを測定できます。 カスタム プロンプト エバリュエータを使って独自の評価基準を定義することもできます。

詳細な手順については、「[出力の評価](https://docs.github.com/ja/github-models/use-github-models/evaluating-ai-models#evaluating-outputs)」をご覧ください。

## [API を使用した AI モデルの実験](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#experimenting-with-ai-models-using-the-api)

メモ

この無料 API の使用は パブリック プレビュー にあり、変更される可能性があります。

GitHub には無料の API 使用が用意されているため、独自のアプリケーションで AI モデルを実験できます。

各モデルを使用する手順は似ています。 一般的に、次のことを行う必要があります。

1.  [github.com/marketplace/models](https://github.com/marketplace/models) に移動します。
    
2.  ページの左上にある **\[Model: Select a Model\]** をクリックします。
    
3.  ドロップダウン メニューからモデルを選択します。
    
    または、ドロップダウン メニューで **\[View all models\]** をクリックし、Marketplace でモデルをクリックしてから、**\[ Playground\]** をクリックします。
    
    モデルがモデル プレイグラウンドに表示されます。
    
4.  **\[Code\]** タブをクリックします。
    
5.  必要に応じて、言語ドロップダウンを使用してプログラミング言語を選択します。
    
6.  必要に応じて、SDK ドロップダウンを使用して、使用する SDK を選択します。
    
    すべてのモデルを Azure AI 推論 SDK と共に使用でき、一部のモデルでは追加の SDK がサポートされています。 モデルを簡単に切り替えたい場合は、\[Azure AI 推論 SDK\] を選択する必要があります。 言語として \[REST\] を選択した場合、SDK は使用されません。 代わりに、API エンドポイントを直接使用します。 [GitHub Models の REST API](https://docs.github.com/ja/rest/models?apiVersion=2022-11-28) に関する記事をご覧ください。
    
7.  codespace を開くか、ローカル環境を設定します。
    
    -   codespace で実行するには、 **\[Run codespace\]** をクリックしてから **\[Create new codespace\]** をクリックします。
    -   ローカルで実行するには:
        -   GitHub personal access token を作成します。 トークンには アクセス許可が必要です。 「[個人用アクセス トークンを管理する](https://docs.github.com/ja/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens)」を参照してください。`models:read`
        -   トークンを環境変数として保存します。
        -   必要に応じて、SDK の依存関係をインストールします。
8.  サンプル コードを使用して、モデルに要求を行います。
    

無料の API の使用はレート制限されています。 以下の「[レート制限](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#rate-limits)」を参照してください。

## [プレイグラウンドでの実験を保存および共有する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#saving-and-sharing-your-playground-experiments)

プリセットを使って、プレイグラウンドでの進捗を保存および共有することができます。 プリセットには以下を保存できます。

-   現在の状態
-   パラメーター
-   チャット履歴 (省略可能)

現在のコンテキストのプリセットを作成するには、プレイグラウンドの右上で **\[Preset: PRESET-NAME\]** を選んでから、 **\[Create new preset\]** をクリックします。 プリセットに名前を付ける必要があります。また、プリセットの説明を入力したり、チャット履歴を含めたり、プリセットの共有を許可したりすることもできます。

プリセットを読み込むには、次の 2 つの方法があります。

-   **\[Preset: PRESET-NAME\]** ドロップダウン メニューを選んでから、読み込むプリセットをクリックします。
-   共有されたプリセットの URL を開きます

プリセットを読み込んだ後は、プリセットを編集、共有、または削除できます。

-   プリセットを編集するには、パラメーターを変更してモデルにプロンプトを送信します。 変更に問題がなければ、**\[Preset: PRESET-NAME\]** ドロップダウン メニューを選んでから、 **\[Edit preset\]** をクリックして更新を保存します。
-   プリセットを共有するには、**\[Preset: PRESET-NAME\]** ドロップダウン メニューを選んでから、 **\[Share preset\]** をクリックして共有可能な URL を取得します。
-   プリセットを削除するには、**\[Preset: PRESET-NAME\]** ドロップダウン メニューを選んでから、 **\[Delete preset\]** をクリックして削除を確認します。

## [プロンプト エディターの使用](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#using-the-prompt-editor)

GitHub Models のプロンプト エディターは、プロンプトを反復、調整、完成させるのに役立つように設計されています。 この専用ビューは、入力の作成とテストのための一元的で直感的なエクスペリエンスを提供する場であり、次のことを実行できます。

-   複数ターンにわたる複雑な操作を必要とせずに、プロンプトをすばやくテストして調整する。
-   プロンプトを微調整して、プロジェクトの精度と関連性を高める。
-   シングルターン シナリオに特化したスペースを使って、一貫性のある最適化された結果を確保する。

プロンプト エディターにアクセスするには、プレイグラウンドの右上にある **\[Prompt editor\]** をクリックします。

![プレイグラウンドの右上にある [Prompt editor] ボタンのスクリーンショット。濃いオレンジ色の枠線で強調表示されています。](https://docs.github.com/assets/cb-36677/images/help/models/model-playground-prompt-editor.png)

## [Visual Studio Code で AI モデルの実験を行う](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#visual-studio-code-%E3%81%A7-ai-%E3%83%A2%E3%83%87%E3%83%AB%E3%81%AE%E5%AE%9F%E9%A8%93%E3%82%92%E8%A1%8C%E3%81%86)

メモ

Visual Studio Code 用 AI ツールキット拡張機能は パブリック プレビュー 段階であり、変更される可能性があります。

IDE で AI モデルの実験を行いたい場合は、Visual Studio Code 用 AI ツールキット拡張機能をインストールした後、調整可能なパラメーターとコンテキストを使ってモデルをテストできます。

1.  Visual Studio Code で、[Visual Studio Code 用 AI ツールキット](https://marketplace.visualstudio.com/items?itemName=ms-windows-ai-studio.windows-ai-studio)のプレリリース バージョンをインストールします。
    
2.  拡張機能を開くには、アクティビティ バーの AI ツールキット アイコンをクリックします。
    
3.  AI ツールキットが GitHub アカウントに接続することを認可します。
    
4.  AI ツールキット パネルの \[My models\] セクションで、**\[Open Model Catalog\]** をクリックし、実験に使うモデルを見つけます。
    
    -   GitHub Models を通じてリモートでホストされるモデルを使うには、モデル カードの **\[Try in playground\]** をクリックします。
    -   モデルをダウンロードしてローカルで使うには、モデル カードの **\[Download\]** をクリックします。 ダウンロードが完了したら、同じモデル カードの **\[Load in playground\]** をクリックします。
5.  サイド バーで、モデルのコンテキスト命令と推論パラメーターを指定し、プロンプトを送信します。
    

## [運用環境への移行](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#going-to-production)

プレイグラウンドと無料 API の使用のレート制限は、モデルでの実験や AI アプリケーションの開発に役立ちます。 アプリケーションを運用環境に移行する準備ができたら、GitHub personal access token ではなく、有料の Azure アカウントのトークンを使用できます。 コードで他に変更する必要はありません。

詳細については、[Azure AI](https://aka.ms/azureai/github-models) のドキュメントを参照してください。

## [転送率の制限](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#rate-limits)

プレイグラウンドと無料の API の使用には、1 分あたりの要求数、1 日あたりの要求数、要求あたりのトークン数、同時要求数のレート制限があります。 レート制限を受けた場合、さらに要求を行うには、該当したレート制限がリセットされるまで待つ必要があります。

低、高、埋め込みモデルのレート制限は異なります。 使用しているモデルの種類を確認するには、GitHub Marketplace のモデルの情報を参照してください。

| **レート制限レベル** | **転送率の制限** | **Copilot Free** | **Copilot Pro** | **Copilot Business** | **Copilot Enterprise** |
| --- | --- | --- | --- | --- | --- |
| **低** | **1 分あたりの要求数** | 15 | 15 | 15 | 20 |
| **1 日あたりの要求数** | 150 | 150 | 300 | 450 |
| **要求あたりのトークン数** | 8000 入力、4000 出力 | 8000 入力、4000 出力 | 8000 入力、4000 出力 | 8000 入力、8000 出力 |
| **同時要求数** | 5 | 5 | 5 | 8 |
| **高** | **1 分あたりの要求数** | 10 | 10 | 10 | 15 |
| **1 日あたりの要求数** | 50 | 50 | 100 | 150 |
| **要求あたりのトークン数** | 8000 入力、4000 出力 | 8000 入力、4000 出力 | 8000 入力、4000 出力 | 16000 入力、8000 出力 |
| **同時要求数** | 2 | 2 | 2 | 4 |
| **埋め込み** | **1 分あたりの要求数** | 15 | 15 | 15 | 20 |
| **1 日あたりの要求数** | 150 | 150 | 300 | 450 |
| **要求あたりのトークン数** | 64000 | 64000 | 64000 | 64000 |
| **同時要求数** | 5 | 5 | 5 | 8 |
| **Azure OpenAI o1-preview** | **1 分あたりの要求数** | 適用なし | 1 | 2 | 2 |
| **1 日あたりの要求数** | 適用なし | 8 | 10 | 12 |
| **要求あたりのトークン数** | 適用なし | 4000 入力、4000 出力 | 4000 入力、4000 出力 | 4000 入力、8000 出力 |
| **同時要求数** | 適用なし | 1 | 1 | 1 |
| **Azure OpenAI o1 と o3** | **1 分あたりの要求数** | 適用なし | 1 | 2 | 2 |
| **1 日あたりの要求数** | 適用なし | 8 | 10 | 12 |
| **要求あたりのトークン数** | 適用なし | 4000 入力、4000 出力 | 4000 入力、4000 出力 | 4000 入力、8000 出力 |
| **同時要求数** | 適用なし | 1 | 1 | 1 |
| **Azure OpenAI o1-mini、o3-mini、o4-mini** | **1 分あたりの要求数** | 適用なし | 2 | 3 | 3 |
| **1 日あたりの要求数** | 適用なし | 12 | 15 | 20 |
| **要求あたりのトークン数** | 適用なし | 4000 入力、4000 出力 | 4000 入力、4000 出力 | 4000 入力、4000 出力 |
| **同時要求数** | 適用なし | 1 | 1 | 1 |
| **DeepSeek-R1、DeepSeek-R1-0528、MAI-DS-R1** | **1 分あたりの要求数** | 1 | 1 | 2 | 2 |
| **1 日あたりの要求数** | 8 | 8 | 10 | 12 |
| **要求あたりのトークン数** | 4000 入力、4000 出力 | 4000 入力、4000 出力 | 4000 入力、4000 出力 | 4000 入力、4000 出力 |
| **同時要求数** | 1 | 1 | 1 | 1 |
| **xAI Grok-3** | **1 分あたりの要求数** | 1 | 1 | 2 | 2 |
| **1 日あたりの要求数** | 15 | 15 | 20 | 30 |
| **要求あたりのトークン数** | 4000 入力、4000 出力 | 4000 入力、4000 出力 | 4000 入力、8000 出力 | 4000 入力、16000 出力 |
| **同時要求数** | 1 | 1 | 1 | 1 |
| **xAI Grok-3-Mini** | **1 分あたりの要求数** | 2 | 2 | 3 | 3 |
| **1 日あたりの要求数** | 30 | 30 | 40 | 50 |
| **要求あたりのトークン数** | 4000 入力、8000 出力 | 4000 入力、8000 出力 | 4000 入力、12000 出力 | 4000 入力、12000 出力 |
| **同時要求数** | 1 | 1 | 1 | 1 |

これらの制限は、予告なしに変更される場合があります。

## [フィードバックを行う](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#leaving-feedback)

質問やフィードバックの共有については、こちらの [GitHub Models に関するディスカッション投稿](https://github.com/orgs/community/discussions/159087)をご覧ください。  
他のユーザーが GitHub Models をどのように使っているかについては、[Models に関する GitHub コミュニティのディスカッション](https://github.com/orgs/community/discussions/categories/models)をご覧ください。