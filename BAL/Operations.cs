//Creado por: Equipo pinoleros ing.sistemas 2 año
//Esta clase maneja las operaciones del CRUD
using Acceso; //el DAL mio es Acceso
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operations
    {
        public DbConnection db = new DbConnection();
        public Information info = new Information();
        //frm1 (employees)
        public int InsertEmp(Information info)
        {
            //se encarga de insertar nuevos registros 
            // al catalogo de registro de usuarios
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO ClientePanaderia1 VALUES('"+info.Nombre+"'," +
                "'"+info.Genero+"'," +
                "'"+info.FechaNacimiento+ "'," +
                ""+"'"+info.Direccion+"',"+"'"
                +info.Educacíon+
                "',"+"'"+info.NombreUsuario+"'" +
                ","+"'"+info.Contraseña+"','U')";

            return db.ExeNonQuery(cmd);
        }
        //frmProducto
        public int InsertEmp(InformationProduc info)
        {
            //se escarga de insertar nuevos registros al catalogo gestion de inventario
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO GestionInventario VALUES(" +
                "'" + info.Nombre + "'," +
                "'" + info.Descripcion + "'," +
                "" + "'" + info.PrecioVenta + "')";

           


            return db.ExeNonQuery(cmd);
        }
        //frmCompra 
        public int InsertEmp(InformationComp info)
        {
            
                //se encarga de insertar nuevos registros 
                // al catalogo Compra Productos
                SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO DetalleCompra VALUES(" +
//(Categoria," +"Descripcion,Precio,FechaCompraX,FechaExpiracionX)" +
            /*  " VALUES */
                      "'"
                    + info.Categoria + "','" 
                    + info.Descripcion + "','"
                    + info.Precio + "','"
                    + info.FechaCompraX + "','"
                    + info.FechaExpiracionX + "')";

            return db.ExeNonQuery(cmd);
            
        }


        //frmLogin
        public DataTable Login(Information info)
        {
            //este verifica existencia o no de un usuario y contraseña en la tabla
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            //AÑADE DATOS DE USUARIOS
            cmd.CommandText = "select * from ClientePanaderia1 WHERE NombreUsuario='"
                + info.NombreUsuario + "' AND Contraseña= '"
                + info.Contraseña + "'";
            return db.ExeReader(cmd);
        }

        public DataTable ViewCompra(InformationComp info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from DetalleCompra";
            return db.ExeReader(cmd);
        }

        //frm employees
        public DataTable ViewEmployees(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
             cmd.CommandText = "SELECT * from ClientePanaderia1";
          

            return db.ExeReader(cmd);
        }

        public DataTable ViewProducto(InformationProduc info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from  GestionInventario";

            return db.ExeReader(cmd);
        }
    }
}
