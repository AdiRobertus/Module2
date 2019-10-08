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
    public partial class MasterRoom : UserControl
    {
        private enum Mode { Insert, Update };

        private Mode ModMode;

        public MasterRoom()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UpdateDatagrid()
        {
            DataSet ds = DB.GetDataset("SELECT Room.ID, Room.RoomNumber, RoomType.Name, Room.RoomFloor, Room.Description from Room JOIN RoomType ON Room.RoomTypeID=RoomType.ID");
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].Visible = false;

            DataSet ds2 = DB.GetDataset("SELECT ID, Name FROM RoomType");
            comboBox1.DataSource = ds2.Tables[0];
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = true;
            comboBox1.Enabled = true;

            textBox1.Text = textBox2.Text = null;

            ModMode = Mode.Insert;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = true;
            comboBox1.Enabled = true;

            ModMode = Mode.Update;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = false;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = comboBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Invalid input detected!");
                return;
            }

            if (ModMode == Mode.Insert)
            {
                DB.ExecNonQuery($"INSERT INTO Room VALUES ({comboBox1.SelectedValue}, {textBox1.Text}, {textBox2.Text}, '{textBox3.Text}')");
            }
            else if (ModMode == Mode.Update)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DB.ExecNonQuery($"UPDATE Room SET RoomNumber={textBox1.Text}, RoomTypeID={comboBox1.SelectedValue}, RoomFloor={textBox2.Text}, Description='{textBox3.Text}' WHERE ID={id}");
            }

            UpdateDatagrid();

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DB.ExecNonQuery($"DELETE FROM Room WHERE ID={id}");
                UpdateDatagrid();
            }
            else
            {
                button1.Enabled = button2.Enabled = button3.Enabled = true;
                button4.Enabled = button5.Enabled = false;

                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = comboBox1.Enabled = false;
            }
        }

        private bool ValidateInput()
        {
            if (textBox1.Text == null || textBox2.Text == null || !int.TryParse(textBox1.Text, out int a) || !int.TryParse(textBox2.Text, out int b))
                return false;
            else
                return true;
        }

        private void MasterRoom_Load(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                textBox1.Text = dr.Cells[1].Value.ToString();
                comboBox1.SelectedItem = dr.Cells[2].Value.ToString();
                textBox2.Text = dr.Cells[3].Value.ToString();
                textBox3.Text = dr.Cells[4].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
