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
            // Apunta al archivo .mdf configurado
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbacademica.mdf;Integrated Security=True";

            objConexion.ConnectionString = cadenaConexion;

            // Verificamos que la conexión esté abierta
            if (objConexion.State == ConnectionState.Closed)
            {
                objConexion.Open();
            }
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear(); // Limpiar el dataset

            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            // 1. Cargar Alumnos
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos");

            // 2. Cargar Materias
            objComando.CommandText = "SELECT * FROM materias";
            objDataAdapter.Fill(objDs, "materias");

            // 3. Cargar Periodos
            objComando.CommandText = "SELECT * FROM periodos";
            objDataAdapter.Fill(objDs, "periodos");

            // 4. Cargar Notas
            objComando.CommandText = "SELECT n.idNota, a.nombre AS Alumno, p.periodo AS Periodo, n.fecha FROM notas n INNER JOIN alumnos a ON n.idAlumno = a.idAlumnos INNER JOIN periodos p ON n.idPeriodo = p.idPeriodo";
            objDataAdapter.Fill(objDs, "notas");

            return objDs;
        }

        // ==========================================
        // MÉTODOS REQUERIDOS PARA EL PARCIAL (USUARIOS)[cite: 1]
        // ==========================================

        public DataSet crearDsUsuarios()
        {
            objDs.Clear();
            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            // Carga la tabla de usuarios con tu código de estudiante[cite: 1]
            objComando.CommandText = "SELECT * FROM usuarios_USSS016526";
            objDataAdapter.Fill(objDs, "usuarios");

            return objDs;
        }

        public string mantenimiento_usuarios_USSS016526(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO usuarios_USSS016526 (usuario, clave, nombre, dirección, teléfono) VALUES ('" + datos[0] + "', '" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE usuarios_USSS016526 SET usuario='" + datos[0] + "', clave='" + datos[1] + "', nombre='" + datos[2] + "', dirección='" + datos[3] + "', teléfono='" + datos[4] + "' WHERE idUsuario=" + datos[5];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM usuarios_USSS016526 WHERE idUsuario=" + datos[5];
            }
            return ejecutarSQL(sql);
        }

        // ==========================================
        // MÉTODOS EXISTENTES DE MANTENIMIENTO
        // ==========================================

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos ([código], nombre, direccion, telefono, email) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET [código]='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumnos=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumnos=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias([código], nombre, uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET [código]='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosPeriodos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO periodos(periodo, fecha) VALUES ('" + datos[1] + "', GETDATE())";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE periodos SET periodo='" + datos[1] + "' WHERE idPeriodo=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM periodos WHERE idPeriodo=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosNotas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO notas(idAlumno, idPeriodo, fecha) VALUES (" + datos[0] + ", " + datos[1] + ", GETDATE())";
            }
            return ejecutarSQL(sql);
        }

        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}