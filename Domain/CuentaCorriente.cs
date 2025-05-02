

using static Dsw2025Ej8.Domain.Excepciones;

namespace Dsw2025Ej8.Domain;

public class CuentaCorriente : CuentaBancaria
{
    public decimal _limiteDeDescubierto { get; set; }
    public decimal _comision { get; set; }

    public CuentaCorriente(string numero, decimal saldo, string[] titulares, decimal comision, decimal limite)
        : base(numero, saldo, titulares, tipo: TipoCuenta.CuentaCorriente)
    {
        _comision = comision;
        _limiteDeDescubierto = limite;
    }
    public override void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        else if (_estado != Estado.Activa)
        {
            throw new CuentaNoActiva(_estado);
        }
        else
        {
            decimal montoConDescuento = monto * (1 - (_comision/100));
            _saldo += montoConDescuento;
        }
    }
    public override void Retirar(decimal monto)
    {
        if (monto <= 0)
            throw new MontoNoValido();

        if (_estado != Estado.Activa)
            throw new CuentaNoActiva(_estado);

        if (_saldo - monto >= -_limiteDeDescubierto)
        {
            _saldo -= monto;
        }
        else
        {
            _estado = Estado.Suspendida;
            throw new SaldoInsuficiente();
        }
    }
    public override void Mostrar()
    {
        Console.WriteLine($"\nNumero de Cuenta: {_numero}\nTipo de Cuenta: {_tipo}\nSaldo de Cuenta: {_saldo}");
    }
}

