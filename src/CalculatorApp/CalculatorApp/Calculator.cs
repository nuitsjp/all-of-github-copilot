namespace CalculatorApp
{
    public class Calculator
    {
        /// <summary>
        /// 指定した底と指数のべき乗（累乗）を計算します。
        /// </summary>
        /// <param name="baseValue">底となる数値（double型）。</param>
        /// <param name="exponent">指数（int型）。</param>
        /// <returns>baseValue の exponent 乗の値（double型）。</returns>
        /// <exception cref="ArgumentException">baseValueがNaNまたはInfinityの場合、またはexponentがintの範囲外の場合にスローされます。</exception>
        public double Power(double baseValue, int exponent)
        {
            // 引数検証
            if (double.IsNaN(baseValue) || double.IsInfinity(baseValue))
            {
                throw new ArgumentException("baseValueは有限な数値でなければなりません。", nameof(baseValue));
            }
            // exponentはint型なので範囲外は発生しないが、念のためチェック
            // Math.Powは指数が大きすぎるとInfinityを返すため、ここでは例外は投げない

            return Math.Pow(baseValue, exponent);
        }
    }
}