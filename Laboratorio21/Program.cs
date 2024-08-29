
internal class Program
{ 
    private static void Main()
    {
        Class2 object1 = new Class2();
        object1.nombre = "Oscar";
        object1.edad = 20;

        Class2 object2 = object1; //Asignación de una variable a otra

        Class2.Valor = 1;
        Console.WriteLine(Class2.Valor);      
    }

}

    public class Class2
    {
        public static int Valor;

    }

    

    
