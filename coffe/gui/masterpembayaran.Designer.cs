namespace coffe.gui
{
    partial class masterpembayaran
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
            this.gridpembayaran = new System.Windows.Forms.DataGridView();
            this.btn_editdata = new System.Windows.Forms.Button();
            this.btn_hapusdata = new System.Windows.Forms.Button();
            this.btn_simpandata = new System.Windows.Forms.Button();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_namamenu = new System.Windows.Forms.TextBox();
            this.txt_idmenu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridpembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // gridpembayaran
            // 
            this.gridpembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpembayaran.Location = new System.Drawing.Point(101, 271);
            this.gridpembayaran.Name = "gridpembayaran";
            this.gridpembayaran.Size = new System.Drawing.Size(427, 101);
            this.gridpembayaran.TabIndex = 23;
            // 
            // btn_editdata
            // 
            this.btn_editdata.Location = new System.Drawing.Point(377, 215);
            this.btn_editdata.Name = "btn_editdata";
            this.btn_editdata.Size = new System.Drawing.Size(112, 37);
            this.btn_editdata.TabIndex = 22;
            this.btn_editdata.Text = "EDIT DATA";
            this.btn_editdata.UseVisualStyleBackColor = true;
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Location = new System.Drawing.Point(231, 218);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(112, 29);
            this.btn_hapusdata.TabIndex = 21;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Location = new System.Drawing.Point(101, 214);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(107, 34);
            this.btn_simpandata.TabIndex = 20;
            this.btn_simpandata.Text = "SIMPAN DATA";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(241, 162);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(287, 20);
            this.txt_jumlah.TabIndex = 19;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(241, 129);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(287, 20);
            this.txt_harga.TabIndex = 18;
            // 
            // txt_namamenu
            // 
            this.txt_namamenu.Location = new System.Drawing.Point(241, 87);
            this.txt_namamenu.Name = "txt_namamenu";
            this.txt_namamenu.Size = new System.Drawing.Size(287, 20);
            this.txt_namamenu.TabIndex = 17;
            // 
            // txt_idmenu
            // 
            this.txt_idmenu.Location = new System.Drawing.Point(241, 50);
            this.txt_idmenu.Name = "txt_idmenu";
            this.txt_idmenu.Size = new System.Drawing.Size(287, 20);
            this.txt_idmenu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "JUMLAH : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "HARGA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NAMA MENU :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID MENU :";
            // 
            // masterpembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 423);
            this.Controls.Add(this.gridpembayaran);
            this.Controls.Add(this.btn_editdata);
            this.Controls.Add(this.btn_hapusdata);
            this.Controls.Add(this.btn_simpandata);
            this.Controls.Add(this.txt_jumlah);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_namamenu);
            this.Controls.Add(this.txt_idmenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "masterpembayaran";
            this.Text = "masterpembayaran";
            ((System.ComponentModel.ISupportInitialize)(this.gridpembayaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridpembayaran;
        private System.Windows.Forms.Button btn_editdata;
        private System.Windows.Forms.Button btn_hapusdata;
        private System.Windows.Forms.Button btn_simpandata;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_namamenu;
        private System.Windows.Forms.TextBox txt_idmenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}