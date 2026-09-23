using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace miPrimeaAplicacion
{
    public class Conexion
    {
        // Definir miembros, atributos y objetos de ADO.NET
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        // Constructor e inicializador de los miembros de la clase
        public Conexion()
        {
            // Se corrigió el nombre a dbacademica.mdf (sin guion bajo)
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbacademica.mdf;Integrated Security=True";

            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // Abrir la base de datos
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); // Limpiar el dataset

            // Establecer la conexión para ejecutar consultas
            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            objComando.CommandText = "SELECT * FROM alumnos";

            // Llenar el DataSet con los datos de la tabla alumnos
            objDataAdapter.Fill(objDs, "alumnos");

            return objDs;
        }
    }
}