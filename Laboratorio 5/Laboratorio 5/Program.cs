internal class Program //Laboratorio 5-1
{
    private int[] sueldos;
    public void Cargar()
    {
        sueldos = new int[6];
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operador" + f + ": ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); //Asignamos los 5 sueldos al vector
        }
    }
    public void Imprimir()
    {
        Console.Write("Los 5 sueldos de los operadores \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("["+ sueldos[f]+"]");
        }
        Console.ReadKey();
    }

    private static void Main(string[] args)
    {
        Program programa = new Program();

        programa.Cargar();
        programa.Imprimir();
    }
}