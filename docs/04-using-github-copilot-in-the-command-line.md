# コマンドラインでのGitHub Copilot活用

## 概要

GitHub Copilotは、IDE内でのコード補完だけでなく、コマンドラインでも強力な支援を提供します。Copilot in the CLIを使用することで、コマンドの説明を受けたり、実行したいタスクに適したコマンドを提案してもらうことができます。

## 学習目標

この教材を完了すると、以下のことができるようになります：

- Copilot in the CLIを使用してコマンドの説明を取得する
- 自然言語でタスクを記述し、適切なコマンドの提案を受ける
- C#プロジェクトの開発でよく使うコマンドをCopilotの支援で効率的に実行する

## 前提条件

- GitHub Copilotへのアクセス権
- GitHub CLIがインストールされていること
- Copilot in the CLI拡張機能がインストールされていること

## セットアップ

1. GitHub CLIをインストールします（まだの場合）：
   ```shell
   # Windowsの場合（winget使用）
   winget install --id GitHub.cli
   
   # macOSの場合
   brew install gh
   ```

2. GitHub CLIで認証します：
   ```shell
   gh auth login
   ```

3. Copilot in the CLI拡張機能をインストールします：
   ```shell
   gh extension install github/gh-copilot
   ```

## 実習：C#プロジェクトでのCopilot活用

### シナリオ：新しいC#コンソールアプリケーションの作成と管理

#### 1. プロジェクトの作成

まず、Copilotにプロジェクト作成コマンドを提案してもらいましょう：

```shell
gh copilot suggest "Calculatorという名前のC#ソリューションの作り方"
```

Copilotは以下のようなコマンドを提案します：
```shell
dotnet new console -n Calculator
```

#### 2. よく使うコマンドの説明を取得

.NET CLIコマンドの詳細を理解したい場合：

```shell
gh copilot explain "dotnet build --configuration Release"
```

Copilotは、このコマンドがリリース構成でプロジェクトをビルドすることを説明してくれます。

#### 3. Gitコマンドの支援

変更をコミットしたい場合：

```shell
gh copilot suggest "Stage all changes and commit with a message about adding calculator logic"
```

提案されるコマンド：
```shell
git add .
git commit -m "Add calculator logic"
```

#### 4. 複雑なタスクの実行

テストカバレッジレポートを生成したい場合：

```shell
gh copilot suggest "Run C# unit tests with code coverage and generate HTML report"
```

提案されるコマンド例：
```shell
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
reportgenerator -reports:coverage.opencover.xml -targetdir:coveragereport -reporttypes:Html
```

### 実践演習

以下のタスクをCopilot in the CLIを使って実行してみましょう：

1. **NuGetパッケージの管理**
   ```shell
   gh copilot suggest "Add xUnit test framework to my C# project"
   ```

2. **ビルドエラーの解決**
   ```shell
   gh copilot explain "error CS0246: The type or namespace name 'System.Text.Json' could not be found"
   ```

3. **プロジェクトのクリーンアップ**
   ```shell
   gh copilot suggest "Clean all build artifacts and bin/obj folders in C# solution"
   ```

## 効率的な使い方のヒント

### 1. 具体的な説明を使う
より具体的な説明をすることで、より適切な提案を受けられます：

```shell
# 良い例
gh copilot suggest "Create a C# xUnit test project with Shouldly assertion library"

# 改善の余地がある例
gh copilot suggest "Create test project"
```

### 2. エイリアスの設定
よく使うコマンドにエイリアスを設定して効率化：

```shell
# ghcsエイリアスを設定（一度だけ実行）
gh copilot alias
```

設定後は以下のように使用できます：
```shell
ghcs "Build and run all tests"
```

### 3. 複数ステップのタスク
複雑なタスクは段階的に質問します：

```shell
# ステップ1：プロジェクト作成
gh copilot suggest "Create C# class library project"

# ステップ2：依存関係追加
gh copilot suggest "Add Entity Framework Core to class library"

# ステップ3：設定
gh copilot suggest "Create appsettings.json with database connection string"
```

## トラブルシューティング

### よくある問題と解決方法

1. **コマンドが見つからない**
   ```shell
   gh copilot explain "command not found: dotnet"
   ```
   Copilotが.NET SDKのインストール方法を説明してくれます。

2. **権限エラー**
   ```shell
   gh copilot suggest "Fix permission denied error when running dotnet command"
   ```

3. **ビルドエラーの解決**
   エラーメッセージをそのままCopilotに渡すことができます：
   ```shell
   gh copilot explain "error CS1061: 'Calculator' does not contain a definition for 'Add'"
   ```

## まとめ

Copilot in the CLIは、コマンドラインでの作業を大幅に効率化します。特に以下の場面で威力を発揮します：

- 普段使わないコマンドの構文を思い出したいとき
- 複雑なコマンドオプションを正しく使いたいとき
- エラーメッセージの意味と解決方法を知りたいとき
- 特定のタスクを実行する最適な方法を知りたいとき

継続的に使用することで、コマンドラインでの生産性が向上し、新しいツールやコマンドの学習も容易になります。

## 次のステップ

- 実際のC#プロジェクトでCopilot in the CLIを活用してみる
- よく使うコマンドのパターンを覚えて、より具体的な質問ができるようになる
- チームメンバーとCopilotの活用方法を共有する
