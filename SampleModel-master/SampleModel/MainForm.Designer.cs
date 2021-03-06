namespace SampleModel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.chMainPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbY = new System.Windows.Forms.Label();
            this.lbYCaption = new System.Windows.Forms.Label();
            this.tmModel = new System.Windows.Forms.Timer(this.components);
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDn2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSPDn = new System.Windows.Forms.Button();
            this.btnSPUp = new System.Windows.Forms.Button();
            this.tbSetpoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKDn = new System.Windows.Forms.Button();
            this.btnKUp = new System.Windows.Forms.Button();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTiDn = new System.Windows.Forms.Button();
            this.btnTiUp = new System.Windows.Forms.Button();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTdDn = new System.Windows.Forms.Button();
            this.btnTdUp = new System.Windows.Forms.Button();
            this.tbTd = new System.Windows.Forms.TextBox();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(712, 517);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 19);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(651, 517);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(208, 40);
            this.tbX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(48, 20);
            this.tbX.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(260, 41);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 19);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(183, 40);
            this.btnDn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(20, 19);
            this.btnDn.TabIndex = 4;
            this.btnDn.Text = "<";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // chMainPlot
            // 
            this.chMainPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "chMainArea";
            this.chMainPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chMainPlot.Legends.Add(legend1);
            this.chMainPlot.Location = new System.Drawing.Point(9, 210);
            this.chMainPlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chMainPlot.Name = "chMainPlot";
            series1.ChartArea = "chMainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Y";
            series1.Name = "seriesY";
            series2.ChartArea = "chMainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "X1";
            series2.Name = "seriesX";
            series3.ChartArea = "chMainArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "X2";
            series3.Name = "seriesX2";
            series4.ChartArea = "chMainArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "U";
            series4.Name = "SeriesU";
            this.chMainPlot.Series.Add(series1);
            this.chMainPlot.Series.Add(series2);
            this.chMainPlot.Series.Add(series3);
            this.chMainPlot.Series.Add(series4);
            this.chMainPlot.Size = new System.Drawing.Size(759, 302);
            this.chMainPlot.TabIndex = 5;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(708, 46);
            this.lbY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(22, 13);
            this.lbY.TabIndex = 7;
            this.lbY.Text = "0.0";
            // 
            // lbYCaption
            // 
            this.lbYCaption.AutoSize = true;
            this.lbYCaption.Location = new System.Drawing.Point(689, 46);
            this.lbYCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYCaption.Name = "lbYCaption";
            this.lbYCaption.Size = new System.Drawing.Size(17, 13);
            this.lbYCaption.TabIndex = 8;
            this.lbYCaption.Text = "Y:";
            this.lbYCaption.Click += new System.EventHandler(this.lbYCaption_Click);
            // 
            // tmModel
            // 
            this.tmModel.Interval = 1000;
            this.tmModel.Tick += new System.EventHandler(this.tmModel_Tick);
            // 
            // btnX1
            // 
            this.btnX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX1.Location = new System.Drawing.Point(9, 517);
            this.btnX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(56, 19);
            this.btnX1.TabIndex = 9;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX10.Location = new System.Drawing.Point(70, 517);
            this.btnX10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(56, 19);
            this.btnX10.TabIndex = 10;
            this.btnX10.Text = "x10";
            this.btnX10.UseVisualStyleBackColor = true;
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SampleModel.Properties.Resources.pictureBox1_Image;
            this.pictureBox1.Location = new System.Drawing.Point(293, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnDn2
            // 
            this.btnDn2.Location = new System.Drawing.Point(667, 175);
            this.btnDn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDn2.Name = "btnDn2";
            this.btnDn2.Size = new System.Drawing.Size(20, 19);
            this.btnDn2.TabIndex = 14;
            this.btnDn2.Text = "<";
            this.btnDn2.UseVisualStyleBackColor = true;
            this.btnDn2.Click += new System.EventHandler(this.btnDn2_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(744, 176);
            this.btnUp2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(20, 19);
            this.btnUp2.TabIndex = 13;
            this.btnUp2.Text = ">";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(692, 175);
            this.tbX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(48, 20);
            this.tbX2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "X1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "X2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "SetPoint";
            // 
            // btnSPDn
            // 
            this.btnSPDn.Location = new System.Drawing.Point(14, 28);
            this.btnSPDn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSPDn.Name = "btnSPDn";
            this.btnSPDn.Size = new System.Drawing.Size(20, 19);
            this.btnSPDn.TabIndex = 19;
            this.btnSPDn.Text = "<";
            this.btnSPDn.UseVisualStyleBackColor = true;
            this.btnSPDn.Click += new System.EventHandler(this.btnSPDn_Click);
            // 
            // btnSPUp
            // 
            this.btnSPUp.Location = new System.Drawing.Point(92, 29);
            this.btnSPUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSPUp.Name = "btnSPUp";
            this.btnSPUp.Size = new System.Drawing.Size(20, 19);
            this.btnSPUp.TabIndex = 18;
            this.btnSPUp.Text = ">";
            this.btnSPUp.UseVisualStyleBackColor = true;
            this.btnSPUp.Click += new System.EventHandler(this.btnSPUp_Click);
            // 
            // tbSetpoint
            // 
            this.tbSetpoint.Location = new System.Drawing.Point(39, 28);
            this.tbSetpoint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSetpoint.Name = "tbSetpoint";
            this.tbSetpoint.Size = new System.Drawing.Size(48, 20);
            this.tbSetpoint.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "K";
            // 
            // btnKDn
            // 
            this.btnKDn.Location = new System.Drawing.Point(14, 77);
            this.btnKDn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKDn.Name = "btnKDn";
            this.btnKDn.Size = new System.Drawing.Size(20, 19);
            this.btnKDn.TabIndex = 23;
            this.btnKDn.Text = "<";
            this.btnKDn.UseVisualStyleBackColor = true;
            this.btnKDn.Click += new System.EventHandler(this.btnKDn_Click);
            // 
            // btnKUp
            // 
            this.btnKUp.Location = new System.Drawing.Point(92, 78);
            this.btnKUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKUp.Name = "btnKUp";
            this.btnKUp.Size = new System.Drawing.Size(20, 19);
            this.btnKUp.TabIndex = 22;
            this.btnKUp.Text = ">";
            this.btnKUp.UseVisualStyleBackColor = true;
            this.btnKUp.Click += new System.EventHandler(this.btnKUp_Click);
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(39, 77);
            this.tbK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(48, 20);
            this.tbK.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ti";
            // 
            // btnTiDn
            // 
            this.btnTiDn.Location = new System.Drawing.Point(14, 124);
            this.btnTiDn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTiDn.Name = "btnTiDn";
            this.btnTiDn.Size = new System.Drawing.Size(20, 19);
            this.btnTiDn.TabIndex = 27;
            this.btnTiDn.Text = "<";
            this.btnTiDn.UseVisualStyleBackColor = true;
            this.btnTiDn.Click += new System.EventHandler(this.btnTiDn_Click);
            // 
            // btnTiUp
            // 
            this.btnTiUp.Location = new System.Drawing.Point(92, 124);
            this.btnTiUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTiUp.Name = "btnTiUp";
            this.btnTiUp.Size = new System.Drawing.Size(20, 19);
            this.btnTiUp.TabIndex = 26;
            this.btnTiUp.Text = ">";
            this.btnTiUp.UseVisualStyleBackColor = true;
            this.btnTiUp.Click += new System.EventHandler(this.btnTiUp_Click);
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(39, 124);
            this.tbTi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(48, 20);
            this.tbTi.TabIndex = 25;
            this.tbTi.TextChanged += new System.EventHandler(this.tbTi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Td";
            // 
            // btnTdDn
            // 
            this.btnTdDn.Location = new System.Drawing.Point(14, 175);
            this.btnTdDn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTdDn.Name = "btnTdDn";
            this.btnTdDn.Size = new System.Drawing.Size(20, 19);
            this.btnTdDn.TabIndex = 31;
            this.btnTdDn.Text = "<";
            this.btnTdDn.UseVisualStyleBackColor = true;
            this.btnTdDn.Click += new System.EventHandler(this.btnTdDn_Click);
            // 
            // btnTdUp
            // 
            this.btnTdUp.Location = new System.Drawing.Point(92, 176);
            this.btnTdUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTdUp.Name = "btnTdUp";
            this.btnTdUp.Size = new System.Drawing.Size(20, 19);
            this.btnTdUp.TabIndex = 30;
            this.btnTdUp.Text = ">";
            this.btnTdUp.UseVisualStyleBackColor = true;
            this.btnTdUp.Click += new System.EventHandler(this.btnTdUp_Click);
            // 
            // tbTd
            // 
            this.tbTd.Location = new System.Drawing.Point(39, 175);
            this.tbTd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTd.Name = "tbTd";
            this.tbTd.Size = new System.Drawing.Size(48, 20);
            this.tbTd.TabIndex = 29;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(183, 77);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(98, 19);
            this.btnAuto.TabIndex = 33;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 545);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTdDn);
            this.Controls.Add(this.btnTdUp);
            this.Controls.Add(this.tbTd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTiDn);
            this.Controls.Add(this.btnTiUp);
            this.Controls.Add(this.tbTi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKDn);
            this.Controls.Add(this.btnKUp);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSPDn);
            this.Controls.Add(this.btnSPUp);
            this.Controls.Add(this.tbSetpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDn2);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.lbYCaption);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.chMainPlot);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Sample model";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMainPlot;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbYCaption;
        private System.Windows.Forms.Timer tmModel;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDn2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSPDn;
        private System.Windows.Forms.Button btnSPUp;
        private System.Windows.Forms.TextBox tbSetpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKDn;
        private System.Windows.Forms.Button btnKUp;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTiDn;
        private System.Windows.Forms.Button btnTiUp;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTdDn;
        private System.Windows.Forms.Button btnTdUp;
        private System.Windows.Forms.TextBox tbTd;
        private System.Windows.Forms.Button btnAuto;
    }
}

