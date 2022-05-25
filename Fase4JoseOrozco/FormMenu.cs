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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
           /* Form FormP = new FormPila();
            FormP.Show();
            this.Hide();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void btnCola_Click(object sender, EventArgs e)
        {
           /* FormCola FormC = new FormCola();
            FormC.Show();
            this.Hide();*/
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            /*FormLista FormL = new FormLista();
            FormL.Show();
            this.Hide();*/
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEsc1 Esc1 = new FormEsc1();
            Esc1.Show();

        }
    }
}
