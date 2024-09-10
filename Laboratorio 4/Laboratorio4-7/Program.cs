internal class Program
{
    private static void Main(string[] args)
    {
        int numero1 = 70;
        double numero2 = 67.89;
        double numero3 = 67.89;

        Console.WriteLine(Suma(numero1, numero2)); //No deja usarlo tira error directamente y no se ejecuta porque no tiene un valor asignado la z
        Console.WriteLine(Suma(numero1, numero2, numero3));
    }

    static double Suma(int x, double y, double z)
    {
        return x + y + z;
    }
}