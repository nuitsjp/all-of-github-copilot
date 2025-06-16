AI を活用したアプリケーションのモデルをテストし、プロンプトを調整する方法について説明します。

新しい AI モデルが定期的にリリースされるため、アプリケーションに適したモデルを選択するのは難しい場合があります。GitHub Models は、**組み込みのエバリュエーター**を使用してモデル出力を検証しながら、**さまざまなモデルとプロンプトのバリエーションを**サンプル入力と比較できるようにすることで、AI を活用したアプリケーションを最適化するのに役立ちます。

サンプル シナリオを通じて、ユーザーがコマンド ラインから Git の使用方法を学習するのに役立つ AI 搭載のアシスタントを構築します。さまざまなモデルを比較し、プロンプトのバリエーションを調整して出力品質を向上させる方法を学習します。

メモ

-   GitHub Models はパブリック プレビュー段階であり、変更される場合があります。
-   Usage is rate limited. See [AI モデルを使用したプロトタイプ作成](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#rate-limits).

## [プロンプトのテスト](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#testing-a-prompt)

GitHub モデル**比較**ビューでは、モデルのパラメーターとプロンプトを調整して、モデルの出力をテストできます。

### [1\. サンプルリポジトリの作成](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#1-creating-a-sample-repository)

**\[比較\]** ビューには、どのリポジトリの \[**モデル**\] タブから直接アクセスできますが、このガイドでは、テスト環境として使用する新しいリポジトリを作成します。

1.  [新しいリポジトリ](https://github.com/new) ページに移動します。
2.  \[オーナー\] で、ユーザ アカウントが選択されていることを確認します。
3.  \[リポジトリ名\] フィールドに「.`models-playground`
4.  説明フィールドの下で、 \[**プライベート**\] を選択してリポジトリの可視性を設定します。
5.  **\[リポジトリの作成**\] をクリックします。

### [2\. 新しいプロンプトの作成](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#2-creating-a-new-prompt)

1.  新しいリポジトリのメインページで、 **\[モデル**\] タブをクリックします。
2.  \[プロンプト\] セクションで、**新しいプロンプト**.
3.  左上隅で、ドロップダウンメニューからモデルを選択します。

### [3\. システムプロンプトの書き方](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#3-writing-a-system-prompt)

システムプロンプトは、AIモデルがユーザーと対話する前に、AIモデルの役割、動作、および制限を定義する一連の命令です。この例では、コマンドラインからGitを使用する方法を説明するAI搭載のアプリケーションに取り組んでいます。

**\[システムプロンプト**\]フィールドに、次のテキストをコピーして貼り付けます。

テキスト

```text
You are an expert at using the Git version control system. I will ask questions looking for guidance on the best way to perform tasks using Git, and you will give clear, step-by-step answers that explain each step you are recommending.
```

メモ

**\[システム**\] テキスト フィールドが編集できない場合は、上のモデルのドロップダウンから別のモデルを選択してみてください。すべてのモデルでシステムプロンプトを変更できるわけではありません。

### [4\. ユーザープロンプトの書き方](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#4-writing-a-user-prompt)

ユーザープロンプトは、会話中にAIシステムに直接質問または指示し、AIシステムがそれに応答します。

**\[ユーザープロンプト**\]フィールドに、次のテキストをコピーして貼り付けます。

テキスト

```text
I want to learn how to use Git from the command line.
```

### [5\. サンプル入力の入力](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#5-entering-sample-input)

**ユーザープロンプト**の変数は、サンプル入力のプレースホルダーとして機能します。このプレースホルダーを管理するには、\[**変数**\] ボタンをクリックし、次のテキストを入力します。`{{input}}`

テキスト

```text
When should I use rebase or merge?
```

### [6\. Running the sample prompt](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#6-running-the-sample-prompt)

1.  In the upper-right corner, click **Play**.
2.  Make a change to the model or prompt, then run the prompt again to see what results you get.

## [Testing different models against a prompt](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#testing-different-models-against-a-prompt)

Now, let's determine which model will work best for our application, using the **Comparisons** view. This view allows you to test different models on the same input, revealing differences in accuracy, creativity, tone, reasoning, and reliability. That will help us choose the model that best fits our needs in terms of quality, speed, cost, and consistency.

1.  In the upper-left corner, click **Comparisons**.
    
2.  To compare different models, click **Add prompt** and select **Copy original prompt** to duplicate your existing system and user prompts. Create at least two copies of the original prompt to evaluate three different models.
    
3.  Next to each prompt, click . From the **Model** dropdown, choose a different model for each prompt you created.
    
4.  Click **Add inputs** to create new rows for sample inputs.
    
    -   Click **Add inputs**. Then, in the "Input" field, copy and paste the following text:
        
        Text
        
        ```text
        How do I modify the most recent commit message in my current branch?
        ```
        
    -   Click **Add inputs** again, then paste the following input:
        
        Text
        
        ```text
        How do I move a specific commit from one branch to a different branch?
        ```
        
    -   Click **Add inputs** one more time, and paste this input:
        
        Text
        
        ```text
        How do I find the author of a specific commit in a repository's history?
        ```
        
5.  To run the prompts, in the upper-right corner, click **Run**.
    
6.  Try out different models against your prompt, making note of the **Latency** and the **Input** and **Output** token usage of the different models.
    

## [Testing prompt variations with a specific model](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#testing-prompt-variations-with-a-specific-model)

If you’re building an application with a specific AI model, you need responses to be predictable and reliable. Testing prompt variations helps you to:

-   **Optimize performance and quality**: Slight changes in phrasing can affect the response quality. By testing variations you can find the wording that gets the best response.
-   **Clarify instructions**: By varying the phrasing of your prompt, you can identify which version the model understands most clearly.
-   **Adapt to specific model behavior**: You can tailor your input to how a specific model interprets language.
-   **Verify the format of the output**: You may want a list, a paragraph, a code block, or a specific tone. Testing prompt variation helps you enforce a specific structure or style.

Now, let's use GitHub Models to test prompt variations against user input for your specific model.

### [1\. Adding prompt variations](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#1-adding-prompt-variations)

For this example scenario, select the **same model for each column**, but provide a different prompt variation by editing the "User prompt" field of our existing prompts. Next to each prompt, click .

1.  Click in "Prompt 2." Then, in the "User prompt" field, copy and paste the following text:
    
    Text
    
    ```text
    I want to learn how to use Git from the command line, but explain it to me like I am five years old.
    ```
    
2.  Click in "Prompt 3", then paste the following input:
    
    Text
    
    ```text
    I want to learn how to use Git from the command line. Give me instructions in the form of a haiku.
    ```
    

### [2\. Running prompt variations](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#2-running-prompt-variations)

1.  To run the prompts, in the upper-right corner, click **Run**.
2.  Try out different prompt variations, and compare the types of output the model gives you.

## [Evaluating model output](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#evaluating-model-output)

We’ve tested different models and prompt variations in GitHub Models, and the next step is interpreting and comparing the results to make informed decisions for our AI-powered application.

As you ran the models in the example scenarios, the **Input** and **Output** token usage and **Latency** were displayed after each run. Token usage matters because it directly affects **cost, performance, and model limitations.**

-   Since most models charge per token both for input and output, using more tokens increases your cost.
-   Each model also has a maximum token limit (called a context window), and exceeding it can result in errors or truncated responses.
-   Longer prompts can slow down response time or reduce clarity, while concise prompts often lead to better, more efficient outputs.

Using GitHub Models to test token usage and latency helps you stay within limits, manage costs, and improve overall effectiveness of your AI-powered application.

### [Using evaluators to judge output](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#using-evaluators-to-judge-output)

Depending on the number of prompts and models you are evaluating, the model output can be overwhelming to sort through manually. To help assess the quality of each model's output, you can use **Evaluators** to score results across key dimensions like clarity, accuracy, and relevance. You can define your own evaluation criteria, or use built-in evaluators to automatically rate outputs, making it easier to identify the best-performing model and prompt variation.

For this example scenario, let's use the **String check** evaluator to check for a string in the output.

1.  In the lower-right corner of the **Prompts** field, click **Add evaluator** and select **String check**.
    
2.  In the **Name** field, enter "Amend check", then copy and paste the following input for the **Value** field:
    
3.  To run the prompts, in the upper-right corner, click **Run**.
    
4.  The prompt output will now show a **Pass** or **Fail** label, letting you know which model contained the required string.
    

To learn more about the pre-built evaluators like similarity, groundedness, and relevance, see [Evaluating AI models](https://docs.github.com/ja/github-models/use-github-models/evaluating-ai-models#evaluating-outputs).

## [Next steps](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#next-steps)

Now that you've explored how to test models, refine prompts, and evaluate outputs using GitHub Models, you're ready to start building prompts for your AI-powered application. After creating a prompt, you can store, version, and share it by committing a file to your repository. This keeps your prompts under version control, and enables easy collaboration on prompt and model refinement. For more information, see [Storing prompts in GitHub repositories](https://docs.github.com/ja/github-models/use-github-models/storing-prompts-in-github-repositories).`.prompt.yml`

To ask questions and share feedback, see this [GitHub Models discussion post](https://github.com/orgs/community/discussions/159087).  
To learn how others are using GitHub Models, visit the [GitHub Community discussions for Models](https://github.com/orgs/community/discussions/categories/models).