﻿using Laboratorio_8;

internal class Program          //Laboratorio 8-1
{
    public static void Main(String[]args)
    {
        Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
        Console.WriteLine("Nombre=" + p.Nombre);
        Console.WriteLine("Edad=" + p.Edad);
        Console.WriteLine("NIF=" + p.NIF);
        Console.WriteLine("Sueldo=" + p.Sueldo);
        Console.ReadKey();
    }
}