namespace EjerciciosLSP.Ejercicio2
{
    public class Camara
    {
        private readonly string Nombre;

        public Camara(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string ObtenerNombre() => Nombre;
    }
}