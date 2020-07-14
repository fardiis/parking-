using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Business
{
    public class Person
    {
        #region Properties

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tell { get; set; }
        public string Cell { get; set; }
        public string NationalCode { get; set; }

        #endregion

        #region Crud

        public void Insert()
        {
            //ارتباط با دیتابیس
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "INSERT into [Person](FirstName,LastName,Tell,Cell,NationalCode) values(@FirstName,@LastName,@Tell,@Cell,@NationalCode)";
            myCommand.Parameters.AddWithValue("@FirstName", this.FirstName);
            myCommand.Parameters.AddWithValue("@LastName", this.LastName);
            myCommand.Parameters.AddWithValue("@Tell", this.Tell);
            myCommand.Parameters.AddWithValue("@Cell", this.Cell);
            myCommand.Parameters.AddWithValue("@NationalCode", this.NationalCode);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public List<Person> Read()
        {
            //ارتباط با دیتابیس
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=E:\Alborz\AlborzProject\Parking\ParkingDB.sdf";

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "Select * from [Person]";

            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;
            myDataAdapter.Fill(myDataTable);

            List<Person> lstResult = new List<Person>();
            foreach(DataRow r in myDataTable.Rows)
            {
                Person p1 = new Business.Person();
                p1.FirstName = r["FirstName"].ToString();
                p1.LastName = r["LastName"].ToString();
                lstResult.Add(p1);
            }

            return lstResult;
        }

        #endregion
    }
}
