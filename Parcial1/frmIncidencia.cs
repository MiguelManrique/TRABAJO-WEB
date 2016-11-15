using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLogic.IncidenciaService;
using BusinessLogic.RecursosService;
using BusinessLogic.EstadoService;
using Entities;
using BusinessLogic.ClienteService;
using BusinessLogic.SupervisorService;


namespace Parcial1
{
    public partial class frmIncidencia : Form
    {
        private IIncidenciaService IncidenciaService;
        private IEstadoService EstadoService;
        private IRecursosService RecursosService;
        private IClienteService ClienteService;
        private ISupervisorService SupervisorService;
        public frmIncidencia()
        {
            InitializeComponent();
        }


        private void frmIncidencia_Load(object sender, EventArgs e)
        {
            try
            {
                this.IncidenciaService = new IncidenciaService();
                this.EstadoService = new EstadoService();
                this.RecursosService = new RecursosService();
                this.ClienteService = new ClienteService();
                this.SupervisorService = new SupervisorService();

                cbEstado.DataSource = this.EstadoService.GetAllEstados();
                cbEstado.SelectedIndex = 0;
                cbRecursoDigitales.DataSource = this.RecursosService.GetAllRecursos();
                cbRecursoDigitales.SelectedIndex = 0;
                cbCLiente.DataSource = this.ClienteService.GetAllClientes();
                cbCLiente.SelectedIndex = 0;
                cbSupervisor.DataSource = this.SupervisorService.GetAllSupervisores();
                cbSupervisor.SelectedIndex = 0;
                this.LoadAllIncidencias();

            }
            catch (Exception ex)
            {



            }


        }


        private void LoadAllIncidencias()
        {
            dgvIncidencias.DataSource = this.IncidenciaService.GetAllIncidencia();
        }



        private void cbCLiente_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Incidencia objIncidencia = new Incidencia();
                //objIncidencia.Fecha = this.dtpFecha.Value.ToString("dd/MM/yyyy");
                objIncidencia.Fecha = this.dtpFecha.Value.ToLocalTime();
                objIncidencia.IdEstado = Convert.ToInt32(this.cbEstado.SelectedValue);
                objIncidencia.IdRecursosDigitales = Convert.ToInt32(this.cbRecursoDigitales.SelectedValue);
                objIncidencia.Descripcion = this.txtDescripcion.Text;
                objIncidencia.IdSupervisor = Convert.ToInt32(this.cbSupervisor.SelectedValue);
                objIncidencia.ICliente = Convert.ToInt32(this.cbCLiente.SelectedValue);

                this.IncidenciaService.InsertIncidencia(objIncidencia);
                this.LoadAllIncidencias();
                MessageBox.Show("Incidencia Guardada satisfactoriamente!");
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    
        //}

        //private void dgvIncidencias_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //
        //
        //    
        //}

        private void dgvIncidencias_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int incidenciaId = Convert.ToInt32(dgvIncidencias.Rows[e.RowIndex].Cells["IdColumn"].Value);
                Incidencia objIncidencia = this.IncidenciaService.GetIncidenciaById(incidenciaId);
                this.txtID.Text = objIncidencia.Id.ToString();
                this.dtpFecha.Value = objIncidencia.Fecha;
                this.cbRecursoDigitales.SelectedValue = objIncidencia.IdRecursosDigitales;
                this.txtDescripcion.Text = objIncidencia.Descripcion;
                this.cbSupervisor.SelectedValue = objIncidencia.IdSupervisor;
                this.cbCLiente.SelectedValue = objIncidencia.ICliente;

            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Incidencia objIncidencia = new Incidencia();
                objIncidencia.Id = Convert.ToInt32(this.txtID.Text);
                objIncidencia.Fecha = this.dtpFecha.Value;
                objIncidencia.IdEstado = Convert.ToInt32(this.cbEstado.SelectedValue);
                objIncidencia.IdRecursosDigitales = Convert.ToInt32(this.cbRecursoDigitales.SelectedValue);
                objIncidencia.Descripcion = this.txtDescripcion.Text;
                objIncidencia.IdSupervisor = Convert.ToInt32(this.cbSupervisor.SelectedValue);
                objIncidencia.ICliente = Convert.ToInt32(this.cbCLiente.SelectedValue);

                this.IncidenciaService.UpdateIncidencia(objIncidencia);
                this.LoadAllIncidencias();
                MessageBox.Show("Incidencia Actualizada satisfactoriamente!");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }



    //private void LoadAllIncidencias()
    //    {
    //        dgvIncidencias.DataSource = this.IncidenciaService.GetAllIncidencia();
    //    }
}
