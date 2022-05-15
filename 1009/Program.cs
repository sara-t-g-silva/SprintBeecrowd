using System;
using System.Globalization;

class SalarioBonus1009 {

    static void Main(string[] args) {

        string Vendedor = Console.ReadLine();
        double Remuneracao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double TOTAL = Remuneracao + (vendas * 0.15);

        Console.WriteLine("TOTAL = R$ {0}", TOTAL.ToString("F2", CultureInfo.InvariantCulture));
        }

    }

