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
    public partial class MasterEmployee : UserControl
    {
        private enum Mode { Insert, Update };
        private Mode ModMode;

        public MasterEmployee()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UpdateDatagrid()
        {
            DataSet ds = DB.GetDataset("select Employee.ID, Username, Employee.Name, Email, DateOfBirth, Job.Name as Job, Address from Employee join job on JobID=job.id");
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].Visible = false;

            DataSet ds2 = DB.GetDataset("SELECT ID, Name FROM Job");
            comboBox1.DataSource = ds2.Tables[0];
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";
            comboBox1.SelectedIndex = 0;
        }

        private void MasterEmployee_Load(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                textBox1.Text = dr.Cells[1].Value.ToString();
                textBox3.Text = dr.Cells[2].Value.ToString();
                textBox5.Text = dr.Cells[3].Value.ToString();

                comboBox1.SelectedItem = dr.Cells[5].Value.ToString();

                dateTimePicker1.Value = DateTime.Parse(dr.Cells[4].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = true;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = null;

            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;

            ModMode = Mode.Insert;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = true;

            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;

            ModMode = Mode.Update;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DB.ExecNonQuery($"DELETE FROM Employee WHERE ID={id}");
                UpdateDatagrid();
            }
            else
            {
                button1.Enabled = button2.Enabled = button3.Enabled = false;
                button4.Enabled = button5.Enabled = true;

                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = true;

                dateTimePicker1.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Invalid input detected or invalid password!");
                return;
            }

            if (ModMode == Mode.Insert)
            {
                DB.ExecNonQuery($"INSERT INTO Employee VALUES ('{textBox1.Text}', '{DB.SHA256Hash(textBox4.Text)}', '{textBox3.Text}', '{textBox5.Text}', '{textBox6.Text}', convert(date, '{dateTimePicker1.Value.ToString("dd/MM/yyyy")}', 103), {comboBox1.SelectedValue})");
            }
            else if (ModMode == Mode.Update)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DB.ExecNonQuery($"UPDATE Employee SET Username='{textBox1.Text}', Password='{DB.SHA256Hash(textBox4.Text)}', Name='{textBox3.Text}', Email='{textBox5.Text}', Address='{textBox6.Text}', DateOfBirth=convert(date, '{dateTimePicker1.Value.ToString("dd/MM/yyyy")}', 103), JobID={comboBox1.SelectedValue} WHERE ID={id}");
            }

            UpdateDatagrid();

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = false;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = false;

            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = false;

            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = false;

            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
        }

        private bool ValidateInput()
        {
            if(ModMode == Mode.Insert)
            {
                if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox3.Text == null || textBox5.Text == null || textBox6.Text == null)
                    return false;
                else
                    return true;
            }
            else
            {
                if (textBox1.Text == null || textBox3.Text == null || textBox5.Text == null || textBox6.Text == null || textBox2.Text != textBox4.Text)
                    return false;
                else
                    return true;
            }

        }
    }
}
