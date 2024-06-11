using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class SeleccionOperacionState : ICajeroState
    {
        private CajeroAutomatico cajero;
        public SeleccionOperacionState(CajeroAutomatico cajero)
        {
            this.cajero = cajero;
        }

        public void IniciarSesion(string pin)
        {
            MessageBox.Show("Ya has iniciado sesión");
        }

        public void SeleccionarOperacion()
        {
            MessageBox.Show("Operación seleccionada");

            if (cajero.OperacionActual is VerificarSaldoOperacion)
            {
                cajero.CambiarEstado(new RealizarOperacionState(cajero, new VerificarSaldoOperacion(cajero)));
            }
            else if (cajero.OperacionActual is DepositarOperacion)
            {
                cajero.CambiarEstado(new RealizarOperacionState(cajero, new DepositarOperacion(cajero)));
            }
            else if (cajero.OperacionActual is RetirarOperacion)
            {
                cajero.CambiarEstado(new RealizarOperacionState(cajero, new RetirarOperacion(cajero)));
            }
        }

        public void RealizarOperacion()
        {
            MessageBox.Show("Debes seleccionar una operación");
        }

        public void CerrarSesion()
        {
            cajero.CambiarEstado(new InicioSesionState(cajero));
            MessageBox.Show("Sesión cerrada");
        }
        public void VerificarSaldo()
        {
            MessageBox.Show("Esta operación no está disponible en el estado actual");
        }
    }
}
