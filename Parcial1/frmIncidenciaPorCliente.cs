using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entities;
using BusinessLogic.IncidenciaService;
using BusinessLogic.ClienteService;

namespace Parcial1
{
    public partial class frmIncidenciaPorCliente : Form
    {
        private IIncidenciaService IncidenciaService;
        private IClienteService ClienteService;
        

        public frmIncidenciaPorCliente()
        {
            InitializeComponent();
        }

        //private void LoadAllIncidencias()
        //{
        //    dgvIncidencias.DataSource = this.IncidenciaService.GetAllIncidencia();
        //}

        private void frmIncidenciaPorCliente_Load(object sender, EventArgs e)
        {
            try
            {
                this.IncidenciaService = new IncidenciaService();
                this.ClienteService = new ClienteService();


                //cbConsulta.DataSource = this.IncidenciaService.GetAllIncidencia();
                //cbConsulta.SelectedIndex = 0;


                cbConsulta.DataSource = this.ClienteService.GetAllClientes();
                cbConsulta.SelectedIndex = 0;

                //this.LoadAllIncidencias();
            }
            catch (Exception ex)
            {
                
            }
            
        }

       

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void LoadAllIncidenciasPorFecha() {
           
        //    dgvIncidencias.DataSource = this.IncidenciaService.GetAllIncidenciaPorFecha(fecha1, fecha2);
        //}

        private void txtConsultar_Click(object sender, EventArgs e)
        {
             DateTime fecha1 = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime fecha2 = Convert.ToDateTime(dateTimePicker2.Value);
            try
            {

                

                Incidencia ojbIncidencia = new Incidencia();
               
                
                //LoadAllIncidenciasPorFecha();
                int id=Convert.ToInt32(cbConsulta.SelectedValue);
                

                dgvIncidencias.DataSource = this.IncidenciaService.GetAllIncidenciaPorFecha(id,fecha1, fecha2);
              

            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void incidenciaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void incidenciaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void recursoDigitalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void cbConsulta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //private void LoadAllIncidencias()
        //{
        //    dgvIncidencias.DataSource = this.IncidenciaService.GetAllIncidencia();
        //}
    }
}
