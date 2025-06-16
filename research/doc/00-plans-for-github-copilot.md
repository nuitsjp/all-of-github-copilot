# GitHub Copilotのプラン比較

> 更新日: 2025年6月17日  
> 原文: [Plans for GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/plans-for-github-copilot)

## 概要

GitHubは、個人開発者から企業まで、ニーズに応じて複数のGitHub Copilotプランを提供しています。

## プラン一覧

### GitHub Copilot Free
- **対象**: 個人開発者（組織や企業のCopilotアクセスがない方）
- **料金**: 無料
- **特徴**: 限定的なCopilot機能へのアクセス、AIによるコーディング支援を無料で体験可能

### GitHub Copilot Pro
- **対象**: より柔軟性を求める個人開発者
- **料金**: 月額$10 USD または 年額$100 USD
- **特徴**: 
  - 無制限の補完機能
  - Copilot Chatでのプレミアムモデルへのアクセス
  - 月間プレミアムリクエスト許可量
  - 学生、教師、人気オープンソースプロジェクトのメンテナーは無料アクセス可能

### GitHub Copilot Pro+
- **対象**: AI パワーユーザー
- **料金**: 月額$39 USD または 年額$390 USD
- **特徴**:
  - Copilot Proの全機能
  - Copilot coding agent
  - より大きなプレミアムリクエスト許可量
  - Copilot Chatの全利用可能モデルへのフルアクセス

### GitHub Copilot Business
- **対象**: GitHub FreeまたはGitHub Teamプランの組織、GitHub Enterprise Cloudの企業
- **料金**: ユーザーあたり月額$19 USD
- **特徴**:
  - 組織メンバーの一元管理
  - Copilotポリシー制御

### GitHub Copilot Enterprise
- **対象**: GitHub Enterprise Cloudを使用する企業
- **料金**: ユーザーあたり月額$39 USD
- **特徴**:
  - Copilot Businessの全機能
  - Copilot coding agent
  - 追加のエンタープライズグレード機能

> **注意**: GitHub Enterprise Serverでは現在Copilotは利用できません。

## 機能比較表

### 基本情報
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **料金** | 無料 | $10/月 または $100/年 | $39/月 または $390/年 | $19/ユーザー/月 | $39/ユーザー/月 |
| **プレミアムリクエスト** | 50/月 | 300/月 | 1500/月 | 300/ユーザー/月 | 1000/ユーザー/月 |
| **無料体験** | - | 含む | 含む | 含む | 含む |

### エージェント機能
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **Copilot coding agent** | ❌ | ❌ | ✅ | ❌ | ✅ |
| **@github agent** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Code review agent** | VS Codeの"Review selection"のみ | ✅ | ✅ | ✅ | ✅ |
| **@workspace agent** | ✅ | ✅ | ✅ | ✅ | ✅ |

### チャット機能
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **チャットメッセージ** | 50メッセージ/月 | ベースモデルで無制限 | ベースモデルで無制限 | ベースモデルで無制限 | ベースモデルで無制限 |
| **IDE内チャット** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **GitHub.com内チャット** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **モバイルアプリ内チャット** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **CLI内チャット** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Copilot Extensions** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **スキル（IDE内）** | ❌ | ❌ | ✅ | ✅ | ✅ |
| **GitHub Modelsとの統合** | ❌ | ✅ | ✅ | ✅ | ✅ |

### モデル
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **Claude 3.5 Sonnet** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **GPT-4o** | ❌ | ✅ | ✅ | ✅ | ✅ |
| **GPT-4o mini** | ❌ | ✅ | ✅ | ✅ | ✅ |
| **o1-preview** | ❌ | ✅ | ✅ | ✅ | ✅ |
| **o1** | ❌ | ❌ | ✅ | ❌ | ✅ |
| **GitHub Models** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Gemini 1.5 Pro** | ❌ | ✅ | ✅ | ✅ | ✅ |
| **Azure OpenAI GPT-4o** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Azure OpenAI GPT-4o mini** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Claude 3.5 Haiku** | ❌ | ❌ | ✅ | ❌ | ✅ |
| **Gemini 1.5 Flash** | ❌ | ✅ | ✅ | ✅ | ✅ |
| **DeepSeek V3** | ❌ | ❌ | ✅ | ❌ | ✅ |
| **Mistral Large** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Meta Llama 3.1 405B** | ❌ | ✅ | ✅ | ✅ | ✅ |

### コード補完
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **IDE内コード補完** | 2000補完/月 | ✅ | ✅ | ✅ | ✅ |
| **マルチライン補完** | ✅ | ✅ | ✅ | ✅ | ✅ |

### カスタマイゼーション
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **カスタム指示** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Fine-tuned models** | ❌ | ❌ | ❌ | ✅ | ✅ |
| **Prompt files** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Copilot Extensions** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Indexing** | ❌ | ❌ | ❌ | ❌ | ✅ |
| **Knowledge bases** | ✅ | ✅ | ✅ | ✅ | ✅ |
| **Organization instructions** | ❌ | ❌ | ✅ | ✅ | ✅ |
| **Repository integration** | ❌ | ❌ | ✅ | ✅ | ✅ |

### その他の機能
| 機能 | Free | Pro | Pro+ | Business | Enterprise |
|------|------|-----|------|----------|------------|
| **Copilot in the CLI** | ❌ | ✅ | ✅ | ✅ | ✅ |
| **Pull request summaries** | ❌ | ❌ | ✅ | ✅ | ✅ |
| **Audit logs** | ❌ | ❌ | ❌ | ❌ | ✅ |
| **Content exclusion** | ❌ | ❌ | ❌ | ❌ | ✅ |
| **GitHub.comの統合** | ✅ | ✅ | ✅ | ✅ | ✅ |

## プラン選択ガイド

### 開始方法
各プランのリンク:
- **Copilot Free**: [無料で始める](https://github.com/copilot)
- **Copilot Pro**: [30日間無料体験](https://github.com/github-copilot/signup?ref_cta=Copilot+trial&ref_loc=about+github+copilot&ref_page=docs)
- **Copilot Pro+**: [Pro+を購読](https://github.com/github-copilot/signup?ref_cta=Copilot+Pro%2B&ref_loc=subscriptions+page&ref_page=docs)
- **Copilot Business**: [Business購読](https://github.com/github-copilot/purchase?priority=business&cft=copilot_li.copilot_plans.cfb)
- **Copilot Enterprise**: [Enterprise購読](https://github.com/github-copilot/purchase?priority=enterprise&cft=copilot_li.copilot_plans.ce)

## 重要な注意事項

> **プレミアムリクエストの課金について**  
> プレミアムリクエストの課金は近日開始予定です。それまでは追加のプレミアムリクエスト料金なしでCopilotプレミアムモデルを使用できます。最新の開始日については[About premium requests](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests)を参照してください。

## 参考リンク

- [GitHub Copilot features](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features)
- [About premium requests](https://docs.github.com/en/copilot/managing-copilot/monitoring-usage-and-entitlements/about-premium-requests)
- [Prototyping with AI models](https://docs.github.com/en/github-models/prototyping-with-ai-models)
- [Creating a custom model for GitHub Copilot](https://docs.github.com/en/enterprise-cloud@latest/copilot/managing-copilot/managing-github-copilot-in-your-organization/customizing-copilot-for-your-organization/creating-a-custom-model-for-github-copilot)