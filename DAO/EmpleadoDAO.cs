using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTuLuz.DAO
{
    class EmpleadoDAO
    {

        public static Empleado obtenerEmpleadoById(int id)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            Empleado e = new Empleado();
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM empleados WHERE empleado_id like @idEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEmpleado", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    e.Id = int.Parse(dr["empleado_id"].ToString());
                    e.Nombre = dr["empleado_nombre"].ToString(); 
                    e.Apellido = dr["empleado_apellido"].ToString(); 
                    e.TipoDoc = dr["empleado_tipo_doc"].ToString(); 
                    e.NumDoc = dr["empleado_num_doc"].ToString(); 
                    e.Direccion = dr["direccion"].ToString(); 
                    e.IdBarrio = int.Parse(dr["barrio_id"].ToString());
                    e.Telefono = dr["telefono"].ToString();
                   if (dr["empleado_id_jefe"].ToString() == "")
                    {
                        e.JefeId = 0;
                    }
                    else
                    {
                        e.JefeId = int.Parse(dr["empleado_id_jefe"].ToString());

                    }
                    e.Activo = Convert.ToBoolean(int.Parse(dr["empleado_activo"].ToString()));

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
            return e;

        }
        public static DataTable obtenerTablaEmpleadoById(int id)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM empleados WHERE empleado_id like @idEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEmpleado", id);
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

        public static DataTable obtenerTablaEmpleados()
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM empleados";
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
        public static DataTable obtenerListadoEmpleadosXEstado(int estado)
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
                    consulta = "SELECT * FROM empleados WHERE empleado_activo = 0";
                }
                else if (estado == 1)
                {
                    consulta = "SELECT * FROM empleados WHERE empleado_activo = 1";
                }
                else
                {
                    consulta = "SELECT * FROM empleados";
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
        public static DataTable obtenerListadoEmpleadosInactivos()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM empleados WHERE empleado_activo = 0";
                
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
        public static DataTable obtenerListadoEmpleadosActivos()
        {

            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {


                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM empleados WHERE empleado_activo = 1";

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
        public static bool RegistrarEmpleado(Empleado e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO empleados (empleado_num_doc, empleado_tipo_doc, empleado_nombre, empleado_apellido, direccion, barrio_id, telefono, empleado_id_jefe, empleado_activo) VALUES(@empleadoDocumento, @empleadoTipoDoc, @empleadoNombre, @empleadoApellido, @empleadoDireccion, @empleadoBarrio, @empleadoTelefono, @empleadoIdJefe, @empleadoEstado); ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@empleadoDocumento", e.NumDoc);
                cmd.Parameters.AddWithValue("@empleadoTipoDoc", e.TipoDoc);
                cmd.Parameters.AddWithValue("@empleadoNombre", e.Nombre);
                cmd.Parameters.AddWithValue("@empleadoApellido", e.Apellido);
                cmd.Parameters.AddWithValue("@empleadoDireccion", e.Direccion);
                cmd.Parameters.AddWithValue("@empleadoBarrio", e.IdBarrio);
                cmd.Parameters.AddWithValue("@empleadoTelefono", e.Telefono);
                cmd.Parameters.AddWithValue("@empleadoIdJefe", e.JefeId);
                cmd.Parameters.AddWithValue("@empleadoEstado", e.Activo);

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
        public static bool EliminarEmpleado(int index, int value)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE empleados SET empleado_activo = @estado WHERE empleado_id = @index";
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
        public static bool ActualizarEmpleado(Empleado e, int index)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE empleados SET empleado_num_doc = @empleadoDocumento, empleado_tipo_doc =@empleadoTipoDoc, empleado_nombre = @empleadoNombre, empleado_apellido= @empleadoApellido , direccion = @empleadoDireccion , barrio_id = @empleadoBarrio , telefono = @empleadoTelefono , empleado_idjefe = @empleadoIdJefe WHERE empleado_id = @index";
                cmd.Parameters.AddWithValue("@empleadoDocumento", e.NumDoc);
                cmd.Parameters.AddWithValue("@empleadoTipoDoc", e.TipoDoc);
                cmd.Parameters.AddWithValue("@empleadoNombre", e.Nombre);
                cmd.Parameters.AddWithValue("@empleadoApellido", e.Apellido);
                cmd.Parameters.AddWithValue("@empleadoDireccion", e.Direccion);
                cmd.Parameters.AddWithValue("@empleadoBarrio", e.IdBarrio);
                cmd.Parameters.AddWithValue("@empleadoTelefono", e.Telefono);
                cmd.Parameters.AddWithValue("@empleadoIdJefe", e.JefeId);
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
