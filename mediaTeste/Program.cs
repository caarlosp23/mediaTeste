using System;

namespace mediaTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;
            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            media = (a + b) / 2;
            Console.WriteLine("Média: " + media);
        }
    }
}
