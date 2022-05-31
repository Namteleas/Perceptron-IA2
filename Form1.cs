using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron per;
        Bitmap bmpFondo;
        Bitmap bmpAnimacion;
        Pen planoPen;
        Brush ceroBrush;
        Brush unoBrush;
        List<Entradas> entradas;
        
        public Form1()
        {
            InitializeComponent();
            bmpFondo = new Bitmap(1000, 1000);
            bmpAnimacion = new Bitmap(1000, 1000);
            entradas = new List<Entradas>();
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCanvas.BackgroundImage = bmpFondo;
            pictureBoxCanvas.Image = bmpAnimacion;
            planoPen = new Pen(Color.Black, 4);
            unoBrush = new SolidBrush(Color.Red);
            ceroBrush = new SolidBrush(Color.Blue);
            listBoxEntradas.DataSource = null;
            dibujarCanvas();
        }

        void dibujarCanvas()
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            for(int i = 1; i < 10; i++)
            {
                g.DrawLine(planoPen, i * 100, 0, i * 100, 999);
                g.DrawLine(planoPen, 0, i * 100, 999, i * 100);
            }
            pictureBoxCanvas.Refresh();
        }

        private void buttonPesos_Click(object sender, EventArgs e)
        {
            per = new Perceptron((float)numericUpDownLR.Value);
            mostrarValores();
            dibujarCirculos();
            dibujarPlano();

        }

        private void mostrarValores()
        {
            labelW0.Text = per.Pesos[0].ToString();
            labelW1.Text = per.Pesos[1].ToString();
            labelW2.Text = per.Pesos[2].ToString();
        }
        
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (per == null)
                return;

            bool termino = false;
            int epoca, res;
            epoca = 1;

            while(epoca <= numericUpDownEpocas.Value && !termino)
            {
                dibujarPlano();
                termino = true;

                foreach (Entradas ent in entradas)
                {
                    res = evaluar(ent.X, ent.Y);
                    if (ent.Clase != res)
                    {
                        termino = false;
                        per.actualizar(ent.Clase - res, ent.X, ent.Y);
                        dibujarPlano();
                    }
                }

                epoca++;
            }

            epoca--;

            if (termino)
            {
                string mess = "Convergio en epoca " + epoca.ToString();
                dibujarPlano();
                MessageBox.Show(mess);
            }
            else
                MessageBox.Show("No convirgio");

            buttonEvaluar.Visible = true;
        }

        private int evaluar(float x, float y)
        {
            if ((per.Pesos[1] * x + per.Pesos[2] * y - per.Pesos[0]) >= 0)
                return 1;
            else
                return 0;
        }

        void dibujarPlano()
        {
            float y1, y2, x1, x2;

            Graphics g = Graphics.FromImage(bmpAnimacion);

            g.Clear(Color.Transparent);

            y1 = (per.Pesos[0] - per.Pesos[1] * -5) / per.Pesos[2];
            y2 = (per.Pesos[0] - per.Pesos[1] * 5) / per.Pesos[2];

            x1 = (per.Pesos[0] - per.Pesos[2] * -5) / per.Pesos[1];
            x2 = (per.Pesos[0] - per.Pesos[2] * 5) / per.Pesos[1];

            if(Math.Abs(y1) <= 5 && Math.Abs(y2) <= 5)
                g.DrawLine(planoPen, -5 * 100 + 500, y1 * 100 + 500, 5 * 100 + 500, y2 * 100 + 500);
            else
                g.DrawLine(planoPen, x1 * 100 + 500, -5 * 100 + 500, x2 * 100 + 500, 5 * 100 + 500);

            pictureBoxCanvas.Refresh();
        }

        void evaluar_Canvas()
        {
            float x, y;

            for(float i = 0; i < 1000; i++)    //Y
                for(float j = 0; j < 1000; j++)  //X
                {
                    x = (j - 500) / 100;
                    y = (i - 500) / 100;

                    if ((per.Pesos[1] * x + per.Pesos[2] * y - per.Pesos[0]) >= 0)
                        bmpFondo.SetPixel((int)j, (int)i, Color.DimGray);
                    else
                        bmpFondo.SetPixel((int)j, (int)i, Color.Violet);
                }

            pictureBoxCanvas.Refresh();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            float x, y;

            x = (e.X * 2f - 500f) / 100f;
            y = (e.Y * 2f - 500f) / 100f;

            if(e.Button == MouseButtons.Left) //Clase 0
            {
                entradas.Add(new Entradas(0, x, y));
                g.FillEllipse(ceroBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);
            }
            if(e.Button == MouseButtons.Right) //Clase 1
            {
                entradas.Add(new Entradas(1, x, y));
                g.FillEllipse(unoBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);
            }

            listBoxEntradas.DataSource = null;
            listBoxEntradas.DataSource = entradas;
            pictureBoxCanvas.Refresh();
        }

        private void dibujarCirculos()
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            foreach (Entradas ent in entradas)
            {
                if(ent.Clase == 0)
                    g.FillEllipse(ceroBrush, ent.X * 100 + 490, ent.Y * 100 + 490, 20, 20);
                else
                    g.FillEllipse(unoBrush, ent.X * 100 + 490, ent.Y * 100 + 490, 20, 20);
            }

            pictureBoxCanvas.Refresh();
        }

        private void buttonEvaluar_Click(object sender, EventArgs e)
        {
            evaluar_Canvas();
            dibujarCirculos();
        }
    }
}
