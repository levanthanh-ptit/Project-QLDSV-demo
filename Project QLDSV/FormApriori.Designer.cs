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
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewListL = new System.Windows.Forms.DataGridView();
            this.ItemSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtListF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 245);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtListL
            // 
            this.txtListL.AutoSize = true;
            this.txtListL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListL.Location = new System.Drawing.Point(443, 0);
            this.txtListL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtListL.Name = "txtListL";
            this.txtListL.Size = new System.Drawing.Size(50, 17);
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
            this.dataGridViewListF.Location = new System.Drawing.Point(2, 25);
            this.dataGridViewListF.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListF.Name = "dataGridViewListF";
            this.dataGridViewListF.RowHeadersWidth = 51;
            this.dataGridViewListF.RowTemplate.Height = 24;
            this.dataGridViewListF.Size = new System.Drawing.Size(437, 218);
            this.dataGridViewListF.TabIndex = 0;
            this.dataGridViewListF.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewListF_Scroll);
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
            this.F_Item.HeaderText = "CADIDATE";
            this.F_Item.MinimumWidth = 6;
            this.F_Item.Name = "F_Item";
            this.F_Item.Width = 125;
            // 
            // dataGridViewListL
            // 
            this.dataGridViewListL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemSet,
            this.SUPPORT});
            this.dataGridViewListL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListL.Location = new System.Drawing.Point(443, 25);
            this.dataGridViewListL.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListL.Name = "dataGridViewListL";
            this.dataGridViewListL.RowHeadersWidth = 51;
            this.dataGridViewListL.RowTemplate.Height = 24;
            this.dataGridViewListL.Size = new System.Drawing.Size(437, 218);
            this.dataGridViewListL.TabIndex = 1;
            // 
            // ItemSet
            // 
            this.ItemSet.HeaderText = "CANDIDATE";
            this.ItemSet.MinimumWidth = 6;
            this.ItemSet.Name = "ItemSet";
            this.ItemSet.Width = 125;
            // 
            // SUPPORT
            // 
            this.SUPPORT.HeaderText = "SUPPORT";
            this.SUPPORT.MinimumWidth = 6;
            this.SUPPORT.Name = "SUPPORT";
            this.SUPPORT.Width = 125;
            // 
            // txtListF
            // 
            this.txtListF.AutoSize = true;
            this.txtListF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListF.Location = new System.Drawing.Point(2, 0);
            this.txtListF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtListF.Name = "txtListF";
            this.txtListF.Size = new System.Drawing.Size(50, 17);
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
            this.label1.Location = new System.Drawing.Point(314, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "APRIORI_TID GEN ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(124, 318);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 48);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Apriori_TID Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(598, 318);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(139, 48);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Apriori_TID Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // FormApriori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 503);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}