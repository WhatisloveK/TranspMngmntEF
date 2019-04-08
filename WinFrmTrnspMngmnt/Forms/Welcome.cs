using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmTrnspMngmnt
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void cirularButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrnspMngmnt frmTrnspMng = new TrnspMngmnt();
            frmTrnspMng.ShowDialog();

            this.Close();
        }
    }
}
