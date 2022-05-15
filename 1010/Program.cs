using System;
using System.Globalization;

public class Desafio1010 {

    public static void Main(string[] args) {

        string[] Produto = Console.ReadLine().Split(' ');
        int codigoPeca1 = Convert.ToInt32(Produto[0]);
        int quantidadeDePeca1 = Convert.ToInt32(Produto[1]);
        double valorPeca1 = Convert.ToDouble(Produto[2], CultureInfo.InvariantCulture);

        string[] Produto2 = Console.ReadLine().Split(' ');
        int codigoPeca2 = Convert.ToInt32(Produto2[0]);
        int quantidadeDePeca2 = Convert.ToInt32(Produto2[1]);
        double valorPeca2 = Convert.ToDouble(Produto2[2], CultureInfo.InvariantCulture);

        double totalAPagar = (quantidadeDePeca1 * valorPeca1) + (quantidadeDePeca2 * valorPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ {0}", totalAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
