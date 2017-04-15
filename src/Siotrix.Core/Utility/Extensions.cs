using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Siotrix
{
    public static class Extensions
    {
        public static long ToLong(this ulong number)
        {
            if (!long.TryParse((number.ToString()), out long convertedNumber))
                throw new AggregateException("Could not convert ulong to long");

            return convertedNumber;
        }

        public static ulong ToUlong(this long number)
        {
            if (!ulong.TryParse((number.ToString()), out ulong convertedNumber))
                throw new AggregateException("Could not convert long to ulong");

            return convertedNumber;
        }

        public static string ToTitleCase(this TextInfo textInfo, string str)
        {
            var tokens = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];
                tokens[i] = token.Substring(0, 1).ToUpper() + token.Substring(1);
            }

            return string.Join(" ", tokens);
        }

        public static string PrettyPrint(this IEnumerable<string> list) =>
            string.Join(", ", list.Select(v => $"``{v}``"));

        public static string Cap(this string value, int length) =>
            value?.Substring(0, Math.Abs(Math.Min(value.Length, length)));

        public static bool ICEquals(this string source, string comparison) =>
            string.Equals(source, comparison, StringComparison.OrdinalIgnoreCase);

        public static bool ICStartsWith(this string source, string comparison) =>
            source.StartsWith(comparison, StringComparison.OrdinalIgnoreCase);

        public static string Truncate(this string value, int length) =>       
            value?.Substring(0, Math.Min(value.Length, value.Length - length));

        public static string RemoveWhitespace(this string input) =>
            new string(input.ToCharArray()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray());
    }
}
