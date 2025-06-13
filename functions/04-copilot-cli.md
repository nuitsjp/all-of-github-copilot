# Copilot in the CLI 学習プラン

## 概要
- **機能名**: Copilot in the CLI
- **学習時間**: 15分
- **対象プラン**: Pro/Pro+/Business/Enterprise
- **対応環境**: ターミナル, Windows Terminal Canary

## 学習目標
- コマンドライン操作でのCopilot支援機能を理解する
- 実際のコマンド提案・説明機能を体験する
- 開発作業での活用シーンを把握する

## 実践内容

### 1. セットアップ確認 (3分)
```bash
# GitHub CLI のインストール確認
gh --version

# Copilot CLI 拡張の確認
gh extension list

# 必要に応じてインストール
gh extension install github/gh-copilot
```

### 2. コマンド提案機能 (7分)

**基本的な使用方法:**
```bash
# コマンド提案を依頼
gh copilot suggest

# 具体的な作業を自然言語で説明
# 例: "Gitで特定のファイルの変更履歴を確認したい"
# 例: "大きなファイルを見つけて削除したい"
# 例: "プロセスをポート番号で検索して終了したい"
```

**試すシナリオ:**
- Git操作の提案
- ファイル・ディレクトリ操作
- プロセス管理
- ネットワーク診断

### 3. コマンド説明機能 (5分)

```bash
# 複雑なコマンドの説明を依頼
gh copilot explain

# 例として以下のコマンドを説明させる
find . -name "*.cs" -exec grep -l "TODO" {} \;
git log --oneline --graph --decorate --all
netstat -tulpn | grep :80
docker run -d -p 8080:80 --name myapp nginx
```

## 確認ポイント
- [ ] 自然言語での要求が理解される
- [ ] 提案されるコマンドが適切
- [ ] 危険なコマンドに対する警告がある
- [ ] 複数の選択肢が提示される
- [ ] コマンドの説明が分かりやすい
- [ ] プラットフォーム固有の違いを理解している

## 活用シーン例
1. **新しいツールの学習**
   - 初めて使うCLIツールのコマンド提案
   
2. **複雑な一行コマンド**
   - find, grep, awk等の組み合わせ
   
3. **システム管理作業**
   - プロセス管理、ネットワーク診断
   
4. **Git操作**
   - 複雑なgitコマンドの生成

## デモ用メモ
- CLIに不慣れな人への支援効果
- ベテランエンジニアの作業効率化
- ドキュメント検索の代替手段として

## 次のステップ
- より複雑なシステム管理タスクでの検証
- 他のCLIツール（Docker, kubectl等）での活用確認
