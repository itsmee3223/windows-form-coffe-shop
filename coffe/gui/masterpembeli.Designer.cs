namespace coffe.gui
{
    partial class masterpembeli
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
            this.gridpembeli = new System.Windows.Forms.DataGridView();
            this.btn_editdata = new System.Windows.Forms.Button();
            this.btn_hapusdata = new System.Windows.Forms.Button();
            this.btn_simpandata = new System.Windows.Forms.Button();
            this.txt_namapembeli = new System.Windows.Forms.TextBox();
            this.txt_idpembeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridpembeli)).BeginInit();
            this.SuspendLayout();
            // 
            // gridpembeli
            // 
            this.gridpembeli.AllowUserToAddRows = false;
            this.gridpembeli.AllowUserToDeleteRows = false;
            this.gridpembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpembeli.Location = new System.Drawing.Point(-2, 241);
            this.gridpembeli.Name = "gridpembeli";
            this.gridpembeli.ReadOnly = true;
            this.gridpembeli.Size = new System.Drawing.Size(400, 226);
            this.gridpembeli.TabIndex = 23;
            this.gridpembeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridpembeli_CellClick);
            // 
            // btn_editdata
            // 
            this.btn_editdata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editdata.Location = new System.Drawing.Point(286, 177);
            this.btn_editdata.Name = "btn_editdata";
            this.btn_editdata.Size = new System.Drawing.Size(112, 46);
            this.btn_editdata.TabIndex = 22;
            this.btn_editdata.Text = "EDIT DATA";
            this.btn_editdata.UseVisualStyleBackColor = true;
            this.btn_editdata.Click += new System.EventHandler(this.btn_editdata_Click);
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapusdata.Location = new System.Drawing.Point(144, 177);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(112, 46);
            this.btn_hapusdata.TabIndex = 21;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            this.btn_hapusdata.Click += new System.EventHandler(this.btn_hapusdata_Click);
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpandata.Location = new System.Drawing.Point(7, 177);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(107, 46);
            this.btn_simpandata.TabIndex = 20;
            this.btn_simpandata.Text = "SIMPAN DATA";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            this.btn_simpandata.Click += new System.EventHandler(this.btn_simpandata_Click);
            // 
            // txt_namapembeli
            // 
            this.txt_namapembeli.Location = new System.Drawing.Point(144, 122);
            this.txt_namapembeli.Name = "txt_namapembeli";
            this.txt_namapembeli.Size = new System.Drawing.Size(254, 20);
            this.txt_namapembeli.TabIndex = 17;
            // 
            // txt_idpembeli
            // 
            this.txt_idpembeli.Location = new System.Drawing.Point(144, 92);
            this.txt_idpembeli.Name = "txt_idpembeli";
            this.txt_idpembeli.Size = new System.Drawing.Size(134, 20);
            this.txt_idpembeli.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Pembeli ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Pembeli ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Jalan Z.A. Pagar Alam , Bandar Lampung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 35);
            this.label4.TabIndex = 24;
            this.label4.Text = "Smart Cafe ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // masterpembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 472);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridpembeli);
            this.Controls.Add(this.btn_editdata);
            this.Controls.Add(this.btn_hapusdata);
            this.Controls.Add(this.btn_simpandata);
            this.Controls.Add(this.txt_namapembeli);
            this.Controls.Add(this.txt_idpembeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "masterpembeli";
            this.Text = "masterpembeli";
            ((System.ComponentModel.ISupportInitialize)(this.gridpembeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridpembeli;
        private System.Windows.Forms.Button btn_editdata;
        private System.Windows.Forms.Button btn_hapusdata;
        private System.Windows.Forms.Button btn_simpandata;
        private System.Windows.Forms.TextBox txt_namapembeli;
        private System.Windows.Forms.TextBox txt_idpembeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}