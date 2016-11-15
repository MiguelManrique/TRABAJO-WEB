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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void incidenciaPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncidenciaPorCliente frmincidenciaPorCliente = new frmIncidenciaPorCliente();
            frmincidenciaPorCliente.MdiParent = this;
            frmincidenciaPorCliente.Show();
        }

        private void gestionarCredencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCredenciales frmcredenciales = new frmCredenciales();
            frmcredenciales.MdiParent = this;
            frmcredenciales.Show();
        }

        private void tablasMaestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablasMaestras frmtablasMaestras = new frmTablasMaestras();
            frmtablasMaestras.MdiParent = this;
            frmtablasMaestras.Show();

        }

        private void cronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCronograma frmcronograma = new frmCronograma();
            frmcronograma.MdiParent = this;
            frmcronograma.Show();
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
