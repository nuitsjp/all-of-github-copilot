# Github Copilot Workspaceの感想 #生成AI - Qiita

[1](/ochtum/items/57dd1bbb645f4f9aa667/likers)

いいねしたユーザー一覧へ移動

1

[](https://b.hatena.ne.jp/entry/s/qiita.com/ochtum/items/57dd1bbb645f4f9aa667 "はてなブックマーク")

more\_horiz

記事を削除する

close

一度削除した記事は復旧できません。

この記事の編集中の下書きも削除されます。

削除してよろしいですか？

キャンセル削除するdelete

[

![](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fqiita-image-store.s3.ap-northeast-1.amazonaws.com%2F0%2F755626%2Fprofile-images%2F1746481229?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=48&s=ad2e5af703b9cfb531bc6798dc689118)

@ochtum(オクトゥム)](/ochtum)

# Github Copilot Workspaceの感想

-   [生成AI](/tags/%e7%94%9f%e6%88%90ai)
-   [GenerativeAI](/tags/generativeai)
-   [CopilotWorkspace](/tags/copilotworkspace)
-   [GitHubCopilotWorkspace](/tags/githubcopilotworkspace)
-   [GithubNext](/tags/githubnext)

投稿日 2024年11月15日

**＜本記事のターゲット層＞**

-   Github Copilot Workspaceに関心がある人
-   システム開発の効率化に関心がある人
-   開発者の将来に不安を感じている人

## [](#1%E3%81%AF%E3%81%98%E3%82%81%E3%81%AB)1.はじめに

今回、記事はあっさり目に書きます。なぜなら、Github Copilot Workspaceはもう少しプロンプトをいじくり倒したほうが良いだけではなく、Technical Previewなだけあって発展途上なため、手厚く書いたところでGAしたときには仕様が変わっている可能性が大いにあるからです。

とにかくお伝えしたいことは、開発者の将来は思ったより明るく、ただしいままで通りの時代ではなく、いままで以上に変化が早くなるということです。

## [](#2-github-copilot-workspace%E3%81%A8%E3%81%AF)2\. Github Copilot Workspaceとは？

[Github Copilot Workspace](https://github.blog/jp/2024-04-30-github-copilot-workspace/)とは、自然言語により、コードのブレインストーミング、計画、ビルド、テスト、実行を行うことができる機能です。

すでにGithubやVS CodeでGithub Copilotの性能を体感している人も多くいることでしょう。エラーの原因調査、コードのレビュー、提案、あるいは分からないことについて質問をしたり、ときにヒントをもらったり・・・一度体感してしまうを手放すことが難しいのではないでしょうか。

そうした能力をレポジトリやissueに対して発揮する機能、それがGithub Copilot Workspaceだと捉えて頂くとイメージが沸くと思います。

## [](#3-github-copilot-workspace%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%9F%E6%84%9F%E6%83%B3)3\. Github Copilot Workspaceを使った感想

まだ使い始めたばかりですが、想像していた通り、ただプロンプトを記述して実行してみても、構築したアプリケーションはそのままでは動きませんでした。

大したことないと思われますか？とんでもありません。

何某かを作り上げたいとき、最初をどのように構築すればよいか悩んだことはありませんか？

ある程度、最初の形を作ってくれるだけでも助かるものです。それに、問題があってもissueに登録して、そこからまたGithub Copilot Workspaceに頼むことでより完成度の高いものが出来上がります。

イチからコードを書くとどれだけ時間がかかるのか、調査する時間を含めると膨大な時間と労力を使うことは想像に難くありません。

**＜Github Copilot Workspaceダッシュボード＞**  
[![](https://qiita-user-contents.imgix.net/https%3A%2F%2Fstorage.googleapis.com%2Fzenn-user-upload%2F2f0b8441f9aa-20241115.jpg?ixlib=rb-4.0.0&auto=format&gif-q=60&q=75&s=3e61b2badea96cb87b4517d295ce5160)](https://qiita-user-contents.imgix.net/https%3A%2F%2Fstorage.googleapis.com%2Fzenn-user-upload%2F2f0b8441f9aa-20241115.jpg?ixlib=rb-4.0.0&auto=format&gif-q=60&q=75&s=3e61b2badea96cb87b4517d295ce5160)

**＜Github Copilot Workspaceで自動で作成されたレポジトリ＞**  
[![](https://qiita-user-contents.imgix.net/https%3A%2F%2Fstorage.googleapis.com%2Fzenn-user-upload%2Fea6803cd23a3-20241115.jpg?ixlib=rb-4.0.0&auto=format&gif-q=60&q=75&s=307db44429d663c50880e2db40bb18d2)](https://qiita-user-contents.imgix.net/https%3A%2F%2Fstorage.googleapis.com%2Fzenn-user-upload%2Fea6803cd23a3-20241115.jpg?ixlib=rb-4.0.0&auto=format&gif-q=60&q=75&s=307db44429d663c50880e2db40bb18d2)

**＜issueのGithub Copilot Workspaceボタン＞**  
[![](https://qiita-user-contents.imgix.net/https%3A%2F%2Fstorage.googleapis.com%2Fzenn-user-upload%2F1bb32313b745-20241115.jpg?ixlib=rb-4.0.0&auto=format&gif-q=60&q=75&s=e8a5dabefa42a358ce8114ce98ca9e5d)](https://qiita-user-contents.imgix.net/https%3A%2F%2Fstorage.googleapis.com%2Fzenn-user-upload%2F1bb32313b745-20241115.jpg?ixlib=rb-4.0.0&auto=format&gif-q=60&q=75&s=e8a5dabefa42a358ce8114ce98ca9e5d)

## [](#4-%E3%81%BE%E3%81%A8%E3%82%81)4\. まとめ

AIはいまのところ人に成り代わるものではなく、人の力を底上げするものであると感じています。Github CopilotやChat-GPT、Microsoft Copilotを使ったことがあればそこはお分かりいただけると思います。

Github Copilot Workspaceについても同様です。人間が一から考えて構築するのではなく、AIが支援してくれるのだと捉えて頂ければよいと思います。

これからの時代、出生数が大幅に減少し、労働人口が著しく減った時代に突入します。そうした時代においては、人を採用で増やすには限界があります。もちろん外国人労働者を雇うという手もありますが、それでも有限ですし、何より日本語が話せる人材を探す労力、またはこちらが相手の言語を話せる人材を探さなくてはいけません。

AIを活用することで、労働力を底上げするという設備投資の一環が生成AIを導入するということです。

生成AIの活用なくして仕事が回らない時代に突入しつつあることは、人手不足倒産が増加しつつあることでお分かり頂けると思います。

[1](/ochtum/items/57dd1bbb645f4f9aa667/likers)

いいねしたユーザー一覧へ移動

1

[comment0](#comments)

コメント一覧へ移動

[](https://b.hatena.ne.jp/entry/s/qiita.com/ochtum/items/57dd1bbb645f4f9aa667 "はてなブックマーク")

## @ochtumのピックアップ記事

### [メンタルの強弱とは？](https://qiita.com/ochtum/items/e8d8629c0c40a8fefd29)

1111いいね

-   [メンタル](/tags/%e3%83%a1%e3%83%b3%e3%82%bf%e3%83%ab)
-   [ストレス対策](/tags/%e3%82%b9%e3%83%88%e3%83%ac%e3%82%b9%e5%af%be%e7%ad%96)

2024年10月14日投稿日2024年10月14日

### [SESに戻ってみて感じたこと](https://qiita.com/ochtum/items/ae460d680e3ef70c031f)

5656いいね

-   [ses](/tags/ses)
-   [市場価値](/tags/%e5%b8%82%e5%a0%b4%e4%be%a1%e5%80%a4)
-   [働きがい](/tags/%e5%83%8d%e3%81%8d%e3%81%8c%e3%81%84)
-   [人生の充実](/tags/%e4%ba%ba%e7%94%9f%e3%81%ae%e5%85%85%e5%ae%9f)

2024年10月14日投稿日2024年10月14日

### [Githubを使ったObsidianの無料クラウドデータ化](https://qiita.com/ochtum/items/85eec6e0f2ee27a01767)

33いいね

-   [OneNote](/tags/onenote)
-   [Notion](/tags/notion)
-   [ナレッジグラフ](/tags/%e3%83%8a%e3%83%ac%e3%83%83%e3%82%b8%e3%82%b0%e3%83%a9%e3%83%95)
-   [Obsidian](/tags/obsidian)
-   [クラウドノート](/tags/%e3%82%af%e3%83%a9%e3%82%a6%e3%83%89%e3%83%8e%e3%83%bc%e3%83%88)

2025年05月17日投稿日2025年05月17日

[

![ochtum](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fqiita-image-store.s3.ap-northeast-1.amazonaws.com%2F0%2F755626%2Fprofile-images%2F1746481229?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=3449c67787662c7f5513c4bf51db48d6)

](/ochtum)

[

## @ochtum(オクトゥム)

](/ochtum)

SEやってます。 行動はガンガン行こうぜが基本です。

フォロー

[linkWeb](https://j-takeda.com/)[](https://github.com/ochtum)[](https://twitter.com/ochtum18)[rss\_feedRSS](/ochtum/feed)

trending\_up

## 今日のトレンド記事

[](https://qiita.com/tomada/items/efce0e3b3dfb033663ef)

[

![tomada](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fqiita-image-store.s3.ap-northeast-1.amazonaws.com%2F0%2F364501%2Fprofile-images%2F1727641866?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=f2e468d742d1a9b1f9c9d8508c613a0c)

](/tomada)

[@tomada(とまだ@Webエンジニア＆Udemy講師)](/tomada)in[Learning Next](/organizations/learningnext)

2025年06月16日

## [【AI駆動開発】Cursorを使いこなして1ヶ月でプログラミング学習サイトを作ったのでノウハウを伝えたい](https://qiita.com/tomada/items/efce0e3b3dfb033663ef)

[](https://qiita.com/nucomiya/items/05e262b633ec5f8747f9)

[

![nucomiya](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Flh3.googleusercontent.com%2Fa%2FACg8ocJZztTcjS-tQ0lH-sM7NBC_g4DwRpgE9dRgmdLk8nYY%3Ds96-c?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=51b231c23c5e4eb6b9f02936f02d64a3)

](/nucomiya)

[@nucomiya](/nucomiya)in[株式会社Nuco](/organizations/nuco-inc)

2025年06月16日

## [Cookieだけじゃない！Webの裏側で“あなたの行動”はこう見られている](https://qiita.com/nucomiya/items/05e262b633ec5f8747f9)

[flagアプリケーションのパフォーマンス最適化のTipsをシェアしよう！](https://qiita.com/official-events/16fbe2948367d399e185)[](https://qiita.com/Sakai_path/items/c51030f1291839025263)

[

![Sakai_path](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fqiita-image-store.s3.ap-northeast-1.amazonaws.com%2F0%2F2253716%2Fprofile-images%2F1749469663?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=8136b90ae29c90dc01813804facecca9)

](/Sakai_path)

[@Sakai\_path](/Sakai_path)

2025年06月17日

## [【C#】同じ機能、違う書き方 - パフォーマンスで選ぶべきコードはどっち？](https://qiita.com/Sakai_path/items/c51030f1291839025263)

[](https://qiita.com/q-1-p/items/1ef5b9e581d350f8d8c1)

[

![q-1-p](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fs3-ap-northeast-1.amazonaws.com%2Fqiita-image-store%2F0%2F3456603%2F9d8e3da29d8664fd5b8f337a8cbcbc88517b25cb%2Flarge.png%3F1732623700?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=fd72bc0cf2cb5d41c8013aacdc2f755e)

](/q-1-p)

[@q-1-p(U)](/q-1-p)in[JISOU | Reactプログラミングコーチング](/organizations/jisou)

2025年06月15日

## [【個人開発】契約中のサブスクリプションを管理できるサービスをリリースしました【Next.js×Neon×Clerk×Netlify】](https://qiita.com/q-1-p/items/1ef5b9e581d350f8d8c1)

[flagその他技術 Qiita Tech Festa 2025](https://qiita.com/official-events/373107c63dfb360f9d9b)[](https://qiita.com/shirok/items/a9b14c61fe8a1c02669a)

[

![shirok](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fqiita-image-store.s3.amazonaws.com%2F0%2F109087%2Fprofile-images%2F1532744149?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=008f6221acdf793429f08a5473e3fd5f)

](/shirok)

[@shirok(Shiro Kobayashi)](/shirok)in[日本オラクル株式会社](/organizations/oracle)

2025年06月18日

## [Oracle Alloy: Fujitsu クラウドサービス powered by Oracle Alloy へログインしてみてみた](https://qiita.com/shirok/items/a9b14c61fe8a1c02669a)

[トレンド一覧を見る](/trend)

関連記事 [Recommended by](https://www.logly.co.jp/privacy.html)

![](//cdn.logly.co.jp/recommend/s3-ap-northeast-1.amazonaws.com/dfeb01c6a08e73a79e9d898ecef855df.webp?1748754075&oe=png)

[GitHub Copilotとチームでモブプロしたいときにハマったこと（VSCode & LiveS...](https://qiita.com/jnymyk/items/42e67c027fac7a3c32bf) by jnymyk![](//b.logly.co.jp/abc?ac=06g_4A-9t6LzYok64lLxXw&pt=1&sp=4279494&st=https%3A%2F%2Fqiita.com&lg=similarity&wd=10662&rd=&ct=4)

![](//cdn.logly.co.jp/recommend/secure.gravatar.com/da4743d13b408091cff8768bba93215a.webp?1748856357&oe=jpeg)

[GitHub Copilot入門：コーディング補助とチャット機能の利用用途と使い分け](https://qiita.com/iret_takano/items/1ff86c506479f36c377f) by iret\_takano

![](//s3-ap-northeast-1.amazonaws.com/qiita-image-store/0/781232/6b432608f89030a1ece6c753e1463c3426d18cb7/x_large.png)

[Github Copilotを活用する上でのおさえておくべき特徴とTips](https://qiita.com/ryosuke-horie/items/39ba28294fc4bbfc8722) by ryosuke-horie

![](//cdn.logly.co.jp/recommend/s3-ap-northeast-1.amazonaws.com/40247933c957ce7546ac6e2e8662223e.webp?1748831279&oe=png)

[GitHub Copilotを上手に活用するために知っておきたいこと](https://qiita.com/yoda_naan/items/a5c53acc790586cd4fd9) by yoda\_naan

[電子帳票システムをお探しのIT担当者様向け資料を無料配布中！](https://dsp.logly.co.jp/click?ad=4AG4hpsDG-RLtEVJfizoZ7L4e1nsxQ76ddrJWtVY6-8aG8FkSsrySiQFBf09Le_ZrQKO9eeEyI1Rp-YJYutV5yUVLyUK378_LIy66fPAWQe7V_oWW-jz04gBK213RJIilZNV50aH8OkKMBLHrcfMnpAO7PCliQCDXrqglbKs9gIng2nkBGsw7D9lYYl1LVygka01flpbt-mTLrHBbmEsOqlhB725AfWhasO0FYgtYMB-10Xkp1n-5yuYUIIgEpMasSJESSCCOsOwDygHrPHH3umHSCLoApFNrRR2QA1Xwc8T-ci765KRS3fd3zPxP4gp8zozdx1iBCeK9qeXI2dKdI23r-MnCxHBMhxvBSnBbrPZIhdOua-DwN8GELyjbE8OFbcFQJGw_BXMRd_Hq80pFPDCcix4D4fdJrsNy2mq8WR2Pf4Esb2dMgyhr4ZYYEclRS_czrrNdEuqFw_HclCQH1WuoI0DNCNBz2Armpswfzq1Osc1NRremySVsr17Y7YBh3KF6odlZY29QcbbICXSEDJoRZP9kSMb) ![](//b.logly.co.jp/bc?ac=06g_4A-9t6LzYok64lLxXw&ad=4392519) PR 株式会社インテック

[「さくらのクラウド検定」に込めた国内DX人材育成に向けた思い](https://dsp.logly.co.jp/click?ad=4AG4hpsDG-RLtEVJfizoZ7L4e1nsxQ76Ywuf3yMJMgkM0NbbmMEGZOFTCdaUeTZwcl6Sb57yyuf0q9iZ-osZFRYNRO89MuMN5CICp6ZcHsr253CLO77T21NKB-JFtB6q8oFPcOEfUnQW5sXsWcIcgkcv8gKSimwVf5iIAfusnteRmjeWciyihoUblCsAPquuiN_kbN4y3S916_ymrtM7Etap72oXi5WPr2RU2TBxBGgoRLy5hxWpY92VOQsnqiCS4c8Ad0gUfNVOJoA4VCe3TpjiQwvfnIG3SbcRtjo1ha0QE1Vd4StqNlbwcU8YC8v3cN4waV2V0B72c0wIWcFwofhnXcBu5AHxIhPhnlE6iICzxTZ4NEfUaD4fyTEK5ALNJ930-L9QrA-zj-ukyNLYmmRyk5Zlp5pUtc2diJ7ayRghP7JXcnk6vUtD0ZTROwVS8uH7ZdrmI_Lw_2lUg0cQSTtjxc7dDqLUaGr4QMSGQCybRn3xAcFeIGzWrXGEU46Osv2fg3rJXzDSn20FHPyOOq6B8FJa6gulpV9FfWmrlWCuMvhG-MtIklmGNPoX5USgaKI5L-42AytIQRr3l993C09zYQuOgQvvmQsb0LoH6XdyerNX7k8hnQ) ![](//b.logly.co.jp/bc?ac=06g_4A-9t6LzYok64lLxXw&ad=4433004) PR さくらインターネット株式会社

## コメント

この記事にコメントはありません。

![](https://qiita-user-profile-images.imgix.net/https%3A%2F%2Fqiita-image-store.s3.amazonaws.com%2F0%2F99262%2Fprofile-images%2F1477544324?ixlib=rb-4.0.0&auto=compress%2Cformat&lossless=0&w=128&s=3f3a90ff6917f0a910fbb5a39f79df3c)

コメントする

image

添付する画像を選択またはドラッグ&ドロップ

mood

絵文字を選択

---

[help](https://qiita.com/Qiita/items/c686397e4a0f4f11683d)

Markdownの書き方

プレビュー

[コミュニティガイドライン](https://help.qiita.com/ja/articles/qiita-community-guideline)に基づき、良識ある内容を心がけましょう。

アップロード可能なサイズ0B / 100MB

アップロード可能なサイズ

投稿する

## 記事投稿キャンペーン開催中

[![](https://qiita-official-contents.imgix.net/https%3A%2F%2Fs3-ap-northeast-1.amazonaws.com%2Fqiita-official-event-image%2F7fa8542652299ac822aeb499615412623a04f95b%2Foriginal.jpg%3F1747618020?ixlib=rb-4.0.0&auto=compress%2Cformat&s=d8c49e419f17881de478a3bd7f9ead83)](/official-events/47c5f176193772aa3e97)

[

### Flutter/Dartで〇〇してみた！

](/official-events/47c5f176193772aa3e97)

2025/06/17~2025/07/15

[詳細を見る](/official-events/47c5f176193772aa3e97)

[![](https://qiita-official-contents.imgix.net/https%3A%2F%2Fs3-ap-northeast-1.amazonaws.com%2Fqiita-official-event-image%2Fcc5d9703857e4eafcbda0f0fdd26a3292ac09d30%2Foriginal.jpg%3F1750120127?ixlib=rb-4.0.0&auto=compress%2Cformat&s=b69391cbec100be9cbf4ad9cec29af51)](/official-events/350f22416f0b85428b7a)

[

### 組織にとって特権アクセス管理（PAM）が重要な理由とは？

](/official-events/350f22416f0b85428b7a)

2025/06/17~2025/07/15

[詳細を見る](/official-events/350f22416f0b85428b7a)

[すべて見るarrow\_circle\_right](/official-events)

## Embedded Content

[![](https://tpc.googlesyndication.com/simgad/9987595304991418067)](https://googleads.g.doubleclick.net/pcs/click?xai=AKAOjss9a2Lva1Zb3oiN24rE8PIc_KkBleBGv95sDD2zoVPJMAy_UMGAiZVm9y9N0OQ411tms1nSrfN7qJGgudxcROV3DRApuxPk67i2sNqONEctVccb6aYEqucIQ2FkFkpdGSc76Ni3t1cTeViGCIcXjxMZX6erOrBj7Qyvmme15F93X10whU3pcityJmMLNHEJr7OORl1MlITDbqIJ19GpKJPvOqadkPiS9hl_BKGSpdxh-XfdF7oEL3Qb_8Tutb9y3v5wJ-XA3Pp03uM5c5Jrj-MgztAiuTHZHxaKXtLQTVgealSKro__VPnIZPjrd-llN-s6GXAzPOMptnX0TM0M4NJfzBR7ma-7jd-4bxbEwya0Gzkm5AXcMeTbfsf6LkhaLsRGJ3E8-E75zIxAlKFWsdGrk14vaqHXgnp6IxU8FYb2OM-1-M8KpQ&sai=AMfl-YRnBxR6uk1qKNjUKhftDWPF19SPM3dvaFDAm8f6wATaILG9lckaSQ-XUruRNGbBm8opGWzDaCyVnwKcjX_K_iMtUw3m6BGvs3P984nAVokN&sig=Cg0ArKJSzL_Z2jKc22Zw&fbs_aeid=%5Bgw_fbsaeid%5D&adurl=https://qiita.com/official-events/16fbe2948367d399e185)

![](//www.google.com/ads/measurement/l?ebcid=ALh7CaQMHTCb75F6-rI94ey1t3Sz0Nx-DF0y5iXFTu-K6pMQiGUgJ2MGkKmCZfUum-1efcIl2bxO)

---

[![](https://tpc.googlesyndication.com/simgad/1448943587029906146)](https://googleads.g.doubleclick.net/pcs/click?xai=AKAOjsswKNQRxaiplSk5VXDiMiyFfYaUjM52XK3xz6EKN3E23v9VzJIyFZTtQAcyoXUPc5dAbJFJcs-lqFg23kY-nfJ3ZbHI3z1tABXBmmfa1jathHZcfUo8w9P7J3efB6ZUDcxJ_qu33VBW9XE3sUuJvdRdNTah8xyhO13UYUdwQsq81xpLW0cavysBLXOvAIugfmJDR_S251sb16rYwqkV6HXSg4xNwizhrbM6Ks8t9XnPUUUNR_KZ11cFtplNgLHHHBzQhMmeE0V3SLi_mNIdCZrMmEBESeKJcTIcqF3nYj4sk7YjDHn7iKjHpJianI1u-026mEQuLKV5lp2rJTcmz8Pxrm79Pqjw6LaG7RYfBV0gsHgOYJxdR6cY_Xvgpx3hiq2cKqz8yvT8c8LE2SBOilAiIjNk18dHAQyVg-lRC3UJiMyuPQ&sai=AMfl-YT1TUoXL2wweRF8JZccykB8yHZ1Ba84EntRHsBnRxq7IronwbIXPNOYSghvYDAKDaODdarYKjw1PiBJnG_VozO74ZpHPZTPvS5rIDyXWTnp&sig=Cg0ArKJSzA-Er_Pd0o9b&fbs_aeid=%5Bgw_fbsaeid%5D&adurl=https://increments.connpass.com/event/351027/)

![](//www.google.com/ads/measurement/l?ebcid=ALh7CaQdoT5joQmYBBcXD8Eq_tqXGBi-l9svuT7zKqCUEl7wdqZ1-ineFwv97oH1ZuCZ2_367LRn)

---

---

<iframe height="0" width="0" src="https://www.googletagmanager.com/static/service_worker/5690/sw_iframe.html?origin=https%3A%2F%2Fqiita.com" style="display: none; visibility: hidden;"></iframe>

---

---

---

---