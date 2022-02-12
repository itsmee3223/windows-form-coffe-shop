namespace coffe.gui
{
    partial class menuutama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mastermenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterpembeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mastertransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuutama";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastermenuToolStripMenuItem,
            this.masterpembeliToolStripMenuItem,
            this.mastertransaksiToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // mastermenuToolStripMenuItem
            // 
            this.mastermenuToolStripMenuItem.Name = "mastermenuToolStripMenuItem";
            this.mastermenuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mastermenuToolStripMenuItem.Text = "mastermenu";
            this.mastermenuToolStripMenuItem.Click += new System.EventHandler(this.mastermenuToolStripMenuItem_Click);
            // 
            // masterpembeliToolStripMenuItem
            // 
            this.masterpembeliToolStripMenuItem.Name = "masterpembeliToolStripMenuItem";
            this.masterpembeliToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.masterpembeliToolStripMenuItem.Text = "masterpembeli";
            this.masterpembeliToolStripMenuItem.Click += new System.EventHandler(this.masterpembeliToolStripMenuItem_Click);
            // 
            // mastertransaksiToolStripMenuItem
            // 
            this.mastertransaksiToolStripMenuItem.Name = "mastertransaksiToolStripMenuItem";
            this.mastertransaksiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mastertransaksiToolStripMenuItem.Text = "mastertransaksi";
            this.mastertransaksiToolStripMenuItem.Click += new System.EventHandler(this.mastertransaksiToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // menuutama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::coffe.Properties.Resources.undraw_Coffee_re_x35h;
            this.ClientSize = new System.Drawing.Size(553, 550);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuutama";
            this.Text = "menuutama";
            this.Load += new System.EventHandler(this.menuutama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mastermenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterpembeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mastertransaksiToolStripMenuItem;
    }
}