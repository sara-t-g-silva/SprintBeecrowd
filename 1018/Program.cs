using System;

class Desafio1018 {

    static void Main(string[] args) {

        String valorDeEntrada = Console.ReadLine();
        int valor = int.Parse(valorDeEntrada);

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

        for (int i = 0; i < notas.Length; i++) {
            int quantidadeDeNotas = (valor / notas[i]);
            Console.WriteLine(" {0} nota(s) de R$ {1} ", quantidadeDeNotas, notas[i].ToString("F2"));
            valor -= quantidadeDeNotas * notas[i];
            }

        }
    }
