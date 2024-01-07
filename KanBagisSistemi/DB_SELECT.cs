using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace KanBagisSistemi
{
    internal class DB_SELECT
    {



        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("server=35.246.162.48; port=5432; Database=proje; user Id=postgres; password=ora123;");
        }

        private NpgsqlCommand cmd;
        private string sql;
        private DataTable dt;

        private void get_kanbagislayanlar_with_hemsireid(int h_id)
        {

            using(var conn=GetConnection()) 
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("get_kanbagislayanlar_with_hemsireid", conn);
                cmd.Parameters.AddWithValue(new NpgsqlParameter("h_id",DbType.Int32)).Value=h_id;
                cmd.CommandType = CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    Console.WriteLine(reader[""]);
                }
            }
        }

        private void Insert(string kimlikno,string kangrupad,string hastasemt,string hemsiread,string hastaad,string hastasoyad,string hastaadres,string hastatelno,string hastayas,string sonkanbagis,string hastaemail,bool covidtest)
        {
            try
            {
               
                GetConnection().Open();  //bağlantı açıldı
                sql = @"select * from textboxs_insert(:_kimlikno,:_kangrupad,:_hastasemt,:_hemsiread,:_hastaad,:_hastasoyad,:_hastaadres,:_hastatelno,:_hastayas,:_sonkanbagis,:_hastaemail,:_covidtest)";
                cmd = new NpgsqlCommand(sql, GetConnection());
                cmd.Parameters.AddWithValue("_kimlikno",kimlikno);
                cmd.Parameters.AddWithValue("_kangrupad", kangrupad);
                cmd.Parameters.AddWithValue("_hastasemt", hastasemt);
                cmd.Parameters.AddWithValue("_hemsiread",hemsiread);
                cmd.Parameters.AddWithValue("_hastaad", hastaad);
                cmd.Parameters.AddWithValue("_hastasoyad",hastasoyad);
                cmd.Parameters.AddWithValue("_hastaadres", hastaadres);
                cmd.Parameters.AddWithValue("_hastatelno",hastatelno);
                cmd.Parameters.AddWithValue("_hastayas", int.Parse(hastayas));
                cmd.Parameters.AddWithValue("_sonkanbagis",sonkanbagis);
                cmd.Parameters.AddWithValue("_hastaemail",hastaemail);
                cmd.Parameters.AddWithValue("_covidtest", covidtest);
                dt.Load(cmd.ExecuteReader());
                GetConnection().Close();   //bağlantı kapandı

            }
            catch (Exception ex)
            {
                GetConnection().Close();
                MessageBox.Show("Error: " + ex.Message);
            }

        }

    }
}
