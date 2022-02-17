using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Prueba1.Models;

namespace Prueba1.Data
{
    public class AreaData
    {
        public static bool RegistrarArea(Area oArea)

        {
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cantidad_Trabajador", oArea.cantidad_Trabajador);
                cmd.Parameters.AddWithValue("@nombre_Area", oArea.nombre_Area);
                cmd.Parameters.AddWithValue("@id_Supervisor_Area", oArea.id_Supervisor_Area);

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
        public static bool ActualizarArea(Area oArea)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id_Area", oArea.id_Area);
                cmd.Parameters.AddWithValue("@cantidad_Trabajador", oArea.cantidad_Trabajador);
                cmd.Parameters.AddWithValue("@nombre_Area", oArea.nombre_Area);
                cmd.Parameters.AddWithValue("@id_Supervisor_Area", oArea.id_Supervisor_Area);

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
        public static Area ObtenerIdArea(int idArea)
        {
            Area oArea = new Area();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerIdArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Area", idArea);
                try
                {
                    connection.Open();
                    cmd.ExecuteReader();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oArea = new Area()
                            {
                                id_Area = Convert.ToInt32(dr["id_Area"]),
                                cantidad_Trabajador = Convert.ToInt32(dr["cantidad_Trabajador"]),
                                nombre_Area = dr["nombre_Area"].ToString(),
                                id_Supervisor_Area = Convert.ToInt32(dr["id_Supervisor_Area"]),
                                estadoArea = Convert.ToInt32(dr["estadoArea"])

                            };
                        }
                    }
                    return oArea;
                }
                catch (Exception ex)
                {
                    return oArea;
                }
            }
        }
        public static List<Area> ObtenerArea()
        {
            List<Area> ObtenerArea = new List<Area>();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ObtenerArea.Add(new Area()
                            {
                                id_Area = Convert.ToInt32(dr["id_Area"]),
                                cantidad_Trabajador = Convert.ToInt32(dr["cantidad_Trabajador"]),
                                nombre_Area = dr["nombre_Area"].ToString(),
                                id_Supervisor_Area = Convert.ToInt32(dr["id_Supervisor_Area"]),
                                estadoArea = Convert.ToInt32(dr["estadoArea"])

                            });
                        }
                    }
                    return ObtenerArea;
                }
                catch (Exception ex)
                {
                    return ObtenerArea;
                }

            }
        }
        public static bool EliminarArea(int idArea)
        {
            Area oArea = new Area();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Area", idArea);
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
        public static bool EliminarLogicaArea(int id)
        {
            Area oArea = new Area();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarLogicaArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Area", id);
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
        public static bool ActivarLogicaArea(int id)
        {
            Area oArea = new Area();
            using (SqlConnection connection = new SqlConnection(Conexion.conn))
            {
                SqlCommand cmd = new SqlCommand("sp_ActivarLogicaArea", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Area", id);
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