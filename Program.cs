using System;

namespace ImparOuPar;

internal class Program
{
    static void Main(string[] args)
    {
        int fim = 0;
        Console.WriteLine("===============================");
        Console.WriteLine("||       Impar ou Par        ||");
        Console.WriteLine("===============================");
        Console.WriteLine("Este programa recebe um numero e informa se é impar ou par.");
        do
        {
            Console.Write("Digite um numero:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} É par!", num);
            }
            else
            {
                Console.WriteLine("{0} É impar!", num);
            }
            Console.WriteLine("Deseja digitar outro numero? [S/N]:");
            string resposta = Console.ReadLine();
            if (resposta == "N" || resposta == "n")
            {
                fim++;
            }
            else
            {
                Console.Clear();
            }
        } 
        while (fim == 0);
        Console.WriteLine("=================================");
        Console.WriteLine("Obrigado por utilizar o programa!");
        Console.WriteLine("=================================");
    }
}