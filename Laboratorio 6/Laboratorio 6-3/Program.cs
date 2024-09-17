internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] myNumbers = { 1, 2, 3 };
        }
        catch(Exception) {
            Console.WriteLine("Algo salió mal, valide el índice del arreglo");
        }
        finally
        {
            Console.WriteLine("Continuación de la aplicación, luego del bloque try/catch");
        }
        
    }
}