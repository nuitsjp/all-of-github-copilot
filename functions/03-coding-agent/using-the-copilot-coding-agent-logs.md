# Copilot エージェントログ活用 学習マニュアル

## 学習時間
**約30分**

## 学習目標
- セッションログの見方を理解する
- Copilotの思考プロセスを読み解く
- 効果的なセッション管理方法を習得する
- デバッグとトラブルシューティング技術を身につける

## 理論学習: セッションログの概念 (10分)

### セッションログとは
Copilot coding agentが作業する際の内部プロセスを可視化したリアルタイムログ

### ログで確認できる内容
1. **内部モノローグ**: Copilotの思考過程
2. **ツール使用**: 実行されたコマンド・操作
3. **ファイル探索**: リポジトリ内の調査活動
4. **変更実施**: コード修正の詳細
5. **検証作業**: テスト・ビルドの実行

### ログ確認のタイミング
- **進捗確認**: 作業が順調に進んでいるか
- **方向性確認**: 期待通りのアプローチか
- **問題診断**: エラーや停止の原因調査
- **学習目的**: Copilotの作業方法理解

## 実践学習1: ログアクセスと基本操作 (10分)

### セッションログへのアクセス
1. Copilotが作成したPull requestを開く
2. PRタイムラインで **View session** ボタンをクリック
3. セッションログビューアーが新しいタブで開く

### ログビューアーの画面構成

```
┌─────────────────────────────────────────┐
│ Session Log Viewer                      │
├─────────────────────────────────────────┤
│ [Stop session] [Filter] [Export]       │
├─────────────────────────────────────────┤
│ 🤖 Analyzing the issue...              │
│ 📁 Exploring repository structure      │
│ 💭 Planning implementation approach    │
│ ⚙️  Running: npm test                   │
│ ✅ Tests passed                        │
│ 📝 Writing code changes...             │
│ 🔄 Committing changes                  │
└─────────────────────────────────────────┘
```

### 基本操作の練習
```markdown
# 学習用Issue作成
タイトル: Add email validation utility

説明:
EmailValidatorクラスを作成してください：
- IsValidEmail(string email)メソッド
- 基本的なメール形式チェック
- null/empty対応
- 単体テスト作成
```

1. Issueを作成してCopilotに割り当て
2. セッション開始を確認
3. ログビューアーでリアルタイム監視

## 実践学習2: ログ内容の解読 (10分)

### 典型的なログエントリの理解

#### 1. 初期分析フェーズ
```
🤖 I need to analyze the issue and understand what's required.

The issue asks me to create an EmailValidator class with:
- IsValidEmail(string email) method  
- Basic email format validation
- Null/empty handling
- Unit tests

Let me start by exploring the project structure.
```

**解読ポイント**: Copilotが要件を正しく理解しているか確認

#### 2. リポジトリ探索フェーズ
```
📁 Exploring project structure...

🔍 Found these relevant files:
- src/StringUtilities.cs (similar utility class)
- tests/StringUtilitiesTests.cs (test examples)
- UtilityLibrary.csproj (project configuration)

I'll follow the same patterns used in StringUtilities.
```

**解読ポイント**: 既存パターンの認識と一貫性の確保

#### 3. 実装計画フェーズ
```
💭 Planning implementation:

1. Create EmailValidator.cs in src/ directory
2. Implement IsValidEmail with regex pattern
3. Add null/empty validation  
4. Create EmailValidatorTests.cs in tests/
5. Add test cases for various scenarios
6. Run tests to verify functionality
```

**解読ポイント**: アプローチが適切か、段階的計画の妥当性

#### 4. ツール実行フェーズ
```
⚙️ Running: dotnet build
✅ Build successful

⚙️ Running: dotnet test  
❌ Test failed: 'System.Text.RegularExpressions' namespace not found

💭 I need to add using statement for regex functionality.
```

**解読ポイント**: エラー対応能力と問題解決プロセス

#### 5. 検証・修正フェーズ
```
🔄 Fixing namespace issue...

📝 Updated EmailValidator.cs:
- Added using System.Text.RegularExpressions;
- Refined email regex pattern
- Improved error handling

⚙️ Running: dotnet test
✅ All 5 tests passed
```

