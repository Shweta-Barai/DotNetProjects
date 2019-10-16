using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInformation_Assignment2
{
    public partial class CustomerInformationUI : Form
    {
        public CustomerInformationUI()
        {
            InitializeComponent();
        }

        private void cutomerName_TextChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void customerContact_TextChanged(object sender, EventArgs e)
        {


        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {


        }

        private void customerOrder_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void orderQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int price = 0; ;
            int priceText = 0;

            if (customerOrder.Text == "Black-120")
            {
                priceText = 120;
            }
            else if (customerOrder.Text == "Cold-100")
            {
                priceText = 100;
            }
            else if (customerOrder.Text == "Hot-90")
            {
                priceText = 90;
            }
            else
            {
                priceText = 80;
            }

            price = priceText * Convert.ToInt32(orderQuantity.Text);
            richTextBox1.Text = "Customer Name : " + customerName.Text + 
                "\nCustomer Contact : " + customerContact.Text + 
                "\nCustomer Address : " + customerAddress.Text + 
                "\nCustomer Order : " + customerOrder.Text + 
                "\nOrder Quantity : " + orderQuantity.Text + 
                "\nTotal Price : " + price;
        }   
    }
}
