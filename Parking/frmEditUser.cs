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
    public partial class frmEditUser : Form
    {
        #region Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int ID { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// This Method Will Load The Data
        /// </summary>
        private void LoadData()
        {
            txtFirstName.Text = this.FirstName;
            txtLastName.Text = this.LastName;
            txtUsername.Text = this.Username;
            txtPassword.Text = this.Password;
        }

        #endregion

        public frmEditUser()
        {
            InitializeComponent();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مایل به ویرایش هستید؟", "اطلاع", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //ارتباط با دیتابیس
                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = "server=.;initial catalog=Parking;integrated security=true";


                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = "update [Usser] set [name]=@name,[family]=@family,[Username]=@username,[password]=@password where ID=@ID ";
                myCommand.Parameters.AddWithValue("@name", txtFirstName.Text);
                myCommand.Parameters.AddWithValue("@family", txtLastName.Text);
                myCommand.Parameters.AddWithValue("@username", txtUsername.Text);
                myCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                myCommand.Parameters.AddWithValue("@ID", this.ID);


                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("عملیات با موفقیت انجام شد");

                this.Close();
            }
        }
    }
}
