using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Class for logging to a MySql database.
    /// </summary>
    public class MySqlDatabaseLogger
    {
        #region Fields

        //generate a mysqlconnection object
        MySqlConnection conn = null;

        #endregion

        #region Bindings

        /// <summary>
        /// Binding for the mysqlconnection
        /// </summary>
        public MySqlConnection Connection
        {
            get
            {
                return conn;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method to establish a connection to a specified mysql database.
        /// </summary>
        public void Log()
        {
            //string to provide access to the database
            string cs = @"server=localhost;userid=marcfoelster;
            password=karate91test;database=world";

            //try establishing a connection
            try
            {
                //initialize a new connection
                conn = new MySqlConnection(cs);
                //open the connection
                conn.Open();
                //notify developer of successfully connection to the database
                Debug.WriteLine("MYSQL CONNECTION SUCCESSFULLY ESTABLISHED!!!");
                //print out the current mysql version to the debugger
                Debug.WriteLine(string.Format("MySQL version : {0}", conn.ServerVersion));

            }
            //catch the mysqlexception
            catch (MySqlException ex)
            {
                //notify developer of failed connection to the database
                Debug.WriteLine("ATTENTION: MYSQL CONNECTION ERROR!!!");
                //print out the exception to the debugger output window
                Debug.WriteLine(string.Format("Error: {0}", ex.ToString()));

            }
        }

        /// <summary>
        /// Method to log off.
        /// </summary>
        public void LogOff()
        {
            //check if an connection is established
            if (conn != null)
            {
                //close the connection
                conn.Close();
            }
        }

        #endregion

    }
}
