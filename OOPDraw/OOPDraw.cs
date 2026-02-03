using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class OOPDraw : Form
    {
        public OOPDraw()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        Pen currentPen = new Pen(Color.Black);

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Point a = new Point(20, 30);
            Point b = new Point(400, 500);
            gr.DrawLine(currentPen, a, b);

            gr.DrawLine()
        }
    }
}
