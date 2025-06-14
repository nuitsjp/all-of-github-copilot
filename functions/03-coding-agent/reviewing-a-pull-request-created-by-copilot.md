# Copilot作成PR レビュー実践 学習マニュアル

## 学習時間
**約30分**

## 学習目標
- Copilotが作成したPRの適切なレビュー方法を習得する
- 効果的なコメントでの反復改善を実践する
- GitHub Actionsワークフローの承認方法を理解する
- フィードバック機能の活用方法を学ぶ

## 理論学習: PRレビューの基本原則 (10分)

### Copilot作成PRレビューの特徴
- **人間開発者と同じレビュープロセス**: マージ前の十分な確認が必要
- **反復改善**: コメントでの追加指示が可能
- **権限管理**: 書き込み権限を持つユーザーのみが有効なコメント
- **自動承認制限**: PR作成者は自分のPRを承認できない

### レビューすべき観点
1. **機能要件の充足**: Issue要件との適合性
2. **コード品質**: 可読性、保守性、パフォーマンス
3. **セキュリティ**: 脆弱性や不適切な実装の確認
4. **テストカバレッジ**: 適切なテストの存在
5. **ドキュメント**: コメントやドキュメントの更新

## 実践学習1: 基本的なPRレビュー (10分)

### 事前準備
Copilotが作成したPRを開き、以下の確認を実施：

#### ステップ1: 全体構造の確認
```markdown
# レビューチェックリスト

## 基本確認
- [ ] 変更ファイル数が適切（過度に多くない）
- [ ] ブランチ名が`copilot/`で始まる
- [ ] コミットメッセージが明確
- [ ] PR説明がIssue要件と一致

## コード品質
- [ ] 命名規則の遵守
- [ ] エラーハンドリングの実装
- [ ] 重複コードの回避
- [ ] パフォーマンスへの配慮
```

#### ステップ2: 詳細コードレビュー
各変更ファイルで以下を確認：

```csharp
// 例: Calculator.cs のレビューポイント
public class Calculator
{
    // ✅ 確認ポイント: XMLドキュメントコメントの存在
    /// <summary>
    /// 二つの数値を除算します
    /// </summary>
    /// <param name="a">被除数</param>
    /// <param name="b">除数</param>
    /// <returns>除算結果</returns>
    /// <exception cref="ArgumentException">除数が0の場合</exception>
    public double Divide(double a, double b)
    {
        // ✅ 確認ポイント: 適切な例外処理
        if (b == 0)
            throw new ArgumentException("除数は0にできません", nameof(b));
            
        return a / b;
    }
}
```

#### ステップ3: テストの確認
```csharp
// 例: CalculatorTests.cs のレビューポイント
[Test]
public void Divide_ValidInputs_ReturnsCorrectResult()
{
    // ✅ 確認ポイント: AAA パターンの実装
    // Arrange
    var calculator = new Calculator();
    
    // Act
    var result = calculator.Divide(10, 2);
    
    // Assert
    Assert.AreEqual(5.0, result, 0.001);
}

[Test]
public void Divide_ZeroDivisor_ThrowsArgumentException()
{
    // ✅ 確認ポイント: 例外テストの実装
    var calculator = new Calculator();
    
    Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
}
```

## 実践学習2: 効果的なレビューコメント作成 (10分)

### バッチレビューの実践

#### 手順1: レビュー開始
1. PRページで **Start a review** をクリック
2. 複数のコメントを準備
3. 最後に **Submit review** で一括送信

#### 手順2: 具体的なコメント例

**✅ 良いコメント例**:
```markdown
このメソッドの引数検証を強化してください：
- `input`パラメータがnullの場合の処理を追加
- 空文字列の場合の動作も明確化
- 例外メッセージに具体的な説明を含める

例:
```csharp
if (string.IsNullOrEmpty(input))
    throw new ArgumentException("Input cannot be null or empty", nameof(input));
```
```

**❌ 避けるべきコメント例**:
```markdown
このコードを改善してください
```

#### 手順3: @copilot メンション活用
確実に応答させたい場合：
```markdown
@copilot この機能にロギングを追加してください：
- 処理開始時にInfo レベル
- エラー発生時にError レベル
- 処理時間の計測も含める
```

### コメントカテゴリ別の書き方

#### 1. バグ修正要求
```markdown
Line 45: null参照例外の可能性があります。
`user?.Name`のようにnull条件演算子を使用するか、
事前にnullチェックを追加してください。
```

