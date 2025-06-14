public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// 二つの整数を除算します。
    /// </summary>
    /// <param name="a">被除数</param>
    /// <param name="b">除数</param>
    /// <returns>a を b で除算した結果</returns>
    /// <exception cref="ArgumentException">b が 0 の場合にスローされます</exception>
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.", nameof(b));
        }
        return a / b;
    }
    
    public void ProcessArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine("Even: " + numbers[i]);
            }
        }
    }
}