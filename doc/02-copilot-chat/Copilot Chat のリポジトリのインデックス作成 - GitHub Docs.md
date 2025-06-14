GitHub Copilot Chat を使って、リポジトリのインデックスを作成することで、コードに関する質問への応答を改善できます。

## [リポジトリのインデックス作成の利点](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/indexing-repositories-for-copilot-chat#benefit-of-indexing-repositories)

リポジトリのコンテキストで自然言語の質問に答える Copilot Chat の機能は、リポジトリのセマンティック コード検索インデックスが最新の場合、最適になります。

リポジトリのコンテキストを使用する Copilot Chat との会話を始めると、リポジトリのインデックスが自動的に作成されて、GitHub と Visual Studio Code でのコードの構造とロジックに関する質問への回答が、コンテキストでエンリッチされて向上します。 たとえば、**"このリポジトリは HTTP 要求と応答をどのように管理するのですか?"** などと質問すると、 Copilot Chat はコードの関連するセクションを参照して、情報に基づく回答を提供します。

**Copilot Chat では、モデルトレーニングにインデックス付きリポジトリは使用されません。**

質問のしかたについて詳しくは、「[GitHub で GitHub Copilot に質問をする](https://docs.github.com/ja/copilot/using-github-copilot/asking-github-copilot-questions-in-github)」をご覧ください。

## [インデックスの作成と使用](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/indexing-repositories-for-copilot-chat#about-index-creation-and-use)

インデックス作成はバックグラウンドで実行されます。大規模なリポジトリの場合、最初のインデックス作成には最長 60 秒かかる場合があります。 初めてリポジトリのインデックスを作成した後、インデックスの再作成ははるかに速くなり、通常、新しい会話を開始してから数秒でインデックスが自動的に更新され、最新の変更が反映されます。

リポジトリのインデックスが作成されると、Copilot Chat はそれを使い、GitHub と Visual Studio Code の Copilot ユーザーから聞かれた質問に回答します。

ヒント

インデックスを作成できるリポジトリの数に制限はありません。

## [Copilot Chat の回答からコンテンツを除外する](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/indexing-repositories-for-copilot-chat#copilot-chat-%E3%81%AE%E5%9B%9E%E7%AD%94%E3%81%8B%E3%82%89%E3%82%B3%E3%83%B3%E3%83%86%E3%83%B3%E3%83%84%E3%82%92%E9%99%A4%E5%A4%96%E3%81%99%E3%82%8B)

Copilot Enterprise または Copilot Business プランを使用する Enterprise または organization 所有者は、コンテンツの除外を定義して、管理している Copilot シートに関する GitHub Copilot の動作を制御できます。 詳しくは、「[GitHub Copilot からのコンテンツの除外](https://docs.github.com/ja/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/excluding-content-from-github-copilot)」をご覧ください。

コンテンツ除外ポリシーに含まれるリポジトリに対してセマンティック コード検索インデックスが作成されている場合、データは Copilot Chat に渡される前にポリシーに従ってフィルター処理されます。