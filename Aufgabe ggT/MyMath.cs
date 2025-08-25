using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_ggT
{
    internal class MyMath
    {
        internal static double mean(int[] values)
        {
            int sum = 0;
            foreach (int v in values) sum += v;
            return (double)sum / values.Length;
        }

        internal static int min(int[] values)
        {
            int m = values[0];
            foreach (int v in values)
                if (v < m) m = v;
            return m;
        }

        internal static int max(int[] values)
        {
            int m = values[0];
            foreach (int v in values)
                if (v > m) m = v;
            return m;
        }
        internal static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        internal static int Calc_ggt_r(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;           // Basisfall
            return Calc_ggt_r(b, a % b);    // Rekursiver Schritt
        }
        internal static void showresult(string opLabel, int a, int b, int result)
        {
            Console.WriteLine($"{opLabel} von {a} und {b} ist {result}");
        }
        static internal int Calc_ggt(int a, int b)
        {
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }
        static internal int Calc_kgv(int a, int b)
        {
            return (a *b) / Calc_ggt(a, b);
        }

        internal static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? s = Console.ReadLine();

                if (int.TryParse(s, out int value) && value > 0)
                    return value;

                Console.WriteLine("Ungueltige Eingabe. Bitte eine positive ganze Zahl (> 0) eingeben.\n");
            }
        }
    }
}
