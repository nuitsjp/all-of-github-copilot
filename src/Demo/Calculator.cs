public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

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