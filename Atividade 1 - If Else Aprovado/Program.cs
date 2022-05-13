using System;

class Programa
{
    static void Main(string[] args)

    {
        int n1, n2, n3, n4, res;

        Console.WriteLine("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        float media = res / 4f;

        Console.WriteLine("A média das notas é: " + media);

        if(media >= 6)
        {
            Console.WriteLine("Parabéns você foi aprovado!!!");
        }
        else if(media == 5){
            Console.WriteLine("Você está de recuperação, mais atenção");
        }
        else if(media < 4)
        {
            Console.WriteLine("Você foi REPROVADO");
        }
        Console.WriteLine();

        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}