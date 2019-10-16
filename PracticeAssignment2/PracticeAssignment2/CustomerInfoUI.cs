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
            const int size = 1;

            string[] customerName = new string[size];
            int[] customerContact = new int[size];
            string[] customerAddress = new string[size];
            string[] customerOrder = new string[size];
            int[] orderQuantity = new int[size];
            int[] price = new int[size];

            for (int index = 0; index < size; index++)
            {
                customerName[index] = customerTextBox.Text;
                customerContact[index] = Convert.ToInt32(contactTextBox.Text);
                customerAddress[index] = AddressTextBox.Text;
                customerOrder[index] = orderTextBox.Text;
                orderQuantity[index] = Convert.ToInt32(quantityTextBox.Text);


                int orderValue = 0;

                if (customerOrder[index] == "Black")
                {
                    orderValue = 120;
                }
                else if (customerOrder[index] == "Hold")
                {
                    orderValue = 100;
                }
                else if (customerOrder[index] == "Cold")
                {
                    orderValue = 90;
                }
                else
                {
                    orderValue = 80;
                }

                price[index] = orderQuantity[index] * orderValue;




                RichTextBox.Text = RichTextBox.Text + "Customer Name : " + customerName[index] +
                  "\nContact : " + customerContact[index] +
                  "\nAddress : " + customerAddress[index] +
                  "\nOrder : " + customerOrder[index] +
                  "\nQuantity : " + orderQuantity[index] +
                  "\nTotal Price : " + price[index] + "\n";

            }

        



    }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
        /*    const int size = 1;

            string[] customerName = new string[size];
            int[] customerContact = new int[size];
            string[] customerAddress = new string[size];
            string[] customerOrder = new string[size];
            int[] orderQuantity = new int[size];
            int[] price = new int[size];

            for (int index = 0; index < size; index++)
            {
                customerName[index] = customerTextBox.Text;
                customerContact[index] = Convert.ToInt32(contactTextBox.Text);
                customerAddress[index] = AddressTextBox.Text;
                customerOrder[index] = orderTextBox.Text;
                orderQuantity[index] = Convert.ToInt32(quantityTextBox.Text);


                int orderValue = 0;

                if (customerOrder[index] == "Black")
                {
                    orderValue = 120;
                }
                else if (customerOrder[index] == "Hold")
                {
                    orderValue = 100;
                }
                else if (customerOrder[index] == "Cold")
                {
                    orderValue = 90;
                }
                else
                {
                    orderValue = 80;
                }

                price[index] = orderQuantity[index] * orderValue;




                RichTextBox.Text = RichTextBox.Text + "Customer Name : " + customerName[index] +
                  "\nContact : " + customerContact[index] +
                  "\nAddress : " + customerAddress[index] +
                  "\nOrder : " + customerOrder[index] +
                  "\nQuantity : " + orderQuantity[index] +
                  "\nTotal Price : " + price[index] + "\n";

            }*/

        } 
    }
}
