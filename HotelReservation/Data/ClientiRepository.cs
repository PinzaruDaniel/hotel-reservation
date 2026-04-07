using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HotelReservation.Models;

namespace HotelReservation.Data
{
    public class ClientiRepository
    {
        public List<Client> GetAll()
        {
            var list = new List<Client>();
            const string sql = "SELECT client_id, nume, prenume, telefon, email, document_identitate FROM clienti ORDER BY nume, prenume";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Client
                        {
                            ClientId           = dr.GetInt32("client_id"),
                            Nume               = dr.GetString("nume"),
                            Prenume            = dr.GetString("prenume"),
                            Telefon            = dr.GetString("telefon"),
                            Email              = dr.IsDBNull(dr.GetOrdinal("email")) ? "" : dr.GetString("email"),
                            DocumentIdentitate = dr.GetString("document_identitate")
                        });
                    }
                }
            }
            return list;
        }

        public Client GetById(int id)
        {
            const string sql = "SELECT client_id, nume, prenume, telefon, email, document_identitate FROM clienti WHERE client_id=@id";
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
                            return new Client
                            {
                                ClientId           = dr.GetInt32("client_id"),
                                Nume               = dr.GetString("nume"),
                                Prenume            = dr.GetString("prenume"),
                                Telefon            = dr.GetString("telefon"),
                                Email              = dr.IsDBNull(dr.GetOrdinal("email")) ? "" : dr.GetString("email"),
                                DocumentIdentitate = dr.GetString("document_identitate")
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Insert(Client c)
        {
            const string sql = "INSERT INTO clienti (nume, prenume, telefon, email, document_identitate) VALUES (@nume, @prenume, @telefon, @email, @doc)";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nume",    c.Nume);
                    cmd.Parameters.AddWithValue("@prenume", c.Prenume);
                    cmd.Parameters.AddWithValue("@telefon", c.Telefon);
                    cmd.Parameters.AddWithValue("@email",   string.IsNullOrEmpty(c.Email) ? (object)System.DBNull.Value : c.Email);
                    cmd.Parameters.AddWithValue("@doc",     c.DocumentIdentitate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Client c)
        {
            const string sql = "UPDATE clienti SET nume=@nume, prenume=@prenume, telefon=@telefon, email=@email, document_identitate=@doc WHERE client_id=@id";
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nume",    c.Nume);
                    cmd.Parameters.AddWithValue("@prenume", c.Prenume);
                    cmd.Parameters.AddWithValue("@telefon", c.Telefon);
                    cmd.Parameters.AddWithValue("@email",   string.IsNullOrEmpty(c.Email) ? (object)System.DBNull.Value : c.Email);
                    cmd.Parameters.AddWithValue("@doc",     c.DocumentIdentitate);
                    cmd.Parameters.AddWithValue("@id",      c.ClientId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            const string sql = "DELETE FROM clienti WHERE client_id=@id";
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
    }
}
