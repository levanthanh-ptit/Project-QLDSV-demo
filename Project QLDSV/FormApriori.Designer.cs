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
            this.txtListL = new System.Windows.Forms.Label();
            this.dataGridViewListF = new System.Windows.Forms.DataGridView();
            this.dataGridViewListL = new System.Windows.Forms.DataGridView();
            this.txtListF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTapF = new System.Windows.Forms.TextBox();
            this.txtTapL = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.txtListL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewListF, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewListL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtListF, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 302);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtListL
            // 
            this.txtListL.AutoSize = true;
            this.txtListL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListL.Location = new System.Drawing.Point(591, 0);
            this.txtListL.Name = "txtListL";
            this.txtListL.Size = new System.Drawing.Size(57, 20);
            this.txtListL.TabIndex = 5;
            this.txtListL.Text = "Tập L";
            // 
            // dataGridViewListF
            // 
            this.dataGridViewListF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID,
            this.F_Item});
            this.dataGridViewListF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListF.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewListF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListF.Name = "dataGridViewListF";
            this.dataGridViewListF.RowHeadersWidth = 51;
            this.dataGridViewListF.RowTemplate.Height = 24;
            this.dataGridViewListF.Size = new System.Drawing.Size(582, 270);
            this.dataGridViewListF.TabIndex = 0;
            // 
            // dataGridViewListL
            // 
            this.dataGridViewListL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSet,
            this.SUPPORT});
            this.dataGridViewListL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListL.Location = new System.Drawing.Point(591, 30);
            this.dataGridViewListL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListL.Name = "dataGridViewListL";
            this.dataGridViewListL.RowHeadersWidth = 51;
            this.dataGridViewListL.RowTemplate.Height = 24;
            this.dataGridViewListL.Size = new System.Drawing.Size(582, 270);
            this.dataGridViewListL.TabIndex = 1;
            // 
            // txtListF
            // 
            this.txtListF.AutoSize = true;
            this.txtListF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListF.Location = new System.Drawing.Point(3, 0);
            this.txtListF.Name = "txtListF";
            this.txtListF.Size = new System.Drawing.Size(57, 20);
            this.txtListF.TabIndex = 4;
            this.txtListF.Text = "Tập F";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "APRIORI_TID GEN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(169, 459);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnNext.Location = new System.Drawing.Point(795, 459);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 59);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Apriori_TID Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TID
            // 
            this.TID.HeaderText = "TID";
            this.TID.MinimumWidth = 6;
            this.TID.Name = "TID";
            this.TID.Width = 125;
            // 
            // F_Item
            // 
            this.F_Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F_Item.HeaderText = "CADIDATE";
            this.F_Item.MinimumWidth = 6;
            this.F_Item.Name = "F_Item";
            // 
            // ItemSet
            // 
            this.ItemSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemSet.HeaderText = "CANDIDATE";
            this.ItemSet.MinimumWidth = 6;
            this.ItemSet.Name = "ItemSet";
            // 
            // SUPPORT
            // 
            this.SUPPORT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUPPORT.HeaderText = "SUPPORT";
            this.SUPPORT.MinimumWidth = 6;
            this.SUPPORT.Name = "SUPPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // txtTapF
            // 
            this.txtTapF.Location = new System.Drawing.Point(87, 387);
            this.txtTapF.Name = "txtTapF";
            this.txtTapF.Size = new System.Drawing.Size(68, 22);
            this.txtTapF.TabIndex = 6;
            // 
            // txtTapL
            // 
            this.txtTapL.Location = new System.Drawing.Point(669, 387);
            this.txtTapL.Name = "txtTapL";
            this.txtTapL.Size = new System.Drawing.Size(66, 22);
            this.txtTapL.TabIndex = 7;
            // 
            // FormApriori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 619);
            this.Controls.Add(this.txtTapL);
            this.Controls.Add(this.txtTapF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormApriori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApriori";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewListL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label txtListF;
        private System.Windows.Forms.Label txtListL;
        private System.Windows.Forms.DataGridView dataGridViewListF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTapF;
        private System.Windows.Forms.TextBox txtTapL;
    }
}