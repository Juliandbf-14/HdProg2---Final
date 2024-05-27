namespace AppRestaurante.Interfaces_Graficas
{
    partial class GestionSolicitante
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
            this.btnEliminarSol = new System.Windows.Forms.Button();
            this.btnActualizarSol = new System.Windows.Forms.Button();
            this.btnIngresarSol = new System.Windows.Forms.Button();
            this.txtNomSol = new System.Windows.Forms.TextBox();
            this.lblNomSol = new System.Windows.Forms.Label();
            this.txtApeSol = new System.Windows.Forms.TextBox();
            this.lblApeSol = new System.Windows.Forms.Label();
            this.txtTelRest = new System.Windows.Forms.TextBox();
            this.lblEmailSol = new System.Windows.Forms.Label();
            this.txtCedSol = new System.Windows.Forms.TextBox();
            this.lblCedSol = new System.Windows.Forms.Label();
            this.ResultadosRest = new System.Windows.Forms.DataGridView();
            this.btnSalirSol = new System.Windows.Forms.Button();
            this.btnModificarSol = new System.Windows.Forms.Button();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreRest = new System.Windows.Forms.Label();
            this.txtBuscarCedSol = new System.Windows.Forms.TextBox();
            this.txtTituloRest = new System.Windows.Forms.Label();
            this.lblTelSol = new System.Windows.Forms.Label();
            this.txtTelSol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosRest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarSol
            // 
            this.btnEliminarSol.Location = new System.Drawing.Point(612, 425);
            this.btnEliminarSol.Name = "btnEliminarSol";
            this.btnEliminarSol.Size = new System.Drawing.Size(127, 31);
            this.btnEliminarSol.TabIndex = 57;
            this.btnEliminarSol.Text = "Eliminar";
            this.btnEliminarSol.UseVisualStyleBackColor = true;
            this.btnEliminarSol.Click += new System.EventHandler(this.btnEliminarRest_Click);
            // 
            // btnActualizarSol
            // 
            this.btnActualizarSol.Location = new System.Drawing.Point(402, 425);
            this.btnActualizarSol.Name = "btnActualizarSol";
            this.btnActualizarSol.Size = new System.Drawing.Size(127, 31);
            this.btnActualizarSol.TabIndex = 56;
            this.btnActualizarSol.Text = "Actualizar";
            this.btnActualizarSol.UseVisualStyleBackColor = true;
            // 
            // btnIngresarSol
            // 
            this.btnIngresarSol.Location = new System.Drawing.Point(187, 425);
            this.btnIngresarSol.Name = "btnIngresarSol";
            this.btnIngresarSol.Size = new System.Drawing.Size(127, 31);
            this.btnIngresarSol.TabIndex = 55;
            this.btnIngresarSol.Text = "Ingresar";
            this.btnIngresarSol.UseVisualStyleBackColor = true;
            // 
            // txtNomSol
            // 
            this.txtNomSol.Location = new System.Drawing.Point(187, 268);
            this.txtNomSol.Name = "txtNomSol";
            this.txtNomSol.Size = new System.Drawing.Size(145, 22);
            this.txtNomSol.TabIndex = 54;
            // 
            // lblNomSol
            // 
            this.lblNomSol.AutoSize = true;
            this.lblNomSol.Location = new System.Drawing.Point(109, 268);
            this.lblNomSol.Name = "lblNomSol";
            this.lblNomSol.Size = new System.Drawing.Size(56, 16);
            this.lblNomSol.TabIndex = 53;
            this.lblNomSol.Text = "Nombre";
            // 
            // txtApeSol
            // 
            this.txtApeSol.Location = new System.Drawing.Point(187, 321);
            this.txtApeSol.Name = "txtApeSol";
            this.txtApeSol.Size = new System.Drawing.Size(145, 22);
            this.txtApeSol.TabIndex = 52;
            // 
            // lblApeSol
            // 
            this.lblApeSol.AutoSize = true;
            this.lblApeSol.Location = new System.Drawing.Point(109, 321);
            this.lblApeSol.Name = "lblApeSol";
            this.lblApeSol.Size = new System.Drawing.Size(57, 16);
            this.lblApeSol.TabIndex = 51;
            this.lblApeSol.Text = "Apellido";
            // 
            // txtTelRest
            // 
            this.txtTelRest.Location = new System.Drawing.Point(594, 216);
            this.txtTelRest.Name = "txtTelRest";
            this.txtTelRest.Size = new System.Drawing.Size(145, 22);
            this.txtTelRest.TabIndex = 50;
            // 
            // lblEmailSol
            // 
            this.lblEmailSol.AutoSize = true;
            this.lblEmailSol.Location = new System.Drawing.Point(511, 219);
            this.lblEmailSol.Name = "lblEmailSol";
            this.lblEmailSol.Size = new System.Drawing.Size(41, 16);
            this.lblEmailSol.TabIndex = 49;
            this.lblEmailSol.Text = "Email";
            // 
            // txtCedSol
            // 
            this.txtCedSol.Location = new System.Drawing.Point(187, 213);
            this.txtCedSol.Name = "txtCedSol";
            this.txtCedSol.Size = new System.Drawing.Size(145, 22);
            this.txtCedSol.TabIndex = 48;
            // 
            // lblCedSol
            // 
            this.lblCedSol.AutoSize = true;
            this.lblCedSol.Location = new System.Drawing.Point(109, 216);
            this.lblCedSol.Name = "lblCedSol";
            this.lblCedSol.Size = new System.Drawing.Size(50, 16);
            this.lblCedSol.TabIndex = 47;
            this.lblCedSol.Text = "Cédula";
            // 
            // ResultadosRest
            // 
            this.ResultadosRest.AllowUserToAddRows = false;
            this.ResultadosRest.AllowUserToDeleteRows = false;
            this.ResultadosRest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadosRest.Location = new System.Drawing.Point(55, 166);
            this.ResultadosRest.Name = "ResultadosRest";
            this.ResultadosRest.ReadOnly = true;
            this.ResultadosRest.RowHeadersWidth = 51;
            this.ResultadosRest.RowTemplate.Height = 24;
            this.ResultadosRest.Size = new System.Drawing.Size(758, 302);
            this.ResultadosRest.TabIndex = 42;
            // 
            // btnSalirSol
            // 
            this.btnSalirSol.Location = new System.Drawing.Point(220, 115);
            this.btnSalirSol.Name = "btnSalirSol";
            this.btnSalirSol.Size = new System.Drawing.Size(85, 35);
            this.btnSalirSol.TabIndex = 46;
            this.btnSalirSol.Text = "Salir";
            this.btnSalirSol.UseVisualStyleBackColor = true;
            // 
            // btnModificarSol
            // 
            this.btnModificarSol.Location = new System.Drawing.Point(55, 115);
            this.btnModificarSol.Name = "btnModificarSol";
            this.btnModificarSol.Size = new System.Drawing.Size(112, 35);
            this.btnModificarSol.TabIndex = 45;
            this.btnModificarSol.Text = "Modificar";
            this.btnModificarSol.UseVisualStyleBackColor = true;
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(322, 518);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(165, 31);
            this.btnExportTxt.TabIndex = 44;
            this.btnExportTxt.Text = "Exportar a Txt";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Consultar Solictante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreRest
            // 
            this.txtNombreRest.AutoSize = true;
            this.txtNombreRest.Location = new System.Drawing.Point(558, 132);
            this.txtNombreRest.Name = "txtNombreRest";
            this.txtNombreRest.Size = new System.Drawing.Size(50, 16);
            this.txtNombreRest.TabIndex = 41;
            this.txtNombreRest.Text = "Cédula";
            // 
            // txtBuscarCedSol
            // 
            this.txtBuscarCedSol.Location = new System.Drawing.Point(632, 129);
            this.txtBuscarCedSol.Name = "txtBuscarCedSol";
            this.txtBuscarCedSol.Size = new System.Drawing.Size(181, 22);
            this.txtBuscarCedSol.TabIndex = 40;
            // 
            // txtTituloRest
            // 
            this.txtTituloRest.AutoSize = true;
            this.txtTituloRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloRest.Location = new System.Drawing.Point(265, 9);
            this.txtTituloRest.Name = "txtTituloRest";
            this.txtTituloRest.Size = new System.Drawing.Size(264, 36);
            this.txtTituloRest.TabIndex = 39;
            this.txtTituloRest.Text = "Gestión Solicitante";
            this.txtTituloRest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTelSol
            // 
            this.lblTelSol.AutoSize = true;
            this.lblTelSol.Location = new System.Drawing.Point(511, 268);
            this.lblTelSol.Name = "lblTelSol";
            this.lblTelSol.Size = new System.Drawing.Size(61, 16);
            this.lblTelSol.TabIndex = 58;
            this.lblTelSol.Text = "Teléfono";
            // 
            // txtTelSol
            // 
            this.txtTelSol.Location = new System.Drawing.Point(594, 268);
            this.txtTelSol.Name = "txtTelSol";
            this.txtTelSol.Size = new System.Drawing.Size(145, 22);
            this.txtTelSol.TabIndex = 59;
            // 
            // GestionSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 554);
            this.Controls.Add(this.txtTelSol);
            this.Controls.Add(this.lblTelSol);
            this.Controls.Add(this.btnEliminarSol);
            this.Controls.Add(this.btnActualizarSol);
            this.Controls.Add(this.btnIngresarSol);
            this.Controls.Add(this.txtNomSol);
            this.Controls.Add(this.lblNomSol);
            this.Controls.Add(this.txtApeSol);
            this.Controls.Add(this.lblApeSol);
            this.Controls.Add(this.txtTelRest);
            this.Controls.Add(this.lblEmailSol);
            this.Controls.Add(this.txtCedSol);
            this.Controls.Add(this.lblCedSol);
            this.Controls.Add(this.ResultadosRest);
            this.Controls.Add(this.btnSalirSol);
            this.Controls.Add(this.btnModificarSol);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreRest);
            this.Controls.Add(this.txtBuscarCedSol);
            this.Controls.Add(this.txtTituloRest);
            this.Name = "GestionSolicitante";
            this.Text = "GestionSolicitante";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosRest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarSol;
        private System.Windows.Forms.Button btnActualizarSol;
        private System.Windows.Forms.Button btnIngresarSol;
        private System.Windows.Forms.TextBox txtNomSol;
        private System.Windows.Forms.Label lblNomSol;
        private System.Windows.Forms.TextBox txtApeSol;
        private System.Windows.Forms.Label lblApeSol;
        private System.Windows.Forms.TextBox txtTelRest;
        private System.Windows.Forms.Label lblEmailSol;
        private System.Windows.Forms.TextBox txtCedSol;
        private System.Windows.Forms.Label lblCedSol;
        private System.Windows.Forms.DataGridView ResultadosRest;
        private System.Windows.Forms.Button btnSalirSol;
        private System.Windows.Forms.Button btnModificarSol;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtNombreRest;
        private System.Windows.Forms.TextBox txtBuscarCedSol;
        private System.Windows.Forms.Label txtTituloRest;
        private System.Windows.Forms.Label lblTelSol;
        private System.Windows.Forms.TextBox txtTelSol;
    }
}