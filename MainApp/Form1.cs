using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new PizzaApp();
            frm.Show();
        }
        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            Form frm = new TicTacToe();
            frm.Show();
        }
    }
}
