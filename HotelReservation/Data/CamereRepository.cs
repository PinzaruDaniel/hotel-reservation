using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HotelReservation.Models;

namespace HotelReservation.Data
{
    public class CamereRepository
    {
        public List<Camera> GetAll()
        {
            var list = new List<Camera>();
            const string sql = "SELECT camera_id, numar_camera, tip_camera, pret_noapte, etaj, activa FROM camere ORDER BY numar_camera";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Camera
                        {
                            CameraId    = dr.GetInt32("camera_id"),
                            NumarCamera = dr.GetString("numar_camera"),
                            TipCamera   = dr.GetString("tip_camera"),
                            PretNoapte  = dr.GetDecimal("pret_noapte"),
                            Etaj        = dr.GetInt32("etaj"),
                            Activa      = dr.GetBoolean("activa")
                        });
                    }
                }
            }
            return list;
        }

        public List<Camera> GetActive()
        {
            var list = new List<Camera>();
            const string sql = "SELECT camera_id, numar_camera, tip_camera, pret_noapte, etaj, activa FROM camere WHERE activa=1 ORDER BY numar_camera";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Camera
                        {
                            CameraId    = dr.GetInt32("camera_id"),
                            NumarCamera = dr.GetString("numar_camera"),
                            TipCamera   = dr.GetString("tip_camera"),
                            PretNoapte  = dr.GetDecimal("pret_noapte"),
                            Etaj        = dr.GetInt32("etaj"),
                            Activa      = true
                        });
                    }
                }
            }
            return list;
        }

        public Camera GetById(int id)
        {
            const string sql = "SELECT camera_id, numar_camera, tip_camera, pret_noapte, etaj, activa FROM camere WHERE camera_id=@id";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Camera
                            {
                                CameraId    = dr.GetInt32("camera_id"),
                                NumarCamera = dr.GetString("numar_camera"),
                                TipCamera   = dr.GetString("tip_camera"),
                                PretNoapte  = dr.GetDecimal("pret_noapte"),
                                Etaj        = dr.GetInt32("etaj"),
                                Activa      = dr.GetBoolean("activa")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Insert(Camera c)
        {
            const string sql = "INSERT INTO camere (numar_camera, tip_camera, pret_noapte, etaj, activa) VALUES (@nr, @tip, @pret, @etaj, @activa)";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nr",     c.NumarCamera);
                    cmd.Parameters.AddWithValue("@tip",    c.TipCamera);
                    cmd.Parameters.AddWithValue("@pret",   c.PretNoapte);
                    cmd.Parameters.AddWithValue("@etaj",   c.Etaj);
                    cmd.Parameters.AddWithValue("@activa", c.Activa ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Camera c)
        {
            const string sql = "UPDATE camere SET numar_camera=@nr, tip_camera=@tip, pret_noapte=@pret, etaj=@etaj, activa=@activa WHERE camera_id=@id";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nr",     c.NumarCamera);
                    cmd.Parameters.AddWithValue("@tip",    c.TipCamera);
                    cmd.Parameters.AddWithValue("@pret",   c.PretNoapte);
                    cmd.Parameters.AddWithValue("@etaj",   c.Etaj);
                    cmd.Parameters.AddWithValue("@activa", c.Activa ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id",     c.CameraId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            const string sql = "DELETE FROM camere WHERE camera_id=@id";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Returns all rooms with their availability status over [start, end].
        /// Status: "Libera", "Ocupata", "Rezervata"
        /// </summary>
        public List<(Camera camera, string status)> GetAvailabilityMap(System.DateTime start, System.DateTime end)
        {
            var result = new List<(Camera, string)>();
            const string sql = @"
                SELECT c.camera_id, c.numar_camera, c.tip_camera, c.pret_noapte, c.etaj, c.activa,
                       COALESCE((
                           SELECT MAX(r.status_rezervare)
                           FROM rezervari r
                           WHERE r.camera_id = c.camera_id
                             AND r.status_rezervare = 'Confirmata'
                             AND r.data_checkin < @end
                             AND r.data_checkout > @start
                       ), 'Libera') AS status_calc
                FROM camere c
                WHERE c.activa = 1
                ORDER BY c.numar_camera";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end",   end);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var cam = new Camera
                            {
                                CameraId    = dr.GetInt32("camera_id"),
                                NumarCamera = dr.GetString("numar_camera"),
                                TipCamera   = dr.GetString("tip_camera"),
                                PretNoapte  = dr.GetDecimal("pret_noapte"),
                                Etaj        = dr.GetInt32("etaj"),
                                Activa      = true
                            };
                            var status = dr.IsDBNull(dr.GetOrdinal("status_calc"))
                                ? "Libera"
                                : dr.GetString("status_calc");
                            // Map "Confirmata" -> "Ocupata"
                            if (status == "Confirmata") status = "Ocupata";
                            result.Add((cam, status));
                        }
                    }
                }
            }
            return result;
        }
    }
}
