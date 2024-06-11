using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class InicioSesionState : ICajeroState
    {
        private CajeroAutomatico cajero;

        public InicioSesionState(CajeroAutomatico cajero)
        {
            this.cajero = cajero;
        }

        public void IniciarSesion(string pin)
        {
            if (VerificarPIN(pin))
            {
                cajero.CambiarEstado(new SeleccionOperacionState(cajero));
                MessageBox.Show("PIN ingresado correctamente");
            }
            else
            {
                MessageBox.Show("PIN incorrecto");
            }
        }

        public void SeleccionarOperacion()
        {
            MessageBox.Show("Debes iniciar sesión primero");
        }

        public void RealizarOperacion()
        {
            MessageBox.Show("Debes iniciar sesión primero");
        }

        public void CerrarSesion()
        {
            MessageBox.Show("Debes iniciar sesión primero");
        }
        public void VerificarSaldo()
        {
            MessageBox.Show("Debes iniciar sesión primero");
        }
        private bool VerificarPIN(string pin)
        {
            return pin == "3699";
        }
    }
}
