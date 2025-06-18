# Copilot Extensions 概要

## Copilot Extensions とは

Copilot Extensions は、GitHub Copilot Chat の機能を拡張するための仕組みです。GitHub App として構築され、サードパーティのサービスや独自の機能を Copilot Chat に統合できます。

## 主な種類

- **スキルセット**  
  軽量な統合方式。最大5つの関数（スキル）を定義し、外部APIやサービスと簡単に連携できます。プロンプト生成や関数呼び出しはプラットフォームが自動で処理します。

- **エージェント**  
  高度なカスタマイズが可能な統合方式。会話の流れや応答生成を独自に制御できます。複雑なワークフローや高度なAI連携に適しています。

## 仕組み

1. ユーザーが Copilot Chat でリクエストを送信
2. 拡張性プラットフォームが適切な拡張機能にルーティング
3. スキルセットの場合は関数呼び出し、エージェントの場合はカスタムロジックで処理
4. 結果を Copilot Chat に返却

## アクセスと権限

- 拡張機能ごとに必要なアクセス許可が異なります
- Organization リソースへのアクセスは管理者による許可が必要
- Marketplace で公開・非公開の選択が可能

## 用語

- **Copilot Extension**: Copilot Chat 機能を拡張する GitHub App
- **スキル/スキルセット**: Copilot で呼び出せる関数群
- **エージェント**: 独自ロジックを持つ拡張機能
- **Marketplace**: 拡張機能の公開・配布プラットフォーム

## 参考

- [Copilot 拡張機能の構築について](#)
- [スキルセットの例](https://github.com/copilot-extensions/skillset-example)
