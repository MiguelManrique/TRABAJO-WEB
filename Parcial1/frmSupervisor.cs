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
    public partial class frmSupervisor : Form
    {
        public frmSupervisor()
        {
            InitializeComponent();
        }

        private void agregarIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncidencia frmincidencia = new frmIncidencia();
            frmincidencia.MdiParent = this;
            frmincidencia.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora();
            frmBitacora.MdiParent = this;
            frmBitacora.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
