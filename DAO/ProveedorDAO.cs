using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.DAO
{
    class ProveedorDAO
    {
        public static Proveedor ObtenerProveedorById(int id)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            Proveedor p = new Proveedor();
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM proveedores WHERE proveedor_id like @idProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProveedor", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    p.Id = int.Parse(dr["proveedor_id"].ToString());
                    p.RazonSocial = dr["razon_social"].ToString();
                    p.Mail = dr["mail"].ToString();
                    p.Telefono = dr["telefono"].ToString();
                    p.Activo = Convert.ToBoolean(int.Parse(dr["proveedor_activo"].ToString()));

                }
            }
            catch (Exception)
            {


                throw;
            }
            finally
            {
                cn.Close();
            }
            return p;

        }
        public static DataTable ObtenerTablaProveedoresById(int id)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM proveedores WHERE proveedor_id like @idProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProveedor", id);
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

        public static DataTable ObtenerTablaProveedores()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM proveedores";
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
        public static DataTable ObtenerListadoProveedoresXEstado(int estado)
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();
                string consulta;
                //Escribir consulta SQL
                if (estado == 0)
                {
                    consulta = "SELECT * FROM proveedores WHERE proveedor_activo = 0";
                }
                else if (estado == 1)
                {
                    consulta = "SELECT * FROM proveedores WHERE proveedor_activo = 1";
                }
                else
                {
                    consulta = "SELECT * FROM proveedor";
                }
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
        public static DataTable ObtenerListadoProveedoresInactivos()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM proveedores WHERE proveedor_activo = 0";

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
        public static DataTable ObtenerListadoProveedoresActivos()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM proveedores WHERE proveedor_activo = 1";

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
        public static bool RegistrarProveedor(Proveedor p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO proveedores (razon_social, mail, telefono, proveedor_activo) VALUES(@razonSocial, @mail, @telefono, @proveedorEstado); ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@razonSocial", p.RazonSocial);
                cmd.Parameters.AddWithValue("@mail", p.Mail);
                cmd.Parameters.AddWithValue("@telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@proveedorEstado", p.Activo);

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
        public static bool EliminarProveedor(int index, int value)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE proveedores SET proveedor_activo = @estado WHERE proveedor_id = @index";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@estado", value);
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
        public static bool ActualizarProveedor(Proveedor p, int index)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE proveedores SET razon_social = @razonSocial, mail = @mail, telefono = @telefono WHERE proveedor_id = @index";
                cmd.Parameters.AddWithValue("@razonSocial", p.RazonSocial);
                cmd.Parameters.AddWithValue("@mail", p.Mail);
                cmd.Parameters.AddWithValue("@telefono", p.Telefono);
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
    }


}