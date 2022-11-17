using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.DAO
{
    class VentasDAO
    {
        public static DataTable obtenerListadoDeVentas()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT v.venta_id, v.venta_fecha, E.empleado_apellido as empleado_id, FP.Forma_de_pago_nombre as forma_de_pago_id, cotizacion FROM VENTAS V JOIN EMPLEADOS E ON v.empleado_id = E.empleado_id JOIN FORMAS_DE_PAGO FP ON V.Forma_de_pago_id = FP.Forma_de_pago_id ";
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
        public static DataTable obtenerEstadisticaDeVenta()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT V.VENTA_ID, E.empleado_apellido, V.VENTA_FECHA, p.nombre, FP.FORMA_DE_PAGO_NOMBRE FROM VENTAS V JOIN empleados E ON V.EMPLEADO_ID = E.empleado_id  JOIN detalle_cotizacion D ON V.COTIZACION = D.numCotizacion  JOIN productos P ON P.id = D.cod_producto JOIN FORMAS_DE_PAGO FP ON V.FORMA_DE_PAGO_ID = FP.FORMA_DE_PAGO_ID";
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

        public static DataTable obtenerEstadisticaDeVentaEmpleado(int idEmpleado, int idProducto, int año, int idMetodoPago)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT a.nombre, COALESCE(SUM(t.valor), 0) as valor, Month_No as orden_mes FROM(SELECT DateName(month, '1/1/3') AS nombre, 1 as Month_No UNION ALL SELECT DateName(month, '2/2/3'), 2 UNION ALL SELECT DateName(month, '3/3/3'), 3      UNION ALL SELECT DateName(month, '4/4/3'), 4       UNION ALL SELECT DateName(month, '5/5/3'), 5       UNION ALL SELECT DateName(month, '6/6/3'), 6        UNION ALL SELECT DateName(month, '7/7/3'), 7        UNION ALL SELECT DateName(month, '8/8/3'), 8        UNION ALL SELECT DateName(month, '9/9/3'), 9        UNION ALL SELECT DateName(month, '10/10/3'), 10        UNION ALL SELECT DateName(month, '11/11/3'), 11    UNION ALL SELECT DateName(month, '12/12/3'), 12) a  LEFT JOIN(SELECT count(VENTA_ID) as valor, DateName(month, V.VENTA_FECHA) as nombre FROM VENTAS V JOIN empleados E ON V.EMPLEADO_ID = E.empleado_id  JOIN detalle_cotizacion D ON V.COTIZACION = D.numCotizacion  JOIN productos P ON P.id = D.cod_producto JOIN FORMAS_DE_PAGO FP ON V.FORMA_DE_PAGO_ID = FP.FORMA_DE_PAGO_ID  GROUP BY v.empleado_id, DateName(month, V.VENTA_FECHA), YEAR(v.venta_fecha), V.empleado_id,P.id,V.FORMA_DE_PAGO_ID ";
                string empleadoFiltro = idEmpleado != -1 ? " V.empleado_id = " + idEmpleado : "";
                string productoFiltro = idProducto != -1 ? " P.id = " + idProducto +  " " : "";
                string pagoFiltro = idMetodoPago != -1 ? "V.FORMA_DE_PAGO_ID = '" + idMetodoPago + "' ": ""  ;
                string añoFiltro = "YEAR(V.VENTA_FECHA) = " + año +" ";
                if (empleadoFiltro != "" || productoFiltro != "" || pagoFiltro != "") añoFiltro += " AND ";
                string conector = empleadoFiltro != "" && productoFiltro != "" ? " AND " : "";
                string conectorEstado = (empleadoFiltro != "" || productoFiltro != "") && pagoFiltro != "" ? " AND " : "";
                
                 consulta += " HAVING "+ añoFiltro + empleadoFiltro + conector + productoFiltro + conectorEstado + pagoFiltro + "  ) t         ON t.nombre = a.nombre GROUP BY a.nombre,a.Month_No          Order by Month_No";
                ;

                cmd.Parameters.Clear();   
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
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
