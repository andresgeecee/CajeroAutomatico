using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public class RetirarOperacion : IOperacionCajero
    {
        private CajeroAutomatico cajero;

        public RetirarOperacion(CajeroAutomatico cajero)
        {
            this.cajero = cajero;
        }

        public void Realizar()
        {
            string montoStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto:", "Retirar");
            if (!string.IsNullOrEmpty(montoStr) && decimal.TryParse(montoStr, out decimal monto))
            {
                if (cajero.Saldo >= monto)
                {
                    cajero.Retirar(monto);
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
            }
            else
            {
                MessageBox.Show("Monto inválido");
            }
        }
    }
}
