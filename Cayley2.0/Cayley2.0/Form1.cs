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

        double th1 => AngleLeft * Math.PI / 180;
        double th2 => AngleRight * Math.PI / 180;
        double per1 => RatioLeft * 0.02;
        double per2 => RatioRight * 0.02;


        public Form1()
        {


            InitializeComponent();
            IterationTimes = 10;
            MainLength = 200;
            AngleLeft = 30;
            AngleRight = 20;
            RatioLeft = 35;
            RatioRight = 30;
            graphics = treePanel.CreateGraphics();


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
            graphics.DrawLine(Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }


        private void TBIterTimes_Scroll(object sender, EventArgs e)
        {
            this.IterationTimes = tBIterTimes.Value;
            treePanel.Refresh();
        }

        private void TBLength_Scroll(object sender, EventArgs e)
        {
            this.MainLength = tBLength.Value;
            treePanel.Refresh();
        }

        private void TBAngleLeft_Scroll(object sender, EventArgs e)
        {
            this.AngleLeft = tBAngleLeft.Value;
            treePanel.Refresh();
        }

        private void TBAngleRight_Scroll(object sender, EventArgs e)
        {
            this.AngleRight = tBAngleRight.Value;
            treePanel.Refresh();
        }

        private void TBRatioLeft_Scroll(object sender, EventArgs e)
        {
            this.RatioLeft = tBRatioLeft.Value;
            treePanel.Refresh();
        }

        private void TBRatioRight_Scroll(object sender, EventArgs e)
        {
            this.RatioRight = tBRatioLeft.Value;
            treePanel.Refresh();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TreePanel_Paint(object sender, PaintEventArgs e)
        {
            drawCayleyTree(IterationTimes, 130, 310, 100, -Math.PI / 2);
        }
    }
}
