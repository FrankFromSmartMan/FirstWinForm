namespace FirstWinForm
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
            buttonInsert = new Button();
            dataGridViewScoreData = new DataGridView();
            buttonCreateDB = new Button();
            buttonTruncateDB = new Button();
            buttonSelect = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            label2 = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            labelID = new Label();
            buttonSave = new Button();
            numericUpDownID = new NumericUpDown();
            buttonDrop = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScoreData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).BeginInit();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(162, 26);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 0;
            buttonInsert.Text = "Insert Data";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += ButtonInsert_Click;
            // 
            // dataGridViewScoreData
            // 
            dataGridViewScoreData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewScoreData.Location = new Point(36, 105);
            dataGridViewScoreData.Name = "dataGridViewScoreData";
            dataGridViewScoreData.RowHeadersWidth = 51;
            dataGridViewScoreData.Size = new Size(405, 311);
            dataGridViewScoreData.TabIndex = 1;
            // 
            // buttonCreateDB
            // 
            buttonCreateDB.Location = new Point(36, 26);
            buttonCreateDB.Name = "buttonCreateDB";
            buttonCreateDB.Size = new Size(94, 29);
            buttonCreateDB.TabIndex = 2;
            buttonCreateDB.Text = "Create DB";
            buttonCreateDB.UseVisualStyleBackColor = true;
            buttonCreateDB.Click += ButtonCreateDB_Click;
            // 
            // buttonTruncateDB
            // 
            buttonTruncateDB.Location = new Point(36, 61);
            buttonTruncateDB.Name = "buttonTruncateDB";
            buttonTruncateDB.Size = new Size(94, 29);
            buttonTruncateDB.TabIndex = 3;
            buttonTruncateDB.Text = "Truncate DB";
            buttonTruncateDB.UseVisualStyleBackColor = true;
            buttonTruncateDB.Click += ButtonTruncateDB_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(162, 61);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(94, 29);
            buttonSelect.TabIndex = 4;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += ButtonSelect_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(540, 107);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(184, 27);
            textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(471, 110);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 6;
            labelName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 144);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 7;
            label2.Text = "Birthday";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.Location = new Point(540, 144);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(184, 27);
            dateTimePickerBirthday.TabIndex = 8;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(471, 75);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 20);
            labelID.TabIndex = 9;
            labelID.Text = "ID";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(540, 194);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // numericUpDownID
            // 
            numericUpDownID.Location = new Point(540, 73);
            numericUpDownID.Name = "numericUpDownID";
            numericUpDownID.ReadOnly = true;
            numericUpDownID.Size = new Size(184, 27);
            numericUpDownID.TabIndex = 12;
            // 
            // buttonDrop
            // 
            buttonDrop.Location = new Point(296, 26);
            buttonDrop.Name = "buttonDrop";
            buttonDrop.Size = new Size(94, 29);
            buttonDrop.TabIndex = 13;
            buttonDrop.Text = "Drop DB";
            buttonDrop.UseVisualStyleBackColor = true;
            buttonDrop.Click += ButtonDrop_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(640, 194);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(640, 229);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonDrop);
            Controls.Add(numericUpDownID);
            Controls.Add(buttonSave);
            Controls.Add(labelID);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(label2);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonSelect);
            Controls.Add(buttonTruncateDB);
            Controls.Add(buttonCreateDB);
            Controls.Add(dataGridViewScoreData);
            Controls.Add(buttonInsert);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewScoreData).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInsert;
        private DataGridView dataGridViewScoreData;
        private Button buttonCreateDB;
        private Button buttonTruncateDB;
        private Button buttonSelect;
        private TextBox textBoxName;
        private Label labelName;
        private Label label2;
        private DateTimePicker dateTimePickerBirthday;
        private Label labelID;
        private Button buttonSave;
        private NumericUpDown numericUpDownID;
        private Button buttonDrop;
        private Button buttonClear;
        private Button buttonDelete;
    }
}