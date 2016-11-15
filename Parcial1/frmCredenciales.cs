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
    public partial class frmCredenciales : Form
    {
        private IUsuarioService UsuarioService;

        public frmCredenciales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCredenciales_Load(object sender, EventArgs e)
        {

            try
            {
                
                this.UsuarioService = new UsuarioService();

                cbUsuarios.DataSource = this.UsuarioService.GetAllUsuarios();               
                cbUsuarios.SelectedIndex = 0;

                //this.LoadAllUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.UsuarioService = new UsuarioService();

             Usuario user = new Usuario() ;
             user.Id = Convert.ToInt32(cbUsuarios.SelectedValue);

            try
            {
                Usuario objUsuario = new Usuario();
                objUsuario = this.UsuarioService.GetUsuarioById(Convert.ToInt32(cbUsuarios.SelectedValue));
                //objUsuario = this.cbUsuarios.ValueMember();

                if (rbAdm.Checked)
                {
                    objUsuario.IdTipoUsuario = 1;
                    //objUsuario.Id = user.Id;
                    //objUsuario.Nombre = user.Nombre;
                    //objUsuario.Password = user.Password;
                    //objUsuario.Codigo = user.Codigo;

                    this.UsuarioService.CambiarCredencia(objUsuario);
                    MessageBox.Show("La cuenta ahora es Administrador");
                }

                else if (rbSup.Checked)
                {
                    objUsuario.IdTipoUsuario = 2;
                    //objUsuario.Id = user.Id;
                    //objUsuario.Nombre = user.Nombre;
                    //objUsuario.Password = user.Password;
                    //objUsuario.Codigo = user.Codigo;
                    this.UsuarioService.CambiarCredencia(objUsuario);
                    MessageBox.Show("La cuenta ahora es Supervisor");
                }

                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
