using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class CajeroAutomatico
    {
        private ICajeroState estado;
        private decimal saldo;
        public IOperacionCajero OperacionActual { get; set; }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public ICajeroState Estado
        {
            get { return estado; }
        }
        public CajeroAutomatico()
        {
            estado = new InicioSesionState(this);
        }

        public void CambiarEstado(ICajeroState nuevoEstado)
        {
            estado = nuevoEstado;
        }

        public void IniciarSesion(string pin)
        {
            estado.IniciarSesion(pin);
        }

        public void SeleccionarOperacion()
        {
            estado.SeleccionarOperacion();
        }

        public void RealizarOperacion()
        {
            estado.RealizarOperacion();
        }

        public void CerrarSesion()
        {
            estado.CerrarSesion();
        }
        public void VerificarSaldo()
        {
            estado.VerificarSaldo();
        }
        
        public void Depositar(decimal monto)
        {
            saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            if (saldo >= monto)
            {
                saldo -= monto;
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
    }
}
