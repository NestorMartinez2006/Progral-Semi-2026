using System;
using System.Drawing;
using System.Windows.Forms;

namespace parcial_progra_l
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();

            // Vincular únicamente el evento de cerrar sesión
            this.btnCerrarSesion.Click += new EventHandler(btnCerrarSesion_Click);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}