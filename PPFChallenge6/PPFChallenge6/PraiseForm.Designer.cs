namespace PPFChallenge6
{
    partial class PraiseForm
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
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommentLabel
            // 
            this.CommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CommentLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CommentLabel.ForeColor = System.Drawing.Color.Red;
            this.CommentLabel.Location = new System.Drawing.Point(0, 0);
            this.CommentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(672, 562);
            this.CommentLabel.TabIndex = 0;
            this.CommentLabel.Text = "\r\nよくできました！\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n努力することは素晴らしい事ですよ。";
            this.CommentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CommentLabel.Click += new System.EventHandler(this.CommentLabel_Click);
            // 
            // PraiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPFChallenge6.Properties.Resources.miroku_400x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 562);
            this.Controls.Add(this.CommentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PraiseForm";
            this.Text = "PraiseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CommentLabel;
    }
}