using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
////using System.Threading.Tasks;not support in 3.5 .Netnot support in 3.5 .Net
using System.Windows.Forms;
using ClassLibraryGrafh;
namespace Semestr2Att3
{
    public partial class FormGrapfhDraw : Form
    {
        public FormGrapfhDraw()
        {
            InitializeComponent();
            Draw();
        }
        Graphics g;
        Bitmap bitmap;
        void Draw()
        {
           bitmap = new Bitmap(pictureBoxGrafh.Width, pictureBoxGrafh.Height);
           g = Graphics.FromImage(bitmap);
           ClassDrawing.DrawGr(ref g, pictureBoxGrafh.Width, pictureBoxGrafh.Height);
           pictureBoxGrafh.Image = bitmap;
        }

        private void pictureBoxGrafh_SizeChanged(object sender, EventArgs e)
        {
            ClassDrawing.ClearCoord();
            Draw();
        }
        bool draw = false;
        int index = -1;

        private void pictureBoxGrafh_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {
                    ClassDrawing.ChangeCoordinate(index, e.X, e.Y);
                    Draw();                
            }
        }

        private void pictureBoxGrafh_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void pictureBoxGrafh_MouseDown(object sender, MouseEventArgs e)
        {

            if (ClassDrawing.CheckCoordinate(ref index, e.X, e.Y))
            {
                draw = true;
            }
        }


    }
}
