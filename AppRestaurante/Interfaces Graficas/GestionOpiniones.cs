using AppRestaurante.Entidades;
using AppRestaurante.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace AppRestaurante.Interfaces_Graficas
{
    public partial class GestionOpiniones : Form
    {
        private OpinionesBD operacionesBd;
        private DataSet dataSetRest;
        private DataSet dataSetOpi;
        private DataTable opiDataTable;
        private bool swCrud = false;
        private bool swModificarOpi = false;

        private int tempId;
        private string tempOpinion;
        private int tempCal;

        public GestionOpiniones()
        {
            InitializeComponent();
        }

        private void GestionOpiniones_Load(object sender, EventArgs e)
        {
            CargarDatosInicio();
        }


        private void CargarDatosInicio()
        {
            OcultarComponentesOpinion();
            CargarRestaurantes();
            CargarOpiniones();
        }

        private void CargarRestaurantes()
        {
            operacionesBd = new OpinionesBD();

            DataSet ds = operacionesBd.ConsultarRestaurantesDtSet();
            listRestaurantes.DataSource = ds.Tables[0];
            listRestaurantes.DisplayMember = "Nombre";
            dataSetRest = ds;
        }

        private void CargarOpiniones()
        {
            try
            {
                operacionesBd = new OpinionesBD();
                OcultarComponentesOpinion();

                opiDataTable = operacionesBd.consultarDatos();
                ResultadosOpi.DataSource = opiDataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Lo siento, ha ocurrido un error. Error:\n{error.Message} ", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarOpinionId()
        {
            try
            {
                operacionesBd = new OpinionesBD();
                OpinionCalificacion opinionCalificacion = null;

                opinionCalificacion = operacionesBd.BuscarDato(int.Parse(ResultadosOpi.CurrentCell.Value.ToString()));

                if (opinionCalificacion != null)
                {
                    txtIdOpi.Text = opinionCalificacion.Id.ToString();
                    txtOpinion.Text = opinionCalificacion.Opinion;
                    txtCalificacion.Text = opinionCalificacion.Calificacion.ToString();
                    listRestaurantes.SelectedItem = listRestaurantes.Items[opinionCalificacion.Restaurante_Id - 1];

                    btnActualizarOpi.Enabled = true;
                    btnEliminarOpi.Enabled = true;
                    btnIngresarOpi.Enabled = false;

                    swModificarOpi = true;
                    ValorTemporales(opinionCalificacion);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al insertar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresarOpi_Click(object sender, EventArgs e)
        {
            try
            {
                operacionesBd = new OpinionesBD();
                string nombre_Restaurante = listRestaurantes.Text;

                int id_restaurante = operacionesBd.ConsultarRestaurantes().Where(x => x.Nombre == nombre_Restaurante).Select(x => x.Id).FirstOrDefault();
                OpinionCalificacion opinionObj = new OpinionCalificacion(txtOpinion.Text, int.Parse(txtCalificacion.Text), id_restaurante );

                if (opinionObj.ValidarPropiedades() && operacionesBd.InsertarDatos(opinionObj))
                {
                    MessageBox.Show($"Opinion de Restaurante ingresada con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else{
                    MessageBox.Show("Asegurate de llenar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al insertar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarOpi_Click(object sender, EventArgs e)
        {
            operacionesBd = new OpinionesBD();
            try
            {   

                string nombre_Restaurante = listRestaurantes.Text;
                int id_restaurante = operacionesBd.ConsultarRestaurantes().Where(x => x.Nombre == nombre_Restaurante).Select(x => x.Id).FirstOrDefault();

                operacionesBd = new OpinionesBD();
                bool cambioInfo = (tempId != int.Parse(txtIdOpi.Text) || tempOpinion != txtOpinion.Text || tempCal != int.Parse(txtCalificacion.Text));

                OpinionCalificacion opinionObj = new OpinionCalificacion(txtOpinion.Text, int.Parse(txtCalificacion.Text), id_restaurante, int.Parse(txtIdOpi.Text));

                if (swModificarOpi && cambioInfo && opinionObj.ValidarPropiedades())
                {
                    bool swActualizado = operacionesBd.ModificarDato(opinionObj);
                    if (swActualizado)
                    {
                        MessageBox.Show($"Opinion actualizada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Asegurate de llenar o modificar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al actualizar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarOpi_Click(object sender, EventArgs e)
        {
            operacionesBd = new OpinionesBD();
            try
            {

                string nombre_Restaurante = listRestaurantes.Text;
                int id_restaurante = operacionesBd.ConsultarRestaurantes().Where(x => x.Nombre == nombre_Restaurante).Select(x => x.Id).FirstOrDefault();

                operacionesBd = new OpinionesBD();
                bool cambioInfo = (int.Parse(txtIdOpi.Text) > 0 || !string.IsNullOrEmpty(txtOpinion.Text) || int.Parse(txtCalificacion.Text) > 0);

                OpinionCalificacion opinionObj = new OpinionCalificacion(txtOpinion.Text, int.Parse(txtCalificacion.Text), id_restaurante, int.Parse(txtIdOpi.Text));

                if (swModificarOpi && cambioInfo && opinionObj.ValidarPropiedades())
                {
                    bool swEliminado = operacionesBd.EliminarDato(opinionObj.Id);
                    if (swEliminado)
                    {
                        LimpiarCampos();
                        MessageBox.Show($"Opinion eliminada correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Asegurate de llenar o modificar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al eliminar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificarOpi_Click(object sender, EventArgs e)
        {
            swCrud = true;
            btnModificarOpi.Hide();
            txtIdOpi.Enabled = false;
            MostrarComponentesOpinion();

            BuscarOpinionId();
        }

        private void btnSalirOpi_Click(object sender, EventArgs e)
        {
            CargarDatosInicio();
            OcultarComponentesOpinion();
            LimpiarCampos();
        }

        public void ValorTemporales(OpinionCalificacion opinion)
        {
            tempId = int.Parse(txtIdOpi.Text);
            tempOpinion = txtOpinion.Text;
            tempCal = int.Parse(txtCalificacion.Text);
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarOpi.Enabled = false;
            btnEliminarOpi.Enabled = false;
            btnIngresarOpi.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtIdOpi.Text = "";
            txtCalificacion.Text = "";
            txtOpinion.Text = "";
        }

        private void MostrarComponentesOpinion()
        {
            ResultadosOpi.Visible = false;
            btnExportTxt.Hide();

            btnSalirOpi.Show();
            btnLimpiar.Show();

            lblIdOpi.Show();
            txtIdOpi.Show();

            lblCalificOpi.Show();
            txtCalificacion.Show();

            listRestaurantes.Show();
            lblSelectRest.Show();

            lblOpi.Show();
            txtOpinion.Show();

            btnIngresarOpi.Show();
            btnActualizarOpi.Show();
            btnActualizarOpi.Enabled = false;
            btnEliminarOpi.Show();
            btnEliminarOpi.Enabled = false;
        }

        private void OcultarComponentesOpinion()
        {
            ResultadosOpi.Visible = true;
            btnExportTxt.Show();
            btnModificarOpi.Show();

            btnSalirOpi.Hide();
            btnLimpiar.Hide();
            listRestaurantes.Hide();

            lblIdOpi.Hide();
            txtIdOpi.Hide();

            lblCalificOpi.Hide();
            txtCalificacion.Hide();
            lblSelectRest.Hide();
            lblOpi.Hide();
            txtOpinion.Hide();

            btnIngresarOpi.Hide();
            btnActualizarOpi.Hide();
            btnEliminarOpi.Hide();

        }

        private void ResultadosOpi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
