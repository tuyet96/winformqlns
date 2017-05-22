namespace Khanh
{
    partial class Hopdong
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bắt Đầu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Kết thúc";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(123, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(108, 20);
            this.txtMa.TabIndex = 4;
            this.txtMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(123, 66);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(108, 20);
            this.txtTen.TabIndex = 7;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(402, 28);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBD.TabIndex = 8;
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Location = new System.Drawing.Point(402, 66);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerKT.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 197);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerKT);
            this.Controls.Add(this.dateTimePickerBD);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hopdong";
            this.Text = "Hopdong";
            this.Load += new System.EventHandler(this.Hopdong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}