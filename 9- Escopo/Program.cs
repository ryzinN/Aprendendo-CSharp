using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto 09 - Escopo");

        int idadeRafael = 17;
        int quantidadePessoas = 1;

        bool acompanhado = quantidadePessoas > 1;

        string textoadicional;

        //bool grupo = false;

        if (acompanhado == true)
        {
            textoadicional = "Rafae está acompanhado";
        }
        else
        {
            textoadicional = "Rafael não está acompanhado";
        }
        if(idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoadicional);
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            Console.WriteLine(textoadicional);
            Console.WriteLine("Não Pode Entrar");
        }
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}