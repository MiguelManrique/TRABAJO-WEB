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
using BusinessLogic.UsuarioService;

namespace Parcial1
{
    public partial class Main : Form
    {
        private IUsuarioService UsuarioService;
        public Main()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }


        //CAMBIAR ENTIDAD1 POR nombre real, ejem: Students, FrmStudents
        private void entidad1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupervisor frmENTIDAD1 = new frmSupervisor();
            frmENTIDAD1.MdiParent = this;
            frmENTIDAD1.Show();
        }

        private void entidad2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAdministrador frmENTIDAD2 = new frmAdministrador();
            //frmENTIDAD2.MdiParent = this;
            //frmENTIDAD2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Introduce usuario y contraseña.");
                return;
            }

            try
            {
                this.UsuarioService = new UsuarioService();
                Usuario usuario = new Usuario();
                usuario.Codigo = txtUsuario.Text;
                usuario.Password = txtPassword.Text;

                //int comp = Convert.ToInt32(usuario.TipoUsuario);



                if (UsuarioService.getUsuarioPorContrasena(usuario) != null)
                {
                    if (UsuarioService.getUsuarioPorContrasena(usuario).IdTipoUsuario.Equals(2))
                    {
                        MessageBox.Show("Bienvenido");

                        frmSupervisor frmSupervi = new frmSupervisor();
                        frmSupervi.Show();
                    }

                    else
                    {
                        MessageBox.Show("Bienvenido");
                        frmAdministrador frmAdministrador = new frmAdministrador();
                        frmAdministrador.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Error " + ex.Message);
            }






        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
