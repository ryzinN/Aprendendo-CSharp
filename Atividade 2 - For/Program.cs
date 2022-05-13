using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");
        Console.WriteLine();

        double investimento = 1000;

        // rendimento de 0,5% (0,005) ao mês

        //mes 1
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        //mes 2
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        //mes 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        for (int mes = 1; mes <= 12; mes+= 1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento.ToString("C"));

        }
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}