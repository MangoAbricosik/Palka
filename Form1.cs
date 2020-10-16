using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stretches the image to fit the pictureBox.
            Bitmap MyImage;
            string fileToDisplay = @"D:\Documents\1222.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            MyImage = new Bitmap(fileToDisplay);

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 30);
            // Create coordinates of points that define line.
            x+=5;
            int x1 = 1+x;   //topleft to topright
            int y1 = 1 + x;
            int x2 = 300 + x;
            int y2 = 300 + x;

            // Draw line to screen.
            using (var graphics = Graphics.FromImage(MyImage))
            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }


            pictureBox1.ClientSize = new Size(190, 1080);
            pictureBox1.Image = (Image)MyImage;
        }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
  }
}
