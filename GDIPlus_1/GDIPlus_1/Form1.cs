using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap("D://water.PNG");
            this.SetClientSizeCore(bmp.Width,bmp.Height);
            Rectangle topLeft = new Rectangle(0,0,bmp.Width/2,bmp.Height/2);
            Rectangle topRight = new Rectangle(bmp.Width/2,0,bmp.Width/2,bmp.Height/2);
            Rectangle bottomLeft = new Rectangle(0,bmp.Height/2,bmp.Width/2,bmp.Height/2);
            Rectangle bottomRight = new Rectangle(bmp.Width/2,bmp.Height/2,bmp.Width/2,bmp.Height/2);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            e.Graphics.DrawImage(bmp,topLeft);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawImage(bmp,topRight);

            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            e.Graphics.DrawImage(bmp,bottomLeft);

            bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
            e.Graphics.DrawImage(bmp,bottomRight);

            g.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //LinearGradientBrush pnlGdt = new LinearGradientBrush(panel1.ClientRectangle,Color.Yellow,Color.Navy,0f,true);
            //e.Graphics.FillRectangle(pnlGdt,panel1.ClientRectangle);
            //pnlGdt.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //LinearGradientBrush pnlGdt = new LinearGradientBrush(panel2.ClientRectangle, Color.Yellow, Color.Navy, 90f, true);
            //e.Graphics.FillRectangle(pnlGdt, panel2.ClientRectangle);
            //pnlGdt.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(panel3.ClientRectangle);
            //PathGradientBrush br = new PathGradientBrush(path);
            //br.CenterPoint = new PointF(panel3.ClientRectangle.Width/2,panel3.ClientRectangle.Height/2);
            //br.CenterColor = Color.Navy;
            //br.SurroundColors = new Color[] { Color.Yellow };
            //e.Graphics.FillPath(br,path);
        }
    }
}
