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
    public partial class FrmCargoSearch : Form
    {
        public FrmCargoSearch()
        {
            InitializeComponent();
        }

        private void fillBindingSourse()
        {
            var ctx = new TrnspMngmntDataEF.DBTransportManagementEntities();


            


            var query = from cargo in ctx.CARGOS

                        join dest in ctx.DEPARTURES on cargo.CG_DESTINATION equals dest.DP_ID
                        join deprt in ctx.DEPARTURES on cargo.CG_DEPARTURE_PLACE equals deprt.DP_ID
                        join destCity in ctx.CITIES on dest.DP_CITY equals destCity.CITY_ID
                        join deprtCity in ctx.CITIES on deprt.DP_CITY equals deprtCity.CITY_ID 
                        
                        select new
                        {
                            DepartureDate = cargo.CG_DEPARTURE_DATE,
                            DepartureTime = cargo.CG_DEPARTURE_TIME,
                            DepartureCity = deprtCity.CITY_NAME,
                            DepartureAdress = deprt.DP_ADRESS,
                            Weight = cargo.CG_WEIGHT,
                            DestinationCity = destCity.CITY_NAME,
                            DestinationAdress = dest.DP_ADRESS,
                            DestinationDate = cargo.CG_ARRIVAL_DATE,
                            DestinationTime = cargo.CG_ARRIVAL_TIME,

                        };

            foreach ( var item in query)
            {
                
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var ctx = new TrnspMngmntDataEF.DBTransportManagementEntities();

            var query = from cargo in ctx.CARGOS
                        join dest in ctx.DEPARTURES on cargo.CG_DESTINATION equals dest.DP_ID
                        join deprt in ctx.DEPARTURES on cargo.CG_DEPARTURE_PLACE equals deprt.DP_ID
                        join destCity in ctx.CITIES on dest.DP_CITY equals destCity.CITY_ID
                        join deprtCity in ctx.CITIES on deprt.DP_CITY equals deprtCity.CITY_ID
                        select new
                        {
                            DepartureDate = cargo.CG_DEPARTURE_DATE,
                            DepartureTime = cargo.CG_DEPARTURE_TIME,
                            DepartureCity = deprtCity.CITY_NAME,
                            DepartureAdress = deprt.DP_ADRESS,
                            Weight = cargo.CG_WEIGHT,
                            DestinationCity = destCity.CITY_NAME,
                            DestinationAdress = dest.DP_ADRESS,
                            DestinationDate = cargo.CG_ARRIVAL_DATE,
                            DestinationTime = cargo.CG_ARRIVAL_TIME,
                            
                        };
            
            
            
            foreach(var item in query)
            {
                cargoSearchBindingSource.Add(new TrnspMngmntDataEF.CargoSearch(item.DepartureDate, item.DestinationDate, item.DepartureTime,
                    item.DestinationTime, item.DestinationCity, item.DepartureCity, item.DestinationAdress, item.DepartureAdress,item.Weight));
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            fillBindingSourse();
        }
    }
}

