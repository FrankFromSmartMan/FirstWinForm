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
            blueButtonContainer1 = new BlueButtonContainer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 274);
            dataGridView1.TabIndex = 0;
            // 
            // blueButtonContainer1
            // 
            blueButtonContainer1.Location = new Point(57, 29);
            blueButtonContainer1.Name = "blueButtonContainer1";
            blueButtonContainer1.Size = new Size(229, 80);
            blueButtonContainer1.TabIndex = 1;
            // 
            // FormParking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blueButtonContainer1);
            Controls.Add(dataGridView1);
            Name = "FormParking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "停車資訊";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BlueButtonContainer blueButtonContainer1;
    }
}