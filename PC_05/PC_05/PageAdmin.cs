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
    public partial class PageAdmin : UserControl
    {
        public PageAdmin()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterEmployee1.Visible ^= true;
        }
    }
}
