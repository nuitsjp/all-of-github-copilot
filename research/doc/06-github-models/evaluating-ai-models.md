GitHub Modelsのエバリュエーターとスコアリングメトリクスを使用して、AIモデルの出力をテストおよび比較します。

## [概要](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#overview)

GitHub Models は、開発者が GitHub プラットフォーム内で大規模言語モデル (LLM) を比較し、プロンプトを改良し、データドリブンな意思決定を行うのに役立つシンプルな評価ワークフローを提供します。GitHub Models を使用して、構造化された評価ツールを通じてパフォーマンス、精度、コストを分析することで、新機能を試したり、モデルの変更を検証したりできます。

## [GitHub Modelsのユースケース](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#use-cases-for-github-models)

モデルの動作は、プロンプト、入力、または構成によって大きく異なります。GitHub Models は、次のことを支援します。

-   現実的なユースケース全体で複数のLLMをテストおよび比較します。
-   プロンプトの言い回し、温度、およびその他のパラメーターを最適化します。
-   構造化された反復可能なメトリクスを使用してモデル出力を評価します。
-   AI開発を開発ワークフローに統合します。

## [シナリオ例](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#example-scenario)

サポート チケットを通じて送信された顧客フィードバックを要約する機能を構築しているシナリオを考えてみましょう。これらのサマリーは、内部レポートとチケットを生成するために使用されるため、出力は明確で、関連性があり、簡潔である必要があります。

次のことを行う必要があります。

-   さまざまなモデルを試し、構成を促します。
-   品質、一貫性、効率に基づいて、最もパフォーマンスの高い構成を評価します。
-   設定をリポジトリに保存して、再利用とコラボレーションを行います。

## [プレイグラウンドでの迅速なテスト](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#prompt-testing-in-the-playground)

