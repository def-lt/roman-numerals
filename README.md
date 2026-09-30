# Roman Numerals Converter

Перевод числа (1–3999) в римскую запись и обратно.

## Функции

- `int_to_roman(num: int) -> str` — число → римская запись
- `roman_to_int(s: str) -> int` — римская запись → число

## Пример

```python
from roman_numerals import int_to_roman, roman_to_int

print(int_to_roman(1994))      # MCMXCIV
print(roman_to_int("MCMXCIV")) # 1994
```

## Запуск

```bash
python roman_numerals.py
```
