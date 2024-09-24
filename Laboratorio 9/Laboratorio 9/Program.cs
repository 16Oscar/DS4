internal class Program             //Laboratorio 9-1
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese el precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        while (precio <= 0)
        {
            Console.WriteLine("El precio ingresado no es válido, ingrese un valor positivo: ");
            precio = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Ingrese la forma de pago (efectivo o tarjeta: ");
        string formaDePago = Console.ReadLine().ToLower();

        if (formaDePago == "tarjeta")
        {
            Console.WriteLine("Ingrese su número de cuenta(16 dígitos): ");
            string numeroDeCuenta = Console.ReadLine();

            while (numeroDeCuenta.Length != 16 || !long.TryParse(numeroDeCuenta,out _))
            {
                Console.WriteLine("Número de cuenta inválido, Ingrese el número nuevamente: ");
                numeroDeCuenta = Console.ReadLine();
            }
            Console.WriteLine("Pago exitoso con tarjeta.");
        }
        else
        {
            Console.WriteLine("Pago realizado en efectivo.");
        }
    }
}