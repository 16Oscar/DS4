internal class Program
{
    private static void Main(string[] args)
    {
        Coordenadas1 misCoords = new Coordenadas1(10, 15);
        misCoords.VerCoordenadas();
    }
}
public partial class Coordenadas1
{
    private int x, y;

    public Coordenadas1(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
public partial class Coordenadas1
{
    public void VerCoordenadas()
    {
        Console.WriteLine("Coordenadas: {1}, {0}", x, y);
    }
}