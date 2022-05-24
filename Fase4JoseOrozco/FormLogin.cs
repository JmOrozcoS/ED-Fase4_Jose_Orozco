using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4JoseOrozco
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {   
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            // validacion de clave generica
            if (txtcontrasena.Text == "123")
            {
                this.Hide();
                FormMenu FormM = new FormMenu();
                FormM.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                txtcontrasena.Clear();
                txtcontrasena.Focus();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {   
            }
 
        }
    }
}
