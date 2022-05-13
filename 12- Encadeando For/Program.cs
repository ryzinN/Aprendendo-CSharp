using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto 12 - Encadeando For");
        Console.WriteLine();

        for(int contadordelinha = 0; contadordelinha  <= 10; contadordelinha++)
        {
            for(int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadordelinha)
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}