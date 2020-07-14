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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ثبتکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser frmUser = new Parking.frmNewUser();
            frmUser.Show();
        }

        private void لیستکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frmList = new Parking.frmUsersList();
            frmList.ShowDialog();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Form1 frmLogin = new Parking.Form1();
            frmLogin.ShowDialog();
        }

        private void ثبتشخصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmNewPerson frmNewPerson = new UI.frmNewPerson();
            frmNewPerson.ShowDialog();
        }

        private void لیستاشخاصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmPersonsList frmPersonsList = new UI.frmPersonsList();
            frmPersonsList.ShowDialog();
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
