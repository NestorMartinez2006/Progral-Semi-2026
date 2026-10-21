namespace parcial_progra_l
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.btnDonaciones = new System.Windows.Forms.Button();
            this.btnOfrecerAyuda = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblLogoTitulo = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUltimasPubs = new System.Windows.Forms.Label();
            this.lblVerTodas = new System.Windows.Forms.Label();
            this.cardSolicitudes = new System.Windows.Forms.Panel();
            this.lblNumSolicitudes = new System.Windows.Forms.Label();
            this.lblTextSolicitudes = new System.Windows.Forms.Label();
            this.cardOfertas = new System.Windows.Forms.Panel();
            this.lblNumOfertas = new System.Windows.Forms.Label();
            this.lblTextOfertas = new System.Windows.Forms.Label();
            this.cardDonaciones = new System.Windows.Forms.Panel();
            this.lblNumDonaciones = new System.Windows.Forms.Label();
            this.lblTextDonaciones = new System.Windows.Forms.Label();
            this.cardMascotas = new System.Windows.Forms.Panel();
            this.lblNumMascotas = new System.Windows.Forms.Label();
            this.lblTextMascotas = new System.Windows.Forms.Label();
            this.panelPerfilSuperior = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.dgvPublicaciones = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSidebar.SuspendLayout();
            this.cardSolicitudes.SuspendLayout();
            this.cardOfertas.SuspendLayout();
            this.cardDonaciones.SuspendLayout();
            this.cardMascotas.SuspendLayout();
            this.panelPerfilSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.panelSidebar.Controls.Add(this.btnCerrarSesion);
            this.panelSidebar.Controls.Add(this.btnPerfil);
            this.panelSidebar.Controls.Add(this.btnActividades);
            this.panelSidebar.Controls.Add(this.btnReportes);
            this.panelSidebar.Controls.Add(this.btnMascotas);
            this.panelSidebar.Controls.Add(this.btnDonaciones);
            this.panelSidebar.Controls.Add(this.btnOfrecerAyuda);
            this.panelSidebar.Controls.Add(this.btnSolicitudes);
            this.panelSidebar.Controls.Add(this.btnInicio);
            this.panelSidebar.Controls.Add(this.lblLogoTitulo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(260, 695);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 640);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(235, 42);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "   Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnPerfil.Location = new System.Drawing.Point(12, 475);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(235, 42);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "   Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnActividades.Location = new System.Drawing.Point(12, 420);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(235, 42);
            this.btnActividades.TabIndex = 2;
            this.btnActividades.Text = "   Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnReportes.Location = new System.Drawing.Point(12, 365);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(235, 42);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "   Reportes comunitarios";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnMascotas
            // 
            this.btnMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnMascotas.FlatAppearance.BorderSize = 0;
            this.btnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMascotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnMascotas.Location = new System.Drawing.Point(12, 310);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(235, 42);
            this.btnMascotas.TabIndex = 4;
            this.btnMascotas.Text = "   Mascotas perdidas";
            this.btnMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMascotas.UseVisualStyleBackColor = false;
            // 
            // btnDonaciones
            // 
            this.btnDonaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnDonaciones.FlatAppearance.BorderSize = 0;
            this.btnDonaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDonaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnDonaciones.Location = new System.Drawing.Point(12, 255);
            this.btnDonaciones.Name = "btnDonaciones";
            this.btnDonaciones.Size = new System.Drawing.Size(235, 42);
            this.btnDonaciones.TabIndex = 5;
            this.btnDonaciones.Text = "   Donaciones";
            this.btnDonaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonaciones.UseVisualStyleBackColor = false;
            // 
            // btnOfrecerAyuda
            // 
            this.btnOfrecerAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnOfrecerAyuda.FlatAppearance.BorderSize = 0;
            this.btnOfrecerAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfrecerAyuda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOfrecerAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnOfrecerAyuda.Location = new System.Drawing.Point(12, 200);
            this.btnOfrecerAyuda.Name = "btnOfrecerAyuda";
            this.btnOfrecerAyuda.Size = new System.Drawing.Size(235, 42);
            this.btnOfrecerAyuda.TabIndex = 6;
            this.btnOfrecerAyuda.Text = "   Ofrecer ayuda";
            this.btnOfrecerAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOfrecerAyuda.UseVisualStyleBackColor = false;
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSolicitudes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnSolicitudes.Location = new System.Drawing.Point(12, 145);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(235, 42);
            this.btnSolicitudes.TabIndex = 7;
            this.btnSolicitudes.Text = "   Solicitudes de ayuda";
            this.btnSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnInicio.Location = new System.Drawing.Point(12, 90);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(235, 42);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // lblLogoTitulo
            // 
            this.lblLogoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblLogoTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblLogoTitulo.Name = "lblLogoTitulo";
            this.lblLogoTitulo.Size = new System.Drawing.Size(220, 50);
            this.lblLogoTitulo.TabIndex = 9;
            this.lblLogoTitulo.Text = "Comunidad Conecta";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSaludo.Location = new System.Drawing.Point(295, 25);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(215, 41);
            this.lblSaludo.TabIndex = 11;
            this.lblSaludo.Text = "¡Hola, Néstor!";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(295, 75);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(502, 23);
            this.lblSubtitulo.TabIndex = 10;
            this.lblSubtitulo.Text = "Bienvenido a Comunidad Conecta. Aquí puedes ver un resumen.";
            // 
            // lblUltimasPubs
            // 
            this.lblUltimasPubs.AutoSize = true;
            this.lblUltimasPubs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUltimasPubs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblUltimasPubs.Location = new System.Drawing.Point(295, 250);
            this.lblUltimasPubs.Name = "lblUltimasPubs";
            this.lblUltimasPubs.Size = new System.Drawing.Size(264, 32);
            this.lblUltimasPubs.TabIndex = 9;
            this.lblUltimasPubs.Text = "Últimas publicaciones";
            // 
            // lblVerTodas
            // 
            this.lblVerTodas.AutoSize = true;
            this.lblVerTodas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVerTodas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblVerTodas.Location = new System.Drawing.Point(970, 650);
            this.lblVerTodas.Name = "lblVerTodas";
            this.lblVerTodas.Size = new System.Drawing.Size(234, 21);
            this.lblVerTodas.TabIndex = 0;
            this.lblVerTodas.Text = "Ver todas las publicaciones →";
            // 
            // cardSolicitudes
            // 
            this.cardSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.cardSolicitudes.Controls.Add(this.lblNumSolicitudes);
            this.cardSolicitudes.Controls.Add(this.lblTextSolicitudes);
            this.cardSolicitudes.Location = new System.Drawing.Point(295, 125);
            this.cardSolicitudes.Name = "cardSolicitudes";
            this.cardSolicitudes.Size = new System.Drawing.Size(200, 100);
            this.cardSolicitudes.TabIndex = 3;
            // 
            // lblNumSolicitudes
            // 
            this.lblNumSolicitudes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumSolicitudes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.lblNumSolicitudes.Location = new System.Drawing.Point(15, 15);
            this.lblNumSolicitudes.Name = "lblNumSolicitudes";
            this.lblNumSolicitudes.Size = new System.Drawing.Size(170, 35);
            this.lblNumSolicitudes.TabIndex = 0;
            this.lblNumSolicitudes.Text = "3";
            // 
            // lblTextSolicitudes
            // 
            this.lblTextSolicitudes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextSolicitudes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.lblTextSolicitudes.Location = new System.Drawing.Point(15, 60);
            this.lblTextSolicitudes.Name = "lblTextSolicitudes";
            this.lblTextSolicitudes.Size = new System.Drawing.Size(170, 25);
            this.lblTextSolicitudes.TabIndex = 1;
            this.lblTextSolicitudes.Text = "Solicitudes de ayuda";
            // 
            // cardOfertas
            // 
            this.cardOfertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.cardOfertas.Controls.Add(this.lblNumOfertas);
            this.cardOfertas.Controls.Add(this.lblTextOfertas);
            this.cardOfertas.Location = new System.Drawing.Point(510, 125);
            this.cardOfertas.Name = "cardOfertas";
            this.cardOfertas.Size = new System.Drawing.Size(200, 100);
            this.cardOfertas.TabIndex = 4;
            // 
            // lblNumOfertas
            // 
            this.lblNumOfertas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumOfertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblNumOfertas.Location = new System.Drawing.Point(15, 15);
            this.lblNumOfertas.Name = "lblNumOfertas";
            this.lblNumOfertas.Size = new System.Drawing.Size(170, 35);
            this.lblNumOfertas.TabIndex = 0;
            this.lblNumOfertas.Text = "2";
            // 
            // lblTextOfertas
            // 
            this.lblTextOfertas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextOfertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblTextOfertas.Location = new System.Drawing.Point(15, 60);
            this.lblTextOfertas.Name = "lblTextOfertas";
            this.lblTextOfertas.Size = new System.Drawing.Size(170, 25);
            this.lblTextOfertas.TabIndex = 1;
            this.lblTextOfertas.Text = "Ofertas de ayuda";
            // 
            // cardDonaciones
            // 
            this.cardDonaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.cardDonaciones.Controls.Add(this.lblNumDonaciones);
            this.cardDonaciones.Controls.Add(this.lblTextDonaciones);
            this.cardDonaciones.Location = new System.Drawing.Point(725, 125);
            this.cardDonaciones.Name = "cardDonaciones";
            this.cardDonaciones.Size = new System.Drawing.Size(200, 100);
            this.cardDonaciones.TabIndex = 5;
            // 
            // lblNumDonaciones
            // 
            this.lblNumDonaciones.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumDonaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblNumDonaciones.Location = new System.Drawing.Point(15, 15);
            this.lblNumDonaciones.Name = "lblNumDonaciones";
            this.lblNumDonaciones.Size = new System.Drawing.Size(170, 35);
            this.lblNumDonaciones.TabIndex = 0;
            this.lblNumDonaciones.Text = "1";
            // 
            // lblTextDonaciones
            // 
            this.lblTextDonaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextDonaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblTextDonaciones.Location = new System.Drawing.Point(15, 60);
            this.lblTextDonaciones.Name = "lblTextDonaciones";
            this.lblTextDonaciones.Size = new System.Drawing.Size(170, 25);
            this.lblTextDonaciones.TabIndex = 1;
            this.lblTextDonaciones.Text = "Donaciones";
            // 
            // cardMascotas
            // 
            this.cardMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cardMascotas.Controls.Add(this.lblNumMascotas);
            this.cardMascotas.Controls.Add(this.lblTextMascotas);
            this.cardMascotas.Location = new System.Drawing.Point(940, 125);
            this.cardMascotas.Name = "cardMascotas";
            this.cardMascotas.Size = new System.Drawing.Size(200, 100);
            this.cardMascotas.TabIndex = 6;
            // 
            // lblNumMascotas
            // 
            this.lblNumMascotas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblNumMascotas.Location = new System.Drawing.Point(15, 15);
            this.lblNumMascotas.Name = "lblNumMascotas";
            this.lblNumMascotas.Size = new System.Drawing.Size(170, 35);
            this.lblNumMascotas.TabIndex = 0;
            this.lblNumMascotas.Text = "1";
            // 
            // lblTextMascotas
            // 
            this.lblTextMascotas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblTextMascotas.Location = new System.Drawing.Point(15, 60);
            this.lblTextMascotas.Name = "lblTextMascotas";
            this.lblTextMascotas.Size = new System.Drawing.Size(170, 25);
            this.lblTextMascotas.TabIndex = 1;
            this.lblTextMascotas.Text = "Mascotas perdidas";
            // 
            // panelPerfilSuperior
            // 
            this.panelPerfilSuperior.BackColor = System.Drawing.Color.White;
            this.panelPerfilSuperior.Controls.Add(this.lblNombreUsuario);
            this.panelPerfilSuperior.Controls.Add(this.lblRolUsuario);
            this.panelPerfilSuperior.Location = new System.Drawing.Point(920, 25);
            this.panelPerfilSuperior.Name = "panelPerfilSuperior";
            this.panelPerfilSuperior.Size = new System.Drawing.Size(220, 65);
            this.panelPerfilSuperior.TabIndex = 7;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(10, 10);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(133, 21);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Néstor Martínez";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRolUsuario.Location = new System.Drawing.Point(10, 34);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblRolUsuario.TabIndex = 1;
            this.lblRolUsuario.Text = "Usuario";
            // 
            // dgvPublicaciones
            // 
            this.dgvPublicaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvPublicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colDescripcion,
            this.colFecha,
            this.colEstado});
            this.dgvPublicaciones.Location = new System.Drawing.Point(295, 300);
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            this.dgvPublicaciones.RowHeadersVisible = false;
            this.dgvPublicaciones.RowHeadersWidth = 51;
            this.dgvPublicaciones.RowTemplate.Height = 35;
            this.dgvPublicaciones.Size = new System.Drawing.Size(845, 330);
            this.dgvPublicaciones.TabIndex = 8;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.Width = 160;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Width = 365;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 140;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1244, 695);
            this.Controls.Add(this.lblVerTodas);
            this.Controls.Add(this.dgvPublicaciones);
            this.Controls.Add(this.lblUltimasPubs);
            this.Controls.Add(this.panelPerfilSuperior);
            this.Controls.Add(this.cardMascotas);
            this.Controls.Add(this.cardDonaciones);
            this.Controls.Add(this.cardOfertas);
            this.Controls.Add(this.cardSolicitudes);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comunidad Conecta";
            this.panelSidebar.ResumeLayout(false);
            this.cardSolicitudes.ResumeLayout(false);
            this.cardOfertas.ResumeLayout(false);
            this.cardDonaciones.ResumeLayout(false);
            this.cardMascotas.ResumeLayout(false);
            this.panelPerfilSuperior.ResumeLayout(false);
            this.panelPerfilSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogoTitulo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnOfrecerAyuda;
        private System.Windows.Forms.Button btnDonaciones;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel cardSolicitudes;
        private System.Windows.Forms.Label lblNumSolicitudes;
        private System.Windows.Forms.Label lblTextSolicitudes;

        private System.Windows.Forms.Panel cardOfertas;
        private System.Windows.Forms.Label lblNumOfertas;
        private System.Windows.Forms.Label lblTextOfertas;

        private System.Windows.Forms.Panel cardDonaciones;
        private System.Windows.Forms.Label lblNumDonaciones;
        private System.Windows.Forms.Label lblTextDonaciones;

        private System.Windows.Forms.Panel cardMascotas;
        private System.Windows.Forms.Label lblNumMascotas;
        private System.Windows.Forms.Label lblTextMascotas;

        private System.Windows.Forms.Panel panelPerfilSuperior;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRolUsuario;

        private System.Windows.Forms.Label lblUltimasPubs;
        private System.Windows.Forms.Label lblVerTodas;

        private System.Windows.Forms.DataGridView dgvPublicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}