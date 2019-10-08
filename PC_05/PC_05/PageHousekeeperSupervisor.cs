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
    public partial class PageHousekeeperSupervisor : UserControl
    {
        public PageHousekeeperSupervisor()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addHousekeepingSchedule1.Visible ^= true;
        }
    }
}
