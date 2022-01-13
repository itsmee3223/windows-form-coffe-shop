using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;



namespace coffe.gui
{
    public partial class menuutama : Form
    {
        public menuutama()
        {
            InitializeComponent();
        }

        private void mastermenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mastermenu x = new mastermenu();
            x.MdiParent = this;
            x.Show();
        }

        private void masterpembeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masterpembeli y = new masterpembeli();
            y.MdiParent = this;
            y.Show();
        }


        private void menuutama_Load(object sender, EventArgs e)
        {

        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailtransaksi a = new detailtransaksi();
            a.MdiParent = this;
            a.Show();
        }

        private void mastertransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gui.mastertransaksi trx = new gui.mastertransaksi();
            trx.MdiParent = this;
            trx.Show();
        }
    }
}
