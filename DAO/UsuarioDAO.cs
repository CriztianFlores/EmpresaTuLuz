using EmpresaTuLuz.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmpresaTuLuz.DAO
{
    class UsuarioDAO
    {
        //Validar si el usuario existe en la BD
        public static bool validarUsuario(string usuario, string password)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM usuarios WHERE usuario_nombre LIKE @usu AND usuario_pass LIKE @pass AND usuario_activo LIKE @activo";
                //Agregando parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usu", usuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@activo", 1);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static DataTable obtenerListadoUsuarios(int estado)
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
                if (estado == 0) { 
                    consulta = "SELECT * FROM usuarios WHERE usuario_activo = 0";
                }
                else if (estado == 1) {
                    consulta = "SELECT * FROM usuarios WHERE usuario_activo = 1";
                }
                else
                    {
                        consulta = "SELECT * FROM usuarios";
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

        public static bool registrarUsuario(Usuario u)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO usuarios (usuario_nombre, usuario_pass, empleado_id, usuario_activo) VALUES(@nombreUsuario, @passUsuario, @idEmmpleado, @estado); ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", u.Username);
                cmd.Parameters.AddWithValue("@passUsuario", u.Password);
                cmd.Parameters.AddWithValue("@idEmmpleado", u.EmpleadoId);
                cmd.Parameters.AddWithValue("@estado", u.Activo);

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

        public static bool actualizarUsuario(Usuario u, int index)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE usuarios SET usuario_nombre = @nombreUsuario, usuario_pass= @passUsuario , empleado_id = @idEmmpleado , usuario_activo = @estado WHERE usuario_id = @index";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsuario", u.Username);
                cmd.Parameters.AddWithValue("@passUsuario", u.Password);
                cmd.Parameters.AddWithValue("@idEmmpleado", u.EmpleadoId);
                cmd.Parameters.AddWithValue("@estado", u.Activo);
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


        public static bool eliminarUsuario(int index, int value)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE usuarios SET usuario_activo = @estado WHERE usuario_id = @index";
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



        public static Usuario obtenerUsuarioById(int id)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            Usuario u = new Usuario();
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM usuarios WHERE usuario_id like @idUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idUsuario", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    u.Username = dr["usuario_nombre"].ToString();
                    u.Password = dr["usuario_pass"].ToString();
                    u.EmpleadoId = int.Parse(dr["empleado_id"].ToString());
                    u.Activo = int.Parse(dr["usuario_activo"].ToString());

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
            return u;    

        }

        public static Usuario obtenerUsuarioByName(string name)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            Usuario u = new Usuario();
            try
            {
                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM usuarios WHERE usuario_nombre like @nameUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nameUsuario", name);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    u.Username = dr["usuario_nombre"].ToString();
                    u.Password = dr["usuario_pass"].ToString();
                    u.EmpleadoId = int.Parse(dr["empleado_id"].ToString());
                    u.Activo = int.Parse(dr["usuario_activo"].ToString());

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
            return u;

        }

        public DataTable obtenerListadoUsuariosEmpleado(int index)
        {
            //Crear objeto conexion
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                //Crear objeto sql command
                SqlCommand cmd = new SqlCommand();

                //Escribir consulta SQL
                string consulta = "SELECT * FROM usuarios WHERE empleado_id LIKE @index";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@index", index);
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
