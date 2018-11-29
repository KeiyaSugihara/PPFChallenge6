namespace PPFChallenge6
{
    partial class SentenceForm
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
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.SetTextBox = new System.Windows.Forms.TextBox();
            this.SetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PeriodLabel.Location = new System.Drawing.Point(28, 31);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(100, 23);
            this.PeriodLabel.TabIndex = 7;
            this.PeriodLabel.Text = "期限";
            // 
            // SetTextBox
            // 
            this.SetTextBox.AcceptsReturn = true;
            this.SetTextBox.AcceptsTab = true;
            this.SetTextBox.Location = new System.Drawing.Point(32, 128);
            this.SetTextBox.Multiline = true;
            this.SetTextBox.Name = "SetTextBox";
            this.SetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SetTextBox.Size = new System.Drawing.Size(378, 294);
            this.SetTextBox.TabIndex = 6;
            this.SetTextBox.TextChanged += new System.EventHandler(this.SetTextBox_TextChanged);
            // 
            // SetDateTimePicker
            // 
            this.SetDateTimePicker.Location = new System.Drawing.Point(32, 57);
            this.SetDateTimePicker.Name = "SetDateTimePicker";
            this.SetDateTimePicker.Size = new System.Drawing.Size(157, 22);
            this.SetDateTimePicker.TabIndex = 5;
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ToDoLabel.Location = new System.Drawing.Point(28, 102);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(100, 23);
            this.ToDoLabel.TabIndex = 10;
            this.ToDoLabel.Text = "やること";
            // 
            // SetButton
            // 
            this.SetButton.Enabled = false;
            this.SetButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SetButton.Location = new System.Drawing.Point(314, 441);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(96, 42);
            this.SetButton.TabIndex = 11;
            this.SetButton.Text = "登録";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // SentenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(456, 507);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.PeriodLabel);
            this.Controls.Add(this.SetTextBox);
            this.Controls.Add(this.SetDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SentenceForm";
            this.Text = "SentenceForm";
            this.Load += new System.EventHandler(this.SentenceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.TextBox SetTextBox;
        private System.Windows.Forms.DateTimePicker SetDateTimePicker;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.Button SetButton;
    }
}