using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CuentaCorriente CC1 = new CuentaCorriente("1234", 50000, ["Titular1", "Titula2"], 30, 2000);
            CuentaCorriente CC2 = new CuentaCorriente("1235", 520000, ["Titular1", "Titula2"], 20, 2300);
            CajaAhorro CA1 = new CajaAhorro("2453", 380000, ["Titular7", "Titula8"], 40);
            CajaAhorro CA2 = new CajaAhorro("6789", 150000, ["Titular1", "Titula2"], 15);

            try
            {
                CC1._estado = Estado.Inactiva;
                CC1.Retirar(500);
                CC1.Depositar(100);
                CC1.AplicarInteres();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            try
            {
                CC2.Depositar(55000);
                CC2.Retirar(150000);
                CC2.AplicarInteres();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            try
            {
                CA1.Depositar(86238);
                CA1.Retirar(100000000);
                CA1.AplicarInteres(); 

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            try
            {
                CA2.Depositar(67812);
                CA2.AplicarInteres();
                CA2.Retirar(1599);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            CC1.Mostrar();
            CC2.Mostrar();
            CA1.Mostrar();
            CA2.Mostrar();
        }
    }
}
