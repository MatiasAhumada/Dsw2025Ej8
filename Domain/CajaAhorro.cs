
namespace Dsw2025Ej8.Domain;

    public class CajaAhorro : CuentaBancaria
    {
        public decimal _tasaDeInteres {  get; set; }

        public CajaAhorro(string numero,decimal saldo, string[] titulares,decimal tasaInteres)
        :base(numero,saldo,titulares)
        {
            _tasaDeInteres = tasaInteres;
        }
        public override void Depositar(decimal monto)
        {
            _saldo += monto;
        }
    public override void Retirar (decimal monto)
    {
        _saldo -= monto;
    }
    public override void AplicarInteres()
    {
        _saldo += _saldo * _tasaDeInteres;
    }
}

