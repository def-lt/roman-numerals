# Roman Numerals Converter (C#)

Перевод числа (1–3999) в римскую запись и обратно.

## Методы

- `IntToRoman(int num)` — число → римская запись
- `RomanToInt(string s)` — римская запись → число

## Пример

```csharp
Console.WriteLine(RomanNumerals.IntToRoman(1994));      // MCMXCIV
Console.WriteLine(RomanNumerals.RomanToInt("MCMXCIV")); // 1994
```

## Запуск

```bash
dotnet new console -n RomanApp
# скопируй RomanNumerals.cs в проект и вызови RomanNumerals.Main()
```

Или просто:
```bash
csc RomanNumerals.cs && RomanNumerals.exe
```
