

namespace Dsw2025Ej8.Domain;

    public class CuentaCorriente : CuentaBancaria
    {
    public decimal _limiteDeDescubierto {  get; set; }
    public decimal _comision {  get; set; }
    
    public CuentaCorriente(string numero,decimal saldo, string[] titulares, decimal comision, decimal limite)
        :base(numero,saldo,titulares)
    {
        _comision = comision;
        _limiteDeDescubierto = limite;
    }
    public override void Depositar(decimal monto)
    {
        _saldo += monto - (monto * _comision);
    }
    public override void Retirar(decimal monto)
    {
        if(_saldo-monto >= -_limiteDeDescubierto)
        {
            _saldo -= monto;
        }
        if (_saldo < 0)
        {
            _estado = Estado.Suspendida;
        }
    }
}

