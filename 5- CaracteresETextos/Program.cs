using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");

        char letra = 'a'; 

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)76;
        Console.WriteLine(letra);

        letra = (char)73;
        Console.WriteLine(letra);

        letra = (char)83;
        Console.WriteLine(letra);

        letra = (char)79;
        Console.WriteLine(letra);

        letra = (char)78;
        Console.WriteLine(letra);

        Console.WriteLine();

        letra = (char)65;
        Console.Write(letra);

        letra = (char)76;
        Console.Write(letra);

        letra = (char)73;
        Console.Write(letra);

        letra = (char)83;
        Console.Write(letra);

        letra = (char)79;
        Console.Write(letra);

        letra = (char)78;
        Console.WriteLine(letra);

        Console.WriteLine();

       string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis: 
-C 
-C++
-HTML
-CSharp";

        Console.WriteLine(cursos);
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
