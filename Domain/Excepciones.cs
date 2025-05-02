using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class Excepciones
    {
        public class MontoNoValido : Exception
        {
            public MontoNoValido()
            {
                Console.WriteLine(" El monto ingresado no es válido para la operación solicitada");
            }
        }

        public class CuentaNoActiva : Exception
        {
            public CuentaNoActiva(Estado estado)
            {
                Console.WriteLine($"No se puede operar con la cuenta {estado.ToString()}");
            }
        }

        public class SaldoInsuficiente : Exception
        {
            public SaldoInsuficiente()
            {
                Console.WriteLine("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
            }
        }
    }
}
