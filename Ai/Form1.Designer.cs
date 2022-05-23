namespace Ai
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
            this.btnPridict = new System.Windows.Forms.Button();
            this.txtMobId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvMob = new System.Windows.Forms.DataGridView();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Priorization = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstCombo = new System.Windows.Forms.ComboBox();
            this.SecondCombo = new System.Windows.Forms.ComboBox();
            this.thirdCombo = new System.Windows.Forms.ComboBox();
            this.fourthCombo = new System.Windows.Forms.ComboBox();
            this.fifthCombo = new System.Windows.Forms.ComboBox();
            this.grpFields = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMob)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Priorization.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpFields.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPridict
            // 
            this.btnPridict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPridict.Location = new System.Drawing.Point(142, 121);
            this.btnPridict.Name = "btnPridict";
            this.btnPridict.Size = new System.Drawing.Size(120, 43);
            this.btnPridict.TabIndex = 0;
            this.btnPridict.Text = "Predict";
            this.btnPridict.UseVisualStyleBackColor = true;
            this.btnPridict.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMobId
            // 
            this.txtMobId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMobId.Location = new System.Drawing.Point(121, 3);
            this.txtMobId.Name = "txtMobId";
            this.txtMobId.Size = new System.Drawing.Size(141, 27);
            this.txtMobId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mobile Id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 167);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(135, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(127, 167);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(3, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(112, 38);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(121, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 27);
            this.txtPrice.TabIndex = 8;
            // 
            // dgvMob
            // 
            this.dgvMob.AllowUserToAddRows = false;
            this.dgvMob.AllowUserToDeleteRows = false;
            this.dgvMob.AllowUserToOrderColumns = true;
            this.dgvMob.AllowUserToResizeColumns = false;
            this.dgvMob.AllowUserToResizeRows = false;
            this.dgvMob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rank,
            this.MobileID,
            this.MobileName,
            this.Rating});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMob, 3);
            this.dgvMob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMob.Location = new System.Drawing.Point(3, 202);
            this.dgvMob.MultiSelect = false;
            this.dgvMob.Name = "dgvMob";
            this.dgvMob.ReadOnly = true;
            this.dgvMob.RowHeadersWidth = 51;
            this.dgvMob.RowTemplate.Height = 29;
            this.dgvMob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMob.ShowCellErrors = false;
            this.dgvMob.Size = new System.Drawing.Size(825, 313);
            this.dgvMob.TabIndex = 9;
            // 
            // rank
            // 
            this.rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rank.HeaderText = "rank";
            this.rank.MinimumWidth = 6;
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            // 
            // MobileID
            // 
            this.MobileID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MobileID.HeaderText = "Mobile ID";
            this.MobileID.MinimumWidth = 6;
            this.MobileID.Name = "MobileID";
            this.MobileID.ReadOnly = true;
            // 
            // MobileName
            // 
            this.MobileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MobileName.HeaderText = "Mobile Name";
            this.MobileName.MinimumWidth = 6;
            this.MobileName.Name = "MobileName";
            this.MobileName.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMob, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Priorization, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpFields, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.41699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.58301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 518);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Priorization
            // 
            this.Priorization.Controls.Add(this.tableLayoutPanel4);
            this.Priorization.Location = new System.Drawing.Point(3, 3);
            this.Priorization.Name = "Priorization";
            this.Priorization.Size = new System.Drawing.Size(271, 193);
            this.Priorization.TabIndex = 10;
            this.Priorization.TabStop = false;
            this.Priorization.Text = "Priorization";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.59259F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.40741F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.FirstCombo, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.SecondCombo, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.thirdCombo, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.fourthCombo, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.fifthCombo, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(265, 167);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "First";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Second";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Third";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fourth";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 35);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fifth";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstCombo
            // 
            this.FirstCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstCombo.FormattingEnabled = true;
            this.FirstCombo.Location = new System.Drawing.Point(115, 3);
            this.FirstCombo.Name = "FirstCombo";
            this.FirstCombo.Size = new System.Drawing.Size(147, 28);
            this.FirstCombo.TabIndex = 6;
            // 
            // SecondCombo
            // 
            this.SecondCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondCombo.FormattingEnabled = true;
            this.SecondCombo.Location = new System.Drawing.Point(115, 36);
            this.SecondCombo.Name = "SecondCombo";
            this.SecondCombo.Size = new System.Drawing.Size(147, 28);
            this.SecondCombo.TabIndex = 7;
            // 
            // thirdCombo
            // 
            this.thirdCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdCombo.FormattingEnabled = true;
            this.thirdCombo.Location = new System.Drawing.Point(115, 69);
            this.thirdCombo.Name = "thirdCombo";
            this.thirdCombo.Size = new System.Drawing.Size(147, 28);
            this.thirdCombo.TabIndex = 8;
            // 
            // fourthCombo
            // 
            this.fourthCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourthCombo.FormattingEnabled = true;
            this.fourthCombo.Location = new System.Drawing.Point(115, 102);
            this.fourthCombo.Name = "fourthCombo";
            this.fourthCombo.Size = new System.Drawing.Size(147, 28);
            this.fourthCombo.TabIndex = 9;
            // 
            // fifthCombo
            // 
            this.fifthCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fifthCombo.FormattingEnabled = true;
            this.fifthCombo.Location = new System.Drawing.Point(115, 135);
            this.fifthCombo.Name = "fifthCombo";
            this.fifthCombo.Size = new System.Drawing.Size(147, 28);
            this.fifthCombo.TabIndex = 10;
            // 
            // grpFields
            // 
            this.grpFields.Controls.Add(this.tableLayoutPanel2);
            this.grpFields.Location = new System.Drawing.Point(280, 3);
            this.grpFields.Name = "grpFields";
            this.grpFields.Size = new System.Drawing.Size(271, 193);
            this.grpFields.TabIndex = 0;
            this.grpFields.TabStop = false;
            this.grpFields.Text = "Filter";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.61538F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.38462F));
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPrice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMobId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPridict, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.8926F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.88808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.21932F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 167);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(557, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predict";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblResult, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 167);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Recomindation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMob)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Priorization.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.grpFields.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPridict;
        private TextBox txtMobId;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private Label lblPrice;
        private TextBox txtPrice;
        private DataGridView dgvMob;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpFields;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridViewTextBoxColumn rank;
        private DataGridViewTextBoxColumn MobileID;
        private DataGridViewTextBoxColumn MobileName;
        private DataGridViewTextBoxColumn Rating;
        private GroupBox Priorization;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox FirstCombo;
        private ComboBox SecondCombo;
        private ComboBox thirdCombo;
        private ComboBox fourthCombo;
        private ComboBox fifthCombo;
    }
}