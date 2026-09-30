def int_to_roman(num: int) -> str:
    if not 1 <= num <= 3999:
        raise ValueError("Число должно быть в диапазоне 1–3999")
    
    val = [
        1000, 900, 500, 400,
        100,  90,  50,  40,
        10,   9,   5,   4,
        1
    ]
    syb = [
        "M", "CM", "D", "CD",
        "C", "XC", "L", "XL",
        "X", "IX", "V", "IV",
        "I"
    ]
    
    roman = ""
    for i in range(len(val)):
        while num >= val[i]:
            roman += syb[i]
            num -= val[i]
    return roman


def roman_to_int(s: str) -> int:
    roman_map = {
        'I': 1, 'V': 5, 'X': 10, 'L': 50,
        'C': 100, 'D': 500, 'M': 1000
    }
    
    total = 0
    prev = 0
    
    for char in reversed(s.upper()):
        value = roman_map[char]
        if value < prev:
            total -= value
        else:
            total += value
        prev = value
    
    return total


if __name__ == "__main__":
    # Примеры
    print(int_to_roman(1994))       # MCMXCIV
    print(roman_to_int("MCMXCIV"))  # 1994

    print(int_to_roman(58))         # LVIII
    print(roman_to_int("LVIII"))    # 58

    print(int_to_roman(3999))       # MMMCMXCIX
    print(roman_to_int("MMMCMXCIX")) # 3999
