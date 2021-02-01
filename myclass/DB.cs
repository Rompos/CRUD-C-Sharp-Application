using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD_Application_C_SHARP.myclass
{
    class DB
    {
        public MySqlConnection con;

        public DB()
        {
            string host = "dspai.kastoria.teiwm.gr";
            string db = "world";
            string port = "3306";
            string user = "k702910";
            string pass = "K@$t0r1@";
            string constring = "datasource =" + host + "; database = " + db + "; port =" + port + "; username =" + user + "; password =" + pass + "; SslMode=none";

            con = new MySqlConnection(constring);
        }
    }

    class CRUD : DB
    {
        //Properties
        public string Name { set; get; }
        public string CountryCode { set; get; }
        public string District { set; get; }
        public string Population { set; get; }

        //FOR ID
        public string ID { set; get; }//used for update/delete function

        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        //CREATE Function

        public void Create_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO  `City` (`Name`,`CountryCode`,`District`,`Population`)VALUES(@Name, @CountryCode, @District, @Population)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@CountryCode", MySqlDbType.VarChar).Value = CountryCode;
                cmd.Parameters.Add("@District", MySqlDbType.VarChar).Value = District;
                cmd.Parameters.Add("@Population", MySqlDbType.VarChar).Value = Population;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //UPDATE function
        public void Update_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE City SET Name=@Name,CountryCode=@CountryCode,District=@District,Population=@Population WHERE ID = @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@CountryCode", MySqlDbType.VarChar).Value = CountryCode;
                cmd.Parameters.Add("@District", MySqlDbType.VarChar).Value = District;
                cmd.Parameters.Add("@Population", MySqlDbType.VarChar).Value = Population;
                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ID;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //DELETE Function
        public void Delete_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM City WHERE ID = @ID";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("@CountryCode", MySqlDbType.VarChar).Value = CountryCode;
                cmd.Parameters.Add("@District", MySqlDbType.VarChar).Value = District;
                cmd.Parameters.Add("@Population", MySqlDbType.VarChar).Value = Population;
                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ID;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        
        //READ Function
        public void Read_Data()
        {
            dt.Clear();
            //The first letter of City is capital letter
            string query = "SELECT * FROM `City`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query,con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }


    }

}
