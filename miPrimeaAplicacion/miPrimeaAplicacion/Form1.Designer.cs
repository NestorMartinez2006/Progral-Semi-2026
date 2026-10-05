namespace miPrimeaAplicacion
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
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.idAlumno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.lblnRegistrosAlumno = new System.Windows.Forms.Label();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbEdicionAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.lblId);
            this.grbDatosAlumno.Controls.Add(this.idAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigo);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombre);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccion);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTel);
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Location = new System.Drawing.Point(16, 15);
            this.grbDatosAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatosAlumno.Size = new System.Drawing.Size(467, 295);
            this.grbDatosAlumno.TabIndex = 0;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "DATOS";
            this.grbDatosAlumno.Enter += new System.EventHandler(this.grbDatosAlumno_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 37);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(133, 37);
            this.idAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(14, 16);
            this.idAlumno.TabIndex = 1;
            this.idAlumno.Text = "1";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 78);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(133, 74);
            this.txtCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(159, 22);
            this.txtCodigoAlumno.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 127);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(133, 123);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(292, 22);
            this.txtNombreAlumno.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 176);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 16);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "DIRECCION:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(133, 172);
            this.txtDireccionAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(292, 22);
            this.txtDireccionAlumno.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(27, 225);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(35, 16);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "TEL:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(133, 222);
            this.txtTelefonoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(159, 22);
            this.txtTelefonoAlumno.TabIndex = 9;
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistrosAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(16, 320);
            this.grbNavegacionAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(293, 74);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(13, 25);
            this.btnPrimeroAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(43, 34);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(64, 25);
            this.btnAnteriorAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(43, 34);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // lblnRegistrosAlumno
            // 
            this.lblnRegistrosAlumno.AutoSize = true;
            this.lblnRegistrosAlumno.Location = new System.Drawing.Point(115, 34);
            this.lblnRegistrosAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnRegistrosAlumno.Name = "lblnRegistrosAlumno";
            this.lblnRegistrosAlumno.Size = new System.Drawing.Size(43, 16);
            this.lblnRegistrosAlumno.TabIndex = 2;
            this.lblnRegistrosAlumno.Text = "1 de 1";
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(180, 25);
            this.btnSiguienteAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(43, 34);
            this.btnSiguienteAlumno.TabIndex = 3;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Location = new System.Drawing.Point(231, 25);
            this.btnUltimoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(43, 34);
            this.btnUltimoAlumno.TabIndex = 4;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(320, 320);
            this.grbEdicionAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicionAlumno.Size = new System.Drawing.Size(373, 74);
            this.grbEdicionAlumno.TabIndex = 2;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAlumno.Location = new System.Drawing.Point(13, 22);
            this.btnAgregarAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(107, 39);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Nuevo";
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarAlumno.Location = new System.Drawing.Point(128, 22);
            this.btnModificarAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(112, 39);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarAlumno.Location = new System.Drawing.Point(248, 22);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(112, 39);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(507, 15);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(146, 17);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Busqueda Alumnos";
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(507, 37);
            this.txtBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(505, 22);
            this.txtBuscarAlumnos.TabIndex = 2;
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.AllowUserToAddRows = false;
            this.grdAlumnos.AllowUserToDeleteRows = false;
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdAlumnos.Location = new System.Drawing.Point(507, 74);
            this.grdAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.ReadOnly = true;
            this.grdAlumnos.RowHeadersWidth = 51;
            this.grdAlumnos.Size = new System.Drawing.Size(507, 236);
            this.grdAlumnos.TabIndex = 1;
            this.grdAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAlumnos_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idAlumno";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 420);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.grdAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRACION DE ALUMNOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbEdicionAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Label lblnRegistrosAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}