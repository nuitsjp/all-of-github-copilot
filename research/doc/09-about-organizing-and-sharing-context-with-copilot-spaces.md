# Copilot Spaces を使用したコンテキストの整理と共有について - GitHub Docs

# Copilot Spaces を使用したコンテキストの整理と共有について

Copilot Spaces を使ってコンテキストを収集すると、結果をどのように向上させて、チームメイトを支援できるかについて説明します。

## この機能を使用できるユーザーについて

Anyone with a Copilot license can use スペース.

## この記事の内容

メモ

Copilot Spaces は パブリック プレビュー 段階であり、変更される可能性があります。

Copilot Spaces を使うと、Copilot がユーザーの質問に答えるために使うコンテキストを整理できます。 リポジトリからのコード、音声テキストやメモなどの自由形式のテキスト コンテンツ、その他を スペース に格納して、1 か所にまとめることができます。 そのコンテキストでグラウンディングされた質問を Copilot にしたり、スペースをチームと共有してコラボレーションと知識の共有をサポートしたりできます。

## [Copilot Spaces を使用する理由](#copilot-spaces-を使用する理由)

1 人の作業でもチームの共同作業でも、スペース を使うと Copilot をいっそう便利にできます。

Copilot Spaces を使うと、次のことができます。

-   Copilot から、より関連性の高い具体的な応答を得ます。
-   タスクに必要なものを 1 か所で集めることで、フローに留まります。
-   知識をチームと共有して、質問の繰り返しを減らします。
-   チャット履歴の外部でも有効なセルフサービスのコンテキストにより、オンボードと再利用をサポートします。

### [スペース とナレッジ ベースの相違点](#スペース-とナレッジ-ベースの相違点)

スペース は、特定のタスクとグラウンディングされた会話用に最適化されています。 スペース のコンテキストにはスコープがあるため、Copilot の応答の正確さと関連性がいっそう高くなります。

Copilot Spaces

ナレッジ ベース

作成できるユーザー

Copilot ライセンスを持つすべてのユーザー

組織所有者

所有元

Organization または個々のユーザー

組織

コンテンツ タイプ

リポジトリでホストされているコードと自由形式のテキスト コンテンツ

GitHub

でホストされている Markdown ファイル

コンテキストの処理

サイズが制限されているため、選択が絞り込まれていると、より高い応答品質が保証されます

無制限ですが、そのために応答の品質が低下します

## [スペース を使用できるユーザー](#スペース-を使用できるユーザー)

Copilot のライセンス (Copilot Free を含む) を持つすべてのユーザーは、スペース を作成して使用できます。

Copilot Business または Copilot Enterprise プランをお使いの場合、パブリック プレビュー の期間中は、プランを提供する organization または Enterprise で **\[Opt in to preview features\]** の設定が有効にされている必要があります。 「[organization 内での Copilot のポリシーの管理](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#enabling-copilot-features-in-your-organization)」または「[企業内の Copilot のポリシーと機能を管理する](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#copilot-in-githubcom)」を参照してください。

スペース は、個人用アカウントまたは organization のどちらに属していてもかまいません。 Organization が所有するスペースは、他の organization メンバーと共有することも (読み取り専用)、スペースを作成したユーザーにプライベートにすることもできます。

スペースで送信する質問は、Copilot Chat 要求としてカウントされます。

-   Copilot Free ユーザーの場合、この使用量は毎月のチャット制限にカウントされます。
-   Premium モデルで スペース をお使いの場合、この使用量は Premium 使用量クォータにカウントされます。

## [次のステップ](#next-steps)

スペース を使い始めるには、「[Copilot Spaces の作成と使用](/ja/copilot/using-github-copilot/copilot-spaces/creating-and-using-copilot-spaces)」をご覧ください。