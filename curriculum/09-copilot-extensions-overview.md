# GitHub Copilot Extensions 学習教材 - スキルセットとエージェントの概要

## 学習目標

この教材を通じて、以下のことを理解し実装できるようになります：

- GitHub Copilot Extensions の基本概念
- スキルセットとエージェントの違いと使い分け
- C#を使った基本的なスキルセット/エージェントの実装
- 拡張性プラットフォームのワークフロー

## 1. 概要と基本概念

### GitHub Copilot Extensions とは

GitHub Copilot Extensions は、GitHub Copilot の機能を拡張するためのプラットフォームです。主に以下の2つの方式があります：

- **スキルセット**: 軽量で効率化された方式（最大5つのスキル）
- **エージェント**: 完全制御可能な複雑な統合方式

### スキルセット vs エージェント比較表

| 特徴 | スキルセット | エージェント |
|------|-------------|-------------|
| 設定の複雑さ | 最小限 | 複雑 |
| 制御レベル | 自動処理 | 完全制御 |
| 用途 | データ取得、単純操作 | 複雑なワークフロー |
| 開発コスト | 低 | 高 |

## 2. シナリオ1: 基本的なスキルセットの実装

### 目標
天気情報を取得するスキルセットを作成する

### 実装手順

#### Step 1: プロジェクト構造の作成

```
src/
  WeatherSkillset/
    Controllers/
    Models/
    Services/
tests/
  WeatherSkillset.Tests/
```

#### Step 2: 基本モデルの定義

```csharp
// filepath: src/WeatherSkillset/Models/WeatherRequest.cs
using System.ComponentModel.DataAnnotations;

namespace WeatherSkillset.Models
{
    /// <summary>
    /// 天気情報要求のモデル
    /// </summary>
    public class WeatherRequest
    {
        /// <summary>
        /// 都市名
        /// </summary>
        [Required(ErrorMessage = "都市名は必須です")]
        [StringLength(100, ErrorMessage = "都市名は100文字以内で入力してください")]
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// 国コード（ISO 3166-1 alpha-2）
        /// </summary>
        [StringLength(2, ErrorMessage = "国コードは2文字で入力してください")]
        public string? CountryCode { get; set; }
    }
}
```

#### Step 3: 天気サービスの実装

```csharp
// filepath: src/WeatherSkillset/Services/WeatherService.cs
using WeatherSkillset.Models;

namespace WeatherSkillset.Services
{
    /// <summary>
    /// 天気情報を取得するサービス
    /// </summary>
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<WeatherService> _logger;

        public WeatherService(HttpClient httpClient, ILogger<WeatherService> logger)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// 指定された都市の天気情報を取得します
        /// </summary>
        /// <param name="request">天気情報要求</param>
        /// <returns>天気情報</returns>
        public async Task<WeatherResponse> GetWeatherAsync(WeatherRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrWhiteSpace(request.City))
                throw new ArgumentException("都市名は必須です", nameof(request));

            try
            {
                _logger.LogInformation("天気情報を取得開始: {City}", request.City);
                
                // 実際のAPIコールの代わりにモックデータを返す
                var response = new WeatherResponse
                {
                    City = request.City,
                    Temperature = 25.5m,
                    Description = "晴れ",
                    Humidity = 60,
                    WindSpeed = 5.2m
                };

                _logger.LogInformation("天気情報を取得完了: {City}", request.City);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "天気情報の取得中にエラーが発生: {City}", request.City);
                throw;
            }
        }
    }
}
```

#### Step 4: Copilot スキルセットコントローラー

```csharp
// filepath: src/WeatherSkillset/Controllers/WeatherController.cs
using Microsoft.AspNetCore.Mvc;
using WeatherSkillset.Models;
using WeatherSkillset.Services;

namespace WeatherSkillset.Controllers
{
    /// <summary>
    /// 天気情報のCopilotスキルセットコントローラー
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        private readonly ILogger<WeatherController> _logger;

        public WeatherController(IWeatherService weatherService, ILogger<WeatherController> logger)
        {
            _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// 指定された都市の現在の天気を取得します
        /// </summary>
        /// <param name="request">天気情報要求</param>
        /// <returns>天気情報</returns>
        [HttpPost("current")]
        public async Task<ActionResult<WeatherResponse>> GetCurrentWeather([FromBody] WeatherRequest request)
        {
            if (request == null)
            {
                _logger.LogWarning("無効な要求: リクエストボディがnull");
                return BadRequest("リクエストボディは必須です");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("無効な要求: {Errors}", string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
                return BadRequest(ModelState);
            }

            try
            {
                var weather = await _weatherService.GetWeatherAsync(request);
                return Ok(weather);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "引数エラー");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "天気情報取得中の予期しないエラー");
                return StatusCode(500, "内部サーバーエラーが発生しました");
            }
        }
    }
}
```

## 3. シナリオ2: エージェントの実装

### 目標
複雑な計算処理を行うCopilotエージェントを作成する

#### Step 1: エージェントベースクラス

