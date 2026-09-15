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
    public partial class PizzaApp : Form
    {
        public PizzaApp()
        {
            InitializeComponent();
        }

        private float TotalPrice()
        {
            float Total = 0;
            if (rbSmall.Checked) Total += Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked) Total += Convert.ToSingle(rbMedium.Tag);
            else if (rbLarge.Checked) Total += Convert.ToSingle(rbLarge.Tag);

            if (rbThickCrust.Checked) Total += Convert.ToSingle(rbThickCrust.Tag);
            if (rbEatIn.Checked) Total += Convert.ToSingle(rbEatIn.Tag);

            if (chbExtraCheese.Checked) Total += Convert.ToSingle(chbExtraCheese.Tag);
            if (chbMashroom.Checked) Total += Convert.ToSingle(chbMashroom.Tag);
            if (chbChilies.Checked) Total += Convert.ToSingle(chbChilies.Tag);
            if (chbOlives.Checked) Total += Convert.ToSingle(chbOlives.Tag);
            if (chbOnion.Checked) Total += Convert.ToSingle(chbOnion.Tag);
            if (chbTomatoes.Checked) Total += Convert.ToSingle(chbTomatoes.Tag);

            return Total;
        }
        private void GetSummary()
        {
            if (rbSmall.Checked) lblSizeText.Text = rbSmall.Text;
            else if (rbMedium.Checked) lblSizeText.Text = rbMedium.Text;
            else if (rbLarge.Checked) lblSizeText.Text = rbLarge.Text;

            if (rbThinCrust.Checked) lblCrustTypeText.Text = rbThinCrust.Text;
            else if (rbThickCrust.Checked) lblCrustTypeText.Text = rbThickCrust.Text;

            if (rbEatIn.Checked) lblWhereToEat.Text = rbEatIn.Text;
            else if (rbTakeAway.Checked) lblWhereToEat.Text = rbTakeAway.Text;

            List<string> Toppings = new List<string>();
            if (chbExtraCheese.Checked) Toppings.Add(chbExtraCheese.Text);
            if (chbMashroom.Checked) Toppings.Add(chbMashroom.Text);
            if (chbTomatoes.Checked) Toppings.Add(chbTomatoes.Text);
            if (chbChilies.Checked) Toppings.Add(chbChilies.Text);
            if (chbOlives.Checked) Toppings.Add(chbOlives.Text);
            if (chbOnion.Checked) Toppings.Add(chbOnion.Text);

            lblToppingsText.Text = (Toppings.Count > 0) ? string.Join(", ", Toppings) : "No Toppings";
            lblPrice.Text = TotalPrice().ToString() + " $";
        }

        private void Option_CheckedChanged(object sender, MouseEventArgs e)
        {
            GetSummary();
            lblPrice.Text = TotalPrice().ToString() + " $";
        }

        private void OrderPizza()
        {
            if (MessageBox.Show("Are You Sure?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizze.Enabled = gbSize.Enabled = gbCrustType.Enabled = gbToppings.Enabled = gbWhereToEat.Enabled = false;
            }
        }
        private void btnOrderPizze_Click(object sender, EventArgs e)
        {
            OrderPizza();
        }
        private void Reset()
        {
            btnOrderPizze.Enabled = gbSize.Enabled = gbCrustType.Enabled = gbToppings.Enabled = gbWhereToEat.Enabled = true;
            rbSmall.Checked = rbThinCrust.Checked = rbTakeAway.Checked = true;

            chbExtraCheese.Checked = chbMashroom.Checked = chbChilies.Checked = chbOnion.Checked
                 = chbOlives.Checked  = chbTomatoes.Checked = false;

            lblToppingsText.Text = "No Toppings";
        }
        private void PizzaApp_Load(object sender, EventArgs e)
        {
            Reset();
            GetSummary();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }




    }
    
}
