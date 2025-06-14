# Copilot Spaces を使った開発効率化

## 学習目標

このモジュールを完了すると、以下のことができるようになります：

- Copilot Spacesの概念と利点を理解する
- スペースを作成し、適切なコンテキストを追加する
- 開発タスクでスペースを効果的に活用する
- チームとスペースを共有してコラボレーションを促進する

## 前提条件

- GitHub Copilotのライセンス（無料版でも可）
- C#の基本的な知識
- Visual StudioまたはVS Codeの使用経験

## Copilot Spacesとは

Copilot Spacesは、特定のタスクに関連するコンテキスト（コード、ドキュメント、指示）を一箇所に整理し、より精度の高いAI支援を受けられる機能です。

### 主な利点

1. **コンテキストの一元管理**: 関連する情報を整理して保存
2. **より正確な回答**: 特定のコンテキストに基づいた精度の高い提案
3. **チーム共有**: 知識の共有とオンボーディングの効率化
4. **作業の継続性**: チャット履歴に依存しない永続的なコンテキスト

## シナリオ: C# Calculatorアプリケーションの機能拡張

既存のC# Calculatorアプリケーションに新機能を追加するシナリオを通じて、Copilot Spacesの使い方を学びます。

### ステップ1: スペースの作成

1. [https://github.com/copilot/spaces](https://github.com/copilot/spaces) にアクセス
2. **[Create space]** をクリック
3. 以下の情報を入力：
   - **名前**: `C# Calculator Enhancement`
   - **所有者**: 自分または所属するorganization
   - **説明**: `C# Calculatorアプリケーションの機能拡張と保守作業`
4. **Create** をクリック

### ステップ2: 指示の追加

スペースに以下の指示を追加します：

```
あなたはC#開発のエキスパートです。以下のガイドラインに従ってください：

1. コーディング規約
   - C#命名規則（PascalCase、camelCase）を厳守
   - XMLドキュメントコメントを全publicメソッドに追加
   - 引数検証をメソッド冒頭で実施

2. テスト要件
   - xUnitとShouldlyを使用
   - Arrange-Act-Assertパターンを遵守
   - テストメソッド名は日本語で記述

3. エラーハンドリング
   - 適切な例外処理の実装
   - カスタム例外クラスの活用
```

### ステップ3: コンテキストの追加

#### 既存のCalculatorクラスを追加

```csharp
namespace Calculator.Core
{
    /// <summary>
    /// 基本的な計算機能を提供するクラス
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// 2つの数値を加算します
        /// </summary>
        /// <param name="a">第1引数</param>
        /// <param name="b">第2引数</param>
        /// <returns>加算結果</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// 2つの数値を減算します
        /// </summary>
        /// <param name="a">第1引数</param>
        /// <param name="b">第2引数</param>
        /// <returns>減算結果</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
```

#### テストコードを追加

```csharp
using Xunit;
using Shouldly;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator.Core.Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator.Core.Calculator();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void 加算メソッドは正しい結果を返す(double a, double b, double expected)
        {
            // Arrange
            // (constructorで初期化済み)

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            result.ShouldBe(expected);
        }
    }
}
```

### ステップ4: スペースを使った開発作業

#### タスク1: 乗算機能の追加

スペース内で以下のプロンプトを使用：

> Calculatorクラスに乗算（Multiply）メソッドを追加してください。
> 既存のコードスタイルに従い、XMLコメントと引数検証を含めてください。

期待される回答例：

```csharp
/// <summary>
/// 2つの数値を乗算します
/// </summary>
/// <param name="a">第1引数</param>
/// <param name="b">第2引数</param>
/// <returns>乗算結果</returns>
/// <exception cref="OverflowException">計算結果がdoubleの範囲を超えた場合</exception>
public double Multiply(double a, double b)
{
    if (double.IsInfinity(a) || double.IsInfinity(b))
    {
        throw new ArgumentException("無限大は処理できません");
    }
    
    var result = a * b;
    
    if (double.IsInfinity(result))
    {
        throw new OverflowException("計算結果がdoubleの範囲を超えました");
    }
    
    return result;
}
```

#### タスク2: 対応するテストの生成

> 追加したMultiplyメソッドのテストコードを生成してください。
> 正常系、境界値、異常系のテストケースを含めてください。

### ステップ5: チームとの共有

1. スペースの右上の設定アイコンをクリック
2. **[Share]** を選択
3. 基本的な役割を **[The entire organization can access]** に変更
4. リンクをコピーしてチームメンバーに共有

## 実践演習

### 演習1: 除算機能の実装

1. 新しいスペースを作成（名前: `Division Feature Development`）
2. 以下の要件を指示として追加：
   - ゼロ除算の適切な処理
   - 小数点以下の精度管理
   - パフォーマンスを考慮した実装
3. Copilotに除算メソッドとテストコードの生成を依頼

### 演習2: コードレビューのためのスペース作成

1. `Code Review Guidelines`という名前のスペースを作成
2. チームのコーディング規約とレビューチェックリストを追加
3. 実際のコードをレビューしてもらう

## ベストプラクティス

### スペースの効果的な使用

1. **明確な目的設定**: スペースごとに明確な目的を定義
2. **適切な粒度**: タスクやプロジェクトに応じた適切なスコープ
3. **定期的な更新**: コンテキストを最新の状態に保つ
4. **チーム共有**: 知識の属人化を防ぐ

### よくある使用パターン

- **機能開発**: 仕様書、関連コード、設計ドキュメント
- **バグ修正**: エラーログ、関連コード、過去の修正履歴
- **オンボーディング**: システム概要、開発環境設定、チーム規約
- **技術調査**: 参考資料、POCコード、調査メモ

## トラブルシューティング

### よくある問題と解決方法

1. **回答が期待と異なる場合**
   - 指示をより具体的に記述
   - 関連するコンテキストが不足していないか確認
   - 使用するAIモデルを変更してみる

2. **パフォーマンスの問題**
   - 不要なコンテキストを削除
   - 大きなファイルは要約版を使用

## まとめ

Copilot Spacesを使うことで：
- 特定のタスクに集中した開発が可能
- チームの知識共有が促進される
- より正確で関連性の高いAI支援を受けられる

次のステップとして、実際のプロジェクトでCopilot Spacesを活用し、チームの生産性向上に貢献しましょう。

## 参考リソース

- [Copilot Spaces公式ドキュメント](https://docs.github.com/copilot/using-github-copilot/copilot-spaces)
- [GitHub Copilot ベストプラクティス](https://docs.github.com/copilot/getting-started-with-github-copilot)
