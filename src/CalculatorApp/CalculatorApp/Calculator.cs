namespace CalculatorApp;

/// <summary>
/// 四則演算などの計算機能を提供するクラスです。
/// </summary>
public class Calculator
{
    /// <summary>
    /// 2つの整数値を加算します。
    /// </summary>
    /// <param name="a">1つ目の加算対象</param>
    /// <param name="b">2つ目の加算対象</param>
    /// <returns>加算結果</returns>
    /// <exception cref="OverflowException">加算結果がintの範囲を超えた場合</exception>
    public int Add(int a, int b)
    {
        // checkedブロックでオーバーフローを検出
        checked
        {
            return a + b;
        }
    }

    /// <summary>
    /// 2つの整数値を乗算します。
    /// </summary>
    /// <param name="a">1つ目の乗算対象</param>
    /// <param name="b">2つ目の乗算対象</param>
    /// <returns>乗算結果</returns>
    /// <exception cref="OverflowException">乗算結果がintの範囲を超えた場合</exception>
    public int Multiply(int a, int b)
    {
        // checkedブロックでオーバーフローを検出
        checked
        {
            return a * b;
        }
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
