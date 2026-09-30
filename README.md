# Roman Numerals Converter (C#)

Перевод числа (1–3999) в римскую запись и обратно.

## Как работает

Программа спрашивает:
1. Число → римская запись
2. Римская запись → число

Потом ты вводишь значение, и она переводит.

## Методы

- `IntToRoman(int num)` — число → римская запись
- `RomanToInt(string s)` — римская запись → число

## Запуск

```bash
csc RomanNumerals.cs
RomanNumerals.exe
```

Или через .NET:
```bash
dotnet new console -n RomanApp
# замени Program.cs на содержимое RomanNumerals.cs
dotnet run
```
