namespace Project_QLDSV
{
    partial class FormApriori
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewListF = new System.Windows.Forms.DataGridView();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CADIDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewListL = new System.Windows.Forms.DataGridView();
            this.CANDIDATE_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListL)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewListF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewListL, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewListF
            // 
            this.dataGridViewListF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID,
            this.CADIDATE});
            this.dataGridViewListF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListF.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewListF.Name = "dataGridViewListF";
            this.dataGridViewListF.RowHeadersWidth = 51;
            this.dataGridViewListF.RowTemplate.Height = 24;
            this.dataGridViewListF.Size = new System.Drawing.Size(495, 223);
            this.dataGridViewListF.TabIndex = 0;
            // 
            // TID
            // 
            this.TID.HeaderText = "TID";
            this.TID.MinimumWidth = 6;
            this.TID.Name = "TID";
            this.TID.Width = 125;
            // 
            // CADIDATE
            // 
            this.CADIDATE.HeaderText = "CADIDATE";
            this.CADIDATE.MinimumWidth = 6;
            this.CADIDATE.Name = "CADIDATE";
            this.CADIDATE.Width = 125;
            // 
            // dataGridViewListL
            // 
            this.dataGridViewListL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CANDIDATE_C,
            this.SUPPORT});
            this.dataGridViewListL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListL.Location = new System.Drawing.Point(504, 3);
            this.dataGridViewListL.Name = "dataGridViewListL";
            this.dataGridViewListL.RowHeadersWidth = 51;
            this.dataGridViewListL.RowTemplate.Height = 24;
            this.dataGridViewListL.Size = new System.Drawing.Size(496, 223);
            this.dataGridViewListL.TabIndex = 1;
            // 
            // CANDIDATE_C
            // 
            this.CANDIDATE_C.HeaderText = "CANDIDATE";
            this.CANDIDATE_C.MinimumWidth = 6;
            this.CANDIDATE_C.Name = "CANDIDATE_C";
            this.CANDIDATE_C.Width = 125;
            // 
            // SUPPORT
            // 
            this.SUPPORT.HeaderText = "SUPPORT";
            this.SUPPORT.MinimumWidth = 6;
            this.SUPPORT.Name = "SUPPORT";
            this.SUPPORT.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "APRIORI_TID GEN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(133, 318);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 59);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Apriori_TID Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(690, 318);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 59);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Apriori_TID Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tập F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tập L";
            // 
            // FormApriori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormApriori";
            this.Text = "FormApriori";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CADIDATE;
        private System.Windows.Forms.DataGridView dataGridViewListL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANDIDATE_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewListF;
    }
}