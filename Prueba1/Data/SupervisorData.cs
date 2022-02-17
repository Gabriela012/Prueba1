using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Prueba1.Models;


namespace Prueba1.Data
{
    public class SupervisorData
    {
       
        public static bool RegistrarSupervisor( Supervisor supervisor)
               
        {
            
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                Supervisor oSupervisor = new Supervisor();
                SqlCommand cmd = new SqlCommand("sp_RegistrarSupervisor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oSupervisor.nombre);
                cmd.Parameters.AddWithValue("@apellido", oSupervisor.apellido);
                cmd.Parameters.AddWithValue("@dni", oSupervisor.dni);
                cmd.Parameters.AddWithValue("@sexo",oSupervisor.sexo);
                cmd.Parameters.AddWithValue("@direccion", oSupervisor.direccion);
                cmd.Parameters.AddWithValue("@telefono", oSupervisor.telefono);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }
        public static bool ActualizarSupervisor(Supervisor oSupervisor)
        {
            
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarSupervisor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Supervisor", oSupervisor.id_Supervisor);
                cmd.Parameters.AddWithValue("@nombre", oSupervisor.nombre);
                cmd.Parameters.AddWithValue("@apellido", oSupervisor.apellido);
                cmd.Parameters.AddWithValue("@direccion", oSupervisor.direccion);
                cmd.Parameters.AddWithValue("@telefono", oSupervisor.telefono);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static Supervisor ObtenerIdSupervisor(int idSupervisor)
        {
            Supervisor oSupervisor = new Supervisor();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerIdSupervisor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Supervisor", idSupervisor);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oSupervisor = new Supervisor()
                            {
                                id_Supervisor = Convert.ToInt32(dr["id_Supervisor"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                sexo = dr["sexo"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                telefono = Convert.ToInt32(dr["telefono"]),
                                estadoSupervisor = Convert.ToInt32(dr["estadoSupervisor"])

                            };
                        }
                    }
                    return oSupervisor;
                }
                catch (Exception ex)
                {
                    return oSupervisor;
                }
            }
        }
        public static List<Supervisor> ObtenerSupervisor()
        {
            List<Supervisor> oObtenerSupervisor = new List<Supervisor>();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerSupervisor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oObtenerSupervisor.Add(new Supervisor()
                            {
                                id_Supervisor = Convert.ToInt32(dr["id_Supervisor"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                sexo = dr["sexo"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                telefono = Convert.ToInt32(dr["telefono"]),
                                estadoSupervisor = Convert.ToInt32(dr["estadoSupervisor"])

                            });
                        }
                    }
                    return oObtenerSupervisor;
                }
                catch (Exception ex)
                {
                    return oObtenerSupervisor;
                }

            }
        }
        public static bool EliminarSupervisor(int idSupervisor)
        {
            Supervisor oSupervisor = new Supervisor();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarSupervisor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Supervisor", idSupervisor);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
        public static bool EliminarLogicaSupervisor(int id)
        {
            Supervisor oSupervisor = new Supervisor();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarLogicaSupervisor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Supervisor", id);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
            public static bool ActivarLogicaSupervisor(int id)
            {
                Supervisor oSupervisor = new Supervisor();
                using (SqlConnection connection = new SqlConnection(Conexion.conn))
                {
                    SqlCommand cmd = new SqlCommand("sp_ActivarLogicaSupervisor", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_Supervisor", id);
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }

        }

}
