using AppRestaurante.Entidades;
using AppRestaurante.Helper;
using System;

using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppRestaurante.Interfaces_Graficas
{
    public partial class GestionMenu : Form
    {
        private MenuBD operacionesBd;
        private DataSet dataSetRest;
        private DataSet dataSetMenu;
        private DataTable menuDataTable;

        private bool swCrud = false;
        private bool swModificarOpi = false;

        private string tempEntrada;
        private string tempFuerte;
        private string tempBebida;
        private string tempPostre;

        public GestionMenu()
        {
            InitializeComponent();
        }

        private void GestionMenu_Load(object sender, EventArgs e)
        {
            CargarDatosInicial();
        }

        private void CargarDatosInicial()
        {

            CargarRestaurantes();
            CargarMenus();
            OcultarComponentesMenu();
        }

        private void CargarRestaurantes()
        {
            operacionesBd = new MenuBD();

            DataSet ds = operacionesBd.ConsultarRestaurantesDtSet();
            listRestaurantes.DataSource = ds.Tables[0];
            listRestaurantes.DisplayMember = "Nombre";
            dataSetRest = ds;
        }

        private void CargarMenus()
        {
            try
            {
                operacionesBd = new MenuBD();
                OcultarComponentesMenu();

                menuDataTable = operacionesBd.consultarDatos();
                ResultadosMenu.DataSource = menuDataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show($"Lo siento, ha ocurrido un error. Error:\n{error.Message} ", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BuscarMenuId()
        {
            try
            {
                operacionesBd = new MenuBD();
                Entidades.Menu menu = null;

                menu = operacionesBd.BuscarDato(int.Parse(ResultadosMenu.CurrentCell.Value.ToString()));

                if (menu != null)
                {
                    txtIdMenu.Text = menu.Id.ToString();
                    txtEntMenu.Text = menu.Entrada;
                    txtFuerMenu.Text = menu.Fuerte;
                    txtBebiMenu.Text = menu.Bebida;
                    txtPosMenu.Text = menu.Postre;
                    listRestaurantes.SelectedItem = listRestaurantes.Items[menu.Restaurante_Id - 1];

                    btnActualizarMenu.Enabled = true;
                    btnEliminarMenu.Enabled = true;
                    btnIngresarMenu.Enabled = false;

                    swModificarOpi = true;
                    ValoresTemporales();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al insertar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                operacionesBd = new MenuBD();
                string nombre_Restaurante = listRestaurantes.Text;

                int id_restaurante = operacionesBd.ConsultarRestaurantes().Where(x => x.Nombre == nombre_Restaurante).Select(x => x.Id).FirstOrDefault();
                Entidades.Menu menuObj = new Entidades.Menu(txtEntMenu.Text, txtFuerMenu.Text, txtBebiMenu.Text, txtPosMenu.Text, id_restaurante);

                if (menuObj.ValidarPropiedades() && operacionesBd.InsertarDatos(menuObj))
                {
                    MessageBox.Show($"Menú de Restaurante ingresada con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asegurate de llenar todos los campos de texto para continuar. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ops! Parece que ha ocurrido un error al insertar los datos. Error:\n{error.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarMenu_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre_Restaurante = listRestaurantes.Text;
                int id_restaurante = operacionesBd.ConsultarRestaurantes().Where(x => x.Nombre == nombre_Restaurante).Select(x => x.Id).FirstOrDefault();

                operacionesBd = new MenuBD();
                bool cambioInfo = (tempEntrada != txtEntMenu.Text || tempFuerte != txtFuerMenu.Text || tempBebida != txtBebiMenu.Text || tempPostre != txtPosMenu.Text);

                Entidades.Menu menuObj = new Entidades.Menu(txtEntMenu.Text, txtFuerMenu.Text, txtBebiMenu.Text, txtPosMenu.Text, id_restaurante, int.Parse(txtIdMenu.Text));

                if (swModificarOpi && cambioInfo && menuObj.ValidarPropiedades())
                {
                    bool swActualizado = operacionesBd.ModificarDato(menuObj);
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

        private void btnEliminarMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre_Restaurante = listRestaurantes.Text;
                int id_restaurante = operacionesBd.ConsultarRestaurantes().Where(x => x.Nombre == nombre_Restaurante).Select(x => x.Id).FirstOrDefault();

                operacionesBd = new MenuBD();
                Entidades.Menu menuObj = new Entidades.Menu(txtEntMenu.Text, txtFuerMenu.Text, txtBebiMenu.Text, txtPosMenu.Text, id_restaurante, int.Parse(txtIdMenu.Text));

                if (swModificarOpi && menuObj.ValidarPropiedades())
                {
                    bool swEliminado = operacionesBd.EliminarDato(menuObj.Id);
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

        private void btnModificarMenu_Click(object sender, EventArgs e)
        {
            swCrud = true;
            btnModificarMenu.Hide();
            txtIdMenu.Enabled = false;
            MostrarComponentesMenu();
            if(ResultadosMenu.ColumnCount > 0 && ResultadosMenu.RowCount > 0) 
            {
                BuscarMenuId();
            }
            
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            CargarDatosInicial();
            OcultarComponentesMenu();
            LimpiarCampos();
        }

        private void btnLimpiarMenu_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarMenu.Enabled = false;
            btnEliminarMenu.Enabled = false;
            btnIngresarMenu.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtIdMenu.Text = "";
            txtEntMenu.Text = "";
            txtFuerMenu.Text = "";
            txtIdMenu.Text = "";
            txtBebiMenu.Text = "";
            txtPosMenu.Text = "";
        }

        private void ValoresTemporales()
        {
            tempEntrada = txtEntMenu.Text;
            tempFuerte = txtFuerMenu.Text;
            tempBebida = txtBebiMenu.Text;
            tempPostre = txtPosMenu.Text;
        }

        private void MostrarComponentesMenu()
        {
            ResultadosMenu.Visible = false;
            btnExportTxt.Hide();
            btnSalirMenu.Show();

            lblIdMenu.Show();
            txtIdMenu.Show();

            lblEntMenu.Show();
            txtEntMenu.Show();

            lblFuerMenu.Show();
            txtFuerMenu.Show();

            lblBebiMenu.Show();
            txtBebiMenu.Show();

            lblPosMenu.Show();
            txtPosMenu.Show();

            lblRestMenu.Show();
            listRestaurantes.Show();

            btnIngresarMenu.Show();
            btnActualizarMenu.Show();
            btnActualizarMenu.Enabled = false;
            btnEliminarMenu.Show();
            btnEliminarMenu.Enabled = false;
        }

        private void OcultarComponentesMenu()
        {
            ResultadosMenu.Visible = true;
            btnExportTxt.Show();
            btnModificarMenu.Show();

            btnSalirMenu.Hide();
            //btnLimpiarMenu.Hide();

            lblIdMenu.Hide();
            txtIdMenu.Hide();

            lblEntMenu.Hide();
            txtEntMenu.Hide();

            lblFuerMenu.Hide();
            txtFuerMenu.Hide();

            lblBebiMenu.Hide();
            txtBebiMenu.Hide();

            lblPosMenu.Hide();
            txtPosMenu.Hide();

            lblRestMenu.Hide();
            listRestaurantes.Hide();

            btnIngresarMenu.Hide();
            btnActualizarMenu.Hide();
            btnEliminarMenu.Hide();

        }
    }
}
