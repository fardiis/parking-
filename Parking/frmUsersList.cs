using Parking.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class frmUsersList : Form
    {

        public void ReadFromDatabase()
        {
            //ارتباط با دیتابیس
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "Select * from [usser]";

            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;
            myDataAdapter.Fill(myDataTable);

            // dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = myDataTable;
        }

        public void SearchDatabase()
        {
            //ارتباط با دیتابیس
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";

            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "Select * from [usser] where Family like @family or [Name] like @name";
            myCommand.Parameters.AddWithValue("@family","%"+txtSearchParameter.Text+"%");
            myCommand.Parameters.AddWithValue("@name", "%" + txtSearchParameter.Text + "%");

            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = myCommand;
            myDataAdapter.Fill(myDataTable);

            // dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = myDataTable;
        }

        public frmUsersList()
        {
            InitializeComponent();
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            ReadFromDatabase();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //test
            MessageBox.Show(dataGridView1.CurrentRow.Cells["clmnID"].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به حذف هستید؟", "هشدار", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                //ارتباط با دیتابیس
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";

                //Insert into TableName(coulmns) values('','','')
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = "delete from [usser] where ID=@ID";
                myCommand.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells["clmnID"].Value);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("عملیات با موفقیت انجام شد");

                ReadFromDatabase();             
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchParameter.Text != string.Empty)
                SearchDatabase();
            else
                ReadFromDatabase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new Parking.frmEditUser();

            #region Set Properties

            frmEditUser.FirstName = dataGridView1.CurrentRow.Cells["clmnName"].Value.ToString();
            frmEditUser.LastName = dataGridView1.CurrentRow.Cells["clmnFamily"].Value.ToString();
            frmEditUser.Username = dataGridView1.CurrentRow.Cells["clmnUsername"].Value.ToString();
            frmEditUser.Password = dataGridView1.CurrentRow.Cells["clmnPassword"].Value.ToString();
            frmEditUser.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clmnID"].Value);

            #endregion

            frmEditUser.ShowDialog();

            ReadFromDatabase();
           
        }
    }
}
