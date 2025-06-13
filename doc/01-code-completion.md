## [GitHub Copilot と Visual Studio Code について](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#github-copilot-%E3%81%A8-visual-studio-code-%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6)

このガイドでは、macOS、Windows、Linux 用の Visual Studio Code で GitHub Copilot からコーディングの提案を取得する方法について説明します。 その他の一般的なコーディング環境の説明を確認するには、ページの上部にあるツール スイッチャーを使います。

Copilot in VS Code には、2 種類の提案が用意されています。

-   **コード補完**。 Copilot により、入力時にコーディングの提案が提供されます。 コメント内で自然言語を使用して実行する操作を記述できます。Copilot では、目標を達成するためのコードが提案されます。
-   **次の編集候補 (パブリック プレビュー)**。 行っている編集に基づいて、Copilot により、次に行う可能性のある編集の場所が予測され、その補完が提案されます。

このガイドの例では JavaScript を使用していますが、他の言語も同様に機能します。 GitHub Copilot は、多数の言語とさまざまなフレームワークに対する候補を提示しますが、特に Python、JavaScript、TypeScript、Ruby、Go、C#、C++ に適しています。 GitHub Copilot は、データベースのクエリ生成や、API とフレームワークの候補の生成にも役立ちますし、コード開発としてインフラストラクチャを構築することもできます。

## [前提条件](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#prerequisites)

