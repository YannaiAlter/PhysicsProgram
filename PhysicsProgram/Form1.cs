using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("X(t)");
            chart1.Series["X(t)"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            proccess.Text = "Done";
            time.Text = "";
            xtext.Text = "";
            float second = float.Parse(secondstoshow.Text);
  
        
            float deltaX = 0;
            float V;
            float Xt = 0;
     
            float X0 = -float.Parse(X0t.Text);

            float Masa = float.Parse(Masat.Text);

            float Kvooa = float.Parse(Kvooat.Text);

            float V0 = float.Parse(V0t.Text);

            float length = -float.Parse(lengtht.Text);
            double g = 9.8;
            deltaX = length - X0;
            Xt = X0;
            float Ftot = Kvooa * deltaX - Masa * (float)g;
            float a;
            V = V0;
            a = Kvooa * deltaX / Masa - (float)g;

            Console.WriteLine(deltaX + " " + a + " " + V);
            Console.ReadLine();
            for (int t = 0; t < second*50; t++)
            {
                chart1.Series["X(t)"].Points.AddXY((float)t / 50, (float)Xt);
                time.Text +="\r\n" + (float)t/50;
                xtext.Text += "\r\n" + Xt;
                Xt += V * ((float)0.02) + 1 / 2 * a * ((float)0.02 * ((float)0.02));
                deltaX = length - Xt;
                a = Kvooa * deltaX / Masa - (float)g;

                V += a * ((float)0.02);
             
     

            }
            
        }
    }
}
