using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        public ItemUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*connection*/
                string connectionString = @"Server=DESKTOP-3OC37E3\SQLEXPRESS;Database=CoffeeShopServerConnectionDatabase;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                /**** show all command *********/
                string commandString = @"SELECT * FROM Items";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                /***** open ******/
                sqlConnection.Open();

                /******** SHOW ALL ********/
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                //showDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }

                /******** close *********/
                sqlConnection.Close();
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            //check price is empty or not
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("price cannot be empty!!!");
                return;
            }
            if (!isNameExists(nameTextBox.Text))
            {
                isAdded = Add(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text));
            }
            else
            {
                MessageBox.Show(nameTextBox.Text + " already Exists");
                return;
            }

   
            if (isAdded == true )
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*connection*/
                string connectionString = @"Server=DESKTOP-3OC37E3\SQLEXPRESS;Database=CoffeeShopServerConnectionDatabase;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                /*Command*/
                //string commandString = @"INSERT INTO Items (Name, Price) Values ('Black', 120)";
                string commandString = @"DELETE FROM Items WHERE ID = " + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                /***** open ******/
                sqlConnection.Open();

                /********* DELETE ********/
                //sqlCommand.ExecuteNonQuery();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }

                /******** close *********/
                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*connection*/
                string connectionString = @"Server=DESKTOP-3OC37E3\SQLEXPRESS;Database=CoffeeShopServerConnectionDatabase;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                /*Command*/
                //string commandString = @"INSERT INTO Items (Name, Price) Values ('Black', 120)";
                string commandString = @"UPDATE Items SET Name =  '" + nameTextBox.Text + "',Price = " + priceTextBox.Text + " WHERE ID = " + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);


                /***** open ******/
                sqlConnection.Open();

                /********* UPDATE ********/
                //sqlCommand.ExecuteNonQuery();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }

                /******** close *********/
                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*connection*/
                string connectionString = @"Server=DESKTOP-3OC37E3\SQLEXPRESS;Database=CoffeeShopServerConnectionDatabase;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                /*Command*/
                //string commandString = @"INSERT INTO Items (Name, Price) Values ('Black', 120)";
                string commandString = @"SELECT * FROM Items WHERE Name = '" + nameTextBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                /***** open ******/
                sqlConnection.Open();

                /******** Search Selected ********/
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                //showDataGridView.DataSource = dataTable;
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    showDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }

                /********* Search ********/
                //sqlCommand.ExecuteNonQuery();


                /******** close *********/
                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private bool isNameExists(string name)
        {
            bool exists = false;
            /**** search button code ****/
            try
            {
                /*connection*/
                string connectionString = @"Server=DESKTOP-3OC37E3\SQLEXPRESS;Database=CoffeeShopServerConnectionDatabase;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                /*Command*/
                //string commandString = @"INSERT INTO Items (Name, Price) Values ('Black', 120)";
                string commandString = @"SELECT * FROM Items WHERE Name = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                /***** open ******/
                sqlConnection.Open();

           
                /******** Search Selected ********/
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();              
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                /******** close *********/
                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            return exists;

        }

        private bool Add(string name,double price)
        {
            bool isAdded = false;
            try
            {
                /*connection*/
                string connectionString = @"Server=DESKTOP-3OC37E3\SQLEXPRESS;Database=CoffeeShopServerConnectionDatabase;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
         
                string commandString = @"INSERT INTO Items (Name, Price) Values ('" + name + "', '" + price + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                /***** open ******/
                sqlConnection.Open();

                {
                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        isAdded = true;
                    }
                }
                //if (!isNameExists(nameTextBox.Text))
                //{
                //    int isExecuted = sqlCommand.ExecuteNonQuery();
                //    if (isExecuted > 0)
                //    {
                //        isAdded = true;
                //    }                    
                //}
                //else
                //{
                //    MessageBox.Show(nameTextBox.Text + " already Exists");
                //}

                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }
    }
}

