using System;

namespace ExtensionMethod
{
    public static class ReverseExtension
    {
        public static string StringReverse(this string word)
        {
            var toArray = word.ToCharArray();
            Array.Reverse(toArray);
            return new string(toArray);
        }
    }
}
