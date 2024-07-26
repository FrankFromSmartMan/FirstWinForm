namespace FirstWinForm
{
    partial class FormUpdate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(97, 58);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 0;
            label1.Text = "員工編號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(97, 116);
            label2.Name = "label2";
            label2.Size = new Size(129, 38);
            label2.TabIndex = 1;
            label2.Text = "中文姓名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(97, 185);
            label3.Name = "label3";
            label3.Size = new Size(129, 38);
            label3.TabIndex = 2;
            label3.Text = "英文姓名";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(264, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 27);
            textBox3.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 16.2F);
            buttonSave.Location = new Point(141, 283);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(133, 58);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "存檔";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 16.2F);
            buttonCancel.Location = new Point(329, 283);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 58);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "取消";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 420);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "編輯員工資料";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonSave;
        private Button buttonCancel;
    }
}