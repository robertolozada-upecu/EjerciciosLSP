namespace EjerciciosLSP.Ejercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var camaraNueva = new CamaraNueva("Camara Nueva");
            var mostradorCamara = new MostradorCamara(camaraNueva);
            mostradorCamara.Mostrar();
 
            var camaraSinNombre = new CamaraSinNombre();
            mostradorCamara = new MostradorCamara(camaraSinNombre);
            mostradorCamara.Mostrar();
        }
    }
}