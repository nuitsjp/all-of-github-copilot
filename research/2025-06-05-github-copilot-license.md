---
title: "GitHub Copilotライセンスの適用詳細"
emoji: "😸"
type: "tech" # tech: 技術記事 / idea: アイデア
topics: [github, copilot]
published: true
---

GitHub Copilotの有償ライセンスにはPro・Pro+・Business・Enterpriseの4つがあります。

基本的にはProとPro+が個人で契約するもので、BusinessとEnterpriseは組織で契約するものになります。

これらのライセンスは、きれいに分離・適用されているわけではなく、少し癖のある内容になっています。

というわけで、下記の観点で調査・整理したので、気になる方はご覧ください。

1. Pro+とBusiness両方持っていたらどうなるの？
2. 同一リポジトリで、人によってBusinessとEnterpriseを使い分けられるの？
3. Copilotが有効な人が、Copilotの無効なOrganizationを使ったらどうなるの？
4. おすすめの割当方法は？

他に分からないことがあれば、ぜひコメントでご質問ください。

# 基本概念

ざっくり基本概念を確認してください。

1. ProとPro+は個人アカウントで個別に契約できる（下図ではUser CとUser DがPro+を契約）
2. OrganizationはBusinessかEnterpriseか、いずれか一つの種類だけ割り当てられる
3. Organization内で任意の個人もしくはTeamにCopilotライセンスを割り当てられる（下図ではTeamだけだが、直接個人にも割当可能）
4. プレミアムリクエストは有効になっているライセンス1つ分のみが利用できる

# Q & A

## Pro+とBusiness両方持っていたらどうなるの？

Businessが有効になります。

Pro+の方がBusinessより高機能ですが、Pro+限定の機能は使えませんし、Business側で無効に設定された機能や言語モデルは利用できません。

Pro+の機能は一切使えません。契約は完全に無駄になります。

おそらく組織のガバナンスを優先するためだと思われます。

下図のUser CとUser Dは、いずれもPro+の契約をしています。

User CはBusiness側でCopilotが有効化されているので、Businessの機能しか使えません。

User DはPro+しか割り当てられていないので、すべてのリポジトリでPro+の機能が使えます。

```mermaid
flowchart TB
    subgraph Organization Enterprise

        subgraph Repository
            A1[Repository A-1]
            A2[Repository A-2]
        end

        subgraph Teams
            enable-copilot-a-1([Copilot 有効 Team])
            enable-copilot-a-2([Copilot 無効 Team])
        end

        style Repository fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
        style Teams fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    subgraph Organization Business

        subgraph RepositoryB
            B1[Repository B-1]
            B2[Repository B-2]
        end

        subgraph TeamsB[Teams]
            enable-copilot-b-1([Copilot 有効 Team])
            enable-copilot-b-2([Copilot 無効 Team])
        end

        style RepositoryB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
        style TeamsB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    UserC((User C（Pro＋）))
    UserD((User D（Pro＋）))

    UserC -.-> enable-copilot-b-1
    UserD -.-> enable-copilot-a-2
    UserD -.-> enable-copilot-b-2

    enable-copilot-a-1 -.-> A1
    enable-copilot-a-1 -.-> A2
    enable-copilot-a-2 -.-> A1
    enable-copilot-a-2 -.-> A2

    enable-copilot-b-1 -.-> B1
    enable-copilot-b-1 -.-> B2
    enable-copilot-b-2 -.-> B1
    enable-copilot-b-2 -.-> B2

```


## 同一リポジトリで、人によってBusinessとEnterpriseを使い分けられるの？

使い分けられます。

User AはEnterprise側でCopilotが有効になっており、User BはBusiness側で有効になっています。

このとき、User AはRepository B-1、B-2を使うときEnterpriseの権限で利用できます。

Copilot coding agentのようなEnterprise限定の機能も、Business側のOrganizationのリポジトリでも利用できます。

逆にUser Bは、Enterprise側のリポジトリを使う時でも、Businessの権限内でしか利用できません。

