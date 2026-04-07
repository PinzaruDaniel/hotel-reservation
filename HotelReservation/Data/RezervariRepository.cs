using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HotelReservation.Models;

namespace HotelReservation.Data
{
    public class RezervariRepository
    {
        public List<Rezervare> GetAll()
        {
            var list = new List<Rezervare>();
            const string sql = @"
                SELECT r.rezervare_id, r.client_id, r.camera_id,
                       r.data_checkin, r.data_checkout, r.status_rezervare, r.pret_total,
                       CONCAT(cl.nume, ' ', cl.prenume) AS nume_client,
                       c.numar_camera
                FROM rezervari r
                INNER JOIN clienti cl ON r.client_id = cl.client_id
                INNER JOIN camere  c  ON r.camera_id  = c.camera_id
                ORDER BY r.data_checkin DESC";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(MapRow(dr));
                    }
                }
            }
            return list;
        }

        public List<Rezervare> GetByPeriod(DateTime start, DateTime end)
        {
            var list = new List<Rezervare>();
            const string sql = @"
                SELECT r.rezervare_id, r.client_id, r.camera_id,
                       r.data_checkin, r.data_checkout, r.status_rezervare, r.pret_total,
                       CONCAT(cl.nume, ' ', cl.prenume) AS nume_client,
                       c.numar_camera
                FROM rezervari r
                INNER JOIN clienti cl ON r.client_id = cl.client_id
                INNER JOIN camere  c  ON r.camera_id  = c.camera_id
                WHERE r.data_checkin >= @start AND r.data_checkout <= @end
                ORDER BY r.data_checkin";
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
                            list.Add(MapRow(dr));
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Checks for overlapping confirmed reservations for the same room.
        /// Optionally excludes a reservation by id (for edit).
        /// </summary>
        public bool HasOverlap(int cameraId, DateTime checkin, DateTime checkout, int excludeId = 0)
        {
            const string sql = @"
                SELECT COUNT(*) FROM rezervari
                WHERE camera_id = @cameraId
                  AND status_rezervare = 'Confirmata'
                  AND data_checkin  < @checkout
                  AND data_checkout > @checkin
                  AND rezervare_id <> @excludeId";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cameraId",  cameraId);
                    cmd.Parameters.AddWithValue("@checkin",   checkin);
                    cmd.Parameters.AddWithValue("@checkout",  checkout);
                    cmd.Parameters.AddWithValue("@excludeId", excludeId);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void Insert(Rezervare r)
        {
            const string sql = @"
                INSERT INTO rezervari (client_id, camera_id, data_checkin, data_checkout, status_rezervare, pret_total)
                VALUES (@clientId, @cameraId, @checkin, @checkout, @status, @pret)";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@clientId", r.ClientId);
                    cmd.Parameters.AddWithValue("@cameraId", r.CameraId);
                    cmd.Parameters.AddWithValue("@checkin",  r.DataCheckin);
                    cmd.Parameters.AddWithValue("@checkout", r.DataCheckout);
                    cmd.Parameters.AddWithValue("@status",   r.StatusRezervare);
                    cmd.Parameters.AddWithValue("@pret",     r.PretTotal);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Rezervare r)
        {
            const string sql = @"
                UPDATE rezervari SET client_id=@clientId, camera_id=@cameraId,
                    data_checkin=@checkin, data_checkout=@checkout,
                    status_rezervare=@status, pret_total=@pret
                WHERE rezervare_id=@id";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@clientId", r.ClientId);
                    cmd.Parameters.AddWithValue("@cameraId", r.CameraId);
                    cmd.Parameters.AddWithValue("@checkin",  r.DataCheckin);
                    cmd.Parameters.AddWithValue("@checkout", r.DataCheckout);
                    cmd.Parameters.AddWithValue("@status",   r.StatusRezervare);
                    cmd.Parameters.AddWithValue("@pret",     r.PretTotal);
                    cmd.Parameters.AddWithValue("@id",       r.RezervareId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            const string sql = "DELETE FROM rezervari WHERE rezervare_id=@id";
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

        private static Rezervare MapRow(MySqlDataReader dr)
        {
            return new Rezervare
            {
                RezervareId     = dr.GetInt32("rezervare_id"),
                ClientId        = dr.GetInt32("client_id"),
                CameraId        = dr.GetInt32("camera_id"),
                DataCheckin     = dr.GetDateTime("data_checkin"),
                DataCheckout    = dr.GetDateTime("data_checkout"),
                StatusRezervare = dr.GetString("status_rezervare"),
                PretTotal       = dr.GetDecimal("pret_total"),
                NumeClient      = dr.GetString("nume_client"),
                NumarCamera     = dr.GetString("numar_camera")
            };
        }
    }
}
