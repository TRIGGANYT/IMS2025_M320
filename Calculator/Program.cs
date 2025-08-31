using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculator_FLorin");
                Console.Write("Wähle eine Operation: + - * /");
                Console.WriteLine(" | q | zum beenden");
                Console.Write("Eingabe: ");
                string? op = Console.ReadLine()?.Trim();

                if (string.Equals(op, "q", StringComparison.OrdinalIgnoreCase))
                    break;

                double a = ReadDouble("Gib die 1. Zahl ein: ");
                double b = ReadDouble("Gib die 2. Zahl ein: ");

                try
                {
                    double result = op switch
                    {
                        "+" => calc.Add(a, b),
                        "-" => calc.Subtract(a, b),
                        "*" => calc.Multiply(a, b),
                        "/" => calc.Divide(a, b),
                        _ => throw new InvalidOperationException("Unbekante Operation.")
                    };

                    Console.WriteLine($"Ergebnis: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                }

                Console.WriteLine("Enter drücken für nächste Rechnung");
                Console.ReadLine();
            }

            static double ReadDouble(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                        {
                        Console.WriteLine("Bitte gültigen Wert eingeben");
                        continue;
                        }

                    input = input.Replace(',', '.');

                    if (double.TryParse(input, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        return value;
                    }

                    Console.WriteLine("Ungültige Zahl. Verwende: . oder ,");
                }
            }
        }
    }
}