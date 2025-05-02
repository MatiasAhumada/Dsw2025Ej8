using static Dsw2025Ej8.Domain.Excepciones;
using System;

namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    public TipoCuenta _tipo;
    public string _numero { get; }
    public decimal _saldo { get; set; }
    public Estado _estado { get; set; } = Estado.Activa;
    public string[] _titulares {get;}

    protected CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _titulares = titulares;
    }
  
    public abstract void Depositar(decimal monto);
    public abstract void Retirar(decimal monto);
    public virtual void AplicarInteres() { }
   
}
