using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace WindowsFormsApplication1
{
    public partial class FrmMantenEstud : Form
    {
        public FrmMantenEstud()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenEstud_Load(object sender, EventArgs e)
        {
            deshabilitarTodo();
            cargarNanacionalidades();
            tsbMod.Enabled = false;
            tsbElim.Enabled = false;
            txtCedBusqueda.Enabled = true;
            btnBuscar.Enabled = true;




        }
        private void cargarNanacionalidades()
        {
            EstudianteBLL estuBLL = new EstudianteBLL();
            DataTable nacionalides = estuBLL.cargarNacionalidades();
            cboNac.DataSource = nacionalides;
            cboNac.ValueMember = Convert.ToString("idNacionalidad");
            cboNac.DisplayMember = "descripcion";


        }
        private void deshabilitarTodo()
        {
            txtCedBusqueda.Enabled = false;
            txtCédula.Enabled = false;
            txtEXP.Enabled = false;
            txtExpCed.Enabled = false;
            txtExpirCed.Enabled = false;
            txtFechNac.Enabled = false;
            txtNombre.Enabled = false;
            txtSegAp.Enabled = false;
            txtPriAp.Enabled = false;
            rdbFem.Enabled = false;
            rdbMasc.Enabled = false;
            txtExpedCed.Enabled = false;
            btnBuscar.Enabled = false;
            btnGuardar.Enabled = false;
            cboNac.Enabled = false;
        }
        private void habilitarTodo()
        {

            txtCédula.Enabled = true;
            txtEXP.Enabled = true;
            txtExpCed.Enabled = true;
            txtExpirCed.Enabled = true;
            txtFechNac.Enabled = true;
            txtNombre.Enabled = true;
            txtSegAp.Enabled = true;
            txtPriAp.Enabled = true;
            rdbFem.Enabled = true;
            rdbMasc.Enabled = true;
            txtExpedCed.Enabled = true;
            btnGuardar.Enabled = true;
            cboNac.Enabled = true;
        }
        private void tsbInsertar_Click(object sender, EventArgs e)
        {
            habilitarTodo();
            tsbElim.Enabled = false;
            tsbMod.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtExpCed_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            deshabilitarTodo();
            habilitarBusqueda();
            tsbInsertar.Enabled = false;
            tsbElim.Enabled = false;

        }

        private void habilitarBusqueda()
        {
            txtCedBusqueda.Enabled = true;
            btnBuscar.Enabled = true;
            txtCedBusqueda.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            deshabilitarTodo();
            habilitarBusqueda();
            tsbInsertar.Enabled = false;
            tsbMod.Enabled = false;
            string cedula = txtCédula.Text.ToString();

            if (cedula.Length > 0 &&  MessageBox.Show("Esta seguro de desear eliminar este estudiante de forma permanente?", "Confirmar Eliminación de Estudiante",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                EstudianteBLL estBLL = new EstudianteBLL();
                try
                {
                    int resultado=estBLL.eliminarEstudiante(cedula);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Estudiante eliminado con exito", "Estudiante Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar estudiante"+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe buscar un estudiante para eliminar", "Estudiante Invalido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void txtCédula_Validating(object sender, CancelEventArgs e)
        {


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNombre.ToString();
            if (!validarNoNumeros(nombre))
            {
                errorProvider1.SetError(txtNombre, "El nombre es requerido y no debe incluir números");
            }

        }


        private bool validarNoNumeros(string valor)
        {
            Regex regex = new Regex(@"^[0-9]+$");


            if (String.IsNullOrWhiteSpace(valor))
            {
                return false;
            }
            if (regex.IsMatch(valor))
            {
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                char genero = 'n';
                Estudiante est = new Estudiante();
                est.cedula = txtCédula.Text.ToString();
                est.nombre = txtNombre.Text.ToString();
                est.primerApellido = txtPriAp.Text.ToString();
                est.segundoApellido = txtSegAp.Text.ToString();
                est.idNacionalidad = Convert.ToInt32(cboNac.SelectedValue.ToString());
                foreach (Control control in pnlGen.Controls)
                {

                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        genero = Convert.ToChar(radio.Text.ToString());
                    }

                }
                est.genero = genero;
                est.fechaNacimiento = DateTime.ParseExact(txtFechNac.Text.ToString(), "d", null);
                est.fechaExped = DateTime.ParseExact(txtExpedCed.Text.ToString(), "d", null);
                est.fechaVenc = DateTime.ParseExact(txtExpirCed.Text.ToString(), "d", null);
                try
                {
                    EstudianteBLL estuBLL = new EstudianteBLL();
                    estuBLL.guardarEstudiante(est);
                    MessageBox.Show("Estudiante registrado exitosamete", "Estudiante Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtFechNac.Clear();
                    txtCedBusqueda.Clear();
                    txtCédula.Clear();
                    txtEXP.Clear();
                    txtExpCed.Clear();
                    txtExpirCed.Clear();
                    txtFechNac.Clear();
                    txtNombre.Clear();
                    txtSegAp.Clear();
                    txtPriAp.Clear();
                    txtExpedCed.Clear();
                    tsbElim.Enabled = true;
                    tsbInsertar.Enabled = true;
                    tsbMod.Enabled = true;
                    tsbCancelar.Enabled = true;
                    deshabilitarTodo();
                    cargarNanacionalidades();
                    tsbMod.Enabled = false;
                    tsbElim.Enabled = false;
                    txtCedBusqueda.Enabled = true;
                    btnBuscar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar estudiante" + ex.Message);
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.txtFechNac.Clear();
            txtCedBusqueda.Clear();
            txtCédula.Clear();
            txtEXP.Clear();
            txtExpCed.Clear();
            txtExpirCed.Clear();
            txtFechNac.Clear();
            txtNombre.Clear();
            txtSegAp.Clear();
            txtPriAp.Clear();
            txtExpedCed.Clear();
            tsbElim.Enabled = true;
            tsbInsertar.Enabled = true;
            tsbMod.Enabled = true;
            tsbCancelar.Enabled = true;
            deshabilitarTodo();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tsbMod.Enabled = true;
            string cedula = txtCedBusqueda.Text.ToString();
            EstudianteBLL estBll = new EstudianteBLL();
            Estudiante estudiante = estBll.buscarEstudianteCed(cedula);
            tsbElim.Enabled = true;
            txtCédula.Text = estudiante.cedula;
            txtNombre.Text = estudiante.nombre;
            txtPriAp.Text = estudiante.primerApellido;
            txtFechNac.Text = estudiante.fechaNacimiento.ToString("dd/MM/yyyy");
            txtExpedCed.Text = estudiante.fechaExped.ToString("dd/MM/yyyy"); ;
            txtExpirCed.Text = estudiante.fechaVenc.ToString("dd/MM/yyyy"); ;
            cboNac.SelectedIndex = estudiante.idNacionalidad;
            txtSegAp.Text = estudiante.segundoApellido;
            if (estudiante.genero.Equals("F"))
            {
                rdbFem.Select();
            }
            else
            {
                rdbMasc.Select();
            }

            habilitarTodo();
        }
    }
}
