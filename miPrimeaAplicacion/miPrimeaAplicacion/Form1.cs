using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        // Variables globales del formulario
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String accion = "nuevo";
        int posicion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] }; 

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (dt.Rows.Count > 0)
            {
                // Accedemos a las columnas por su posición numérica (0, 1, 2...)
                TxtCodigoAlumno.Text = dt.Rows[posicion][0].ToString();
                txtNombreAlumno.Text = dt.Rows[posicion][1].ToString();
                txtDireccionAlumno.Text = dt.Rows[posicion][2].ToString();
                txtTelefonoAlumno.Text = dt.Rows[posicion][3].ToString();
                txtEmailAlumno.Text = dt.Rows[posicion][4].ToString();

                lblRegistrosAlumnos.Text = (posicion + 1) + " de " + dt.Rows.Count;
            }
        }

        private void activarDesactivarCtrls(Boolean estado)
        {
            grbDatos.Enabled = estado;
            grbNavegacion.Enabled = !estado;
        }

       

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Agregar")
            {
                accion = "nuevo";
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";

                activarDesactivarCtrls(true);
            }
            else
            { // Guardar
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                accion = "modificar";
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";
                activarDesactivarCtrls(true);
            }
            else
            { // Cancelar
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (posicion < dt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                posicion = dt.Rows.Count - 1;
                mostrarDatos();
            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDireccionAlumno_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}