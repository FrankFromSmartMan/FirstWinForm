namespace FirstWinForm
{
    partial class FormInternet
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
            buttonDownload = new Button();
            textBoxURL = new TextBox();
            label1 = new Label();
            listBoxFileData = new ListBox();
            dataGridViewData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // buttonDownload
            // 
            buttonDownload.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDownload.Location = new Point(38, 80);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(224, 87);
            buttonDownload.TabIndex = 0;
            buttonDownload.Text = "下載檔案";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(102, 28);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(652, 27);
            textBoxURL.TabIndex = 1;
            textBoxURL.Text = "https://www.twse.com.tw/exchangeReport/STOCK_DAY_ALL?response=open_data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 31);
            label1.TabIndex = 2;
            label1.Text = "URL";
            // 
            // listBoxFileData
            // 
            listBoxFileData.FormattingEnabled = true;
            listBoxFileData.Location = new Point(38, 187);
            listBoxFileData.Name = "listBoxFileData";
            listBoxFileData.Size = new Size(716, 264);
            listBoxFileData.TabIndex = 3;
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(38, 479);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.Size = new Size(747, 314);
            dataGridViewData.TabIndex = 4;
            // 
            // FormInternet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 826);
            Controls.Add(dataGridViewData);
            Controls.Add(listBoxFileData);
            Controls.Add(label1);
            Controls.Add(textBoxURL);
            Controls.Add(buttonDownload);
            Name = "FormInternet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "網路處理";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDownload;
        private TextBox textBoxURL;
        private Label label1;
        private ListBox listBoxFileData;
        private DataGridView dataGridViewData;
    }
}