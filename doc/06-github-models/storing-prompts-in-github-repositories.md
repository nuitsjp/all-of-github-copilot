## GitHub リポジトリへのプロンプトの保存

プロンプトを GitHub リポジトリに直接保存して、自動テキスト要約やその他の AI 駆動型機能を活用できます。

プロンプトは、GitHub リポジトリ内にファイルとして直接保存できます。これにより、整理された UI でプロンプトを表示し、技術者以外の関係者と共有し、モデルとプロンプトの調整に対してシームレスなイテレーションと比較を実行する機能のロックを解除します。

## [利点](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#benefits)

-   新しいAI開発ツールスイートとGitHubで直接簡単に統合できます。
-   シンプルなユースケースから複雑なユースケースまで、シンプルでスケーラブルです。
-   広くサポートされている形式を使用し、既存のツールと互換性があります。

## [サポートされているファイル形式](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#supported-file-format)

プロンプトをYAMLファイルに保存します。

ファイルはリポジトリ内の任意の場所に配置できますが、_拡張子は `.prompt.yml` または `.prompt.yaml` にする必要があります。_

例：

YAMLの

```yaml
name: Text Summarizer description: Summarizes input text concisely model: gpt-4o-mini modelParameters: temperature: 0.5 messages: - role: system content: You are a text summarizer. Your only job is to summarize text given to you. - role: user content: | Summarize the given text, beginning with "Summary -": <text> {{input}} </text> testData: - input: | The quick brown fox jumped over the lazy dog. The dog was too tired to react. expected: Summary - A fox jumped over a lazy, unresponsive dog. evaluators: - name: Output should start with 'Summary -' string: startsWith: 'Summary -'
```

## [プロンプト構造](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#prompt-structure)

プロンプトには、次の 2 つの主要な部分があります。

-   **ランタイム情報** (必須)
    -   プロンプトテンプレート(システム、ユーザーなど)は、単純なプレースホルダーを使用します。`{{variable}}`
-   **開発情報**(オプション)
    -   人間が読める名前と説明
    -   モデルの識別子とパラメーター
    -   テストと評価のためのサンプルデータ
    -   評価者自身を説明するデータ

## [制限](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#limitations)

次のプロンプトは保存できません。

-   複雑なテンプレート言語
-   独自のファイル形式または複雑なファイル形式 ( など)`.ghprompt``.prompty`)