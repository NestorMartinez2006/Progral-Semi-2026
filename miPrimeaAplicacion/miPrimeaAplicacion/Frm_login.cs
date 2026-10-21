using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miPrimeaAplicacion
{
    public partial class frm_login : Form
    {
        Conexion conexion = new Conexion();

        public frm_login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Valida si el usuario y la clave existen en la tabla del parcial[cite: 1]
                string query = "SELECT COUNT(*) FROM usuarios_USSS016526 WHERE usuario = @usuario AND clave = @clave";

                SqlCommand cmd = new SqlCommand(query, conexion.objConexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                if (resultado > 0)
                {
                    MessageBox.Show("¡Acceso concedido! Bienvenido al sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_usuario formUsuario = new frm_usuario();
                    formUsuario.Show();
                    this.Hide(); // Oculta el login y abre el formulario principal de usuarios
                }
                else
                {
                    // Si no está registrado, deniega el acceso[cite: 1]
                    MessageBox.Show("Acceso denegado. El usuario no está registrado o la clave es incorrecta.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtClave.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}