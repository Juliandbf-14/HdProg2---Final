namespace AppRestaurante.Interfaces_Graficas
{
    partial class GestionOpiniones
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
            this.listRestaurantes = new System.Windows.Forms.ListBox();
            this.txtOpinion = new System.Windows.Forms.TextBox();
            this.lblSelectRest = new System.Windows.Forms.Label();
            this.lblCalificOpi = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtIdOpi = new System.Windows.Forms.TextBox();
            this.lblIdOpi = new System.Windows.Forms.Label();
            this.btnEliminarOpi = new System.Windows.Forms.Button();
            this.btnActualizarOpi = new System.Windows.Forms.Button();
            this.btnIngresarOpi = new System.Windows.Forms.Button();
            this.ResultadosOpi = new System.Windows.Forms.DataGridView();
            this.btnSalirOpi = new System.Windows.Forms.Button();
            this.btnModificarOpi = new System.Windows.Forms.Button();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.txtTituloRest = new System.Windows.Forms.Label();
            this.lblOpi = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosOpi)).BeginInit();
            this.SuspendLayout();
            // 
            // listRestaurantes
            // 
            this.listRestaurantes.FormattingEnabled = true;
            this.listRestaurantes.ItemHeight = 16;
            this.listRestaurantes.Location = new System.Drawing.Point(141, 201);
            this.listRestaurantes.Name = "listRestaurantes";
            this.listRestaurantes.Size = new System.Drawing.Size(171, 36);
            this.listRestaurantes.TabIndex = 7;
            // 
            // txtOpinion
            // 
            this.txtOpinion.Location = new System.Drawing.Point(131, 273);
            this.txtOpinion.Multiline = true;
            this.txtOpinion.Name = "txtOpinion";
            this.txtOpinion.Size = new System.Drawing.Size(630, 96);
            this.txtOpinion.TabIndex = 8;
            // 
            // lblSelectRest
            // 
            this.lblSelectRest.AutoSize = true;
            this.lblSelectRest.Location = new System.Drawing.Point(138, 173);
            this.lblSelectRest.Name = "lblSelectRest";
            this.lblSelectRest.Size = new System.Drawing.Size(165, 16);
            this.lblSelectRest.TabIndex = 9;
            this.lblSelectRest.Text = "Seleccione el Restaurante";
            // 
            // lblCalificOpi
            // 
            this.lblCalificOpi.AutoSize = true;
            this.lblCalificOpi.Location = new System.Drawing.Point(520, 173);
            this.lblCalificOpi.Name = "lblCalificOpi";
            this.lblCalificOpi.Size = new System.Drawing.Size(76, 16);
            this.lblCalificOpi.TabIndex = 12;
            this.lblCalificOpi.Text = "Calificación";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(523, 201);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 22);
            this.txtCalificacion.TabIndex = 13;
            // 
            // txtIdOpi
            // 
            this.txtIdOpi.AcceptsReturn = true;
            this.txtIdOpi.Location = new System.Drawing.Point(200, 135);
            this.txtIdOpi.Name = "txtIdOpi";
            this.txtIdOpi.Size = new System.Drawing.Size(30, 22);
            this.txtIdOpi.TabIndex = 44;
            // 
            // lblIdOpi
            // 
            this.lblIdOpi.AutoSize = true;
            this.lblIdOpi.Location = new System.Drawing.Point(138, 138);
            this.lblIdOpi.Name = "lblIdOpi";
            this.lblIdOpi.Size = new System.Drawing.Size(20, 16);
            this.lblIdOpi.TabIndex = 43;
            this.lblIdOpi.Text = "ID";
            // 
            // btnEliminarOpi
            // 
            this.btnEliminarOpi.Location = new System.Drawing.Point(523, 388);
            this.btnEliminarOpi.Name = "btnEliminarOpi";
            this.btnEliminarOpi.Size = new System.Drawing.Size(127, 31);
            this.btnEliminarOpi.TabIndex = 41;
            this.btnEliminarOpi.Text = "Eliminar";
            this.btnEliminarOpi.UseVisualStyleBackColor = true;
            this.btnEliminarOpi.Click += new System.EventHandler(this.btnEliminarOpi_Click);
            // 
            // btnActualizarOpi
            // 
            this.btnActualizarOpi.Location = new System.Drawing.Point(362, 388);
            this.btnActualizarOpi.Name = "btnActualizarOpi";
            this.btnActualizarOpi.Size = new System.Drawing.Size(127, 31);
            this.btnActualizarOpi.TabIndex = 40;
            this.btnActualizarOpi.Text = "Actualizar";
            this.btnActualizarOpi.UseVisualStyleBackColor = true;
            this.btnActualizarOpi.Click += new System.EventHandler(this.btnActualizarOpi_Click);
            // 
            // btnIngresarOpi
            // 
            this.btnIngresarOpi.Location = new System.Drawing.Point(200, 388);
            this.btnIngresarOpi.Name = "btnIngresarOpi";
            this.btnIngresarOpi.Size = new System.Drawing.Size(127, 31);
            this.btnIngresarOpi.TabIndex = 39;
            this.btnIngresarOpi.Text = "Ingresar";
            this.btnIngresarOpi.UseVisualStyleBackColor = true;
            this.btnIngresarOpi.Click += new System.EventHandler(this.btnIngresarOpi_Click);
            // 
            // ResultadosOpi
            // 
            this.ResultadosOpi.AllowUserToAddRows = false;
            this.ResultadosOpi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadosOpi.Location = new System.Drawing.Point(95, 115);
            this.ResultadosOpi.Name = "ResultadosOpi";
            this.ResultadosOpi.RowHeadersWidth = 51;
            this.ResultadosOpi.RowTemplate.Height = 24;
            this.ResultadosOpi.Size = new System.Drawing.Size(678, 377);
            this.ResultadosOpi.TabIndex = 26;
            this.ResultadosOpi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultadosOpi_CellContentClick);
            // 
            // btnSalirOpi
            // 
            this.btnSalirOpi.Location = new System.Drawing.Point(227, 74);
            this.btnSalirOpi.Name = "btnSalirOpi";
            this.btnSalirOpi.Size = new System.Drawing.Size(85, 35);
            this.btnSalirOpi.TabIndex = 30;
            this.btnSalirOpi.Text = "Salir";
            this.btnSalirOpi.UseVisualStyleBackColor = true;
            this.btnSalirOpi.Click += new System.EventHandler(this.btnSalirOpi_Click);
            // 
            // btnModificarOpi
            // 
            this.btnModificarOpi.Location = new System.Drawing.Point(95, 74);
            this.btnModificarOpi.Name = "btnModificarOpi";
            this.btnModificarOpi.Size = new System.Drawing.Size(112, 35);
            this.btnModificarOpi.TabIndex = 29;
            this.btnModificarOpi.Text = "Modificar";
            this.btnModificarOpi.UseVisualStyleBackColor = true;
            this.btnModificarOpi.Click += new System.EventHandler(this.btnModificarOpi_Click);
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(339, 442);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(165, 31);
            this.btnExportTxt.TabIndex = 28;
            this.btnExportTxt.Text = "Exportar a Txt";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // txtTituloRest
            // 
            this.txtTituloRest.AutoSize = true;
            this.txtTituloRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloRest.Location = new System.Drawing.Point(283, 9);
            this.txtTituloRest.Name = "txtTituloRest";
            this.txtTituloRest.Size = new System.Drawing.Size(285, 36);
            this.txtTituloRest.TabIndex = 23;
            this.txtTituloRest.Text = "Buzón de Opiniones";
            this.txtTituloRest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOpi
            // 
            this.lblOpi.AutoSize = true;
            this.lblOpi.Location = new System.Drawing.Point(138, 254);
            this.lblOpi.Name = "lblOpi";
            this.lblOpi.Size = new System.Drawing.Size(53, 16);
            this.lblOpi.TabIndex = 45;
            this.lblOpi.Text = "Opinión";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(688, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // GestionOpiniones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 550);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblOpi);
            this.Controls.Add(this.txtIdOpi);
            this.Controls.Add(this.lblIdOpi);
            this.Controls.Add(this.btnEliminarOpi);
            this.Controls.Add(this.btnActualizarOpi);
            this.Controls.Add(this.btnIngresarOpi);
            this.Controls.Add(this.btnSalirOpi);
            this.Controls.Add(this.btnModificarOpi);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.txtTituloRest);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificOpi);
            this.Controls.Add(this.lblSelectRest);
            this.Controls.Add(this.txtOpinion);
            this.Controls.Add(this.listRestaurantes);
            this.Controls.Add(this.ResultadosOpi);
            this.Name = "GestionOpiniones";
            this.Text = "GestionOpiniones";
            this.Load += new System.EventHandler(this.GestionOpiniones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosOpi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRestaurantes;
        private System.Windows.Forms.TextBox txtOpinion;
        private System.Windows.Forms.Label lblSelectRest;
        private System.Windows.Forms.Label lblCalificOpi;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtIdOpi;
        private System.Windows.Forms.Label lblIdOpi;
        private System.Windows.Forms.Button btnEliminarOpi;
        private System.Windows.Forms.Button btnActualizarOpi;
        private System.Windows.Forms.Button btnIngresarOpi;
        private System.Windows.Forms.DataGridView ResultadosOpi;
        private System.Windows.Forms.Button btnSalirOpi;
        private System.Windows.Forms.Button btnModificarOpi;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Label txtTituloRest;
        private System.Windows.Forms.Label lblOpi;
        private System.Windows.Forms.Button btnLimpiar;
    }
}