﻿namespace Project_QLDSV
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewGiaotac = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenItemset = new System.Windows.Forms.Button();
            this.labelMinSup = new System.Windows.Forms.Label();
            this.trackBarMinSup = new System.Windows.Forms.TrackBar();
            this.btnRefill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MASVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.MAMHCol,
            this.TENMHCol});
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.RowHeadersWidth = 51;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(384, 325);
            this.dataGridViewMonHoc.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMonHoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewGiaotac, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1308, 555);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewGiaotac
            // 
            this.dataGridViewGiaotac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGiaotac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaotac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASVCol});
            this.dataGridViewGiaotac.Location = new System.Drawing.Point(396, 4);
            this.dataGridViewGiaotac.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGiaotac.Name = "dataGridViewGiaotac";
            this.dataGridViewGiaotac.RowHeadersWidth = 51;
            this.dataGridViewGiaotac.Size = new System.Drawing.Size(908, 325);
            this.dataGridViewGiaotac.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGenItemset);
            this.panel1.Controls.Add(this.labelMinSup);
            this.panel1.Controls.Add(this.trackBarMinSup);
            this.panel1.Controls.Add(this.btnRefill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(396, 337);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 214);
            this.panel1.TabIndex = 3;
            // 
            // btnGenItemset
            // 
            this.btnGenItemset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenItemset.Location = new System.Drawing.Point(460, 119);
            this.btnGenItemset.Name = "btnGenItemset";
            this.btnGenItemset.Size = new System.Drawing.Size(148, 64);
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
            this.trackBarMinSup.Location = new System.Drawing.Point(62, 35);
            this.trackBarMinSup.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarMinSup.Maximum = 100;
            this.trackBarMinSup.Name = "trackBarMinSup";
            this.trackBarMinSup.Size = new System.Drawing.Size(707, 56);
            this.trackBarMinSup.TabIndex = 3;
            this.trackBarMinSup.Scroll += new System.EventHandler(this.trackBarMinSup_Scroll);
            // 
            // btnRefill
            // 
            this.btnRefill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefill.Location = new System.Drawing.Point(182, 119);
            this.btnRefill.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(148, 64);
            this.btnRefill.TabIndex = 2;
            this.btnRefill.Text = "Find D";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(333, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐỀ TÀI TÌM LUẬT MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // MASVCol
            // 
            this.MASVCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASVCol.HeaderText = "Mã SV";
            this.MASVCol.MinimumWidth = 6;
            this.MASVCol.Name = "MASVCol";
            // 
            // Key
            // 
            this.Key.HeaderText = "keyMH";
            this.Key.MinimumWidth = 6;
            this.Key.Name = "Key";
            this.Key.Width = 125;
            // 
            // MAMHCol
            // 
            this.MAMHCol.HeaderText = "Mã môn học";
            this.MAMHCol.MinimumWidth = 6;
            this.MAMHCol.Name = "MAMHCol";
            this.MAMHCol.Width = 125;
            // 
            // TENMHCol
            // 
            this.TENMHCol.HeaderText = "Tên môn học";
            this.TENMHCol.MinimumWidth = 6;
            this.TENMHCol.Name = "TENMHCol";
            this.TENMHCol.Width = 250;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).EndInit();
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
    }
}