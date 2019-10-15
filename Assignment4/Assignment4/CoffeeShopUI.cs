using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class CoffeeShopUI : Form
    {
        const int size = 10;

        List<string> customerName = new List<string> { };
        List<int> customerContact = new List<int> { };
        List<string> customerAddress = new List<string> { };
        List<string> customerOrder = new List<string> { };
        List<int> orderQuantity = new List<int> { };
        List<int> prices = new List<int> { };
        List<int> totalPrice = new List<int> { };


        public CoffeeShopUI()
        {
            InitializeComponent();
        }

        private void AddCustomer(string name, int contact, string address, string order, int quantity)
        {
            

            //nt price = 0;
            int orderValue = 0;

            customerName.Add(name);
            customerContact.Add(contact);
            customerAddress.Add(address);
            customerOrder.Add(order);
            orderQuantity.Add(quantity);
            prices.Add(orderValue);



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

            totalPrice.Add(orderValue * quantity);




           
        }
    

        private void ShowCustomer(int listStart, int listEnd)
        {
            /* for (int i = listStart; i < listEnd; i++)
                 richTextBox.Text = richTextBox.Text + "Customer Name : " + customerName + "\n" +
                 "\nContact : " + customerContact +
                  "\nAddress : " + customerAddress +
                  "\nOrder : " + customerOrder +
                  "\nQuantity : " + orderQuantity +
                  "\nTotal Price : " + totalPrice + "\n";*/
            for (int i = listStart; i < listEnd; i++)
            {
                richTextBox.Text += "Customer Name : " + customerName[i] + "\n";
                richTextBox.Text += "\nContact : " + customerContact[i] + "\n";
                richTextBox.Text += "\nAddress : " + customerAddress[i];
                richTextBox.Text += "\nOrder : " + customerOrder[i];
                richTextBox.Text += "\nQuantity : " + orderQuantity[i];
                richTextBox.Text += "\nTotal Price : " + totalPrice[i] + "\n";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {

            if (!customerContact.Contains(Convert.ToInt32(contactTextBox.Text)) && orderTextBox.Text != " Select one" && !String.IsNullOrEmpty(quantityTextBox.Text))
            {

                AddCustomer(nameTextBox.Text, Convert.ToInt32(contactTextBox.Text), addressTextBox.Text,  orderTextBox.Text, Convert.ToInt32(quantityTextBox.Text));

            }
            else
            {

                if (customerContact.Contains(Convert.ToInt32(contactTextBox.Text)))
                {
                    MessageBox.Show("This number is already added !");
                }
                else if (orderTextBox.Text == " Select an item")
                {
                    MessageBox.Show(" Nothing selected");
                }
                else if (String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    MessageBox.Show("Enter Quanitity");

                }
                return;
            }
            Reset();
            ShowCustomer(customerName.Count - 1, customerName.Count);


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer(0, customerName.Count);
        }

        private void ResetButton1_Click(object sender, EventArgs e)
        {
            private void Reset()
            {
                NameTextBox1.Text = " ";
                ContactTextBox2.Text = " ";
                AddressTextBox3.Text = " ";
                QuantityTextBox5.Text = null;
                OrderComboBox1.Text = "select One";
                richTextBox1.Text = " ";
            }
        }
    }
}

