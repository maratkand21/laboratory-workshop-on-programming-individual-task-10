using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics g;
        static Color colorFigure = Color.Green;
        Pen p = new Pen(colorFigure);

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            g = CreateGraphics();
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            Refresh();

            p.Color = colorFigure;
            p.Width = trackBar3.Value;

            float widthFigure = trackBar1.Value + 1;
            float heightFigure = trackBar2.Value + 1;

            if (radioButton1.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(p, Width / 2 - 100, 50, 200 / widthFigure, 200 / heightFigure);
            }
            else if (radioButton2.Checked)
            {
                g.FillRectangle(new SolidBrush(colorFigure), new Rectangle(Width / 2 - 100, 50, (int)(200 / widthFigure), (int)(200 / heightFigure)));
            }
            else if (radioButton3.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g.DrawRectangle(p, Width / 2 - 100, 50, 200 / widthFigure, 200 / heightFigure);
            }
        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            Refresh();

            p.Color = colorFigure;
            p.Width = trackBar3.Value;

            float widthFigure = trackBar1.Value + 1;
            float heightFigure = trackBar2.Value + 1;

            if (radioButton1.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawEllipse(p, Width / 2 - 100, 50, 200 / widthFigure, 200 / heightFigure);
            }
            else if (radioButton2.Checked)
            {
                g.FillEllipse(new SolidBrush(colorFigure), new Rectangle(Width / 2 - 100, 50, (int)(200 / widthFigure), (int)(200 / heightFigure)));
            }
            else if (radioButton3.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g.DrawEllipse(p, Width / 2 - 100, 50, 200 / widthFigure, 200 / heightFigure);
            }
        }

        private void select_color(object sender, EventArgs e)
        {
            string selectedColor = listBox1.SelectedItem.ToString();

            switch(selectedColor)
            {
                case ("Красный"):
                    colorFigure = Color.Red;
                    break;
                case ("Синий"):
                    colorFigure = Color.Blue;
                    break;
                case ("Оранжевый"):
                    colorFigure = Color.Orange;
                    break;
                case ("Желтый"):
                    colorFigure = Color.Yellow;
                    break;
                case ("Черный"):
                    colorFigure = Color.Black;
                    break;
                case ("Розовый"):
                    colorFigure = Color.Pink;
                    break;
                case ("Белый"):
                    colorFigure = Color.White;
                    break;
                case ("Зеленый"):
                    colorFigure = Color.Green;
                    break;
            }
        }

        private void triangle_button_click(object sender, EventArgs e)
        {
            Refresh();

            p.Color = colorFigure;
            p.Width = trackBar3.Value;

            float widthFigure = trackBar1.Value + 1;
            float heightFigure = trackBar2.Value + 1;

            PointF[] cords =
             {
                 new PointF(250 + ((widthFigure > 2) ? widthFigure * 10 : 1),  250 - ((heightFigure > 2) ? heightFigure * 10 : 1)),
                 new PointF(350, 50),
                 new PointF(450 - ((widthFigure > 2) ? widthFigure * 10 : 1),  250 - ((heightFigure > 2) ? heightFigure * 10 : 1)),
                 new PointF(250 + ((widthFigure > 2) ? widthFigure * 10 : 1),  250 - ((heightFigure > 2) ? heightFigure * 10 : 1))
            };

            if (radioButton1.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLines(p, cords);
            }
            else if (radioButton2.Checked)
            {
                g.FillPolygon(new SolidBrush(colorFigure), cords);
            }
            else if (radioButton3.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g.DrawLines(p, cords);
            }
        }

        private void poligon_button_click(object sender, EventArgs e)
        {
            Refresh();

            p.Color = colorFigure;
            p.Width = trackBar3.Value;

            float widthFigure = trackBar1.Value + 1;
            float heightFigure = trackBar2.Value + 1;
        
            PointF[] cords = {
                 new PointF(275 + ((widthFigure > 2) ? widthFigure * 6 : 1),  250 - ((heightFigure > 2) ? heightFigure * 6 : 1)),
                 new PointF(175 + ((widthFigure > 2) ? widthFigure * 6 : 1), 150),
                 new PointF(275 + ((widthFigure > 2) ? widthFigure * 6 : 1), 50 + ((heightFigure > 2) ? heightFigure * 6 : 1)),
                 new PointF(425 - ((widthFigure > 2) ? widthFigure * 6 : 1), 50 + ((heightFigure > 2) ? heightFigure * 6 : 1)),
                 new PointF(525 - ((widthFigure > 2) ? widthFigure * 6 : 1), 150),
                 new PointF(425 - ((widthFigure > 2) ? widthFigure * 6 : 1), 250 - ((heightFigure > 2) ? heightFigure * 6 : 1)),
             };

            if (radioButton1.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawPolygon(p, cords);
            }
            else if (radioButton2.Checked)
            {
                g.FillPolygon(new SolidBrush(colorFigure), cords);
            }
            else if (radioButton3.Checked)
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                g.DrawPolygon(p, cords);
            }
        }
    }
}
