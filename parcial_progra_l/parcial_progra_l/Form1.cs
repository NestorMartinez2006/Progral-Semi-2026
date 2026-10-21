using System;
using System.Drawing;
using System.Windows.Forms;

namespace parcial_progra_l
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarTablaPublicaciones();
        }

        private void ConfigurarTablaPublicaciones()
        {
            if (dgvPublicaciones != null)
            {
                dgvPublicaciones.Rows.Clear();
                dgvPublicaciones.Rows.Add("Solicitud", "Necesito ayuda con mi computadora", "20/09/2026", "Pendiente");
                dgvPublicaciones.Rows.Add("Oferta", "Puedo ayudar con clases de matemáticas...", "19/09/2026", "En proceso");
                dgvPublicaciones.Rows.Add("Mascota", "Se perdió un perro café, en la zona...", "18/09/2026", "Abierto");
                dgvPublicaciones.Rows.Add("Donación", "Regalo ropa en buen estado, talla M...", "17/09/2026", "Disponible");
                dgvPublicaciones.Rows.Add("Reporte", "Hay un hoyo en la calle, puede ser...", "16/09/2026", "En revisión");
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}