**解読ポイント**: 反復改善と品質確保プロセス

## 高度な活用技術

### ログパターンによる品質予測

#### 良いセッションの特徴
```
✅ 良いパターン:
🤖 Clear understanding of requirements
📁 Thorough project exploration  
💭 Logical implementation plan
⚙️ Frequent testing and validation
🔄 Error correction and improvement
```

#### 問題のあるセッションの特徴
```
⚠️ 注意が必要なパターン:
❌ Misunderstanding of requirements
🔄 Repeated failed attempts
❌ No testing validation
⚠️ Inconsistent with project patterns
❌ Excessive trial and error
```

### セッション停止の判断

#### 停止すべき状況
```markdown
以下の場合はセッションを停止:

1. **方向性の誤り**
   - 要件を誤解している
   - 不適切なアプローチを選択

2. **技術的な行き詰まり**  
   - 同じエラーを繰り返す
   - 無限ループ状態

3. **要件変更**
   - 元のタスクが不要になった
   - 優先度が変更された
```

#### 停止操作の実践
1. セッションログで **Stop session** をクリック
2. 停止理由を記録（学習目的）
3. 必要に応じて新しいIssueで再開

## デバッグとトラブルシューティング

### よくある問題パターン

#### パターン1: ビルドエラーの連続
```
❌ Build failed: missing dependency
🔄 Attempting to install package...
❌ Installation failed: permission denied
🔄 Trying alternative approach...
❌ Still failing...
```

**対処法**: 
- カスタム指示でビルド手順を明確化
- 依存関係を事前にドキュメント化

#### パターン2: テスト失敗の繰り返し
```
❌ Tests failed: assertion error
🔄 Modifying test logic...
❌ Tests still failing...
🔄 Changing implementation...
```

**対処法**:
- PRコメントで具体的なテスト要件を指定
- 既存テストパターンの参照を追加

#### パターン3: 無関係な変更
```
📝 Modified unrelated file: GlobalConfig.cs
📝 Added unnecessary dependency: NewtonSoft.Json
🔄 Refactoring entire class structure...
```

**対処法**:
- より具体的な要件定義
- 変更対象ファイルの明示

## 実践演習

### 演習1: ログ解読実践
1. 複雑なタスクでCopilotを動作させる
2. ログを逐次確認し、各フェーズを記録
3. 問題発生時の対処プロセスを分析

### 演習2: セッション管理実践
1. 意図的に曖昧なタスクを与える
2. 方向性の誤りを早期発見
3. 適切なタイミングでセッション停止

### 演習3: 品質改善実践
1. ログパターンから品質予測
2. 問題の早期発見と対処
3. より良い要件定義の作成

## 理解度チェック

### 質問1: セッション停止すべきタイミングは？
A) 最初のエラーが発生した時
B) 方向性が明らかに間違っている時
C) テストが1回失敗した時  
D) 作業開始から5分経過した時

### 質問2: ログで確認すべき重要な要素は？
A) 実行時間のみ
B) エラーメッセージのみ
C) 要件理解度と実装アプローチ
D) コミット数のみ

## ベストプラクティス

### 効果的なログ活用
1. **リアルタイム監視**: 長時間タスクでの進捗確認
2. **パターン学習**: 成功・失敗パターンの蓄積
3. **早期介入**: 問題の早期発見と対処
4. **品質予測**: ログパターンからの品質判断

### チーム内での活用
1. **ベストプラクティス共有**: 良いログパターンの共有
2. **問題事例の蓄積**: トラブルシューティング事例
3. **要件定義改善**: ログから学ぶ効果的な指示方法
4. **品質基準設定**: 受け入れ可能なログパターン

## 次のステップ
- [Pull requestレビューの実践](reviewing-a-pull-request-created-by-copilot.md)
- [トラブルシューティング技術](troubleshooting-copilot-coding-agent.md)

## 学習記録
セッションログ分析の結果：
- 確認したセッション数: 
- 発見したパターン: 
- 停止が必要だった事例: 
- 改善のポイント: 
