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
            ((System.ComponentModel.ISupportInitialize)(this.datamenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID MENU :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA MENU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HARGA :";
            // 
            // txt_idmenu
            // 
            this.txt_idmenu.Location = new System.Drawing.Point(152, 36);
            this.txt_idmenu.Name = "txt_idmenu";
            this.txt_idmenu.Size = new System.Drawing.Size(78, 20);
            this.txt_idmenu.TabIndex = 4;
            // 
            // txt_namamenu
            // 
            this.txt_namamenu.Location = new System.Drawing.Point(152, 72);
            this.txt_namamenu.Name = "txt_namamenu";
            this.txt_namamenu.Size = new System.Drawing.Size(184, 20);
            this.txt_namamenu.TabIndex = 5;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(152, 106);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(118, 20);
            this.txt_harga.TabIndex = 6;
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Location = new System.Drawing.Point(23, 193);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(93, 32);
            this.btn_simpandata.TabIndex = 8;
            this.btn_simpandata.Text = "SIMPAN DATA";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            this.btn_simpandata.Click += new System.EventHandler(this.btn_simpandata_Click);
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Location = new System.Drawing.Point(137, 194);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(93, 27);
            this.btn_hapusdata.TabIndex = 9;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            this.btn_hapusdata.Click += new System.EventHandler(this.btn_hapusdata_Click);
            // 
            // btn_editdata
            // 
            this.btn_editdata.Location = new System.Drawing.Point(247, 194);
            this.btn_editdata.Name = "btn_editdata";
            this.btn_editdata.Size = new System.Drawing.Size(89, 27);
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
            this.datamenu.Location = new System.Drawing.Point(18, 245);
            this.datamenu.Name = "datamenu";
            this.datamenu.ReadOnly = true;
            this.datamenu.Size = new System.Drawing.Size(427, 110);
            this.datamenu.TabIndex = 11;
            this.datamenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamenu_CellClick);
            this.datamenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datamenu_CellContentClick);
            // 
            // btn_databaru
            // 
            this.btn_databaru.Location = new System.Drawing.Point(351, 192);
            this.btn_databaru.Name = "btn_databaru";
            this.btn_databaru.Size = new System.Drawing.Size(88, 30);
            this.btn_databaru.TabIndex = 12;
            this.btn_databaru.Text = "DATA BARU";
            this.btn_databaru.UseVisualStyleBackColor = true;
            this.btn_databaru.Click += new System.EventHandler(this.btn_databaru_Click);
            // 
            // mastermenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 374);
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
    }
}