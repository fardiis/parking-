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
    public partial class frmPersonsList : Form
    {
        public frmPersonsList()
        {
            InitializeComponent();
        }

        private void frmPersonsList_Load(object sender, EventArgs e)
        {
            Business.Person persons = new Business.Person();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = persons.Read();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
