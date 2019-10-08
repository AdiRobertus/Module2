using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_05
{
    public partial class AddHousekeepingSchedule : UserControl
    {
        public AddHousekeepingSchedule()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void AddHousekeepingSchedule_Load(object sender, EventArgs e)
        {
            DataSet ds = DB.GetDataset("select ID, Name from Employee where JobID=4");
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;

            DataSet ds2 = DB.GetDataset("select ID, RoomNumber from Room");
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "RoomNumber";
            comboBox2.SelectedIndex = 0;

            DataGridViewButtonColumn dgbc = new DataGridViewButtonColumn();
            dgbc.Text = "Remove";
            dataGridView1.Columns.Add(dgbc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: ;)");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
