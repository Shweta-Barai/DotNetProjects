using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    
    public partial class VehicleUi : Form
    {
        VehicleMetre vehicleMetre = new VehicleMetre();
        List<int> speedList = new List<int>();
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicleMetre.VehicleName = vehicleNameTextBox.Text;
            vehicleMetre.RegNo = Convert.ToInt32(regNoTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            speedList.Add(Convert.ToInt32(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //minSpeedTextBox.Text = speedList.Min().ToString();
            //maxSpeedTextBox.Text = speedList.Max().ToString();
            //averageSpeedTextBox.Text = speedList.Average().ToString();
            int min = speedList[0];
            int max = speedList[0];
            int sum = 0;
            for (int index = 0; index < speedList.Count; index++)
            {
                 
                if (speedList[index] < min)
                {
                    min = speedList[index];
                    
                }

                if (speedList[index] > max)
                {
                    max = speedList[index];
                }

                sum += speedList[index];
                


            }

            minSpeedTextBox.Text = min.ToString();
            maxSpeedTextBox.Text = max.ToString();
            averageSpeedTextBox.Text = (sum / speedList.Count()).ToString();


        }
    }
}
