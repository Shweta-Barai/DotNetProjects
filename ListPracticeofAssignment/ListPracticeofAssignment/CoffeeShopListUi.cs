using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListPracticeofAssignment
{
    public partial class CoffeeShopListUi : Form
    {
        //initialize list variables
        List<string> customerNameList = new List<string> {}; 
        List<int> customerContactList = new List<int> {};
        List<string> customerAddressList = new List<string> {};
        List<string> orderList = new List<string> {};
        List<int> orderQuantityList = new List<int> {};
        List<int> priceList = new List<int>();
        List<int> totalPriceList = new List<int>();


        public CoffeeShopListUi()
        {
            InitializeComponent();
        }
        //add customer info method
        private void AddCustomer(string name,int contact,string address,string order,int quantity)
        {
            customerNameList.Add(name);          
            customerContactList.Add(contact);
            customerAddressList.Add(address);
            orderList.Add(order);
            orderQuantityList.Add(quantity);

            int orderValue = 0;
            if (order == "black-120")
            {
                orderValue = 120;
            }
            else if (order == "hot-100")
            {
                orderValue = 100;
            }
            else if (order == "cold-90")
            {
                orderValue = 90;
            }
            else
            {
                orderValue = 80;
            }

            totalPriceList.Add(orderValue * quantity);
        }
        
        //add button click
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                int contact = Convert.ToInt32(contactTextBox.Text);
                string address = addressTextBox.Text;
                string order = orderComboBox.Text;
                int quantity = Convert.ToInt32(qualityTextBox.Text);

                //AddCustomer(name,contact,address,order,quantity);

                //if customerContactList variable don't contain same ContactNumber then add  customer 
                if (!customerContactList.Contains(contact) && !String.IsNullOrEmpty(qualityTextBox.Text) &&
                    (order != "select one"))
                {
                    AddCustomer(name, contact, address, order, quantity);
                }
                else
                {
                    if (customerContactList.Contains(contact))
                    {
                        MessageBox.Show("this contact already exist;");
                    }
                    else if (String.IsNullOrEmpty(contactTextBox.Text))
                    {
                        MessageBox.Show("Enter Quantity");
                    }
                    else if (order == "select one")
                    {
                        MessageBox.Show("Please select an order;");
                    }

                    return;

                }

                Reset();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Message");
            }
        }
        
        //Reset method
        private void Reset()
        {
            nameTextBox.Text = " Put Your Name";
            contactTextBox.Text = "Put your contact No ";
            addressTextBox.Text = " give your address";
            orderComboBox.Text = "select one";
            qualityTextBox.Text = "null";
          
        }

        //Save customer info method
        private void SaveCustomerInfo(int listStart, int listEnd)
        {
            //display all info in richTextBox and add new info
            for (int index = listStart; index < listEnd; index++)
            {
                displayRichTextBox.Text += "name : " + customerNameList[index] + "\n";
                displayRichTextBox.Text += "contact: " + customerContactList[index] + "\n";
                displayRichTextBox.Text += "address: " + customerAddressList[index] + "\n";
                displayRichTextBox.Text += "order: " + orderList[index] + "\n";
                displayRichTextBox.Text += "quantity: " + orderQuantityList[index] + "\n";
                displayRichTextBox.Text += "Total Price: " + totalPriceList[index] + "\n\n";
            }
        }
        
        //SaveButton click 
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveCustomerInfo(0, customerNameList.Count);
        }
        
        

       


    
        private void displayRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
