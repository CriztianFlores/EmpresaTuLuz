using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz.DAO
{
    class CotizacionDAO
    {
        //Validar si el usuario existe en la BD
        public static int ObtenerUltimoNroCotizacion()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
 
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT MAX(numCotizacion) FROM cotizaciones";
                //Agregando parameters
                cmd.Parameters.Clear();
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AltaCotizacion(int numCot,int idCliente,int idVend, int estado, string nombre, string apellido, string obs, float precio, string motivo, List<int[]> listaProd)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlTransaction objTransaccion = null;

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "INSERT INTO cotizaciones values(@idCliente,@idVend,@estado,@nombre,@apellido,@fecha,@obs,@precio,@motivo)";
                //Agregando parameters
                cmd.Parameters.Clear();

              //  cmd.Parameters.AddWithValue("@numCot",numCot);
                cmd.Parameters.AddWithValue("@idCliente",idCliente);
                cmd.Parameters.AddWithValue("@idVend",idVend);
                cmd.Parameters.AddWithValue("@estado",estado);
                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@apellido",apellido);
                cmd.Parameters.AddWithValue("@fecha",DateTime.Now);
                cmd.Parameters.AddWithValue("@obs",obs);
                cmd.Parameters.AddWithValue("@precio",precio);
                cmd.Parameters.AddWithValue("@motivo",motivo);
                

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                

                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeCotizacion");

                cmd.Transaction = objTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                foreach (var producto in listaProd)
                {
                    string consultaCotizacioXDetalle = "INSERT INTO detalle_cotizacion values(@numCotizacion,@cod_producto,@cantidad,@precio)";
                    cmd.Parameters.Clear();
                  //  cmd.Parameters.AddWithValue("@numCotizacion", numCot);
                    cmd.Parameters.AddWithValue("@cod_producto", producto[0]);
                    cmd.Parameters.AddWithValue("@cantidad", producto[1]);
                    cmd.Parameters.AddWithValue("@precio",precio);
                    cmd.Parameters.AddWithValue("@numCotizacion", numCot);
                    cmd.CommandText = consultaCotizacioXDetalle;
                    cmd.ExecuteNonQuery();
                }
                objTransaccion.Commit();
                return true;

            }
            catch (Exception e )
            {

                MessageBox.Show(e.Message);
                objTransaccion.Rollback();
                return false;
                ;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerCotizaciones()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT C.numCotizacion,E.empleado_apellido, C.id_vendedor, C.estado as id_estado, C.nombreCliente, C.apellidoCliente,C.fecha, C.observaciones, C.precioTotal, C.motivo_perdida, ES.descripcion as estado FROM cotizaciones C JOIN estados_cotizaciones ES ON ES.id_estado = C.estado JOIN empleados E ON C.id_vendedor = E.empleado_id";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
           
                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerCotizacionXId(int id)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT C.numCotizacion,E.empleado_apellido, E.empleado_nombre,E.empleado_num_doc, C.id_vendedor, C.estado as id_estado," +
                    " CLI.cliente_nombre, CLI.cliente_apellido, CLI.cliente_cuit,C.fecha, C.observaciones, C.precioTotal, " +
                    "C.motivo_perdida, ES.descripcion as estado FROM cotizaciones C JOIN estados_cotizaciones ES " +
                    "ON ES.id_estado = C.estado JOIN empleados E ON C.id_vendedor = E.empleado_id JOIN clientes CLI ON C.id_cliente = CLI.cliente_id WHERE  C.numCotizacion LIKE @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
       
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerDetallesCotizacion(int nroCotizacion)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT DC.*, P.nombre FROM detalle_cotizacion DC JOIN productos P ON DC.cod_producto = P.id WHERE DC.numCotizacion LIKE @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", nroCotizacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool actualizarCotizacion(string observacion, string estado, string motivoPerdida, int index)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                string consulta;
                SqlCommand cmd = new SqlCommand();
                if(estado != "-1") { 
                 consulta = "UPDATE cotizaciones SET estado = @estado, observaciones= @observaciones , motivo_perdida = @motivo_perdida  WHERE numCotizacion = @index";
                }
                else
                {
                    consulta = "UPDATE cotizaciones SET  observaciones= @observaciones , motivo_perdida = @motivo_perdida  WHERE numCotizacion = @index";
                }
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@estado",estado);
                cmd.Parameters.AddWithValue("@observaciones",observacion);
                cmd.Parameters.AddWithValue("@motivo_perdida", motivoPerdida);
                cmd.Parameters.AddWithValue("@index", index);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                //Si ejecuto esto y no hubo ninguna excepcion fue porque fue exitosa la insercion
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static DataTable obtenerListadoCotizaciones()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM COTIZACIONES";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable obtenerEstadisticaProductoVendido()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT P.NOMBRE AS 'PRODUCTO', COUNT(P.ID) AS 'CANTIDAD' FROM detalle_cotizacion DC JOIN VENTAS V ON DC.numCotizacion = V.cotizacion JOIN PRODUCTOS P ON(P.ID = DC.cod_producto) GROUP BY P.NOMBRE";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
