using Parcial_1;

internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Ingrese el tamaño de la matriz (un número par): ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n % 2 != 0);

        Matriz matriz = new Matriz(n);

        Console.WriteLine("Matriz generada:");
        matriz.MostrarMatriz();

        Console.WriteLine($"Suma de las esquinas: {matriz.CalcularSuma()}");

        Console.WriteLine($"Multiplicación de las esquinas: {matriz.CalcularMultiplicacion()}");
    }
}

