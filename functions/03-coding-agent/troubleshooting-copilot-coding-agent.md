# Copilot Coding Agent トラブルシューティング 学習マニュアル

## 学習時間
**約30分**

## 学習目標
- よくある問題の診断方法を習得する
- 効果的な問題解決手順を学ぶ
- 予防的対策の実装方法を理解する
- エスカレーション手順を把握する

## 理論学習: トラブルシューティングの体系的アプローチ (10分)

### 問題分類とアプローチ

#### 1. アクセス・権限関連問題
- Copilotが選択肢に表示されない
- 機能が有効化されていない
- 権限不足エラー

#### 2. 動作・応答関連問題
- 割り当て後に反応がない
- コメントに応答しない
- セッションが停止する

#### 3. 品質・性能関連問題
- 期待と異なる実装
- CI/CDチェック失敗
- ビルドエラーの繰り返し

#### 4. セキュリティ・制限関連問題
- ファイアウォール警告
- 外部アクセス制限
- 機密情報の扱い

### 診断の基本手順
1. **現象の確認**: 何が起きているかの正確な把握
2. **環境の確認**: ライセンス、設定、権限の検証
3. **ログの確認**: セッションログやエラーメッセージの分析
4. **再現テスト**: 問題の一貫性確認
5. **対処実施**: 段階的な解決策の適用

## 実践学習1: アクセス・権限問題の解決 (8分)

### 問題1: Issue assigneesにCopilotが表示されない

#### 診断手順
```bash
# 1. 現在のライセンス確認
gh copilot status

# 2. APIでの確認
curl -H "Authorization: token YOUR_TOKEN" \
  https://api.github.com/repos/OWNER/REPO/assignees
```

#### 解決策チェックリスト
```markdown
## ライセンス確認
- [ ] GitHub Copilot Pro+ または Enterprise プラン
- [ ] サブスクリプションの有効性
- [ ] 組織への正しい割り当て

## 設定確認
- [ ] 個人設定でのcoding agent有効化
- [ ] Organization設定での許可
- [ ] リポジトリレベルでの有効化

## 権限確認
- [ ] リポジトリへの書き込みアクセス権限
- [ ] Organization メンバーシップ
- [ ] Enterprise ポリシー制限の有無
```

#### 段階的解決手順

**ステップ1: 基本設定確認**
```markdown
1. GitHub.com → Settings → Copilot
2. "Enable Copilot coding agent" チェック状況確認
3. Organization設定での許可状況確認
```

**ステップ2: GraphQL APIでの詳細確認**
```graphql
query {
  repository(owner: "YOUR_USERNAME", name: "YOUR_REPO") {
    suggestedActors(capabilities: [CAN_BE_ASSIGNED], first: 100) {
      nodes {
        login
        __typename
        ... on Bot {
          id
        }
      }
    }
  }
}
```

期待される結果: `copilot-swe-agent` の存在

**ステップ3: 権限レベルの確認**
```bash
# リポジトリ権限確認
gh api repos/OWNER/REPO/collaborators/USERNAME/permission
```

### 問題2: 機能の段階的ロールアウト問題

#### 対処法
```markdown
## 確認事項
- パブリックプレビュー機能のため段階的提供
- GitHub Statusページでの機能状況確認
- 地域・アカウント別の提供タイミング差

## 対応策
- 時間を置いて再確認
- GitHub Supportへの問い合わせ
- 代替手段での実装継続
```

## 実践学習2: 動作・応答問題の解決 (8分)

### 問題3: Copilotに割り当てたが反応がない

#### 診断チェックリスト
```markdown
## 即座確認事項
- [ ] ページリフレッシュ実施済み
- [ ] 👀 リアクションの有無確認
- [ ] 数分の待機時間経過済み
- [ ] ブラウザのキャッシュクリア

## 深度確認事項
- [ ] Issue内容の明確性
- [ ] 対象ファイルの存在確認
- [ ] リポジトリサイズの適切性
- [ ] 同時実行制限の確認
```

#### 解決手順

**ステップ1: 基本的な再試行**
```markdown
1. Issue右サイドバーで Assignees → Copilot再選択
2. 10-15秒待機してページリフレッシュ
3. 👀 リアクションとPRリンクの確認
```

**ステップ2: Issue内容の最適化**
```markdown
Issue説明の改善：
- 明確なタスク定義
- 具体的な受け入れ基準
- 対象ファイルの明示
- 技術的制約の記載
```

**ステップ3: 環境制限の確認**
```markdown
制限事項チェック：
- 同時実行PR数（1つまで）
- リポジトリサイズ制限
- ファイル数制限
- 複雑性レベル
```

### 問題4: コメントに応答しない

#### 診断フローチャート
```
コメントに応答しない
    ↓
書き込み権限確認
    ↓ No → 権限付与またはコラボレーター追加
    ↓ Yes
Copilotの割り当て状況確認
    ↓ Not assigned → Copilotを再割り当て
    ↓ Assigned
コメント内容の具体性確認
    ↓ 曖昧 → より具体的なコメントに修正
    ↓ 具体的
@copilot メンション追加
```

#### 効果的な対処法

**権限確認コマンド**
```bash
# コラボレーター権限確認
gh api repos/OWNER/REPO/collaborators/USERNAME/permission

# 期待される応答: "permission": "write" または "admin"
```

