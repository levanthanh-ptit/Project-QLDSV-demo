namespace Project_QLDSV
{
    partial class FormMain
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
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenItemset = new System.Windows.Forms.Button();
            this.labelMinSup = new System.Windows.Forms.Label();
            this.trackBarMinSup = new System.Windows.Forms.TrackBar();
            this.btnRefill = new System.Windows.Forms.Button();
            this.dataGridViewGiaotac = new System.Windows.Forms.DataGridView();
            this.MASVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.AllowUserToAddRows = false;
            this.dataGridViewMonHoc.AllowUserToDeleteRows = false;
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.MAMHCol,
            this.TENMHCol});
            this.dataGridViewMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.ReadOnly = true;
            this.dataGridViewMonHoc.RowHeadersWidth = 20;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(384, 307);
            this.dataGridViewMonHoc.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.HeaderText = "keyMH";
            this.Key.MinimumWidth = 6;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 60;
            // 
            // MAMHCol
            // 
            this.MAMHCol.HeaderText = "Mã môn học";
            this.MAMHCol.MinimumWidth = 6;
            this.MAMHCol.Name = "MAMHCol";
            this.MAMHCol.ReadOnly = true;
            this.MAMHCol.Width = 125;
            // 
            // TENMHCol
            // 
            this.TENMHCol.HeaderText = "Tên môn học";
            this.TENMHCol.MinimumWidth = 6;
            this.TENMHCol.Name = "TENMHCol";
            this.TENMHCol.ReadOnly = true;
            this.TENMHCol.Width = 220;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMonHoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewGiaotac, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1308, 525);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenItemset);
            this.panel1.Controls.Add(this.labelMinSup);
            this.panel1.Controls.Add(this.trackBarMinSup);
            this.panel1.Controls.Add(this.btnRefill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(396, 319);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 202);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "MinSup:";
            // 
            // btnGenItemset
            // 
            this.btnGenItemset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenItemset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenItemset.Location = new System.Drawing.Point(463, 119);
            this.btnGenItemset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenItemset.Name = "btnGenItemset";
            this.btnGenItemset.Size = new System.Drawing.Size(168, 47);
            this.btnGenItemset.TabIndex = 5;
            this.btnGenItemset.Text = "Gen Itemsets";
            this.btnGenItemset.UseVisualStyleBackColor = true;
            this.btnGenItemset.Click += new System.EventHandler(this.BtnGenItemset_Click);
            // 
            // labelMinSup
            // 
            this.labelMinSup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMinSup.AutoSize = true;
            this.labelMinSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinSup.Location = new System.Drawing.Point(499, 14);
            this.labelMinSup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinSup.Name = "labelMinSup";
            this.labelMinSup.Size = new System.Drawing.Size(30, 17);
            this.labelMinSup.TabIndex = 4;
            this.labelMinSup.Text = "0%";
            // 
            // trackBarMinSup
            // 
            this.trackBarMinSup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMinSup.Location = new System.Drawing.Point(61, 34);
            this.trackBarMinSup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarMinSup.Maximum = 100;
            this.trackBarMinSup.Name = "trackBarMinSup";
            this.trackBarMinSup.Size = new System.Drawing.Size(797, 56);
            this.trackBarMinSup.TabIndex = 3;
            this.trackBarMinSup.Scroll += new System.EventHandler(this.trackBarMinSup_Scroll);
            // 
            // btnRefill
            // 
            this.btnRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefill.Location = new System.Drawing.Point(288, 119);
            this.btnRefill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(168, 47);
            this.btnRefill.TabIndex = 2;
            this.btnRefill.Text = "Find D";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // dataGridViewGiaotac
            // 
            this.dataGridViewGiaotac.AllowUserToAddRows = false;
            this.dataGridViewGiaotac.AllowUserToDeleteRows = false;
            this.dataGridViewGiaotac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaotac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASVCol});
            this.dataGridViewGiaotac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGiaotac.Location = new System.Drawing.Point(396, 4);
            this.dataGridViewGiaotac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewGiaotac.Name = "dataGridViewGiaotac";
            this.dataGridViewGiaotac.ReadOnly = true;
            this.dataGridViewGiaotac.RowHeadersWidth = 20;
            this.dataGridViewGiaotac.Size = new System.Drawing.Size(908, 307);
            this.dataGridViewGiaotac.TabIndex = 1;
            // 
            // MASVCol
            // 
            this.MASVCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASVCol.HeaderText = "Mã SV";
            this.MASVCol.MinimumWidth = 6;
            this.MASVCol.Name = "MASVCol";
            this.MASVCol.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(465, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐỀ TÀI TÌM LUẬT MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "DANH SÁCH MÔN HỌC";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "BẢNG GIAO TÁC (TẬP D)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 619);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewGiaotac;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarMinSup;
        private System.Windows.Forms.Label labelMinSup;
        private System.Windows.Forms.Button btnGenItemset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASVCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMHCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMHCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}