-   **Copilot へのアクセス権**。 GitHub Copilot in Visual Studio Code を使用するには、Copilot Free での制限付きアクセス、または有料 Copilot プランのフル アクセスが必要です。 Copilot のアクセス方法の詳細については、「[GitHub Copilot とは何ですか?](https://docs.github.com/ja/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)」を参照してください。
    
-   **Visual Studio Code で GitHub にサインインします**。 詳しくは、VS Code のドキュメント「[Visual Studio Code での GitHub Copilot の設定](https://code.visualstudio.com/docs/copilot/setup)」をご覧ください。
    
-   **Visual Studio Code**。 Visual Studio Code で GitHub Copilot を使うには、Visual Studio Code がインストールされている必要があります。 詳細については、[Visual Studio Code のダウンロード ページ](https://code.visualstudio.com/Download)を参照してください。
    
-   **Visual Studio Code の Copilot**。 Visual Studio Code で GitHub Copilot を初めて設定すると、必要な拡張機能が自動的にインストールされます。 手動でダウンロードまたはインストールする必要はありません。 詳細な手順については、Visual Studio Code ドキュメントの「[Visual Studio Code での GitHub Copilot の設定](https://code.visualstudio.com/docs/copilot/setup)」を参照してください。
    

## [コードの提案の取得](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#getting-code-suggestions)

GitHub Copilot では、入力時にコーディングの提案が提供されます。 たとえば、JavaScript ファイルに次の関数ヘッダーを入力します。

JavaScript

```javascript
function calculateDaysBetweenDates(begin, end) {
```

GitHub Copilot により、自動的に関数の残りの部分が提案されます。 候補を受け入れるには、Tab キーを押します。

コメント内で自然言語を使用して実行する操作を記述できます。Copilot では、目標を達成するためのコードが提案されます。 たとえば、JavaScript ファイルに次のコメントを入力します。

JavaScript

```javascript
// write a function to // find all images without alternate text // and give them a red border
```

GitHub Copilot によって、自動的にコードが提案されます。 候補を受け入れるには、Tab キーを押します。

## [代替候補を表示する](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#showing-alternative-suggestions)

特定の入力に対して、GitHub Copilot が複数の候補を提示することがあります。 使う候補を選択するか、すべての候補を拒否できます。

たとえば、JavaScript ファイルに次の関数ヘッダーを入力し、Enter キーを押します。

JavaScript

```javascript
function calculateDaysBetweenDates(begin, end) {
```

GitHub Copilot による候補が表示されます。

次に、候補の上にマウス ポインターを置くと、候補を選べるように GitHub Copilot コントロールが表示されます。 次または前の候補を表示するには、コントロールの前方矢印または戻る矢印ボタンをクリックします。

キーボード ショートカットを使用して、代替候補を表示することもできます。

| OS | 次の候補を表示 | 前の候補を表示 |
| --- | --- | --- |
| macOS | Option (⌥) または Alt+\] | Option (⌥) または Alt+\[ |
| Windows または Linux | Alt+\] | Alt+\[ |

提案を受け入れるには、Copilot コマンド パレットで \[承諾する\] をクリックするか、Tab キーを押します。すべての提案を拒否するには、Esc キーを押します。

## [新しいタブに複数の候補を表示する](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#showing-multiple-suggestions-in-a-new-tab)

GitHub Copilot プランの最初の候補を使用しない場合は、新しいタブに複数の候補を表示できます。

たとえば、JavaScript ファイルに次の関数ヘッダーを入力し、Enter キーを押します。

JavaScript

```javascript
function calculateDaysBetweenDates(begin, end) {
```

GitHub Copilot による候補が表示されます。 次に、Ctrl+Enter キーを押して、複数の追加オプションを含む新しいタブを開きます。

提案を受け入れるには、提案の下にある \[**提案 (番号) を受け入れる**\] をクリックします。 すべての候補を拒否するには、タブを閉じます。

## [部分的な提案の受け入れ](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#accepting-partial-suggestions)

GitHub Copilot から提案全体を受け入れたくない場合は、提案の次の単語または次の行を受け入れます。

たとえば、JavaScript ファイルに次の関数ヘッダーを入力し、Enter キーを押します。

JavaScript

```javascript
function calculateDaysBetweenDates(begin, end) {
```

GitHub Copilot による関数本体全体の候補が自動的に灰色のテキストで表示されます。 実際に表示される候補はこのとおりではない場合があります。

次に、候補の上にマウス ポインターを置くと、候補を選べるように GitHub Copilot コントロールが表示されます。 候補の次の単語のみを受け入れるには、コントロールの **\[Word を承諾\]** をクリックします。

または、キーボード ショートカットを使用して、提案の次の単語を受け入れることもできます。

| OS | 次の単語を受け入れる |
| --- | --- |
| macOS | Command+→ |
| Windows または Linux | コントロール+→ |

提案の次の行を受け入れる場合は、コマンド `editor.action.inlineSuggest.acceptNextLine` のカスタム キーボード ショートカットを設定する必要があります。 カスタム キーボード ショートカットの設定の詳細については、「[環境での GitHub Copilot の構成](https://docs.github.com/ja/copilot/configuring-github-copilot/configuring-github-copilot-in-your-environment)」を参照してください。

## [次の編集候補](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#%E6%AC%A1%E3%81%AE%E7%B7%A8%E9%9B%86%E5%80%99%E8%A3%9C-1)

について

インライン提案によってコードは自動補完されますが、多くの開発タスクでは既存のコードの編集が必要です。 次の編集候補 により、カーソル位置とコードの他の関連部分という両方の面で編集が支援され、整合性が維持され、変更が合理化されます。

次の編集候補 により、現在行っている変更に基づいて、どこをどのように編集する必要があるかが予測されます。 考えられる変更のスコープに応じて、提案は 1 つのシンボル、行全体、または複数行に及ぶ場合があります。

次の編集候補 を有効にするには、「[環境での GitHub Copilot の構成](https://docs.github.com/ja/copilot/managing-copilot/configure-personal-settings/configuring-github-copilot-in-your-environment#enabling-next-edit-suggestions)」を参照してください。

### [提案のナビゲーションと承認](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#navigating-and-accepting-suggestions)

Tab キーを使って提案されたコード変更を操作すると、ファイルや参照を手動で検索しなくても、次の関連する編集を簡単に見つけることができます。 提案を受け入れるには、もう一度 Tab キーを押します。

余白領域にある矢印は、使用できる編集提案を示します。 矢印にマウス ポインターを移動して、編集提案メニューにアクセスします。キーボード ショートカットと設定オプションが表示されます。 編集提案が現在のエディター ビューの外部にある場合、次の提案の位置が上下の矢印で示されます。

![Visual Studio Code の余白領域メニューのスクリーンショット。 矢印が濃いオレンジ色の枠線で囲まれています。](https://docs.github.com/assets/cb-39261/images/help/copilot/vsc-advanced-code-completion-menu.png)

詳細と例については、Visual Studio Code ドキュメントの「[GitHub Copilot in VS Code によるコード補完](https://code.visualstudio.com/docs/copilot/ai-powered-suggestions)」を参照してください。

## [AI モデルを変更する](https://docs.github.com/ja/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot#changing-the-ai-model)

コード補完の提案を生成するために使われる大規模言語モデルを変更できます。 詳しくは、「[Copilot コード補完の AI モデルを変更する](https://docs.github.com/ja/copilot/using-github-copilot/ai-models/changing-the-ai-model-for-copilot-code-completion)」をご覧ください。