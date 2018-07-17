using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CPSTest
{
    public partial class Chart : Form
    {
        double[] CPSArray;
        Graphics g;
        Pen PenRed;
        Pen PenBlue;
        public Chart()
        {
            InitializeComponent();
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            g = drawPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PenRed = new Pen(Color.FromArgb(255,63,63), 1f);
            PenBlue = new Pen(Color.FromArgb(63,127,255), 1f);
        }
        public void setArray(double[] CPSArray)
        {
            this.CPSArray = CPSArray;
        }
        public void draw()
        {
            double max = CPSArray[0];
            double min = CPSArray[0];
            double width = 500f / (float)(CPSArray.Length-2);
            int minPos = 0;
            for(int i = 0;i < CPSArray.Length-1;i++)
            {
                if(CPSArray[i]>max)
                    max = CPSArray[i];
            }
            for (int i = 0; i < CPSArray.Length; i++)
            {
                if (CPSArray[i] < min)
                {
                    min = CPSArray[i];
                    minPos = i;
                }
            }
            PointF p1;
            PointF p2 = new PointF((float)(0d*width),(float)(180f-(((float)CPSArray[0]/max)*180f)));
            for(int i = 1;i < CPSArray.Length-1;i++)
            {
                p1 = p2;
                p2 = new PointF((float)((double)i * width), (float)(180f - (((float)CPSArray[i] / max) * 180f)));
                g.DrawLine(PenBlue, p1, p2);
                if (i == minPos)
                {
                    g.DrawLine(PenRed, 0f, (float)(180f - (((float)CPSArray[i] / max) * 180f)), (float)((double)i * width), (float)(180f - (((float)CPSArray[i] / max) * 180f)));
                }
            }
            peakCPSLbl.Text = "Peak:" + max.ToString("00.000");
            valleyCPSLbl.Text = "Valley:" + min.ToString("00.000");
            valleyCPSLbl.Location = new Point(0, ((int)(180f - (((float)min / max) * 180f)) + 2));
        }
        public void clear()
        {
            g.Clear(Color.FromArgb(32, 32, 32));
        }
    }
}
