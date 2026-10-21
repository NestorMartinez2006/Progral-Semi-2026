namespace parcial_progra_l
{
    partial class inicio
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

            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.lblSubtituloPrincipal = new System.Windows.Forms.Label();

            // Tarjetas del menú principal
            this.cardSolicitudes = new System.Windows.Forms.Panel();
            this.lblTextSolicitudes = new System.Windows.Forms.Label();

            this.cardOfrecer = new System.Windows.Forms.Panel();
            this.lblTextOfrecer = new System.Windows.Forms.Label();

            this.cardDonaciones = new System.Windows.Forms.Panel();
            this.lblTextDonaciones = new System.Windows.Forms.Label();

            this.cardMascotas = new System.Windows.Forms.Panel();
            this.lblTextMascotas = new System.Windows.Forms.Label();

            this.cardReportes = new System.Windows.Forms.Panel();
            this.lblTextReportes = new System.Windows.Forms.Label();

            this.cardActividades = new System.Windows.Forms.Panel();
            this.lblTextActividades = new System.Windows.Forms.Label();

            this.cardPerfil = new System.Windows.Forms.Panel();
            this.lblTextPerfil = new System.Windows.Forms.Label();

            this.panelSidebar.SuspendLayout();
            this.cardSolicitudes.SuspendLayout();
            this.cardOfrecer.SuspendLayout();
            this.cardDonaciones.SuspendLayout();
            this.cardMascotas.SuspendLayout();
            this.cardReportes.SuspendLayout();
            this.cardActividades.SuspendLayout();
            this.cardPerfil.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
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
            this.panelSidebar.Size = new System.Drawing.Size(260, 720);
            this.panelSidebar.TabIndex = 0;

            // 
            // lblLogoTitulo
            // 
            this.lblLogoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogoTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblLogoTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblLogoTitulo.Name = "lblLogoTitulo";
            this.lblLogoTitulo.Size = new System.Drawing.Size(220, 50);
            this.lblLogoTitulo.Text = "Comunidad Conecta";

            // 
            // btnInicio (Activo)
            // 
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.Location = new System.Drawing.Point(12, 90);
            this.btnInicio.Size = new System.Drawing.Size(235, 42);
            this.btnInicio.UseVisualStyleBackColor = false;

            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.Text = "   Solicitudes de ayuda";
            this.btnSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitudes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSolicitudes.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnSolicitudes.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnSolicitudes.Location = new System.Drawing.Point(12, 145);
            this.btnSolicitudes.Size = new System.Drawing.Size(235, 42);
            this.btnSolicitudes.UseVisualStyleBackColor = false;

            // 
            // btnOfrecerAyuda
            // 
            this.btnOfrecerAyuda.Text = "   Ofrecer ayuda";
            this.btnOfrecerAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOfrecerAyuda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOfrecerAyuda.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnOfrecerAyuda.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnOfrecerAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfrecerAyuda.FlatAppearance.BorderSize = 0;
            this.btnOfrecerAyuda.Location = new System.Drawing.Point(12, 200);
            this.btnOfrecerAyuda.Size = new System.Drawing.Size(235, 42);
            this.btnOfrecerAyuda.UseVisualStyleBackColor = false;

            // 
            // btnDonaciones
            // 
            this.btnDonaciones.Text = "   Donaciones";
            this.btnDonaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDonaciones.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnDonaciones.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnDonaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonaciones.FlatAppearance.BorderSize = 0;
            this.btnDonaciones.Location = new System.Drawing.Point(12, 255);
            this.btnDonaciones.Size = new System.Drawing.Size(235, 42);
            this.btnDonaciones.UseVisualStyleBackColor = false;

            // 
            // btnMascotas
            // 
            this.btnMascotas.Text = "   Mascotas perdidas";
            this.btnMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMascotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMascotas.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnMascotas.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMascotas.FlatAppearance.BorderSize = 0;
            this.btnMascotas.Location = new System.Drawing.Point(12, 310);
            this.btnMascotas.Size = new System.Drawing.Size(235, 42);
            this.btnMascotas.UseVisualStyleBackColor = false;

            // 
            // btnReportes
            // 
            this.btnReportes.Text = "   Reportes comunitarios";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.Location = new System.Drawing.Point(12, 365);
            this.btnReportes.Size = new System.Drawing.Size(235, 42);
            this.btnReportes.UseVisualStyleBackColor = false;

            // 
            // btnActividades
            // 
            this.btnActividades.Text = "   Actividades";
            this.btnActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActividades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnActividades.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnActividades.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.Location = new System.Drawing.Point(12, 420);
            this.btnActividades.Size = new System.Drawing.Size(235, 42);
            this.btnActividades.UseVisualStyleBackColor = false;

            // 
            // btnPerfil
            // 
            this.btnPerfil.Text = "   Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.Location = new System.Drawing.Point(12, 475);
            this.btnPerfil.Size = new System.Drawing.Size(235, 42);
            this.btnPerfil.UseVisualStyleBackColor = false;

            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Text = "   Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 640);
            this.btnCerrarSesion.Size = new System.Drawing.Size(235, 42);
            this.btnCerrarSesion.UseVisualStyleBackColor = false;

            // 
            // Títulos principales
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTituloPrincipal.Location = new System.Drawing.Point(420, 30);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(460, 50);
            this.lblTituloPrincipal.Text = "Bienvenido a Comunidad Conecta";

            this.lblSubtituloPrincipal.AutoSize = true;
            this.lblSubtituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtituloPrincipal.Location = new System.Drawing.Point(440, 90);
            this.lblSubtituloPrincipal.Name = "lblSubtituloPrincipal";
            this.lblSubtituloPrincipal.Size = new System.Drawing.Size(380, 25);
            this.lblSubtituloPrincipal.Text = "Juntos podemos ayudar a nuestra comunidad";

            // 
            // Tarjetas Centrales
            // 
            // 1. Solicitudes
            this.cardSolicitudes.BackColor = System.Drawing.Color.FromArgb(224, 242, 254);
            this.cardSolicitudes.Controls.Add(this.lblTextSolicitudes);
            this.cardSolicitudes.Location = new System.Drawing.Point(310, 150);
            this.cardSolicitudes.Size = new System.Drawing.Size(210, 160);
            this.lblTextSolicitudes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextSolicitudes.ForeColor = System.Drawing.Color.FromArgb(14, 116, 144);
            this.lblTextSolicitudes.Location = new System.Drawing.Point(20, 110);
            this.lblTextSolicitudes.Size = new System.Drawing.Size(170, 35);
            this.lblTextSolicitudes.Text = "Solicitudes de ayuda";

            // 2. Ofrecer ayuda
            this.cardOfrecer.BackColor = System.Drawing.Color.FromArgb(220, 252, 231);
            this.cardOfrecer.Controls.Add(this.lblTextOfrecer);
            this.cardOfrecer.Location = new System.Drawing.Point(540, 150);
            this.cardOfrecer.Size = new System.Drawing.Size(210, 160);
            this.lblTextOfrecer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextOfrecer.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
            this.lblTextOfrecer.Location = new System.Drawing.Point(20, 110);
            this.lblTextOfrecer.Size = new System.Drawing.Size(170, 35);
            this.lblTextOfrecer.Text = "Ofrecer ayuda";

            // 3. Donaciones
            this.cardDonaciones.BackColor = System.Drawing.Color.FromArgb(254, 243, 199);
            this.cardDonaciones.Controls.Add(this.lblTextDonaciones);
            this.cardDonaciones.Location = new System.Drawing.Point(770, 150);
            this.cardDonaciones.Size = new System.Drawing.Size(210, 160);
            this.lblTextDonaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextDonaciones.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14);
            this.lblTextDonaciones.Location = new System.Drawing.Point(20, 110);
            this.lblTextDonaciones.Size = new System.Drawing.Size(170, 35);
            this.lblTextDonaciones.Text = "Donaciones";

            // 4. Mascotas perdidas
            this.cardMascotas.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.cardMascotas.Controls.Add(this.lblTextMascotas);
            this.cardMascotas.Location = new System.Drawing.Point(1000, 150);
            this.cardMascotas.Size = new System.Drawing.Size(210, 160);
            this.lblTextMascotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextMascotas.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27);
            this.lblTextMascotas.Location = new System.Drawing.Point(20, 110);
            this.lblTextMascotas.Size = new System.Drawing.Size(170, 35);
            this.lblTextMascotas.Text = "Mascotas perdidas";

            // 5. Reportes comunitarios
            this.cardReportes.BackColor = System.Drawing.Color.FromArgb(237, 233, 254);
            this.cardReportes.Controls.Add(this.lblTextReportes);
            this.cardReportes.Location = new System.Drawing.Point(310, 330);
            this.cardReportes.Size = new System.Drawing.Size(210, 160);
            this.lblTextReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextReportes.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182);
            this.lblTextReportes.Location = new System.Drawing.Point(20, 110);
            this.lblTextReportes.Size = new System.Drawing.Size(170, 35);
            this.lblTextReportes.Text = "Reportes comunitarios";

            // 6. Actividades
            this.cardActividades.BackColor = System.Drawing.Color.FromArgb(207, 250, 254);
            this.cardActividades.Controls.Add(this.lblTextActividades);
            this.cardActividades.Location = new System.Drawing.Point(540, 330);
            this.cardActividades.Size = new System.Drawing.Size(210, 160);
            this.lblTextActividades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextActividades.ForeColor = System.Drawing.Color.FromArgb(14, 116, 144);
            this.lblTextActividades.Location = new System.Drawing.Point(20, 110);
            this.lblTextActividades.Size = new System.Drawing.Size(170, 35);
            this.lblTextActividades.Text = "Actividades";

            // 7. Perfil
            this.cardPerfil.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.cardPerfil.Controls.Add(this.lblTextPerfil);
            this.cardPerfil.Location = new System.Drawing.Point(770, 330);
            this.cardPerfil.Size = new System.Drawing.Size(210, 160);
            this.lblTextPerfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTextPerfil.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTextPerfil.Location = new System.Drawing.Point(20, 110);
            this.lblTextPerfil.Size = new System.Drawing.Size(170, 35);
            this.lblTextPerfil.Text = "Perfil";

            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1250, 560);
            this.Controls.Add(this.cardPerfil);
            this.Controls.Add(this.cardActividades);
            this.Controls.Add(this.cardReportes);
            this.Controls.Add(this.cardMascotas);
            this.Controls.Add(this.cardDonaciones);
            this.Controls.Add(this.cardOfrecer);
            this.Controls.Add(this.cardSolicitudes);
            this.Controls.Add(this.lblSubtituloPrincipal);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.panelSidebar);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comunidad Conecta - Inicio";

            this.panelSidebar.ResumeLayout(false);
            this.cardSolicitudes.ResumeLayout(false);
            this.cardOfrecer.ResumeLayout(false);
            this.cardDonaciones.ResumeLayout(false);
            this.cardMascotas.ResumeLayout(false);
            this.cardReportes.ResumeLayout(false);
            this.cardActividades.ResumeLayout(false);
            this.cardPerfil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Declaración de todos los controles para que el diseñador y el código los reconozcan sin errores
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

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label lblSubtituloPrincipal;

        private System.Windows.Forms.Panel cardSolicitudes;
        private System.Windows.Forms.Label lblTextSolicitudes;
        private System.Windows.Forms.Panel cardOfrecer;
        private System.Windows.Forms.Label lblTextOfrecer;
        private System.Windows.Forms.Panel cardDonaciones;
        private System.Windows.Forms.Label lblTextDonaciones;
        private System.Windows.Forms.Panel cardMascotas;
        private System.Windows.Forms.Label lblTextMascotas;
        private System.Windows.Forms.Panel cardReportes;
        private System.Windows.Forms.Label lblTextReportes;
        private System.Windows.Forms.Panel cardActividades;
        private System.Windows.Forms.Label lblTextActividades;
        private System.Windows.Forms.Panel cardPerfil;
        private System.Windows.Forms.Label lblTextPerfil;
    }
}