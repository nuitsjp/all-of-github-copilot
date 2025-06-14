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
        try
        {
            return checked(a + b);
        }
        catch (OverflowException)
        {
            throw new OverflowException($"Addition overflow: {a} + {b} exceeds int range");
        }
    }

    /// <summary>
    /// 二つの整数を減算します
    /// </summary>
    /// <param name="a">被減数</param>
    /// <param name="b">減数</param>
    /// <returns>減算結果</returns>
    /// <exception cref="OverflowException">演算結果がint型の範囲を超えた場合</exception>
    public int Subtract(int a, int b)
    {
        try
        {
            return checked(a - b);
        }
        catch (OverflowException)
        {
            throw new OverflowException($"Subtraction overflow: {a} - {b} exceeds int range");
        }
    }

    /// <summary>
    /// 二つの整数を乗算します
    /// </summary>
    /// <param name="a">第一オペランド</param>
    /// <param name="b">第二オペランド</param>
    /// <returns>乗算結果</returns>
    /// <exception cref="OverflowException">演算結果がint型の範囲を超えた場合</exception>
    public int Multiply(int a, int b)
    {
        try
        {
            return checked(a * b);
        }
        catch (OverflowException)
        {
            throw new OverflowException($"Multiplication overflow: {a} * {b} exceeds int range");
        }
    }

    /// <summary>
    /// 二つの整数を除算します
    /// </summary>
    /// <param name="a">被除数</param>
    /// <param name="b">除数</param>
    /// <returns>除算結果</returns>
    /// <exception cref="DivideByZeroException">除数が0の場合</exception>
    /// <exception cref="OverflowException">演算結果がint型の範囲を超えた場合</exception>
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }

        try
        {
            return checked(a / b);
        }
        catch (OverflowException)
        {
            throw new OverflowException($"Division overflow: {a} / {b} exceeds int range");
        }
    }
}