

using System;
/*************************/

using lab_2;

namespace lab_2t
{
    class Program
    {

        private static void lab_2()
        {
            ushort n1 = ((ushort)404);
            RomanNumber conv1 = new RomanNumber(n1);
            ushort n2 = ((ushort)272);
            RomanNumber conv2 = new RomanNumber(n2);
            Console.WriteLine("404 = " + conv1.ToString());
            Console.WriteLine("272 = " + conv2.ToString());
            Console.WriteLine("404 + 272 = 676 >>> " + conv1.ToString() + " + " + conv2.ToString() + " = " + RomanNumber.Add(conv1, conv2));
            Console.WriteLine("404 - 272 = 676 >>> " + conv1.ToString() + " - " + conv2.ToString() + " = " + RomanNumber.Sub(conv1, conv2));
            ushort n3 = ((ushort)16);
            ushort n4 = ((ushort)8);
            RomanNumber conv3 = new RomanNumber(n3);
            RomanNumber conv4 = new RomanNumber(n4);
            Console.WriteLine("16 * 8 = 128 >>> " + conv3.ToString() + " * " + conv4.ToString() + " = " + RomanNumber.Mul(conv3, conv4));
            Console.WriteLine("16 / 8 = 2 >>> " + conv3.ToString() + " / " + conv4.ToString() + " = " + RomanNumber.Div(conv3, conv4));
            short[] Values = new short[]
            { 1000, 997, 500, 335, 105, 80, 44, 30, 20, 10, 6, 4, 2 };
            RomanNumber[] conv5 = new RomanNumber[Values.Length];

            Console.WriteLine("Initial array:");
            for (int i = 0; i < Values.Length; ++i)
            {
                conv5[i] = new RomanNumber(((ushort)Values[i]));
                Console.Write(Values[i] + "(" + conv5[i].ToString() + ")" + " ");
            }
            Console.WriteLine("\nFinal sorted array:");
            Array.Sort(conv5);
            foreach (object el in conv5)
            {
                Console.Write(el.ToString() + " ");
            }

        }
        static void Main(string[] args)
        {
           
            lab_2();
        }
    }
}