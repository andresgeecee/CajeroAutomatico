using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class DepositarOperacion : IOperacionCajero
    {
        private CajeroAutomatico cajero;

        public DepositarOperacion(CajeroAutomatico cajero)
        {
            this.cajero = cajero;
        }

        public void Realizar()
        {
            string montoStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto:", "Depositar");
            if (!string.IsNullOrEmpty(montoStr) && decimal.TryParse(montoStr, out decimal monto))
            {
                cajero.Depositar(monto);
                MessageBox.Show($"Se ha depositado {monto} Bs correctamente.");
            }
            else
            {
                MessageBox.Show("Monto inválido");
            }
        }
    }
}
