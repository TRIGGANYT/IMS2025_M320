namespace Aufgabe_ggT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int[] ReadIntArray()
            {
                Console.Write("Wie viele Zahlen moechten Sie eingeben? ");
                int n = int.Parse(Console.ReadLine()!);

                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = MyMath.ReadInt($"Zahl {i + 1}: ");
                }
                return arr;
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== Rechner ===");
                Console.WriteLine("1) ggT");
                Console.WriteLine("2) kgV");
                Console.WriteLine("3) ggT (rekursiv)");
                Console.WriteLine("4) Array-Statistik (Mittelwert / Minimum / Maximum)");
                Console.WriteLine("5) Swap");

                Console.WriteLine("0) Beenden");
                Console.Write("Ihre Wahl: ");
                string? choice = Console.ReadLine();

                if (choice == "0") break;

                int a = MyMath.ReadInt("Erste Zahl (>0): ");
                int b = MyMath.ReadInt("Zweite Zahl (>0): ");

                if (choice == "1")
                {
                    int ggt = MyMath.Calc_ggt(a, b);
                    MyMath.showresult("ggT", a, b, ggt);
                }
                else if (choice == "2")
                {
                    int kgv = MyMath.Calc_kgv(a, b);
                    MyMath.showresult("kgV", a, b, kgv);
                }
                else if (choice == "3")
                {
                    int ggt = MyMath.Calc_ggt_r(a, b);
                    MyMath.showresult("ggT (rekursiv)", a, b, ggt);
                }
                else if (choice == "4")
                {
                    int[] arr = ReadIntArray();
                    Console.WriteLine($"Mittelwert = {MyMath.mean(arr)}");
                    Console.WriteLine($"Minimum    = {MyMath.min(arr)}");
                    Console.WriteLine($"Maximum    = {MyMath.max(arr)}");
                }
                else if (choice == "5")
                {
                    a = MyMath.ReadInt("Wert a: ");
                    b = MyMath.ReadInt("Wert b: ");
                    Console.WriteLine($"Vor Swap: a={a}, b={b}");
                    MyMath.swap(ref a, ref b);
                    Console.WriteLine($"Nach Swap: a={a}, b={b}");
                }

                else
                {
                    Console.WriteLine("Unbekannte Wahl.");
                }
            }

            Console.WriteLine("Tschuess!");
        }
    }
}
