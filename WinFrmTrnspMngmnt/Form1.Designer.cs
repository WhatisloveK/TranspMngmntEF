namespace WinFrmTrnspMngmnt
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.tabPageDepartures = new System.Windows.Forms.TabPage();
            this.tabPageCargos = new System.Windows.Forms.TabPage();
            this.tabPageTrucker = new System.Windows.Forms.TabPage();
            this.tabPageTrucks = new System.Windows.Forms.TabPage();
            this.tabPageTruckTypes = new System.Windows.Forms.TabPage();
            this.dGVCities = new System.Windows.Forms.DataGridView();
            this.dGVDepartures = new System.Windows.Forms.DataGridView();
            this.dGVCargos = new System.Windows.Forms.DataGridView();
            this.dGVTruckers = new System.Windows.Forms.DataGridView();
            this.dGVTrucks = new System.Windows.Forms.DataGridView();
            this.dGVTruckTypes = new System.Windows.Forms.DataGridView();
            this.tabPageTrailers = new System.Windows.Forms.TabPage();
            this.tabPageTrailerTypes = new System.Windows.Forms.TabPage();
            this.dGVTrailers = new System.Windows.Forms.DataGridView();
            this.dGVTrailerTypes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageCities.SuspendLayout();
            this.tabPageDepartures.SuspendLayout();
            this.tabPageCargos.SuspendLayout();
            this.tabPageTrucker.SuspendLayout();
            this.tabPageTrucks.SuspendLayout();
            this.tabPageTruckTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckTypes)).BeginInit();
            this.tabPageTrailers.SuspendLayout();
            this.tabPageTrailerTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailerTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCities);
            this.tabControl1.Controls.Add(this.tabPageDepartures);
            this.tabControl1.Controls.Add(this.tabPageCargos);
            this.tabControl1.Controls.Add(this.tabPageTrucker);
            this.tabControl1.Controls.Add(this.tabPageTrucks);
            this.tabControl1.Controls.Add(this.tabPageTruckTypes);
            this.tabControl1.Controls.Add(this.tabPageTrailers);
            this.tabControl1.Controls.Add(this.tabPageTrailerTypes);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.dGVCities);
            this.tabPageCities.Location = new System.Drawing.Point(4, 22);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(794, 425);
            this.tabPageCities.TabIndex = 0;
            this.tabPageCities.Text = "Cities";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // tabPageDepartures
            // 
            this.tabPageDepartures.Controls.Add(this.dGVDepartures);
            this.tabPageDepartures.Location = new System.Drawing.Point(4, 22);
            this.tabPageDepartures.Name = "tabPageDepartures";
            this.tabPageDepartures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartures.Size = new System.Drawing.Size(794, 425);
            this.tabPageDepartures.TabIndex = 1;
            this.tabPageDepartures.Text = "Departures";
            this.tabPageDepartures.UseVisualStyleBackColor = true;
            // 
            // tabPageCargos
            // 
            this.tabPageCargos.Controls.Add(this.dGVCargos);
            this.tabPageCargos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCargos.Name = "tabPageCargos";
            this.tabPageCargos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCargos.Size = new System.Drawing.Size(794, 425);
            this.tabPageCargos.TabIndex = 2;
            this.tabPageCargos.Text = "Cargos";
            this.tabPageCargos.UseVisualStyleBackColor = true;
            // 
            // tabPageTrucker
            // 
            this.tabPageTrucker.Controls.Add(this.dGVTruckers);
            this.tabPageTrucker.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrucker.Name = "tabPageTrucker";
            this.tabPageTrucker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrucker.Size = new System.Drawing.Size(794, 425);
            this.tabPageTrucker.TabIndex = 3;
            this.tabPageTrucker.Text = "Truckers";
            this.tabPageTrucker.UseVisualStyleBackColor = true;
            // 
            // tabPageTrucks
            // 
            this.tabPageTrucks.Controls.Add(this.dGVTrucks);
            this.tabPageTrucks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrucks.Name = "tabPageTrucks";
            this.tabPageTrucks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrucks.Size = new System.Drawing.Size(794, 425);
            this.tabPageTrucks.TabIndex = 4;
            this.tabPageTrucks.Text = "Trucks";
            this.tabPageTrucks.UseVisualStyleBackColor = true;
            // 
            // tabPageTruckTypes
            // 
            this.tabPageTruckTypes.Controls.Add(this.dGVTruckTypes);
            this.tabPageTruckTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPageTruckTypes.Name = "tabPageTruckTypes";
            this.tabPageTruckTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTruckTypes.Size = new System.Drawing.Size(794, 425);
            this.tabPageTruckTypes.TabIndex = 5;
            this.tabPageTruckTypes.Text = "Truck types";
            this.tabPageTruckTypes.UseVisualStyleBackColor = true;
            // 
            // dGVCities
            // 
            this.dGVCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCities.Location = new System.Drawing.Point(-4, 35);
            this.dGVCities.Name = "dGVCities";
            this.dGVCities.Size = new System.Drawing.Size(802, 390);
            this.dGVCities.TabIndex = 0;
            // 
            // dGVDepartures
            // 
            this.dGVDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDepartures.Location = new System.Drawing.Point(-4, 35);
            this.dGVDepartures.Name = "dGVDepartures";
            this.dGVDepartures.Size = new System.Drawing.Size(802, 390);
            this.dGVDepartures.TabIndex = 1;
            // 
            // dGVCargos
            // 
            this.dGVCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCargos.Location = new System.Drawing.Point(-4, 35);
            this.dGVCargos.Name = "dGVCargos";
            this.dGVCargos.Size = new System.Drawing.Size(802, 390);
            this.dGVCargos.TabIndex = 1;
            // 
            // dGVTruckers
            // 
            this.dGVTruckers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTruckers.Location = new System.Drawing.Point(-4, 35);
            this.dGVTruckers.Name = "dGVTruckers";
            this.dGVTruckers.Size = new System.Drawing.Size(802, 390);
            this.dGVTruckers.TabIndex = 1;
            // 
            // dGVTrucks
            // 
            this.dGVTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrucks.Location = new System.Drawing.Point(-4, 35);
            this.dGVTrucks.Name = "dGVTrucks";
            this.dGVTrucks.Size = new System.Drawing.Size(802, 390);
            this.dGVTrucks.TabIndex = 1;
            // 
            // dGVTruckTypes
            // 
            this.dGVTruckTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTruckTypes.Location = new System.Drawing.Point(-4, 35);
            this.dGVTruckTypes.Name = "dGVTruckTypes";
            this.dGVTruckTypes.Size = new System.Drawing.Size(802, 390);
            this.dGVTruckTypes.TabIndex = 1;
            // 
            // tabPageTrailers
            // 
            this.tabPageTrailers.Controls.Add(this.dGVTrailers);
            this.tabPageTrailers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrailers.Name = "tabPageTrailers";
            this.tabPageTrailers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrailers.Size = new System.Drawing.Size(794, 425);
            this.tabPageTrailers.TabIndex = 6;
            this.tabPageTrailers.Text = "Trailers";
            this.tabPageTrailers.UseVisualStyleBackColor = true;
            // 
            // tabPageTrailerTypes
            // 
            this.tabPageTrailerTypes.Controls.Add(this.dGVTrailerTypes);
            this.tabPageTrailerTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrailerTypes.Name = "tabPageTrailerTypes";
            this.tabPageTrailerTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrailerTypes.Size = new System.Drawing.Size(794, 425);
            this.tabPageTrailerTypes.TabIndex = 7;
            this.tabPageTrailerTypes.Text = "Trailer types";
            this.tabPageTrailerTypes.UseVisualStyleBackColor = true;
            // 
            // dGVTrailers
            // 
            this.dGVTrailers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrailers.Location = new System.Drawing.Point(-4, 35);
            this.dGVTrailers.Name = "dGVTrailers";
            this.dGVTrailers.Size = new System.Drawing.Size(802, 390);
            this.dGVTrailers.TabIndex = 1;
            // 
            // dGVTrailerTypes
            // 
            this.dGVTrailerTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTrailerTypes.Location = new System.Drawing.Point(-4, 35);
            this.dGVTrailerTypes.Name = "dGVTrailerTypes";
            this.dGVTrailerTypes.Size = new System.Drawing.Size(802, 390);
            this.dGVTrailerTypes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCities.ResumeLayout(false);
            this.tabPageDepartures.ResumeLayout(false);
            this.tabPageCargos.ResumeLayout(false);
            this.tabPageTrucker.ResumeLayout(false);
            this.tabPageTrucks.ResumeLayout(false);
            this.tabPageTruckTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepartures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTruckTypes)).EndInit();
            this.tabPageTrailers.ResumeLayout(false);
            this.tabPageTrailerTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTrailerTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCities;
        private System.Windows.Forms.DataGridView dGVCities;
        private System.Windows.Forms.TabPage tabPageDepartures;
        private System.Windows.Forms.DataGridView dGVDepartures;
        private System.Windows.Forms.TabPage tabPageCargos;
        private System.Windows.Forms.DataGridView dGVCargos;
        private System.Windows.Forms.TabPage tabPageTrucker;
        private System.Windows.Forms.DataGridView dGVTruckers;
        private System.Windows.Forms.TabPage tabPageTrucks;
        private System.Windows.Forms.DataGridView dGVTrucks;
        private System.Windows.Forms.TabPage tabPageTruckTypes;
        private System.Windows.Forms.DataGridView dGVTruckTypes;
        private System.Windows.Forms.TabPage tabPageTrailers;
        private System.Windows.Forms.DataGridView dGVTrailers;
        private System.Windows.Forms.TabPage tabPageTrailerTypes;
        private System.Windows.Forms.DataGridView dGVTrailerTypes;
    }
}

