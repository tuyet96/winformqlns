namespace Khanh
{
    partial class XemLuong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtLuongThuong = new System.Windows.Forms.TextBox();
            this.txtLuongcoban = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dgvXem = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(342, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lương Thưởng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(342, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương Cơ Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(38, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(153, 48);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 4;
            this.txtMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLuongThuong
            // 
            this.txtLuongThuong.Location = new System.Drawing.Point(473, 97);
            this.txtLuongThuong.Name = "txtLuongThuong";
            this.txtLuongThuong.Size = new System.Drawing.Size(100, 20);
            this.txtLuongThuong.TabIndex = 5;
            // 
            // txtLuongcoban
            // 
            this.txtLuongcoban.Location = new System.Drawing.Point(473, 48);
            this.txtLuongcoban.Name = "txtLuongcoban";
            this.txtLuongcoban.Size = new System.Drawing.Size(100, 20);
            this.txtLuongcoban.TabIndex = 6;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(153, 93);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 7;
            // 
            // dgvXem
            // 
            this.dgvXem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXem.Location = new System.Drawing.Point(12, 141);
            this.dgvXem.Name = "dgvXem";
            this.dgvXem.Size = new System.Drawing.Size(634, 204);
            this.dgvXem.TabIndex = 8;
            this.dgvXem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXem_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(229, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "DANH SÁCH LƯƠNG";
            // 
            // XemLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(658, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvXem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtLuongcoban);
            this.Controls.Add(this.txtLuongThuong);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XemLuong";
            this.Text = "XemLuong";
            this.Load += new System.EventHandler(this.XemLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtLuongThuong;
        private System.Windows.Forms.TextBox txtLuongcoban;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dgvXem;
        private System.Windows.Forms.Label label5;
    }
}