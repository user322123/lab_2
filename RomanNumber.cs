using System;
using System.Text;
using lab_2.ex;

namespace lab_2
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort Number;

        private static short[] Val = new short[]
        { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        private static string[] Numerals = new string[]
        { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private short ToShort()
        {
            short res = ((short)Number);
            return res;
        }

        public RomanNumber(ushort n)
        {
            short CheckException = ((short)n);
            if (n <= 0)
            {
                throw new RomanNumberException("InvalidValueException: Ожидалось, что число > 0");
            }
            Number = n;
        }

        public static RomanNumber Add(RomanNumber? g1, RomanNumber? g2)
        {
            ushort result = 0;
            short x1 = g1.ToShort();
            short x2 = g2.ToShort();
            short x3 = ((short)(x2 + x1));
            result = ((ushort)x3);
            RomanNumber res = new RomanNumber(result);
            return res;
        }

        public static RomanNumber Sub(RomanNumber? g1, RomanNumber? g2)
        {
            ushort result = 0;
            short x1 = g1.ToShort();
            short x2 = g2.ToShort();
            short x3 = ((short)(x1 - x2));
            if (x3 <= 0)
            {
                throw new RomanNumberException("\nInvalidValueException: Ожидалось, что значение выражения (" + x3.ToString() + ") будет больше 0");
            }
            else
            {
                result = ((ushort)x3);
                RomanNumber res = new RomanNumber(result);
                return res;
            }
        }

        public static RomanNumber Mul(RomanNumber? g1, RomanNumber? g2)
        {
            ushort result = 0;
            short x1 = g1.ToShort();
            short x2 = g2.ToShort();
            short x3 = ((short)(x2 * x1));
            result = ((ushort)x3);
            RomanNumber res = new RomanNumber(result);
            return res;
        }

        public static RomanNumber Div(RomanNumber? g1, RomanNumber? g2)
        {
            ushort result = 0;
            short x1 = g1.ToShort();
            short x2 = g2.ToShort();
            short x3 = ((short)(x1 / x2));
            if (x3 <= 0)
            {
                throw new RomanNumberException("InvalidValueException: Ожидалось, что результат выражение будет больше 0 (" + x3.ToString() + ")");
            }
            else
            {
                result = ((ushort)(x3));
                RomanNumber res = new RomanNumber(result);
                return res;
            }
        }

        public override string ToString()
        {
            StringBuilder NumberInRomanSystem = new StringBuilder();

            int Range = 13;

            short Temp = ((short)Number);

            for (int i = 0; i < Range; ++i)
            {
                while (Temp >= Val[i])
                {
                    Temp -= Val[i];
                    NumberInRomanSystem.Append(Numerals[i]);
                }
            }

            return NumberInRomanSystem.ToString();
        }

        public object Clone()
        {
            return new RomanNumber(Number);
        }

        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber rom) return ((short)Number).CompareTo(rom.ToShort());
            else throw new RomanNumberException("InvaludValueException: Некорректное значение параметра");
        }
    }
}