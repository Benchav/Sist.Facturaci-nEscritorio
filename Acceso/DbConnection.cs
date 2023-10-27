//Creado por: Equipo pinoleros ing.sistemas 2 año
//Esta clase maneja la coneccion a la base de datos
using System.Data;
using System.Data.SqlClient;

namespace Acceso // este es el DAL solo con el nombre Acceso
{
    public class DbConnection
    {
        //esta es la instancia de la coneccion
        public SqlConnection cnn = new SqlConnection
        (@"Data Source=LAPTOP-ALNE2D47\SQLEXPRESS;"
        + "Initial catalog=AB;"
        + "integrated security = SSPI");

        public SqlConnection getcon()
        {
            //es el metodo que devuelve la instancia de la conexión
            //hace la conectividad al server
            if (cnn.State == ConnectionState.Closed) //si la conexion esta cerrada
                // se abre antes de devolverla
            {
                cnn.Open();
            }
            return cnn;

        }
        public int ExeNonQuery(SqlCommand cmd)
        {
            //es un metodo que ejecuta una consulta como insertar
            //esta funcion es para relaizar cosas en el CRUD
            cmd.Connection = getcon();
            int rowsAffected = -1;
            rowsAffected = cmd.ExecuteNonQuery();
            cnn.Close();
            return rowsAffected;
            //estable la conexion y ejecuta la consulta devolviendo el numero de filas afectadas
        }
        public object ExeScalar(SqlCommand cmd)
        {
            // es un metodo que ejecuta una consulta y devuelve
            // la primera columna del primer resultado como objeto
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            cnn.Close();
            return obj;
        }
        public DataTable ExeReader(SqlCommand cmd)
        //es un metodo que ejecuta una consulta y devuelve un objeto
        //Datatable que contiene los resultados de la consulta
            {
                cmd.Connection = getcon();
                SqlDataReader sdr;// para leer los datos y cargar resultado en el data table
                DataTable dt = new DataTable();
                sdr = cmd.ExecuteReader();             
                dt.Load(sdr);
                cnn.Close();
                return dt;
         
            }
        }
}//En resumen, esta clase DbConnection proporciona métodos para establecer
 //la conexión con una base de datos y ejecutar consultas
 //utilizando el proveedor System.Data.SqlClient. Estos métodos
 //facilitan la ejecución de consultas no consultivas, la obtención
 //de valores escalares y la lectura de datos en forma de DataTable.



