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
    public partial class frmTablasMaestras : Form
    {
        public frmTablasMaestras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtAgregar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count>0)
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
