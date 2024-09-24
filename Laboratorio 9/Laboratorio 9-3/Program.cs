using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer lado del triángulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo lado del triángulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer lado del triángulo: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (TrianguloValido (lado1, lado2, lado3))
        {
            if (lado1 == lado2 &&  lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isóceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        else
        {
            Console.WriteLine("No es posible formar un triángulo con los lados ingresados.");
        }
        static bool TrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}