```mermaid
flowchart TB
    subgraph Organization Enterprise

        subgraph Repository
            A1[Repository A-1]
            A2[Repository A-2]
        end

        subgraph Teams
            enable-copilot-a-1([Copilot 有効 Team])
            enable-copilot-a-2([Copilot 無効 Team])
        end

        style Repository fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
        style Teams fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    subgraph Organization Business

        subgraph RepositoryB
            B1[Repository B-1]
            B2[Repository B-2]
        end

        subgraph TeamsB[Teams]
            enable-copilot-b-1([Copilot 有効 Team])
            enable-copilot-b-2([Copilot 無効 Team])
        end

        style RepositoryB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
        style TeamsB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    UserA((User A))
    UserB((User B))

    UserA -.-> enable-copilot-a-1
    UserA -.-> enable-copilot-b-2
    UserB -.-> enable-copilot-a-2
    UserB -.-> enable-copilot-b-1

    enable-copilot-a-1 -.-> A1
    enable-copilot-a-1 -.-> A2
    enable-copilot-a-2 -.-> A1
    enable-copilot-a-2 -.-> A2

    enable-copilot-b-1 -.-> B1
    enable-copilot-b-1 -.-> B2
    enable-copilot-b-2 -.-> B1
    enable-copilot-b-2 -.-> B2

```

## 一人にBusinessとEnterprise両方割り当てたらどうなる？

Enterpriseだけ有効になります。Businessは割り当て損です。

## Copilotが有効な人が、Copilotの無効なOrganizationを使ったらどうなるの？

有効になります。

別のOrganizationでBusinessもしくはEnterpriseを割り当てていても、個人でProやPro+を契約していても、有効なCopilotのライセンスがあれば、無効なOrganizationのリポジトリでも利用できます。

## おすすめの割当方法は？

2025年5月現在、Copilot割当用のOrganizationと、リポジトリ管理用のOrganizationを分けるのがおすすめです。

下図のような感じです。

こうすることでリポジトリへの権限の割当と、Copilotの割当の組み合わせを、任意に組み合わせることができます。

```mermaid
flowchart TB
    subgraph Organization Enterprise

        subgraph TeamsEnterprse[Teams]
            enable-copilot-enterprise([Copilot有効])
        end

        style TeamsEnterprse fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    subgraph Organization Business

        subgraph TeamsB[Teams]
            enable-copilot-business([Copilot有効])
        end

        style TeamsB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    subgraph Organization Domain A

        subgraph RepositoryA
            A1[Repository A-1]
            A2[Repository A-2]
        end

        subgraph TeamsDomainA[Teams]
            enable-copilot-a([Copilot無効])
        end

        style RepositoryA fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
        style TeamsDomainA fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    subgraph Organization Domain B

        subgraph RepositoryB
            B1[Repository B-1]
            B2[Repository B-2]
        end

        subgraph TeamsDomainB[Teams]
            enable-copilot-b([Copilot無効])
        end

        style RepositoryB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
        style TeamsDomainB fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
    end

    UserA((User A))
    UserB((User B))
    UserC((User C))
    UserD((User D))

    enable-copilot-a -.-> A1
    enable-copilot-a -.-> A2
    enable-copilot-b -.-> B1
    enable-copilot-b -.-> B2

    UserA -.-> enable-copilot-a
    UserB -.-> enable-copilot-a
    UserC -.-> enable-copilot-b
    UserD -.-> enable-copilot-b
    UserA -.-> enable-copilot-enterprise
    UserC -.-> enable-copilot-enterprise
    UserB -.-> enable-copilot-business
    UserD -.-> enable-copilot-business

```

Copilotの割当とリポジトリへの権限制御はOrganizationで分離するのが、個人的には一番おすすめです。

また、リポジトリ管理用のOrganizationも、何らかのドメイン単位でリポジトリをまとめたほうが良いと思います。[GitHub Copilot Spaces](https://github.blog/jp/2025-05-30-introducing-copilot-spaces-a-new-way-to-work-with-code-and-context/)を有効活用するにはドメイン単位でOrganizationを分け、リポジトリを分類するのが「おそらくは」良いと思います。GitHub Copilot Spacesは出たばかりなので、確実とは言いかねますが。

