using System;

namespace Loken.TestLib
{
    /// <summary>
    /// Convenience extensions to <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Default separators to use when converting between a <see cref="string"/> and a <see cref="T:string[]"/>
        /// </summary>
        public static char[] DefaultSeparators = { ';', ',' };

        /// <summary>
        /// Split the <paramref name="source"/> by the <paramref name="separators"/> when provided, or otherwise by the <see cref="DefaultSeparators"/>.
        /// </summary>
        public static string[] SplitList(this string source, params char[] separators)
        {
            if (separators == null || separators.Length == 0)
                separators = DefaultSeparators;

            return source.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
