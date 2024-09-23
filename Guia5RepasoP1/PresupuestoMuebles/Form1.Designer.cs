namespace PresupuestoMuebles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.btnIniciarPresp = new System.Windows.Forms.Button();
            this.btnCerrarPres = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecioB = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.cmbProductos);
            this.groupBox1.Controls.Add(this.btnCerrarPres);
            this.groupBox1.Controls.Add(this.btnIniciarPresp);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.btnAgregar);
            this.gbProducto.Controls.Add(this.tbCodigo);
            this.gbProducto.Controls.Add(this.tbAncho);
            this.gbProducto.Controls.Add(this.tbGrosor);
            this.gbProducto.Controls.Add(this.tbLargo);
            this.gbProducto.Controls.Add(this.tbPrecioB);
            this.gbProducto.Controls.Add(this.label7);
            this.gbProducto.Controls.Add(this.label6);
            this.gbProducto.Controls.Add(this.label5);
            this.gbProducto.Controls.Add(this.label4);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Location = new System.Drawing.Point(339, 12);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(331, 176);
            this.gbProducto.TabIndex = 1;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            this.gbProducto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(64, 27);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(226, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(64, 56);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(226, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // btnIniciarPresp
            // 
            this.btnIniciarPresp.Location = new System.Drawing.Point(37, 114);
            this.btnIniciarPresp.Name = "btnIniciarPresp";
            this.btnIniciarPresp.Size = new System.Drawing.Size(94, 62);
            this.btnIniciarPresp.TabIndex = 4;
            this.btnIniciarPresp.Text = "Iniciar Presupuesto";
            this.btnIniciarPresp.UseVisualStyleBackColor = true;
            this.btnIniciarPresp.Click += new System.EventHandler(this.btnIniciarPresp_Click);
            // 
            // btnCerrarPres
            // 
            this.btnCerrarPres.Location = new System.Drawing.Point(177, 114);
            this.btnCerrarPres.Name = "btnCerrarPres";
            this.btnCerrarPres.Size = new System.Drawing.Size(98, 62);
            this.btnCerrarPres.TabIndex = 4;
            this.btnCerrarPres.Text = "Cerrar Presupuesto";
            this.btnCerrarPres.UseVisualStyleBackColor = true;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(10, 234);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(148, 21);
            this.cmbProductos.TabIndex = 5;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(164, 232);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(111, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ancho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Largo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Grosor";
            // 
            // tbPrecioB
            // 
            this.tbPrecioB.Location = new System.Drawing.Point(58, 30);
            this.tbPrecioB.Name = "tbPrecioB";
            this.tbPrecioB.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioB.TabIndex = 1;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(58, 59);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(100, 20);
            this.tbAncho.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(59, 107);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(225, 30);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(100, 20);
            this.tbLargo.TabIndex = 1;
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(225, 60);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(100, 20);
            this.tbGrosor.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(188, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(359, 244);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(139, 42);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(523, 244);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(139, 42);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 331);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.Button btnCerrarPres;
        public System.Windows.Forms.Button btnIniciarPresp;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox tbAncho;
        public System.Windows.Forms.TextBox tbGrosor;
        public System.Windows.Forms.TextBox tbLargo;
        public System.Windows.Forms.TextBox tbPrecioB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.ComboBox cmbProductos;
        public System.Windows.Forms.GroupBox gbProducto;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbNombre;
    }
}

