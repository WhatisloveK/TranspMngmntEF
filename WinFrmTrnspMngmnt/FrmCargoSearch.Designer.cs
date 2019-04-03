namespace WinFrmTrnspMngmnt
{
    partial class FrmCargoSearch
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cargoSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoSearchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureDateDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.departureCityDataGridViewTextBoxColumn,
            this.departureAdressDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.destinationDateDataGridViewTextBoxColumn,
            this.destinationCityDataGridViewTextBoxColumn,
            this.destinationAdressDataGridViewTextBoxColumn,
            this.destinationTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cargoSearchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // cargoSearchBindingSource
            // 
            this.cargoSearchBindingSource.DataSource = typeof(TrnspMngmntDataEF.CargoSearch);
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            // 
            // departureCityDataGridViewTextBoxColumn
            // 
            this.departureCityDataGridViewTextBoxColumn.DataPropertyName = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.HeaderText = "DepartureCity";
            this.departureCityDataGridViewTextBoxColumn.Name = "departureCityDataGridViewTextBoxColumn";
            // 
            // departureAdressDataGridViewTextBoxColumn
            // 
            this.departureAdressDataGridViewTextBoxColumn.DataPropertyName = "DepartureAdress";
            this.departureAdressDataGridViewTextBoxColumn.HeaderText = "DepartureAdress";
            this.departureAdressDataGridViewTextBoxColumn.Name = "departureAdressDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // destinationDateDataGridViewTextBoxColumn
            // 
            this.destinationDateDataGridViewTextBoxColumn.DataPropertyName = "DestinationDate";
            this.destinationDateDataGridViewTextBoxColumn.HeaderText = "DestinationDate";
            this.destinationDateDataGridViewTextBoxColumn.Name = "destinationDateDataGridViewTextBoxColumn";
            // 
            // destinationCityDataGridViewTextBoxColumn
            // 
            this.destinationCityDataGridViewTextBoxColumn.DataPropertyName = "DestinationCity";
            this.destinationCityDataGridViewTextBoxColumn.HeaderText = "DestinationCity";
            this.destinationCityDataGridViewTextBoxColumn.Name = "destinationCityDataGridViewTextBoxColumn";
            // 
            // destinationAdressDataGridViewTextBoxColumn
            // 
            this.destinationAdressDataGridViewTextBoxColumn.DataPropertyName = "DestinationAdress";
            this.destinationAdressDataGridViewTextBoxColumn.HeaderText = "DestinationAdress";
            this.destinationAdressDataGridViewTextBoxColumn.Name = "destinationAdressDataGridViewTextBoxColumn";
            // 
            // destinationTimeDataGridViewTextBoxColumn
            // 
            this.destinationTimeDataGridViewTextBoxColumn.DataPropertyName = "DestinationTime";
            this.destinationTimeDataGridViewTextBoxColumn.HeaderText = "DestinationTime";
            this.destinationTimeDataGridViewTextBoxColumn.Name = "destinationTimeDataGridViewTextBoxColumn";
            // 
            // FrmCargoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCargoSearch";
            this.Text = "CargoSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoSearchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cargoSearchBindingSource;
    }
}