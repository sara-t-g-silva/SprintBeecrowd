using System;

class Desafio1020    {

    static void Main(string[] args) {

        int idade = int.Parse(Console.ReadLine());


        int ano = idade / 365;
        int mes = (idade % 365) / 30;
        int dia = (idade % 365) % 30;

        Console.WriteLine($"{ano} ano (s)");
        Console.WriteLine($"{mes} mes (es)");
        Console.WriteLine($"{dia} dia (s)");

        }

    }