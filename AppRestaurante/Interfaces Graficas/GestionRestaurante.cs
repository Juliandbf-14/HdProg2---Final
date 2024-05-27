using AppRestaurante.Entidades;
using AppRestaurante.Helper;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AppRestaurante.Interfaces_Graficas
{
    public partial class GestionRestaurante : Form
    {
        private RestauranteBD operacionesBd;
        private DataTable restDataTable = new DataTable();

        private Stream myStream;

        private bool swCrud = false;
        private bool swModificarRes = false;

        private string tempNombre = "";
        private string tempDireccion = "";
        private string tempEmail = "";
        private string tempTel = "";

        private int counter = 0;
        private string line;
        OpenFileDialog openFileDialog = null;
        ExportDataFile archivo;

        public GestionRestaurante()
        {
            InitializeComponent();
        }

        private void GestionRestaurante_Load(object sender, System.EventArgs e)
        {
            CargarDatosInicio();
        }

        private void CargarDatosInicio()
        {
            try
            {
                operacionesBd = new RestauranteBD();
                OcultarComponentesRestaurante();

                restDataTable = operacionesBd.consultarDatos();
                ResultadosRest.DataSource = restDataTable;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Lo siento, ha ocurrido un error ", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region CRUD Restaurante
        private void txtBuscarRestaurante_TextChanged(object sender, System.EventArgs e)
        {   
            if(!swCrud)
            {
                DataView restauranteBusqueda = restDataTable.DefaultView;
                restauranteBusqueda.RowFilter = $"Nombre LIKE '%{txtBuscarRestaurante.Text}%'";
            }
        }
        private void btnBuscarRest_Click(object sender, EventArgs e)
        {   
            if (swCrud)
            {
                operacionesBd = new RestauranteBD();
                Restaurante restaurante = null;
                restaurante = operacionesBd.BuscarDato(txtBuscarRestaurante.Text);

                if (restaurante != null)
                {
                    txtIdRest.Text = Convert.ToString(restaurante.Id);
                    txtNomRest.Text = restaurante.Nombre;
                    txtDirRest.Text = restaurante.Direccion;
                    txtEmailRest.Text = restaurante.Email;
                    txtTelRest.Text = restaurante.Telefono;

                    swModificarRes = true;
                    btnActualizarRest.Enabled = true;
                    btnEliminarRest.Enabled = true;
                    txtIdRest.Enabled = false;
                    AsignarCamposTemporales();
                } else
                {
                    MessageBox.Show($"Parece que el Restaurante que buscas no existe, revisa el nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnIngresarRest_Click(object sender, System.EventArgs e)
        {
            try
            {
                operacionesBd = new RestauranteBD();
                Restaurante restauranteObj = new Restaurante(txtNomRest.Text, txtDirRest.Text, txtEmailRest.Text, txtTelRest.Text);

                if (restauranteObj.ValidarPropiedades() && operacionesBd.InsertarDatos(restauranteObj))
                {
                    MessageBox.Show($"Información del Restaurante ingresada con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnActualizarRest_Click(object sender, EventArgs e)
        {
            try 
            {
                operacionesBd = new RestauranteBD();
                bool cambioInfo = (tempNombre != txtNomRest.Text || tempDireccion != txtDirRest.Text || tempEmail != txtEmailRest.Text || tempTel != txtTelRest.Text);

                Restaurante restaurante = new Restaurante(txtNomRest.Text, txtDirRest.Text, txtEmailRest.Text, txtTelRest.Text, Convert.ToInt32(txtIdRest.Text));
                if (swModificarRes && cambioInfo && restaurante.ValidarPropiedades())
                {
                    bool swActualizado = operacionesBd.ModificarDato(restaurante);
                    if (swActualizado)
                    {
                        MessageBox.Show($"Información del Restaurante actualizada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else{
                    MessageBox.Show("Asegurate de llenar o modificar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception error){
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al actualizar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarRest_Click(object sender, EventArgs e)
        {
            try
            {
                operacionesBd = new RestauranteBD();
                bool cambioInfo = (tempNombre != txtNomRest.Text || tempDireccion != txtDirRest.Text || tempEmail != txtEmailRest.Text || tempTel != txtTelRest.Text);

                Restaurante restaurante = new Restaurante(txtNomRest.Text, txtDirRest.Text, txtEmailRest.Text, txtTelRest.Text, Convert.ToInt32(txtIdRest.Text));
                if (swModificarRes && cambioInfo && restaurante.ValidarPropiedades())
                {
                    bool swEliminar = operacionesBd.EliminarDato(Convert.ToInt32(txtIdRest.Text));
                    if (swEliminar)
                    {
                        MessageBox.Show($"Información del Restaurante Eliminada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch (Exception error){
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al elimianr los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        #endregion

        private void btnExportTxt_Click(object sender, System.EventArgs e)
        {
            string filename;
            const string filepath = "ListaRestaurantes.txt";
            archivo = new ExportDataFile();
            filename = archivo.validarCargaArchivo(openFileDialog, filepath);
            if(filename != "") 
            {
                archivo.ExportarTxt(filename, ResultadosRest);
                MessageBox.Show("Información de Restaurantes exportada a archivo de texto de forma exitosa", "Operación Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarRest_Click(object sender, System.EventArgs e)
        {
            swCrud = true;
            btnModificarRest.Hide();
            txtIdRest.Enabled = false;
            txtTituloRest.Text = "Gestión de Restaurantes";
            MostrarComponentesRestaurante();
        }

        private void btnSalirRest_Click(object sender, System.EventArgs e)
        {
            CargarDatosInicio();
            ResultadosRest.Visible = true;
            txtTituloRest.Text = "Restaurantes Disponibles";
            
            btnExportTxt.Show();
            btnModificarRest.Show();

            txtBuscarRestaurante.Text = "";
            swCrud = false;
            OcultarComponentesRestaurante();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdRest.Text = "";

            txtNomRest.Text = "";

            txtDirRest.Text = "";

            txtEmailRest.Text = "";

            txtTelRest.Text = "";
        }

        private void AsignarCamposTemporales()
        {
            string tempNombre = txtNomRest.Text;
            string tempDireccion = txtDirRest.Text;
            string tempEmail = txtEmailRest.Text;
            string tempTel = txtTelRest.Text;
        }

        private void OcultarComponentesRestaurante()
        {
            btnSalirRest.Hide();
            btnBuscarRest.Hide();

            lblIdRest.Hide();
            txtIdRest.Hide();
            
            lblNomRest.Hide();
            txtNomRest.Hide();

            lblDirRest.Hide();
            txtDirRest.Hide();

            lblEmailRest.Hide();
            txtEmailRest.Hide();

            lblTelRest.Hide();
            txtTelRest.Hide();

            btnIngresarRest.Hide();
            btnActualizarRest.Hide();
            btnEliminarRest.Hide();
        }
        
        private void MostrarComponentesRestaurante()
        {
            ResultadosRest.Visible = false;
            btnExportTxt.Hide();

            btnBuscarRest.Show();
            btnSalirRest.Show();

            lblIdRest.Show();
            txtIdRest.Show();

            lblNomRest.Show();
            lblDirRest.Show();
            lblEmailRest.Show();
            lblTelRest.Show();

            txtNomRest.Show();
            txtDirRest.Show();
            txtEmailRest.Show();
            txtTelRest.Show();

            btnIngresarRest.Show();

            btnActualizarRest.Show();
            btnActualizarRest.Enabled = false;

            btnEliminarRest.Show();
            btnEliminarRest.Enabled = false;
        }
    }
}
