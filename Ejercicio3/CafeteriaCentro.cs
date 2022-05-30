namespace EjerciciosLSP.Ejercicio3
{
    public class CafeteriaCentro : Cafeteria, IServicioDomicilio
    {
        public string ServicioDomicilio()
        {
            return "Servicio en 30 Minutos";
        }
    }
}