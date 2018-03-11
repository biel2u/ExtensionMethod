using System;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        public static string ReverseString(this string word)
        {
            var toArray = word.ToCharArray();
            Array.Reverse(toArray);
            return new string(toArray);
        }
    }
}
