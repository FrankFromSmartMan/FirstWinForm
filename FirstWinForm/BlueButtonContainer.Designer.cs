namespace FirstWinForm
{
    partial class BlueButtonContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BlueButtonControl = new Button();
            SuspendLayout();
            // 
            // BlueButtonControl
            // 
            BlueButtonControl.BackColor = SystemColors.ActiveCaption;
            BlueButtonControl.Dock = DockStyle.Fill;
            BlueButtonControl.FlatAppearance.BorderSize = 0;
            BlueButtonControl.FlatStyle = FlatStyle.Flat;
            BlueButtonControl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BlueButtonControl.Location = new Point(0, 0);
            BlueButtonControl.Name = "BlueButtonControl";
            BlueButtonControl.Size = new Size(183, 64);
            BlueButtonControl.TabIndex = 0;
            BlueButtonControl.Text = "顯示文字";
            BlueButtonControl.UseVisualStyleBackColor = false;
            // 
            // BlueButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BlueButtonControl);
            Name = "BlueButton";
            Size = new Size(183, 64);
            ResumeLayout(false);
        }

        #endregion

        private Button BlueButtonControl;
    }
}
