﻿namespace FirstWinForm
{
    partial class FormFiles
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            labelFileName = new Label();
            buttonCreateFile = new Button();
            buttonOpenFile = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            listBoxFileData = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelFileName);
            panel1.Controls.Add(buttonCreateFile);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 94);
            panel1.TabIndex = 0;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFileName.Location = new Point(354, 27);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(111, 31);
            labelFileName.TabIndex = 2;
            labelFileName.Text = "檔案名稱:";
            // 
            // buttonCreateFile
            // 
            buttonCreateFile.Font = new Font("Segoe UI", 16.2F);
            buttonCreateFile.Location = new Point(190, 13);
            buttonCreateFile.Name = "buttonCreateFile";
            buttonCreateFile.Size = new Size(158, 54);
            buttonCreateFile.TabIndex = 1;
            buttonCreateFile.Text = "產出檔案";
            buttonCreateFile.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Font = new Font("Segoe UI", 16.2F);
            buttonOpenFile.Location = new Point(26, 13);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(158, 54);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "讀取檔案";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(3, 103);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 344);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxFileData);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 300);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "原始內容";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 300);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "表格顯示";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxFileData
            // 
            listBoxFileData.Dock = DockStyle.Fill;
            listBoxFileData.FormattingEnabled = true;
            listBoxFileData.ItemHeight = 31;
            listBoxFileData.Location = new Point(3, 3);
            listBoxFileData.Name = "listBoxFileData";
            listBoxFileData.Size = new Size(780, 294);
            listBoxFileData.TabIndex = 0;
            // 
            // FormFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFiles";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button buttonCreateFile;
        private Button buttonOpenFile;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelFileName;
        private ListBox listBoxFileData;
    }
}