# Copilot Pull Request作成依頼 実践学習マニュアル

## 学習時間
**約30分**

## 学習目標
- Copilot ChatからのPR作成依頼方法を習得する
- 各IDE・プラットフォームでの使い方を理解する
- 効果的なプロンプト作成技術を学ぶ
- 作業進捗の監視方法を身につける

## 理論学習: Pull Request作成の基本概念 (10分)

### Copilot ChatからのPR作成とは
Issue割り当てとは異なり、チャットプロンプトから直接Pull requestを作成依頼する機能

### 適用シーン
- 現在の作業中に気づいた改善点
- 緊急性の低い修正作業
- 実験的な機能追加
- ドキュメント更新

### Issue割り当てとの違い
| 機能 | Issue割り当て | Chat PR作成 |
|------|-------------|-------------|
| 開始点 | GitHub Issue | Copilot Chat |
| 追跡性 | Issue管理 | PR単体 |
| 詳細記述 | Issue説明文 | チャットプロンプト |
| 適用場面 | 計画的タスク | 即座の改善 |

## 実践学習1: VS Codeでの実践 (10分)

### 事前準備
学習用プロジェクトを準備：

```csharp
// filepath: src/StringUtilities.cs
using System;

namespace UtilityLibrary
{
    public class StringUtilities
    {
        public static bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }
        
        // TODO: 他の文字列ユーティリティメソッドが必要
        // - 先頭・末尾の空白除去
        // - 大文字・小文字変換
        // - 文字列の逆順
    }
}
```

### ステップ1: VS Code Copilot Chat使用
1. VS CodeでCopilot Chatを開く（Ctrl+Shift+I）
2. 関連するコードファイルを開いた状態で実行

### 効果的なプロンプト例

```
@github Create a PR to add string trimming utilities

StringUtilitiesクラスに以下のメソッドを追加してください：

1. TrimStart - 先頭の空白文字を除去
2. TrimEnd - 末尾の空白文字を除去  
3. TrimBoth - 先頭・末尾両方の空白文字を除去

要件：
- 引数のnullチェックを実装
- 適切なXMLドキュメントコメント
- 単体テストも追加
```

### ステップ2: 結果確認
- Copilotからの応答でPRリンクを確認
- GitHub上でPRの内容を確認
- 自動作成されたブランチ名を確認

## 実践学習2: GitHub.comでの実践 (5分)

### GitHub.com Copilot Chat使用
1. リポジトリページでCopilot Chatアイコンをクリック
2. `@github`メンションは不要

### プロンプト例
```
Create a PR to add reverse string functionality

StringUtilitiesクラスにReverseメソッドを追加：
- 文字列を逆順にして返す
- null/empty文字列の適切な処理
- 単体テストを含める
```

## 実践学習3: JetBrains IDEでの実践 (5分)

### IntelliJ/Rider使用
1. Copilot Chatウィンドウを開く
2. `@github`メンションが必要

### プロンプト例
```
@github Create a PR to add case conversion methods

以下のメソッドをStringUtilitiesに追加：
- ToUpperSafe: 安全な大文字変換（null対応）
- ToLowerSafe: 安全な小文字変換（null対応）
- ToTitleCase: タイトルケース変換

各メソッドのテストも作成してください。
```

## 高度な技術: 効果的なプロンプト作成

### コンテキスト指定の活用
```
@github Create a PR to improve error handling

現在選択中のCalculator.Divideメソッドの例外処理を改善：

[コード選択状態で実行]

改善内容：
- ゼロ除算時のカスタム例外
- 引数検証の強化
- 適切なエラーメッセージ
```

### 段階的な指示
```
@github Create a PR for logging infrastructure

Step 1: ILoggerインターフェースを定義
Step 2: ConsoleLoggerの実装
Step 3: 既存のCalculatorクラスにロガー統合
Step 4: ログレベル（Debug, Info, Error）の実装

各ステップに対応する単体テストも追加
```

### ファイル指定の明確化
```
@github Create a PR to refactor configuration

対象ファイル：
- appsettings.json: 新しい設定項目追加
- ConfigurationService.cs: 設定読み込みクラス作成
- Program.cs: DI設定の追加

設定項目：
- DatabaseConnectionString
- LogLevel
- FeatureFlags
```

## 進捗監視とセッション管理

### セッションログの確認
1. 作成されたPRで **View session** をクリック
2. リアルタイムでCopilotの作業状況を確認
3. 必要に応じて **Stop session** で中断

### セッション停止の判断基準
- 期待と異なる方向に進んでいる
- プロンプトに不備があった
- 要件が変更になった
- 作業が複雑すぎることが判明

## トラブルシューティング

### よくある問題と対処法

#### 問題1: "PR作成できません"エラー
**原因と対処**:
- Copilot coding agentが無効: 設定確認
- `@github`メンション不足: IDE依存の要件確認
- 権限不足: リポジトリ書き込み権限確認

#### 問題2: 不完全なPRが作成される
**対処法**:
- より具体的なプロンプトで再依頼
- PRコメントで追加要件を指定
- セッションログで問題箇所を特定

#### 問題3: 期待と異なるコードが生成される
**改善方法**:
- コードコンテキストを明確に選択
- カスタム指示ファイルを活用
- ステップバイステップの指示

## 実践演習

### 演習1: 基本的なPR作成
以下の要件でPRを作成：

```
@github Create a PR to add input validation helper

ValidationHelperクラスを新規作成：
- IsValidEmail(string email): メール形式検証
- IsValidPhoneNumber(string phone): 電話番号検証
- IsPositiveNumber(int number): 正数検証

各メソッドの単体テストも含める
```

### 演習2: 既存コード改善のPR
```
@github Create a PR to add exception handling

[Calculator.csを選択した状態で]

全メソッドに以下を追加：
- 引数のnull/範囲チェック
- カスタム例外クラス作成
- try-catchブロックの適切な実装
```

### 演習3: ドキュメント更新のPR
```
@github Create a PR to update project documentation

README.mdを更新：
- プロジェクト概要の改善
- インストール手順の詳細化
- 使用例のコードサンプル追加
- ライセンス情報の明記
```

## 理解度チェック

### 質問1: IDEごとの`@github`メンションルール
A) 全IDEで必須
B) VS Code/Visual Studio/JetBrainsで必須、GitHub.comでは不要
C) GitHub.comでのみ必須
D) 全IDEで不要

### 質問2: PR作成依頼に適さないタスクは？
A) バグ修正
B) 大規模アーキテクチャ変更
C) ドキュメント更新
D) 単体テスト追加

## ベストプラクティスまとめ

### 効果的なプロンプト作成
1. **具体的な要件**: 曖昧な表現を避ける
2. **コンテキスト提供**: 関連コードの選択
3. **段階的指示**: 複雑なタスクは分割
4. **受け入れ基準**: 明確な完了条件

### 作業効率化
1. **カスタム指示活用**: `.github/copilot-instructions.md`
2. **テンプレート化**: 頻繁な依頼パターンの標準化
3. **適切な粒度**: 1PR = 1機能の原則
4. **レビュー前提**: 人間によるコードレビューは必須

## 次のステップ
- [エージェントログの詳細活用](using-the-copilot-coding-agent-logs.md)
- [Pull requestレビューの実践](reviewing-a-pull-request-created-by-copilot.md)

## 学習記録
今回の実践で作成したPRとその評価：
- PR#1: 
- PR#2: 
- 気づき: 
- 改善点: 
