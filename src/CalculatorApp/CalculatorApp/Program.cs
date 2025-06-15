var calc = new Calculator();
Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
Console.WriteLine($"5 - 3 = {calc.Subtract(5, 3)}");
Console.WriteLine($"4 * 6 = {calc.Multiply(4, 6)}");
Console.WriteLine($"10 / 2 = {calc.Divide(10, 2)}");

// ゼロ除算のエラーハンドリング例
try
{
    Console.WriteLine($"10 / 0 = {calc.Divide(10, 0)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"エラー: {ex.Message}");
}

// オーバーフローのエラーハンドリング例
try
{
    Console.WriteLine($"int.MaxValue * 2 = {calc.Multiply(int.MaxValue, 2)}");
}
catch (OverflowException ex)
{
    Console.WriteLine($"エラー: {ex.Message}");
}