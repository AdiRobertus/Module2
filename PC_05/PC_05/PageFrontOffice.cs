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
    public partial class PageFrontOffice : UserControl
    {
        public PageFrontOffice()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            masterRoomType1.BringToFront();
        }

        private void masterRoomType1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            masterRoom1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            masterItem1.BringToFront();
        }
    }
}
