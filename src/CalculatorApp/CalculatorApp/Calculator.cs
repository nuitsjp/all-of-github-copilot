/// <summary>
/// 基本的な計算機能を提供するクラス
/// </summary>
public class Calculator
{
    /// <summary>
    /// 2つの数値の加算を行います。
    /// </summary>
    /// <param name="a">第1オペランド</param>
    /// <param name="b">第2オペランド</param>
    /// <returns>加算結果</returns>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// 2つの数値の減算を行います。
    /// </summary>
    /// <param name="a">被減数</param>
    /// <param name="b">減数</param>
    /// <returns>減算結果</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// 2つの数値の乗算を行います。
    /// </summary>
    /// <param name="a">第1オペランド</param>
    /// <param name="b">第2オペランド</param>
    /// <returns>乗算結果</returns>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// 2つの数値の除算を行います。
    /// </summary>
    /// <param name="a">被除数</param>
    /// <param name="b">除数</param>
    /// <returns>除算結果</returns>
    /// <exception cref="DivideByZeroException">除数が0の場合</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("除数は0にできません。");
        }
        return a / b;
    }
}