using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Create Object
            Business.Usser currentUser = new Business.Usser();

            //Set Properties
            currentUser.Username = txtUsername.Text;
            currentUser.Password = txtPassword.Text;

            //Call Method
            bool result = currentUser.GetUserByLoginInfo();
                        
            if (result == true)
            {
                this.Close();
            }                
            else
                MessageBox.Show("اطلاعات وارد شده صحیح نیست");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
