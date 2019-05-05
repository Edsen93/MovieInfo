using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ms.MovieInfo.Models;
using Npgsql;

namespace ms.MovieInfo
{
    // guide https://github.com/dalegambill/PostgreSql_and_Csharp/blob/master/PostgreSQL/PostGreSQL.cs
    public class MoviePersistence
    {
        Movie dummyMovie = new Movie();
        private NpgsqlConnection conn;

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
                conn = new NpgsqlConnection(myConnectionString);
                conn.Open();
            }
            catch (NpgsqlException ex)
            {

            }

        }
        public long saveMovie(Movie movieToSave)

        {
            string sqlString = "INSERT INTO `Movies`() VALUES ()";

            NpgsqlCommand cmd = new NpgsqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            return 1;


        }
        
        public void deleteMovie(int id)

        {
            string sqlString = "Delete INTO `Movies`() VALUES ()";

            NpgsqlCommand cmd = new NpgsqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
          


        }
        // Search on title, handle input error, will always return a list.
        public List<Movie> SearchForMovie(String title)

        {
            List<Movie> movies = new List<Movie>();
            string sqlString = "Select From `Movies' WHERE title =";
            Movie m = new Movie();

            NpgsqlCommand cmd = new NpgsqlCommand(sqlString, conn);
            NpgsqlDataReader dataReader = cmd.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                m.ID = (int)dataReader[0];
                m.title = dataReader[1].ToString();
                movies.Add(m);
            }
            return movies;


        }
        //
        public Movie findOneMovie(int id)

        {
            string sqlString = "Select From `Movies' WHERE ID =";

            NpgsqlCommand cmd = new NpgsqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
           
            return dummyMovie;


        }
   
        // Update movie bases on ID.
        public void updateMovie(int id, Movie movieToDelete)

        {
            string sqlString = "Delete INTO `Movies`() VALUES ()";

            NpgsqlCommand cmd = new NpgsqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();          

        }
    }
}

