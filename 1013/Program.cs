using System;

class Desafio1013 {

    static void Main(string[] args) {

        string[] arrayMaior = Console.ReadLine().Split(' ');


        int a = int.Parse(arrayMaior[0]);
        int b = int.Parse(arrayMaior[1]);
        int c = int.Parse(arrayMaior[2]);

        int MaiorAB = 0;

        MaiorAB = (a + b + Math.Abs(a - b)) / 2;

        if (MaiorAB > c) {
            Console.WriteLine($"{MaiorAB} eh o maior");
            } else {
            Console.WriteLine($"{c} eh o maior");
            }
        }

    }
