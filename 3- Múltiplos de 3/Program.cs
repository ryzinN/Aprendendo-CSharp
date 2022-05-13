using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade 3 - Múltiplos de 3");
        Console.WriteLine();
        int soma = 0;

        for(int i = 0; i < 33; i++)
        {
            soma = soma + 3; 
            Console.WriteLine(soma);
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}