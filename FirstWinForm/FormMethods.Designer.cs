namespace FirstWinForm
{
    partial class FormMethods
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
            label4 = new Label();
            buttonInScope = new Button();
            buttonInClass = new Button();
            buttonNewClass = new Button();
            buttonThreeParams = new Button();
            buttonOptionalParams = new Button();
            buttonNamedParams = new Button();
            buttonDateTimeExtension = new Button();
            buttonCreateTree = new Button();
            treeViewFolders = new TreeView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 0;
            label1.Text = "方法定義位置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(78, 41);
            label2.TabIndex = 1;
            label2.Text = "參數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(289, 82);
            label3.TabIndex = 2;
            label3.Text = "擴充方法\r\n(Extension methods)\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(12, 293);
            label4.Name = "label4";
            label4.Size = new Size(138, 41);
            label4.TabIndex = 3;
            label4.Text = "遞迴方法";
            // 
            // buttonInScope
            // 
            buttonInScope.Font = new Font("Segoe UI", 18F);
            buttonInScope.Location = new Point(214, 14);
            buttonInScope.Name = "buttonInScope";
            buttonInScope.Size = new Size(215, 80);
            buttonInScope.TabIndex = 4;
            buttonInScope.Text = "在範圍內";
            buttonInScope.UseVisualStyleBackColor = true;
            buttonInScope.Click += buttonInScope_Click;
            // 
            // buttonInClass
            // 
            buttonInClass.Font = new Font("Segoe UI", 18F);
            buttonInClass.Location = new Point(445, 14);
            buttonInClass.Name = "buttonInClass";
            buttonInClass.Size = new Size(270, 80);
            buttonInClass.TabIndex = 5;
            buttonInClass.Text = "在目前類別中";
            buttonInClass.UseVisualStyleBackColor = true;
            buttonInClass.Click += buttonInClass_Click;
            // 
            // buttonNewClass
            // 
            buttonNewClass.Font = new Font("Segoe UI", 18F);
            buttonNewClass.Location = new Point(731, 14);
            buttonNewClass.Name = "buttonNewClass";
            buttonNewClass.Size = new Size(225, 80);
            buttonNewClass.TabIndex = 6;
            buttonNewClass.Text = "在新類別中";
            buttonNewClass.UseVisualStyleBackColor = true;
            buttonNewClass.Click += buttonNewClass_Click;
            // 
            // buttonThreeParams
            // 
            buttonThreeParams.Font = new Font("Segoe UI", 18F);
            buttonThreeParams.Location = new Point(214, 100);
            buttonThreeParams.Name = "buttonThreeParams";
            buttonThreeParams.Size = new Size(215, 80);
            buttonThreeParams.TabIndex = 7;
            buttonThreeParams.Text = "三個參數";
            buttonThreeParams.UseVisualStyleBackColor = true;
            buttonThreeParams.Click += buttonThreeParams_Click;
            // 
            // buttonOptionalParams
            // 
            buttonOptionalParams.Font = new Font("Segoe UI", 18F);
            buttonOptionalParams.Location = new Point(445, 102);
            buttonOptionalParams.Name = "buttonOptionalParams";
            buttonOptionalParams.Size = new Size(270, 80);
            buttonOptionalParams.TabIndex = 8;
            buttonOptionalParams.Text = "選擇性參數";
            buttonOptionalParams.UseVisualStyleBackColor = true;
            buttonOptionalParams.Click += buttonOptionalParams_Click;
            // 
            // buttonNamedParams
            // 
            buttonNamedParams.Font = new Font("Segoe UI", 18F);
            buttonNamedParams.Location = new Point(731, 102);
            buttonNamedParams.Name = "buttonNamedParams";
            buttonNamedParams.Size = new Size(225, 80);
            buttonNamedParams.TabIndex = 9;
            buttonNamedParams.Text = "具名參數";
            buttonNamedParams.UseVisualStyleBackColor = true;
            buttonNamedParams.Click += buttonNamedParams_Click;
            // 
            // buttonDateTimeExtension
            // 
            buttonDateTimeExtension.Font = new Font("Segoe UI", 18F);
            buttonDateTimeExtension.Location = new Point(445, 188);
            buttonDateTimeExtension.Name = "buttonDateTimeExtension";
            buttonDateTimeExtension.Size = new Size(270, 80);
            buttonDateTimeExtension.TabIndex = 10;
            buttonDateTimeExtension.Text = "時間擴充";
            buttonDateTimeExtension.UseVisualStyleBackColor = true;
            buttonDateTimeExtension.Click += buttonDateTimeExtension_Click;
            // 
            // buttonCreateTree
            // 
            buttonCreateTree.Font = new Font("Segoe UI", 18F);
            buttonCreateTree.Location = new Point(12, 349);
            buttonCreateTree.Name = "buttonCreateTree";
            buttonCreateTree.Size = new Size(256, 80);
            buttonCreateTree.TabIndex = 11;
            buttonCreateTree.Text = "產出資料夾結構";
            buttonCreateTree.UseVisualStyleBackColor = true;
            buttonCreateTree.Click += buttonCreateTree_Click;
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(326, 308);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(709, 282);
            treeViewFolders.TabIndex = 12;
            // 
            // FormMethods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 623);
            Controls.Add(treeViewFolders);
            Controls.Add(buttonCreateTree);
            Controls.Add(buttonDateTimeExtension);
            Controls.Add(buttonNamedParams);
            Controls.Add(buttonOptionalParams);
            Controls.Add(buttonThreeParams);
            Controls.Add(buttonNewClass);
            Controls.Add(buttonInClass);
            Controls.Add(buttonInScope);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMethods";
            Text = "FormMethods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonInScope;
        private Button buttonInClass;
        private Button buttonNewClass;
        private Button buttonThreeParams;
        private Button buttonOptionalParams;
        private Button buttonNamedParams;
        private Button buttonDateTimeExtension;
        private Button buttonCreateTree;
        private TreeView treeViewFolders;
    }
}