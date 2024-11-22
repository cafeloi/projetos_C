using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
            Menu();   
    }

    static void Soma()
    {
        Console.WriteLine("Digite o primeiro valor");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        double n2 = double.Parse(Console.ReadLine());
        double resultado = n1 + n2;
        Console.WriteLine("Resultado " + resultado);
        Menu();
    }
    static void subtração()
    {
        Console.WriteLine("Digite o primeiro valor");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        double n2 = double.Parse(Console.ReadLine());
        double resultado = n1 - n2;
        Console.WriteLine("Resultado " + resultado);
        Menu();
    }
    static void mutiplicacao()
    {
        Console.WriteLine("Digite o primeiro valor");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        double n2 = double.Parse(Console.ReadLine());
        double resultado = n1 * n2;
        Console.WriteLine("Resultado " + resultado);
        Menu();
    }
    static void divisao()
    {
        Console.WriteLine("Digite o primeiro valor");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        double n2 = double.Parse(Console.ReadLine());
        double resultado = n1 / n2;
        Console.WriteLine("Resultado " + resultado);
        Menu();
    }
    static void Menu()
    {
        short op = 0;

        Console.WriteLine("Escolha qual operação deseja realizar");
        Console.WriteLine("1 Adição");
        Console.WriteLine("2 Subtração");
        Console.WriteLine("3 mutiplicação");
        Console.WriteLine("4 divisão");
        Console.WriteLine("5 Sair do programa");
        op = short.Parse(Console.ReadLine());
        switch (op)
        {
            case 1: Soma(); break;
            case 2: subtração(); break;
            case 3: mutiplicacao(); break;
            case 4: divisao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }


    }
}
