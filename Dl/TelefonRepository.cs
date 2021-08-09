using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using MySql;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dl
{
    public class TelefonRepository
    {
       
        public List<Telefon> GetAll()

        {
            List<Telefon> result = new List<Telefon>();
            MySqlConnection conn = new MySqlConnection("Server=localhost; Port=3306;Database=db1;Uid=root;Pwd=router;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from db1.urunler", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Telefon telefon = new Telefon();
                telefon.Id = dr.GetInt32(dr.GetOrdinal("Urun_Id"));
                telefon.Name = dr.GetString(dr.GetOrdinal("Urun_Name"));
                telefon.Brand = dr.GetString(dr.GetOrdinal("Urun_Brand"));
                result.Add(telefon);
            }
            conn.Close();
            return result;
        }
        public void Update(Telefon telefon)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost; Port=3306;Database=db1;Uid=root;Pwd=router;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Update db1.urunler Set Urun_Id=@id,Urun_Name=@name,Urun_Brand=@brand Where Urun_Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(telefon.Id));
            cmd.Parameters.AddWithValue("@name", telefon.Name);
            cmd.Parameters.AddWithValue("@brand", telefon.Brand);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(Telefon telefon)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost; Port=3306;Database=db1;Uid=root;Pwd=router;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Delete From db1.urunler Where Urun_Id=@id", conn);
            cmd.Parameters.AddWithValue("@no", telefon.Id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Add(Telefon telefon)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost; Port=3306;Database=db1;Uid=root;Pwd=router;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Insert into db1.urunler (Urun_Id,Urun_Name,Urun_Brand) values (@id,@name,@brand)", conn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(telefon.Id));
            cmd.Parameters.AddWithValue("@name", telefon.Name);
            cmd.Parameters.AddWithValue("@brand", telefon.Brand);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Telefon Get(int id)
        {
            
            Telefon result = new Telefon();
            MySqlConnection conn = new MySqlConnection("Server=localhost; Port=3306;Database=db1;Uid=root;Pwd=router;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from db1.urunler where Urun_Id='"+ id + "'", conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                result.Id = dr.GetInt32(dr.GetOrdinal("Urun_Id"));
                result.Name = dr.GetString(dr.GetOrdinal("Urun_Name"));
                result.Brand = dr.GetString(dr.GetOrdinal("Urun_Brand"));
                
            }
            conn.Close();
            return result;
        }
    }
}
