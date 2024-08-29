internal class Program
{
    private static void Main()
    {
        MyClass object1 = new MyClass();

        object1.nombre = "Yeison";
        object1.edad = 28;

        MyClass object2 = object1;

        object2.nombre = "José";

        Console.WriteLine(object2.nombre);
        Console.WriteLine(object1.nombre);
    }

    public class MyClass
    {
       

        
    }
}