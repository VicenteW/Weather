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
            this.Slc = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.picSol = new System.Windows.Forms.PictureBox();
            this.pnlTemp = new System.Windows.Forms.Panel();
            this.dgvClima = new System.Windows.Forms.DataGridView();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenarTemp = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lstCiudades = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).BeginInit();
            this.pnlTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClima)).BeginInit();
            this.SuspendLayout();
            // 
            // Slc
            // 
            this.Slc.AutoSize = true;
            this.Slc.Location = new System.Drawing.Point(12, 9);
            this.Slc.Name = "Slc";
            this.Slc.Size = new System.Drawing.Size(155, 17);
            this.Slc.TabIndex = 1;
            this.Slc.Text = "Selecciona una ciudad:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(411, 252);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(118, 63);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(253, 252);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(118, 63);
            this.btnArchivo.TabIndex = 3;
            this.btnArchivo.Text = "Generar Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblTempMax.Location = new System.Drawing.Point(206, 160);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(167, 20);
            this.lblTempMax.TabIndex = 6;
            this.lblTempMax.Text = "Temperatura Maxima";
            // 
            // lblTempMin
            // 
            this.lblTempMin.AutoSize = true;
            this.lblTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMin.Location = new System.Drawing.Point(208, 189);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(163, 20);
            this.lblTempMin.TabIndex = 7;
            this.lblTempMin.Text = "Temperatura Minima";
            // 
            // picSol
            // 
            this.picSol.Location = new System.Drawing.Point(478, 12);
            this.picSol.Name = "picSol";
            this.picSol.Size = new System.Drawing.Size(67, 51);
            this.picSol.TabIndex = 8;
            this.picSol.TabStop = false;
            // 
            // pnlTemp
            // 
            this.pnlTemp.Controls.Add(this.dgvClima);
            this.pnlTemp.Controls.Add(this.btnOrdenarTemp);
            this.pnlTemp.Controls.Add(this.btnOrdenar);
            this.pnlTemp.Controls.Add(this.btnBuscar);
            this.pnlTemp.Controls.Add(this.txtbuscar);
            this.pnlTemp.Location = new System.Drawing.Point(12, 358);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(562, 291);
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
            this.Temp_min});
            this.dgvClima.Location = new System.Drawing.Point(12, 77);
            this.dgvClima.Name = "dgvClima";
            this.dgvClima.RowTemplate.Height = 24;
            this.dgvClima.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClima.Size = new System.Drawing.Size(537, 211);
            this.dgvClima.TabIndex = 4;
            this.dgvClima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClima_CellContentClick);
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
            // btnOrdenarTemp
            // 
            this.btnOrdenarTemp.Location = new System.Drawing.Point(451, 12);
            this.btnOrdenarTemp.Name = "btnOrdenarTemp";
            this.btnOrdenarTemp.Size = new System.Drawing.Size(108, 42);
            this.btnOrdenarTemp.TabIndex = 3;
            this.btnOrdenarTemp.Text = "Ordenar por Temperatura";
            this.btnOrdenarTemp.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(344, 12);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(101, 42);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar por Ciudad";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(233, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 42);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Ciudad";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(12, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(215, 22);
            this.txtbuscar.TabIndex = 0;
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
            "Versalles"});
            this.lstCiudades.Location = new System.Drawing.Point(15, 29);
            this.lstCiudades.Name = "lstCiudades";
            this.lstCiudades.Size = new System.Drawing.Size(152, 308);
            this.lstCiudades.TabIndex = 5;
            this.lstCiudades.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 661);
            this.Controls.Add(this.lstCiudades);
            this.Controls.Add(this.pnlTemp);
            this.Controls.Add(this.picSol);
            this.Controls.Add(this.lblTempMin);
            this.Controls.Add(this.lblTempMax);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.Slc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSol)).EndInit();
            this.pnlTemp.ResumeLayout(false);
            this.pnlTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Slc;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblTempMin;
        private System.Windows.Forms.PictureBox picSol;
        private System.Windows.Forms.Panel pnlTemp;
        private System.Windows.Forms.Button btnOrdenarTemp;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ListBox lstCiudades;
        private System.Windows.Forms.DataGridView dgvClima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp_min;
    }
}

