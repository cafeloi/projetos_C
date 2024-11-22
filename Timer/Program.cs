using System;
using System.Threading;

internal class Program

{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        int mutiplicador = 1;
        Console.WriteLine("Ola esse é um timer. Temos algumas opçoes");
        Console.WriteLine("S para Digitar o tempo em segundos ex -> 10s");
        Console.WriteLine("M para Digitar o tempo em minutos ex -> 1m");
        Console.WriteLine("0 - sair do programa");
        string tipo_tempo = Console.ReadLine().ToLower();
        char tipo = char.Parse(tipo_tempo.Substring(tipo_tempo.Length - 1, 1));
        int tempo = int.Parse(tipo_tempo.Substring(0, tipo_tempo.Length - 1));
        if (tipo == 'm')
        {
            mutiplicador = 60;
        }
        if (tempo == 0)
        {
            System.Environment.Exit(0);
        }
        comecar(tempo * mutiplicador);
    }
    static void comecar(int tempo)
    {
        int tempo_atual = 0;
        while (tempo_atual != tempo)
        {

            tempo_atual++;
            Console.WriteLine(tempo_atual);
            Thread.Sleep(1000);
        }
        Console.WriteLine("O tempo acabou");
        Menu();
    }
}