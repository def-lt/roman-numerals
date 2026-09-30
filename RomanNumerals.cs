using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumerals
{
    public static string IntToRoman(int num)
    {
        if (num < 1 || num > 3999)
            throw new ArgumentOutOfRangeException(nameof(num), "Число должно быть в диапазоне 1–3999");

        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        var result = new StringBuilder();

        for (int i = 0; i < values.Length; i++)
        {
            while (num >= values[i])
            {
                result.Append(symbols[i]);
                num -= values[i];
            }
        }

        return result.ToString();
    }

    public static int RomanToInt(string s)
    {
        if (string.IsNullOrEmpty(s))
            throw new ArgumentException("Строка не может быть пустой");

        var map = new Dictionary<char, int>
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
            { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
        };

        int total = 0;
        int prev = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char c = char.ToUpper(s[i]);
            if (!map.ContainsKey(c))
                throw new ArgumentException($"Недопустимый символ: {c}");

            int value = map[c];

            if (value < prev)
                total -= value;
            else
                total += value;

            prev = value;
        }

        return total;
    }

    // Примеры
    public static void Main()
    {
        Console.WriteLine(IntToRoman(1994));       // MCMXCIV
        Console.WriteLine(RomanToInt("MCMXCIV"));  // 1994

        Console.WriteLine(IntToRoman(58));         // LVIII
        Console.WriteLine(RomanToInt("LVIII"));    // 58

        Console.WriteLine(IntToRoman(3999));       // MMMCMXCIX
        Console.WriteLine(RomanToInt("MMMCMXCIX")); // 3999
    }
}
