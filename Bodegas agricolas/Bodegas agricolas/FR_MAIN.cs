using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodegas_agricolas
{
    public partial class FR_MAIN : Form
    {
        public FR_MAIN()
        {
            InitializeComponent();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_COMPRAS fr = new FR_COMPRAS();
            fr.Show();

        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_MCOMPRAS fr = new FR_MCOMPRAS();
            fr.Show();
        }
    }
}
