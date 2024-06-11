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
    public partial class FrmLogin : Form
    {
        private CajeroAutomatico cajero;
        public FrmLogin()
        {
            cajero = new CajeroAutomatico();
            InitializeComponent();
            txtPIN.Enabled = false;
            txtPIN.UseSystemPasswordChar = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string pin = txtPIN.Text;

            cajero.IniciarSesion(pin);

            if (cajero.Estado is SeleccionOperacionState)
            {
                FrmOperaciones frmOperaciones = new FrmOperaciones(cajero);
                frmOperaciones.Show();
                Hide();
            }
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "1";
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "2";
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "3";
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "4";
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "5";
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "6";
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "7";
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "8";
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "9";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtPIN.Text += "0";
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tarjeta insertada con exito");
            txtPIN.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn03.Enabled = true;
            btn04.Enabled = true;
            btn05.Enabled = true;
            btn06.Enabled = true;
            btn07.Enabled = true;
            btn08.Enabled = true;
            btn09.Enabled = true;
            btn00.Enabled = true;
            btnEliminar.Enabled = true;
            btnIniciarSesion.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPIN.Text))
            {
                txtPIN.Text = txtPIN.Text.Substring(0, txtPIN.Text.Length - 1);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
