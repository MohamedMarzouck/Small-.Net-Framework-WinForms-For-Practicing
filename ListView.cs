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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text.Trim()) || string.IsNullOrWhiteSpace(tbPhone.Text.Trim())
                || string.IsNullOrWhiteSpace(tbName.Text.Trim()) || string.IsNullOrWhiteSpace(tbEmail.Text.Trim())) return;

            ListViewItem Item = new ListViewItem(tbID.Text.Trim());

            if (rbMale.Checked) Item.ImageIndex = 0;
            else Item.ImageIndex = 1;

            Item.SubItems.Add(tbName.Text.Trim());
            Item.SubItems.Add(tbPhone.Text.Trim());
            Item.SubItems.Add(tbEmail.Text.Trim());
            listView1.Items.Add(Item);

            tbID.Clear();
            tbName.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            tbID.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0 && listView1.SelectedItems.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void MouseClickOption(object sender, MouseEventArgs e)
        {
            

        }

     
    }
}
