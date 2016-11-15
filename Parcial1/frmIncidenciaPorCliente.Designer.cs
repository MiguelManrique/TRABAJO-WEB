namespace Parcial1
{
    partial class frmIncidenciaPorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidenciaPorCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtDesde = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.Button();
            this.txtSalir = new System.Windows.Forms.Button();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRecursosDigitalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(81, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // txtDesde
            // 
            this.txtDesde.AutoSize = true;
            this.txtDesde.Location = new System.Drawing.Point(13, 103);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(41, 13);
            this.txtDesde.TabIndex = 4;
            this.txtDesde.Text = "Desde:";
            // 
            // txtHasta
            // 
            this.txtHasta.AutoSize = true;
            this.txtHasta.Location = new System.Drawing.Point(13, 135);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(38, 13);
            this.txtHasta.TabIndex = 5;
            this.txtHasta.Text = "Hasta:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(81, 180);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(75, 23);
            this.txtConsultar.TabIndex = 6;
            this.txtConsultar.Text = "Consultar";
            this.txtConsultar.UseVisualStyleBackColor = true;
            this.txtConsultar.Click += new System.EventHandler(this.txtConsultar_Click);
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(184, 180);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(75, 24);
            this.txtSalir.TabIndex = 7;
            this.txtSalir.Text = "Salir";
            this.txtSalir.UseVisualStyleBackColor = true;
            this.txtSalir.Click += new System.EventHandler(this.txtSalir_Click);
            // 
            // cbConsulta
            // 
            this.cbConsulta.DisplayMember = "NombreCliente";
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(138, 36);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(143, 21);
            this.cbConsulta.TabIndex = 10;
            this.cbConsulta.ValueMember = "Id";
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged_1);
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AutoGenerateColumns = false;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idRecursosDigitalesDataGridViewTextBoxColumn,
            this.idEstadoDataGridViewTextBoxColumn});
            this.dgvIncidencias.DataSource = this.incidenciaBindingSource;
            this.dgvIncidencias.Location = new System.Drawing.Point(12, 212);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.Size = new System.Drawing.Size(317, 150);
            this.dgvIncidencias.TabIndex = 11;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // idRecursosDigitalesDataGridViewTextBoxColumn
            // 
            this.idRecursosDigitalesDataGridViewTextBoxColumn.DataPropertyName = "IdRecursosDigitales";
            this.idRecursosDigitalesDataGridViewTextBoxColumn.HeaderText = "IdRecursosDigitales";
            this.idRecursosDigitalesDataGridViewTextBoxColumn.Name = "idRecursosDigitalesDataGridViewTextBoxColumn";
            // 
            // idEstadoDataGridViewTextBoxColumn
            // 
            this.idEstadoDataGridViewTextBoxColumn.DataPropertyName = "IdEstado";
            this.idEstadoDataGridViewTextBoxColumn.HeaderText = "IdEstado";
            this.idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            // 
            // incidenciaBindingSource
            // 
            this.incidenciaBindingSource.DataSource = typeof(Entities.Incidencia);
            // 
            // frmIncidenciaPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 374);
            this.Controls.Add(this.dgvIncidencias);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.txtSalir);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncidenciaPorCliente";
            this.Text = "Consultar Incidencias por Fecha";
            this.Load += new System.EventHandler(this.frmIncidenciaPorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label txtDesde;
        private System.Windows.Forms.Label txtHasta;
        private System.Windows.Forms.Button txtConsultar;
        private System.Windows.Forms.Button txtSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitacoraSeguimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.BindingSource incidenciaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecursosDigitalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
    }
}