using System;

namespace EjerciciosLSP.Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IColorFruta colorFruta = new Naranja();
            Console.WriteLine(colorFruta.ObtenerColor());
        }
    }
}