#### 2. 機能追加要求
```markdown
このメソッドに入力検証を追加してください：
- 数値範囲チェック（0-100の範囲）
- null値の処理
- 適切な例外タイプの使用
```

#### 3. リファクタリング要求
```markdown
このロジックを別メソッドに分離してください：
- 責任の分離（SRP原則）
- テスタビリティの向上
- コードの再利用性向上
```

#### 4. テスト追加要求
```markdown
以下のテストケースを追加してください：
- 境界値テスト（int.MaxValue, int.MinValue）
- 無効な入力のテスト
- 並行処理時の動作テスト
```

## GitHub Actions ワークフロー管理

### ワークフロー承認の手順
1. PRの**Files changed**タブで変更を確認
2. 特に`.github/workflows/`への変更に注意
3. セキュリティリスクを評価
4. **Approve and run workflows**をクリック

### 承認前確認事項
```yaml
# .github/workflows/ への変更確認ポイント
name: CI Pipeline

on:
  pull_request:
    branches: [ main ]

jobs:
  test:
    runs-on: ubuntu-latest
    steps:
      # ❗ 確認: 外部アクションのバージョン固定
      - uses: actions/checkout@v4  # ✅ バージョン指定済み
      
      # ❗ 確認: シークレットへの不適切なアクセス
      - name: Deploy
        env:
          SECRET_KEY: ${{ secrets.SECRET_KEY }}  # ⚠️ 要確認
```

## フィードバック機能の活用

### フィードバック提供手順
1. PR本文またはコメントで👍/👎ボタンをクリック
2. 👎の場合、理由を選択：
   - Code quality issues
   - Missing functionality
   - Security concerns
   - Performance problems
3. 詳細コメントを追加（任意）
4. **Submit feedback**をクリック

### 効果的なフィードバック例
```markdown
【良いフィードバック】
理由: Code quality issues
コメント: XMLドキュメントコメントが不足している。
全てのpublicメソッドに説明を追加してほしい。

【悪いフィードバック】
理由: その他
コメント: よくない
```

## 実践演習

### 演習1: 総合レビュー実践
以下のシナリオでレビューを実施：

```markdown
# シナリオ: 電卓機能拡張PR
- 新機能: 平方根計算機能
- 対象ファイル: Calculator.cs, CalculatorTests.cs
- Issue要件: Math.Sqrt使用、負数入力時の例外処理

## レビュー課題
1. 実装が要件を満たしているか確認
2. エラーハンドリングの適切性をチェック
3. テストカバレッジの妥当性を評価
4. 改善提案を具体的にコメント
```

### 演習2: 反復改善プロセス
1. 初回レビューでコメント送信
2. Copilotの修正を確認
3. 追加の改善点を指摘
4. 最終承認までの流れを実践

## トラブルシューティング

### よくある問題と対処法

#### 問題1: Copilotがコメントに応答しない
**確認事項**:
- 書き込み権限の有無
- Copilotの割り当て状況
- コメント内容の具体性

**対処法**:
```markdown
@copilot メンションを明示的に追加して再度コメント
```

#### 問題2: 期待と異なる修正
**対処法**:
```markdown
より具体的な指示で再コメント：
- 期待する実装方法を明示
- コード例を含める
- ステップバイステップの指示
```

## 理解度チェック

### 質問1: バッチレビューの利点は？
A) コメント数を制限できる
B) Copilotが全コメントを同時に処理できる
C) レビュー時間を短縮できる
D) 承認が自動化される

### 質問2: GitHub Actionsワークフロー承認が必要な理由は？
A) Copilotの制限
B) セキュリティリスクの軽減
C) リソース使用量の管理
D) プロジェクト管理の要求

## ベストプラクティス

### 効果的なレビュー戦略
1. **段階的レビュー**: 全体→詳細の順序
2. **具体的コメント**: 改善方法を明示
3. **建設的フィードバック**: 学習機会の提供
4. **継続的改善**: フィードバック結果の活用

### チーム内でのレビュー標準化
1. **レビューガイドライン**: 共通基準の設定
2. **テンプレート活用**: 一貫したレビュー形式
3. **知識共有**: 良いレビュー事例の蓄積
4. **継続的改善**: プロセスの定期見直し

## 次のステップ
- [トラブルシューティング](troubleshooting-copilot-coding-agent.md)
- [カスタム指示の詳細活用](../customization/repository-instructions.md)

## 学習記録
今回レビューしたPRの評価：
- レビューしたPR数: 
- 発見した問題: 
- 改善提案数: 
- Copilotの対応評価:
