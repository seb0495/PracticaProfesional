using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {
        public static int rolUsuario { set; get; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.ToString();
            string clave = txtClave.Text.ToString();
            LoginBLL loginBLL = new LoginBLL();
            rolUsuario = loginBLL.validarUsuario(usuario, clave);
            if (rolUsuario != -2)
            {
                FrmMenuPrincipal menuPrin = new FrmMenuPrincipal();
                menuPrin.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos", "Error de Autenticación",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();

            }

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnIngresar_Click(sender, e);
            }


        }

    }
}
