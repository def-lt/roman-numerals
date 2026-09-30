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

    public static void Main()
    {
        Console.WriteLine("=== Римские числа ===");
        Console.WriteLine("1 — число → римская запись");
        Console.WriteLine("2 — римская запись → число");
        Console.Write("Выбери режим (1 или 2): ");

        string choice = Console.ReadLine()?.Trim();

        if (choice == "1")
        {
            Console.Write("Введи число (1–3999): ");
            string input = Console.ReadLine()?.Trim();

            if (int.TryParse(input, out int num))
            {
                try
                {
                    string roman = IntToRoman(num);
                    Console.WriteLine($"Римская запись: {roman}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Нужно ввести целое число.");
            }
        }
        else if (choice == "2")
        {
            Console.Write("Введи римское число: ");
            string roman = Console.ReadLine()?.Trim();

            try
            {
                int number = RomanToInt(roman);
                Console.WriteLine($"Число: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор. Введи 1 или 2.");
        }

        Console.WriteLine("\nНажми Enter, чтобы выйти...");
        Console.ReadLine();
    }
}
