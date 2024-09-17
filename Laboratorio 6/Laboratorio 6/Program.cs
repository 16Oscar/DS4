internal class Program          //Laboratorio 6-1
{
    private static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite el número deseado: ");
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex) {
            Console.WriteLine("No ha introducido un dígito válido");
            num = -1;
        }
        Console.WriteLine(num);
    }
}