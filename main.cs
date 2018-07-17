using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CPSTest
{
    public partial class main : Form
    {
        public List<DateTime> clickTime = new List<DateTime>();
        Thread thread1;
        Chart chart = new Chart();
        public main()
        {
            InitializeComponent();
        }
        public void stop()
        {
            beginButton.Visible = true;
            clickButton.Visible = false;
            thread1 = null;
            showCPSInfo();
            clickTime = new List<DateTime>();
        }
        private void showCPSInfo()
        {
            clickTime.Add(DateTime.Now);
            if (clickTime.Count > 1)
            {
                long[] distanceTimeArray = new long[clickTime.Count - 1];
                double[] CPSData = new Double[clickTime.Count - 1];

                for (int i = 1; i < clickTime.Count; i++)
                {
                    distanceTimeArray[i - 1] = clickTime[i].ToBinary() - clickTime[i - 1].ToBinary();
                }
                for (int i = 0; i < distanceTimeArray.Length; i++)
                {
                    CPSData[i] = 10000000d / distanceTimeArray[i];
                }
                double max = CPSData[0], min = CPSData[0];
                for (int i = 0; i < CPSData.Length; i++)
                {
                    if (i < CPSData.Length - 1)
                    {
                        if (CPSData[i] > max)
                            max = CPSData[i];
                    }
                    if (CPSData[i] < min)
                        min = CPSData[i];
                }

                double avg = (double)clickTime.Count / 10d;
                cpsDisplay.Text = String.Format("CPSInfo: Avg.:{0} Peak:{1} Valley:{2}", avg.ToString("00.0"), max.ToString("00.000"), min.ToString("00.000"));
                chart.clear();
                chart.setArray(CPSData);
                chart.draw();
            }
        }
        private void clickButton_Click(object sender, EventArgs e)
        {
            clickTime.Add(DateTime.Now);
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            beginButton.Visible = false;
            clickButton.Visible = true;
            thread1 = new Thread(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Thread.Sleep(10);
                    ProgressBar.Width = (int)(284 * ((double)(i + 1) / (double)1000));
                }
                stop();
            });
            thread1.Start();
        }

        private void main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            chart.Show();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
