namespace FirstWinForm
{
    partial class FormParking
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
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            blueButtonContainer1 = new BlueButtonContainer();
            tabPage2 = new TabPage();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage3 = new TabPage();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage4 = new TabPage();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1125, 371);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1139, 1055);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(blueButtonContainer1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1131, 1005);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "表格顯示";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // blueButtonContainer1
            // 
            blueButtonContainer1.ButtonText = "顯示文字";
            blueButtonContainer1.Location = new Point(36, 20);
            blueButtonContainer1.Name = "blueButtonContainer1";
            blueButtonContainer1.Size = new Size(213, 59);
            blueButtonContainer1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cartesianChart1);
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1131, 1005);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "折線圖";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Dock = DockStyle.Fill;
            cartesianChart1.Location = new Point(3, 3);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1125, 999);
            cartesianChart1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartesianChart2);
            tabPage3.Location = new Point(4, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1131, 1005);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "直條圖";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Dock = DockStyle.Fill;
            cartesianChart2.Location = new Point(0, 0);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(1131, 1005);
            cartesianChart2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(pieChart1);
            tabPage4.Location = new Point(4, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1131, 1005);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "圓餅圖";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pieChart1
            // 
            pieChart1.Dock = DockStyle.Fill;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(0, 0);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(1131, 1005);
            pieChart1.TabIndex = 0;
            pieChart1.Total = null;
            // 
            // FormParking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 1055);
            Controls.Add(tabControl1);
            Name = "FormParking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "停車資訊";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private BlueButtonContainer blueButtonContainer1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}