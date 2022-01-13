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
            ((System.ComponentModel.ISupportInitialize)(this.gridpembeli)).BeginInit();
            this.SuspendLayout();
            // 
            // gridpembeli
            // 
            this.gridpembeli.AllowUserToAddRows = false;
            this.gridpembeli.AllowUserToDeleteRows = false;
            this.gridpembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpembeli.Location = new System.Drawing.Point(15, 241);
            this.gridpembeli.Name = "gridpembeli";
            this.gridpembeli.ReadOnly = true;
            this.gridpembeli.Size = new System.Drawing.Size(427, 101);
            this.gridpembeli.TabIndex = 23;
            this.gridpembeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridpembeli_CellClick);
            // 
            // btn_editdata
            // 
            this.btn_editdata.Location = new System.Drawing.Point(303, 131);
            this.btn_editdata.Name = "btn_editdata";
            this.btn_editdata.Size = new System.Drawing.Size(112, 29);
            this.btn_editdata.TabIndex = 22;
            this.btn_editdata.Text = "EDIT DATA";
            this.btn_editdata.UseVisualStyleBackColor = true;
            this.btn_editdata.Click += new System.EventHandler(this.btn_editdata_Click);
            // 
            // btn_hapusdata
            // 
            this.btn_hapusdata.Location = new System.Drawing.Point(160, 131);
            this.btn_hapusdata.Name = "btn_hapusdata";
            this.btn_hapusdata.Size = new System.Drawing.Size(112, 29);
            this.btn_hapusdata.TabIndex = 21;
            this.btn_hapusdata.Text = "HAPUS DATA";
            this.btn_hapusdata.UseVisualStyleBackColor = true;
            this.btn_hapusdata.Click += new System.EventHandler(this.btn_hapusdata_Click);
            // 
            // btn_simpandata
            // 
            this.btn_simpandata.Location = new System.Drawing.Point(30, 132);
            this.btn_simpandata.Name = "btn_simpandata";
            this.btn_simpandata.Size = new System.Drawing.Size(107, 28);
            this.btn_simpandata.TabIndex = 20;
            this.btn_simpandata.Text = "SIMPAN DATA";
            this.btn_simpandata.UseVisualStyleBackColor = true;
            this.btn_simpandata.Click += new System.EventHandler(this.btn_simpandata_Click);
            // 
            // txt_namapembeli
            // 
            this.txt_namapembeli.Location = new System.Drawing.Point(155, 57);
            this.txt_namapembeli.Name = "txt_namapembeli";
            this.txt_namapembeli.Size = new System.Drawing.Size(287, 20);
            this.txt_namapembeli.TabIndex = 17;
            // 
            // txt_idpembeli
            // 
            this.txt_idpembeli.Location = new System.Drawing.Point(155, 20);
            this.txt_idpembeli.Name = "txt_idpembeli";
            this.txt_idpembeli.Size = new System.Drawing.Size(134, 20);
            this.txt_idpembeli.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama Pembeli :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Pembeli :";
            // 
            // masterpembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 362);
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

    }
}