**強制応答コメント例**
```markdown
@copilot この機能の実装をお願いします：

1. 入力検証の追加
   - null チェック
   - 型チェック
   - 範囲チェック

2. エラーハンドリング
   - try-catch ブロック
   - 適切な例外タイプ
   - ログ出力

3. 単体テスト
   - 正常系テスト
   - 異常系テスト
   - 境界値テスト
```

## 実践学習3: 品質・性能問題の解決 (4分)

### 問題5: CI/CDチェック失敗

#### .github/copilot-instructions.md による予防的対策
```markdown
# プロジェクト設定

## ビルド要件
- .NET 8.0 必須
- パッケージ復元: `dotnet restore`
- ビルド: `dotnet build --configuration Release`
- テスト: `dotnet test --logger trx --collect:"XPlat Code Coverage"`

## 品質基準
- コードカバレッジ: 最低80%
- 静的解析: SonarQube ルール遵守
- セキュリティスキャン: 脆弱性ゼロ

## 必須チェック項目
1. ビルドエラーゼロ
2. 全テスト成功
3. リンターエラーゼロ
4. セキュリティ警告ゼロ
```

#### カスタム環境設定
```yaml
# copilot-setup-steps.yml
- name: Setup .NET
  uses: actions/setup-dotnet@v3
  with:
    dotnet-version: '8.0.x'

- name: Install dependencies
  run: |
    dotnet restore
    dotnet tool install --global dotnet-reportgenerator-globaltool

- name: Build and test
  run: |
    dotnet build --configuration Release
    dotnet test --logger trx --collect:"XPlat Code Coverage"
```

### 問題6: 期待と異なる実装品質

#### 段階的改善アプローチ
```markdown
## フェーズ1: 基本実装
@copilot 基本機能の実装をお願いします（品質は後回し）

## フェーズ2: 品質向上
@copilot 以下の品質改善を実施してください：
- エラーハンドリング強化
- 入力検証追加
- ログ機能実装

## フェーズ3: テスト追加
@copilot 包括的なテストスイートを追加してください

## フェーズ4: ドキュメント整備
@copilot XMLコメントとREADME更新をお願いします
```

## 高度なトラブルシューティング

### セッションログ分析による問題特定
```markdown
## ログパターン分析

### 成功パターン
✅ "Understanding the issue requirements..."
✅ "Exploring project structure..."
✅ "Planning implementation approach..."
✅ "Running tests to verify changes..."
✅ "All checks passed"

### 問題パターン
❌ "Unable to understand requirements" → Issue記述改善必要
❌ "Build failed repeatedly" → 環境設定問題
❌ "Test failures persist" → テスト設計問題
❌ "Timeout occurred" → タスク複雑性問題
```

### ファイアウォール制限への対処
```markdown
## ファイアウォール警告への対応

### 確認事項
- ブロックされたURL
- アクセス理由
- セキュリティリスク評価

### 対処選択肢
1. 制限受け入れ（推奨）
2. 一時的許可
3. カスタムファイアウォール設定
4. オフライン代替手段
```

## 予防的対策の実装

### プロジェクト設定の最適化
```markdown
# .github/copilot-instructions.md 最適化例

## 開発環境
- IDE: Visual Studio 2022
- Framework: .NET 8.0
- パッケージマネージャー: NuGet

## コーディング規約
- 命名: PascalCase for public, camelCase for private
- ドキュメント: 全publicメンバーにXMLコメント必須
- エラーハンドリング: ArgumentException for validation

## テスト戦略
- フレームワーク: xUnit
- モック: Moq
- カバレッジ目標: 80%以上
- 命名パターン: MethodName_Scenario_ExpectedResult
```

### 継続的監視の設定
```markdown
## 監視指標
- セッション成功率
- 平均完了時間
- コードレビュー品質
- CI/CD成功率

## アラート設定
- 連続失敗時の通知
- 長時間セッションの警告
- 品質指標低下の検知
```

## エスカレーション手順

### 内部エスカレーション
```markdown
## レベル1: セルフサービス
- ドキュメント確認
- 基本的なトラブルシューティング
- 設定見直し

## レベル2: チーム内相談
- 同僚への相談
- 社内ナレッジベース確認
- 過去事例の調査

## レベル3: GitHub Support
- 公式サポートチケット作成
- 詳細な問題情報提供
- 再現手順の文書化
```

### GitHub Support提出情報
```markdown
## 必要情報テンプレート
- Organization/Repository: 
- Copilot Plan: 
- 問題発生日時: 
- Issue/PR URL: 
- エラーメッセージ: 
- セッションログ: 
- 再現手順: 
- 期待される動作: 
- 環境情報: 
```

## 理解度チェック

### 質問1: Copilotが表示されない場合の最初の確認事項は？
A) セッションログ確認
B) ライセンス・権限確認
C) GitHub Support連絡
D) リポジトリ再作成

### 質問2: コメント応答がない場合の対処順序は？
A) @copilot メンション → 権限確認 → 再割り当て
B) 権限確認 → 割り当て確認 → @copilot メンション
C) 再割り当て → 権限確認 → @copilot メンション
D) GitHub Support → 権限確認 → @copilot メンション

## 学習記録
遭遇した問題と解決方法：
- 問題1: 
  - 症状: 
  - 原因: 
  - 解決策: 
- 問題2:
  - 症状: 
  - 原因: 
  - 解決策: 

## 次のステップ
- [カスタム環境設定](../customization/development-environment.md)
- [ファイアウォール設定](../customization/firewall-configuration.md)
