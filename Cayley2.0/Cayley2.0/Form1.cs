using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cayley2._0
{
    public partial class Form1 : Form
    {
        private Graphics graphics;

        public int IterationTimes { get; set; }
        public int MainLength { get; set; }
        public int AngleLeft { get; set; }
        public int AngleRight { get; set; }
        public int RatioRight { get; set; }
        public int RatioLeft { get; set; }
        public Pen Pen { get; set; }


        double th1 => AngleLeft * Math.PI / 180;
        double th2 => AngleRight * Math.PI / 180;
        double per1 => RatioLeft * 0.02;
        double per2 => RatioRight * 0.02;
        double paraX => 1.5;
        double paraY => 1.5;


        public Form1()
        {


            InitializeComponent();
            IterationTimes = 10;
            this.tBIterTimes.Value = IterationTimes;
            MainLength = 200;
            this.tBLength.Value = MainLength / 10;
            AngleLeft = 30;
            tBAngleLeft.Value = AngleLeft;
            AngleRight = 20;
            tBAngleRight.Value = AngleRight;
            RatioLeft = 35;
            tBRatioLeft.Value = RatioLeft;
            RatioRight = 30;
            tBRatioRight.Value = RatioRight;
            Pen = Pens.Black;
            panelColor.BackColor = Color.Black;
            graphics = treePanel.CreateGraphics();
            SizeChanged += Form1_SizeChanged;


        }

        
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /*
            foreach (Control control in this.Controls)
            {
                if (control.Name != "treePanel")
                {
                    control.Size = new Size(
                        Convert.ToInt32(control.Size.Width * paraX),
                        Convert.ToInt32(control.Size.Height * paraY)
                        );
                }
            }
            */
        }

        void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }


        private void TBIterTimes_Scroll(object sender, EventArgs e)
        {

            this.IterationTimes = tBIterTimes.Value;
            labelTimes.Text = labelTimes.Text.Split(':')[0] + ":" + IterationTimes*10;
             

            treePanel.Refresh();
        }

        private void TBLength_Scroll(object sender, EventArgs e)
        {
            this.MainLength = tBLength.Value * 10;
            labelLength.Text = labelLength.Text.Split(':')[0] + ":" + MainLength;
            treePanel.Refresh();
        }

        private void TBAngleLeft_Scroll(object sender, EventArgs e)
        {
            this.AngleLeft = tBAngleLeft.Value;
            labelAngleLeft.Text = labelLength.Text.Split(':')[0] + ":" + AngleLeft;
            treePanel.Refresh();
        }

        private void TBAngleRight_Scroll(object sender, EventArgs e)
        {
            this.AngleRight = tBAngleRight.Value;
            labelAngleRight.Text = labelAngleRight.Text.Split(':')[0] + ":" + AngleRight;
            treePanel.Refresh();
        }

        private void TBRatioLeft_Scroll(object sender, EventArgs e)
        {
            
            this.RatioLeft = tBRatioLeft.Value;
            labelRatioLeft.Text = labelRatioLeft.Text.Split(':')[0] + ":" + RatioLeft;
            treePanel.Refresh();
        }

        private void TBRatioRight_Scroll(object sender, EventArgs e)
        {
            this.RatioRight = tBRatioLeft.Value;
            labelRatioRight.Text = labelRatioRight.Text.Split(':')[0] + ":" + RatioRight;
            treePanel.Refresh();
        }


        private void TreePanel_Paint(object sender, PaintEventArgs e)
        {
            drawCayleyTree(IterationTimes, 130, 310, 100, -Math.PI / 2);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            this.panelColor.BackColor = color;
            this.Pen = new Pen(color);
            treePanel.Refresh();
            
        }
    }
}
