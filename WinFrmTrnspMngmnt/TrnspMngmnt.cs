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
using TrnspMngmntDataEF;
namespace WinFrmTrnspMngmnt
{
    public partial class TrnspMngmnt : Form
    {
        private TrnspMngmntDataEF.DBTransportManagementEntities ctx;
        private int tmp=0;

        public TrnspMngmnt()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ctx = new TrnspMngmntDataEF.DBTransportManagementEntities();
            ctx.CITIES.Load();
            this.cITyBindingSource.DataSource = ctx.CITIES.Local.ToBindingList();

            ctx.DEPARTURES.Load();
            this.dEPARTUREBindingSource.DataSource = ctx.DEPARTURES.Local.ToBindingList();

            ctx.CARGOS.Load();
            this.cARGOBindingSource.DataSource = ctx.CARGOS.Local.ToBindingList();

            ctx.TRUCKERS.Load();
            this.tRUCKERBindingSource.DataSource = ctx.TRUCKERS.Local.ToBindingList();

            ctx.TRUCKs.Load();
            this.tRUCKBindingSource.DataSource = ctx.TRUCKs.Local.ToBindingList();

            ctx.TRUCK_TYPES.Load();
            this.tRUCKTYPESBindingSource.DataSource = ctx.TRUCK_TYPES.Local.ToBindingList();

            ctx.TRAILERs.Load();
            this.tRAILERBindingSource.DataSource = ctx.TRAILERs.Local.ToBindingList();

            ctx.TRAILER_TYPES.Load();
            this.tRAILERTYPESBindingSource.DataSource = ctx.TRAILER_TYPES.Local.ToBindingList();
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }




        #region Save-Delete Buttons

        private void buttonDeleteCities_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.CITy city = (TrnspMngmntDataEF.CITy)dGVCities.CurrentRow.DataBoundItem;
                var b = (from c in ctx.DEPARTURES where c.DP_CITY == city.CITY_ID select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in departures ", "Deleting info about cities", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cITyBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }

        private void buttonSaveCities_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonSaveDepartures_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteDepartures_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.DEPARTURE depart = (TrnspMngmntDataEF.DEPARTURE)dGVDepartures.CurrentRow.DataBoundItem;
                var b = (from c in ctx.CARGOS where (c.CG_DESTINATION == depart.DP_ID) ||( c.CG_DEPARTURE_PLACE==depart.DP_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in cargos ", "Deleting info about departures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dEPARTUREBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }

        private void buttonSaveCargos_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteCargos_Click(object sender, EventArgs e)
        {
            cARGOBindingSource.RemoveCurrent();
        }

        private void buttonSaveTruckers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTruckers_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.TRUCKER trucker = (TrnspMngmntDataEF.TRUCKER)dGVTruckers.CurrentRow.DataBoundItem;
                var b = (from c in ctx.CARGOS where (c.CG_TRUCKER == trucker.TR_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in cargos ", "Deleting info about trucker", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   tRUCKERBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }

        private void buttonSaveTrucks_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTrucks_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.TRUCK truck = (TrnspMngmntDataEF.TRUCK)dGVTrucks.CurrentRow.DataBoundItem;
                var b = (from c in ctx.TRUCKERS where (c.TR_TRUCK == truck.TRUCK_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in truckers ", "Deleting info about truck", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tRUCKBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }

        private void buttonSaveTruckTypes_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTruckTypes_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.TRUCK_TYPES truck_type = (TrnspMngmntDataEF.TRUCK_TYPES)dGVTruckTypes.CurrentRow.DataBoundItem;
                var b = (from c in ctx.TRUCKs where (c.TRUCK_TYPE == truck_type.TYPE_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in trucks ", "Deleting info about truck type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tRUCKTYPESBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }

        private void buttonSaveTrailers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTrailers_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.TRAILER trailer = (TrnspMngmntDataEF.TRAILER)dGVTrailers.CurrentRow.DataBoundItem;
                var b = (from c in ctx.TRUCKs where (c.TRUCK_TRAILER == trailer.TRAILER_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in truck ", "Deleting info about trailers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tRAILERBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }

        private void buttonSaveTrailerType_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTrailerType_Click(object sender, EventArgs e)
        {
            try
            {
                TrnspMngmntDataEF.TRAILER_TYPES trailer_type= (TrnspMngmntDataEF.TRAILER_TYPES)dGVTrailerTypes.CurrentRow.DataBoundItem;
                var b = (from c in ctx.TRAILERs where (c.TRAILER_TYPE == trailer_type.TYPE_TR_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Deleting error! There is a reference in trailer ", "Deleting info about trailer types", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tRAILERTYPESBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Deleting error!");
                throw;
            }
        }
#endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FrmCargoSearch frmCargoSearch = new FrmCargoSearch();
            frmCargoSearch.ShowDialog();
            frmCargoSearch.Dispose();
        }

        
        private void dGVCargos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int temp;
            if(e.ColumnIndex==0||e.ColumnIndex==6)
            {
                if(!int.TryParse(e.FormattedValue.ToString(),out temp))
                {
                    MessageBox.Show("CAUTION you've entered incorrect value");
                    dGVCargos.CurrentCell.Value = tmp;
                }
            }

        }

        private void dGVCargos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex==0||e.ColumnIndex==6)
            {
                if(dGVCargos.CurrentCell.Value!=null)
                {
                    int.TryParse(dGVCargos.CurrentCell.Value.ToString(), out tmp);
                }
            }
        }

       
    }
}
