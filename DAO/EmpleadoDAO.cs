﻿using EmpresaTuLuz.Entidades;
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



    }


}
