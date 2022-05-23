namespace CreateAIDataSate
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
            this.btnGetMobiles = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnGenerateDataSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetMobiles
            // 
            this.btnGetMobiles.Location = new System.Drawing.Point(202, 12);
            this.btnGetMobiles.Name = "btnGetMobiles";
            this.btnGetMobiles.Size = new System.Drawing.Size(150, 65);
            this.btnGetMobiles.TabIndex = 1;
            this.btnGetMobiles.Text = "Get All Mobiles";
            this.btnGetMobiles.UseVisualStyleBackColor = true;
            this.btnGetMobiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(12, 12);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(184, 65);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connect to Data base";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenerateDataSet
            // 
            this.btnGenerateDataSet.Location = new System.Drawing.Point(358, 12);
            this.btnGenerateDataSet.Name = "btnGenerateDataSet";
            this.btnGenerateDataSet.Size = new System.Drawing.Size(162, 65);
            this.btnGenerateDataSet.TabIndex = 2;
            this.btnGenerateDataSet.Text = "Generate Dataset";
            this.btnGenerateDataSet.UseVisualStyleBackColor = true;
            this.btnGenerateDataSet.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 87);
            this.Controls.Add(this.btnGenerateDataSet);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.btnGetMobiles);
            this.MaximumSize = new System.Drawing.Size(550, 134);
            this.MinimumSize = new System.Drawing.Size(550, 134);
            this.Name = "Form1";
            this.Text = "Generate DataSet";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGetMobiles;
        private Button btnConnection;
        private Button btnGenerateDataSet;
    }
}