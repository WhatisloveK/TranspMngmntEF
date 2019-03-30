using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WinFrmTrnspMngmnt
{
    public partial class Form1 : Form
    {
        private TrnspMngmntDataEF.DBTransportManagementEntities ctx;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ctx = new TrnspMngmntDataEF.DBTransportManagementEntities();
            ctx.CITIES.Load();
            this.cITyBindingSource.DataSource = ctx.CITIES.Local.ToBindingList();

            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void buttonCitiesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception)
            {

            }
        }

        private void buttonCitiesSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