GitHub Models でプロンプトを作成および管理する方法については、「[プレイグラウンドでのプロンプトのテスト](https://docs.github.com/ja/github-models/use-github-models/optimizing-your-ai-powered-app-with-github-models#testing-a-prompt-in-the-playground)」を参照してください。

プレイグラウンドでは、モデルを並べて比較したり、パラメータを調整したり、プロンプトのバリエーションをテストしたりできます。

この手順では、カスタマー サポート フィードバックの概要を生成するモデルを構成します。システム プロンプトを定義し、サンプル入力でテストし、出力が簡潔で関連性が高いことを確認するように調整します。

### [システム・プロンプトの定義](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#defining-the-system-prompt)

現在の目標に対するモデルの動作を定義します。この場合、目標は顧客のフィードバックを要約することです。**「パラメータ」**で、次のシステム・プロンプトを入力します。

```
You are a helpful assistant that summarizes support ticket responses into concise summaries.
```

残りの設定はデフォルトのままにします。

![システムプロンプトのスクリーンショット。システムプロンプト入力が強調表示されます。](https://docs.github.com/assets/cb-65099/images/help/models/github-models-system-prompt.png)

### [ユーザープロンプトの記述](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#writing-a-user-prompt)

モデルが設定されたので、次の顧客フィードバックを**プロンプト**ダイアログに入力します。

```
The app crashes every time I try to upload a PDF from my phone. It works on desktop but not on mobile.
```

このモデルでは、次のような応答が生成される場合があります。

```
The user experiences consistent app crashes when attempting to upload a PDF from their phone. Uploading PDFs works normally on desktop. They request an investigation into the issue.
```

### [入力変数の定義](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#defining-the-input-variable)

この時点で、構成は明確で簡潔な要約を生成します。**パラメーター**設定の下部にある \[**prompt.yml ファイルの作成**\] をクリックして \[プロンプト\] ビューを開きます。システムプロンプトは自動的に事前入力されます。

**\[ユーザープロンプト**\] フィールドに、次のプロンプトを入力します。

```text
Summarize the following: {{input}}
```

この変数は、プロンプトを毎回変更することなく、さまざまな入力 (顧客からのフィードバック) をテストできるプレースホルダーとして機能します。追加した各テスト入力は、比較の実行時に置き換えられます。`{{input}}``{{input}}`

## [テスト入力の追加](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#adding-test-inputs)

プロンプト ビューの上部にある **\[比較**\] を選択して、比較ビューを切り替えます。このビューでは、複数のプロンプトまたはモデル間で構造化された比較を実行し、エバリュエーターを適用してパフォーマンスを測定できます。

![比較トグルのスクリーンショット。比較トグルが強調表示されます。](https://docs.github.com/assets/cb-49388/images/help/models/github-models-compare-toggle.png)

「比較」ビューでは、テーブル内の各行は、特定の入力と予期される出力を持つ 1 つのテスト・ケースを表します。各列には、エバリュエーターを使用してさまざまなモデルまたはプロンプト スタイルのパフォーマンスを比較するための、異なるプロンプト構成が表示されます。

\[**行を追加**\] をクリックして、テストデータを入力します。入力は実際のサポート メッセージをシミュレートし、期待される出力はモデルが返す理想的な概要を表します。次の表に、サンプルのテスト入力とそれに対応する評価用の期待出力を示します。

| 漕ぐ | **インプット** | **期待される出力** |
| --- | --- | --- |
| 1 | 電話からPDFをアップロードしようとするたびにアプリがクラッシュします。デスクトップでは動作しますが、モバイルでは動作しません。 | ユーザーは、PDFをアップロードしようとするたびにモバイルアプリがクラッシュするが、デスクトップバージョンは問題なく動作すると報告しています。 |
| 2 | I contacted support two days ago and haven't heard back. I need help recovering my account ASAP. | User is awaiting support response and urgently needs account recovery assistance. |
| 3 | Please add dark mode. It's very hard to use at night. My eyes hurt after prolonged use. | User requests dark mode due to eye strain during nighttime use. |

### [Adjusting model parameters](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#adjusting-model-parameters)

To the right of the table, click to add a new prompt configuration.

Within the new prompt configuration, you can update the model and fine-tune its behavior using the available parameters settings. These settings control how the model generates text, including its length, randomness, and repetition.

### [Configuring the model](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#configuring-the-model)

From the Model dropdown, choose PHI-4 to create a distinct configuration for comparison.

You can adjust the following parameters to influence the model’s output:

-   **Max Tokens**: Sets the maximum number of tokens the model can return. Higher values allow longer outputs.
-   **Temperature**: Controls randomness in the response. Lower values (0.2–0.4) produce more focused, deterministic outputs. Higher values (0.8–1.0) introduce more variation and creativity.
-   **Top P**: Controls output diversity by selecting from a pool of the most probable next words. Lower values reduce variability, similar to lowering temperature.
-   **Presence Penalty**: Discourages the model from introducing new topics. Higher values apply a stronger penalty. A value of 0 is typically suitable for summarization.
-   **Frequency Penalty**: Reduces the likelihood of repeating words. Higher values apply a stronger penalty. A value between 0 and 0.5 helps keep summaries clear and free of redundancy.
-   **Stop**: Specifies one or more strings that, when generated, will cut off the model's response. Use this to prevent overly long outputs or enforce formatting rules.

The table below provides a parameter configuration for generating concise summaries during model comparison.

| Parameter | Value | Reason |
| --- | --- | --- |
| Max Tokens | 128 | Keeps responses short and on-topic |
| Temperature | 0.3 | Ensures deterministic, focused outputs |
| Top P | 1.0 | Allows full vocabulary but keeps selection guided |
| Presence Penalty | 0 | No penalty—summaries don’t need topic variation |
| Frequency Penalty | 0.3 | Reduces repeated phrasing in compact summaries |
| Stop | (optional) | Use if you want to end output after a keyword or symbol |

After applying the parameters, you can add additional columns to compare more models or prompt configurations side by side.

## [Evaluating outputs](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#evaluating-outputs)

Once the prompt is configured, run a structured evaluation to compare model outputs using real data and repeatable metrics.

Model evaluation helps you understand how different models and prompt configurations perform across real inputs. In the Prompt view, you can apply evaluators to multiple models side by side and review metrics such as similarity, relevance, and groundedness.

The following evaluators are available:

-   **Similarity**: Measures how closely a model's output matches an expected or reference answer. This is useful when you want to confirm that the model returns consistent and accurate responses aligned with a known result. The score ranges from 0 to 1, with higher values indicating greater similarity.
-   **Relevance**: Refers to how effectively a response addresses a question. It assesses the accuracy, completeness, and direct relevance of the response based solely on the given information. The score ranges from 0 to 1, with higher values indicating stronger alignment with the input's intent.
-   **Groundedness**: Measures how well an answer is anchored in the provided context, evaluating its relevance, accuracy, and completeness based exclusively on that context. It assesses the extent to which the answer fully addresses the question without introducing unrelated or incorrect information. The score ranges from 0 to 1, with higher values indicating higher accuracy.
-   **Custom prompt**: Lets you define your own evaluation criteria for one LLM to assess the output of another. This allows you to score model outputs based on your own guidelines. You can choose between pass/fail or scored evaluations, making it ideal for scenarios where standard metrics do not capture testing expectations.

When you’re ready to evaluate, click **Run** to generate and compare the outputs across all prompt configurations. After the run completes, GitHub Models displays the output from each prompt configuration, along with evaluator scores.

![Screenshot of the dataset after the evaluator has run.](https://docs.github.com/assets/cb-381635/images/help/models/github-models-datasets.png)

## [Test case: PDF upload crash](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#test-case-pdf-upload-crash)

**Input**: `The app crashes every time I try to upload a PDF from my phone. It works on desktop but not on mobile.`

The following tables display each model's output and its evaluator scores:

| Model | Output |
| --- | --- |
| GPT-4.1 | User reports that the app crashes when uploading a PDF from mobile, though uploading works on desktop. |
| DeepSeek-R1 | Okay, the user is having trouble with the app crashing when they try to upload a PDF from their phone. It works on the desktop but not mobile. Let me break this down. First, the main issue is the app crashing specifically during PDF uploads on mobile. The fact that it works on desktop suggests it's a mobile-specific problem. Possible causes could be related to the mobile app version, the phone's OS, file size limits on mobile, or compatibility issues with certain PDF formats on mobile devices. I need to make sure the summary mentions the crash during PDF uploads on mobile, note that desktop works, and |
| Phi-4 | The app crashes when attempting to upload a PDF from the mobile device, though it functions correctly on the desktop version. |

| Model | Similarity | Relevance | Groundedness | Input tokens | Output tokens | Latency |
| --- | --- | --- | --- | --- | --- | --- |
| GPT-4.1 | 100% | 50% | 100% | 61 | 20 | 918ms |
| DeepSeek-R1 | 50% | 50% | 75% | 52 | 128 | 2285ms |
| Phi-4 | 75% | 100% | 100% | 61 | 66 | 1117ms |

Use the evaluator scores to assess and compare responses beyond surface-level phrasing.

### [Similarity](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#similarity)

Evaluate how closely each model’s output aligns with the expected summary. The table below shows the relevance scores for each model.

| Model | Similarity score |
| --- | --- |
| GPT-4.1 | 100% |
| DeepSeek-R1 | 50% |
| Phi-4 | 75% |

While all models included the key content from the input, DeepSeek-R1’s similarity score is significantly lower due to its verbose internal commentary, which deviate from the expected concise summary format. In contrast, GPT-4.1’s response matches the phrasing and structure of the reference output.

### [Relevance](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#relevance)

Evaluate how well each model captures the core intent of the input. The table below shows the relevance scores for each model.

| Model | Relevance score |
| --- | --- |
| GPT-4.1 | 50% |
| DeepSeek-R1 | 50% |
| Phi-4 | 100% |

All three models recognized the key issue of the app crashing during PDF uploads on mobile. Phi-4 earned a higher relevance score for reflecting the user's perspective more completely. DeepSeek-R1 lost points for introducing speculative technical causes not mentioned in the original input.

### [Groundedness](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#groundedness)

Evaluate whether each model’s output stays true to the input without introducing unsupported information. The table below shows the relevance scores for each model.

| Model | Groundedness score |
| --- | --- |
| GPT-4.1 | 100% |
| DeepSeek-R1 | 75% |
| Phi-4 | 100% |

Even though DeepSeek-R1 adds internal commentary, it does not introduce hallucinated facts. Its final summary sentence correctly reflects the original input.

## [Test case: Dark mode request](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#test-case-dark-mode-request)

**Input**: `Please add dark mode. It's very hard to use at night. My eyes hurt after prolonged use.`

The following tables display each model's output and its evaluator scores:

| Model | Output |
| --- | --- |
| GPT-4.1 | User requests the addition of a dark mode feature due to discomfort and eye strain when using the app at night. |
| DeepSeek-R1 | Okay, the user wants dark mode added because it's hard to use at night and their eyes hurt. I need to make a concise summary. Let me start with the main request: adding dark mode. Then mention the reason: eye strain from prolonged use at night. Keep it to one sentence. Maybe structure it as "Request to implement dark mode to reduce eye strain during nighttime use." That covers the key points without extra details. Check if that's under the character limit. Yep, looks good. Summary: Request to implement dark mode to reduce eye strain caused by prolonged nighttime use. |
| Phi-4 | The customer is requesting the addition of a dark mode feature to reduce eye strain when using the product at night. |

| Model | Similarity | Relevance | Groundedness | Input Tokens | Output Tokens | Latency |
| --- | --- | --- | --- | --- | --- | --- |
| GPT-4.1 | 100% | 75% | 100% | 57 | 18 | 1286ms |
| DeepSeek-R1 | 50% | 0% | 25% | 49 | 128 | 1946ms |
| Phi-4 | 100% | 75% | 100% | 58 | 20 | 899ms |

### [Similarity](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#similarity)

Evaluate how closely each model’s output aligns with the expected summary. The table below shows the relevance scores for each model.

| Model | Similarity score |
| --- | --- |
| GPT-4.1 | 100% |
| DeepSeek-R1 | 50% |
| Phi-4 | 100% |

While all models included the key content from the input, DeepSeek-R1’s similarity score is again, significantly lower due to its verbose internal commentary.

### [Relevance](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#relevance)

Evaluate how well each model captures the core intent of the input. The table below shows the relevance scores for each model.

| Model | Relevance score |
| --- | --- |
| GPT-4.1 | 75% |
| DeepSeek-R1 | 0% |
| Phi-4 | 75% |

GPT-4.1 and Phi-4 both captured the main intent of the user’s request: the need for dark mode to reduce eye strain and improve usability at night. DeepSeek-R1 scored 0% in relevance due to its verbose internal commentary that distracted from the actual output.

### [Groundedness](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#groundedness)

Evaluate whether each model’s output stays true to the input without introducing unsupported information. The table below shows the relevance scores for each model.

| Model | Groundedness score |
| --- | --- |
| GPT-4.1 | 100% |
| DeepSeek-R1 | 25% |
| Phi-4 | 100% |

DeepSeek-R1 scored lower due to its verbose block, which included speculative reasoning not present in the original input.`<think>`

## [Save the configuration](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#save-the-configuration)

After completing your evaluations, the final step is to choose the model that performs best for your specific use case. In the examples above, Phi-4 and GPT-4.1 delivered strong, consistent results across all evaluators. DeepSeek-R1 scored lower due to its verbose reasoning and less focused outputs.

Once you've selected your preferred model and prompt configuration, add a descriptive name to the prompt file, then click **Commit changes**. This will save the model, prompt, parameter settings, and associated dataset as a reusable configuration file in your repository.

![Screenshot of the commit changes button. The commit changes button is highlighted.](https://docs.github.com/assets/cb-15683/images/help/models/github-models-commit-changes.png)

Committing your prompt configuration makes it easy to reuse, collaborate, and iterate across model setups. It makes it easier to rerun evaluations and track the performance of the prompt configuration over time.

## [Further reading](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#further-reading)

-   [Storing prompts in GitHub repositories](https://docs.github.com/ja/github-models/use-github-models/storing-prompts-in-github-repositories)
-   [AI モデルを開発ワークフローに統合する](https://docs.github.com/ja/github-models/use-github-models/integrating-ai-models-into-your-development-workflow)