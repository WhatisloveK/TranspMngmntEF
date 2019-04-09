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


            string depart_city = textBoxDprtCity.Text;
            string dest_city = textBoxDestCity.Text;
            string departureAdress = textBoxDprtAdress.Text;
            string destinationAdress = textBoxDestAdress.Text;
            int weight = (int)numericUpDownWeight.Value;
            string depart_day = dateTimePickerDeprt.Value.ToString("yyyy-MM-dd");
            string dest_day = dateTimePickerDest.Value.ToString("yyyy-MM-dd");

            string depart_time = dateTimePickerDeprtTime.Value.TimeOfDay.ToString();
            string dest_time = dateTimePickerDestTime.Value.TimeOfDay.ToString();
            
            if (!checkBoxDeprtDay.Checked)
                depart_day = "";
            if (!checkBoxDestDay.Checked)
                dest_day = "";
            if (!checkBoxDeprtTime.Checked)
                depart_time = "";
            if (!checkBoxDestTime.Checked)
                dest_time = "";
          


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
                            DestinationTime = cargo.CG_ARRIVAL_TIME
                            
                        };
            

            query = query.Where(n => (n.DepartureAdress == departureAdress || departureAdress == "") && (n.DestinationCity == dest_city ||dest_city == "")
             && (n.DepartureCity == depart_city||depart_city=="") &&(n.DestinationAdress==destinationAdress||destinationAdress=="")&&(n.Weight==weight||weight==0)
             && (n.DepartureDate.ToString()==depart_day||depart_day=="")&&(n.DestinationDate.ToString()==dest_day||dest_day=="")
             &&(n.DepartureTime.ToString()==depart_time||depart_time=="")&&(n.DestinationTime.ToString()==dest_time||dest_time==""));

            cargoSearchBindingSource.Clear();
            foreach ( var item in query)
            {
                cargoSearchBindingSource.Add(new TrnspMngmntDataEF.CargoSearch(item.DepartureDate, item.DestinationDate, item.DepartureTime,
                    item.DestinationTime, item.DestinationCity, item.DepartureCity, item.DestinationAdress, item.DepartureAdress, item.Weight));
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            fillBindingSourse();
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            fillBindingSourse();
        }

      
    }
}

