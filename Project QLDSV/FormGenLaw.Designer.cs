namespace Project_QLDSV
{
    partial class FormGenLaw
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textMinConf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbarMinConf = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSINHLUAT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridLaw = new System.Windows.Forms.DataGridView();
            this.MH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecordLaw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMinConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINH LUẬT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "MinConf:";
            // 
            // textMinConf
            // 
            this.textMinConf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textMinConf.Location = new System.Drawing.Point(419, 78);
            this.textMinConf.Name = "textMinConf";
            this.textMinConf.Size = new System.Drawing.Size(54, 22);
            this.textMinConf.TabIndex = 2;
            this.textMinConf.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "%";
            // 
            // tbarMinConf
            // 
            this.tbarMinConf.Location = new System.Drawing.Point(141, 145);
            this.tbarMinConf.Maximum = 100;
            this.tbarMinConf.Name = "tbarMinConf";
            this.tbarMinConf.Size = new System.Drawing.Size(374, 56);
            this.tbarMinConf.TabIndex = 4;
            this.tbarMinConf.Scroll += new System.EventHandler(this.TbarMinConf_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "100%";
            // 
            // btnSINHLUAT
            // 
            this.btnSINHLUAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSINHLUAT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSINHLUAT.Location = new System.Drawing.Point(612, 125);
            this.btnSINHLUAT.Name = "btnSINHLUAT";
            this.btnSINHLUAT.Size = new System.Drawing.Size(163, 62);
            this.btnSINHLUAT.TabIndex = 7;
            this.btnSINHLUAT.Text = "SINH LUẬT";
            this.btnSINHLUAT.UseVisualStyleBackColor = true;
            this.btnSINHLUAT.Click += new System.EventHandler(this.BtnSINHLUAT_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 394);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dataGridLaw
            // 
            this.dataGridLaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MH,
            this.Min});
            this.dataGridLaw.Location = new System.Drawing.Point(0, 207);
            this.dataGridLaw.Name = "dataGridLaw";
            this.dataGridLaw.RowHeadersWidth = 51;
            this.dataGridLaw.RowTemplate.Height = 24;
            this.dataGridLaw.Size = new System.Drawing.Size(983, 359);
            this.dataGridLaw.TabIndex = 0;
            this.dataGridLaw.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridLaw_Scroll);
            // 
            // MH
            // 
            this.MH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MH.FillWeight = 93.04813F;
            this.MH.HeaderText = "Môn học";
            this.MH.MinimumWidth = 6;
            this.MH.Name = "MH";
            // 
            // Min
            // 
            this.Min.FillWeight = 106.9519F;
            this.Min.HeaderText = "MinConf";
            this.Min.MinimumWidth = 6;
            this.Min.Name = "Min";
            this.Min.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Record:";
            // 
            // txtRecordLaw
            // 
            this.txtRecordLaw.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRecordLaw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRecordLaw.Location = new System.Drawing.Point(76, 184);
            this.txtRecordLaw.Name = "txtRecordLaw";
            this.txtRecordLaw.Size = new System.Drawing.Size(58, 22);
            this.txtRecordLaw.TabIndex = 10;
            this.txtRecordLaw.Text = "0";
            // 
            // FormGenLaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.txtRecordLaw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridLaw);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSINHLUAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbarMinConf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMinConf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGenLaw";
            this.Text = "GenerateLaw";
            ((System.ComponentModel.ISupportInitialize)(this.tbarMinConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMinConf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbarMinConf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSINHLUAT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridLaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn MH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecordLaw;
    }
}