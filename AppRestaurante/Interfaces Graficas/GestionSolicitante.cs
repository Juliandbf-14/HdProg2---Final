using AppRestaurante.Entidades;
using AppRestaurante.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.Interfaces_Graficas
{
    public partial class GestionSolicitante : Form
    {
        private SolicitanteBD operacionesBd;
        private DataTable restDataTable = new DataTable();

        private Stream myStream;

        private bool swCrud = false;
        private bool swModificarRes = false;

        private string tempCedula = "";
        private string tempNombre = "";
        private string tempApellido = "";
        private string tempEmail = "";
        private string tempTel = "";

        private int counter = 0;
        private string line;
        OpenFileDialog openFileDialog = null;
        ExportDataFile archivo;

        public GestionSolicitante()
        {
            InitializeComponent();
        }

        private void GestionSolicitante_Load(object sender, EventArgs e)
        {
            CargarDatosInicio();
        }

        private void CargarDatosInicio()
        {
            try
            {
                operacionesBd = new SolicitanteBD();
                OcultarComponentesSolicitante();

                restDataTable = operacionesBd.consultarDatos();
                ResultadosSoli.DataSource = restDataTable;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Lo siento, ha ocurrido un error ", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarCedSol_TextChanged(object sender, System.EventArgs e)
        {
            if (!swCrud)
            {
                DataView restauranteBusqueda = restDataTable.DefaultView;
                restauranteBusqueda.RowFilter = $"Nombre LIKE '%{txtBuscarCedSol.Text}%'";
            }
        }

        private void btnBuscarSol_Click(object sender, EventArgs e)
        {
            if (swCrud)
            {
                operacionesBd = new SolicitanteBD();
                Solicitante solicitante = null;
                solicitante = operacionesBd.BuscarDato(txtBuscarCedSol.Text);

                if (solicitante != null)
                {
                    txtIdSoli.Text = Convert.ToString(solicitante.Id);
                    txtCedSol.Text = solicitante.Cedula;
                    txtNomSol.Text = solicitante.Nombre;
                    txtApeSol.Text = solicitante.Apellido;
                    txtEmailSol.Text = solicitante.Email;
                    txtTelSol.Text = solicitante.Telefono;

                    swModificarRes = true;
                    btnActualizarSol.Enabled = true;
                    btnEliminarSol.Enabled = true;
                    txtIdSoli.Enabled = false;
                    AsignarCamposTemporales();
                }
                else
                {
                    MessageBox.Show($"Parece que el Solicitante que buscas no existe, revisa el nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnIngresarSol_Click(object sender, System.EventArgs e)
        {
            try
            {
                operacionesBd = new SolicitanteBD();
                Solicitante restauranteObj = new Solicitante(txtCedSol.Text, txtNomSol.Text, txtApeSol.Text, txtEmailSol.Text, txtTelSol.Text);

                if (restauranteObj.ValidarPropiedades() && operacionesBd.InsertarDatos(restauranteObj))
                {
                    MessageBox.Show($"Información del Solicitante ingresada con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Asegurate de llenar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al insertar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarSol_Click(object sender, EventArgs e)
        {
            try 
            {
                operacionesBd = new SolicitanteBD();
                bool cambioInfo = (tempCedula != txtCedSol.Text || tempNombre != txtNomSol.Text || tempApellido != txtApeSol.Text || tempEmail != txtEmailSol.Text || tempTel != txtTelSol.Text);

                Solicitante solicitante = new Solicitante(txtCedSol.Text, txtNomSol.Text, txtApeSol.Text, txtEmailSol.Text, txtTelSol.Text, int.Parse(txtIdSoli.Text));
                if (swModificarRes && cambioInfo && solicitante.ValidarPropiedades())
                {
                    bool swActualizado = operacionesBd.ModificarDato(solicitante);
                    if (swActualizado)
                    {
                        MessageBox.Show($"Información del Solicitante actualizada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else{
                    MessageBox.Show("Asegurate de llenar o modificar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception error){
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al actualizar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSol_Click(object sender, EventArgs e)
        {
            try
            {
                operacionesBd = new SolicitanteBD();

                Solicitante solicitante = new Solicitante(txtCedSol.Text, txtNomSol.Text, txtApeSol.Text, txtEmailSol.Text, txtTelSol.Text, int.Parse(txtIdSoli.Text));
                if (swModificarRes && solicitante.ValidarPropiedades())
                {
                    bool swEliminar = operacionesBd.EliminarDato(Convert.ToInt32(txtIdSoli.Text));
                    if (swEliminar)
                    {
                        MessageBox.Show($"Información del Solicitante Eliminada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al elimianr los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnModificarSol_Click(object sender, EventArgs e)
        {
            swCrud = true;
            btnModificarSol.Hide();
            txtIdSoli.Enabled = false;
            txtTituloRest.Text = "Gestión de Restaurantes";
            MostrarComponentesRestaurante();
        }

        private void btnSalirSol_Click(object sender, EventArgs e)
        {
            CargarDatosInicio();
            ResultadosSoli.Visible = true;
            txtTituloRest.Text = "Solicitudes Existentes";

            btnExportTxt.Show();
            btnModificarSol.Show();

            txtBuscarCedSol.Text = "";
            swCrud = false;
            OcultarComponentesSolicitante();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdSoli.Text = "";
            txtCedSol.Text = "";
            txtNomSol.Text = "";
            txtApeSol.Text = "";
            txtEmailSol.Text = "";
            txtTelSol.Text = "";
        }

        private void AsignarCamposTemporales()
        {
            tempCedula = txtCedSol.Text;
            tempNombre = txtNomSol.Text;
            tempApellido = txtApeSol.Text;
            tempEmail = txtEmailSol.Text;
            tempTel = txtTelSol.Text;
        }

        private void OcultarComponentesSolicitante()
        {
            btnSalirSol.Hide();
            btnBuscarSol.Hide();

            lblId.Hide();
            txtIdSoli.Hide();

            lblCedSol.Hide();
            txtCedSol.Hide();

            lblNomSol.Hide();
            txtNomSol.Hide();

            lblApeSol.Hide();
            txtApeSol.Hide();

            lblEmailSol.Hide();
            txtEmailSol.Hide();

            lblTelSol.Hide();
            txtTelSol.Hide();

            btnIngresarSol.Hide();
            btnActualizarSol.Hide();
            btnEliminarSol.Hide();
        }

        private void MostrarComponentesRestaurante()
        {
            ResultadosSoli.Visible = false;
            btnExportTxt.Hide();

            btnBuscarSol.Show();
            btnSalirSol.Show();

            lblId.Show();
            txtIdSoli.Show();

            lblCedSol.Show();
            txtCedSol.Show();

            lblNomSol.Show();
            txtNomSol.Show();

            lblApeSol.Show();
            txtApeSol.Show();

            lblEmailSol.Show();
            txtEmailSol.Show();

            lblTelSol.Show();
            txtTelSol.Show();

            btnIngresarSol.Show();

            btnActualizarSol.Show();
            btnActualizarSol.Enabled = false;

            btnEliminarSol.Show();
            btnEliminarSol.Enabled = false;
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {

        }

    }
}
