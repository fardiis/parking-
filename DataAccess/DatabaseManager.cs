using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class DatabaseManager
    {
        string connectionString= "server=.;initial catalog=Parking;integrated security=true";

        public bool ExecuteCommand(string command,List<SqlParameter> parameters)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = connectionString;
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = command;
            foreach(SqlParameter param in parameters)
            {
                myCommand.Parameters.Add(param);
            }
            try
            {
                myConnection.Open();
                int result= myCommand.ExecuteNonQuery();
                myConnection.Close();
                if (result>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetData(string command)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = connectionString;
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = command;
            DataTable result = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;

            try
            {
                myDataAdapter.Fill(result);
                return result;
            }
            catch
            {
                return null;
            }
        }

    }
}
