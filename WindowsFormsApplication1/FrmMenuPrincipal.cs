using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenEstud estudiantes = new FrmMantenEstud();
            estudiantes.Visible = true;
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            int rol = FrmLogin.rolUsuario;
            if (rol == 2) {
                menuPrincipal.Items[0].Enabled = false;
                menuPrincipal.Items[2].Enabled = false;
                formularioBecaTransporteToolStripMenuItem.Enabled = false;
                expedienteDeEstudianteToolStripMenuItem.Enabled = false;
                resumenDeIngresosToolStripMenuItem.Enabled = false;
            }
        }

        private void reporteInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncidente incidente = new FrmIncidente();
            incidente.Visible = true;

        }

        private void padreDeFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPadres padres = new FrmPadres();
            padres.Visible = true;
        }
    }
}
