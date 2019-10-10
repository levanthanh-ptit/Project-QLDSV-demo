namespace Project_QLDSV
{
    partial class Form1
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
            this.MAMHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewGiaotac = new System.Windows.Forms.DataGridView();
            this.MASVCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarMinSup = new System.Windows.Forms.TrackBar();
            this.labelMinSup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMHCol,
            this.TENMHCol});
            this.dataGridViewMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(394, 219);
            this.dataGridViewMonHoc.TabIndex = 0;
            // 
            // MAMHCol
            // 
            this.MAMHCol.HeaderText = "Mã môn học";
            this.MAMHCol.Name = "MAMHCol";
            // 
            // TENMHCol
            // 
            this.TENMHCol.HeaderText = "Tên môn học";
            this.TENMHCol.Name = "TENMHCol";
            this.TENMHCol.Width = 300;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMonHoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewGiaotac, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewGiaotac
            // 
            this.dataGridViewGiaotac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiaotac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASVCol});
            this.dataGridViewGiaotac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGiaotac.Location = new System.Drawing.Point(403, 3);
            this.dataGridViewGiaotac.Name = "dataGridViewGiaotac";
            this.dataGridViewGiaotac.Size = new System.Drawing.Size(394, 219);
            this.dataGridViewGiaotac.TabIndex = 1;
            // 
            // MASVCol
            // 
            this.MASVCol.HeaderText = "Mã SV";
            this.MASVCol.Name = "MASVCol";
            // 
            // btnRefill
            // 
            this.btnRefill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefill.Location = new System.Drawing.Point(307, 3);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(84, 39);
            this.btnRefill.TabIndex = 2;
            this.btnRefill.Text = "Cal";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMinSup);
            this.panel1.Controls.Add(this.trackBarMinSup);
            this.panel1.Controls.Add(this.btnRefill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(403, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 219);
            this.panel1.TabIndex = 3;
            // 
            // trackBarMinSup
            // 
            this.trackBarMinSup.Location = new System.Drawing.Point(3, 3);
            this.trackBarMinSup.Maximum = 100;
            this.trackBarMinSup.Name = "trackBarMinSup";
            this.trackBarMinSup.Size = new System.Drawing.Size(256, 45);
            this.trackBarMinSup.TabIndex = 3;
            this.trackBarMinSup.Scroll += new System.EventHandler(this.trackBarMinSup_Scroll);
            // 
            // labelMinSup
            // 
            this.labelMinSup.AutoSize = true;
            this.labelMinSup.Location = new System.Drawing.Point(265, 16);
            this.labelMinSup.Name = "labelMinSup";
            this.labelMinSup.Size = new System.Drawing.Size(15, 13);
            this.labelMinSup.TabIndex = 4;
            this.labelMinSup.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiaotac)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMHCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMHCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewGiaotac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASVCol;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarMinSup;
        private System.Windows.Forms.Label labelMinSup;
    }
}