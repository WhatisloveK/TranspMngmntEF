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
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDprtCity = new System.Windows.Forms.TextBox();
            this.textBoxDestCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDprtAdress = new System.Windows.Forms.TextBox();
            this.textBoxDestAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxDeprtDay = new System.Windows.Forms.CheckBox();
            this.checkBoxDestDay = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDeprt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDest = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDeprtTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDestTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDeprtTime = new System.Windows.Forms.CheckBox();
            this.checkBoxDestTime = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 312);
            this.dataGridView1.TabIndex = 0;
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
            // cargoSearchBindingSource
            // 
            this.cargoSearchBindingSource.DataSource = typeof(TrnspMngmntDataEF.CargoSearch);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departure city";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination city";
            // 
            // textBoxDprtCity
            // 
            this.textBoxDprtCity.Location = new System.Drawing.Point(97, 22);
            this.textBoxDprtCity.Name = "textBoxDprtCity";
            this.textBoxDprtCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxDprtCity.TabIndex = 3;
            // 
            // textBoxDestCity
            // 
            this.textBoxDestCity.Location = new System.Drawing.Point(97, 64);
            this.textBoxDestCity.Name = "textBoxDestCity";
            this.textBoxDestCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departure adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination adress";
            // 
            // textBoxDprtAdress
            // 
            this.textBoxDprtAdress.Location = new System.Drawing.Point(310, 22);
            this.textBoxDprtAdress.Name = "textBoxDprtAdress";
            this.textBoxDprtAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxDprtAdress.TabIndex = 7;
            // 
            // textBoxDestAdress
            // 
            this.textBoxDestAdress.Location = new System.Drawing.Point(310, 64);
            this.textBoxDestAdress.Name = "textBoxDestAdress";
            this.textBoxDestAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestAdress.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Departure day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Destination day";
            // 
            // checkBoxDeprtDay
            // 
            this.checkBoxDeprtDay.AutoSize = true;
            this.checkBoxDeprtDay.Location = new System.Drawing.Point(506, 25);
            this.checkBoxDeprtDay.Name = "checkBoxDeprtDay";
            this.checkBoxDeprtDay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDeprtDay.TabIndex = 11;
            this.checkBoxDeprtDay.UseVisualStyleBackColor = true;
            // 
            // checkBoxDestDay
            // 
            this.checkBoxDestDay.AutoSize = true;
            this.checkBoxDestDay.Location = new System.Drawing.Point(506, 68);
            this.checkBoxDestDay.Name = "checkBoxDestDay";
            this.checkBoxDestDay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDestDay.TabIndex = 12;
            this.checkBoxDestDay.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDeprt
            // 
            this.dateTimePickerDeprt.Location = new System.Drawing.Point(527, 22);
            this.dateTimePickerDeprt.Name = "dateTimePickerDeprt";
            this.dateTimePickerDeprt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeprt.TabIndex = 13;
            // 
            // dateTimePickerDest
            // 
            this.dateTimePickerDest.Location = new System.Drawing.Point(527, 64);
            this.dateTimePickerDest.Name = "dateTimePickerDest";
            this.dateTimePickerDest.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDest.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(733, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Departure time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(733, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Destination time";
            // 
            // dateTimePickerDeprtTime
            // 
            this.dateTimePickerDeprtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDeprtTime.Location = new System.Drawing.Point(842, 22);
            this.dateTimePickerDeprtTime.Name = "dateTimePickerDeprtTime";
            this.dateTimePickerDeprtTime.ShowUpDown = true;
            this.dateTimePickerDeprtTime.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerDeprtTime.TabIndex = 17;
            this.dateTimePickerDeprtTime.Value = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            // 
            // dateTimePickerDestTime
            // 
            this.dateTimePickerDestTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDestTime.Location = new System.Drawing.Point(842, 64);
            this.dateTimePickerDestTime.Name = "dateTimePickerDestTime";
            this.dateTimePickerDestTime.ShowUpDown = true;
            this.dateTimePickerDestTime.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerDestTime.TabIndex = 18;
            this.dateTimePickerDestTime.Value = new System.DateTime(2019, 4, 3, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Weight";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Location = new System.Drawing.Point(380, 102);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownWeight.TabIndex = 20;
            // 
            // checkBoxDeprtTime
            // 
            this.checkBoxDeprtTime.AutoSize = true;
            this.checkBoxDeprtTime.Location = new System.Drawing.Point(821, 25);
            this.checkBoxDeprtTime.Name = "checkBoxDeprtTime";
            this.checkBoxDeprtTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDeprtTime.TabIndex = 21;
            this.checkBoxDeprtTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxDestTime
            // 
            this.checkBoxDestTime.AutoSize = true;
            this.checkBoxDestTime.Location = new System.Drawing.Point(821, 68);
            this.checkBoxDestTime.Name = "checkBoxDestTime";
            this.checkBoxDestTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDestTime.TabIndex = 22;
            this.checkBoxDestTime.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(550, 99);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FrmCargoSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxDestTime);
            this.Controls.Add(this.checkBoxDeprtTime);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerDestTime);
            this.Controls.Add(this.dateTimePickerDeprtTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerDest);
            this.Controls.Add(this.dateTimePickerDeprt);
            this.Controls.Add(this.checkBoxDestDay);
            this.Controls.Add(this.checkBoxDeprtDay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDestAdress);
            this.Controls.Add(this.textBoxDprtAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDestCity);
            this.Controls.Add(this.textBoxDprtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCargoSearch";
            this.Text = "CargoSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDprtCity;
        private System.Windows.Forms.TextBox textBoxDestCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDprtAdress;
        private System.Windows.Forms.TextBox textBoxDestAdress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxDeprtDay;
        private System.Windows.Forms.CheckBox checkBoxDestDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeprt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeprtTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.CheckBox checkBoxDeprtTime;
        private System.Windows.Forms.CheckBox checkBoxDestTime;
        private System.Windows.Forms.Button buttonSearch;
    }
}