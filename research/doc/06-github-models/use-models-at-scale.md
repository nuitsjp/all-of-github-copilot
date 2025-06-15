Enterprise 内の AI 開発を効率化します。

## この機能を使用できるユーザーについて

Organization の所有者と Enterprise の所有者

メモ

Organization とリポジトリの GitHub モデルはパブリック プレビュー段階であり、変更される可能性があります。

GitHub Models を使うと、Enterprise は制御、コンプライアンス、コスト効率を維持しながら、開発者が AI を利用したアプリケーションを大規模に構築できるようになります。

## [GitHub Models を選ぶ理由](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#github-models-%E3%82%92%E9%81%B8%E3%81%B6%E7%90%86%E7%94%B1)

-   **一元的なモデル管理:** Organization 全体の開発者が使用できる AI モデルとプロバイダーを制御します。
-   **AI 開発を高速化:** プロンプトとモデルのプロトタイプ作成、評価、最適化を迅速に行えます。
-   **ガバナンスとコンプライアンスの管理:** Organization の標準を適用し、モデルの使用状況を監視します。
-   **コスト最適化:** 高価なモデルによる予期しないコストを回避します。
-   **コラボレーション:** 標準の GitHub 開発プラクティスを使って、プロンプトと結果を共有します。
-   **セキュリティ重視のアーキテクチャ:** データは GitHub と Azure 内に保持され、モデル プロバイダーと共有されないので安心です。
-   **ビジュアル インターフェイス:** 技術者以外のチーム メンバーも、開発者と一緒に貢献できます。
-   **API アクセス:** GitHub Models REST API を使って、Enterprise ワークフローの自動化と統合を実現します。
-   **バージョン管理:** すべてのプロンプトとモデルの変更は標準の GitHub コミットおよび pull request フローを経由するため、プロンプトがいつ、なぜ変更されたかを把握できます。

