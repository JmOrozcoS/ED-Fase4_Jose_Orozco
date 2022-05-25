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
    public partial class FormEsc1 : Form

    {

        //Se define una variable para el uso de la fuente en todos los dibujos
        private Font font;

        public FormEsc1()
        {
            InitializeComponent();
            mostarIntro();
            font = new Font("Century Gothic", 10);
            this.MouseMove += FormEsc1_MouseMove;
        }

        private void mostarIntro()
        {
            this.lblEsc1.Visible = true;
        }

        private void ocultarIntro()
        {
            this.lblEsc1.Visible = false;
        }

        private void FormEsc1_MouseMove(object sender, MouseEventArgs e)
        {
            txtPosX.Text = e.X.ToString();
            txtPosY.Text = e.Y.ToString();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarIntro();

            //Creacion de los nodos

            //Nodo raiz

            Graphics Nodo;
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 375, 56, 50, 50);
            Nodo.DrawString("50",font, Brushes.White, 390, 73);
            Pen BordeNodoRaiz = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeNodoRaiz, 375, 56, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 775, 156, 50, 50);
            Nodo.DrawString("60", font, Brushes.White, 790, 173);
            Pen BordeNodoDer3 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeNodoDer3, 775, 156, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 275, 156, 50, 50);
            Nodo.DrawString("40", font, Brushes.White, 290, 173);
            Pen BordeSubNodoIzq1 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq1, 275, 156, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 675, 256, 50, 50);
            Nodo.DrawString("55", font, Brushes.White, 690, 273);
            Pen BordeSubNodoIzq6 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq6, 675, 256, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 875, 256, 50, 50);
            Nodo.DrawString("70", font, Brushes.White, 890, 273);
            Pen BordeSubNodoDer4 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer4, 875, 256, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 775, 356, 50, 50);
            Nodo.DrawString("65", font, Brushes.White, 790, 373);
            Pen BordeSubNodoIzq7 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq7, 775, 356, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 975, 356, 50, 50);
            Nodo.DrawString("75", font, Brushes.White, 990, 373);
            Pen BordeSubNodoDer5 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer5, 975, 356, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 175, 256, 50, 50);
            Nodo.DrawString("30", font, Brushes.White, 190, 273);
            Pen BordeSubNodoIzq2 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq2, 175, 256, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 445, 256, 50, 50);
            Nodo.DrawString("45", font, Brushes.White, 460, 273);
            Pen BordeSubNodoDer1 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer1, 445, 256, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 345, 356, 50, 50);
            Nodo.DrawString("42", font, Brushes.White, 360, 373);
            Pen BordeSubNodoIzq4 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq4, 345, 356, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 75, 356, 50, 50);
            Nodo.DrawString("25", font, Brushes.White, 90, 373);
            Pen BordeSubNodoIzq3 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq3, 75, 356, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 275, 356, 50, 50);
            Nodo.DrawString("35", font, Brushes.White, 290, 373);
            Pen BordeSubNodoDer2 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer2,275, 356, 50, 50);


            //Creación de las lineas que conectan los Nodos

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq1 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq1, 325, 160, 385, 100);

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq2 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq2, 225, 260, 285, 200);

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq3 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq3, 125, 360, 185, 300);

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq4 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq4, 395, 360, 455, 300);

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq5 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq2, 725, 260, 785, 200);

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq6 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq6, 825, 360, 885, 300);



            //Linea1 Arbol Derecho
            Pen lineaNodoDer1 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer1, 325, 200, 445, 266);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer2 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer2, 215, 300, 275, 360);




            //Linea1 Arbol Derecho
            Pen lineaNodoDer4 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer4, 915, 300, 975, 360);






        }
    }
}
