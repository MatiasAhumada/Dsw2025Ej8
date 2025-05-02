using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CuentaCorriente CC1 = new CuentaCorriente("1234", 50000, ["Titular1", "Titula2"], 30, 2000);
                CuentaCorriente CC2 = new CuentaCorriente("1235", 520000, ["Titular1", "Titula2"], 20, 2300);
                CajaAhorro CA1 = new CajaAhorro("2453", 380000, ["Titular7", "Titula8"], 40);
                CajaAhorro CA2 = new CajaAhorro("6789", 150000, ["Titular1", "Titula2"], 15);
                CC1._estado = Estado.Inactiva;
                CC1.Depositar(95000);
                CC2.Depositar(-55000);
                CA1.Depositar(86238);
                CA2.Depositar(67812);
                CC1.Retirar(1500000);
                CC2.Retirar(10000);
                CA1.Retirar(10000);
                CA2.Retirar(1500000);
                CC1.AplicarInteres();
                CC2.AplicarInteres();
                CA1.AplicarInteres();
                CA2.AplicarInteres();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
