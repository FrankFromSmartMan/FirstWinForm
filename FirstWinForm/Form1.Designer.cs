namespace FirstWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonGetNetTax = new Button();
            labelNetIncome = new Label();
            textBoxSpecialDeduction = new TextBox();
            textBoxDeduction = new TextBox();
            textBoxTaxFree = new TextBox();
            textBoxTaxIncome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelTaxIncome = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            tabPage2 = new TabPage();
            buttonDelete = new Button();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            listBoxNames = new ListBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(925, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonGetNetTax);
            tabPage1.Controls.Add(labelNetIncome);
            tabPage1.Controls.Add(textBoxSpecialDeduction);
            tabPage1.Controls.Add(textBoxDeduction);
            tabPage1.Controls.Add(textBoxTaxFree);
            tabPage1.Controls.Add(textBoxTaxIncome);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(labelTaxIncome);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 400);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "變數與條件";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGetNetTax
            // 
            buttonGetNetTax.Location = new Point(174, 327);
            buttonGetNetTax.Name = "buttonGetNetTax";
            buttonGetNetTax.Size = new Size(254, 52);
            buttonGetNetTax.TabIndex = 11;
            buttonGetNetTax.Text = "計算所得淨額";
            buttonGetNetTax.UseVisualStyleBackColor = true;
            buttonGetNetTax.Click += ButtonGetNetTax_Click;
            // 
            // labelNetIncome
            // 
            labelNetIncome.AutoSize = true;
            labelNetIncome.Location = new Point(402, 111);
            labelNetIncome.Name = "labelNetIncome";
            labelNetIncome.Size = new Size(164, 38);
            labelNetIncome.TabIndex = 10;
            labelNetIncome.Text = "所得淨額 = ";
            // 
            // textBoxSpecialDeduction
            // 
            textBoxSpecialDeduction.Location = new Point(235, 265);
            textBoxSpecialDeduction.Name = "textBoxSpecialDeduction";
            textBoxSpecialDeduction.Size = new Size(125, 43);
            textBoxSpecialDeduction.TabIndex = 9;
            // 
            // textBoxDeduction
            // 
            textBoxDeduction.Location = new Point(235, 216);
            textBoxDeduction.Name = "textBoxDeduction";
            textBoxDeduction.Size = new Size(125, 43);
            textBoxDeduction.TabIndex = 8;
            // 
            // textBoxTaxFree
            // 
            textBoxTaxFree.Location = new Point(235, 164);
            textBoxTaxFree.Name = "textBoxTaxFree";
            textBoxTaxFree.Size = new Size(125, 43);
            textBoxTaxFree.TabIndex = 7;
            // 
            // textBoxTaxIncome
            // 
            textBoxTaxIncome.Location = new Point(235, 111);
            textBoxTaxIncome.Name = "textBoxTaxIncome";
            textBoxTaxIncome.Size = new Size(125, 43);
            textBoxTaxIncome.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 265);
            label5.Name = "label5";
            label5.Size = new Size(157, 38);
            label5.TabIndex = 5;
            label5.Text = "特別扣除額";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 216);
            label4.Name = "label4";
            label4.Size = new Size(101, 38);
            label4.TabIndex = 4;
            label4.Text = "扣除額";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 167);
            label3.Name = "label3";
            label3.Size = new Size(102, 38);
            label3.TabIndex = 3;
            label3.Text = "免稅額";
            // 
            // labelTaxIncome
            // 
            labelTaxIncome.AutoSize = true;
            labelTaxIncome.Location = new Point(52, 114);
            labelTaxIncome.Name = "labelTaxIncome";
            labelTaxIncome.Size = new Size(130, 38);
            labelTaxIncome.TabIndex = 2;
            labelTaxIncome.Text = "所得稅額";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(231, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 38);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "參考連結";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 46);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 0;
            label1.Text = "所得稅計算";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(buttonDelete);
            tabPage2.Controls.Add(buttonAdd);
            tabPage2.Controls.Add(textBoxName);
            tabPage2.Controls.Add(listBoxNames);
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(917, 400);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "陣列";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(341, 195);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(170, 91);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "移除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(341, 44);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(159, 74);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "新增";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(94, 60);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(226, 43);
            textBoxName.TabIndex = 1;
            // 
            // listBoxNames
            // 
            listBoxNames.FormattingEnabled = true;
            listBoxNames.ItemHeight = 37;
            listBoxNames.Location = new Point(94, 130);
            listBoxNames.Name = "listBoxNames";
            listBoxNames.Size = new Size(226, 226);
            listBoxNames.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 60);
            label2.Name = "label2";
            label2.Size = new Size(341, 38);
            label2.TabIndex = 4;
            label2.Text = "(也可以逗號分隔批次加入)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C#課程練習";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelTaxIncome;
        private Button buttonGetNetTax;
        private Label labelNetIncome;
        private TextBox textBoxSpecialDeduction;
        private TextBox textBoxDeduction;
        private TextBox textBoxTaxFree;
        private TextBox textBoxTaxIncome;
        private Button buttonAdd;
        private TextBox textBoxName;
        private ListBox listBoxNames;
        private Button buttonDelete;
        private Label label2;
    }
}
