# Issue作成だけで後の工程は全てお任せ！GitHub Copilot Workspaceのテクニカルプレビューを触ってみた | DevelopersIO

目次

[GitHub Copilot Workspace とは](#github-copilot-workspace-%25E3%2581%25A8%25E3%2581%25AF) [試してみた](#%25E8%25A9%25A6%25E3%2581%2597%25E3%2581%25A6%25E3%2581%25BF%25E3%2581%259F) [Issue の作成](#issue-%25E3%2581%25AE%25E4%25BD%259C%25E6%2588%2590) [変更仕様の検討](#%25E5%25A4%2589%25E6%259B%25B4%25E4%25BB%2595%25E6%25A7%2598%25E3%2581%25AE%25E6%25A4%259C%25E8%25A8%258E) [変更計画の作成](#%25E5%25A4%2589%25E6%259B%25B4%25E8%25A8%2588%25E7%2594%25BB%25E3%2581%25AE%25E4%25BD%259C%25E6%2588%2590) [実装](#%25E5%25AE%259F%25E8%25A3%2585) [Pull Request の作成](#pull-request-%25E3%2581%25AE%25E4%25BD%259C%25E6%2588%2590) [全く新しい開発プロセスでした](#%25E5%2585%25A8%25E3%2581%258F%25E6%2596%25B0%25E3%2581%2597%25E3%2581%2584%25E9%2596%258B%25E7%2599%25BA%25E3%2583%2597%25E3%2583%25AD%25E3%2582%25BB%25E3%2582%25B9%25E3%2581%25A7%25E3%2581%2597%25E3%2581%259F)

![Issue作成だけで後の工程は全てお任せ！GitHub Copilot Workspaceのテクニカルプレビューを触ってみた](https://devio2023-media.developers.io/wp-content/uploads/2023/03/copilot-ga.png)

# Issue作成だけで後の工程は全てお任せ！GitHub Copilot Workspaceのテクニカルプレビューを触ってみた

GitHub Copilot Workspaceのテクニカルプレビューへの招待が来たので早速触ってみました！

[#GitHub Copilot](/tags/github-copilot/)

[#生成AI](/tags/generative-ai/)

[

![きんじょー](https://devio2023-media.developers.io/wp-content/uploads/devio_thumbnail/2024-06/kinjo-shuya.jpeg)

きんじょー

](/author/kinjo-shuya/)

[![facebook logo](/img/sns/facebook.svg)](https://www.facebook.com/sharer.php?u=https%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIOhttps%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIO)[![hatena logo](/img/sns/hatena.svg)](https://b.hatena.ne.jp/add?mode=confirm&url=https%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&title=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIOhttps%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIO)[![twitter logo](/img/sns/twitter.svg)](https://twitter.com/intent/tweet?original_referer=https://dev.classmethod.jp/articles/github-copilot-workspace-tech-preview/&text=%23DevelopersIO%20Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20https%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=%23DevelopersIO%20Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20)

![Clock Icon](/img/clock.svg)2024.06.13

この記事は公開されてから1年以上経過しています。情報が古い可能性がありますので、ご注意ください。

こんにちは。リテールアプリ共創部の[きんじょー](https://twitter.com/joe_king_sh)です。  
待ちに待った GitHub Copilot Workspace のテクニカルプレビューへ招待が来たので、早速試してみました。

## [](#github-copilot-workspace-%E3%81%A8%E3%81%AF)GitHub Copilot Workspace とは

[GitHub Copilot Workspace](https://githubnext.com/projects/copilot-workspace/)は、自然言語で記載した Issue を元に、仕様の策定から実装、ビルド、デバッグなど、その後の工程を Copilot が自動的に実行してくれる開発者向けの AI ツールです。

現在はテクニカルプレビューの段階で Waiting List に登録することで順次利用することができます。  
ユーザーマニュアルも公開されているため、詳しく知りたい方はこちらをご覧ください。

<iframe loading="lazy" class="hatenablogcard" style="width:100%;height:155px;max-width:680px" title="Copilot Workspace User Manual" src="https://hatenablog-parts.com/embed?url=https://github.com/githubnext/copilot-workspace-user-manual" width="300" height="150" frameborder="0" scrolling="no"></iframe>

## [](#%E8%A9%A6%E3%81%97%E3%81%A6%E3%81%BF%E3%81%9F)試してみた

以前、AWS Blogs や更新情報の RSS フィードを日本語翻訳し、社内 Slack に流す Bot を作成しました。

<iframe loading="lazy" class="hatenablogcard" style="width:100%;height:155px;max-width:680px" title="AWSの英語RSSをAmazon Translateで翻訳してSlack通知し、re:Invent2022のアップデートラッシュに備えるBotを作成しました #reInvent" src="https://hatenablog-parts.com/embed?url=https://dev.classmethod.jp/articles/reinvent-2022-aws-rss-feed-translator-bot" width="300" height="150" frameborder="0" scrolling="no"></iframe>

こちらの Bot には修正が必要な不具合があり、運用を一時停止していましたが、Copilot Workspace を利用して改修していきたいと思います。

### [](#issue-%E3%81%AE%E4%BD%9C%E6%88%90)Issue の作成

まずは Issue を書いてきます。

この Issue で実装したい機能は以下です。

1.  RSS フィードの配信履歴を管理しているテーブルのパーティションキーの変更
2.  それに伴うアプリケーションコードの変更

Issue の画面から右の`Open in Workspace`で Copilot Workspace を起動します。

![1_issue](https://devio2024-media.developers.io/image/upload/v1718284830/2024/06/13/a8w39w8b8sg5hw2walsr.png)

### [](#%E5%A4%89%E6%9B%B4%E4%BB%95%E6%A7%98%E3%81%AE%E6%A4%9C%E8%A8%8E)変更仕様の検討

Issue の内容をもとに Copilot が変更仕様を提案してくれました。

提案内容は以下のとおりです

-   変更前の状態(Current)
    -   `RSSNotificationHistory`テーブルのパーティションキーは Title のままになっている
    -   `lib/rss-feed-translater-stack.ts`の中で Title がパーティションキーに設定されている
    -   `docs/dynamodb.md`でもパーティションキーは Title として定義されている
-   変更仕様(Proposed)
    -   `RSSNotificationHistory`テーブルのパーティションキーは Title から Guid に変更されている
    -   `lib/rss-feed-translater-stack.ts`の中で Guid がパーティションキーに設定されている
    -   `docs/dynamodb.md`でもパーティションキーは Guid に更新されている

![2_specification](https://devio2024-media.developers.io/image/upload/v1718284839/2024/06/13/dyk65ht2mreecnfzudn2.png)

文章中のファイル名をクリックすると、コードのプレビューを確認できます。

![4_specification_code_view](https://devio2024-media.developers.io/image/upload/v1718284837/2024/06/13/ypcktzm39dw8vq9d6qaw.png)

この Issue では、DynamoDB のキーの変更だけでなく DynamoDB アクセスをするコードも一緒に変更したいと考えていました。  
しかし、後者の変更は Issue にしっかりと記載していないためか、変更仕様には含まれていませんでした。

出力された変更仕様は以下の方法で手を加えられます。

-   チャットでの指示
-   直接編集
-   直接項目の追加

「登録・更新処理もキー変更に合わせて変更されていること」という変更仕様を手動で追加しました。

![5_fix_proposed](https://devio2024-media.developers.io/image/upload/v1718284841/2024/06/13/oyzgjv9xvwafu96k1ace.png)

`Generate plan`で変更計画を作成します。

### [](#%E5%A4%89%E6%9B%B4%E8%A8%88%E7%94%BB%E3%81%AE%E4%BD%9C%E6%88%90)変更計画の作成

変更するファイルと、変更内容を出してくれました。

通常の開発プロセスでは Pull Request の形で変更提案をレビューすることが多いですが、Copilot Workspace では実装前に変更されるファイル一覧と変更内容を確認することになります。

この時点では、全体のコードベースを読まないと、変更提案が正しいのかどうか正確に判断が難しいという印象です。  
この後 Pull Request のフェーズはあるので、ここではざっと内容を確認し`Implement selected files`で実装に移ります。

![6_plan](https://devio2024-media.developers.io/image/upload/v1718284835/2024/06/13/ywp3zupspb9ifwfusozh.png)

### [](#%E5%AE%9F%E8%A3%85)実装

画面が切り替わり、1 ファイルずつ実装が進んでいきます。

![7_implement](https://devio2024-media.developers.io/image/upload/v1718284835/2024/06/13/cxr2ug64t9zocil5qdxx.png)

概ね変更は計画通りに実装されていますが、初回の出力では動かないコードが出てきました。  
![9_not_working_code](https://devio2024-media.developers.io/image/upload/v1718284834/2024/06/13/ckqdo3amoavgyoxibugp.png)

生成されたコードは以下のいづれかの方法で修正が可能です。

![8_revice_implement](https://devio2024-media.developers.io/image/upload/v1718284837/2024/06/13/qewjwgliiy9qmgwcsunm.png)

チャットでシンタックスエラーを直すよう指示を出すと、Plan に指示が追加されてコードが再生成されました。  
![10_fix_syntax_errors](https://devio2024-media.developers.io/image/upload/v1718284835/2024/06/13/oxltb1czqy3b76hhypot.png)

続いて関数のインポート元を変更するように指示します。  
![11_fix_import_issue](https://devio2024-media.developers.io/image/upload/v1718284833/2024/06/13/sld2mwxswjqp4u7tkytq.png)

`fetchHistoryByGuid`のインポート元は変わりましたが、今度は`isValidItem`のインポートが消え、不必要なコメントも追加されてしまいました。  
![12_fix_import_issue2](https://devio2024-media.developers.io/image/upload/v1718284830/2024/06/13/udeswnzr1yqxoun3nqgm.png)

直接直した方が早そうなので Codespace でプロジェクトを開きます。  
Copilot の作業内容が反映された状態で開かれ、直接コードの修正が可能です。  
![13_fix_in_codespace](https://devio2024-media.developers.io/image/upload/v1718284831/2024/06/13/cq8kmax7i6zgwdkcybsf.png)

### [](#pull-request-%E3%81%AE%E4%BD%9C%E6%88%90)Pull Request の作成

修正が完了したので Pull Request を作成します。([実際の PR はこちら](https://github.com/joe-king-sh/rss-feed-translater/pull/5))  
![14_create_pr](https://devio2024-media.developers.io/image/upload/v1718284831/2024/06/13/cbhapivtl1u18wpkpjj3.png)

Commit メッセージや PR のタイトル、本文は自動生成されます。  
ここで注目すべき点は、Pull Request からも Copilot Workspace のセッションが開始可能な点です。

![15_created_pr](https://devio2024-media.developers.io/image/upload/v1718284830/2024/06/13/gg4da662tea1lt66rcc6.png)

PR の内容についてさらに修正が必要な場合、Copilot Workspace で追加の修正ができ、そのコミットがこの PR に追加されます。

![16_add_commits_to_pr](https://devio2024-media.developers.io/image/upload/v1718284831/2024/06/13/i3ocyczzystpt5hfuejk.png)

## [](#%E5%85%A8%E3%81%8F%E6%96%B0%E3%81%97%E3%81%84%E9%96%8B%E7%99%BA%E3%83%97%E3%83%AD%E3%82%BB%E3%82%B9%E3%81%A7%E3%81%97%E3%81%9F)全く新しい開発プロセスでした

Copilot Workspace を使用して、個人プロジェクトの小さな Issue を解決してみました。

GitHub Copilot が出た当初は、コード補完をしてくれるアシスタントの役割が主でしたが、昨年リリースされた Copilot Chat で AI に直接的な指示ができるようになり、開発手法が大きく変わりました。

Copilot Workspace は**リポジトリ全体のコンテキストをもとに、Issue から、仕様検討、変更計画策定、実装、PR 作成までの一連の流れを AI が自律的に進める**、これまでの Copilot とは全く違う新しい体験でした。

AI がアプリケーションを生成する SaaS が続々と登場していますが、細かい点について指示出しができないものが多く、実用を検討する段階ではないと考えていました。  
しかし、Copilot Workspace は上記プロセスの各ステップで、開発者が追加の指示を出したり直接手を加えることができ、非常に実用的でした。

一方で、今後の期待する点としては、以下が挙げられます。

-   コード生成の待ち時間短縮
    -   生成を待つ時間は少し気になりました。
    -   変更するファイル数が大きい場合、何度もフィードバックループを回す際にボトルネックになる可能性があります。
    -   モデルの性能の向上とともに解決が期待されます。
-   コード品質の向上
    -   提案されるコードそのままの状態では、シンタックスエラーを含んでいたり、いくら指示しても冗長なコメントが追加されるなど、品質が安定しないことがありました。
    -   CI の実行結果とも統合して、自動でバグ修正まで回るようになることを期待します。
    -   また、PullRequest に対するレビューのコメントを元に修正が走ると、普段の開発プロセスに統合しやすいと感じました。
-   複数リポジトリの統合
    -   現状では 1 リポジトリのコンテキストをもとにコードが生成されます。
    -   プロジェクトやリポジトリの管理方法によっては、複数リポジトリにコンテキストが分散している可能性があります。
    -   GitHub Copilot Enterprise の Knowledge Bases との統合も期待できます。

Copilot Workspace が触ってみたい方は、是非こちらの[waiting list](https://githubnext.com/projects/copilot-workspace)に登録してみください。

以上。リテールアプリ共創部の[きんじょー](https://twitter.com/joe_king_sh)でした。

---

## ChatGPT？Gemini？生成AI導入で迷っているあなたへ

クラスメソッドは、業務効率化・サービス開発を実現する生成AI導入をトータルで支援しています。主要サービスの違いや導入のポイントを分かりやすくまとめた「生成AI活用支援資料」をぜひご覧ください。

[![生成AI資料イメージ](https://classmethod.jp/wp-content/uploads/2024/07/e2eb2f5852b8906fba0b26efd0e3fe14.png)](https://classmethod.jp/download/generative-ai/?utm_source=dev.classmethod.jp&utm_medium=banner&utm_campaign=contentsbanner&utm_content=generativeai-download)

[無料でダウンロードする](https://classmethod.jp/download/generative-ai/?utm_source=dev.classmethod.jp&utm_medium=banner&utm_campaign=contentsbanner&utm_content=generativeai-download)

Share this article

[![facebook logo](/img/sns/facebook.svg)](https://www.facebook.com/sharer.php?u=https%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIOhttps%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIO)[![hatena logo](/img/sns/hatena.svg)](https://b.hatena.ne.jp/add?mode=confirm&url=https%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&title=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIOhttps%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20%7C%20DevelopersIO)[![twitter logo](/img/sns/twitter.svg)](https://twitter.com/intent/tweet?original_referer=https://dev.classmethod.jp/articles/github-copilot-workspace-tech-preview/&text=%23DevelopersIO%20Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20https%3A%2F%2Fdev.classmethod.jp%2Farticles%2Fgithub-copilot-workspace-tech-preview%2F&t=%23DevelopersIO%20Issue%E4%BD%9C%E6%88%90%E3%81%A0%E3%81%91%E3%81%A7%E5%BE%8C%E3%81%AE%E5%B7%A5%E7%A8%8B%E3%81%AF%E5%85%A8%E3%81%A6%E3%81%8A%E4%BB%BB%E3%81%9B%EF%BC%81GitHub%20Copilot%20Workspace%E3%81%AE%E3%83%86%E3%82%AF%E3%83%8B%E3%82%AB%E3%83%AB%E3%83%97%E3%83%AC%E3%83%93%E3%83%A5%E3%83%BC%E3%82%92%E8%A7%A6%E3%81%A3%E3%81%A6%E3%81%BF%E3%81%9F%20)

## Embedded Content

<iframe height="0" width="0" src="https://www.googletagmanager.com/static/service_worker/5690/sw_iframe.html?origin=https%3A%2F%2Fdev.classmethod.jp" style="display: none; visibility: hidden;"></iframe>

---