「[About GitHub Models](https://docs.github.com/ja/github-models/about-github-models)」を参照してください。

## [GitHub Models を大規模に使うためのベスト プラクティス](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#github-models-%E3%82%92%E5%A4%A7%E8%A6%8F%E6%A8%A1%E3%81%AB%E4%BD%BF%E3%81%86%E3%81%9F%E3%82%81%E3%81%AE%E3%83%99%E3%82%B9%E3%83%88-%E3%83%97%E3%83%A9%E3%82%AF%E3%83%86%E3%82%A3%E3%82%B9)

### [ガバナンスとコンプライアンスの観点から AI モデルを比較および評価する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#compare-and-evaluate-ai-models-for-governance-and-compliance)

使用できる AI モデルを、会社のガバナンス、データ セキュリティ、コンプライアンスの要件に照らしてレビューおよび比較します。 これは、モデル対応の GitHub リポジトリ、または GitHub Marketplace ([https://github.com/marketplace?type=models](https://github.com/marketplace?type=models)) の GitHub Models カタログで行うことができます。 次のような考慮事項があります。

-   **ガバナンスとセキュリティ:** 各モデルが GDPR、SOC 2、ISO 27001 などの標準と規制に準拠しているかどうかを検査し、同意を得て明示的にログされない限り、データが organization の外部に保持されないようにします。
-   **モデルのパフォーマンス:** 内部データセットでベンチマーク評価を実行し、推論、コンテキスト保持、ハルシネーション率を評価します。
-   **API 制御と可視性:** チームまたは organization レベルで、使用量のクォータ、プロンプトの検査、レート制限をきめ細かく制御する必要があります。
-   **コストの最適化:** トークンの価格、推論速度、階層化使用のためのモデル バリアントの可用性が含まれます。 たとえば、アーキテクチャの議論には高度なモデルを使うのに対し、テスト ケースの生成にはより安価なモデルを使用できます。

使うモデルを決定したら、organization 内のアクセスをそれらのモデルのみに制限できます。 「[チームのモデル使用状況の管理](https://docs.github.com/ja/github-models/github-models-at-scale/manage-models-at-scale)」を参照してください。

開発者は、GitHub Models のプロンプト エディターを使って、プロンプトを作成および調整できます。 チームは、GitHub 開発ワークフローと統合された、安定した非運用環境で、さまざまなプロンプトのバリエーションとモデルを試すことができます。 ビジュアル インターフェイスにより、技術者以外の関係者も、開発者と一緒に貢献できます。 「[プロンプト エディターの使用](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#using-the-prompt-editor)」を参照してください。

軽量な評価ツールを使うと、チームは待機時間、関連性、根拠などの一般的なメトリック間で結果を比較したり、カスタム エバリュエータを作成したりできます。 コード、テスト、ドキュメント、コード レビューの提案の作成など、特定の生成 AI ユース ケースについてプロンプトとモデルのパフォーマンスを比較します。

チームが効果的なプロンプトを作成したら、それを YAML ファイルとして保存し、GitHub pull request を使ってレビューのために共有できます。 コミットされたプロンプトは他のチームやワークフローからアクセスでき、会社の標準と一貫性を保つことができます。 プロンプト管理に対するこの一元化された共同作業アプローチにより開発が加速され、organization 全体でベスト プラクティスを適用するのに役立ちます。

### [モデルの使用コストを評価して最適化する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#evaluate-and-optimize-model-usage-costs)

AI を利用したアプリケーションの導入が拡大し、AI モデルが改善されるにつれて、GitHub Models を使って、さまざまなモデルおよびモデル更新のコストとパフォーマンスを評価します。 Organization のニーズに最もコスト効率の高いオプションを選び、複数のチームにわたり使用量の拡大に応じて経費を管理します。

### [プログラムによる管理に GitHub Models REST API または拡張機能を使う](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%A0%E3%81%AB%E3%82%88%E3%82%8B%E7%AE%A1%E7%90%86%E3%81%AB-github-models-rest-api-%E3%81%BE%E3%81%9F%E3%81%AF%E6%8B%A1%E5%BC%B5%E6%A9%9F%E8%83%BD%E3%82%92%E4%BD%BF%E3%81%86)

すべてのチームのリソースをより効率的に管理するために、GitHub Models REST API を利用して次のことができます。

-   **Organization 設定の管理と更新:** 整合性とコンプライアンスを確保するために、モデルのアクセス許可とガバナンス設定をプログラムで複数のチームにわたって一度に更新します。
-   **プロンプトの一覧表示と取得:** さまざまなチームで使われているプロンプトの一覧表示、取得、監査を行い、使用状況を監視し、成功したプロンプトを共有し、ベスト プラクティスの中央リポジトリを維持します。
-   **モデル推論要求の実行:** 頻度ペナルティ、最大トークン、応答形式、プレゼンス ペナルティなどの特定のモデルとパラメーターの推論要求を実行します。

これらの拡張機能を使って推論要求を実行し、プロンプトを管理することもできます。

-   GitHub CLI 用の GitHub Models 拡張機能
-   Github Kapilに設定 用の Github Models 拡張機能
-   GitHub Models VS Code 拡張機能

### [監視、反復処理、統合](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#monitor-iterate-and-integrate)

組み込みのガバナンス機能を使うと、モデルの使用状況を監視し、会社のポリシーに継続的に準拠することができます。 監査ログにより、モデルやプロンプトにアクセスまたは変更したユーザーを確認できます。 GitHub Models リポジトリの統合により、すべての関係者が AI を利用したアプリケーションで共同作業を行い、継続的に反復処理を行うことができます。

## [例: GitHub Models と GitHub Actions を使って issue を要約する](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#%E4%BE%8B-github-models-%E3%81%A8-github-actions-%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%A6-issue-%E3%82%92%E8%A6%81%E7%B4%84%E3%81%99%E3%82%8B)

大規模なソフトウェア開発プロジェクトでは、技術的な詳細が詰まった issue を抱えていることがよくあります。 GitHub Models と GitHub Actions を使って、AI を利用した issue の概要をロールアウトできます。

**前提条件:** Organization 内で GitHub Models を有効にし、個々のリポジトリで使用できるようにするモデルと公開元を設定します。

1.  **リポジトリにプロンプトを作成する**
    
    リポジトリの \[Models\] タブで、プロンプト エディターを使ってプロンプトを作成します。
    
    システム プロンプトの例:
    
    > あなたは GitHub の issue を要約する人です。 重要な技術的なポイントや重要な質問を強調してください。
    
    ユーザー プロンプトの例:
    
    > この issue を要約してください - {{input}}
    
2.  **プロンプトで実行して反復処理する**
    
    プロンプトを実行します。 \[Variables\] ペインに、 の値としてサンプルの issue コンテンツをいくつか入力します。`{{input}}`
    
    さまざまなモデル (OpenAI GPT-4o など) を試して、結果を比較します。 最大トークン数や温度などのパラメーターを調整します。 結果に満足するまで繰り返します。
    
3.  **必要に応じて、より広範なテストを実行する**
    
    \[Compare\] ビューでは、複数のプロンプトを異なるモデルに対して同時に実行し、グリッド ビューで結果を比較できます。 また、エバリュエータを定義して使い、結果に特定のキーワードが含まれているか、その他の基準を満たしているかを確認することもできます。
    
4.  **プロンプトをコミットする**
    
    プロンプトに名前を付け、変更をコミットして pull request フローに進みます。 たとえば、プロンプトに という名前を付けると、リポジトリのルート レベルに次のような ファイルが作成されます。`summarize``summarize.prompt.yaml`
    
    ```yaml
    messages: - role: system content: >- You are a summarizer of GitHub issues. Emphasize key technical points or important questions. - role: user content: 'Summarize this issue, please - {{input}}' model: gpt-4o modelParameters: max_tokens: 4096
    ```
    
    Pull request がレビューされ、マージされると、リポジトリ内の誰でもプロンプトを使用できるようになります。
    
5.  **ワークフローでプロンプトを呼び出す**
    
    ワークフローの作成の詳細については、「[ワークフローの書き込み](https://docs.github.com/ja/actions/writing-workflows)」を参照してください。
    
    ワークフローでプロンプトを呼び出すには、 アクセス許可を設定する必要があります。`models: read`
    
    以下は、新しく作成された issue に AI によって生成された概要をコメントとして追加するワークフローの例です。
    
    YAML
    
    ```yaml
    name: Summarize New Issue on: issues: types: [opened] permissions: issues: write contents: read models: read jobs: summarize_issue: runs-on: ubuntu-latest steps: - name: Checkout repository uses: actions/checkout@v4 - name: Install gh-models extension run: gh extension install https://github.com/github/gh-models env: GH_TOKEN: ${{ github.token }} - name: Create issue body file run: | cat > issue_body.txt << 'EOT' ${{ github.event.issue.body }} EOT - name: Summarize new issue run: | cat issue_body.txt | gh models run --file summarize.prompt.yml > summary.txt env: GH_TOKEN: ${{ github.token }} - name: Update issue with summary run: | SUMMARY=$(cat summary.txt) gh issue comment ${{ github.event.issue.number }} --body "### Issue Summary ${SUMMARY}" env: GH_TOKEN: ${{ github.token }}
    ```
    
6.  **監視と反復処理**
    
    GitHub Models プロンプト エディターを使って、アクションのパフォーマンスを監視し、プロンプトとモデルの選択を反復処理できます。 また、[CLI 拡張機能](https://github.com/github/gh-models)を使ってローカルでテストしたり、[GitHub Models REST API](https://docs.github.com/ja/rest/models?apiVersion=2022-11-28) を使ってプロンプトとモデルの設定をプログラムで更新したりすることもできます。
    
    また、モデルの応答をリポジトリ内のファイルとして保存して、時間の経過と共にモデルのパフォーマンスをレビューして反復処理することも検討してください。 これにより、要約の品質を継続的に向上させ、チームのニーズを満たすことができます。