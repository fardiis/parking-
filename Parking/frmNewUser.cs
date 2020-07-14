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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Business.Usser newUser = new Business.Usser();

            //Set Properties
            newUser.Name = txtName.Text;
            newUser.Family = txtFamily.Text;
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;

            bool result = newUser.Insert();

            if (result == true)
                MessageBox.Show("کاربر ثبت شد");
            else
                MessageBox.Show("عملیات با خطا مواجه شد");
        }
    }
}
