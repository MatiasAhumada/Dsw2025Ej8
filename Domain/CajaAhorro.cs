
using static Dsw2025Ej8.Domain.Excepciones;

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
            if (monto <= 0)
                throw new MontoNoValido();

            if (_estado != Estado.Activa)
                throw new CuentaNoActiva(_estado);

            _saldo += monto;
    }
    public override void Retirar (decimal monto)
    {
        if (monto <= 0)
            throw new MontoNoValido();

        if (_estado != Estado.Activa)
            throw new CuentaNoActiva(_estado);

        if (_saldo >= monto)
        {
            _saldo -= monto;
        }
        else
        {
            _estado = Estado.Suspendida;
            throw new SaldoInsuficiente();
        }
    }
    public override void AplicarInteres()
    {
        _saldo += _saldo * _tasaDeInteres;
    }
}

