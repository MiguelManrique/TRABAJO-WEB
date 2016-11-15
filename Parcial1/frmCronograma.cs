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
using BusinessLogic.ClienteService;
using BusinessLogic.IncidenciaService;

namespace Parcial1
{
    public partial class frmCronograma : Form
    {
        private IClienteService ClienteService;
        private IIncidenciaService IncidenciaService;
        public frmCronograma()
        {
            InitializeComponent();
        }
        private void LoadAllCronograma()
        {
            dgvCronograma.DataSource = this.IncidenciaService.GetAllIncidencia();
        }

        private void frmCronograma_Load(object sender, EventArgs e)
        {
            try
            {
                
                this.ClienteService = new ClienteService();
                this.IncidenciaService = new IncidenciaService();

               
                cbCliente.DataSource = this.ClienteService.GetAllClientes();
                cbCliente.SelectedIndex = 0;

                //this.LoadAllCronograma();

            }
            catch (Exception ex)
            {
                throw ex;



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IncidenciaService = new IncidenciaService();

            try
            {
               
                int client = Convert.ToInt32(cbCliente.SelectedValue);
                dgvCronograma.DataSource = this.IncidenciaService.GetAllIncidenciasPorCliente(client);
                dgvCronograma.Rows.Clear();

                //this.LoadAllCronograma();

               
            }

            catch (Exception ex)
            {
                //throw ex;
            }
            

            
        }
    }
}
