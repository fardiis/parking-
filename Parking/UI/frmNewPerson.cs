using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.UI
{
    public partial class frmNewPerson : Form
    {
        public frmNewPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Business.Person newPerson = new Business.Person();

            newPerson.FirstName = txtFirstName.Text;
            newPerson.LastName = txtLastName.Text;
            newPerson.Tell = txtTell.Text;
            newPerson.Cell = txtCell.Text;
            newPerson.NationalCode = txtNationalCode.Text;

            newPerson.Insert();

            MessageBox.Show("عملیات با موفقیت انجام شد");


        }
    }
}
