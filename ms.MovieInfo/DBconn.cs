using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ms.MovieInfo.Models;
using MySql.Data;

namespace ms.MovieInfo
{
    public class MoviePersistence
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;

        public MoviePersistence()
        {
            String myConnectionString;

            string server = "127.0.0.1";
            string database = "";
            string user = "";
            string password = "";
            string port = "";

            myConnectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4};", server, port, user, password, database);
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

        }
        public long saveMovie(Movie movieToSave)

        {
            string sqlString = "INSERT INTO `Movies`() VALUES ()";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;


        }
        
        public long deleteMovie(int id)

        {
            string sqlString = "Delete INTO `Movies`() VALUES ()";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;


        }
        // Search on title, handle input error, will always return a list.
        public long SearchForMovie(String title)

        {
            string sqlString = "Select From `Movies' WHERE ID =";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;


        }
        //
        public long findOneMovie(int id)

        {
            string sqlString = "Select From `Movies' WHERE ID =";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;


        }
   
        // Update movie bases on ID.
        public long updateMovie(int id, Movie movieToDelete)

        {
            string sqlString = "Delete INTO `Movies`() VALUES ()";

            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;


        }
    }
}

