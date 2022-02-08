using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms._Rectangle
{
    public partial class Rectangles : Form
    {
        int startX, startY;
        int endX, endY;
        Pen pen;
        bool isDrawing = false;

 

        public Rectangles()
        {
            InitializeComponent();
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            if (pen == null) return;
            labelRectanglePosition.Text = $"({startX}, {startY} => {endX}, {endY})";
            int sx, sy, ex, ey;

            if (startX > endX) { sx = endX; ex = startX; }
            else { sx = startX; ex = endX; }

            if (startY > endY) { sy = endY; ey = startY; }
            else { sy = startY; ey = endY; }

            Rectangle rect = new Rectangle(sx, sy, ex - sx, ey - sy);

            e.Graphics.DrawRectangle(pen, rect);
        }


        private void Rectangles_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X; startY = e.Y;
            pen = new Pen(Color.LightGray, 1);
            isDrawing = true;
        }

        private void Rectangles_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X; endY = e.Y;
            pen = new Pen(Color.Green, 3);
            isDrawing = false;
            this.Refresh();
        }

        private void Rectangles_MouseMove(object sender, MouseEventArgs e)
        {
            endX = e.X; endY = e.Y;
            if (isDrawing) this.Refresh();

        }
    }
}
