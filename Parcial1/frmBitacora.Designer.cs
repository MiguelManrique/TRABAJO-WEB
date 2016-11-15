namespace Parcial1
{
    partial class frmBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitacora));
            this.gbInfoBitacora = new System.Windows.Forms.GroupBox();
            this.txtEvidencia = new System.Windows.Forms.TextBox();
            this.cbIncidencia = new System.Windows.Forms.ComboBox();
            this.lbIncidencia = new System.Windows.Forms.Label();
            this.lbEvidencia = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvBitacoras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitacoraSeguimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdIncidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoBitacora.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraSeguimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoBitacora
            // 
            this.gbInfoBitacora.Controls.Add(this.txtEvidencia);
            this.gbInfoBitacora.Controls.Add(this.cbIncidencia);
            this.gbInfoBitacora.Controls.Add(this.lbIncidencia);
            this.gbInfoBitacora.Controls.Add(this.lbEvidencia);
            this.gbInfoBitacora.Location = new System.Drawing.Point(0, 0);
            this.gbInfoBitacora.Name = "gbInfoBitacora";
            this.gbInfoBitacora.Size = new System.Drawing.Size(317, 203);
            this.gbInfoBitacora.TabIndex = 0;
            this.gbInfoBitacora.TabStop = false;
            this.gbInfoBitacora.Text = "Informacion";
            // 
            // txtEvidencia
            // 
            this.txtEvidencia.Location = new System.Drawing.Point(172, 128);
            this.txtEvidencia.Name = "txtEvidencia";
            this.txtEvidencia.Size = new System.Drawing.Size(119, 20);
            this.txtEvidencia.TabIndex = 4;
            // 
            // cbIncidencia
            // 
            this.cbIncidencia.DisplayMember = "Id";
            this.cbIncidencia.FormattingEnabled = true;
            this.cbIncidencia.Location = new System.Drawing.Point(172, 64);
            this.cbIncidencia.Name = "cbIncidencia";
            this.cbIncidencia.Size = new System.Drawing.Size(121, 21);
            this.cbIncidencia.TabIndex = 3;
            this.cbIncidencia.ValueMember = "Id";
            // 
            // lbIncidencia
            // 
            this.lbIncidencia.AutoSize = true;
            this.lbIncidencia.Location = new System.Drawing.Point(28, 67);
            this.lbIncidencia.Name = "lbIncidencia";
            this.lbIncidencia.Size = new System.Drawing.Size(56, 13);
            this.lbIncidencia.TabIndex = 2;
            this.lbIncidencia.Text = "Incidencia";
            // 
            // lbEvidencia
            // 
            this.lbEvidencia.AutoSize = true;
            this.lbEvidencia.Location = new System.Drawing.Point(28, 131);
            this.lbEvidencia.Name = "lbEvidencia";
            this.lbEvidencia.Size = new System.Drawing.Size(54, 13);
            this.lbEvidencia.TabIndex = 0;
            this.lbEvidencia.Text = "Evidencia";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnAgregar);
            this.gbOpciones.Location = new System.Drawing.Point(12, 209);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(305, 183);
            this.gbOpciones.TabIndex = 1;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(108, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvBitacoras
            // 
            this.dgvBitacoras.AllowUserToAddRows = false;
            this.dgvBitacoras.AllowUserToDeleteRows = false;
            this.dgvBitacoras.AutoGenerateColumns = false;
            this.dgvBitacoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIncidencia,
            this.Incidencia,
            this.evidenciaDataGridViewTextBoxColumn});
            this.dgvBitacoras.DataSource = this.bitacoraSeguimientoBindingSource;
            this.dgvBitacoras.Location = new System.Drawing.Point(323, 12);
            this.dgvBitacoras.Name = "dgvBitacoras";
            this.dgvBitacoras.ReadOnly = true;
            this.dgvBitacoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacoras.Size = new System.Drawing.Size(492, 380);
            this.dgvBitacoras.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Incidencia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Incidencia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Incidencia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Incidencia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Incidencia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Incidencia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Incidencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Incidencia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Incidencia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Incidencia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // bitacoraSeguimientoBindingSource
            // 
            this.bitacoraSeguimientoBindingSource.DataSource = typeof(Entities.BitacoraSeguimiento);
            // 
            // IdIncidencia
            // 
            this.IdIncidencia.DataPropertyName = "IdIncidencia";
            this.IdIncidencia.HeaderText = "IdIncidencia";
            this.IdIncidencia.Name = "IdIncidencia";
            this.IdIncidencia.ReadOnly = true;
            // 
            // Incidencia
            // 
            this.Incidencia.DataPropertyName = "Incidencia";
            this.Incidencia.HeaderText = "Incidencia";
            this.Incidencia.Name = "Incidencia";
            this.Incidencia.ReadOnly = true;
            this.Incidencia.Width = 200;
            // 
            // evidenciaDataGridViewTextBoxColumn
            // 
            this.evidenciaDataGridViewTextBoxColumn.DataPropertyName = "Evidencia";
            this.evidenciaDataGridViewTextBoxColumn.HeaderText = "Evidencia";
            this.evidenciaDataGridViewTextBoxColumn.Name = "evidenciaDataGridViewTextBoxColumn";
            this.evidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.evidenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 403);
            this.Controls.Add(this.dgvBitacoras);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.gbInfoBitacora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            this.gbInfoBitacora.ResumeLayout(false);
            this.gbInfoBitacora.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraSeguimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoBitacora;
        private System.Windows.Forms.Label lbEvidencia;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvBitacoras;
        private System.Windows.Forms.ComboBox cbIncidencia;
        private System.Windows.Forms.Label lbIncidencia;
        private System.Windows.Forms.TextBox txtEvidencia;
        private System.Windows.Forms.BindingSource bitacoraSeguimientoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIncidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}