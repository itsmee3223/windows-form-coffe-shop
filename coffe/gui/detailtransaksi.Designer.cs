namespace coffe.gui
{
    partial class detailtransaksi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridpembayaran = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.txt_hp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_databaru = new System.Windows.Forms.Button();
            this.btn_editdata = new System.Windows.Forms.Button();
            this.btn_hapusdata = new System.Windows.Forms.Button();
            this.btn_simpandata = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridpembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridpembayaran
            // 
            this.gridpembayaran.AllowUserToAddRows = false;
            this.gridpembayaran.AllowUserToDeleteRows = false;
            this.gridpembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpembayaran.Location = new System.Drawing.Point(3, 338);
            this.gridpembayaran.Name = "gridpembayaran";
            this.gridpembayaran.ReadOnly = true;
            this.gridpembayaran.Size = new System.Drawing.Size(614, 205);
            this.gridpembayaran.TabIndex = 24;
            this.gridpembayaran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridpembayaran_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cari Transaksi";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(128, 159);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(334, 20);
            this.txt_alamat.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID Transaksi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(124, 120);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(62, 19);
            this.lblTanggal.TabIndex = 33;
            this.lblTanggal.Text = "Tanggal: ";
            // 
            // txt_hp
            // 
            this.txt_hp.Location = new System.Drawing.Point(128, 194);
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.Size = new System.Drawing.Size(334, 20);
            this.txt_hp.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "No Handphone";
            // 
            // btn_databaru
            // 
            this.btn_databaru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_databaru.Location = new System.Drawing.Point(369, 227);
            this.btn_databaru.Name = "btn_databaru";
            this.btn_databaru.Size = new System.Drawing.Size(93, 57);
            this.btn_databaru.TabIndex = 39;
            this.btn_databaru.Text = "DATA BARU";
            this.btn_databaru.UseVisualStyleBackColor = true;
            this.btn_databaru.Click += new System.EventHandler(this.btn_databaru_Click);
            // 
            // btn_editdata
            // 
            this.btn_editdata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editdata.Location = new System.Drawing.Point(245, 227);
            this.btn_editdata.Name = "btn_editdata";
            this.btn_editdata.Size = new System.Drawing.Size(93, 57);
            this.btn_editdata.TabIndex = 38;
            this.btn_editdata.Text = "EDIT DATA";
            this.btn_editdata.UseVisualStyleBackColor = true;
            this.btn_editdata.Click += new System.EventHandler(this.btn_editdata_Click);
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapusdata.Location = new System.Drawing.Point(128, 227);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(93, 57);
            this.btn_hapusdata.TabIndex = 37;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            this.btn_hapusdata.Click += new System.EventHandler(this.btn_hapusdata_Click);
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpandata.Location = new System.Drawing.Point(3, 227);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(95, 57);
            this.btn_simpandata.TabIndex = 36;
            this.btn_simpandata.Text = "BAYAR";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            this.btn_simpandata.Click += new System.EventHandler(this.btn_simpandata_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Jalan Z.A. Pagar Alam , Bandar Lampung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 35);
            this.label7.TabIndex = 40;
            this.label7.Text = "Smart Cafe ";
            // 
            // detailtransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 555);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_databaru);
            this.Controls.Add(this.btn_editdata);
            this.Controls.Add(this.btn_hapusdata);
            this.Controls.Add(this.btn_simpandata);
            this.Controls.Add(this.txt_hp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridpembayaran);
            this.Controls.Add(this.textBox1);
            this.Name = "detailtransaksi";
            this.Text = "detailtransaksi";
            this.Load += new System.EventHandler(this.detailtransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridpembayaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gridpembayaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox txt_hp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_databaru;
        private System.Windows.Forms.Button btn_editdata;
        private System.Windows.Forms.Button btn_hapusdata;
        private System.Windows.Forms.Button btn_simpandata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}