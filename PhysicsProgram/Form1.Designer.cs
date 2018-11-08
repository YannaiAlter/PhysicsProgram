namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Masat = new System.Windows.Forms.TextBox();
            this.Kvooat = new System.Windows.Forms.TextBox();
            this.X0t = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.V0t = new System.Windows.Forms.TextBox();
            this.lengtht = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.xtex = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.xtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondstoshow = new System.Windows.Forms.TextBox();
            this.proccess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Masat
            // 
            this.Masat.Location = new System.Drawing.Point(836, 94);
            this.Masat.Name = "Masat";
            this.Masat.Size = new System.Drawing.Size(100, 20);
            this.Masat.TabIndex = 1;
            this.Masat.Text = "0.5";
            // 
            // Kvooat
            // 
            this.Kvooat.Location = new System.Drawing.Point(836, 153);
            this.Kvooat.Name = "Kvooat";
            this.Kvooat.Size = new System.Drawing.Size(100, 20);
            this.Kvooat.TabIndex = 2;
            this.Kvooat.Text = "10";
            // 
            // X0t
            // 
            this.X0t.Location = new System.Drawing.Point(836, 30);
            this.X0t.Name = "X0t";
            this.X0t.Size = new System.Drawing.Size(100, 20);
            this.X0t.TabIndex = 0;
            this.X0t.Text = "0.3";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(807, 33);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(23, 13);
            this.x.TabIndex = 2;
            this.x.Text = "X0:";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(774, 97);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(57, 13);
            this.m.TabIndex = 3;
            this.m.Text = "Masa (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kvooa (N):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "V0(m/s):";
            // 
            // V0t
            // 
            this.V0t.Location = new System.Drawing.Point(833, 208);
            this.V0t.Name = "V0t";
            this.V0t.Size = new System.Drawing.Size(100, 20);
            this.V0t.TabIndex = 3;
            this.V0t.Text = "0";
            // 
            // lengtht
            // 
            this.lengtht.Location = new System.Drawing.Point(833, 260);
            this.lengtht.Name = "lengtht";
            this.lengtht.Size = new System.Drawing.Size(100, 20);
            this.lengtht.TabIndex = 4;
            this.lengtht.Text = "0.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Length(m):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xtex, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.time, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.xtext, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(509, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 274);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "time:";
            // 
            // xtex
            // 
            this.xtex.AutoSize = true;
            this.xtex.Location = new System.Drawing.Point(84, 2);
            this.xtex.Name = "xtex";
            this.xtex.Size = new System.Drawing.Size(15, 13);
            this.xtex.TabIndex = 1;
            this.xtex.Text = "x:";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.Location = new System.Drawing.Point(10, 36);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(60, 223);
            this.time.TabIndex = 12;
            // 
            // xtext
            // 
            this.xtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtext.Location = new System.Drawing.Point(92, 35);
            this.xtext.Multiline = true;
            this.xtext.Name = "xtext";
            this.xtext.Size = new System.Drawing.Size(87, 224);
            this.xtext.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seconds to show:";
            // 
            // secondstoshow
            // 
            this.secondstoshow.Location = new System.Drawing.Point(892, 295);
            this.secondstoshow.Name = "secondstoshow";
            this.secondstoshow.Size = new System.Drawing.Size(32, 20);
            this.secondstoshow.TabIndex = 11;
            this.secondstoshow.Text = "4";
            // 
            // proccess
            // 
            this.proccess.AutoSize = true;
            this.proccess.Location = new System.Drawing.Point(875, 368);
            this.proccess.Name = "proccess";
            this.proccess.Size = new System.Drawing.Size(0, 13);
            this.proccess.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "© Yannai,Aviv,Lior,Ofek";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "X(t)";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(460, 300);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 386);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.proccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondstoshow);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lengtht);
            this.Controls.Add(this.V0t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m);
            this.Controls.Add(this.x);
            this.Controls.Add(this.X0t);
            this.Controls.Add(this.Kvooat);
            this.Controls.Add(this.Masat);
            this.Name = "Form1";
            this.Text = "Physics Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Masat;
        private System.Windows.Forms.TextBox Kvooat;
        private System.Windows.Forms.TextBox X0t;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox V0t;
        private System.Windows.Forms.TextBox lengtht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label xtex;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox xtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondstoshow;
        private System.Windows.Forms.Label proccess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

