using System;

namespace StringExtensionLibrary
{
    public static class Class1
    {
        public static bool StartsWithUpperCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;
            return char.IsUpper(str[0]);
        }

    }
}
