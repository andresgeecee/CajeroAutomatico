using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class RealizarOperacionState : ICajeroState
    {
        private CajeroAutomatico cajero;
        private IOperacionCajero operacion;

        public RealizarOperacionState(CajeroAutomatico cajero, IOperacionCajero operacion)
        {
            this.cajero = cajero;
            this.operacion = operacion;
        }
        public void IniciarSesion(string pin)
        {
            MessageBox.Show("Ya has iniciado sesión");
        }

        public void SeleccionarOperacion()
        {
            MessageBox.Show("Operación seleccionada");
        }

        public void RealizarOperacion()
        {
            if (operacion != null)
            {
                operacion.Realizar();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una operación");
            }
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
