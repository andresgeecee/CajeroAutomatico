using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class FrmOperaciones : Form
    {
        private CajeroAutomatico cajero;
        public FrmOperaciones(CajeroAutomatico cajero)
        {
            this.cajero = cajero;
            InitializeComponent();
            tabControl1.Selecting += TabControl1_Selecting;
            tabPage3.Enabled = false;
            tabPage2.Enabled = false;
        }
        
        private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage3 && !tabPage3.Enabled)
            {
                e.Cancel = true; // Cancelar la selección de tabPage3 si no está habilitada
            }
            else if (e.TabPage == tabPage2 && !tabPage2.Enabled)
            {
                e.Cancel = true; // Cancelar la selección de tabPage2 si no está habilitada
            }
        }
        private void btnVerificarSaldo_Click(object sender, EventArgs e)
        {
            tabPage2.Enabled = true;
            tabPage3.Enabled = false;
            tabControl1.SelectedTab = tabPage2; // Cambiar a la tabPage2 para mostrar el saldo
            lblSaldo.Text = cajero.Saldo.ToString()+" Bs";
            tabPage2.Enabled = false;

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            tabPage3.Enabled = true;
            tabPage2.Enabled = false;
            tabControl1.SelectedTab = tabPage3;
            btnDepositar.Enabled = true;
            btnRetirar.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            tabPage3.Enabled = true;
            tabPage2.Enabled = false;
            tabControl1.SelectedTab = tabPage3;
            btnDepositar.Enabled = false;
            btnRetirar.Enabled = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cajero.CerrarSesion();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            string montoStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el monto:", "Otro Monto");
            if (!string.IsNullOrEmpty(montoStr) && decimal.TryParse(montoStr, out decimal monto))
            {
                if (tabControl1.SelectedTab == tabPage3)
                {
                    if (btnDepositar.Enabled)
                    {
                        cajero.Depositar(monto);
                        MessageBox.Show($"Se ha realizado un depósito de {monto} Bs.");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnRetirar.Enabled = true; // Habilitar el botón de retirar
                        tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                    }
                    else if (btnRetirar.Enabled)
                    {
                        if (cajero.Saldo >= monto)
                        {
                            cajero.Retirar(monto);
                            MessageBox.Show($"Se ha realizado un retiro de {monto} Bs.");
                            tabPage3.Enabled = false;
                            tabPage2.Enabled = false;
                            btnDepositar.Enabled = true; // Habilitar el botón de depositar
                        }
                        else
                        {
                            MessageBox.Show("Saldo insuficiente");
                            tabPage3.Enabled = false;
                            tabPage2.Enabled = false;
                            btnDepositar.Enabled = true; // Habilitar el botón de depositar
                        }
                        tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.");
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (btnDepositar.Enabled)
                {
                    cajero.Depositar(100);
                    MessageBox.Show("Se ha realizado un depósito de 100 Bs.");
                    tabPage3.Enabled = false;
                    tabPage2.Enabled = false;
                    btnRetirar.Enabled = true; // Habilitar el botón de retirar
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
                else if (btnRetirar.Enabled)
                {
                    if (cajero.Saldo >= 100)
                    {
                        cajero.Retirar(100);
                        MessageBox.Show("Se ha realizado un retiro de 100 Bs.");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
            }
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (btnDepositar.Enabled)
                {
                    cajero.Depositar(300);
                    MessageBox.Show("Se ha realizado un depósito de 300 Bs.");
                    tabPage3.Enabled = false;
                    tabPage2.Enabled = false;
                    btnRetirar.Enabled = true; // Habilitar el botón de retirar
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
                else if (btnRetirar.Enabled)
                {
                    if (cajero.Saldo >= 300)
                    {
                        cajero.Retirar(300);
                        MessageBox.Show("Se ha realizado un retiro de 300 Bs.");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (btnDepositar.Enabled)
                {
                    cajero.Depositar(500);
                    MessageBox.Show("Se ha realizado un depósito de 500 Bs.");
                    tabPage3.Enabled = false;
                    tabPage2.Enabled = false;
                    btnRetirar.Enabled = true; // Habilitar el botón de retirar
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
                else if (btnRetirar.Enabled)
                {
                    if (cajero.Saldo >= 500)
                    {
                        cajero.Retirar(500);
                        MessageBox.Show("Se ha realizado un retiro de 500 Bs.");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
            }
        }

        private void btn700_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (btnDepositar.Enabled)
                {
                    cajero.Depositar(700);
                    MessageBox.Show("Se ha realizado un depósito de 700 Bs.");
                    tabPage3.Enabled = false;
                    tabPage2.Enabled = false;
                    btnRetirar.Enabled = true; // Habilitar el botón de retirar
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
                else if (btnRetirar.Enabled)
                {
                    if (cajero.Saldo >= 700)
                    {
                        cajero.Retirar(700);
                        MessageBox.Show("Se ha realizado un retiro de 700 Bs.");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
            }
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (btnDepositar.Enabled)
                {
                    cajero.Depositar(1000);
                    MessageBox.Show("Se ha realizado un depósito de 1000 Bs.");
                    tabPage3.Enabled = false;
                    tabPage2.Enabled = false;
                    btnRetirar.Enabled = true; // Habilitar el botón de retirar
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
                else if (btnRetirar.Enabled)
                {
                    if (cajero.Saldo >= 1000)
                    {
                        cajero.Retirar(1000);
                        MessageBox.Show("Se ha realizado un retiro de 1000 Bs.");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                        tabPage3.Enabled = false;
                        tabPage2.Enabled = false;
                        btnDepositar.Enabled = true; // Habilitar el botón de depositar
                    }
                    tabControl1.SelectedTab = tabPage1; // Redirigir a tabPage1
                }
            }
        }
    }
}
