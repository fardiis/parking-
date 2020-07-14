using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Business
{
    public class Usser
    {
        #region Properties

        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        #endregion

        #region Crud

        public bool Insert()
        {
            try
            {
                //ارتباط با دیتابیس
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = "INSERT into [Usser](name,family,username,password) values(@name,@family,@username,@password)";
                myCommand.Parameters.AddWithValue("@name", this.Name);
                myCommand.Parameters.AddWithValue("@family", this.Family);
                myCommand.Parameters.AddWithValue("@username", this.Username);
                myCommand.Parameters.AddWithValue("@password", this.Password);

                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }          
        }

        #endregion

        #region Methods

        public bool GetUserByLoginInfo()
        {
            //ارتباط با دیتابیس
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "Select * from [usser] where [Username]=@username and [Password]=@password";
            myCommand.Parameters.AddWithValue("@username", this.Username);
            myCommand.Parameters.AddWithValue("@password", this.Password);


            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;

            try
            {
                myDataAdapter.Fill(myDataTable);
            }
            catch
            {
                //throw;
                return false;
            }

            if (myDataTable.Rows.Count == 0)//کاربر معتبر نیست
                return false;
            else
                return true;
        }

        #endregion
    }
}
