/// <summary>
/// 基本的な計算機能を提供するクラス
/// </summary>
public class Calculator
{
    /// <summary>
    /// 二つの整数を加算します
    /// </summary>
    /// <param name="a">第一オペランド</param>
    /// <param name="b">第二オペランド</param>
    /// <returns>加算結果</returns>
    /// <exception cref="OverflowException">演算結果がint型の範囲を超えた場合</exception>
    public int Add(int a, int b)
    {
        return checked(a + b);
    }

    // 減算を追加
    /// <summary>
    /// 二つの整数を減算します
    /// </summary>
    /// <param name="a">第一オペランド</param>
    /// <param name="b">第二オペランド</param>
    /// <returns>減算結果</returns>
    /// <exception cref="OverflowException">演算結果がint型の範囲を超えた場合</exception>
    public int Subtract(int a, int b)
    {
        return checked(a - b);
    }
}