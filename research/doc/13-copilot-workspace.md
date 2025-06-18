# GitHub Copilot Workspace：GitHub Copilotネイティブの開発環境へようこそ - GitHubブログ

![](https://github.blog/jp/wp-content/uploads/sites/2/2024/04/1200x630-Blog-Social-Primary-2.png?fit=1200%2C630)

2024-04-30

-   [Product](https://github.blog/jp/category/product/)

# GitHub Copilot Workspace：GitHub Copilotネイティブの開発環境へようこそ

[

![Image of Ishikawa Setsuna](https://avatars.githubusercontent.com/u/104476557?v=4&s=35)

Ishikawa Setsuna

](https://github.blog/jp/author/bigbeatishikawa/)

Author

[  
![Thomas Dohmke](https://avatars.githubusercontent.com/u/70720?v=4&s=200)Thomas Dohmke](https://github.blog/author/ashtom/)

GitHub Copilot Workspaceで開発環境を再定義します – どんな開発者でも自然言語でアイディアからコード、ソフトウェアまで作成できます。登録は[こちら](https://githubnext.com/projects/copilot-workspace)。

---

この2年間で、生成AIは開発環境の中に組み込まれたツールとして、開発者の状況を大きく変えました。2022年、私たちはエディタ内のオートコンプリートAIペアプログラマーとしてGitHub Copilotを発表し、開発者の生産性を最大[55%](https://github.blog/jp/2022-09-15-research-quantifying-github-copilots-impact-on-developer-productivity-and-happiness/)向上させました。GitHub Copilotは現在、最も広く採用されているAI開発者ツールです。2023年、GitHub Copilot Chatをリリース、コーディング、デバッグ、テストにおける自然言語の力を引き出し、開発者がリアルタイムでコードと会話できるようになりました。

昨年GitHub Universeで[その一端をお見せした](https://github.blog/jp/2023-11-09-universe-2023-copilot-transforms-github-into-the-ai-powered-developer-platform/)後、本日GitHub Copilotネイティブの開発環境であるGitHub Copilot Workspaceのテクニカルプレビューを提供し、開発者体験そのものを再構築します。GitHub Copilot Workspaceでは、開発者は自然言語でコードのブレインストーミング、計画、ビルド、テスト、実行を行うことができます。この新しいタスク中心の開発者体験では、GitHub Copilot を搭載したさまざまなエージェントを開発プロセスの最初から最後まで活用し、開発者はプロセスの各ステップを完全にコントロールできます。

<iframe loading="lazy" title="YouTube video player" src="https://www.youtube.com/embed/pkotufZchjE?si=QvAQYGQXT6-NS30n" width="560" height="315" frameborder="0" allowfullscreen="allowfullscreen"></iframe>

GitHub Copilot Workspaceは、自然言語を使用してソフトウェアを構築する根本的に新しい方法であり、開発者の創造性をこれまで以上に迅速かつ容易に実現するために[設計](https://github.blog/2024-01-17-a-developers-second-brain-reducing-complexity-through-partnership-with-ai/)されています。GitHub Copilot Workspaceは、経験豊富な開発者にはシステム思考者としての力を与え、ソフトウェア構築への参入障壁を大幅に引き下げます。

今日から始まる新しい開発者環境へようこそ。その仕組みを紹介しましょう：

### すべてはタスクから始まります…[](#%e3%81%99%e3%81%b9%e3%81%a6%e3%81%af%e3%82%bf%e3%82%b9%e3%82%af%e3%81%8b%e3%82%89%e5%a7%8b%e3%81%be%e3%82%8a%e3%81%be%e3%81%99)

![](https://github.blog/jp/wp-content/uploads/sites/2/2024/04/It-all-starts-with-the-task.png?w=1024&resize=1024%2C593)

開発者にとって、タスクに関する最大の障壁はほとんどの場合、[最初](https://github.blog/jp/2023-11-09-universe-2023-copilot-transforms-github-into-the-ai-powered-developer-platform/)にあります。大きなプロジェクトや機能リクエスト、バグレポートの最初のステップで壁にぶつかることがよくあります。GitHub Copilot Workspaceは、GitHubリポジトリやGitHub Issueという原点で開発者を迎えます。GitHub Copilotエージェントを第二の頭脳として活用することで、開発者はアイディアの初期段階からAIによる支援を受けることができます。

### …Workspaceは完全な計画を構築します[](#workspace%e3%81%af%e5%ae%8c%e5%85%a8%e3%81%aa%e8%a8%88%e7%94%bb%e3%82%92%e6%a7%8b%e7%af%89%e3%81%97%e3%81%be%e3%81%99)

![Progress from your task to a specification, outlining what you want to achieve with Copilot Workspace. The steps are editable, enabling you to iterate on ideas.](https://github.blog/jp/wp-content/uploads/sites/2/2024/04/3-Plan-of-Action-Zoom-with-BG.png?w=1024&resize=1024%2C607)

そこから、GitHub Copilot Workspaceは、コードベースやIssueの返信などに対する深い理解に基づき、Issueを解決するためのステップバイステップの計画を提供します。計画を検証し、コードをテストするために必要なすべてを、1 つの合理化されたリストで自然言語で提供します。

### しかも、完全に編集可能です…[](#%e3%81%97%e3%81%8b%e3%82%82%e3%80%81%e5%ae%8c%e5%85%a8%e3%81%ab%e7%b7%a8%e9%9b%86%e5%8f%af%e8%83%bd%e3%81%a7%e3%81%99)

![Then adjust your plan of action, adding steps, and general notes. Once the plan is implemented, you can view changes with a PR diff view and make edits as needed.](https://github.blog/jp/wp-content/uploads/sites/2/2024/04/copilot-workspace.png?w=1024&resize=1024%2C593)

GitHub Copilot Workspace が提案するものは、計画からコードまですべて編集可能です。GitHub Copilot Workspaceがあなたの認知的負担を軽減する一方で、あなたはすべてをコントロールできます。

![Once you're happy with the code, you can use the integrated terminal to run unit tests, builds and appropriate checks.](https://github.blog/jp/wp-content/uploads/sites/2/2024/04/4.1-Run-code-in-Copilot-Workspac.png?w=1024&resize=1024%2C604)

計画が大丈夫そうなら、GitHub Copilot Workspaceでコードを直接実行し、基盤となるGitHub Codespaceにジャンプして、最終結果に満足するまですべてのコード変更を微調整できます。また、リンクでワークスペースをチームと即座に共有できるため、チームはあなたの作業を確認したり、自分の反復作業を試したりすることもできます。

あとは、プルリクエストを提出し、GitHub Actions、セキュリティコードスキャンを実行し、チームメンバーにコードレビューを依頼するだけです。そして何より、チームメンバーはGitHub Copilot Workspaceを活用して、アイディアからコードに至るまでの経緯を確認できます。

<iframe loading="lazy" title="YouTube video player" src="https://www.youtube.com/embed/L5Xny6yehUg?si=Uk3BXkhrDSR60fxw" width="560" height="315" frameborder="0" allowfullscreen="allowfullscreen"></iframe>

### またGitHub Copilot Workspace はモバイルに対応しています[](#%e3%81%be%e3%81%9fgithub-copilot-workspace-%e3%81%af%e3%83%a2%e3%83%90%e3%82%a4%e3%83%ab%e3%81%ab%e5%af%be%e5%bf%9c%e3%81%97%e3%81%a6%e3%81%84%e3%81%be%e3%81%99)

GitHub Copilot Workspace は、デスクトップ、ラップトップ、外出先など、あらゆるデバイスから利用できるように設計されており、開発現場の環境に力を与えます。

<iframe loading="lazy" title="YouTube video player" src="https://www.youtube.com/embed/Zv6TuVzcRdY?si=MUG-0exR6678vVtW" width="560" height="315" frameborder="0" allowfullscreen="allowfullscreen"></iframe>

直感的でGitHub Copilotを利用したインフラにより、開発環境の開始、学習、そして最終的な実行が容易になります。

## 10億人の開発者のいる世界を実現[](#10%e5%84%84%e4%ba%ba%e3%81%ae%e9%96%8b%e7%99%ba%e8%80%85%e3%81%ae%e3%81%84%e3%82%8b%e4%b8%96%e7%95%8c%e3%82%92%e5%ae%9f%e7%8f%be)

昨年初め、GitHub はプラットフォーム上の[開発者数が 1 億人を突破](https://github.blog/jp/2023-02-07-100-million-developers-and-counting/)しました。自然言語によるプログラミングがソフトウェアを作ることへの参入障壁を低くするにつれ、私たちはGitHubで[10億人](https://www.sequoiacap.com/article/the-next-billion-developers-perspective/)が自転車に乗るのと同じように簡単にマシンをコントロールする未来へと加速しています。GitHub Copilot Workspaceは、その未来を目指し、地球上のすべての人々にソフトウェアを作る経済的機会と喜びを広げるために構築されました。

同時に、私たちはプロフェッショナルな開発者に依存し、開発者が不足している世界に生きています。世界中で、開発者たちは毎日何百万行ものコード行を、複雑さを増すシステムに追加しており、古いシステムのメンテナンスはますます遅れています。この世界のあらゆるインフラと同じように、世界のコードのメンテナーと更新には本物の専門家が必要です。定型的な作業を定量的に削減することで、私たちはプロの開発者に力を与え、システムの思考者としてますます活動できるようにします。GitHub Copilot、そして今回のGitHub Copilot Workspaceによって、開発者の生産性が一段と向上することで、[労働需要](https://github.blog/jp/2023-07-05-the-economic-impact-of-the-ai-powered-developer-lifecycle-and-lessons-from-github-copilot/)はますます高まるでしょう。

これこそが GitHub Copilot の二重の可能性です。プロフェッショナルな開発者にとっても、趣味で開発する開発者にとっても、創造性をコードに注ぎ込むことがより簡単になります。

---

本日より、GitHub Copilot Workspaceのテクニカルプレビューを開始します。今すぐ[ご登録](https://githubnext.com/projects/copilot-workspace)ください。ここからあなたが何を作るのか楽しみにしています。

---

**Tags:** [generative AI](https://github.blog/jp/tag/generative-ai/) [GitHub Copilot](https://github.blog/jp/tag/github-copilot/) [GitHub Enterprise](https://github.blog/jp/tag/github-enterprise/)

**Share**

-   [Twitter Share on Twitter](https://twitter.com/share?text=GitHub Copilot Workspace：GitHub Copilotネイティブの開発環境へようこそ&url=https://github.blog/jp/2024-04-30-github-copilot-workspace/)
-   [Facebook Share on Facebook](https://www.facebook.com/sharer/sharer.php?u=https://github.blog/jp/2024-04-30-github-copilot-workspace/&t=GitHub%20Copilot%20Workspace%EF%BC%9AGitHub%20Copilot%E3%83%8D%E3%82%A4%E3%83%86%E3%82%A3%E3%83%96%E3%81%AE%E9%96%8B%E7%99%BA%E7%92%B0%E5%A2%83%E3%81%B8%E3%82%88%E3%81%86%E3%81%93%E3%81%9D)
-   [LinkedIn Share on LinkedIn](https://www.linkedin.com/shareArticle?url=https://github.blog/jp/2024-04-30-github-copilot-workspace/&title=GitHub%20Copilot%20Workspace%EF%BC%9AGitHub%20Copilot%E3%83%8D%E3%82%A4%E3%83%86%E3%82%A3%E3%83%96%E3%81%AE%E9%96%8B%E7%99%BA%E7%92%B0%E5%A2%83%E3%81%B8%E3%82%88%E3%81%86%E3%81%93%E3%81%9D)

**Related posts**

2025-02-07

[GitHub Copilot](https://github.blog/jp/category/github-copilot/)

#### [GitHub Copilot:エージェントの覚醒](https://github.blog/jp/2025-02-07-github-copilot-the-agent-awakens/)

GitHub Copilotの新機能を発表：VS Code向けのエージェントモードを導入、Copilot Editsの一般提供を開始、SWEエージェントの初公開

[

![Image of tomokota](https://secure.gravatar.com/avatar/956ea2b792fa8577ae271729cccae2d338be2fb17ff928ff517892ab125d3d04?s=35&d=mm&r=g)

tomokota

](https://github.blog/jp/author/tomokota/)

2024-11-12

[Insights](https://github.blog/jp/category/insights/)

#### [AnthropicのClaude 3.5 Sonnet、GoogleのGemini 1.5 Pro、OpenAIのo1-previewがGitHub Copilotで選べるようになりました](https://github.blog/jp/2024-11-12-bringing-developer-choice-to-copilot/)

GitHub Universeにて、AnthropicのClaude 3.5 Sonnet、GoogleのGemini 1.5 Pro、OpenAIのo1-previewとo1-miniがGitHub Copilotに登場することを発表しました。

[

![Image of tomokota](https://secure.gravatar.com/avatar/956ea2b792fa8577ae271729cccae2d338be2fb17ff928ff517892ab125d3d04?s=35&d=mm&r=g)

tomokota

](https://github.blog/jp/author/tomokota/)

2024-11-10

[Insights](https://github.blog/jp/category/insights/)

#### [GitHub Universe 2024より最新のプレビューとリリースをお届けします](https://github.blog/jp/2024-11-10-universe-2024-previews-releases/)

GitHubとGitHub Copilotの進化と、最新のプレビューやGAリリース情報をご紹介します。

[

![Image of tomokota](https://secure.gravatar.com/avatar/956ea2b792fa8577ae271729cccae2d338be2fb17ff928ff517892ab125d3d04?s=35&d=mm&r=g)

tomokota

](https://github.blog/jp/author/tomokota/)