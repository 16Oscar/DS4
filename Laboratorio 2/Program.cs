internal class Program
{
    //Ejemplo de Variable Local
    private static void Sumar(int valor1, int valor2, int valor4)
    {
        int variableLocal = valor1 + valor2;
        Console.WriteLine(variableLocal);


        //Tipos de Datos
        
        int valor3 = 28;
        valor4 = valor3;
        valor4 = 30;

        Console.WriteLine(valor3);
        Console.WriteLine(valor4);


        char caracter = 'A';
        string cadena = "Cadena de caracteres";
        bool condition = true;


    }
    Console.WriteLine(variableLocal); //Si presenta el error
   