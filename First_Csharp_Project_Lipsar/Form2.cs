using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Csharp_Project_Lipsar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int clickCost = 100;
        public int clicksSumm = 0;
        public int bankStorage = 12000;
        public int lvlupClick = 10000;
        public int lvlupBank = 12000;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((clicksSumm + clickCost) <= bankStorage)
            {
                clicksSumm += clickCost;
                label1.Text = "Total Money:" + clicksSumm.ToString() + "$";
            }
            else
            {
                MessageBox.Show("You need to lvl up Bank Storage", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicksSumm >= lvlupClick)
            {
                clickCost *= 2;
                clicksSumm -= lvlupClick;
                label1.Text = "Total Money:" + clicksSumm.ToString() + "$";
                lvlupClick *= 2;
                label2.Text = "Level up costs:" + lvlupClick.ToString() + "$";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (clicksSumm >= lvlupBank)
            {
                bankStorage *= 2;
                clicksSumm -= lvlupBank;
                label1.Text = "Total Money:" + clicksSumm.ToString() + "$";
                lvlupBank *= 2;
                label3.Text = "Level up costs:" + lvlupBank.ToString() + "$";
            }
        }
    }
}
