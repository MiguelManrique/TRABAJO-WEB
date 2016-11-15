using BusinessLogic.BitacoraService;
using BusinessLogic.IncidenciaService;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class frmBitacora : Form
    {
        private IIncidenciaService IncidenciaService;
        private IBitacoraService BitacoraService;

        public frmBitacora()
        {
            InitializeComponent();
        }

        private void LoadAllBitacoras()
        {
            dgvBitacoras.DataSource = this.BitacoraService.GetAllBitacoras();
        }

        

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                this.IncidenciaService = new IncidenciaService();
                this.BitacoraService = new BitacoraService();

                cbIncidencia.DataSource = this.IncidenciaService.GetAllIncidencia();
                cbIncidencia.SelectedIndex = 0;

                this.LoadAllBitacoras();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                BitacoraSeguimiento objBitacora = new BitacoraSeguimiento();

                objBitacora.Evidencia = this.txtEvidencia.Text;
                objBitacora.IdIncidencia = Convert.ToInt32(this.cbIncidencia.SelectedValue);

                this.BitacoraService.InsertBitacora(objBitacora);
                this.LoadAllBitacoras();
                MessageBox.Show("Incidencia Guardada satisfactoriamente!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
