# GitHub Copilot in GitHub Desktop の責任ある使用 - GitHub Docs

# GitHub Copilot in GitHub Desktop の責任ある使用

GitHub Desktop での Copilot の目的、機能、制限を理解し、それを責任を持って使用する方法を学習します。

## この機能を使用できるユーザーについて

GitHub Copilot Business または GitHub Copilot Enterprise サブスクリプションを持つ organization または Enterprise の所有者は、organization または Enterprise 内のユーザーに対して GitHub Desktop での Copilot へのアクセスを許可するかどうかを決定できます。  
  
GitHub Copilot Free または GitHub Copilot Pro サブスクリプションがある場合は、GitHub Desktop での Copilot にアクセスできるようになりました。

## この記事の内容

## [GitHub Desktop での Copilot について](#github-desktop-での-copilot-について)

Copilot の AI 搭載機能であるコミット メッセージ生成を使うと、ユーザーは GitHub Desktop でコミットすることを選んだ変更に基づいて、コミット メッセージの要約 (タイトル) と説明を作成できます。

ユーザーが特定のコード行を選ぶと、Copilot はコードの変更をスキャンし、散文で行われた変更の要約 (タイトル) と説明の提案を提供します。 コミットを終了して手動でブランチにプッシュする前に、提案を確認、編集、または再生成できます。

GitHub Desktop での Copilot 生成コミット メッセージでサポートされている言語は英語のみです。

Copilot のコミット メッセージ生成では、Copilot API を活用する簡単なプロンプト フローが使われ、汎用の大規模言語モデルが利用されて、他のトレーニング済みモデルは使われません。

コパイロット ボタンをクリックすると、Copilot API の呼び出しが行われて、要約と説明のボックスに挿入する候補テキストが生成されます。 テキスト入力候補の要求では、リポジトリのさまざまなファイルで選択された変更からの情報が、それらの変更を正確に説明するコミット メッセージの提案を生成するよう Copilot に要求するプロンプト含まれます。 その後、応答を使って、要約と説明のボックスが設定されます。 ユーザーは、提案されたメッセージを確認し、必要に応じて編集し、それを使ってコミットを行うことができます。

## [GitHub Desktop での Copilot のユース ケース](#github-desktop-での-copilot-のユース-ケース)

GitHub Desktop での Copilot の目的は、作成者が時間を節約し、変更を要約するときに明確なコミット履歴を維持できるように、作成者ワークフローを合理化することです。 多くのユーザーにとって、これは大規模な変更をコミットするときの時間の節約に役立ちます。 作成者は、コミットを終了して手動でブランチにプッシュする前に、提案を確認、編集、または再生成できます。 また、コンテキストの理解を向上させて正確さを高めるため、特定のコード行またはファイルを選ぶこともできます。 この機能は、より円滑なエクスペリエンスのため、コミット ワークフローにシームレスに統合されます。

## [GitHub Desktop での Copilot の改善](#github-desktop-での-copilot-の改善)

GitHub Desktop での Copilot のエクスペリエンスを向上させ、いくつかの制限に対処するため、さまざまな方法を利用できます。 制限の詳細については、「[GitHub Desktop での Copilot の制限](#limitations-of-copilot-in-github-desktop)」を参照してください。

### [GitHub Desktop での GitHub Copilot は置き換えではなくツールとして使う](#github-desktop-での-github-copilot-は置き換えではなくツールとして使う)

この機能の目的は、コミット メッセージを下書きする人間の作業を置き換えるのではなく、補助することです。 コミット メッセージの提案の品質は、コードの変更の品質と、変更されたファイルでのコンテキストに依存します。 コンテキストがいっそう正しく理解され、正確さが向上するよう、特定のコード行の変更やファイルを選ぶことをお勧めします。 ユーザーは、自分が作成するコミットの情報が正確であることを確認して評価する必要があります。

### [フィードバックを提供する](#provide-feedback)

GitHub Desktop での Copilot で問題や制限が発生した場合は、[GitHub Desktop オープンソース リポジトリ](https://github.com/desktop/desktop/issues/new?template=bug_report.yaml)で問題を作成して、フィードバックを提供できます。 これは、開発者がツールを改善し、懸念事項や制限事項に対処するのに役立ちます。

## [GitHub Desktop での Copilot の制限](#github-desktop-での-copilot-の制限)

オペレーティング システムや入力データなどの要因によっては、GitHub Desktop での Copilot の使用時の正確性が異なる場合があります。 次の情報は、GitHub Desktop での Copilot に適用されるシステム制限とパフォーマンスに関する主な概念を理解するのに役立ちます。

### [制限付きのスコープ](#limited-scope)

GitHub Desktop での Copilot は定義された境界内で動作し、複雑なコードの変更、短い差分ウィンドウ、または最近開発されたプログラミング言語にはうまく対処できない可能性があります。 提供される提案の品質は、トレーニング データの利用可能性と多様性に影響される可能性があります。 たとえば、Python のような十分に文書化された言語に関する問い合わせでは、あまり使われない言語に関する質問と比べて、より正確な応答が得られる場合があります。

### [不正確な応答](#inaccurate-responses)

Copilot が学習できる入力とコンテキストが多いほど、出力は向上します。 ただし、この機能はまだ新しいため、生成される概要が正確な精度に到達するには時間がかかります。 一方で、生成された概要があまり正確ではない場合には、この説明が含まれた pull request を保存して公開する前にユーザーが変更を加える必要があります。 さらに、Copilot が不正確なステートメントを生成する "幻覚" のリスクもあります。 これらの理由から、見直しは必須であり、出力の見直しを慎重に行うことを Microsoft チームとして強くお勧めします。

### [概要の再生成](#regenerating-summaries)

コミット メッセージは、ユーザーがそれを手動で要求した場合にのみ作成されます。 ユーザーがリポジトリに更新または変更を送信しても、コミットの要約と説明は自動的には更新されません。 ユーザーは必要に応じて、Copilot に新しい要約の生成を依頼できます。 更新された Copilot のメッセージを人手でレビューすることを強くお勧めします。 更新されたメッセージには、元のメッセージと同じ不正確さのリスクが伴います。

### [pull request コンテンツのレプリケーション](#replication-of-pull-request-content)

コミット メッセージはリポジトリで行われた変更の要約であるため、変更の内容に有害または不快な用語が存在する場合は、要約にもそれが含まれる可能性があります。

### [潜在的なバイアスとエラー](#potential-biases-and-errors)

GitHub Desktop での GitHub Copilot のトレーニング データは、既存のオンライン ソースから取得されています。 これらのソースには、トレーニング データに貢献した人物それぞれのバイアスとエラーが含まれている可能性があることに注意してください。 GitHub Desktop での Copilot は、これらのバイアスやエラーを誤ってそのままにしてしまう可能性があります。

## [参考資料](#further-reading)

-   [追加の製品および機能に適用される GitHub 条件](/ja/site-policy/github-terms/github-terms-for-additional-products-and-features#github-copilot)
-   [GitHub Copilot トラスト センター](https://copilot.github.trust.page/)