using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DatabaseManager
{
    public class ExerciseDatabaseManager
    {
        public static void GetAll()
        {
            MySqlDatabaseLogger logger = new MySqlDatabaseLogger();
            logger.Log();

            if (logger.Connection != null)
            {
                MySqlDataReader rdr = null;
                string stm = "SELECT * FROM exercise";
                MySqlCommand cmd = new MySqlCommand(stm, logger.Connection);
                rdr = cmd.ExecuteReader();

                Debug.WriteLine("QUERY RESULTS");

                while (rdr.Read())
                {
                    Debug.WriteLine(rdr.GetInt32("ID") + "| " + rdr.GetString("Name") + "| " + rdr.GetString("Description"));
                }       
            }

            logger.LogOff();

        }

        public static List<String> GetNames()
        {
            List<String> names = new List<String>();

            MySqlDatabaseLogger logger = new MySqlDatabaseLogger();

            logger.Log();

            if (logger.Connection != null)
            {
                MySqlDataReader rdr = null;
                string stm = "SELECT Name FROM exercise";
                MySqlCommand cmd = new MySqlCommand(stm, logger.Connection);
                rdr = cmd.ExecuteReader();

                Debug.WriteLine("QUERY RESULTS FOR EXERCISE NAME");

                while (rdr.Read())
                {
                    string exercisename = rdr.GetString("Name");
                    Debug.WriteLine(exercisename);
                    names.Add(exercisename);

                }
            }

            logger.LogOff();

            return names;
        }
    }
}
