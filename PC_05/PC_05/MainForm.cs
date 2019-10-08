using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_05
{
    public partial class MainForm : Form
    {
        public MainForm(int Job)
        {
            InitializeComponent();

            switch(Job)
            {
                case 1:
                    pageFrontOffice1.BringToFront();
                    break;
                case 4:
                    pageHousekeeper1.BringToFront();
                    break;
                case 6:
                    pageHousekeeperSupervisor1.BringToFront();
                    break;
                case 7:
                    pageAdmin1.BringToFront();
                    break;
            }
        }
    }
}
