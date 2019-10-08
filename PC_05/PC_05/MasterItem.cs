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
    public partial class MasterItem : UserControl
    {
        private enum Mode { Insert, Update };
        private Mode ModMode;

        public MasterItem()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UpdateDatagrid()
        {
            DataSet ds = DB.GetDataset("SELECT * FROM Item");
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].Visible = false;
        }

        private void MasterItem_Load(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                textBox1.Text = dr.Cells[1].Value.ToString();
                textBox2.Text = dr.Cells[2].Value.ToString();
                textBox3.Text = dr.Cells[3].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = true;
            textBox1.Text = textBox2.Text = textBox3.Text = null;

            ModMode = Mode.Insert;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = true;

            ModMode = Mode.Update;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DB.ExecNonQuery($"DELETE FROM Item WHERE ID={id}");
                UpdateDatagrid();
            }
            else
            {
                button1.Enabled = button2.Enabled = button3.Enabled = true;
                button4.Enabled = button5.Enabled = false;
            }
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
                DB.ExecNonQuery($"INSERT INTO Item VALUES ('{textBox1.Text}', {textBox2.Text}, {textBox3.Text})");
            }
            else if (ModMode == Mode.Update)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DB.ExecNonQuery($"UPDATE Item SET Name='{textBox1.Text}', RequestPrice={textBox2.Text}, CompensationFee={textBox3.Text} WHERE ID={id}");
            }

            UpdateDatagrid();

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = false;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = false;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = false;
        }

        private bool ValidateInput()
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || !int.TryParse(textBox2.Text, out int a) || !int.TryParse(textBox3.Text, out int b))
                return false;
            else
                return true;
        }
    }
}
