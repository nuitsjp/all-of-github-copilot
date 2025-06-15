# Copilot テキスト入力候補の使用 - GitHub Enterprise Cloud Docs

# Copilot テキスト入力候補の使用

Copilot テキスト入力候補 を使用し、pull request の説明をよりすばやくかつ正確に記述できるようにします。

## この機能を使用できるユーザーについて

Members of an enterprise with a subscription to [GitHub Copilot Enterprise](/ja/enterprise-cloud@latest/copilot/github-copilot-enterprise/overview/about-github-copilot-enterprise)

## この記事の内容

メモ

Copilot テキスト入力候補 は パブリック プレビュー段階であり、変更される可能性があります。 パブリック プレビュー 段階に参加するには、企業の管理者が Copilot 機能のプレビューの使用をオプトインする必要があります。 「[企業内の Copilot のポリシーと機能を管理する](/ja/enterprise-cloud@latest/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise#copilot-in-githubcom)」を参照してください。

## [Copilot テキスト入力候補 について](#copilot-テキスト入力候補-について)

Copilot テキスト入力候補 を使用すると、AI 生成されたオートコンプリートを使用し、pull request の説明をすばやくかつ正確に記述できるようになります。 正確な説明は、レビュー担当者がユーザーの提案する変更を理解できるようにし、pull request の目的をより効果的に伝えるようにします。

新しい pull request を作成すると、Copilot テキスト入力候補 は pull request をスキャンし、pull request のコンテキストに基づいて記述中に提案します。

## [Copilot テキスト入力候補 の使用](#copilot-テキスト入力候補-の使用)

作成する新しい pull request の説明に Copilot テキスト入力候補 を使用できます。

1.  GitHub で、pull request を作成します。
2.  説明フィールドに説明を入力しください。
3.  入力すると、Copilot は pull request のコンテキストに基づいてインライン提案を提供します。
4.  灰色で表示される提案を確認します。
    -   候補を受け入れるには、`Tab` キーを押します。
    -   提案を無視するには、`Esc` を押すか、入力を続けます。 Copilot は追加コンテキストに基づいて、入力時に新しい提案をします。
5.  説明に問題がなければ、**\[pull request の作成\]** クリックします。

## [Copilot テキスト入力候補 の有効化または無効化](#copilot-テキスト入力候補-の有効化または無効化)

pull request の説明に対して Copilot テキスト入力候補 を無効または有効にすることができます。 ユーザー設定は今後の pull request 用に保存されます。

1.  GitHub で、pull request を作成します。
2.  説明フィールドの上部にある を選び、**\[Autocomplete (パブリック プレビュー)\]** にマウス ポインターを移動して、**\[Disabled\]** または **\[Enabled\]** をクリックします。