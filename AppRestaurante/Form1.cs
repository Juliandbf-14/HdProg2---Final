using AppRestaurante.Helper;
using AppRestaurante.Interfaces_Graficas;
using System;
using System.Windows.Forms;

namespace AppRestaurante
{
    public partial class Form1 : Form
    {
        private GestionRestaurante forma_Rest;
        private GestionOpiniones forma_Opi;
        private GestionSolicitante forma_Soli;
        private GestionMenu forma_Menu;

        public Form1()
        {
            InitializeComponent();
        }

        private void restaurantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #region Modulo RESTAURANTE
        private void buscarRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma_Rest == null)
            {
                this.label1.Hide();
                forma_Rest = new GestionRestaurante();
                forma_Rest.MdiParent = this;
                forma_Rest.FormClosed += new FormClosedEventHandler(CerrarFormaRestaurante);
                forma_Rest.Show();
            }
        }

        void CerrarFormaRestaurante(object sender, FormClosedEventArgs e)
        {
            forma_Rest = null;
            this.label1.Show();
        }
        #endregion

        #region Módulo OPINIONES
        private void opinionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma_Opi == null)
            {
                this.label1.Hide();
                forma_Opi = new GestionOpiniones();
                forma_Opi.MdiParent = this;
                forma_Opi.FormClosed += new FormClosedEventHandler(CerrarFormaOpiniones);
                forma_Opi.Show();
            }
        }

        void CerrarFormaOpiniones(object sender, FormClosedEventArgs e)
        {
            forma_Opi = null;
            this.label1.Show();
        }
        #endregion

        private void solicitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma_Soli == null)
            {
                this.label1.Hide();
                forma_Soli = new GestionSolicitante();
                forma_Soli.MdiParent = this;
                forma_Soli.FormClosed += new FormClosedEventHandler(CerrarFormaOpiniones);
                forma_Soli.Show();
            }
        }

        void CerrarFormaSolicitudes(object sender, FormClosedEventArgs e)
        {
            forma_Soli = null;
            this.label1.Show();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma_Menu == null)
            {
                this.label1.Hide();
                forma_Menu = new GestionMenu();
                forma_Menu.MdiParent = this;
                forma_Menu.FormClosed += new FormClosedEventHandler(CerrarFormaMenu);
                forma_Menu.Show();
            }
        }

        void CerrarFormaMenu(object sender, FormClosedEventArgs e)
        {
            forma_Menu = null;
            this.label1.Show();
        }
    }
}
