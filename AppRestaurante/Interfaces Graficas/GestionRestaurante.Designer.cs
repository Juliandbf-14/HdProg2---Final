namespace AppRestaurante.Interfaces_Graficas
{
    partial class GestionRestaurante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTituloRest = new System.Windows.Forms.Label();
            this.txtBuscarRestaurante = new System.Windows.Forms.TextBox();
            this.txtNombreRest = new System.Windows.Forms.Label();
            this.ResultadosRest = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnModificarRest = new System.Windows.Forms.Button();
            this.btnSalirRest = new System.Windows.Forms.Button();
            this.lblNomRest = new System.Windows.Forms.Label();
            this.txtNomRest = new System.Windows.Forms.TextBox();
            this.txtTelRest = new System.Windows.Forms.TextBox();
            this.lblTelRest = new System.Windows.Forms.Label();
            this.txtEmailRest = new System.Windows.Forms.TextBox();
            this.lblEmailRest = new System.Windows.Forms.Label();
            this.txtDirRest = new System.Windows.Forms.TextBox();
            this.lblDirRest = new System.Windows.Forms.Label();
            this.btnIngresarRest = new System.Windows.Forms.Button();
            this.btnActualizarRest = new System.Windows.Forms.Button();
            this.btnEliminarRest = new System.Windows.Forms.Button();
            this.btnBuscarRest = new System.Windows.Forms.Button();
            this.lblIdRest = new System.Windows.Forms.Label();
            this.txtIdRest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosRest)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTituloRest
            // 
            this.txtTituloRest.AutoSize = true;
            this.txtTituloRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloRest.Location = new System.Drawing.Point(231, 18);
            this.txtTituloRest.Name = "txtTituloRest";
            this.txtTituloRest.Size = new System.Drawing.Size(355, 36);
            this.txtTituloRest.TabIndex = 0;
            this.txtTituloRest.Text = "Restaurantes Disponibles";
            this.txtTituloRest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBuscarRestaurante
            // 
            this.txtBuscarRestaurante.Location = new System.Drawing.Point(521, 116);
            this.txtBuscarRestaurante.Name = "txtBuscarRestaurante";
            this.txtBuscarRestaurante.Size = new System.Drawing.Size(181, 22);
            this.txtBuscarRestaurante.TabIndex = 1;
            this.txtBuscarRestaurante.TextChanged += new System.EventHandler(this.txtBuscarRestaurante_TextChanged);
            // 
            // txtNombreRest
            // 
            this.txtNombreRest.AutoSize = true;
            this.txtNombreRest.Location = new System.Drawing.Point(435, 119);
            this.txtNombreRest.Name = "txtNombreRest";
            this.txtNombreRest.Size = new System.Drawing.Size(80, 16);
            this.txtNombreRest.TabIndex = 2;
            this.txtNombreRest.Text = "Restaurante";
            // 
            // ResultadosRest
            // 
            this.ResultadosRest.AllowUserToAddRows = false;
            this.ResultadosRest.AllowUserToDeleteRows = false;
            this.ResultadosRest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadosRest.Location = new System.Drawing.Point(86, 146);
            this.ResultadosRest.Name = "ResultadosRest";
            this.ResultadosRest.ReadOnly = true;
            this.ResultadosRest.RowHeadersWidth = 51;
            this.ResultadosRest.RowTemplate.Height = 24;
            this.ResultadosRest.Size = new System.Drawing.Size(678, 255);
            this.ResultadosRest.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consultar Restaurantes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(299, 427);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(165, 31);
            this.btnExportTxt.TabIndex = 6;
            this.btnExportTxt.Text = "Exportar a Txt";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnModificarRest
            // 
            this.btnModificarRest.Location = new System.Drawing.Point(86, 105);
            this.btnModificarRest.Name = "btnModificarRest";
            this.btnModificarRest.Size = new System.Drawing.Size(112, 35);
            this.btnModificarRest.TabIndex = 7;
            this.btnModificarRest.Text = "Modificar";
            this.btnModificarRest.UseVisualStyleBackColor = true;
            this.btnModificarRest.Click += new System.EventHandler(this.btnModificarRest_Click);
            // 
            // btnSalirRest
            // 
            this.btnSalirRest.Location = new System.Drawing.Point(218, 105);
            this.btnSalirRest.Name = "btnSalirRest";
            this.btnSalirRest.Size = new System.Drawing.Size(85, 35);
            this.btnSalirRest.TabIndex = 8;
            this.btnSalirRest.Text = "Salir";
            this.btnSalirRest.UseVisualStyleBackColor = true;
            this.btnSalirRest.Click += new System.EventHandler(this.btnSalirRest_Click);
            // 
            // lblNomRest
            // 
            this.lblNomRest.AutoSize = true;
            this.lblNomRest.Location = new System.Drawing.Point(129, 205);
            this.lblNomRest.Name = "lblNomRest";
            this.lblNomRest.Size = new System.Drawing.Size(56, 16);
            this.lblNomRest.TabIndex = 9;
            this.lblNomRest.Text = "Nombre";
            // 
            // txtNomRest
            // 
            this.txtNomRest.Location = new System.Drawing.Point(191, 202);
            this.txtNomRest.Name = "txtNomRest";
            this.txtNomRest.Size = new System.Drawing.Size(145, 22);
            this.txtNomRest.TabIndex = 10;
            // 
            // txtTelRest
            // 
            this.txtTelRest.Location = new System.Drawing.Point(531, 270);
            this.txtTelRest.Name = "txtTelRest";
            this.txtTelRest.Size = new System.Drawing.Size(145, 22);
            this.txtTelRest.TabIndex = 12;
            // 
            // lblTelRest
            // 
            this.lblTelRest.AutoSize = true;
            this.lblTelRest.Location = new System.Drawing.Point(464, 273);
            this.lblTelRest.Name = "lblTelRest";
            this.lblTelRest.Size = new System.Drawing.Size(61, 16);
            this.lblTelRest.TabIndex = 11;
            this.lblTelRest.Text = "Teléfono";
            // 
            // txtEmailRest
            // 
            this.txtEmailRest.Location = new System.Drawing.Point(191, 270);
            this.txtEmailRest.Name = "txtEmailRest";
            this.txtEmailRest.Size = new System.Drawing.Size(145, 22);
            this.txtEmailRest.TabIndex = 14;
            // 
            // lblEmailRest
            // 
            this.lblEmailRest.AutoSize = true;
            this.lblEmailRest.Location = new System.Drawing.Point(129, 270);
            this.lblEmailRest.Name = "lblEmailRest";
            this.lblEmailRest.Size = new System.Drawing.Size(41, 16);
            this.lblEmailRest.TabIndex = 13;
            this.lblEmailRest.Text = "Email";
            // 
            // txtDirRest
            // 
            this.txtDirRest.Location = new System.Drawing.Point(531, 205);
            this.txtDirRest.Name = "txtDirRest";
            this.txtDirRest.Size = new System.Drawing.Size(145, 22);
            this.txtDirRest.TabIndex = 16;
            // 
            // lblDirRest
            // 
            this.lblDirRest.AutoSize = true;
            this.lblDirRest.Location = new System.Drawing.Point(464, 205);
            this.lblDirRest.Name = "lblDirRest";
            this.lblDirRest.Size = new System.Drawing.Size(64, 16);
            this.lblDirRest.TabIndex = 15;
            this.lblDirRest.Text = "Dirección";
            // 
            // btnIngresarRest
            // 
            this.btnIngresarRest.Location = new System.Drawing.Point(191, 353);
            this.btnIngresarRest.Name = "btnIngresarRest";
            this.btnIngresarRest.Size = new System.Drawing.Size(127, 31);
            this.btnIngresarRest.TabIndex = 17;
            this.btnIngresarRest.Text = "Ingresar";
            this.btnIngresarRest.UseVisualStyleBackColor = true;
            this.btnIngresarRest.Click += new System.EventHandler(this.btnIngresarRest_Click);
            // 
            // btnActualizarRest
            // 
            this.btnActualizarRest.Location = new System.Drawing.Point(363, 353);
            this.btnActualizarRest.Name = "btnActualizarRest";
            this.btnActualizarRest.Size = new System.Drawing.Size(127, 31);
            this.btnActualizarRest.TabIndex = 18;
            this.btnActualizarRest.Text = "Actualizar";
            this.btnActualizarRest.UseVisualStyleBackColor = true;
            this.btnActualizarRest.Click += new System.EventHandler(this.btnActualizarRest_Click);
            // 
            // btnEliminarRest
            // 
            this.btnEliminarRest.Location = new System.Drawing.Point(531, 353);
            this.btnEliminarRest.Name = "btnEliminarRest";
            this.btnEliminarRest.Size = new System.Drawing.Size(127, 31);
            this.btnEliminarRest.TabIndex = 19;
            this.btnEliminarRest.Text = "Eliminar";
            this.btnEliminarRest.UseVisualStyleBackColor = true;
            this.btnEliminarRest.Click += new System.EventHandler(this.btnEliminarRest_Click);
            // 
            // btnBuscarRest
            // 
            this.btnBuscarRest.Location = new System.Drawing.Point(708, 112);
            this.btnBuscarRest.Name = "btnBuscarRest";
            this.btnBuscarRest.Size = new System.Drawing.Size(65, 31);
            this.btnBuscarRest.TabIndex = 20;
            this.btnBuscarRest.Text = "Buscar";
            this.btnBuscarRest.UseVisualStyleBackColor = true;
            this.btnBuscarRest.Click += new System.EventHandler(this.btnBuscarRest_Click);
            // 
            // lblIdRest
            // 
            this.lblIdRest.AutoSize = true;
            this.lblIdRest.Location = new System.Drawing.Point(129, 169);
            this.lblIdRest.Name = "lblIdRest";
            this.lblIdRest.Size = new System.Drawing.Size(20, 16);
            this.lblIdRest.TabIndex = 21;
            this.lblIdRest.Text = "ID";
            // 
            // txtIdRest
            // 
            this.txtIdRest.Location = new System.Drawing.Point(191, 166);
            this.txtIdRest.Name = "txtIdRest";
            this.txtIdRest.Size = new System.Drawing.Size(30, 22);
            this.txtIdRest.TabIndex = 22;
            // 
            // GestionRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.txtIdRest);
            this.Controls.Add(this.lblIdRest);
            this.Controls.Add(this.btnBuscarRest);
            this.Controls.Add(this.btnEliminarRest);
            this.Controls.Add(this.btnActualizarRest);
            this.Controls.Add(this.btnIngresarRest);
            this.Controls.Add(this.txtDirRest);
            this.Controls.Add(this.lblDirRest);
            this.Controls.Add(this.txtEmailRest);
            this.Controls.Add(this.lblEmailRest);
            this.Controls.Add(this.txtTelRest);
            this.Controls.Add(this.lblTelRest);
            this.Controls.Add(this.txtNomRest);
            this.Controls.Add(this.lblNomRest);
            this.Controls.Add(this.ResultadosRest);
            this.Controls.Add(this.btnSalirRest);
            this.Controls.Add(this.btnModificarRest);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreRest);
            this.Controls.Add(this.txtBuscarRestaurante);
            this.Controls.Add(this.txtTituloRest);
            this.Name = "GestionRestaurante";
            this.Text = "GestionRestaurante";
            this.Load += new System.EventHandler(this.GestionRestaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosRest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloRest;
        private System.Windows.Forms.TextBox txtBuscarRestaurante;
        private System.Windows.Forms.Label txtNombreRest;
        private System.Windows.Forms.DataGridView ResultadosRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnModificarRest;
        private System.Windows.Forms.Button btnSalirRest;
        private System.Windows.Forms.Label lblNomRest;
        private System.Windows.Forms.TextBox txtNomRest;
        private System.Windows.Forms.TextBox txtTelRest;
        private System.Windows.Forms.Label lblTelRest;
        private System.Windows.Forms.TextBox txtEmailRest;
        private System.Windows.Forms.Label lblEmailRest;
        private System.Windows.Forms.TextBox txtDirRest;
        private System.Windows.Forms.Label lblDirRest;
        private System.Windows.Forms.Button btnIngresarRest;
        private System.Windows.Forms.Button btnActualizarRest;
        private System.Windows.Forms.Button btnEliminarRest;
        private System.Windows.Forms.Button btnBuscarRest;
        private System.Windows.Forms.Label lblIdRest;
        private System.Windows.Forms.TextBox txtIdRest;
    }
}