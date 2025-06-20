namespace CalculatorApp;

/// <summary>
/// 四則演算を提供する電卓クラス。
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
}
