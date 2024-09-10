using System;
namespace laboratorio4;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.Pow(radio, 2) * Math.PI;

        Console.WriteLine($"El area del circulo es: {area}");
    }
}