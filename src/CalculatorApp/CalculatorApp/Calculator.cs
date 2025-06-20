/// <summary>
/// 四則演算などの計算機能を提供するクラスです。
/// </summary>
public class Calculator
{
    /// <summary>
    /// 2つの整数を加算します。
    /// </summary>
    /// <param name="a">加算する最初の整数</param>
    /// <param name="b">加算する2番目の整数</param>
    /// <returns>2つの整数の合計</returns>
    /// <exception cref="OverflowException">加算結果がintの範囲を超えた場合にスローされます。</exception>
    public int Add(int a, int b)
    {
        checked
        {
            return a + b;
        }
    }
}