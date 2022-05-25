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

            Nodo.FillEllipse(Brushes.DarkGray, 775, 156, 50, 50);
            Nodo.DrawString("60", font, Brushes.White, 790, 173);
            Pen BordeNodoDer3 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeNodoDer3, 775, 156, 50, 50);

            //Subnodo iz

            Nodo.FillEllipse(Brushes.DarkGray, 275, 156, 50, 50);
            Nodo.DrawString("40", font, Brushes.White, 290, 173);
            Pen BordeSubNodoIzq1 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq1, 275, 156, 50, 50);

            //Subnodo iz

            Nodo.FillEllipse(Brushes.DarkGray, 675, 256, 50, 50);
            Nodo.DrawString("55", font, Brushes.White, 690, 273);
            Pen BordeSubNodoIzq6 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq6, 675, 256, 50, 50);

            //Subnodo der

            Nodo.FillEllipse(Brushes.DarkGray, 875, 256, 50, 50);
            Nodo.DrawString("70", font, Brushes.White, 890, 273);
            Pen BordeSubNodoDer4 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer4, 875, 256, 50, 50);

            //Subnodo iz

            Nodo.FillEllipse(Brushes.DarkGray, 775, 356, 50, 50);
            Nodo.DrawString("65", font, Brushes.White, 790, 373);
            Pen BordeSubNodoIzq7 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq7, 775, 356, 50, 50);

            //Subnodo der

            Nodo.FillEllipse(Brushes.DarkGray, 975, 356, 50, 50);
            Nodo.DrawString("75", font, Brushes.White, 990, 373);
            Pen BordeSubNodoDer5 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer5, 975, 356, 50, 50);

            //Subnodo iz

            Nodo.FillEllipse(Brushes.DarkGray, 175, 256, 50, 50);
            Nodo.DrawString("30", font, Brushes.White, 190, 273);
            Pen BordeSubNodoIzq2 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq2, 175, 256, 50, 50);

            //Subnodo der

            Nodo.FillEllipse(Brushes.DarkGray, 445, 256, 50, 50);
            Nodo.DrawString("45", font, Brushes.White, 460, 273);
            Pen BordeSubNodoDer1 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoDer1, 445, 256, 50, 50);

            //Subnodo iz

            Nodo.FillEllipse(Brushes.DarkGray, 345, 356, 50, 50);
            Nodo.DrawString("42", font, Brushes.White, 360, 373);
            Pen BordeSubNodoIzq4 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq4, 345, 356, 50, 50);

            //Subnodo iz

            Nodo.FillEllipse(Brushes.DarkGray, 75, 356, 50, 50);
            Nodo.DrawString("25", font, Brushes.White, 90, 373);
            Pen BordeSubNodoIzq3 = new Pen(Color.LightBlue, 3);
            Nodo.DrawEllipse(BordeSubNodoIzq3, 75, 356, 50, 50);

            //Subnodo der

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
            Nodo.DrawLine(lineaNodoDer1, 425, 90, 774, 180);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer2 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer2, 325, 200, 445, 266);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer3 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer3, 215, 300, 275, 360);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer4 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer4, 815, 200, 875, 260);

            //Linea1 Arbol Derecho
            Pen lineaNodoDer5 = new Pen(Color.Black, 3);
            Nodo.DrawLine(lineaNodoDer5, 915, 300, 975, 360);


        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarIntro();

            //Creacion del recorrido en preorden
            Graphics PreOrden;
            PreOrden = CreateGraphics();

            PreOrden.DrawString("PreOrden: ", font, Brushes.DarkBlue, 80, 460);
            PreOrden.DrawString("50: ", font, Brushes.Black, 174, 460);
            Pen NodoPreOrden1 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden1, 160, 444, 50, 50);

            PreOrden.DrawString("40: ", font, Brushes.Black, 226, 460);
            Pen NodoPreOrden2 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden2, 212, 444, 50, 50);

            PreOrden.DrawString("30: ", font, Brushes.Black, 278, 460);
            Pen NodoPreOrden3 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden3, 264, 444, 50, 50);

            PreOrden.DrawString("25: ", font, Brushes.Black, 330, 460);
            Pen NodoPreOrden4 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden4, 316, 444, 50, 50);

            PreOrden.DrawString("35: ", font, Brushes.Black, 382, 460);
            Pen NodoPreOrden5 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden5, 368, 444, 50, 50);

            PreOrden.DrawString("45: ", font, Brushes.Black, 434, 460);
            Pen NodoPreOrden6 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden6, 420, 444, 50, 50);

            PreOrden.DrawString("42: ", font, Brushes.Black, 486, 460);
            Pen NodoPreOrden7 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden7, 472, 444, 50, 50);

            PreOrden.DrawString("60: ", font, Brushes.Black, 538, 460);
            Pen NodoPreOrden8 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden8, 524, 444, 50, 50);

            PreOrden.DrawString("55: ", font, Brushes.Black, 590, 460);
            Pen NodoPreOrden9 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden9, 576, 444, 50, 50);

            PreOrden.DrawString("70: ", font, Brushes.Black, 642, 460);
            Pen NodoPreOrden10 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden10, 628, 444, 50, 50);
            
            PreOrden.DrawString("65: ", font, Brushes.Black, 694, 460);
            Pen NodoPreOrden11 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden11, 680, 444, 50, 50);
            
            PreOrden.DrawString("75: ", font, Brushes.Black, 746, 460);
            Pen NodoPreOrden12 = new Pen(Color.LightBlue, 2);
            PreOrden.DrawEllipse(NodoPreOrden12, 732, 444, 50, 50);

        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarIntro();

            //Creacion del recorrido en InOrden
            Graphics InOrden;
            InOrden = CreateGraphics();

            InOrden.DrawString("InOrden: ", font, Brushes.DarkBlue, 80, 520);
            InOrden.DrawString("25: ", font, Brushes.Black, 174, 520);
            Pen NodoInOrden1 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden1, 160, 504, 50, 50);

            InOrden.DrawString("30: ", font, Brushes.Black, 226, 520);
            Pen NodoInOrden2 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden2, 212, 504, 50, 50);

            InOrden.DrawString("35: ", font, Brushes.Black, 278, 520);
            Pen NodoInOrden3 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden3, 264, 504, 50, 50);

            InOrden.DrawString("40: ", font, Brushes.Black, 330, 520);
            Pen NodoInOrden4 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden4, 316, 504, 50, 50);

            InOrden.DrawString("42: ", font, Brushes.Black, 382, 520);
            Pen NodoInOrden5 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden5, 368, 504, 50, 50);

            InOrden.DrawString("45: ", font, Brushes.Black, 434, 520);
            Pen NodoInOrden6 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden6, 420, 504, 50, 50);

            InOrden.DrawString("50: ", font, Brushes.Black, 486, 520);
            Pen NodoInOrden7 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden7, 472, 504, 50, 50);

            InOrden.DrawString("55: ", font, Brushes.Black, 538, 520);
            Pen NodoInOrden8 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden8, 524, 504, 50, 50);

            InOrden.DrawString("60: ", font, Brushes.Black, 590, 520);
            Pen NodoInOrden9 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden9, 576, 504, 50, 50);

            InOrden.DrawString("65: ", font, Brushes.Black, 642, 520);
            Pen NodoInOrden10 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden10, 628, 504, 50, 50);

            InOrden.DrawString("70: ", font, Brushes.Black, 694, 520);
            Pen NodoInOrden11 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden11, 680, 504, 50, 50);

            InOrden.DrawString("75: ", font, Brushes.Black, 746, 520);
            Pen NodoInOrden12 = new Pen(Color.LightBlue, 2);
            InOrden.DrawEllipse(NodoInOrden12, 732, 504, 50, 50);
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarIntro();

            //Creacion del recorrido en PostOrden
            Graphics PostOrden;
            PostOrden = CreateGraphics();

            PostOrden.DrawString("PostOrden: ", font, Brushes.DarkBlue, 80, 580);
            PostOrden.DrawString("25: ", font, Brushes.Black, 174, 580);
            Pen NodoPostOrden1 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden1, 160, 564, 50, 50);

            PostOrden.DrawString("30: ", font, Brushes.Black, 226, 580);
            Pen NodoPostOrden2 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden2, 212, 564, 50, 50);

            PostOrden.DrawString("35: ", font, Brushes.Black, 278, 580);
            Pen NodoPostOrden3 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden3, 264, 564, 50, 50);

            PostOrden.DrawString("40: ", font, Brushes.Black, 330, 580);
            Pen NodoPostOrden4 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden4, 316, 564, 50, 50);

            PostOrden.DrawString("42: ", font, Brushes.Black, 382, 580);
            Pen NodoPostOrden5 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden5, 368, 564, 50, 50);

            PostOrden.DrawString("45: ", font, Brushes.Black, 434, 580);
            Pen NodoPostOrden6 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden6, 420, 564, 50, 50);

            PostOrden.DrawString("50: ", font, Brushes.Black, 486, 580);
            Pen NodoPostOrden7 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden7, 472, 564, 50, 50);

            PostOrden.DrawString("55: ", font, Brushes.Black, 538, 580);
            Pen NodoPostOrden8 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden8, 524, 564, 50, 50);

            PostOrden.DrawString("60: ", font, Brushes.Black, 590, 580);
            Pen NodoPostOrden9 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden9, 576, 564, 50, 50);

            PostOrden.DrawString("65: ", font, Brushes.Black, 642, 580);
            Pen NodoPostOrden10 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden10, 628, 564, 50, 50);

            PostOrden.DrawString("70: ", font, Brushes.Black, 694, 580);
            Pen NodoPostOrden11 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden11, 680, 564, 50, 50);

            PostOrden.DrawString("75: ", font, Brushes.Black, 746, 580);
            Pen NodoPostOrden12 = new Pen(Color.LightBlue, 2);
            PostOrden.DrawEllipse(NodoPostOrden12, 732, 564, 50, 50);
        }
    }
}
