using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace EmpresaTuLuz.DAO
{
     class VentaDAO
    {

        public static bool AltaVenta(int idCotizacion, int idVend, int formaDePago)
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
                string consulta = "INSERT INTO VENTAS values(@fecha,@idVend,@formaDePago,@idCotizacion)";
                //Agregando parameters
                cmd.Parameters.Clear();

                //  cmd.Parameters.AddWithValue("@numCot",numCot);
                cmd.Parameters.AddWithValue("@idCotizacion", idCotizacion);
                cmd.Parameters.AddWithValue("@idVend", idVend);
                cmd.Parameters.AddWithValue("@formaDePago", formaDePago);      
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();

                objTransaccion = cn.BeginTransaction("AltaDeVenta");
                cmd.Transaction = objTransaccion;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                objTransaccion.Commit();
                return true;

            }
            catch (Exception e)
            {


                objTransaccion.Rollback();
                return false;
                ;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerVentas()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT C.numCotizacion,V.venta_id,E.empleado_apellido, C.id_vendedor, C.nombreCliente, C.apellidoCliente,V.VENTA_FECHA, P.FORMA_DE_PAGO_NOMBRE FROM cotizaciones C JOIN VENTAS V ON V.cotizacion = C.numCotizacion JOIN FORMAS_DE_PAGO P ON P.FORMA_DE_PAGO_ID = V.FORMA_DE_PAGO_ID JOIN empleados E ON C.id_vendedor = E.empleado_id";
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
