using System;

namespace EjerciciosLSP.Ejercicio2
{
    public class MostradorCamara
    {
        private readonly Camara camara;

        public MostradorCamara(Camara camara)
        {
            this.camara = camara;
        }

        public void Mostrar()
        {
            Console.WriteLine(camara.ObtenerNombre());
        }
    }
}