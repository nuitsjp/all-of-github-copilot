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

    /// <summary>
    /// 整数の累乗を計算します
    /// </summary>
    /// <param name="baseNumber">底</param>
    /// <param name="exponent">指数（0以上の整数）</param>
    /// <returns>累乗結果</returns>
    /// <exception cref="ArgumentOutOfRangeException">指数が負の値の場合</exception>
    /// <exception cref="OverflowException">演算結果がint型の範囲を超えた場合</exception>
    public int Power(int baseNumber, int exponent)
    {
        if (exponent < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(exponent), "Exponent must be non-negative");
        }

        if (exponent == 0)
        {
            return 1;
        }

        if (baseNumber == 0)
        {
            return 0;
        }

        if (baseNumber == 1)
        {
            return 1;
        }

        if (baseNumber == -1)
        {
            return exponent % 2 == 0 ? 1 : -1;
        }

        try
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = checked(result * baseNumber);
            }
            return result;
        }
        catch (OverflowException)
        {
            throw new OverflowException($"Power overflow: {baseNumber}^{exponent} exceeds int range");
        }
    }
}