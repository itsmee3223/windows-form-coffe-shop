namespace coffe.gui
{
    partial class mastermenu
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
            this.txt_idmenu = new System.Windows.Forms.TextBox();
            this.txt_namamenu = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.btn_simpandata = new System.Windows.Forms.Button();
            this.btn_hapusdata = new System.Windows.Forms.Button();
            this.btn_editdata = new System.Windows.Forms.Button();
            this.datamenu = new System.Windows.Forms.DataGridView();
            this.btn_databaru = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datamenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID MENU ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA MENU ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HARGA ";
            // 
            // txt_idmenu
            // 
            this.txt_idmenu.Location = new System.Drawing.Point(151, 80);
            this.txt_idmenu.Name = "txt_idmenu";
            this.txt_idmenu.Size = new System.Drawing.Size(368, 20);
            this.txt_idmenu.TabIndex = 4;
            // 
            // txt_namamenu
            // 
            this.txt_namamenu.Location = new System.Drawing.Point(151, 116);
            this.txt_namamenu.Name = "txt_namamenu";
            this.txt_namamenu.Size = new System.Drawing.Size(368, 20);
            this.txt_namamenu.TabIndex = 5;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(151, 150);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(368, 20);
            this.txt_harga.TabIndex = 6;
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpandata.Location = new System.Drawing.Point(13, 197);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(98, 54);
            this.btn_simpandata.TabIndex = 8;
            this.btn_simpandata.Text = "SIMPAN DATA";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            this.btn_simpandata.Click += new System.EventHandler(this.btn_simpandata_Click);
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapusdata.Location = new System.Drawing.Point(151, 197);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(99, 54);
            this.btn_hapusdata.TabIndex = 9;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            this.btn_hapusdata.Click += new System.EventHandler(this.btn_hapusdata_Click);
            // 
            // btn_editdata
            // 
            this.btn_editdata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editdata.Location = new System.Drawing.Point(286, 197);
            this.btn_editdata.Name = "btn_editdata";
            this.btn_editdata.Size = new System.Drawing.Size(100, 54);
            this.btn_editdata.TabIndex = 10;
            this.btn_editdata.Text = "EDIT DATA";
            this.btn_editdata.UseVisualStyleBackColor = true;
            this.btn_editdata.Click += new System.EventHandler(this.btn_editdata_Click);
            // 
            // datamenu
            // 
            this.datamenu.AllowUserToAddRows = false;
            this.datamenu.AllowUserToDeleteRows = false;
            this.datamenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamenu.Location = new System.Drawing.Point(12, 269);
            this.datamenu.Name = "datamenu";
            this.datamenu.ReadOnly = true;
            this.datamenu.Size = new System.Drawing.Size(507, 185);
            this.datamenu.TabIndex = 11;
            this.datamenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamenu_CellClick);
            this.datamenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamenu_CellContentClick);
            // 
            // btn_databaru
            // 
            this.btn_databaru.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_databaru.Location = new System.Drawing.Point(419, 197);
            this.btn_databaru.Name = "btn_databaru";
            this.btn_databaru.Size = new System.Drawing.Size(100, 54);
            this.btn_databaru.TabIndex = 12;
            this.btn_databaru.Text = "DATA BARU";
            this.btn_databaru.UseVisualStyleBackColor = true;
            this.btn_databaru.Click += new System.EventHandler(this.btn_databaru_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Smart Cafe ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jalan Z.A. Pagar Alam , Bandar Lampung";
            // 
            // mastermenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_databaru);
            this.Controls.Add(this.datamenu);
            this.Controls.Add(this.btn_editdata);
            this.Controls.Add(this.btn_hapusdata);
            this.Controls.Add(this.btn_simpandata);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_namamenu);
            this.Controls.Add(this.txt_idmenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mastermenu";
            this.Text = "mastermenu";
            this.Load += new System.EventHandler(this.mastermenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idmenu;
        private System.Windows.Forms.TextBox txt_namamenu;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Button btn_simpandata;
        private System.Windows.Forms.Button btn_hapusdata;
        private System.Windows.Forms.Button btn_editdata;
        private System.Windows.Forms.DataGridView datamenu;
        private System.Windows.Forms.Button btn_databaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}