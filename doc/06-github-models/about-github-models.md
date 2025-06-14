GitHub Models は、モデル カタログ、迅速な管理、定量的評価など、AI のアイデアからリリースまでの一連の開発者ツールです。

メモ

Organization とリポジトリの GitHub モデルはパブリック プレビュー段階であり、変更される可能性があります。

## [概要](https://docs.github.com/ja/github-models#overview)

GitHub Models は、エンタープライズ レベルの AI 導入の障壁を下げるワークスペースです。これは、AI 開発を使い慣れた GitHub ワークフローに直接埋め込むことで、孤立した実験から脱却するのに役立ちます。GitHub Models は、大規模言語モデル (LLM) のテスト、プロンプトの調整、出力の評価、構造化されたメトリックに基づく情報に基づいた意思決定を行うためのツールを提供します。開始するには、「[モデルを使用した AI 搭載アプリの最適化](https://docs.github.com/ja/github-models/use-github-models/optimizing-your-ai-powered-app-with-github-models)」を参照してください。

## [資格](https://docs.github.com/ja/github-models#capabilities)

GitHub Models は、AI 開発の迅速なイテレーション、評価、統合をサポートする一連の機能を提供します。

-   **迅速な開発**: システム命令、テスト入力、変数構成をサポートする構造化されたエディターで、AI 開発を直接開始します。
-   **モデルの比較**: 複数のモデルを同じプロンプトと入力で並べてテストし、異なる出力で実験します。
-   **評価者**: 類似性、関連性、根拠性などのスコアリング メトリックを使用して、出力を分析し、パフォーマンスを追跡します。
-   **プロンプト設定**: プロンプト、モデル、およびパラメータの設定をファイルとしてリポジトリに保存します。これにより、レビュー、コラボレーション、再現性が可能になります。`.prompt.yml`
-   **本番環境の統合**: 保存した設定を使用して、AI 機能を構築したり、SDK や [GitHub Models REST API](https://docs.github.com/ja/rest/models?apiVersion=2022-11-28) を介して接続したりします。

## [GitHub モデルの有効化](https://docs.github.com/ja/github-models#enabling-github-models)

GitHub Models の使用を開始するには、役割とニーズに応じていくつかの方法があります。

GitHub Models API を使用するには、「[API を使用した AI モデルの実験](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#experimenting-with-ai-models-using-the-api)」を参照してください。

### [個人の方へ](https://docs.github.com/ja/github-models#for-individuals)

GitHub モデルを使用するには、新しい GitHub リポジトリを作成するか、既存のリポジトリを開きます。リポジトリ設定で、サイドバーの **\[モデル**\] をクリックし、機能を有効にします。

### [組織およびエンタープライズ向け](https://docs.github.com/ja/github-models#for-organizations-and-enterprises)

Organization で GitHub Models を使用するには、まず Enterprise のオーナーが機能を有効にする必要があります。その後、組織の所有者は、許可されるモデルを構成できます。

See [チームのモデル使用状況の管理](https://docs.github.com/ja/github-models/github-models-at-scale/manage-models-at-scale).

## [プロンプト](https://docs.github.com/ja/github-models#prompts)

リポジトリに格納されているプロンプト構成を管理します。各プロンプトは、モデル、パラメーター、およびテスト入力を定義するファイルとして保存されます。ここから、実験や運用環境での使用をサポートするプロンプトを作成、編集、整理できます。`.prompt.yml`

## [比較](https://docs.github.com/ja/github-models#comparisons)

比較ビューを使用して、一貫性のあるテスト駆動型ワークフローで複数のプロンプト設定の出力を評価します。入力データの行全体でテストを実行し、各構成のエバリュエーター スコア (類似性、関連性、接地性など) を表示します。このビューは、プロンプトの調整、変更の検証、および回帰の回避に最適です。

## [遊び場](https://docs.github.com/ja/github-models#playground)

プレイグラウンドを使用して、モデルをすばやく探索し、プロンプトのアイデアをリアルタイムでテストします。Playground は、モデルの動作、機能、応答スタイルを理解するのに役立つ、初期の実験に最適です。モデルを対話形式で選択し、パラメーターを調整し、応答を並べて比較できます。

質問をしたり、フィードバックを共有したりするには、この [GitHub Models ディスカッション投稿](https://github.com/orgs/community/discussions/159087)を参照してください。  
他のユーザーが GitHub モデルをどのように使用しているかについては、[モデルの GitHub コミュニティ ディスカッション](https://github.com/orgs/community/discussions/categories/models)にアクセスしてください。

## [参考資料](https://docs.github.com/ja/github-models#further-reading)

-   [AI モデルを使用したプロトタイプ作成](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models)
-   [モデルによる AI 搭載アプリの最適化](https://docs.github.com/ja/github-models/use-github-models/optimizing-your-ai-powered-app-with-github-models)
-   [AIモデルの評価](https://docs.github.com/ja/github-models/use-github-models/evaluating-ai-models)