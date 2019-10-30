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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenItemset = new System.Windows.Forms.Button();
            this.labelMinSup = new System.Windows.Forms.Label();
            this.trackBarMinSup = new System.Windows.Forms.TrackBar();
            this.btnRefill = new System.Windows.Forms.Button();
            this.dataGridViewGiaotac = new System.Windows.Forms.DataGridView();
            this.MASVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewEncode = new System.Windows.Forms.DataGridView();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEncode)).BeginInit();
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
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.ReadOnly = true;
            this.dataGridViewMonHoc.RowHeadersWidth = 20;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(337, 235);
            this.dataGridViewMonHoc.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.HeaderText = "keyMH";
            this.Key.MinimumWidth = 6;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 55;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMonHoc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewGiaotac, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 427);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "BẢNG GIAO TÁC (TẬP D)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "DANH SÁCH MÔN HỌC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenItemset);
            this.panel1.Controls.Add(this.labelMinSup);
            this.panel1.Controls.Add(this.trackBarMinSup);
            this.panel1.Controls.Add(this.btnRefill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(346, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 155);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "MinSup:";
            // 
            // btnGenItemset
            // 
            this.btnGenItemset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenItemset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenItemset.Location = new System.Drawing.Point(298, 97);
            this.btnGenItemset.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenItemset.Name = "btnGenItemset";
            this.btnGenItemset.Size = new System.Drawing.Size(126, 38);
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
            this.labelMinSup.Location = new System.Drawing.Point(350, 11);
            this.labelMinSup.Name = "labelMinSup";
            this.labelMinSup.Size = new System.Drawing.Size(23, 13);
            this.labelMinSup.TabIndex = 4;
            this.labelMinSup.Text = "0%";
            // 
            // trackBarMinSup
            // 
            this.trackBarMinSup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMinSup.Location = new System.Drawing.Point(46, 28);
            this.trackBarMinSup.Maximum = 100;
            this.trackBarMinSup.Name = "trackBarMinSup";
            this.trackBarMinSup.Size = new System.Drawing.Size(549, 45);
            this.trackBarMinSup.TabIndex = 3;
            this.trackBarMinSup.Scroll += new System.EventHandler(this.trackBarMinSup_Scroll);
            // 
            // btnRefill
            // 
            this.btnRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefill.Location = new System.Drawing.Point(216, 97);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(126, 38);
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
            this.dataGridViewGiaotac.Location = new System.Drawing.Point(346, 28);
            this.dataGridViewGiaotac.Name = "dataGridViewGiaotac";
            this.dataGridViewGiaotac.ReadOnly = true;
            this.dataGridViewGiaotac.RowHeadersWidth = 20;
            this.dataGridViewGiaotac.Size = new System.Drawing.Size(632, 235);
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
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐỀ TÀI TÌM LUẬT MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewEncode, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 269);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 155);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã hóa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewEncode
            // 
            this.dataGridViewEncode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEncode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.colEncode});
            this.dataGridViewEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEncode.Location = new System.Drawing.Point(3, 28);
            this.dataGridViewEncode.Name = "dataGridViewEncode";
            this.dataGridViewEncode.Size = new System.Drawing.Size(331, 124);
            this.dataGridViewEncode.TabIndex = 5;
            // 
            // colMaMH
            // 
            this.colMaMH.HeaderText = "Mã Môn học";
            this.colMaMH.Name = "colMaMH";
            // 
            // colEncode
            // 
            this.colEncode.HeaderText = "Mã hóa";
            this.colEncode.Name = "colEncode";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEncode)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMHCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMHCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewEncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEncode;
    }
}