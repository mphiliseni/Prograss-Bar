using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograssBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dir = 1;
        private void Strech_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value==100)
            {
                dir = -1; //reduce
            }
            else if (bunifuCircleProgressbar1.Value==0)
            {
                dir = +1; // expand 
            }
            bunifuCircleProgressbar1.Value += dir;
        }
    }
}
