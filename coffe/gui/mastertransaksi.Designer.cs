namespace coffe.gui
{
    partial class mastertransaksi
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
            this.gridtransaksi = new System.Windows.Forms.DataGridView();
            this.btn_hapusdata = new System.Windows.Forms.Button();
            this.btn_simpandata = new System.Windows.Forms.Button();
            this.txt_idtransaksi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtNamaPb = new System.Windows.Forms.TextBox();
            this.pembeliiii = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.menuuu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridtransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridtransaksi
            // 
            this.gridtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtransaksi.Location = new System.Drawing.Point(18, 379);
            this.gridtransaksi.Name = "gridtransaksi";
            this.gridtransaksi.Size = new System.Drawing.Size(432, 149);
            this.gridtransaksi.TabIndex = 23;
            this.gridtransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtransaksi_CellClick);
            this.gridtransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridtransaksi_CellContentClick);
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapusdata.Location = new System.Drawing.Point(284, 313);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(116, 46);
            this.btn_hapusdata.TabIndex = 21;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            this.btn_hapusdata.Click += new System.EventHandler(this.btn_hapusdata_Click);
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpandata.Location = new System.Drawing.Point(44, 313);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(107, 46);
            this.btn_simpandata.TabIndex = 20;
            this.btn_simpandata.Text = "SIMPAN DATA";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            this.btn_simpandata.Click += new System.EventHandler(this.btn_simpandata_Click);
            // 
            // txt_idtransaksi
            // 
            this.txt_idtransaksi.Location = new System.Drawing.Point(145, 250);
            this.txt_idtransaksi.Name = "txt_idtransaksi";
            this.txt_idtransaksi.Size = new System.Drawing.Size(305, 20);
            this.txt_idtransaksi.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Transaksi ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Pembeli ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.DropDownClosed += new System.EventHandler(this.comboBox2_DropDownClosed);
            // 
            // txtNamaPb
            // 
            this.txtNamaPb.Location = new System.Drawing.Point(145, 179);
            this.txtNamaPb.Name = "txtNamaPb";
            this.txtNamaPb.Size = new System.Drawing.Size(305, 20);
            this.txtNamaPb.TabIndex = 29;
            // 
            // pembeliiii
            // 
            this.pembeliiii.AutoSize = true;
            this.pembeliiii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembeliiii.Location = new System.Drawing.Point(27, 180);
            this.pembeliiii.Name = "pembeliiii";
            this.pembeliiii.Size = new System.Drawing.Size(98, 19);
            this.pembeliiii.TabIndex = 28;
            this.pembeliiii.Text = "Nama Pembeli";
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(145, 215);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(305, 20);
            this.txtMenu.TabIndex = 31;
            // 
            // menuuu
            // 
            this.menuuu.AutoSize = true;
            this.menuuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuuu.Location = new System.Drawing.Point(26, 216);
            this.menuuu.Name = "menuuu";
            this.menuuu.Size = new System.Drawing.Size(85, 19);
            this.menuuu.TabIndex = 30;
            this.menuuu.Text = "Nama Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Jalan Z.A. Pagar Alam , Bandar Lampung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.TabIndex = 32;
            this.label3.Text = "Smart Cafe ";
            // 
            // mastertransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.menuuu);
            this.Controls.Add(this.txtNamaPb);
            this.Controls.Add(this.pembeliiii);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gridtransaksi);
            this.Controls.Add(this.btn_hapusdata);
            this.Controls.Add(this.btn_simpandata);
            this.Controls.Add(this.txt_idtransaksi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mastertransaksi";
            this.Text = "Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.gridtransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView gridtransaksi;
        private System.Windows.Forms.Button btn_hapusdata;
        private System.Windows.Forms.Button btn_simpandata;
        private System.Windows.Forms.TextBox txt_idtransaksi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtNamaPb;
        private System.Windows.Forms.Label pembeliiii;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label menuuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}