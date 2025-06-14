GitHub Models を使って、organization 内の AI モデルを制御し、セキュリティで保護します。

## この機能を使用できるユーザーについて

Organization のオーナーは、Organization で使用されるモデルを管理できます

メモ

Organization とリポジトリの GitHub モデルはパブリック プレビュー段階であり、変更される可能性があります。

## [Organization 内でのモデルの使用を制限する理由](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#why-restrict-model-usage-in-your-organization)

開発者が使用できるモデルを制限することで、**モデルへの支出を制御し、ガバナンス、データ セキュリティ、コンプライアンスの要件を満たすことができます**。

アクセスを管理しないと、チームが organization の標準を満たしていないモデルを誤って使い、次のような潜在的なリスクにつながる可能性があります。

-   高価なモデルによる予期しないコスト
-   不正な AI サービスによって引き起こされるセキュリティまたはコンプライアンスの問題
-   承認されていないモデルや最適ではないモデルの統合に費やされる時間の無駄

大規模なモデルの使用の詳細については、「[GitHub Models を使って Enterprise 内で AI を利用したアプリケーションを開発する](https://docs.github.com/ja/github-models/github-models-at-scale/use-models-at-scale)」を参照してください。

## [Organization のモデル設定の例外](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#exceptions-to-your-organizations-model-settings)

Organization とリポジトリの GitHub Models はパブリック プレビュー段階ですが、特定の状況では organization のモデル設定の一部が適用されません。 チームは、次の場所で AI モデルを制限なく使用できます。

-   Enterprise Managed Users 組織
-   GitHub CLI 用の GitHub Models 拡張機能
-   Github Kapilに設定 用の Github Models 拡張機能
-   GitHub Models VS Code 拡張機能
-   GitHub Marketplace ([https://github.com/marketplace/models](https://github.com/marketplace/models)) にある GitHub Models のプレイグラウンド。

## [Enterprise の GitHub Models を有効にする](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#enterprise-%E3%81%AE-github-models-%E3%82%92%E6%9C%89%E5%8A%B9%E3%81%AB%E3%81%99%E3%82%8B)

GitHub モデルを Organization で利用できるようにするには、まず Enterprise のオーナーが Enterprise の機能を有効にする必要があります。

1.  ページの左側にある Enterprise アカウント サイドバーの **\[ポリシー\]** をクリックします。
2.  "Policies(ポリシー)"の下で、**モデル**.
3.  \[Models\] の \[Models in your enterprise\] セクションで、**\[Disabled\]** の横にある をクリックし、ドロップダウンから **\[Enabled\]** を選びます。

## [Organization 内でのモデルの使用の制御](https://docs.github.com/ja/github-models/use-github-models/prototyping-with-ai-models#controlling-model-usage-in-your-organization)

メモ

Organization の Models 設定を変更できるのは、Enterprise ポリシーで GitHub Models へのアクセスが許可されている場合のみです。

Organization の GitHub モデルを有効にするか無効にするかを選択できます。また、選択したモデルまたはモデルの発行元の使用のみを許可するように選択することもできます。

1.  GitHub の右上隅でプロフィール写真を選んでから、**\[あなたの組織\]** をクリックします。
    
2.  組織の隣の **\[設定\]** をクリックします。
    
3.  サイドバーの「コード、計画、および自動化」セクションで、**モデル**.
    
4.  \[モデル\] の \[組織内のモデル\] セクションで、\[**無効\]** の横にあるをクリックし、ドロップダウンから **\[有効**\] を選択します。
    
    メモ
    
    GitHub ModelsがOrganizationですでに有効になっている場合、ドロップダウンには**\[有効\]**と表示され、上記の手順をスキップできます。
    
5.  \[モデルの権限\] で、1 つ以上のオプションを選択します。
    
    -   **\[すべてのパブリッシャー\]** はデフォルトのオプションであり、GitHub Marketplace の GitHub Models カタログで利用可能な現在および将来のすべてのパブリッシャーのモデルを Organization で使用できることを示します。
    -   **「モデルのみ選択**」では、モデルとパブリッシャーのリストを定義できます。
        -   組織で使用可能 (**\[有効\] リスト**)
        -   組織での使用が制限されている (**無効リスト**)
    
    Depending on your requirements, you can specify an enabled list, a disabled list, or both. Once you've added a publisher to a list, you can fine-tune the list by removing individual models from it.