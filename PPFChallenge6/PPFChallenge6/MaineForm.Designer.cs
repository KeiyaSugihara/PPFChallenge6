namespace PPFChallenge6
{
    partial class MaineForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.ToDoDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftDaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ListEditFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PunishmentButton = new System.Windows.Forms.Button();
            this.PraiseButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OptionFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDataGridView)).BeginInit();
            this.ListEditFlowLayoutPanel.SuspendLayout();
            this.OptionFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveButton.Location = new System.Drawing.Point(3, 2);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(91, 38);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExitButton.Location = new System.Drawing.Point(3, 44);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(91, 38);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "終了";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // QuoteLabel
            // 
            this.QuoteLabel.Font = new System.Drawing.Font("富士ポップ", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuoteLabel.ForeColor = System.Drawing.Color.White;
            this.QuoteLabel.Location = new System.Drawing.Point(724, 24);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(195, 28);
            this.QuoteLabel.TabIndex = 3;
            this.QuoteLabel.Text = "見ておりますよ...";
            // 
            // ToDoDataGridView
            // 
            this.ToDoDataGridView.AllowUserToAddRows = false;
            this.ToDoDataGridView.AllowUserToDeleteRows = false;
            this.ToDoDataGridView.AllowUserToResizeColumns = false;
            this.ToDoDataGridView.AllowUserToResizeRows = false;
            this.ToDoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ToDoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ToDoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectColumn,
            this.PeriodColumn,
            this.LeftDaysColumn,
            this.ToDoColumn});
            this.ToDoDataGridView.Location = new System.Drawing.Point(131, 65);
            this.ToDoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToDoDataGridView.MultiSelect = false;
            this.ToDoDataGridView.Name = "ToDoDataGridView";
            this.ToDoDataGridView.RowHeadersVisible = false;
            this.ToDoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ToDoDataGridView.RowTemplate.Height = 24;
            this.ToDoDataGridView.Size = new System.Drawing.Size(772, 526);
            this.ToDoDataGridView.TabIndex = 4;
            this.ToDoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToDoDataGridView_CellValueChanged);
            this.ToDoDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.ToDoDataGridView_CurrentCellDirtyStateChanged);
            // 
            // SelectColumn
            // 
            this.SelectColumn.FillWeight = 34.3303F;
            this.SelectColumn.HeaderText = "選択";
            this.SelectColumn.Name = "SelectColumn";
            this.SelectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectColumn.Width = 80;
            // 
            // PeriodColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PeriodColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PeriodColumn.FillWeight = 74.09158F;
            this.PeriodColumn.HeaderText = "期限";
            this.PeriodColumn.Name = "PeriodColumn";
            this.PeriodColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PeriodColumn.Width = 130;
            // 
            // LeftDaysColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LeftDaysColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.LeftDaysColumn.FillWeight = 197.8712F;
            this.LeftDaysColumn.HeaderText = "残り日数";
            this.LeftDaysColumn.Name = "LeftDaysColumn";
            this.LeftDaysColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LeftDaysColumn.Width = 130;
            // 
            // ToDoColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ToDoColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ToDoColumn.FillWeight = 93.70694F;
            this.ToDoColumn.HeaderText = "やること";
            this.ToDoColumn.Name = "ToDoColumn";
            this.ToDoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ToDoColumn.Width = 235;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddButton.Location = new System.Drawing.Point(3, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 38);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EditButton.Location = new System.Drawing.Point(3, 44);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(91, 38);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "編集";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ListEditFlowLayoutPanel
            // 
            this.ListEditFlowLayoutPanel.Controls.Add(this.AddButton);
            this.ListEditFlowLayoutPanel.Controls.Add(this.EditButton);
            this.ListEditFlowLayoutPanel.Controls.Add(this.DeleteButton);
            this.ListEditFlowLayoutPanel.Location = new System.Drawing.Point(12, 65);
            this.ListEditFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListEditFlowLayoutPanel.Name = "ListEditFlowLayoutPanel";
            this.ListEditFlowLayoutPanel.Size = new System.Drawing.Size(99, 130);
            this.ListEditFlowLayoutPanel.TabIndex = 8;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteButton.Location = new System.Drawing.Point(3, 86);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 38);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PunishmentButton
            // 
            this.PunishmentButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PunishmentButton.Location = new System.Drawing.Point(937, 554);
            this.PunishmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PunishmentButton.Name = "PunishmentButton";
            this.PunishmentButton.Size = new System.Drawing.Size(240, 38);
            this.PunishmentButton.TabIndex = 9;
            this.PunishmentButton.Text = "お叱りを受ける...";
            this.PunishmentButton.UseVisualStyleBackColor = true;
            this.PunishmentButton.Click += new System.EventHandler(this.PunishmentButton_Click);
            // 
            // PraiseButton
            // 
            this.PraiseButton.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PraiseButton.Location = new System.Drawing.Point(937, 511);
            this.PraiseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PraiseButton.Name = "PraiseButton";
            this.PraiseButton.Size = new System.Drawing.Size(240, 38);
            this.PraiseButton.TabIndex = 10;
            this.PraiseButton.Text = "褒めてもらう♡";
            this.PraiseButton.UseVisualStyleBackColor = true;
            this.PraiseButton.Click += new System.EventHandler(this.PraiseButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.Black;
            this.DescriptionLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(131, 604);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(1047, 42);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "期限内に完了したものを選択にチェックを入れ褒めてもらってください。\r\n期限内に完了しなかったものを選択にチェックを入れお叱りを受けてください。";
            // 
            // OptionFlowLayoutPanel1
            // 
            this.OptionFlowLayoutPanel1.Controls.Add(this.SaveButton);
            this.OptionFlowLayoutPanel1.Controls.Add(this.ExitButton);
            this.OptionFlowLayoutPanel1.Location = new System.Drawing.Point(12, 508);
            this.OptionFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionFlowLayoutPanel1.Name = "OptionFlowLayoutPanel1";
            this.OptionFlowLayoutPanel1.Size = new System.Drawing.Size(99, 92);
            this.OptionFlowLayoutPanel1.TabIndex = 12;
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Image = global::PPFChallenge6.Properties.Resources.Daibutu;
            this.CharacterPictureBox.Location = new System.Drawing.Point(921, 0);
            this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(287, 488);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CharacterPictureBox.TabIndex = 0;
            this.CharacterPictureBox.TabStop = false;
            // 
            // MaineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1211, 675);
            this.ControlBox = false;
            this.Controls.Add(this.OptionFlowLayoutPanel1);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PraiseButton);
            this.Controls.Add(this.PunishmentButton);
            this.Controls.Add(this.ListEditFlowLayoutPanel);
            this.Controls.Add(this.ToDoDataGridView);
            this.Controls.Add(this.QuoteLabel);
            this.Controls.Add(this.CharacterPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1211, 675);
            this.MinimumSize = new System.Drawing.Size(1211, 675);
            this.Name = "MaineForm";
            this.Text = "不撓不屈";
            this.Load += new System.EventHandler(this.Maine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoDataGridView)).EndInit();
            this.ListEditFlowLayoutPanel.ResumeLayout(false);
            this.OptionFlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CharacterPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.DataGridView ToDoDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.FlowLayoutPanel ListEditFlowLayoutPanel;
        private System.Windows.Forms.Button PunishmentButton;
        private System.Windows.Forms.Button PraiseButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel OptionFlowLayoutPanel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftDaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDoColumn;
        private System.Windows.Forms.Button DeleteButton;
    }
}