```csharp
// filepath: src/CalculatorAgent/Services/CopilotAgent.cs
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAgent.Services
{
    /// <summary>
    /// Copilotエージェントの基底クラス
    /// </summary>
    public abstract class CopilotAgentBase
    {
        protected readonly ILogger _logger;

        protected CopilotAgentBase(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// ユーザーメッセージを処理します
        /// </summary>
        /// <param name="message">ユーザーメッセージ</param>
        /// <returns>応答メッセージ</returns>
        public abstract Task<string> ProcessMessageAsync(string message);

        /// <summary>
        /// エージェントの機能を説明します
        /// </summary>
        /// <returns>機能説明</returns>
        public abstract string GetCapabilities();
    }

    /// <summary>
    /// 計算機能を提供するCopilotエージェント
    /// </summary>
    public class CalculatorAgent : CopilotAgentBase
    {
        public CalculatorAgent(ILogger<CalculatorAgent> logger) : base(logger) { }

        /// <summary>
        /// 計算要求メッセージを処理します
        /// </summary>
        /// <param name="message">計算要求メッセージ</param>
        /// <returns>計算結果</returns>
        public override async Task<string> ProcessMessageAsync(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("メッセージは必須です", nameof(message));

            _logger.LogInformation("計算要求を処理開始: {Message}", message);

            try
            {
                // 簡単な計算パーサーの実装
                var result = await ParseAndCalculateAsync(message);
                var response = $"計算結果: {result}";
                
                _logger.LogInformation("計算要求を処理完了: {Response}", response);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "計算処理中にエラーが発生");
                return "申し訳ございません。計算処理中にエラーが発生しました。";
            }
        }

        /// <summary>
        /// エージェントの計算機能を説明します
        /// </summary>
        /// <returns>機能説明</returns>
        public override string GetCapabilities()
        {
            return "基本的な四則演算（+, -, *, /）と平方根計算をサポートしています。例: '2 + 3', '10 * 5', 'sqrt(16)'";
        }

        private async Task<decimal> ParseAndCalculateAsync(string expression)
        {
            // 非同期処理のシミュレーション
            await Task.Delay(100);

            // 簡単な式の解析と計算（実際にはより複雑なパーサーが必要）
            expression = expression.Replace(" ", "").ToLower();

            if (expression.StartsWith("sqrt(") && expression.EndsWith(")"))
            {
                var numberStr = expression[5..^1];
                if (decimal.TryParse(numberStr, out var number))
                {
                    return (decimal)Math.Sqrt((double)number);
                }
            }

            // 基本的な二項演算
            foreach (var op in new[] { "+", "-", "*", "/" })
            {
                var index = expression.LastIndexOf(op);
                if (index > 0)
                {
                    var leftStr = expression[..index];
                    var rightStr = expression[(index + 1)..];
                    
                    if (decimal.TryParse(leftStr, out var left) && decimal.TryParse(rightStr, out var right))
                    {
                        return op switch
                        {
                            "+" => left + right,
                            "-" => left - right,
                            "*" => left * right,
                            "/" => right != 0 ? left / right : throw new DivideByZeroException("ゼロで割ることはできません"),
                            _ => throw new InvalidOperationException($"不明な演算子: {op}")
                        };
                    }
                }
            }

            throw new ArgumentException($"解析できない式: {expression}");
        }
    }
}
```

## 4. テストの実装

### 単体テスト例

```csharp
// filepath: tests/WeatherSkillset.Tests/Services/WeatherServiceTests.cs
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using WeatherSkillset.Models;
using WeatherSkillset.Services;
using Xunit;

namespace WeatherSkillset.Tests.Services
{
    public class WeatherServiceTests
    {
        private readonly Mock<ILogger<WeatherService>> _loggerMock;
        private readonly Mock<HttpClient> _httpClientMock;
        private readonly WeatherService _weatherService;

        public WeatherServiceTests()
        {
            _loggerMock = new Mock<ILogger<WeatherService>>();
            _httpClientMock = new Mock<HttpClient>();
            _weatherService = new WeatherService(_httpClientMock.Object, _loggerMock.Object);
        }

        [Fact]
        public async Task GetWeatherAsync_正常なリクエスト_天気情報を返す()
        {
            // Arrange
            var request = new WeatherRequest { City = "東京" };

            // Act
            var result = await _weatherService.GetWeatherAsync(request);

            // Assert
            result.ShouldNotBeNull();
            result.City.ShouldBe("東京");
            result.Temperature.ShouldBeGreaterThan(0);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public async Task GetWeatherAsync_無効な都市名_ArgumentExceptionをスロー(string invalidCity)
        {
            // Arrange
            var request = new WeatherRequest { City = invalidCity };

            // Act & Assert
            await Should.ThrowAsync<ArgumentException>(() => _weatherService.GetWeatherAsync(request));
        }

        [Fact]
        public async Task GetWeatherAsync_nullリクエスト_ArgumentNullExceptionをスロー()
        {
            // Act & Assert
            await Should.ThrowAsync<ArgumentNullException>(() => _weatherService.GetWeatherAsync(null));
        }
    }
}
```

## 5. 実践演習

### 演習1: スキルセットの拡張
天気スキルセットに以下の機能を追加してください：
- 週間天気予報の取得
- 複数都市の天気比較
- 天気アラート機能

### 演習2: エージェントの高度化
計算エージェントに以下の機能を追加してください：
- 複雑な数式の解析
- 統計計算（平均、分散など）
- グラフ描画機能

### 演習3: エラーハンドリングの改善
両方の実装について、以下のエラーハンドリングを追加してください：
- レート制限処理
- リトライ機能
- 詳細なログ出力

## 6. まとめ

このカリキュラムで学習した内容：

1. **スキルセット**: 軽量で簡単に実装できる拡張方式
2. **エージェント**: 高度な制御が可能な複雑な拡張方式
3. **実装パターン**: C#での基本的な実装方法
4. **テスト手法**: xUnitとShouldlyを使った単体テスト

### 次のステップ
- GitHub App の設定と統合
- 実際のCopilot Chatでのテスト
- プロダクション環境への展開

### 参考リンク
- [GitHub Copilot Extensions ドキュメント](https://docs.github.com/ja/copilot/building-copilot-extensions)
- [Skillset Example Repository](https://github.com/copilot-extensions/skillset-example)
