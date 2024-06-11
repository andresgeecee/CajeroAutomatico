using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class VerificarSaldoOperacion : IOperacionCajero
    {
        private CajeroAutomatico cajero;

        public VerificarSaldoOperacion(CajeroAutomatico cajero)
        {
            this.cajero = cajero;
        }

        public void Realizar()
        {
            MessageBox.Show("Tu saldo es: " + cajero.Saldo.ToString());
        }
    }
}
