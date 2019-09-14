using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeAssignment2
{
    public partial class CustomerInfoUI : Form
    {
        public CustomerInfoUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String name = customerTextBox.Text;
            int contact = Convert.ToInt32(contactTextBox.Text);
            String address = AddressTextBox.Text;
            String order = orderTextBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);

            int price = 0;
            int orderValue = 0;

            if (order == "Black")
            {
                orderValue = 120;
            }
            else if (order == "Hold")
            {
                orderValue = 100;
            }
            else if (order == "Cold")
            {
                orderValue = 90;
            }
            else
            {
                orderValue = 80;
            }

            price = quantity * orderValue;


            RichTextBox.Text = "Customer Name : " + name + 
                "\nContact : " + contact + 
                "\nAddress : " + address + 
                "\nOrder : " + order + 
                "\nQuantity : " + quantity + 
                "\nTotal Price : " + price;
        }
    }
}
