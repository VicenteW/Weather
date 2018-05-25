namespace Clima_Grafico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Slc = new System.Windows.Forms.Label();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.picSol = new System.Windows.Forms.PictureBox();
            this.pnlTemp = new System.Windows.Forms.Panel();
            this.dgvClima = new System.Windows.Forms.DataGridView();
            this.lstCiudades = new System.Windows.Forms.ListBox();
            this.lbl_humedad = new System.Windows.Forms.Label();
            this.lbl_presion = new System.Windows.Forms.Label();
            this.lbl_vel_viento = new System.Windows.Forms.Label();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vel_vientio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic_termometro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).BeginInit();
            this.pnlTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_termometro)).BeginInit();
            this.SuspendLayout();
            // 
            // Slc
            // 
            this.Slc.AutoSize = true;
            this.Slc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Slc.Location = new System.Drawing.Point(12, 9);
            this.Slc.Name = "Slc";
            this.Slc.Size = new System.Drawing.Size(155, 17);
            this.Slc.TabIndex = 1;
            this.Slc.Text = "Selecciona una ciudad:";
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnArchivo.ForeColor = System.Drawing.Color.Black;
            this.btnArchivo.Location = new System.Drawing.Point(578, 298);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(169, 39);
            this.btnArchivo.TabIndex = 3;
            this.btnArchivo.Text = "Generar Archivo";
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(205, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE   ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTemp.Location = new System.Drawing.Point(207, 120);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(81, 29);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Text = "TEMP";
            // 
            // lblTempMax
            // 
            this.lblTempMax.AutoSize = true;
            this.lblTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTempMax.Location = new System.Drawing.Point(206, 166);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(167, 20);
            this.lblTempMax.TabIndex = 6;
            this.lblTempMax.Text = "Temperatura Maxima";
            // 
            // lblTempMin
            // 
            this.lblTempMin.AutoSize = true;
            this.lblTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTempMin.Location = new System.Drawing.Point(208, 189);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(163, 20);
            this.lblTempMin.TabIndex = 7;
            this.lblTempMin.Text = "Temperatura Minima";
            this.lblTempMin.Click += new System.EventHandler(this.lblTempMin_Click);
            // 
            // picSol
            // 
            this.picSol.Location = new System.Drawing.Point(212, 27);
            this.picSol.Name = "picSol";
            this.picSol.Size = new System.Drawing.Size(67, 51);
            this.picSol.TabIndex = 8;
            this.picSol.TabStop = false;
            // 
            // pnlTemp
            // 
            this.pnlTemp.Controls.Add(this.dgvClima);
            this.pnlTemp.Location = new System.Drawing.Point(12, 374);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(786, 264);
            this.pnlTemp.TabIndex = 9;
            this.pnlTemp.Visible = false;
            // 
            // dgvClima
            // 
            this.dgvClima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciudad,
            this.Temperatura,
            this.Temp_max,
            this.Temp_min,
            this.humedad,
            this.presion,
            this.vel_vientio});
            this.dgvClima.Location = new System.Drawing.Point(12, 37);
            this.dgvClima.Name = "dgvClima";
            this.dgvClima.RowTemplate.Height = 24;
            this.dgvClima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClima.Size = new System.Drawing.Size(755, 211);
            this.dgvClima.TabIndex = 7;
            this.dgvClima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClima_CellContentClick);
            // 
            // lstCiudades
            // 
            this.lstCiudades.FormattingEnabled = true;
            this.lstCiudades.ItemHeight = 16;
            this.lstCiudades.Items.AddRange(new object[] {
            "Orizaba",
            "Cordoba",
            "Veracruz",
            "Xalapa",
            "Irvine",
            "Chimbote",
            "Toronto",
            "Austin",
            "Versalles",
            "Paris",
            "Montreal",
            "Madrid",
            "London",
            "Quebec",
            "Shanghai",
            "Tokyo"});
            this.lstCiudades.Location = new System.Drawing.Point(15, 29);
            this.lstCiudades.Name = "lstCiudades";
            this.lstCiudades.Size = new System.Drawing.Size(152, 276);
            this.lstCiudades.TabIndex = 5;
            this.lstCiudades.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_humedad
            // 
            this.lbl_humedad.AutoSize = true;
            this.lbl_humedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humedad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_humedad.Location = new System.Drawing.Point(208, 212);
            this.lbl_humedad.Name = "lbl_humedad";
            this.lbl_humedad.Size = new System.Drawing.Size(81, 20);
            this.lbl_humedad.TabIndex = 10;
            this.lbl_humedad.Text = "Humedad";
            // 
            // lbl_presion
            // 
            this.lbl_presion.AutoSize = true;
            this.lbl_presion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_presion.Location = new System.Drawing.Point(208, 238);
            this.lbl_presion.Name = "lbl_presion";
            this.lbl_presion.Size = new System.Drawing.Size(66, 20);
            this.lbl_presion.TabIndex = 11;
            this.lbl_presion.Text = "Presión";
            // 
            // lbl_vel_viento
            // 
            this.lbl_vel_viento.AutoSize = true;
            this.lbl_vel_viento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vel_viento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_vel_viento.Location = new System.Drawing.Point(208, 262);
            this.lbl_vel_viento.Name = "lbl_vel_viento";
            this.lbl_vel_viento.Size = new System.Drawing.Size(86, 20);
            this.lbl_vel_viento.TabIndex = 12;
            this.lbl_vel_viento.Text = "Vel. viento";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Temperatura
            // 
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            // 
            // Temp_max
            // 
            this.Temp_max.HeaderText = "Temp. Max";
            this.Temp_max.Name = "Temp_max";
            // 
            // Temp_min
            // 
            this.Temp_min.HeaderText = "Temp. Min";
            this.Temp_min.Name = "Temp_min";
            // 
            // humedad
            // 
            this.humedad.HeaderText = "Humedad";
            this.humedad.Name = "humedad";
            // 
            // presion
            // 
            this.presion.HeaderText = "Presión";
            this.presion.Name = "presion";
            // 
            // vel_vientio
            // 
            this.vel_vientio.HeaderText = "Vel. Viento";
            this.vel_vientio.Name = "vel_vientio";
            // 
            // pic_termometro
            // 
            this.pic_termometro.BackColor = System.Drawing.Color.Transparent;
            this.pic_termometro.Image = ((System.Drawing.Image)(resources.GetObject("pic_termometro.Image")));
            this.pic_termometro.InitialImage = null;
            this.pic_termometro.Location = new System.Drawing.Point(538, 29);
            this.pic_termometro.Name = "pic_termometro";
            this.pic_termometro.Size = new System.Drawing.Size(243, 256);
            this.pic_termometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_termometro.TabIndex = 13;
            this.pic_termometro.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(810, 660);
            this.Controls.Add(this.pic_termometro);
            this.Controls.Add(this.lbl_vel_viento);
            this.Controls.Add(this.lbl_presion);
            this.Controls.Add(this.lbl_humedad);
            this.Controls.Add(this.lstCiudades);
            this.Controls.Add(this.pnlTemp);
            this.Controls.Add(this.picSol);
            this.Controls.Add(this.lblTempMin);
            this.Controls.Add(this.lblTempMax);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.Slc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "wwWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).EndInit();
            this.pnlTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_termometro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Slc;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblTempMin;
        private System.Windows.Forms.PictureBox picSol;
        private System.Windows.Forms.Panel pnlTemp;
        private System.Windows.Forms.ListBox lstCiudades;
        private System.Windows.Forms.DataGridView dgvClima;
        private System.Windows.Forms.Label lbl_humedad;
        private System.Windows.Forms.Label lbl_presion;
        private System.Windows.Forms.Label lbl_vel_viento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn presion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vel_vientio;
        private System.Windows.Forms.PictureBox pic_termometro;
    }
}

