namespace UtilityLibrary
{
    public class StringUtilities
    {
        public static bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// 文字列の先頭の空白文字を除去します。
        /// </summary>
        /// <param name="input">処理対象の文字列</param>
        /// <returns>先頭の空白文字が除去された文字列</returns>
        /// <exception cref="ArgumentNullException">inputがnullの場合</exception>
        public static string TrimStart(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.TrimStart();
        }

        /// <summary>
        /// 文字列の末尾の空白文字を除去します。
        /// </summary>
        /// <param name="input">処理対象の文字列</param>
        /// <returns>末尾の空白文字が除去された文字列</returns>
        /// <exception cref="ArgumentNullException">inputがnullの場合</exception>
        public static string TrimEnd(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.TrimEnd();
        }

        /// <summary>
        /// 文字列の先頭・末尾両方の空白文字を除去します。
        /// </summary>
        /// <param name="input">処理対象の文字列</param>
        /// <returns>先頭・末尾の空白文字が除去された文字列</returns>
        /// <exception cref="ArgumentNullException">inputがnullの場合</exception>
        public static string TrimBoth(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            return input.Trim();
        }

        // TODO: 他の文字列ユーティリティメソッドが必要
        // - 大文字・小文字変換
        // - 文字列の逆順
    }
}