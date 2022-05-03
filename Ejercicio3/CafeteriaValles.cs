using System;

namespace EjerciciosLSP.Ejercicio3
{
    public class CafeteriaValles : ServicioDomicilio
    {
        public string ServicioDomicilio()
        {
            return "No se realizan pedidos a domicilio";
        }
    }
}