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
    public partial class FormEsc2 : Form

    {

        //Se define una variable para el uso de la fuente en todos los dibujos
        private Font font;

        public FormEsc2()
        {
            InitializeComponent();
            mostarIntro();
            font = new Font("Century Gothic", 10);
            this.MouseMove += FormEsc1_MouseMove;
        }

        private void mostarIntro()
        {
            this.lblEsc2.Visible = true;
        }

        private void ocultarIntro()
        {
            this.lblEsc2.Visible = false;
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
            Nodo.DrawString("26",font, Brushes.White, 390, 73);
            Pen BordeNodoRaiz = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeNodoRaiz, 375, 56, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 775, 156, 50, 50);
            Nodo.DrawString("31", font, Brushes.White, 790, 173);
            Pen BordeNodoDer3 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeNodoDer3, 775, 156, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 275, 156, 50, 50);
            Nodo.DrawString("20", font, Brushes.White, 290, 173);
            Pen BordeSubNodoIzq1 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq1, 275, 156, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 675, 256, 50, 50);
            Nodo.DrawString("28", font, Brushes.White, 690, 273);
            Pen BordeSubNodoIzq6 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq6, 675, 256, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 875, 256, 50, 50);
            Nodo.DrawString("55", font, Brushes.White, 890, 273);
            Pen BordeSubNodoDer4 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer4, 875, 256, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 775, 356, 50, 50);
            Nodo.DrawString("37", font, Brushes.White, 790, 373);
            Pen BordeSubNodoIzq7 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq7, 775, 356, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 175, 256, 50, 50);
            Nodo.DrawString("17", font, Brushes.White, 190, 273);
            Pen BordeSubNodoIzq2 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq2, 175, 256, 50, 50);

            //Subnodo der
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 445, 256, 50, 50);
            Nodo.DrawString("25", font, Brushes.White, 460, 273);
            Pen BordeSubNodoDer1 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer1, 445, 256, 50, 50);

            //Subnodo iz
            Nodo = CreateGraphics();

            Nodo.FillEllipse(Brushes.DarkGray, 345, 356, 50, 50);
            Nodo.DrawString("24", font, Brushes.White, 360, 373);
            Pen BordeSubNodoIzq4 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq4, 345, 356, 50, 50);


            //Creación de las lineas que conectan los Nodos

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq1 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq1, 325, 160, 385, 100);

            //Linea1 Arbol Izquierdo
            Pen lineaNodoIzq2 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoIzq2, 225, 260, 285, 200);

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
            Nodo.DrawLine(lineaNodoDer1, 425, 90, 774, 180);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer2 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer2, 325, 200, 445, 266);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer4 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer4, 815, 200, 875, 260);

        }

        private void escenario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarIntro();

            //Creacion del recorrido en preorden
            Graphics Orden;
            Orden = CreateGraphics();

            Orden.DrawString("PreOrden: ", font, Brushes.DarkBlue, 80, 460);
            Orden.DrawString("26: ", font, Brushes.Black, 174, 460);
            Pen NodoPreOrden1 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden1, 160, 444, 50, 50);

            Orden.DrawString("20: ", font, Brushes.Black, 226, 460);
            Pen NodoPreOrden2 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden2, 212, 444, 50, 50);

            Orden.DrawString("17: ", font, Brushes.Black, 278, 460);
            Pen NodoPreOrden3 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden3, 264, 444, 50, 50);

            Orden.DrawString("25: ", font, Brushes.Black, 330, 460);
            Pen NodoPreOrden4 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden4, 316, 444, 50, 50);

            Orden.DrawString("24: ", font, Brushes.Black, 382, 460);
            Pen NodoPreOrden5 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden5, 368, 444, 50, 50);

            Orden.DrawString("31: ", font, Brushes.Black, 434, 460);
            Pen NodoPreOrden6 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden6, 420, 444, 50, 50);

            Orden.DrawString("28: ", font, Brushes.Black, 486, 460);
            Pen NodoPreOrden7 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden7, 472, 444, 50, 50);

            Orden.DrawString("55: ", font, Brushes.Black, 538, 460);
            Pen NodoPreOrden8 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden8, 524, 444, 50, 50);

            Orden.DrawString("37: ", font, Brushes.Black, 590, 460);
            Pen NodoPreOrden9 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPreOrden9, 576, 444, 50, 50);


            //Creacion del recorrido en InOrden
           
            Orden.DrawString("InOrden: ", font, Brushes.DarkBlue, 80, 520);
            Orden.DrawString("17: ", font, Brushes.Black, 174, 520);
            Pen NodoInOrden1 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden1, 160, 504, 50, 50);

            Orden.DrawString("20: ", font, Brushes.Black, 226, 520);
            Pen NodoInOrden2 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden2, 212, 504, 50, 50);

            Orden.DrawString("24: ", font, Brushes.Black, 278, 520);
            Pen NodoInOrden3 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden3, 264, 504, 50, 50);

            Orden.DrawString("25: ", font, Brushes.Black, 330, 520);
            Pen NodoInOrden4 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden4, 316, 504, 50, 50);

            Orden.DrawString("26: ", font, Brushes.Black, 382, 520);
            Pen NodoInOrden5 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden5, 368, 504, 50, 50);

            Orden.DrawString("28: ", font, Brushes.Black, 434, 520);
            Pen NodoInOrden6 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden6, 420, 504, 50, 50);

            Orden.DrawString("31: ", font, Brushes.Black, 486, 520);
            Pen NodoInOrden7 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden7, 472, 504, 50, 50);

            Orden.DrawString("37: ", font, Brushes.Black, 538, 520);
            Pen NodoInOrden8 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden8, 524, 504, 50, 50);

            Orden.DrawString("55: ", font, Brushes.Black, 590, 520);
            Pen NodoInOrden9 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoInOrden9, 576, 504, 50, 50);
  

            //Creacion del recorrido en PostOrden
            

            Orden.DrawString("PostOrden: ", font, Brushes.DarkBlue, 80, 580);
            Orden.DrawString("17: ", font, Brushes.Black, 174, 580);
            Pen NodoPostOrden1 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden1, 160, 564, 50, 50);

            Orden.DrawString("24: ", font, Brushes.Black, 226, 580);
            Pen NodoPostOrden2 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden2, 212, 564, 50, 50);

            Orden.DrawString("25: ", font, Brushes.Black, 278, 580);
            Pen NodoPostOrden3 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden3, 264, 564, 50, 50);

            Orden.DrawString("20: ", font, Brushes.Black, 330, 580);
            Pen NodoPostOrden4 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden4, 316, 564, 50, 50);

            Orden.DrawString("28: ", font, Brushes.Black, 382, 580);
            Pen NodoPostOrden5 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden5, 368, 564, 50, 50);

            Orden.DrawString("37: ", font, Brushes.Black, 434, 580);
            Pen NodoPostOrden6 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden6, 420, 564, 50, 50);

            Orden.DrawString("55: ", font, Brushes.Black, 486, 580);
            Pen NodoPostOrden7 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden7, 472, 564, 50, 50);

            Orden.DrawString("31: ", font, Brushes.Black, 538, 580);
            Pen NodoPostOrden8 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden8, 524, 564, 50, 50);

            Orden.DrawString("26: ", font, Brushes.Black, 590, 580);
            Pen NodoPostOrden9 = new Pen(Color.LightBlue, 2);
            Orden.DrawEllipse(NodoPostOrden9, 576, 564, 50, 50);


        }
    }
}
