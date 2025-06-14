# 学習マニュアル: GitHub Copilot CLI の使用方法

## 学習目標
このマニュアルを完了すると、以下のことができるようになります：
- GitHub Copilot CLI の基本的な使用方法を理解する
- コマンドラインでの効率的な作業方法を身につける
- Copilot を活用したコマンド作成と説明取得ができる

## 前提知識
- 基本的なコマンドライン操作
- GitHub アカウントの保有
- GitHub Copilot のライセンス

## 学習内容

### 1. 環境準備 (15分)

#### 必要なツールの確認
1. **GitHub CLI のインストール確認**
   ```shell
   gh --version
   ```

2. **Copilot CLI 拡張機能のインストール**
   ```shell
   gh extension install github/gh-copilot
   ```

3. **認証確認**
   ```shell
   gh auth status
   ```

#### 演習 1: セットアップ確認
以下のコマンドを実行して、正常にインストールされているか確認してください：
```shell
gh copilot --help
```

### 2. コマンド説明機能の活用 (20分)

#### 基本的な使用方法
```shell
gh copilot explain "コマンド"
```

#### 実践演習 2: コマンドの理解
以下のコマンドについて説明を求めてみましょう：

1. **基本的なコマンド**
   ```shell
   gh copilot explain "ls -la"
   ```

2. **システム管理コマンド**
   ```shell
   gh copilot explain "sudo systemctl restart nginx"
   ```

3. **ネットワークコマンド**
   ```shell
   gh copilot explain "netstat -tuln"
   ```

#### チャレンジ演習
普段使わないコマンドを5つ選んで、Copilot に説明を求めてみてください。

### 3. コマンド提案機能の活用 (25分)

#### 基本的な使用方法
```shell
gh copilot suggest "やりたいこと"
```

#### 実践演習 3: コマンド提案
以下のタスクについてコマンドを提案してもらいましょう：

1. **ファイル操作**
   ```shell
   gh copilot suggest "Find all .log files larger than 100MB"
   ```

2. **プロセス管理**
   ```shell
   gh copilot suggest "Kill all processes containing 'node'"
   ```

3. **Git操作**
   ```shell
   gh copilot suggest "Create a new branch and switch to it"
   ```

#### 対話型セッションの活用
Copilot との対話を通じて、より具体的な提案を得る方法を学びます。

### 4. 実践的なワークフロー (30分)

#### シナリオベース演習

**シナリオ 1: ログ解析**
1. 「過去1時間のエラーログを検索したい」
2. Copilot に提案を求める
3. 提案されたコマンドを実行する

**シナリオ 2: システム監視**
1. 「CPUとメモリの使用状況を監視したい」
2. 複数の提案から最適なものを選択
3. 結果を理解する

**シナリオ 3: ファイル整理**
1. 「古いファイルを自動的に削除したい」
2. 安全なコマンドの確認
3. テスト実行

#### グループ演習（推奨）
チームで以下のタスクに取り組んでください：
1. 各自が異なるタスクについてCopilotに相談
2. 提案されたコマンドをチーム内で共有
3. より良い解決策を議論

### 5. エイリアス設定と効率化 (15分)

#### ghcs エイリアスの設定
```shell
# bashの場合
echo 'alias ghcs="gh copilot suggest"' >> ~/.bashrc
echo 'alias ghce="gh copilot explain"' >> ~/.bashrc
source ~/.bashrc
```

#### 演習 4: エイリアスの活用
設定したエイリアスを使って、以下を試してください：
```shell
ghcs "Backup a directory to a tar.gz file"
ghce "tar -czf"
```

### 6. トラブルシューティングとベストプラクティス (10分)

#### よくある問題と解決策
1. **認証エラー**: `gh auth refresh`
2. **拡張機能の更新**: `gh extension upgrade gh-copilot`
3. **権限不足**: organization の設定確認

#### ベストプラクティス
- 提案されたコマンドは実行前に必ず確認
- 重要なシステム操作は段階的に実行
- フィードバック機能を積極的に活用

## 評価とフィードバック

### 自己評価チェックリスト
- [ ] Copilot CLI の基本コマンドを理解した
- [ ] explain 機能を効果的に使用できる
- [ ] suggest 機能で実用的な提案を得られる
- [ ] エイリアスを設定して効率化できる
- [ ] 安全性を考慮してコマンドを実行できる

### 実践課題
以下の課題に取り組んで、学習を深めてください：

1. **日常タスクの自動化**
   - 自分の作業でよく行うタスクをCopilotに相談
   - より効率的な方法を見つける

2. **新しい技術の学習**
   - 知らないコマンドやツールについて説明を求める
   - 実際に試してみる

3. **チーム共有**
   - 便利な提案をチームメンバーと共有
   - ベストプラクティスを蓄積

## 次のステップ
- [CLI での GitHub Copilot の構成](https://docs.github.com/ja/copilot/github-copilot-in-the-cli/configuring-github-copilot-in-the-cli)
- より高度なワークフローの構築
- 他の Copilot 機能との連携

## リソース
- [Copilot CLI 拡張機能 README](https://github.com/github/gh-copilot)
- [GitHub CLI 公式ドキュメント](https://cli.github.com/)
- [コミュニティフォーラム](https://github.com/github/gh-copilot/discussions)

---
**注意**: このマニュアルは実践的な学習を重視しています。各演習は実際に手を動かして体験することで、より深い理解が得られます。
