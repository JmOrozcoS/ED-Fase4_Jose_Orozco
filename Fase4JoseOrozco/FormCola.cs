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
    public partial class FormCola : Form
    {
        //Varables de clase para metodo ValidarFormulario
        private string strIdCliente;
        private string srtcbNempresa;
        private string strtxtNcliente;
        private string srtcbNDestino;
        private int totalRegistros;
        private int Consecutivo = 0;

        //Instanciar a las clases a trabajar
        private Queue<ColaViaje> MyColaViaje = new Queue<ColaViaje>();
        
        public FormCola()
        {
            InitializeComponent();
            this.ItemMenuEliminar.Enabled = false;
            this.ItemMenuReporte.Enabled = false;
            CargarElementos(); //LLamar al metodo
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenu formM = new FormMenu();
            formM.Show();
            this.Hide();

        }

        private void CargarElementos()
        {

            //Limpiar campos
            txtNumViaje.Text = "";
            txtNumViaje.Text = "";
            txtIdCliente.Text = "";
            txtNcliente.Text = "";
            this.dtFechaPago.Value = DateTime.Now;
            this.cbNDestino.Items.Clear();


            //Agregar elementos al cb
            this.cbNDestino.Items.Clear();
            this.cbNDestino.Items.Add("Bogotá");
            this.cbNDestino.Items.Add("Medellín");
            this.cbNDestino.Items.Add("Cali");
            this.cbNDestino.Items.Add("Cartgena");
            this.cbNDestino.Items.Add("florencia");

            //Agregar elementos al cb
            this.cbNempresa.Items.Clear();
            this.cbNempresa.Items.Add("Empresa 1");
            this.cbNempresa.Items.Add("Empresa 2");
            this.cbNempresa.Items.Add("Empresa 3");
            this.cbNempresa.Items.Add("Empresa 4");
            this.cbNempresa.Items.Add("Empresa 6");

        }

        private void ItemMenuRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                ColaViaje MyViaje = new ColaViaje();

                string prefijo = "Ticket-";//Variable para concatenar con el consecutivo del Ticket
                Consecutivo += 1; // incrementar el valor
                string Fact = prefijo + Consecutivo;

                //asignar los valores de los campos al objeto de clase MyViaje
                txtNumViaje.Text = Fact;
                MyViaje.NumViaje = txtNumViaje.Text;
                MyViaje.IdCliente = strIdCliente;
                MyViaje.Nempresa = srtcbNempresa;
                MyViaje.NCliente = strtxtNcliente;
                MyViaje.NDestino = srtcbNDestino;
                this.totalRegistros = this.totalRegistros += 1;

                //Agregar elementos a la Cola
                MyColaViaje.Enqueue(MyViaje);
                dgCola.DataSource = null;
                dgCola.DataSource = MyColaViaje.ToArray();
            
                //Habilitar los botones
                this.ItemMenuEliminar.Enabled = true;
                this.ItemMenuReporte.Enabled = true;

                MessageBox.Show("Se agregó el registro");
                CargarElementos();
            }
        }

        private bool ValidarFormulario()
        {
            string strmsg = "";

            //asignar las variables de clase
            this.strIdCliente = this.txtIdCliente.Text.Trim();
            this.srtcbNempresa = this.cbNempresa.Text.Trim();
            this.strtxtNcliente = this.txtNcliente.Text.Trim();
            this.srtcbNDestino = this.cbNDestino.Text.Trim();


            //Validar si los campos estan vacios asiganr un mensaje a la varialbe strmsg
            if (this.strIdCliente.Equals(""))
            {
                strmsg = strmsg + "- Número de identificacion \n";
                this.txtIdCliente.Focus();
            }
            else
            {
                int intidentificacion = 0;
                bool esnumero = int.TryParse(this.strIdCliente, out intidentificacion);
                if (!esnumero)
                {
                    strmsg = strmsg + "- La identificacion debe ser un valor númerico\n";
                }
            }

            if (this.cbNempresa.SelectedIndex.Equals(-1))
            {
                strmsg = strmsg + "- La empresa debe ser un texto de la lista\n";
                this.cbNempresa.Focus();
            }


            if (this.strtxtNcliente.Equals(""))
            {
                strmsg = strmsg + "- Nombre del cliente \n";
                this.txtNcliente.Focus();
            }
            else
            {
                int intnombre = 0;
                bool esnumero = int.TryParse(this.strtxtNcliente, out intnombre);
                if (!esnumero)
                {
                    
                }
                else
                {
                    strmsg = strmsg + "- El nombre debe ser un texto\n";
                }
            }

            if (this.cbNDestino.SelectedIndex.Equals(-1))
            {
                strmsg = strmsg + "- El destino debe ser un texto de la lista\n";
                this.cbNDestino.Focus();
            }

            // si la variable strmsg no esta vacía
            if (!strmsg.Equals(""))
            {
                strmsg = "Debe diligeciar los siguientes campos: \n ********** \n\n" + strmsg;
                MessageBox.Show(strmsg, "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }

        }


        private void ItemMenuEliminar_Click(object sender, EventArgs e)
        {

            if (MyColaViaje.Count() > 0)
            {
                DialogResult result = MessageBox.Show("Seguro que dese eliminar?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ColaViaje MyViaje = new ColaViaje();

                    Consecutivo -= 1;

                    MyViaje = MyColaViaje.Dequeue();
                    txtNumViaje.Text = MyViaje.NumViaje;
                    txtIdCliente.Text = MyViaje.IdCliente;
                    cbNempresa.Text = MyViaje.Nempresa;
                    txtNcliente.Text = MyViaje.NCliente.ToString();
                    cbNDestino.Text = MyViaje.NDestino.ToString();
                    this.totalRegistros = this.totalRegistros -= 1;
                    dgCola.DataSource = MyColaViaje.ToArray();
                    MessageBox.Show("Se eliminó el registro");
                }
                else if (result == DialogResult.No)
                {
                  
                }
            }
            else
            {
                string stmsg = "No hay elementos";
                MessageBox.Show(stmsg, "", MessageBoxButtons.OK);

                this.ItemMenuEliminar.Enabled = false;
                this.ItemMenuReporte.Enabled = false;

            }
        }

        private void ItemMenuReporte_Click(object sender, EventArgs e)
        {
            this.txtTotalR.Text = this.totalRegistros.ToString();
        }

        private void ItemMenuSalir_Click(object sender, EventArgs e)
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
